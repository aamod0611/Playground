using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeForm_In_Api.Models
{
    public class Designation
    {
        //public int DesignationId { get; set; }

        //public string DesignationName { get; set; }

        public int DesignationID { get; set; }
        public string DesignationName { get; set; }

        public virtual ICollection<EmployeeData> Employees { get; set; }
    }
}