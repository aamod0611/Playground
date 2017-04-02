using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeForm_In_Api.Models
{
    public class EmployeeSummery
    {
        [Key]
        public int SummeryID { get; set; }
        public int EmployeeID { get; set; }
        public int RatingsID { get; set; }
        public int SkillID { get; set; }
       

        public Ratings Ratings { get; set; }
        public Skills Skills { get; set; }
        public EmployeeData EmployeeData { get; set; }
    }
}