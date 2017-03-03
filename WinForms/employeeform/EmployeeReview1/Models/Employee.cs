using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeReview1.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public DevSkillsRatings DeveloperSkills { get; set; }
        public TechSkillsRatings TechnicalSkills { get; set; }

        public Employee()
        {
            DeveloperSkills = new DevSkillsRatings();
            TechnicalSkills = new TechSkillsRatings();
        }
    }

    public class DevSkillsRatings
    {
        public int CodingSkills { get; set; }
        public int TroubleShooting { get; set;}
        public int QualityAssurance { get; set; }
        public int TimeLogging { get; set; }
        public int RequirementsAnalysis { get; set; }
    }

    public class TechSkillsRatings
    {
        public int CSharp { get; set; }
        public int Java { get; set; }
        public int AngularJs { get; set; }
        public int NodeJs { get; set; }
    }
}
