﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeeform
{
    public partial class second : Form
    {
        public second()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            technical tc = new technical();
            tc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            developer dv = new developer();
            dv.Show();
        }
    }
}