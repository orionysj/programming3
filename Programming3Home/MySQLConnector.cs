using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///The connection class was completed by Kyle Hutchinson

namespace Programming3Home
{
    internal class MySQLConnector
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

        public void ExecuteNonQueryWithParameters(string query, MySqlParameter[] parameters)
        {
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
    

