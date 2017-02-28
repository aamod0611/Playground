using System;
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
    public partial class developer1 : Form
    {
        public developer1()
        {
            InitializeComponent();
        }

      //  public Employee Employee { get; set; }
       // public Form1 MainForm { get; set; }
        public developer dev { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value;
            this.Hide();
            developer3 dv3 = new developer3();
            dv3.dev1 = this;
            dv3.Show();

            if (radioButton1.Checked)
            {
                value = "5";
            }
            if (radioButton2.Checked)
            {
                value = "4";
            }
            if (radioButton3.Checked)
            {
                value = "3";
            }
            if (radioButton4.Checked)
            {
                value = "2";
            }
            if (radioButton5.Checked)
            {
                value = "1";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dev.Show();
        }

        private void developer1_Load(object sender, EventArgs e)
        {

        }
    }
}
