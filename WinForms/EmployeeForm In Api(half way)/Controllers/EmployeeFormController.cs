using EmployeeForm_In_Api.Models;
using EmployeeForm_In_Api.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeForm_In_Api.Controllers
{

    public class EmployeeFormController : Controller
    {
        int pageCounter;
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
            pageCounter = 1;
            Session["pageCounter"] = 1;
            return View();
        }




        public ActionResult DeveloperSkills()
        {

            //-------------------- either take ratinglist or change the view to get selected radio button ---------
            EmployeeContext sn = new EmployeeContext();
            EmployeeViewModel vm = new EmployeeViewModel();

            pageCounter = Convert.ToInt32(Session["pageCounter"]);

            vm.Skillslist = Db.skills.Where(x => x.SkillID == pageCounter).ToList();

            Session["pageCounter"] = ++pageCounter;


            int totalCount = sn.skills.Where(x =>x.SkillTypeID==1).Count();

            if (pageCounter > totalCount + 2)
            {
                return RedirectToAction("Selectskills");
            }

            return View(vm);

        }






        public ActionResult TechnicalSkills()
        {
            EmployeeContext sn = new EmployeeContext();
            EmployeeViewModel vm = new EmployeeViewModel();
            pageCounter = 6;
            Session["pageCounter"] = 6;

            pageCounter = Convert.ToInt32(Session["pageCounter"]);

            vm.Skillslist = Db.skills.Where(x => x.SkillID == pageCounter).ToList();

            Session["pageCounter"] = ++pageCounter;


            int totalCount = sn.skills.Count();

            if (pageCounter > totalCount + 1)
            {
                return RedirectToAction("Selectskills");
            }

            return View(vm);

        }
      
        public ActionResult Summery( )
        {
            return View();
        }
    }
}