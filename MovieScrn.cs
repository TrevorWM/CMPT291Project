using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _291_Project
{
    public partial class MovieScrn : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public MovieScrn()
        {
            InitializeComponent();
            String connectionString = "Server = localhost; Database = TBMRS; Trusted_Connection = Yes;";
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

        private void SignOutLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Move to Login screen 
            this.Hide();
            Login login = new Login();
            login.Show();
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

        private void reportsMenuItem_Click(object sender, EventArgs e)
        {
            //Move to report screen
            this.Hide();
            ReportingScreen reportScreen = new ReportingScreen();
            reportScreen.Show();

        }

        private void submitp1_btn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int MovieID = rnd.Next(1000, 99999);
            try
            {
                myCommand.CommandText = "insert into MovieTable values ('" + MovieID + "','" + movieNinput.Text + "','" + MovieTypeList.SelectedItem + "'," + int.Parse(fee_input.Text) + "," + int.Parse(copies_inp.Text) + ")";
                MessageBox.Show("Adding " + movieNinput.Text + " as a new movie");
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
      
            this.Hide();
            ActorScreen actorScreen = new ActorScreen();
            actorScreen.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            myCommand.CommandText = "Select Title from MovieTable where MovieID =" + int.Parse(richTextBox1.Text) + ";";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader.HasRows)
                {
                    MessageBox.Show("Movie Deleted --> " + myReader["Title"]);
                    richTextBox2.Text = myReader["Title"].ToString();
                }
                else if (myReader.HasRows == false)
                {
                    MessageBox.Show("Movie does not exist!");
                }

            }
            myReader.Close();

            myCommand.CommandText = "DELETE FROM MovieTable where MovieID = '" + int.Parse(richTextBox1.Text) + "'";
            myCommand.ExecuteNonQuery();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "Select Title from MovieTable where MovieID =" + int.Parse(textBox5.Text) + ";";
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                MessageBox.Show("Movie Selected --> " + myReader["Title"]);
                textBox6.Text = (myReader["Title"].ToString()).Trim();
            }
            myReader.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from MovieTable where ";

            if (comboBox1.Text == "MovieID is:")
            {
                myCommand.CommandText += " MovieID = '" + searchinput.Text + "'";
            }
            if (comboBox1.Text == "Title is: ")
            {
                myCommand.CommandText += " Title = '" + searchinput.Text + "'";
            }
            if (comboBox1.Text == "Genre is: ")
            {
                myCommand.CommandText += " Genre = '" + searchinput.Text + "'";
            }
            if (comboBox1.Text == "Fee (is at least):")
            {
                myCommand.CommandText += " RentalFee >= '" + searchinput.Text + "'";
            }
            if (comboBox1.Text == "Copies available (at least):")
            {
                myCommand.CommandText += " Copies >= '" + searchinput.Text + "'";
            }

            try
            {
                myReader = myCommand.ExecuteReader();

                MovieList.Rows.Clear();
                while (myReader.Read())
                {
                    MovieList.Rows.Add(myReader["MovieID"].ToString(), myReader["Title"].ToString(), myReader["RentalFee"].ToString(), myReader["Genre"].ToString(), myReader["Copies"].ToString());
                }
                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int counter = 0;
            myCommand.CommandText = "UPDATE MovieTable SET ";

            if (String.IsNullOrEmpty(textBox7.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    myCommand.CommandText += ", ";
                myCommand.CommandText += "Title = '" + textBox7.Text + "'";
                MessageBox.Show("Movie title set to " + textBox7.Text);
               
            }

            if (String.IsNullOrEmpty(textBox9.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    myCommand.CommandText += ", ";
                myCommand.CommandText += "RentalFee = '" + int.Parse(textBox9.Text) + "'";
                MessageBox.Show("Movie Fee set to " + textBox9.Text);
               
            }

            if (String.IsNullOrEmpty(textBox10.Text) == false)
            {
                counter += 1;
                if (counter >= 2)
                    myCommand.CommandText += ", ";
                myCommand.CommandText += "Copies = '" + int.Parse(textBox10.Text) + "'";
                MessageBox.Show("Movie Fee set to " + textBox10.Text);
             
            }

            myCommand.CommandText += " WHERE Title = '" + textBox6.Text + "'";

            myCommand.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "Select * from MovieTable" + ";";


            try
            {
                myReader = myCommand.ExecuteReader();

                MovieList.Rows.Clear();
                while (myReader.Read())
                {
                    MovieList.Rows.Add(myReader["MovieID"].ToString(), myReader["Title"].ToString(), myReader["RentalFee"].ToString(), myReader["Genre"].ToString(), myReader["Copies"].ToString());

                }
                myReader.Close();
            }

            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            myCommand.CommandText = "Select Title from MovieTable where Title = '" + richTextBox3.Text.ToString() + "'" + ";";
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader.HasRows)
                {
                    MessageBox.Show("Movie Deleted --> " + myReader["Title"]);
                    richTextBox4.Text = myReader["Title"].ToString();
                }
                else if (myReader.HasRows == false)
                {
                    MessageBox.Show("Movie does not exist!");
                }

            }
            myReader.Close();

            myCommand.CommandText = "DELETE FROM MovieTable where Title = '" + richTextBox3.Text + "'" + ";";
            myCommand.ExecuteNonQuery();
        }

        private void MovieScrn_Load(object sender, EventArgs e)
        {
            UserLBL.Text = "Hello " + Login.Fname;
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            movieNinput.Text = String.Empty;
            fee_input.Text = String.Empty;
            copies_inp.Text = String.Empty;
        }

        private void Reset2BTN_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
            textBox9.Text = String.Empty;
            textBox10.Text = String.Empty;
        }
    }





}