using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Restourant
{
    public partial class Home : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID.Text) || string.IsNullOrWhiteSpace(location.Text) ||
                    string.IsNullOrWhiteSpace(manager.Text) || string.IsNullOrWhiteSpace(type.Text) ||
                    string.IsNullOrWhiteSpace(income.Text))
                {
                    MessageBox.Show("Please fill all the fields before inserting a new restaurant.");
                    return;
                }

                if (!decimal.TryParse(income.Text, out decimal incomeValue))
                {
                    MessageBox.Show("Please enter a valid income value.");
                    return;
                }

                string query = $"INSERT INTO [Restaurants] VALUES('{ID.Text}', '{location.Text}', '{manager.Text}', '{type.Text}', '{income.Text}')";
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                cleardata();
                conn.Close();
                displaydata();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void cleardata()
        {
            ID.Clear();
            location.Clear();
            manager.Clear();
            type.Clear();
            income.Clear();
        }

        private void displaydata()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Restaurants";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";

            conn = new SqlConnection(connectionString);
            cmd = conn.CreateCommand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(location.Text) || string.IsNullOrWhiteSpace(manager.Text) ||
                    string.IsNullOrWhiteSpace(type.Text) || string.IsNullOrWhiteSpace(ID.Text))
                {
                    MessageBox.Show("Please fill all the fields before updating.");
                    return;
                }

                string query = $"UPDATE [Restaurants] SET Location='{location.Text}', Manager='{manager.Text}', Type='{type.Text}' WHERE Id='{ID.Text}'";
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                displaydata();
                cleardata();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ID.Text))
                {
                    MessageBox.Show("Please enter the ID of the restaurant you want to delete");
                    return;
                }

                string query = $"DELETE FROM [Restaurants] WHERE id='{ID.Text}'";
                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();
                dataGridView1.DataSource = null;
                cleardata();
                conn.Close();
                displaydata();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void location_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
