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
            //Db.employeeData.Add(new EmployeeData { EmployeeName = "hi" });
            //Db.SaveChanges();
            //ViewBag.designationList = new SelectList(Api.GetDesignation(), "DesignationID", "DesignationName");

            return View();
        }
        public ActionResult Selectskills()
        {
                       
                return View();

        }





        public ActionResult DeveloperSkills(int id, int? pageCounter, bool submit = false)
        {
          //  int MainCounter=0;
            Session["type"] = id;
            Session["submit"] = submit;
            if(id == 1 && pageCounter==-1)
            {
              
                pageCounter = 1;
                Session["pageCounter"] = 1;
                Session["MainCounter"] = 1;
            }
            else if(id == 2 && pageCounter==-1)
            {
                Session["MainCounter"] = 5;
                pageCounter = 5;
                Session["pageCounter"] = 5;
            }
            //-------------------- either take ratinglist or change the view to get selected radio button ---------
            EmployeeContext sn = new EmployeeContext();
            EmployeeViewModel vm = new EmployeeViewModel();

            pageCounter = Convert.ToInt32(Session["pageCounter"]);

            vm.Skillslist = Db.skills.Where(x => x.SkillID == pageCounter && x.SkillTypeID == id).ToList();
           

            Session["pageCounter"] = ++pageCounter;


            int totalCount = sn.skills.Where(x => x.SkillTypeID == id).Count();


            if (pageCounter > totalCount + Convert.ToInt32(Session["MainCounter"]))
            {
                return RedirectToAction("Selectskills");
            }

            return View(vm);

        }




        public ActionResult TechnicalSkills()
        {
            Session["type"] = 2;

            return View();

        }

        public ActionResult Summary()
        {
            return View();
        }
    }
}