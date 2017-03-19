using EmployeeReview1.Models;
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

namespace EmployeeReview1.Forms
{
    public partial class DeveloperSkillsForm : Form
    {
        public DeveloperSkillsForm(Employee employee)
        {
            InitializeComponent();
            fillcombo();
            fetchingdata();
            //SelectedEmployee = employee;

            ////Logic to fetch from DB. 
            //_devSkillsList = new List<DeveloperSkills>();
            //_devSkillsList.Add(new DeveloperSkills() { SkillName = "Coding Skills", SkillDescription = "" });
            //_devSkillsList.Add(new DeveloperSkills() { SkillName = "TroubleShooting Skills", SkillDescription = "" });
            //_devSkillsList.Add(new DeveloperSkills() { SkillName = "RequirementsAnalysis", SkillDescription = "" });
            //_devSkillsList.Add(new DeveloperSkills() { SkillName = "timelogging", SkillDescription = "" });
            //_devSkillsList.Add(new DeveloperSkills() { SkillName = "QualityAssurance", SkillDescription = "" });
        }

        void fetchingdata()
        {
            string[] stringArray = new string[3];

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=CCI-LPT-06\\MSSQLSERVER2K14E;Initial Catalog=employeeform;User ID=sa;Password=sa123456#";
            SqlCommand cmd = new SqlCommand("select * from devskillsratings", conn);
            SqlDataReader myReader;


            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                GroupBox g = new GroupBox();
                Label l1 = new Label();
                l1.Text = "Label1";
                l1.Location = new Point(10, 10);

                while (myReader.Read())
                {
                    string sname = myReader.GetString(1);
                  


                }
                MessageBox.Show("Connection Open ! ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! " + ex.Message);
            }

            System.Windows.Forms.RadioButton[] radioButtons =
                new System.Windows.Forms.RadioButton[3];

            for (int i = 0; i < 3; ++i)
            {
                radioButtons[i] = new RadioButton();
                radioButtons[i].Text = stringArray[i];
                radioButtons[i].Location = new System.Drawing.Point(
                    10, 10 + i * 20);
                this.Controls.Add(radioButtons[i]);
            }
        }
        void fillcombo()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=CCI-LPT-06\\MSSQLSERVER2K14E;Initial Catalog=employeeform;User ID=sa;Password=sa123456#";
            SqlCommand cmd = new SqlCommand("select * from devskills", conn);
            SqlDataReader myReader;


            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString(1);
                   
                   
                }
                MessageBox.Show("Connection Open ! ");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! " + ex.Message);
            }
        }

        private void DeveloperSkillsForm_Load(object sender, EventArgs e)
        {

        }






        //Private Class variabled : Camel Casing with _ as prefix
        //private List<DeveloperSkills> _devSkillsList;

        //public Employee SelectedEmployee { get; set; }

        //public int currentSkillsId = 0;

        // public DashboardForm DashboardForm { get; set; }

        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    int rating = GetSelectedRatings();

        //    //If no ratings are selected return back to the form. 
        //    if (rating <= 0)
        //        return;

        //    //Save the selected rating in the object. 
        //    SaveSelectedRating(rating);

        //    currentSkillsId++;
        //    if (currentSkillsId >= _devSkillsList.Count)
        //    {
        //        this.Close();
        //    }
        //    else
        //    {
        //        lblDevSkillName.Text = _devSkillsList[currentSkillsId].SkillName;
        //        ResetOptions();

        //    }

        //}

        //private void SaveSelectedRating(int rating)
        //{
        //    switch (_devSkillsList[currentSkillsId].SkillName)
        //    {
        //        case "Coding Skills":
        //            SelectedEmployee.DeveloperSkills.CodingSkills = rating;
        //            break;
        //        case "TroubleShooting Skills":
        //            SelectedEmployee.DeveloperSkills.TroubleShooting = rating;
        //            break;
        //        case "RequirementsAnalysis":
        //            SelectedEmployee.DeveloperSkills.RequirementsAnalysis = rating;
        //            break;
        //        case "timelogging":
        //            SelectedEmployee.DeveloperSkills.TimeLogging = rating;
        //            break;
        //        case "QualityAssurance":
        //            SelectedEmployee.DeveloperSkills.QualityAssurance = rating;
        //            break;
        //        default: break;
        //    }
        //}

        //private int GetSelectedRatings()
        //{
        //    int rating = 0;
        //    if (rbOutstanding.Checked)
        //    {
        //        rating = 5;
        //    }
        //    else if (rbAboveExpectations.Checked)
        //    {
        //        rating = 4;
        //    }
        //    else if (rbMeetsExpectations.Checked)
        //    {
        //        rating = 3;
        //    }
        //    else if (rbNeedsImprovement.Checked)
        //    {
        //        rating = 2;
        //    }
        //    else if (rbUnsatisfactory.Checked)
        //    {
        //        rating = 1;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please Select a rating to continue");
        //    }
        //    return rating;
        //}
        //private void ResetOptions()
        //{
        //    rbAboveExpectations.Checked =
        //        rbMeetsExpectations.Checked =
        //        rbNeedsImprovement.Checked =
        //        rbOutstanding.Checked =
        //        rbUnsatisfactory.Checked = false;
        //}
        //private void DeveloperSkills_Load(object sender, EventArgs e)
        //{
        //    ResetOptions();
        //    lblDevSkillName.Text = _devSkillsList[currentSkillsId].SkillName;
        //}

        //private void rbOutstanding_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
