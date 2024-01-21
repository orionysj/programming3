using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

//All functionality in this file was implemented by Orion Williams

namespace Programming3Home
{
    public partial class Form1 : Form
    {
        private int orderBy { get; set; }
        private string[] orderByTranslations = { "clients.ClientID", "clients.FirstName", "clients.LastName", "clients.Address", "clients.Phone", "clients.Email", "services.Software desc", "services.LaptopsPC desc", "services.Games desc", "services.OfficeTools desc", "services.Accessories desc" };
        public Form1()
        {
            InitializeComponent();
            orderBy = 0;
            refresh();
        }

        private void refresh(string query = "select clients.ClientID, clients.FirstName, clients.LastName, clients.Address, clients.Phone, clients.Email, services.Software, services.LaptopsPC, services.Games, services.OfficeTools, services.Accessories from clients inner join services on clients.ServiceID = services.ServiceID")
        {
            MySQLConnector connector = new MySQLConnector();
            var queryToRun = query + " order by " + orderByTranslations[orderBy];
            ClientDataTable.DataSource = connector.ExecuteQuery(queryToRun);
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            AddRecord addForm = new AddRecord();
            addForm.ShowDialog();
            refresh();
        }

        private void ClientDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search_Engine searchForm = new Search_Engine();
            searchForm.ShowDialog();
            refresh();
        }

        private void OrderClientButton_Click(object sender, EventArgs e)
        {
            Order orderForm = new Order(orderBy);
            orderForm.ShowDialog();
            orderBy = orderForm.getSelectedOption();
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void PrintClientButton_Click(object sender, EventArgs e)
        {
            MySQLConnector connector = new MySQLConnector();
            string query = "select clients.ClientID, clients.FirstName, clients.LastName, clients.Address, clients.Phone, clients.Email, services.Software, services.LaptopsPC, services.Games, services.OfficeTools, services.Accessories from clients inner join services on clients.ServiceID = services.ServiceID";
            var queryToRun = query + " order by " + orderByTranslations[orderBy];
            DataTable data = connector.ExecuteQuery(queryToRun);
            Print printForm = new Print(data);
            printForm.ShowDialog();
            refresh();
        }

        private void RemoveClientButton_Click(object sender, EventArgs e)
        {
            MySQLConnector connector = new MySQLConnector();
            string query = "select clients.ClientID, clients.FirstName, clients.LastName, clients.Address, clients.Phone, clients.Email, services.Software, services.LaptopsPC, services.Games, services.OfficeTools, services.Accessories from clients inner join services on clients.ServiceID = services.ServiceID";
            var queryToRun = query + " order by " + orderByTranslations[orderBy];
            DataTable data = connector.ExecuteQuery(queryToRun);
            Remove removeForm = new Remove(data);
            removeForm.ShowDialog();
            refresh();
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
            server = "";
            database = "";
            username = "";
            password = "";

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
