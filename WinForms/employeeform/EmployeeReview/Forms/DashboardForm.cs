using EmployeeReview.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeReview.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm(Employee currentEmployee)
        {
            InitializeComponent();

            employeeBindingSource.DataSource = currentEmployee;
        }

    

    

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnDevSkills_Click(object sender, EventArgs e)
        {
            //open devskills form
            DeveloperSkillsForm devForm = new DeveloperSkillsForm((Employee)employeeBindingSource.DataSource);
            this.Hide();
            devForm.ShowDialog();
            btnViewSummary.Visible = true;
            this.Show();
        }

        private void btnTechSkills_Click(object sender, EventArgs e)
        {

        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            SummaryForm summary = new SummaryForm((Employee)employeeBindingSource.DataSource);
            this.Hide();
            summary.ShowDialog();
            this.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
