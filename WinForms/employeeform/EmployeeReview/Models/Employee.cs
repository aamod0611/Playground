using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReview.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public DevSkills DeveloperSkills { get; set; }
        public TechSkills TechnicalSkills { get; set; }

        public Employee()
        {
            DeveloperSkills = new DevSkills();
            TechnicalSkills = new TechSkills();
        }
    }

    public class DevSkills
    {
        public int CodingSkills { get; set; }
        public int TroubleShooting { get; set;}
        public int QualityAssurance { get; set; }
        public int TimeLogging { get; set; }
    }

    public class TechSkills
    {
        public int CSharp { get; set; }
        public int Java { get; set; }
        public int AngularJs { get; set; }
        public int NodeJs { get; set; }
    }
}
