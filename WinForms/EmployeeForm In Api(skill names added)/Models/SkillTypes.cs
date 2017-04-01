using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeForm_In_Api.Models
{
    public class SkillTypes
    {
        [Key]
        public int SkillTypeID { get; set; }

        public string SkillTypeName { get; set; }
    }
}