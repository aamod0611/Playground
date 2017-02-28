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
    public partial class SummaryForm : Form
    {
        public SummaryForm(Employee currentEmployee)
        {
            InitializeComponent();
            _selectedEmployee = currentEmployee;
        }
        private Employee _selectedEmployee;
        private void SummaryForm_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("************************************");
            sb.AppendLine("             Summary");
            sb.AppendLine("************************************");
            sb.AppendLine("Developer Name :  "+ _selectedEmployee.Name+"("+_selectedEmployee.Designation+")");
            sb.AppendLine("----------Developer Skills---------");
            sb.AppendLine("---- " + nameof(_selectedEmployee.DeveloperSkills.CodingSkills)+"  :" + _selectedEmployee.DeveloperSkills.CodingSkills);
            sb.AppendLine("---- " + nameof(_selectedEmployee.DeveloperSkills.TroubleShooting) + "  :" + _selectedEmployee.DeveloperSkills.TroubleShooting);
            sb.AppendLine("---- " + nameof(_selectedEmployee.DeveloperSkills.QualityAssurance) + "  :" + _selectedEmployee.DeveloperSkills.QualityAssurance);
            sb.AppendLine("---- " + nameof(_selectedEmployee.DeveloperSkills.TimeLogging) + "  :" + _selectedEmployee.DeveloperSkills.TimeLogging);
            sb.AppendLine("---- " + nameof(_selectedEmployee.DeveloperSkills.RequirementsAnalysis) + "  :" + _selectedEmployee.DeveloperSkills.RequirementsAnalysis);
            lbl_Summary.Text = sb.ToString();
        }
    }
}
