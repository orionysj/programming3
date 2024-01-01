using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
///The Add records funcitonality was completed by Kyle Hutchinson.


namespace Programming3Home
{
    public partial class AddRecord : Form
    {
        private System.Windows.Forms.Timer refreshTimer;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public AddRecord()
        {
            InitializeComponent();
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 10; // 1000 milliseconds = 1 second
            refreshTimer.Tick += new EventHandler(refreshTimer_Tick);
            refreshTimer.Start();

        }

        private void AddRecord_Load(object sender, EventArgs e)
        {

        }

        private void refreshTimer_Tick(object sender, EventArgs e)
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

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Location = this.Location;
            home.StartPosition = FormStartPosition.Manual;
            home.FormClosing += delegate { this.Show(); };
            home.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            var searchfrm = new Search_Engine();
            searchfrm.Location = this.Location;
            searchfrm.StartPosition = FormStartPosition.Manual;
            searchfrm.FormClosing += delegate { this.Show(); };
            searchfrm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            int software = checkSoftware.Checked ? 1 : 0;
            int laptopsPC = checkLaptops.Checked ? 1 : 0;
            int games = checkGames.Checked ? 1 : 0;
            int officeTools = checkOfficeTools.Checked ? 1 : 0;
            int accessories = checkAccessories.Checked ? 1 : 0;

            // Validates each of the inputs and makes sure data is correct
            if (!Regex.IsMatch(firstName, "^[a-zA-Z]+$") || firstName.Length >= 20)
            {
                MessageBox.Show("Invalid first name. Please enter only letters and ensure the length is less than 20.");
                return;
            }

            if (!Regex.IsMatch(lastName, "^[a-zA-Z]+$") || lastName.Length >= 20)
            {
                MessageBox.Show("Invalid last name. Please enter only letters and ensure the length is less than 20.");
                return;
            }

            if (address.Length >= 70)
            {
                MessageBox.Show("Invalid address. Please ensure the length is less than 70.");
                return;
            }

            if (!Regex.IsMatch(phone, "^[0-9]+$") || phone.Length != 11) // Adjust the length as needed
            {
                MessageBox.Show("Invalid phone number. Please enter only numbers and ensure the length is correct.");
                return;
            }


            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.");
                return;
            }


            MySQLConnector mySQLConnector = new MySQLConnector();

            // Insert into Clients table
            string clientQuery = "INSERT INTO Clients (FirstName, LastName, Address, Phone, Email) VALUES (@FirstName, @LastName, @Address, @Phone, @Email); SELECT LAST_INSERT_ID();";
            MySqlParameter[] clientParameters =
            {
                new MySqlParameter("@FirstName", firstName),
                new MySqlParameter("@LastName", lastName),
                new MySqlParameter("@Address", address),
                new MySqlParameter("@Phone", phone),
                new MySqlParameter("@Email", email)
            };

            // Execute the query and get the last insert ID
            DataTable clientResult = mySQLConnector.ExecuteQuery(clientQuery, clientParameters);
            int clientID = Convert.ToInt32(clientResult.Rows[0][0]);

            // Insert into Services table
            string boolQuery = "INSERT INTO Services (Software, LaptopsPC, Games, OfficeTools, Accessories, ClientID) VALUES (@Software, @LaptopsPC, @Games, @OfficeTools, @Accessories, @ClientID); SELECT LAST_INSERT_ID();";
            MySqlParameter[] boolParameters =
            {
                new MySqlParameter("@Software", software),
                new MySqlParameter("@LaptopsPC", laptopsPC),
                new MySqlParameter("@Games", games),
                new MySqlParameter("@OfficeTools", officeTools),
                new MySqlParameter("@Accessories", accessories),
                new MySqlParameter("@ClientID", clientID)
            };

            // Execute the query and get the last insert ID
            DataTable serviceResult = mySQLConnector.ExecuteQuery(boolQuery, boolParameters);
            int serviceID = Convert.ToInt32(serviceResult.Rows[0][0]);

            // Update the Clients table with the obtained ServiceID
            string updateClientsQuery = "UPDATE Clients SET ServiceID = @ServiceID WHERE ClientID = @ClientID";
            MySqlParameter[] updateClientsParameters =
            {
                new MySqlParameter("@ServiceID", serviceID),
                new MySqlParameter("@ClientID", clientID)
            };

            mySQLConnector.ExecuteNonQueryWithParameters(updateClientsQuery, updateClientsParameters);

            MessageBox.Show("Data inserted successfully.");



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
