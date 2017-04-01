using EmployeeForm_In_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeForm_In_Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeApiController : ApiController
    {
        //EmployeeData data = new EmployeeData();
        EmployeeContext Db = new EmployeeContext();

        [HttpPost]
        public void PostPersonalDetails([FromBody] EmployeeData data)
        {
           Db.employeeData.Add(new EmployeeData { EmployeeName = data.EmployeeName , Email = data.Email, DesignationID = data.DesignationID});
           Db.SaveChanges();
            
        }

        [HttpGet]       
        public IEnumerable<Designation> GetDesignation()
        {
           /* List<Designation> li = Db.designationName.ToList()*/;
            return Db.designationName.ToList();

        }

        [ActionName("GetRatings")]
        public IEnumerable<Ratings> GetRatings(int id)
        {
            List<Ratings> li = Db.ratings.Where(x => x.SkillTypeID == 1).ToList();            
            return li;
        }

        [ActionName("GetSkillNames")]
        public IEnumerable<Skills> GetSkillNames(int id)
        {
            List<Skills> li = Db.skills.Where(x => x.SkillTypeID == 1).ToList();
            return li;

        }


    }
}
