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
    public partial class Order : Form
    {
        // The code in this file was done by Orion Williams
        private int selectedOption { get; set; }
        public Order(int selectedOrderBy)
        {
            InitializeComponent();
            selectedOption = selectedOrderBy;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOption = orderByOptions.SelectedIndex;
        }

        public int getSelectedOption() //public getter method for parent form
        {
            return selectedOption;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
