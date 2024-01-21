using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//The design and layout of this window was created by Luke Finan. Orion Williams made amendments to the first two functions in the partial class below.

namespace Programming3Home
{
    public partial class Remove : Form
    {
        public Remove(DataTable table)
        {
            InitializeComponent();
            dataGridView1.DataSource = table;
        }

        private void removeselectedc_Click(object sender, EventArgs e)
        {
            int clientID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            RemoveConfirmation SearchForm = new RemoveConfirmation(clientID);
            SearchForm.Show();
        }

        private void Remove_Load(object sender, EventArgs e)
        {

        }

        private void Remove_Load_1(object sender, EventArgs e)
        {

        }
    }
}
