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
    public partial class developer3 : Form
    {
        public developer3()
        {
            InitializeComponent();
        }
     //   public Employee Employee { get; set; }
       // public Form1 MainForm { get; set; }
        public developer1 dev1 { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            developer4 dv4 = new developer4();
            dv4.dev3 = this;
            dv4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            dev1.Show();        
        }

        private void developer3_Load(object sender, EventArgs e)
        {

        }
    }
}
