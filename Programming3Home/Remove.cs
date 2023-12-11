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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void removeselectedc_Click(object sender, EventArgs e)
        {
            RemoveConfirmation SearchForm = new RemoveConfirmation();
            SearchForm.Show();
        }
    }
}
