﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Form_CEO : Form
    {
        public Form_CEO()
        {
            InitializeComponent();
        }

        private void MgrView_Click(object sender, EventArgs e)
        {
            Form_manager MgrForm = new Form_manager();
            MgrForm.Show();
        }
    }
}
