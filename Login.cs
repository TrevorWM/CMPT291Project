using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class Login : Form
    {

        public SqlConnection MyConnection;
        public SqlCommand MyCommand;
        public SqlDataReader MyReader;
        public static String IDstring = "";
        public static String Fname = "";

        public Login()
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

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustLoginBTN_Click(object sender, EventArgs e)
        {
            MyCommand.CommandText = "SELECT Username, CustID " +
                                    "FROM CustomerLogin " +
                                    "WHERE Username = '" + UnameTB.Text + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(MyCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                
                MessageBox.Show("Welcome to TBMRS!\nThe best movie rental system!");
                IDstring = dataTable.Rows[0][1].ToString();
                this.Hide();
                RentalScreen rentScreen = new RentalScreen();
                rentScreen.Show();               
            }

            MyCommand.CommandText = "SELECT FirstName " +
                                    "FROM CustomerTable " +
                                    "WHERE CustID = '" + IDstring + "'";

            SqlDataAdapter nameAdapter = new SqlDataAdapter(MyCommand);
            DataTable nameTable = new DataTable();
            nameAdapter.Fill(nameTable);

            if (nameTable.Rows.Count > 0)
            {
                Fname = nameTable.Rows[0][0].ToString();
            }
        }

        private void EmpLoginBTN_Click(object sender, EventArgs e)
        {
            MyCommand.CommandText = "SELECT Username, SSN " +
                                    "FROM EmployeeLogin " +
                                    "WHERE Username = '" + UnameTB.Text + "'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(MyCommand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Welcome to TBMRS!\nThe best movie rental system!");
                IDstring = dataTable.Rows[0][1].ToString();
                this.Hide();
                EmployeeScreen empScreen = new EmployeeScreen();
                empScreen.Show();
            }

            MyCommand.CommandText = "SELECT FirstName " +
                                    "FROM EmployeeTable " +
                                    "WHERE SSN = '" + IDstring + "'";

            SqlDataAdapter nameAdapter = new SqlDataAdapter(MyCommand);
            DataTable nameTable = new DataTable();
            nameAdapter.Fill(nameTable);

            if (nameTable.Rows.Count > 0)
            {
                Fname = nameTable.Rows[0][0].ToString();
            }
        }

    }
}
