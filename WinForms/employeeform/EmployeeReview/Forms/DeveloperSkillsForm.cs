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
    public partial class DeveloperSkillsForm : Form
    {
        public DeveloperSkillsForm(Employee employee)
        {
            InitializeComponent();
            SelectedEmployee = employee;

            //Logic to fetch from DB. 
            _devSkillsList = new List<DeveloperSkills>();
            _devSkillsList.Add(new DeveloperSkills() { SkillName = "Coding Skills", SkillDescription = "" });
            _devSkillsList.Add(new DeveloperSkills() { SkillName = "TroubleShooting Skills", SkillDescription = "" });
            _devSkillsList.Add(new DeveloperSkills() { SkillName = "RequirementsAnalysis", SkillDescription = "" });
            _devSkillsList.Add(new DeveloperSkills() { SkillName = "timelogging", SkillDescription = "" });
            _devSkillsList.Add(new DeveloperSkills() { SkillName = "QualityAssurance", SkillDescription = "" });
        }
        //Private Class variabled : Camel Casing with _ as prefix
        private List<DeveloperSkills> _devSkillsList;

        public Employee SelectedEmployee { get; set; }

        public int currentSkillsId = 0;

         public DashboardForm DashboardForm { get; set; }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int rating = GetSelectedRatings();

            //If no ratings are selected return back to the form. 
            if (rating <= 0)
                return;

            //Save the selected rating in the object. 
            SaveSelectedRating(rating);

            currentSkillsId++;
            if (currentSkillsId >= _devSkillsList.Count)
            {
                this.Close();
            }
            else
            {
                lblDevSkillName.Text = _devSkillsList[currentSkillsId].SkillName;
                ResetOptions();
                
            }

        }

        private void SaveSelectedRating(int rating)
        {
            switch (_devSkillsList[currentSkillsId].SkillName)
            {
                case "Coding Skills":
                    SelectedEmployee.DeveloperSkills.CodingSkills = rating;
                    break;
                case "TroubleShooting Skills":
                    SelectedEmployee.DeveloperSkills.TroubleShooting = rating;
                    break;
                case "RequirementsAnalysis":
                    SelectedEmployee.DeveloperSkills.RequirementsAnalysis = rating;
                    break;
                case "timelogging":
                    SelectedEmployee.DeveloperSkills.TimeLogging = rating;
                    break;
                case "QualityAssurance":
                    SelectedEmployee.DeveloperSkills.QualityAssurance = rating;
                    break;
                default: break;
            }
        }

        private int GetSelectedRatings()
        {
            int rating = 0;
            if (rbOutstanding.Checked)
            {
                rating = 5;
            }
            else if (rbAboveExpectations.Checked)
            {
                rating = 4;
            }
            else if (rbMeetsExpectations.Checked)
            {
                rating = 3;
            }
            else if (rbNeedsImprovement.Checked)
            {
                rating = 2;
            }
            else if (rbUnsatisfactory.Checked)
            {
                rating = 1;
            }
            else
            {
                MessageBox.Show("Please Select a rating to continue");
            }
            return rating;
        }
        private void ResetOptions()
        {
            rbAboveExpectations.Checked =
                rbMeetsExpectations.Checked =
                rbNeedsImprovement.Checked =
                rbOutstanding.Checked =
                rbUnsatisfactory.Checked = false;
        }
        private void DeveloperSkills_Load(object sender, EventArgs e)
        {
            ResetOptions();
            lblDevSkillName.Text = _devSkillsList[currentSkillsId].SkillName;
        }

        private void rbOutstanding_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
