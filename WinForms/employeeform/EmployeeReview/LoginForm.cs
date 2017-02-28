using EmployeeReview.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeReview
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoggedInEmployee = new Models.Employee();
        }

        //Pascal Naming Convention
        public Models.Employee LoggedInEmployee;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            employeeBindingSource.DataSource = LoggedInEmployee;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DashboardForm dashform = new DashboardForm(LoggedInEmployee);
            this.Hide();
            dashform.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
