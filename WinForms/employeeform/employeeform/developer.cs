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
    public partial class developer : Form
    {
        public developer()
        {
            InitializeComponent();
        }
        //public Employee Employee { get; set; }
        //public Form1 MainForm { get; set; }
        public second secondform { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = null;
            this.Hide();
            developer1 dv1 = new developer1();
            dv1.dev = this;
            dv1.Show();

            if(radioButton1.Checked)
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
            secondform.Show();
        }

        private void developer_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
