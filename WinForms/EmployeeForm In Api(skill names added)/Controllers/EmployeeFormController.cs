using EmployeeForm_In_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeForm_In_Api.Controllers
{
    public class EmployeeFormController : Controller
    {
        // GET: EmployeeForm
        EmployeeData data = new EmployeeData();
        EmployeeContext Db = new EmployeeContext();

       // EmployeeApiController Api = new EmployeeApiController();

        public ActionResult Index()
        {
              // Db.employeeData.Add(new EmployeeData { EmployeeName = "hi" });
             //Db.SaveChanges();
            //ViewBag.designationList = new SelectList(Api.GetDesignation(), "DesignationID", "DesignationName");
             
            return View();
        }
        public ActionResult Selectskills()
        {
            return View();
        }
        public ActionResult DeveloperSkills()
        {
            return View();
        }
    }
}