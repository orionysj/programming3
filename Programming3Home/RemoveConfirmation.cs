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

//The design and layout of this window was created by Luke Finan. Orion Williams added the MySQL connection functionality.

namespace Programming3Home
{
    public partial class RemoveConfirmation : Form
    {

        private string clientIDtoRemove;
        public RemoveConfirmation(int toRemove)
        {
            InitializeComponent();
            clientIDtoRemove = toRemove.ToString();
        }

        private void removeno_Click(object sender, EventArgs e)
        {
            Form1 SearchForm = new Form1();
            SearchForm.Show();
        }

        private void removeyes_Click(object sender, EventArgs e)
        {
            Removedone SearchForm = new Removedone();
            SearchForm.Show();
            this.Close();
            MySQLConnector connector = new MySQLConnector();
            string getServicesID = "select ServiceID from clients where ClientID='" + clientIDtoRemove + "'";
            DataTable ServicesIDresult = connector.ExecuteQuery(getServicesID);
            string ServicesID = ServicesIDresult.Rows[0][0].ToString();
            string removeClient = "delete from clients where ClientID='" + clientIDtoRemove + "'";
            connector.ExecuteQuery(removeClient);
            string removeService = "delete from services where ClientID='" + ServicesID + "'";
            connector.ExecuteQuery(removeService);
        }

        private void removeno_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
