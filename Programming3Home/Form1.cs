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

            var searchfrm = new Search_Engine();
            searchfrm.Location = this.Location;
            searchfrm.StartPosition = FormStartPosition.Manual;
            searchfrm.FormClosing += delegate { this.Show(); };
            searchfrm.Show();
            this.Hide();

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
