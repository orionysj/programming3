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
    public partial class PrintConfirmation : Form
    {
        public PrintConfirmation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintRedirect printRedirect = new PrintRedirect();
            printRedirect.ShowDialog();
        }

        private void PrintConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
