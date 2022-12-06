using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class RentalScreen : Form
    {

        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public static String AccTypeString = "";
        public static String MovRentedString = "";
        public static String CopiesString = "";
        public static int CopiesInt = 0;
        public static String MovieIDString = "";
        public static String RatingString = "";

        public RentalScreen()
        {
            InitializeComponent();

            String connectionString = "Server = localhost; Database = TBMRS; Trusted_Connection = yes;";
            //String to keep thing tidy, for local use.
            myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; //links command to connection
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// ========================================================================================= ///
        
        private void AccountLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Move to customer account screen
            this.Hide();
            AccountScreen accountScreen = new AccountScreen();
            accountScreen.Show();
        }

        private void SignOutLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Move to Login screen 
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        /// ========================================================================================= ///

        private void RentBTN_Click(object sender, EventArgs e)
        {
            string pickUpDay = PickupDTP.Value.ToString("yyyy-MM-dd");
            string dropOffDay = PickupDTP.Value.AddDays(7).ToString("yyyy-MM-dd");

            string pickUpMonth = PickupDTP.Value.ToString("yyyy-MM-01");
            string dropOffMonth = PickupDTP.Value.AddMonths(1).ToString("yyyy-MM-01");

            string movieTitle = MovTitleRentTB.Text.ToString();
            //---------------------------------------------------------------------------

            // Handle limited accounts
            if (getAccountType() == 10 && getMoviesRentedThisMonth(pickUpMonth, dropOffMonth) < 2)
            {
                MessageBox.Show("Limited Account");
                MessageBox.Show("you've rented " + getMoviesRentedThisMonth(pickUpMonth, dropOffMonth).ToString() + " movies this month.");
                MessageBox.Show("Movie Title: " + movieTitle + ", ID: " + getMovieID(movieTitle) + ".");
                MessageBox.Show("You currently have " + getNumCurrentlyRentedMovies(pickUpDay, dropOffDay).ToString() + "movies rented out.");

                // check to make sure you can't take 2 movies out at the same time
                if (getNumCurrentlyRentedMovies(pickUpDay, dropOffDay) > 0)
                {
                    pickUpDay = getLastOrderDropOff(pickUpDay);
                    createQueueEntry(getMovieID(movieTitle), pickUpDay);
                    MessageBox.Show("You already have a movie rented out during this time. \nMovie has been added to your queue.");

                }
                else
                {
                    createOrderEntry(pickUpDay, dropOffDay, getMovieID(movieTitle));
                    MessageBox.Show("Order Added");
                }

            }
            else if (getAccountType() == 10 && getMoviesRentedThisMonth(pickUpMonth, dropOffMonth) > 1)
            {
                MessageBox.Show("You've reached your movie limit for the month!");
            }

            // Handle Unlimited Accounts
            if (getAccountType() == 15)
            {
                MessageBox.Show("You've rented " + getMoviesRentedThisMonth(pickUpMonth, dropOffMonth).ToString() + " movies this month.");
                MessageBox.Show("You currently have " + getNumCurrentlyRentedMovies(pickUpDay, dropOffDay).ToString() + "movies rented out.");

                if (getNumCurrentlyRentedMovies(pickUpDay, dropOffDay) > 0)
                {
                    pickUpDay = getLastOrderDropOff(pickUpDay);
                    createQueueEntry(getMovieID(movieTitle), pickUpDay);
                    MessageBox.Show("You already have a movie rented. Added order to queue.");

                }
                else
                {
                    createOrderEntry(pickUpDay, dropOffDay, getMovieID(movieTitle));
                    MessageBox.Show("Order Added");
                }
            }
            else if (getAccountType() == 20)
            {

                MessageBox.Show("You've rented " + getMoviesRentedThisMonth(pickUpMonth, dropOffMonth).ToString() + " movies this month.");
                MessageBox.Show("You currently have " + getNumCurrentlyRentedMovies(pickUpDay, dropOffDay).ToString() + "movies rented out.");

                if (getNumCurrentlyRentedMovies(pickUpDay, dropOffDay) > 1)
                {
                    pickUpDay = getLastOrderDropOff(pickUpDay);
                    createQueueEntry(getMovieID(movieTitle), pickUpDay);
                    MessageBox.Show("You already have a movie rented. Added order to queue.");

                }
                else
                {
                    createOrderEntry(pickUpDay, dropOffDay, getMovieID(movieTitle));
                    MessageBox.Show("Order Added");
                }

            }
            else if (getAccountType() == 25)
            {
                MessageBox.Show("You've rented " + getMoviesRentedThisMonth(pickUpMonth, dropOffMonth).ToString() + " movies this month.");
                MessageBox.Show("You currently have " + getNumCurrentlyRentedMovies(pickUpDay, dropOffDay).ToString() + "movies rented out.");

                if (getNumCurrentlyRentedMovies(pickUpDay, dropOffDay) > 2)
                {
                    pickUpDay = getLastOrderDropOff(pickUpDay);
                    createQueueEntry(getMovieID(movieTitle), pickUpDay);
                    MessageBox.Show("You already have a movie rented. Added order to queue.");

                }
                else
                {
                    createOrderEntry(pickUpDay, dropOffDay, getMovieID(movieTitle));
                    MessageBox.Show("Order Added");
                }

            }

            MovTitleRentTB.Text = String.Empty;
            LoadCurrentlyRentedDGV();
            LoaddataGridOrderHistory();
            LoadQueueDGV();
            LoadRecommendationDGV();
            LoadAvailMovDGV();

        }

        /// ========================================================================================= ///

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "SELECT Title, Genre, Copies, RentalFee\n" +
                                    "FROM MovieTable M\n" +
                                    "LEFT JOIN StarringTable as S\n" +
                                    "ON M.MovieID = S.MovieID\n" +
                                    "LEFT JOIN Actor_Table as A\n" +
                                    "ON S.ActorID = A.ActorID\n" +
                                    "WHERE Copies > 0\n";

            if (SearchCB.Text == "Movie Title")
                myCommand.CommandText += "AND Title = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Actor Name (Full name)")
            {
                string[] acName = SearchTB.Text.Split(' ');
                myCommand.CommandText += "AND A.FirstName = '" + acName[0] + "'\nAND A.LastName = '" + acName[1] + "'";
            }

            if (SearchCB.Text == "Genre")
                myCommand.CommandText += "AND Genre = '" + SearchTB.Text + "'";

            try
            {
                //MessageBox.Show("Searching by " + SearchCB.Text + ":\n" + SearchTB.Text);
                myReader = myCommand.ExecuteReader();
                AvailMovDGV.Rows.Clear();

                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    AvailMovDGV.Rows.Add(myReader["Title"], myReader["Genre"], myReader["Copies"], myReader["RentalFee"]);
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// ========================================================================================= ///
       
        private void RandRBTN_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "SELECT MovieID, Copies " +
                                    "FROM MovieTable " +
                                    "WHERE Title = '" + MovTitleTB.Text + "'";

            SqlDataAdapter copiesAdapter = new SqlDataAdapter(myCommand);
            DataTable copiesTable = new DataTable();
            copiesAdapter.Fill(copiesTable);

            if (copiesTable.Rows.Count > 0)
            {
                MovieIDString = copiesTable.Rows[0][0].ToString();
                CopiesString = copiesTable.Rows[0][1].ToString();
            }

            CopiesInt = int.Parse(CopiesString);
            myCommand.CommandText = "UPDATE MovieTable SET Copies = '" + (CopiesInt + 1) + "' " +
                                    "WHERE Title = '" + MovTitleTB.Text + "'";
            myCommand.ExecuteNonQuery();

            myCommand.CommandText = "INSERT into RatingTable " +
                                    "VALUES ('" + MovieIDString + "','" + RatingCB.Text + "')";
            myCommand.ExecuteNonQuery();

            MovTitleTB.Text = String.Empty;
            RatingCB.SelectedItem = null;
        }

        /// ========================================================================================= ///

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            LoadAvailMovDGV();
            SearchCB.SelectedItem = null;
            SearchTB.Text = String.Empty;

        }

        /// ========================================================================================= ///

        private void LoadQueueDGV()
        {
            myCommand.CommandText = "SELECT Title, Genre, RentalFee, PickUP \n" +
                           "FROM QueueTable as Q, MovieTable as M \n" +
                           "WHERE Q.MovieID = M.MovieID AND Q.CustID = '"
                           + Login.IDstring + "' AND GETDATE() < PickUP";

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                QueueDGV.Rows.Clear();

                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    QueueDGV.Rows.Add(myReader["Title"], myReader["Genre"], myReader["RentalFee"], myReader["PickUP"]);
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// ========================================================================================= ///

        private void LoaddataGridOrderHistory()
        {
            myCommand.CommandText = "SELECT OrderID, Title, RentalFee, DropOFF, PickUP \n" +
                                    "FROM CustomerTable as C, OrderTable as O, MovieTable as M \n" +
                                    "WHERE C.CustID = '" + Login.IDstring + "' AND O.CustID = '" + Login.IDstring + "' AND O.MovieID = M.MovieID \n";

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                dataGridOrderHistory.Rows.Clear();

                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    dataGridOrderHistory.Rows.Add(myReader["OrderID"], myReader["Title"], myReader["RentalFee"], myReader["DropOFF"], myReader["PickUP"]);
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// ========================================================================================= ///

        private void LoadCurrentlyRentedDGV()
        {
            myCommand.CommandText = "SELECT Title, DropOFF, PickUP \n" +
                                    "FROM OrderTable as O, MovieTable as M \n" +
                                    "WHERE O.CustID =  '" + Login.IDstring + "' AND O.MovieID = M.MovieID \n" +
                                    "AND DropOFF >= GETDATE() AND PickUP <= GETDATE()";

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                CurrentlyRentedDGV.Rows.Clear();

                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    CurrentlyRentedDGV.Rows.Add(myReader["Title"], myReader["PickUP"], myReader["DropOFF"]);
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// ========================================================================================= ///

        private void LoadRecommendationDGV()
        {
            myCommand.CommandText = "SELECT M.Title\n" +
                                    "FROM MovieTable M, OrderTable O, CustomerTable C, (SELECT SUBSTRING(ZipCode, 1 , 6) " +
                                    "Zip from CustomerTable C where C.CustID = '" + Login.IDstring + "') as Z \n" +
                                    "WHERE O.MovieID = M.MovieID and O.CustID = C.CustID and C.ZipCode LIKE Zip + '%' and GETDATE() > O.DropOFF";

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                RecommendationDGV.Rows.Clear();

                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    RecommendationDGV.Rows.Add(myReader["Title"]);
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// ========================================================================================= ///

        private void LoadAvailMovDGV()
        {
            myCommand.CommandText = "SELECT Title, Genre, Copies, RentalFee, R.Rating " +
                                    "FROM MovieTable M " +
                                    "FULL OUTER JOIN " +
                                    "(SELECT MovieID, avg(Rating) as Rating " +
                                    "FROM RatingTable " +
                                    "GROUP BY MovieID) as R " +
                                    "ON M.MovieID = R.MovieID " +
                                    "WHERE Copies > 0 ";

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                AvailMovDGV.Rows.Clear();

                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    AvailMovDGV.Rows.Add(myReader["Title"], myReader["Genre"], myReader["Copies"], myReader["RentalFee"], myReader["Rating"]);
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// ========================================================================================= ///

        private int getAccountType()
        {
            int accType;
            myCommand.CommandText = "SELECT AccType \n" +
                                    "FROM CustomerTable \n" +
                                    "WHERE CustID = '" + Login.IDstring + "' \n";

            SqlDataAdapter accTypeAdapter = new SqlDataAdapter(myCommand);
            DataTable accTypeTable = new DataTable();
            accTypeAdapter.Fill(accTypeTable);

            accType = int.Parse(accTypeTable.Rows[0][0].ToString());

            return accType;
        }

        /// ========================================================================================= ///

        private int getMoviesRentedThisMonth(string pickUpMonth, string dropOffMonth)
        {
            int moviesRented;

            myCommand.CommandText = "SELECT COUNT(*) as MoviesRentedThisMonth \n" +
                                    "FROM \n" +
                                    "(SELECT FullName, Title, OrderDate, PickUP, DropOFF \n" +
                                    "FROM \n" +
                                    "(SELECT FirstName+LastName as FullName, Title, OrderDate, PickUP, DropOFF \n" +
                                    "FROM OrderTable as O, CustomerTable as C, MovieTable as M \n" +
                                    "WHERE C.CustID = O.CustID AND M.MovieID = O.MovieID AND C.CustID = '" + Login.IDstring + "' \n" +
                                    "AND PickUP >= '" + pickUpMonth + "' AND DropOFF < '" + dropOffMonth + "') as MoviesRented \n" +
                                    "GROUP BY FullName, Title, OrderDate, PickUP, DropOFF) as Orders \n";

            SqlDataAdapter moviesRentedThisMonthAdapter = new SqlDataAdapter(myCommand);
            DataTable moviesRentedThisMonthTable = new DataTable();
            moviesRentedThisMonthAdapter.Fill(moviesRentedThisMonthTable);

            moviesRented = int.Parse(moviesRentedThisMonthTable.Rows[0][0].ToString());

            return moviesRented;
        }


        /// ========================================================================================= ///

        private int getMovieID(string movieTitle)
        {
            int movieID;
            myCommand.CommandText = "SELECT MovieID \n" +
                                    "FROM MovieTable \n" +
                                    "WHERE Title = '" + movieTitle + "'";

            SqlDataAdapter getMovieIDAdapter = new SqlDataAdapter(myCommand);
            DataTable getMovieIDTable = new DataTable();
            getMovieIDAdapter.Fill(getMovieIDTable);

            if (getMovieIDTable.Rows.Count > 0)
            {
                movieID = int.Parse(getMovieIDTable.Rows[0][0].ToString());
            }
            else
            {
                movieID = 0;
            }


            return movieID;
        }


        /// ========================================================================================= ///

        private string getLastOrderDropOff(string pickUpDay)
        {
            myCommand.CommandText = "SELECT MAX(DropOFF) as LastDropOff \n" +
                                    "FROM OrderTable \n" +
                                    "WHERE CustID = '" + Login.IDstring + "'";

            SqlDataAdapter getLastOrderAdapter = new SqlDataAdapter(myCommand);
            DataTable getLastOrderTable = new DataTable();
            getLastOrderAdapter.Fill(getLastOrderTable);

            if (getLastOrderTable.Rows[0][0] != null)
            {
                return DateTime.Parse(getLastOrderTable.Rows[0][0].ToString()).ToString("yyyy-MM-dd");
            }
            else
            {
                return pickUpDay;
            }
        }


        /// ========================================================================================= ///

        private int getNumCurrentlyRentedMovies(string pickUpDay, string dropOffDay)
        {
            int moviesRented;

            myCommand.CommandText = "SELECT COUNT(*) as MoviesRented \n" +
                                    "FROM \n" +
                                    "(SELECT Title, Genre, PickUP, DropOFF \n" +
                                    "FROM MovieTable as M, OrderTable as O \n" +
                                    "WHERE M.MovieID = O.MovieID AND O.CustID = '" + Login.IDstring + "' \n" +
                                    "AND DropOFF >= '" + pickUpDay + "' AND PickUP <= '" + dropOffDay + "') as Rented \n";

            SqlDataAdapter moviesCurrentlyRentedAdapter = new SqlDataAdapter(myCommand);
            DataTable moviesCurrentlyRentedTable = new DataTable();
            moviesCurrentlyRentedAdapter.Fill(moviesCurrentlyRentedTable);

            moviesRented = int.Parse(moviesCurrentlyRentedTable.Rows[0][0].ToString());

            return moviesRented;
        }


        /// ========================================================================================= ///

        private void createOrderEntry(string pickUpDate, string dropOffDate, int movieID)
        {
            try
            {
                myCommand.CommandText = "INSERT INTO OrderTable (OrderID, CustID, MovieID, SSN, OrderDate, PickUP, DropOFF) \n" +
                                    "VALUES((SELECT MAX(OrderID) + 1 as newOrderNum FROM OrderTable), " +
                                    "'" + Login.IDstring + "', " + movieID + ", (SELECT TOP 1 SSN FROM EmployeeTable ORDER BY NEWID()), \n" +
                                    "GETDATE(), '" + pickUpDate + "', '" + dropOffDate + "') \n" +
                                    "\n" +
                                    "UPDATE MovieTable \n" +
                                    "SET Copies = Copies-1 \n" +
                                    "WHERE MovieID = " + movieID + "\n";

                myCommand.ExecuteNonQuery();

            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            return;
        }


        /// ========================================================================================= ///

        private void createQueueEntry(int movieID, string pickUpDate)
        {
            string newPickUp = DateTime.Parse(pickUpDate).AddDays(1).ToString();
            try
            {
                myCommand.CommandText = "INSERT INTO QueueTable (MovieID, CustID, PickUP) \n" +
                                    "VALUES(" + movieID + ", " + Login.IDstring + ", '" + newPickUp + "' ) \n";

                myCommand.ExecuteNonQuery();

            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            return;
        }

        /// ========================================================================================= ///


        private void RentalScreen_Load(object sender, EventArgs e)
        {
            AccountLnk.Text = "Hello " + Login.Fname;
            LoadCurrentlyRentedDGV();
            LoaddataGridOrderHistory();
            LoadQueueDGV();
            LoadRecommendationDGV();
            LoadAvailMovDGV();
            
        }
    }
}
