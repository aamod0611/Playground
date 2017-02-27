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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            developer3 dv3 = new developer3();
            dv3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            developer dv = new developer();
            dv.Show();
        }
    }
}
