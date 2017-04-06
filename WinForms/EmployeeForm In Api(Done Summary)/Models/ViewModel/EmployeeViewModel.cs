using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeForm_In_Api.Models.ViewModel
{
    public class EmployeeViewModel
    {
        public  List<SkillTypes> SkillTypeslist { get; set; }

        public  List<Skills> Skillslist { get; set; }

        public  List<Ratings> Ratingslist { get; set; }

        public  List<Designation> Designationlist { get; set; }

        public  List<EmployeeData> EmployeeDatalist { get; set; }

        public List<EmployeeSummery> EmployeeSummerylist { get; set; }

        public string SelectedAnswer { set; get; }


    }
}