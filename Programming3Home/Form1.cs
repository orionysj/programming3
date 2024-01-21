using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming3Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refresh();
        }


        private void refresh(string query = "select clients.ClientID, clients.FirstName, clients.LastName, clients.Address, clients.Phone, clients.Email, services.Software, services.LaptopsPC, services.Games,services.OfficeTools, services.Accessories from clients inner join services on clients.ServiceID = services.ServiceID")
        {
        MySQLConnector lab11connect = new MySQLConnector();
        ClientDataTablehome.DataSource = lab11connect.ExecuteQuery(query);
        }
        private void button1_Click(object sender, EventArgs e)
        {

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
                server = ""; // Replace with your MySQL server hostname or IP address
                database = ""; // Replace with your MySQL database name
                username = ""; // Replace with your MySQL username
                password = ""; // Replace with your MySQL password

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

        private void RemoveClientButton_Click(object sender, EventArgs e)
        {
            Remove remove = new Remove();
            remove.Show();
        }

        private void ClientDataTablehome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrintClientButton_Click(object sender, EventArgs e)
        {
            Print print = new Print();  
            print.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
