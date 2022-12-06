using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


namespace _291_Project
{
    public partial class EmployeeScreen : Form
    {
        public SqlConnection MyConnection;
        public SqlCommand MyCommand;
        public SqlDataReader MyReader;
        public static String EmpTypeString = "";

        public EmployeeScreen()
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

            MyCommand.CommandText = "select SSN, concat(FirstName, LastName) as FullName, LastName, PhoneNumber," +
                                   "concat(City, State, ZipCode) as Address, HourlyRate, StartDate from EmployeeTable";

            try
            {
                MyReader = MyCommand.ExecuteReader();
                EmpListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    EmpListDGV.Rows.Add(MyReader["SSN"].ToString()[^4..] + MyReader["LastName"].ToString(), MyReader["FullName"].ToString(), 
                                        MyReader["PhoneNumber"].ToString(), MyReader["HourlyRate"].ToString(), MyReader["Address"].ToString(), 
                                        MyReader["StartDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        /// ========================================================================================= /// 

        private void Emp_ImpInfo(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Showcard Gothic", 17, FontStyle.Italic);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gold);
            e.Graphics.TranslateTransform(40, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Important Information", myfont, mybrush, -200, -25);
        }

        private void Emp_Info(object sender, PaintEventArgs e)
        {
            Font myfont = new Font("Showcard Gothic", 17, FontStyle.Italic);
            Brush mybrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gold);
            e.Graphics.TranslateTransform(40, 170);
            e.Graphics.RotateTransform(-90);
            e.Graphics.DrawString("Employee Information", myfont, mybrush, -200, -25);
        }

        /// ========================================================================================= /// 
        
        private void AddBTN_Click(object sender, EventArgs e)
        { 
            try
            {
                MyCommand.CommandText = "INSERT INTO EmployeeTable " +
                                        "VALUES ('" + SocialTB.Text + "','" + FnameTB.Text + "','" + LnameTB.Text + "','" +
                                                    CityTB.Text + "','" + StateTB.Text + "','" + ZipTB.Text + "','" + TeleTB.Text + 
                                                    "','" + StartDateDTP.Text + "','" + HrlyRateTB.Text + "','" + PosCB.Text + "')\n" +
                                        "INSERT INTO EmployeeLogin " +
                                        "VALUES (CONCAT('" + SocialTB.Text.Substring(0,6) + "','" + LnameTB.Text + "'),'" + SocialTB.Text + "')";
                MessageBox.Show("Adding " + FnameTB.Text + " " + LnameTB.Text + " as a new employee.");
                MyCommand.ExecuteNonQuery();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            //Refresh Table
            MyCommand.CommandText = "select SSN, concat(FirstName, LastName) as FullName, LastName, PhoneNumber," +
                                   "concat(City, State, ZipCode) as Address, HourlyRate, StartDate from EmployeeTable";
            try
            {
                MyReader = MyCommand.ExecuteReader();
                EmpListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    EmpListDGV.Rows.Add(MyReader["SSN"].ToString()[^4..] + MyReader["LastName"].ToString(), MyReader["FullName"].ToString(),
                                        MyReader["PhoneNumber"].ToString(), MyReader["HourlyRate"].ToString(), MyReader["Address"].ToString(),
                                        MyReader["StartDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            //Empty the boxes that has customer info
            FnameTB.Text = String.Empty;
            LnameTB.Text = String.Empty;
            HrlyRateTB.Text = String.Empty;
            StartDateDTP.Text = String.Empty;
            SocialTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            EmpIdTB.Text = String.Empty;
            SearchTB.Text = String.Empty;
            TeleTB.Text = String.Empty;
            PosCB.SelectedItem = null;
            SearchCB.SelectedItem = null;


        }

        /// ========================================================================================= /// 

        private void EditBTN_Click(object sender, EventArgs e)
        {
            MyCommand.CommandText = "SELECT EmployeeType " +
                                    "FROM EmployeeTable " +
                                    "WHERE SSN = '" + Login.IDstring + "'";

            SqlDataAdapter EmpTypeAdapter = new SqlDataAdapter(MyCommand);
            DataTable EmpTypeTable = new DataTable();
            EmpTypeAdapter.Fill(EmpTypeTable);

            if (EmpTypeTable.Rows.Count > 0)
            {
                EmpTypeString = EmpTypeTable.Rows[0][0].ToString().Trim();
            }

            if (EmpTypeString == "Manager" || EmpTypeString == "Ass-Man")
            {
                int counter = 0;
                MyCommand.CommandText = "update EmployeeTable set";

                if (String.IsNullOrEmpty(FnameTB.Text) == false)
                {
                    counter += 1;
                    if (counter >= 2)
                        MyCommand.CommandText += ", ";
                    MyCommand.CommandText += " FirstName = '" + FnameTB.Text + "'";
                }

                if (String.IsNullOrEmpty(LnameTB.Text) == false)
                {
                    counter += 1;
                    if (counter >= 2)
                        MyCommand.CommandText += ", ";
                    MyCommand.CommandText += " LastName = '" + LnameTB.Text + "'";
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

                if (String.IsNullOrEmpty(TeleTB.Text) == false)
                {
                    counter += 1;
                    if (counter >= 2)
                        MyCommand.CommandText += ", ";
                    MyCommand.CommandText += " PhoneNumber = '" + TeleTB.Text + "'";

                }

                if (String.IsNullOrEmpty(HrlyRateTB.Text) == false)
                {
                    counter += 1;
                    if (counter >= 2)
                        MyCommand.CommandText += ", ";
                    MyCommand.CommandText += " HourlyRate = '" + HrlyRateTB.Text + "'";
                }

                if (String.IsNullOrEmpty(PosCB.Text) == false)
                {
                    counter += 1;
                    if (counter >= 2)
                        MyCommand.CommandText += ", ";
                    MyCommand.CommandText += " EmployeeType = '" + PosCB.Text + "'";
                }

                MyCommand.CommandText += " where SSN = '" + EmpIdTB.Text + "'";

                MyCommand.CommandText += "\nselect SSN, concat(FirstName, LastName) as FullName, LastName, PhoneNumber," +
                                       "concat(City, State, ZipCode) as Address, HourlyRate, StartDate from EmployeeTable";

                try
                {
                    MessageBox.Show("Editing Employee: " + EmpIdTB.Text);
                    MyReader = MyCommand.ExecuteReader();
                    EmpListDGV.Rows.Clear(); //clear the table first
                    while (MyReader.Read()) //read queries into DataGridView
                    {
                        EmpListDGV.Rows.Add(MyReader["SSN"].ToString()[^4..] + MyReader["LastName"].ToString(), MyReader["FullName"].ToString(),
                                            MyReader["PhoneNumber"].ToString(), MyReader["HourlyRate"].ToString(), MyReader["Address"].ToString(),
                                            MyReader["StartDate"].ToString());
                    }
                    MyReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            else
                MessageBox.Show("Only Managers/Ass-man can Edit Employees");

            //Empty the boxes that has customer info
            FnameTB.Text = String.Empty;
            LnameTB.Text = String.Empty;
            HrlyRateTB.Text = String.Empty;
            StartDateDTP.Text = String.Empty;
            SocialTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            EmpIdTB.Text = String.Empty;
            SearchTB.Text = String.Empty;
            TeleTB.Text = String.Empty;
            PosCB.SelectedItem = null;
            SearchCB.SelectedItem = null;
        }

        /// ========================================================================================= ///

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            MyCommand.CommandText = "SELECT EmployeeType " +
                                    "FROM EmployeeTable " +
                                    "WHERE SSN = '" + Login.IDstring + "'";

            SqlDataAdapter EmpTypeAdapter = new SqlDataAdapter(MyCommand);
            DataTable EmpTypeTable = new DataTable();
            EmpTypeAdapter.Fill(EmpTypeTable);

            if (EmpTypeTable.Rows.Count > 0)
            {
                EmpTypeString = EmpTypeTable.Rows[0][0].ToString().Trim();
            }

            if (EmpTypeString == "Manager")
            {
                MyCommand.CommandText = "delete from EmployeeTable where SSN = '" + EmpIdTB.Text + "'\n" +
                                        "delete from EmployeeLogin where SSN = '" + EmpIdTB.Text + "'\n" +
                                        "select SSN, " + "concat(FirstName, LastName) as FullName, LastName, PhoneNumber," +
                                        "concat(City, State, ZipCode) as Address, HourlyRate, StartDate from EmployeeTable";

                try
                {
                    MessageBox.Show("DELETING Employee: " + EmpIdTB.Text);
                    MyReader = MyCommand.ExecuteReader();
                    EmpListDGV.Rows.Clear(); //clear the table first
                    while (MyReader.Read()) //read queries into DataGridView
                    {
                        EmpListDGV.Rows.Add(MyReader["SSN"].ToString()[^4..] + MyReader["LastName"].ToString(), MyReader["FullName"].ToString(),
                                            MyReader["PhoneNumber"].ToString(), MyReader["HourlyRate"].ToString(), MyReader["Address"].ToString(),
                                            MyReader["StartDate"].ToString());
                    }
                    MyReader.Close();
                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }
            }

            else
                MessageBox.Show("Only Managers can Delete Employees");

            //Empty the boxes that has customer info
            FnameTB.Text = String.Empty;
            LnameTB.Text = String.Empty;
            HrlyRateTB.Text = String.Empty;
            StartDateDTP.Text = String.Empty;
            SocialTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            EmpIdTB.Text = String.Empty;
            SearchTB.Text = String.Empty;
            TeleTB.Text = String.Empty;
            PosCB.SelectedItem = null;
            SearchCB.SelectedItem = null;
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            MyCommand.CommandText = "select SSN, concat(FirstName, LastName) as FullName, LastName, PhoneNumber," +
                                    "concat(City, State, ZipCode) as Address, HourlyRate, StartDate from EmployeeTable where";

            if (SearchCB.Text == "EmpID (SSN)")
                MyCommand.CommandText += " SSN = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Last Name")
                MyCommand.CommandText += " LastName = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "City")
                MyCommand.CommandText += " City = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "State")
                MyCommand.CommandText += " State = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Zip Code")
                MyCommand.CommandText += " ZipCode = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Phone Number")
                MyCommand.CommandText += " PhoneNumber = '" + SearchTB.Text + "'";
            if (SearchCB.Text == "Position")
                MyCommand.CommandText += " EmployeeType = '" + SearchTB.Text + "'";

            try
            {
                MessageBox.Show("Searching by " + SearchCB.Text + ":\n" + SearchTB.Text);
                MyReader = MyCommand.ExecuteReader();
                EmpListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    EmpListDGV.Rows.Add(MyReader["SSN"].ToString()[^4..] + MyReader["LastName"].ToString(), MyReader["FullName"].ToString(),
                                        MyReader["PhoneNumber"].ToString(), MyReader["HourlyRate"].ToString(), MyReader["Address"].ToString(),
                                        MyReader["StartDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        
        }

        /// ========================================================================================= /// 
    
        private void ResetBTN_Click(object sender, EventArgs e)
        {   
            //Refresh Table
            MyCommand.CommandText = "select SSN, concat(FirstName, LastName) as FullName, LastName, PhoneNumber," +
                                    "concat(City, State, ZipCode) as Address, HourlyRate, StartDate from EmployeeTable";

            try
            {
                MyReader = MyCommand.ExecuteReader();
                EmpListDGV.Rows.Clear(); //clear the table first
                while (MyReader.Read()) //read queries into DataGridView
                {
                    EmpListDGV.Rows.Add(MyReader["SSN"].ToString()[^4..] + MyReader["LastName"].ToString(), MyReader["FullName"].ToString(),
                                        MyReader["PhoneNumber"].ToString(), MyReader["HourlyRate"].ToString(), MyReader["Address"].ToString(),
                                        MyReader["StartDate"].ToString());
                }
                MyReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

            //Empty the boxes that has customer info
            FnameTB.Text = String.Empty;
            LnameTB.Text = String.Empty;
            HrlyRateTB.Text = String.Empty;
            StartDateDTP.Text = String.Empty;
            SocialTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            EmpIdTB.Text = String.Empty;
            SearchTB.Text = String.Empty;
            TeleTB.Text = String.Empty;
            PosCB.SelectedItem = null;
            SearchCB.SelectedItem = null;
        }

        /// ========================================================================================= /// 
        
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Move to customer add/edit/delete screen
            this.Hide();
            CustomerScreen custScreen = new CustomerScreen();
            custScreen.Show();

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

        private void reportsMenuItem_Click(object sender, EventArgs e)
        {
            //Move to report screen
            this.Hide();
            ReportingScreen reportScreen = new ReportingScreen();
            reportScreen.Show();

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

        private void EmployeeScreen_Load(object sender, EventArgs e)
        {
            UserLBL.Text = "Hello " + Login.Fname;
        }
    }
}
