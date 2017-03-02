using EmployeeReview.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=CCI-LPT-06\\MSSQLSERVER2K14E;Initial Catalog=employeeform;User ID=sa;Password=sa123456#";
            SqlCommand cmd = new SqlCommand("Insert into login(name,designation)values('" + txtName.Text + "','" + txtDesignation.Text + "')",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Open ! ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! "+ex.Message);
            }
            DashboardForm dashform = new DashboardForm(LoggedInEmployee);
            this.Hide();
            dashform.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesignation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
