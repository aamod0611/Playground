using EmployeeForm_In_Api.Models;
using EmployeeForm_In_Api.Models.ViewModel;
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
        [ActionName("PostPersonalDetails")]
        public int PostPersonalDetails([FromBody] EmployeeData data)
        {
            //Db.employeeData.Add(data);
           Db.employeeData.Add(data);
           Db.SaveChanges();
            return data.EmployeeID;
          //  return data.EmployeeID;
        }



        [ActionName("PostRatings")]
        public void PostRatings([FromBody] EmployeeSummery data)
        {
            Db.EmployeeSummery.Add(new EmployeeSummery { RatingsID = data.RatingsID, EmployeeID = data.EmployeeID, SkillID = data.SkillID });
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
            List<Ratings> li = Db.ratings.Where(x => x.SkillTypeID == id).ToList();            
            return li;
        }

        [ActionName("GetSkillNames")]
        public IEnumerable<Skills> GetSkillNames(int id)
        {
            List<Skills> li = Db.skills.Where(x => x.SkillTypeID == 1).ToList();
            return li;


        }
        //[ActionName("GetTechRatings")]
        //public IEnumerable<Ratings> GetTechRatings(int id)
        //{
        //    var li = Db.ratings.Where(x => x.SkillTypeID == 2).ToList();
        //    return li;


        //}
        [ActionName("GetTechSkillNames")]
        public IEnumerable<Skills> GetTechSkillNames(int id)
        {
            var li = Db.skills.Where(x => x.SkillTypeID == 2).ToList();
            return li;
        }

        [ActionName("GetSummary")]
        public IEnumerable<SummaryViewModel> GetSummary(int id)
        {
            SummaryViewModel sumobj = new SummaryViewModel();
            IList<SummaryViewModel> li = (from x in Db.EmployeeSummery
                                          where x.EmployeeID==id
                                          select new SummaryViewModel
                                          { EmployeeName = x.EmployeeData.EmployeeName,
                                            RatingNames = x.Ratings.RatingNames,
                                            SkillNames = x.Skills.SkillNames
                                          }).ToList();
            //foreach (var x in Db.EmployeeSummery)
            //  {   
            //      sumobj.EmployeeName = x.EmployeeData.EmployeeName;
            //      sumobj.RatingNames = x.Ratings.RatingNames;
            //      sumobj.SkillNames = x.Skills.SkillNames;
            //      li.Add(sumobj);
            //  }
            //List<EmployeeSummery> li = Db.EmployeeSummery.Where(x => x.EmployeeID == id).ToList();
            return li;
        }
    }
}
