﻿using System;
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

        private void AddClientButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveClientButton_Click(object sender, EventArgs e)
        {
            Remove SearchForm = new Remove();
            SearchForm.Show();
        }
    }
}
