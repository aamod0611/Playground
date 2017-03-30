using EmployeeForm_In_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeForm_In_Api.Controllers
{
    public class EmployeeApiController : ApiController
    {
        EmployeeData data = new EmployeeData();
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
            return Db.designationName.ToList();

        }

    }
}
