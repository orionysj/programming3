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

namespace Programming3Home
{
    public partial class Home : Form
    {
        private System.Windows.Forms.Timer refreshTimer;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Home()
        {
            InitializeComponent();

            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 10; // 1000 milliseconds = 1 second
            refreshTimer.Tick += new EventHandler(refreshTimer_Tick);
            refreshTimer.Start();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            var Add = new AddRecord();
            Add.Location = this.Location;
            Add.StartPosition = FormStartPosition.Manual;
            Add.FormClosing += delegate { this.Show(); };
            Add.Show();
            this.Hide();
        }
    }

}
