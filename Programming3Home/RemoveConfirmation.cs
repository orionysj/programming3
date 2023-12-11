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
    public partial class RemoveConfirmation : Form
    {
        public RemoveConfirmation()
        {
            InitializeComponent();
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
        }
    }
}
