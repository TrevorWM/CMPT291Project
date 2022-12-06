using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class ActorScreen : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand; //connect to sql query, anything that enter through here will be on query
        public SqlDataReader myReader; //read the output of the query
        public String Table = "Actor_Table"; //For changing database table
        public ActorScreen()
        {
            InitializeComponent();
            //
            String connectDB = "Server = localhost; Database = TBMRS; Trusted_Connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectDB); // Timeout in seconds
            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
            //Show database on launch
            myCommand.CommandText = "select A.ActorID, concat(FirstName, LastName) as FullName, Gender, DATEDIFF(YEAR, DateofBirth, GETDATE()) as Age, R.Rating from Actor_Table A FULL OUTER JOIN(select A.ActorID, count(S.ActorID) careers, " +
                "cast(count(S.ActorID) AS float)/ cast(4 AS float) * cast(5 AS float) Rating from Actor_Table A, StarringTable S where A.ActorID = S.ActorID group by A.ActorID) R on A.ActorID = R.ActorID; ";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                ActorList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    ActorList.Rows.Add(myReader["ActorID"].ToString(), myReader["FullName"].ToString(), myReader["Gender"].ToString(), myReader["Age"].ToString(), myReader["Rating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            myCommand.CommandText = "select concat( A.FirstName, A.LastName) FullName, M.Title, M.MovieID from StarringTable S, Actor_Table A, MovieTable M where S.ActorID = A.ActorID and S.MovieID = M.MovieID;";
            try
            {
                myReader = myCommand.ExecuteReader();

                CareerList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    CareerList.Rows.Add(myReader["FullName"].ToString(), myReader["Title"].ToString(), myReader["MovieID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }
        //Page Functions
        private void AddA_Click(object sender, EventArgs e)
        {
            //Generate ActorID, format (intial + IDnum) 
            Random rnd = new Random();
            int IDnum = rnd.Next(1000, 9999);
            try
            {
                myCommand.CommandText = "insert into Actor_Table values ('" + ActorFname.Text.Substring(0,1) + ActorLname.Text.Substring(0,1) + 
                    IDnum.ToString() + "','" + ActorFname.Text + "','" + ActorLname.Text + "','" + ActorGender.Text + "','" + ActorAge.Text + "')";
                //MessageBox.Show(myCommand.CommandText);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            //Refresh Table
            myCommand.CommandText = "select A.ActorID, concat(FirstName, LastName) as FullName, Gender, DATEDIFF(YEAR, DateofBirth, GETDATE()) as Age, R.Rating from Actor_Table A FULL OUTER JOIN(select A.ActorID, count(S.ActorID) careers, " +
               "cast(count(S.ActorID) AS float)/ cast(4 AS float) * cast(5 AS float) Rating from Actor_Table A, StarringTable S where A.ActorID = S.ActorID group by A.ActorID) R on A.ActorID = R.ActorID; ";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                ActorList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    ActorList.Rows.Add(myReader["ActorID"].ToString(), myReader["FullName"].ToString(), myReader["Gender"].ToString(),
                        myReader["Age"].ToString(), myReader["Rating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }
        private void Search_Click(object sender, EventArgs e) //search for an actor
        {
            myCommand.CommandText = "select A.ActorID, concat(FirstName, LastName) as FullName, Gender, DATEDIFF(YEAR, DateofBirth, GETDATE()) as Age, R.Rating from Actor_Table A FULL OUTER JOIN(select A.ActorID, count(S.ActorID) careers, " +
               "cast(count(S.ActorID) AS float)/ cast(4 AS float) * cast(5 AS float) Rating from Actor_Table A, StarringTable S where A.ActorID = S.ActorID group by A.ActorID) R on A.ActorID = R.ActorID where ";
            /////Combo box condition (remember single quotation around the string)
            ///SearchBox1
            if (operation.Text == "First Name is:") 
                myCommand.CommandText += " FirstName = '" + SearchText.Text + "'";
            if (operation.Text == "Last Name is:")
                myCommand.CommandText += " LastName = '" + SearchText.Text + "'";
            if (operation.Text == "Gender is:")
                myCommand.CommandText += " Gender = '" + SearchText.Text + "'";
            if (operation.Text == "Age is at least:")
                myCommand.CommandText += " DATEDIFF(YEAR, DateofBirth, GETDATE()) >= " + SearchText.Text;
            if (operation.Text == "Rating is at least:")
                myCommand.CommandText += " R.Rating >=" + SearchText.Text;
            ///SearchBox2
            if (operation2.Text == "First Name is:")
                myCommand.CommandText += " and FirstName = '" + SearchText2.Text + "'";
            if (operation2.Text == "Last Name is:")
                myCommand.CommandText += " and LastName = '" + SearchText2.Text + "'";
            if (operation2.Text == "Gender is:")
                myCommand.CommandText += " and Gender = '" + SearchText2.Text + "'";
            if (operation2.Text == "Age is at least:")
                myCommand.CommandText += " and DATEDIFF(YEAR, DateofBirth, GETDATE()) >= " + SearchText2.Text;
            if (operation2.Text == "Rating is at least:")
                myCommand.CommandText += " and R.Rating >=" + SearchText2.Text;
            ///SearchBox3
            if (operation3.Text == "First Name is:")
                myCommand.CommandText += " and FirstName = '" + SearchText3.Text + "'";
            if (operation3.Text == "Last Name is:")
                myCommand.CommandText += " and LastName = '" + SearchText3.Text + "'";
            if (operation3.Text == "Gender is:")
                myCommand.CommandText += " and Gender = '" + SearchText3.Text + "'";
            if (operation3.Text == "Age is at least:")
                myCommand.CommandText += " and DATEDIFF(YEAR, DateofBirth, GETDATE()) >= " + SearchText3.Text;
            if (operation3.Text == "Rating is at least:")
                myCommand.CommandText += " and R.Rating >=" + SearchText3.Text;
            /////
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                ActorList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    ActorList.Rows.Add(myReader["ActorID"].ToString(), myReader["FullName"].ToString(), myReader["Gender"].ToString(),
                        myReader["Age"].ToString(), myReader["Rating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void DeleteA_Click(object sender, EventArgs e) //delete an actor using ID, should also delete all the actorID in the StarringTable due to ActorID being foreign key
        {
            myCommand.CommandText = "delete from Actor_Table where ActorID = '" + ActID.Text + "'\nselect A.ActorID, concat(FirstName, LastName) as FullName, Gender, DATEDIFF(YEAR, DateofBirth, GETDATE()) as Age, R.Rating from Actor_Table A FULL OUTER JOIN(select A.ActorID, count(S.ActorID) careers, " +
               "cast(count(S.ActorID) AS float)/ cast(4 AS float) * cast(5 AS float) Rating from Actor_Table A, StarringTable S where A.ActorID = S.ActorID group by A.ActorID) R on A.ActorID = R.ActorID; ";
            //first part delete the ID, then refresh the table.
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                ActorList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    ActorList.Rows.Add(myReader["ActorID"].ToString(), myReader["FullName"].ToString(), myReader["Gender"].ToString(),
                        myReader["Age"].ToString(), myReader["Rating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            myCommand.CommandText = "select concat( A.FirstName, A.LastName) FullName, M.Title, M.MovieID from StarringTable S, Actor_Table A, MovieTable M where S.ActorID = A.ActorID and S.MovieID = M.MovieID;";
            try
            {
                myReader = myCommand.ExecuteReader();

                CareerList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    CareerList.Rows.Add(myReader["FullName"].ToString(), myReader["Title"].ToString(), myReader["MovieID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void Update_Click(object sender, EventArgs e) //Update actor information
        {
            int counter = 0;
            myCommand.CommandText = "update " + Table + " set";
            ////what info is updated
            if (String.IsNullOrEmpty(ActorFname.Text) == false)//check if anything is entered into textbox
            {
                counter += 1;
                if (counter >= 2)
                    myCommand.CommandText += ", "; 
                myCommand.CommandText += " FirstName = '" + ActorFname.Text + "'";
            }  
            if (String.IsNullOrEmpty(ActorLname.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    myCommand.CommandText += ", ";
                myCommand.CommandText += " LastName = '" + ActorLname.Text + "'";
            }
            if (String.IsNullOrEmpty(ActorAge.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    myCommand.CommandText += ", ";
                myCommand.CommandText += " DateofBirth = '" + ActorAge.Text + " 00:00:00'";
            }
            if (String.IsNullOrEmpty(ActorGender.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    myCommand.CommandText += ", ";
                myCommand.CommandText += " Gender = '" + ActorGender.Text + "'";
            }
            myCommand.CommandText += " where ActorID = '" + ActID.Text + "'";

            ///refresh the table
            myCommand.CommandText += "\nselect A.ActorID, concat(FirstName, LastName) as FullName, Gender, DATEDIFF(YEAR, DateofBirth, GETDATE()) as Age, cast(career as float) / cast(movies as float) * 5 Rating " +
                "from Actor_Table A, (select count(MovieID) movies from MovieTable) M, (select S.ActorID, count(ActorID) career from StarringTable S group by S.ActorID) C where A.ActorID = C.ActorID;"; ;
            try
            {
                myReader = myCommand.ExecuteReader();

                ActorList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    ActorList.Rows.Add(myReader["ActorID"].ToString(), myReader["FullName"].ToString(), myReader["Gender"].ToString(),
                        myReader["Age"].ToString(), myReader["Rating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }
        private void AddCareer_Click(object sender, EventArgs e) //set relation between actor and movie
        {
            myCommand.CommandText = "insert into StarringTable (ActorID, MovieID) values('" + ActorID2.Text + "','" + Movie_ID.Text + "'); " +
                "\nselect concat( A.FirstName, A.LastName) FullName, M.Title, M.MovieID from StarringTable S, Actor_Table A, MovieTable M where S.ActorID = A.ActorID and S.MovieID = M.MovieID;";
            try
            {
                myReader = myCommand.ExecuteReader();

                CareerList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    CareerList.Rows.Add(myReader["FullName"].ToString(), myReader["Title"].ToString(), myReader["MovieID"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
            myCommand.CommandText = "select A.ActorID, concat(FirstName, LastName) as FullName, Gender, DATEDIFF(YEAR, DateofBirth, GETDATE()) as Age, R.Rating from Actor_Table A FULL OUTER JOIN(select A.ActorID, count(S.ActorID) careers, " +
               "cast(count(S.ActorID) AS float)/ cast(4 AS float) * cast(5 AS float) Rating from Actor_Table A, StarringTable S where A.ActorID = S.ActorID group by A.ActorID) R on A.ActorID = R.ActorID; ";
            try
            {
                myReader = myCommand.ExecuteReader();

                ActorList.Rows.Clear(); //clear the table first
                while (myReader.Read()) //read queries into DataGridView
                {
                    ActorList.Rows.Add(myReader["ActorID"].ToString(), myReader["FullName"].ToString(), myReader["Gender"].ToString(), myReader["Age"].ToString(), myReader["Rating"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }
        //Page transfer
        private void LogoLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //on click, return to home screen
        {
            this.Hide();
            RentalScreen rentalScreen = new RentalScreen();
            rentalScreen.Show();
        }
        private void SignoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //return to login screen
        {
            this.Hide();
            Login loginScreen = new Login();
            loginScreen.Show();
        }
        private void reportToolStripMenuItem_Click(object sender, EventArgs e)//open report page
        {
            this.Hide();
            ReportingScreen reportingScreen = new ReportingScreen();
            reportingScreen.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)//open customer edit
        {
            this.Hide();
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)//open employee edit
        {
            this.Hide();
            EmployeeScreen employeeScreen = new EmployeeScreen();
            employeeScreen.Show();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)//open movie edit
        {
            this.Hide();
            MovieScrn movieScreen = new MovieScrn();
            movieScreen.Show();
        }

        private void SearchM_Click(object sender, EventArgs e)
        {
            MovieScrn movieScreen = new MovieScrn();
            movieScreen.Show();
        }
        private void ActorScreen_Load(object sender, EventArgs e)
        {
            UserLBL.Text = "Hello " + Login.Fname;
        }


    }
}
