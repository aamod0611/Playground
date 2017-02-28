using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeform
{
   public  class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string value { get; set; }

        public int DevSkills_Csharp { get; set; }
        public int DevSkills_Java { get; set; }

        public Employee()
        {
        }
    }


    //public class TechnicalSkills
    //{
    //    public int Ratings { get; set; }
    //    public string Note { get; set; }
    //}

    //public class DeveloperSkills
    //{
    //    public int Ratings { get; set; }
    //    public string Note { get; set; }
    //}
}
