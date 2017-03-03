using EmployeeReview1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeReview1.Forms
{
    public partial class TechnicalSkillsForm : Form
    {
       

        public TechnicalSkillsForm(Employee employee)
        {
            InitializeComponent();
            SelectedEmployee = employee;

            _techSkillsList = new List<Technicalskills>();
            _techSkillsList.Add(new Technicalskills() { SkillName = "CSharp", SkillDescription = "" });
            _techSkillsList.Add(new Technicalskills() { SkillName = "java", SkillDescription = "" });
            _techSkillsList.Add(new Technicalskills() { SkillName = "Angular js", SkillDescription = "" });
            _techSkillsList.Add(new Technicalskills() { SkillName = "nodejs", SkillDescription = "" });
        }

        private List<Technicalskills> _techSkillsList;

        public Employee SelectedEmployee { get; set; }

        public DashboardForm DashboardForm { get; set; }

        public int currentSkillsId = 0;
        

        private void rb_Expert_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Intermediate_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rb_proficient_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_beginner_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int rating = GetSelectedRatings();

           
            if (rating <= 0)
                return;

            
            SaveSelectedRating(rating);

            currentSkillsId++;
            if (currentSkillsId >= _techSkillsList.Count)
            {
                this.Close();
            }
            else
            {
                //missing 
                lbltechSkillName.Text = _techSkillsList[currentSkillsId].SkillName;
                ResetOptions();


            }
        }


        private void SaveSelectedRating(int rating)
        {
            switch (_techSkillsList[currentSkillsId].SkillName)
            {
                case "CSharp":
                    SelectedEmployee.TechnicalSkills.CSharp = rating;
                    break;
                case "java":
                    SelectedEmployee.TechnicalSkills.Java = rating;
                    break;
                case "Angular js":
                    SelectedEmployee.TechnicalSkills.AngularJs = rating;
                    break;
                case "nodejs":
                    SelectedEmployee.TechnicalSkills.NodeJs = rating;
                    break;
                default: break;
            }
        }


        private int GetSelectedRatings()
        {
            int rating = 0;
            if (rb_Expert.Checked)
            {
                rating = 4;
            }
            else if (rb_proficient.Checked)
            {
                rating = 3;
            }
            else if (rb_Intermediate.Checked)
            {
                rating = 2;
            }
            else if (rb_beginner.Checked)
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
            rb_Expert.Checked =
              rb_proficient.Checked =
               rb_Intermediate.Checked =
               rb_beginner.Checked = false;
        }

        private void TechnicalSkillsForm_Load(object sender, EventArgs e)
        {
            //missing
            lbltechSkillName.Text = _techSkillsList[currentSkillsId].SkillName;
            ResetOptions();
        }
    }
}
