using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            MySQLConnector connector = new MySQLConnector();
            ClientDataTable.DataSource = connector.ExecuteQuery(query);
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {

        }

        private void ClientDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void OrderClientButton_Click(object sender, EventArgs e)
        {

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

        private void Initialize()
        {
            server = "ysjcs.net";
            database = "username";
            username = "user.name";
            password = "PASSWORD";

            string stringConnection = $"Server={server}; Database={database}; Uid={username}; Pwd={password}";

            connection = new MySqlConnection(stringConnection);
        }

        public bool OpenConnection()
        {
            try
            {
                if (connection?.State != System.Data.ConnectionState.Open)
                {
                    connection?.Open();
                }
                return true;
            }
            catch (MySqlException ex)
            {
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
                connection?.Dispose();
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
