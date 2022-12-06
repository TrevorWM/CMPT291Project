using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class CustomerScreen : Form
    {

        public SqlConnection MyConnection;
        public SqlCommand MyCommand;
        public SqlDataReader MyReader;

        public CustomerScreen()
        {
            InitializeComponent();

            String ConnectDB = "Server = localhost; Database = TBMRS; Trusted_Connection = Yes;";
            SqlConnection myConnection = new SqlConnection(ConnectDB); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                MyCommand = new SqlCommand();
                MyCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            MyCommand.CommandText = "select CustId, concat(FirstName, LastName) as FullName, Email, PhoneNum, AccType," +
                                    "concat(City, State, ZipCode) as Address, CustRating, AccCreationDate from CustomerTable";
            try
            {
                MyReader = MyCommand.ExecuteReader();

                CustListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    CustListDGV.Rows.Add(MyReader["CustId"].ToString(), MyReader["FullName"].ToString(), MyReader["Email"].ToString(),
                                         MyReader["PhoneNum"].ToString(), MyReader["AccType"].ToString(), MyReader["Address"].ToString(),
                                         MyReader["CustRating"].ToString(), MyReader["AccCreationDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
            
        }

        /// ========================================================================================= /// 

        private void Billing_Info(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Showcard Gothic", 17, FontStyle.Italic);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gold);
            e.Graphics.TranslateTransform(40, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Billing Information", myfont, mybrush, -200, -25);
        }

        private void Customer_Information(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Showcard Gothic", 17, FontStyle.Italic);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gold);
            e.Graphics.TranslateTransform(40, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Customer Information", myfont, mybrush, -200, -25);
        }

        /// ========================================================================================= /// 

        private void AddBTN_Click(object sender, EventArgs e)
        {
            //Generate CustID
            Random rnd = new Random();
            int IDnum = rnd.Next(1000, 9999);
            try
            {
                MyCommand.CommandText = "INSERT into CustomerTable " +
                                        "VALUES ('" + IDnum + "','" + FNameTB.Text + "','" + LNameTB.Text + "','" +
                                                    CityTB.Text + "','" + StateTB.Text + "','" + ZipTB.Text + "','" + 
                                                    TeleTB.Text + "','" + EmailTB.Text + "','" + TypeCB.Text + "','" + 
                                                    CreationDT.Text + "','" + CardTB.Text + "', '0')\n" +
                                        "INSERT INTO CustomerLogin(Username, CustID)\n" +
                                        "VALUES (CONCAT('" + IDnum + "','" + LNameTB.Text + "'),'" + IDnum + "')";

                MessageBox.Show("Adding " + FNameTB.Text + " " + LNameTB.Text + " as a new customer.");
                MyCommand.ExecuteNonQuery();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            //Refresh Table
            MyCommand.CommandText = "select CustId, concat(FirstName, LastName) as FullName, Email, PhoneNum, AccType," +
                                    "concat(City, State, ZipCode) as Address, CustRating, AccCreationDate from CustomerTable";
            try
            {
                MyReader = MyCommand.ExecuteReader();

                CustListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    CustListDGV.Rows.Add(MyReader["CustId"].ToString(), MyReader["FullName"].ToString(), MyReader["Email"].ToString(),
                                         MyReader["PhoneNum"].ToString(), MyReader["AccType"].ToString(), MyReader["Address"].ToString(),
                                         MyReader["CustRating"].ToString(), MyReader["AccCreationDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            //Empty the boxes that has customer info
            FNameTB.Text = String.Empty;
            LNameTB.Text = String.Empty;
            EmailTB.Text = String.Empty;
            TypeCB.SelectedItem = null;
            CreationDT.Text = String.Empty;
            TeleTB.Text = String.Empty;
            CardTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            CustIdTB.Text = String.Empty;
            RatingCB.SelectedItem = null;
            SearchCB.SelectedItem = null;
            SearchTB.Text = String.Empty;

        }

        /// ========================================================================================= /// 

        private void EditBTN_Click(object sender, EventArgs e)
        {
            int counter = 0;
            MyCommand.CommandText = "update CustomerTable set";

            if (String.IsNullOrEmpty(FNameTB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " FirstName = '" + FNameTB.Text + "'";
            }

            if (String.IsNullOrEmpty(LNameTB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " LastName = '" + LNameTB.Text + "'";
            }

            if (String.IsNullOrEmpty(EmailTB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " Email = '" + EmailTB.Text + "'";
            }

            if (String.IsNullOrEmpty(CityTB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " City = '" + CityTB.Text + "'";
            }

            if (String.IsNullOrEmpty(StateTB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " State = '" + StateTB.Text + "'";
            }

            if (String.IsNullOrEmpty(ZipTB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " ZipCode = '" + ZipTB.Text + "'";
            }

            if (String.IsNullOrEmpty(CardTB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " CredCard = '" + CardTB.Text + "'";
            }

            if (String.IsNullOrEmpty(TeleTB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " PhoneNum = '" + TeleTB.Text + "'";
            }

            if (String.IsNullOrEmpty(TypeCB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " AccType = '" + TypeCB.Text + "'";
            }

            
            if (String.IsNullOrEmpty(RatingCB.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    MyCommand.CommandText += ", ";
                MyCommand.CommandText += " CustRating = '" + RatingCB.Text + "'";
            }

            MyCommand.CommandText += " where CustID = '" + CustIdTB.Text + "'";

            MyCommand.CommandText += "\nselect CustId, concat(FirstName, LastName) as FullName, " +
                                    "Email, PhoneNum, AccType, concat(City, State, ZipCode) as Address, " +
                                    "CustRating, AccCreationDate from CustomerTable";
    
            try
            {
                MessageBox.Show("Editing Customer: " + CustIdTB.Text);
                MyReader = MyCommand.ExecuteReader();

                CustListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    CustListDGV.Rows.Add(MyReader["CustId"].ToString(), MyReader["FullName"].ToString(), MyReader["Email"].ToString(),
                                         MyReader["PhoneNum"].ToString(), MyReader["AccType"].ToString(), MyReader["Address"].ToString(),
                                         MyReader["CustRating"].ToString(), MyReader["AccCreationDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            //Empty the boxes that has customer info
            FNameTB.Text = String.Empty;
            LNameTB.Text = String.Empty;
            EmailTB.Text = String.Empty;
            SearchTB.Text = String.Empty;
            CreationDT.Text = String.Empty;
            TeleTB.Text = String.Empty;
            CardTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            CustIdTB.Text = String.Empty;
            RatingCB.SelectedItem = null;
            SearchCB.SelectedItem = null;
            TypeCB.SelectedItem = null;
        }

        /// ========================================================================================= ///

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            MyCommand.CommandText = "delete from CustomerTable where CustID = '" + CustIdTB.Text + "'\n"+
                                    "delete from CustomerLogin where CustID = '" + CustIdTB.Text + "'\n" +
                                    "select CustId, " + "concat(FirstName, LastName) as FullName, Email, PhoneNum, AccType, " +
                                    "concat(City, State, ZipCode) " + "as Address, CustRating, AccCreationDate  from CustomerTable";
            try
            {
                MessageBox.Show("DELETING Customer: " + CustIdTB.Text);
                MyReader = MyCommand.ExecuteReader();

                CustListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    CustListDGV.Rows.Add(MyReader["CustId"].ToString(), MyReader["FullName"].ToString(), MyReader["Email"].ToString(),
                                         MyReader["PhoneNum"].ToString(), MyReader["AccType"].ToString(), MyReader["Address"].ToString(),
                                         MyReader["CustRating"].ToString(), MyReader["AccCreationDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            //Empty the boxes that has customer info
            FNameTB.Text = String.Empty;
            LNameTB.Text = String.Empty;
            EmailTB.Text = String.Empty;
            SearchTB.Text = String.Empty;
            CreationDT.Text = String.Empty;
            TeleTB.Text = String.Empty;
            CardTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            CustIdTB.Text = String.Empty;
            RatingCB.SelectedItem = null;
            SearchCB.SelectedItem = null;
            TypeCB.SelectedItem = null;

        }

        /// ========================================================================================= ///

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            MyCommand.CommandText = "select CustId, concat(FirstName, LastName) as FullName, Email, PhoneNum, AccType," +
                                    "concat(City, State, ZipCode) as Address, CustRating, AccCreationDate from CustomerTable where ";
            
            //SearchCB
            if (SearchCB.Text == "CustID")
                MyCommand.CommandText += " CustID = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Last Name")
                MyCommand.CommandText += " LastName = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "City")
                MyCommand.CommandText += " City = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "State")
                MyCommand.CommandText += " State = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "ZipCode")
                MyCommand.CommandText += " ZipCode = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Phone Number")
                MyCommand.CommandText += " PhoneNum = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Email")
                MyCommand.CommandText += " Email = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Account Type")
                MyCommand.CommandText += " AccType = '" + SearchTB.Text + "'";
            /////
            try
            {
                MessageBox.Show("Searching by " + SearchCB.Text + ":\n" + SearchTB.Text);
                MyReader = MyCommand.ExecuteReader();

                CustListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    CustListDGV.Rows.Add(MyReader["CustId"].ToString(), MyReader["FullName"].ToString(), MyReader["Email"].ToString(),
                                         MyReader["PhoneNum"].ToString(), MyReader["AccType"].ToString(), MyReader["Address"].ToString(),
                                         MyReader["CustRating"].ToString(), MyReader["AccCreationDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        /// ========================================================================================= /// 
        
        private void ResetBTN_Click(object sender, EventArgs e)
        {
            //Refresh Table
            MyCommand.CommandText = "select CustId, concat(FirstName, LastName) as FullName, Email, PhoneNum, AccType," +
                                    "concat(City, State, ZipCode) as Address, CustRating, AccCreationDate from CustomerTable";
            try
            {
                MyReader = MyCommand.ExecuteReader();

                CustListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    CustListDGV.Rows.Add(MyReader["CustId"].ToString(), MyReader["FullName"].ToString(), MyReader["Email"].ToString(),
                                         MyReader["PhoneNum"].ToString(), MyReader["AccType"].ToString(), MyReader["Address"].ToString(),
                                         MyReader["CustRating"].ToString(), MyReader["AccCreationDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            //Empty the boxes that has customer info
            FNameTB.Text = String.Empty;
            LNameTB.Text = String.Empty;
            EmailTB.Text = String.Empty;
            SearchTB.Text = String.Empty;
            CreationDT.Text = String.Empty;
            TeleTB.Text = String.Empty;
            CardTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            CustIdTB.Text = String.Empty;
            RatingCB.SelectedItem = null;
            SearchCB.SelectedItem = null;
            TypeCB.SelectedItem = null;
            
        }

        /// ========================================================================================= ///

        private void reportsMenuItem_Click(object sender, EventArgs e)
        {
            //Move to report screen
            this.Hide();
            ReportingScreen reportScreen = new ReportingScreen();
            reportScreen.Show();

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

        private void LogoLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Move to movie rental screen 
            this.Hide();
            RentalScreen rentScreen = new RentalScreen();
            rentScreen.Show();
        }

        private void SignOutLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Move to Login screen 
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            UserLBL.Text = "Hello " + Login.Fname;
        }

        /// ========================================================================================= /// 

    }
}

