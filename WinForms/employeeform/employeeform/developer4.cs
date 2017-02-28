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
    public partial class developer4 : Form
    {
        public developer4()
        {
            InitializeComponent();
        }

        //public Employee Employee { get; set; }
        //public Form1 MainForm { get; set; }
        public developer3 dev3 { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dev3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            second sf = new second();
            sf.dv4 = this;
            sf.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
