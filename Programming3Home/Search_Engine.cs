﻿using MySql.Data.MySqlClient;
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

///The search engine part of this project was completed by Kyle Hutchinson. Minor amendments were made by Orion Williams and are marked within the code.

namespace Programming3Home
{
    public partial class Search_Engine : Form
    {
        private System.Windows.Forms.Timer refreshTimer;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Search_Engine()
        {
            InitializeComponent();

            comboBox1.Text = "ClientID";

            // Initialize the Timer
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 10; // 1000 milliseconds = 1 second
            refreshTimer.Tick += new EventHandler(refreshTimer_Tick);
            refreshTimer.Start();


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
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
 
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            MySQLConnector Programming3Home = new MySQLConnector();
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM clients";
            dataGridView1.DataSource = Programming3Home.ExecuteQuery(query);

            if (textBox1.Text != "")
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string info = comboBox1.SelectedItem?.ToString(); // Use SelectedItem instead of SelectedText
                string command = "SELECT * FROM clients WHERE " + info + " LIKE '%" + textBox1.Text + "%'";

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
            string query = "SELECT * FROM clients";
            dataGridView1.DataSource = Programming3Home.ExecuteQuery(query);

            if (textBox1.Text != "")
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string info = comboBox1.SelectedItem?.ToString(); // Use SelectedItem instead of SelectedText
                string command = "SELECT * FROM clients WHERE " + info + " LIKE '%" + textBox1.Text + "%'";

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




        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }


        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void HomeButton_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e) //This function was added by Orion Wililams
        {
            MySQLConnector connector = new MySQLConnector();
            string query = "select clients.ClientID, clients.FirstName, clients.LastName, clients.Address, clients.Phone, clients.Email, services.Software, services.LaptopsPC, services.Games, services.OfficeTools, services.Accessories from clients inner join services on clients.ServiceID = services.ServiceID";
            DataTable data = connector.ExecuteQuery(query);
            Print printForm = new Print(data);
            printForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) //This function was added by Orion Williams
        {
            MySQLConnector refresher = new MySQLConnector();
            refresher.ExecuteQuery("select * from clients");
        }

        private void button3_Click(object sender, EventArgs e) //This function was added by Orion Williams
        {
            MySQLConnector connector = new MySQLConnector();
            string query = "select clients.ClientID, clients.FirstName, clients.LastName, clients.Address, clients.Phone, clients.Email, services.Software, services.LaptopsPC, services.Games, services.OfficeTools, services.Accessories from clients inner join services on clients.ServiceID = services.ServiceID";
            DataTable data = connector.ExecuteQuery(query);
            Remove removeForm = new Remove(data);
            removeForm.ShowDialog();
        }
        private void Order_Click(object snder, EventArgs e) //This function was added by Orion Williams
        {
            Order orderForm = new Order(0);
            orderForm.ShowDialog();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            // Orion Williams comment - removing the following lines
            //var home = new Home();
            //home.Location = this.Location;
            //home.StartPosition = FormStartPosition.Manual;
            //home.FormClosing += delegate { this.Show(); };
            //home.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
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
