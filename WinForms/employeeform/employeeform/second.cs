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
    public partial class second : Form
    {
        public second()
        {
            InitializeComponent();
        }

        public Employee Employee { get; set; }
        public Form1 MainForm { get; set; }
        public developer4 dv4 { get; set; }

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
           
            
            dv.secondform = this;
            dv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm.Show();
        }

        private void second_Load(object sender, EventArgs e)
        {

        }
    }
}
