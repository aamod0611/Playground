using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeForm_In_Api.Models
{
    public class Skills
    {
        [Key]
        public int SkillID { get; set; }

        public string SkillNames { get; set; }

        public int SkillTypeID { get; set; }

        public ICollection<EmployeeData> Employees { get; set; }

        public SkillTypes SkillTypes { get; set; }


    }
}