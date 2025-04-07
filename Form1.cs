using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BCrypt.Net;

namespace Restourant
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text != string.Empty && password.Text != string.Empty && confirmpassword.Text != string.Empty)
            {
                if (password.Text == confirmpassword.Text)
                {
                    cmd = new SqlCommand("SELECT * FROM [User] WHERE Username = @Username", conn);
                    cmd.Parameters.AddWithValue("@Username", username.Text);
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exists");
                    }
                    else
                    {
                        dr.Close();

                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password.Text);

                        cmd = new SqlCommand("INSERT INTO [User] (Username, Password) VALUES (@Username, @Password)", conn);
                        cmd.Parameters.AddWithValue("@Username", username.Text);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Your account has been created!");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Please enter all values", "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;";
            conn = new SqlConnection(connectionString);
            conn.Open();
        }
    }
}
