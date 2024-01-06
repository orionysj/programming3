using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming3Home
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintConfirmation printConfirmation = new PrintConfirmation();
            printConfirmation.ShowDialog();
        }
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
            database = "lukefinan"; // Replace with your MySQL database name
            username = "luke.finan"; // Replace with your MySQL username
            password = "ME7G8FAF"; // Replace with your MySQL password

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
}