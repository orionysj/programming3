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
    public partial class PrintRedirect : Form
    {
        public PrintRedirect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }

    namespace MultipleFormCLosing
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeLifetimeService();
            }
            private void button1_Click(object sender, EventArgs e)
            {
                CloseAllFormsExceptMain();
            }
            private void CloseAllFormsExceptMain()
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this)
                    { form.Close(); }
                }
            }
        }
    }
}
