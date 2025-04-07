using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using BCrypt.Net;

namespace Restourant
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;";

            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 registration = new Form1();
            registration.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text))
            {
                cmd = new SqlCommand("SELECT Password FROM [User] WHERE Username = @Username", conn);
                cmd.Parameters.AddWithValue("@Username", username.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string storedHashedPassword = dr.GetString(0);
                    dr.Close();

                    if (BCrypt.Net.BCrypt.Verify(password.Text, storedHashedPassword))
                    {
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Account doesn't exist.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
    }
}
