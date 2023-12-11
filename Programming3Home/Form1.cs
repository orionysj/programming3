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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Search_Engine SearchForm = new Search_Engine();

            // Show the settings form
            SearchForm.Show();
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
