using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeForm_In_Api.Models
{
    public class Ratings
    {
        [Key]
        public int RatingsID { get; set; }

        public string RatingNames { get; set; }

        public int SkillTypeID { get; set; }

        public ICollection<EmployeeData> Employees { get; set; }

        public SkillTypes SkillTypes { get; set; }
    }
}