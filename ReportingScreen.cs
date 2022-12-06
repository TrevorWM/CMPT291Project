using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class ReportingScreen : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public ReportingScreen()
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

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Move to customer add/edit/delete screen
            this.Hide();
            CustomerScreen custScreen = new CustomerScreen();
            custScreen.Show();

        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Move to employee add/edit/delete screen
            this.Hide();
            EmployeeScreen empScreen = new EmployeeScreen();
            empScreen.Show();

        }

        private void actorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Move to actor add/edit/delete screen
            this.Hide();
            ActorScreen actorScreen = new ActorScreen();
            actorScreen.Show();

        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Move to movies add/edit/delete screen
            this.Hide();
            MovieScrn movieScreen = new MovieScrn();
            movieScreen.Show();
        }

        private void genSalesReportButton_Click(object sender, EventArgs e)
        {
            string monthOffset = dateTimeSalesReport.Value.AddMonths(1).ToString("yyyy-MM");
            monthOffset = ("'" + monthOffset + "-01'");

            string selectedDate = dateTimeSalesReport.Value.ToString("MMMM");

            MessageBox.Show("Month is: " + selectedDate);

            myCommand.CommandText = "SELECT AccType, AccType*numAccounts AS Revenue \n" +
                                    "FROM( SELECT AccType, COUNT(AccType) as numAccounts \n" +
                                    "FROM CustomerTable \n" +
                                    "WHERE AccCreationDate < " + monthOffset + "\n" +
                                    "GROUP BY AccType) as totalAccounts";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridSalesReport.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads the database Account Type and total revenue for each account type into data grid*/
                    dataGridSalesReport.Rows.Add(myReader["AccType"].ToString(), myReader["Revenue"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void LoadCurOrders()
        {

            //Get the current date time then add single quotes to it for use in SQL
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            currentDate = "'" + currentDate + "'";

            myCommand.CommandText = "SELECT FullName, Title, COUNT(Title) as Amount, DropOFF \n" +
                                    "FROM \n" +
                                    "(SELECT FirstName+LastName as FullName, Title, DropOFF \n"+
                                    "FROM OrderTable as O, CustomerTable as C, MovieTable as M \n" +
                                    "WHERE C.CustID = O.CustID AND M.MovieID = O.MovieID \n" +
                                    "AND PickUP <= " + currentDate + " AND " + currentDate +" <= DropOFF) \n"+
                                    "as MoviesRented \n"+
                                    "GROUP BY FullName, Title, DropOFF \n" +
                                    "ORDER BY FullName \n";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridCurOrders.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads customer names, movie title, amount currently rented out by them, and the return dates.*/
                    dataGridCurOrders.Rows.Add(myReader["FullName"].ToString(), myReader["Title"].ToString(),
                        myReader["Amount"].ToString(), myReader["DropOFF"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void LoadAllOrders()
        {
            //Get the current date time then add single quotes to it for use in SQL
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            currentDate = "'" + currentDate + "'";

            myCommand.CommandText = "SELECT FullName, Title, COUNT(Title) as Amount, OrderDate, PickUP, DropOFF \n" +
                                    "FROM \n" +
                                    "(SELECT FirstName+LastName as FullName, Title, OrderDate, PickUP, DropOFF \n" +
                                    "FROM OrderTable as O, CustomerTable as C, MovieTable as M \n" +
                                    "WHERE C.CustID = O.CustID AND M.MovieID = O.MovieID \n" +
                                    "AND OrderDate < " + currentDate + ")\n" +
                                    "as MoviesRented \n" +
                                    "GROUP BY FullName, Title, OrderDate, PickUP, DropOFF \n" +
                                    "ORDER BY FullName \n";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridAllOrders.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads customer names, movie title, amount currently rented out by them, and the return dates.*/
                    dataGridAllOrders.Rows.Add(myReader["FullName"].ToString(), myReader["Title"].ToString(),
                        myReader["Amount"].ToString(), myReader["OrderDate"].ToString(), myReader["PickUP"].ToString(),myReader["DropOFF"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void LoadRatedMovies()
        { 

            myCommand.CommandText = "SELECT Title, Genre, count(R.MovieID) as Amount, avg(R.Rating) as movieRating \n" +
                                    "FROM MovieTable as M, RatingTable as R \n" +
                                    "WHERE M.MovieID = R.MovieID " +
                                    "GROUP BY Title, Genre " +
                                    "ORDER BY movieRating DESC";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridHighRating.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    dataGridHighRating.Rows.Add(myReader["Title"].ToString(), myReader["Genre"].ToString(),
                        myReader["movieRating"].ToString(), myReader["Amount"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void LoadCustomerList()
        {
            myCommand.CommandText = "SELECT CustID, FirstName + LastName as FullName, AccType, CustRating \n" +
                                    "FROM CustomerTable\n";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridCustList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    dataGridCustList.Rows.Add(myReader["CustID"], myReader["FullName"].ToString(), myReader["AccType"].ToString(),
                        myReader["CustRating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void LoadMailingList()
        {
            //Get the current date time then add single quotes to it for use in SQL
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            currentDate = "'" + currentDate + "'";

            myCommand.CommandText = "SELECT (FirstName+LastName) as FullName, Email, (City+State+ZipCode) as Address, Title, PickUP, OrderDate \n" +
                                    "FROM CustomerTable as C, OrderTable as O, MovieTable as M \n" +
                                    "WHERE C.CustID = O.CustID AND M.MovieID = O.MovieID \n" +
                                    "AND PickUP <= " + currentDate + " AND OrderDate <= " + currentDate + " \n" +
                                    "ORDER BY OrderDate ASC";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridMailList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    dataGridMailList.Rows.Add(myReader["FullName"], myReader["Email"].ToString(), myReader["Address"].ToString(),
                        myReader["Title"].ToString(), myReader["PickUP"].ToString(), myReader["OrderDate"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void LoadActiveEmp()
        {
            myCommand.CommandText = "SELECT FirstName + LastName as EmployeeName, COUNT(O.SSN) as Orders \n" +
                                    "FROM OrderTable AS O, EmployeeTable AS E \n" +
                                    "WHERE O.SSN = E.SSN \n" +
                                    "GROUP BY FirstName, LastName \n" +
                                    "ORDER BY Orders DESC \n";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                dataGridMostActiveEmp.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    /*Reads movie title, genre, rating, and the total times the movie has been rented to data grid*/
                    dataGridMostActiveEmp.Rows.Add(myReader["EmployeeName"], myReader["Orders"]);
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void ReportingScreen_Load(object sender, EventArgs e)
        {
            UserLBL.Text = "Hello " + Login.Fname;
            LoadActiveEmp();
            LoadAllOrders();
            LoadCurOrders();
            LoadCustomerList();
            LoadMailingList();
            LoadRatedMovies();
        }

        private void SignOutLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Move to Login screen 
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
  
            
}
