using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Programming3Home
{
    public partial class Search : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Search()
        {
            InitializeComponent();
        }
        public class MySQLConnector
        {
            private MySqlConnection connection;
            private string server;
            private string database;
            private string username;
            private string password;

            public MySQLConnector()
            {
                Initialize();
            }

            // Initialize the connection properties
            private void Initialize()
            {
                server = "ysjcs.net"; // Replace with your MySQL server hostname or IP address
                database = "kylehutchinson_Programming_Project"; // Replace with your MySQL database name
                username = "kyle.hutchinson"; // Replace with your MySQL username
                password = "UYLXWYMQ"; // Replace with your MySQL password

                string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
                connection = new MySqlConnection(connectionString);
            }

            public bool OpenConnection()
            {
                try
                {
                    if (connection?.State != System.Data.ConnectionState.Open)
                        connection?.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    // Handle the exception (e.g., log it or display an error message)
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }

            public bool CloseConnection()
            {
                try
                {
                    if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                    return true;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection?.Dispose(); // Dispose of the connection if it’s not null
                }
            }

            public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
            {
                DataTable dataTable = new DataTable();
                if (OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        try
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                dataTable.Load(reader);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                    CloseConnection();
                }
                return dataTable;
            }

            public void ExecuteNonQuery(string query)
            {
                if (OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                    CloseConnection();
                }
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySQLConnector Programming3Home = new MySQLConnector();
            string query = "SELECT * FROM Clients";
            dataGridView1.DataSource = Programming3Home.ExecuteQuery(query);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
 
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            MySQLConnector Programming3Home = new MySQLConnector();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Clients";
            dataGridView1.DataSource = Programming3Home.ExecuteQuery(query);

            if (textBox1.Text != "")
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string info = comboBox1.SelectedItem?.ToString(); // Use SelectedItem instead of SelectedText
                string command = "SELECT * FROM Clients WHERE " + info + " LIKE '%" + textBox1.Text + "%'";

                if (Programming3Home.OpenConnection())
                {
                    dataTable = Programming3Home.ExecuteQuery(command);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Programming3Home.CloseConnection();
                }
                dataGridView1.Refresh();

            }
            else
            {

                dataGridView1.Refresh();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySQLConnector Programming3Home = new MySQLConnector();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Clients";
            dataGridView1.DataSource = Programming3Home.ExecuteQuery(query);

            if (textBox1.Text != "")
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string info = comboBox1.SelectedItem?.ToString(); // Use SelectedItem instead of SelectedText
                string command = "SELECT * FROM Clients WHERE " + info + " LIKE '%" + textBox1.Text + "%'";

                if (Programming3Home.OpenConnection())
                {
                    dataTable = Programming3Home.ExecuteQuery(command);
                    dataGridView1.DataSource = dataTable.DefaultView;
                    Programming3Home.CloseConnection();
                }
                dataGridView1.Refresh();

            }
            else
            {

                dataGridView1.Refresh();
            }

        }

        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void HomeButton_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void Order_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Form1 SearchForm = new Form1();
            SearchForm.Show();
        }
    }
}
