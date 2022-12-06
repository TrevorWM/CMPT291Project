using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class AccountScreen : Form
    {

        public SqlConnection MyConnection;
        public SqlCommand MyCommand;
        public SqlDataReader MyReader;
        public AccountScreen()
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
        }

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

            MyCommand.CommandText += "WHERE CustID = '" + Login.IDstring + "'";

            MyCommand.ExecuteNonQuery();
            MessageBox.Show("Account Information has been updated!\nThank you for using TBMRS");

            //Empty the boxes that has customer info
            FNameTB.Text = String.Empty;
            LNameTB.Text = String.Empty;
            EmailTB.Text = String.Empty;
            TeleTB.Text = String.Empty;
            CardTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            TypeCB.SelectedItem = null;
        }

        private void SignOutLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Move to Login screen 
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void LogoLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Move to movie rental screen 
            this.Hide();
            RentalScreen rentScreen = new RentalScreen();
            rentScreen.Show();
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            //Empty the boxes that has customer info
            FNameTB.Text = String.Empty;
            LNameTB.Text = String.Empty;
            EmailTB.Text = String.Empty;
            TeleTB.Text = String.Empty;
            CardTB.Text = String.Empty;
            CityTB.Text = String.Empty;
            StateTB.Text = String.Empty;
            ZipTB.Text = String.Empty;
            TypeCB.SelectedItem = null;
        }

        private void AccountScreen_Load(object sender, EventArgs e)
        {
            UserLBL.Text = "Hello " + Login.Fname;
        }
    }
}
