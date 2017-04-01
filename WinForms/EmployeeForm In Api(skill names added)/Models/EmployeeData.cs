using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeForm_In_Api.Models
{
    public class EmployeeData
    {
        //public int Id { get; set; }

        //public string Name { get; set; }

        //public int DesignationId { get; set; }

        //public string Email { get; set; }

        //public Designation Designation { get; set; }
        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public int DesignationID { get; set; }

        public string Email { get; set; }

        public Designation Designation { get; set; }
        

    }
}