using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Todo_App_in_Web_Api.Models;
using Todo_App_in_Web_Api.ViewModels;

namespace Todo_App_in_Web_Api.Controllers
{
    public class TodoController : Controller
    {
        // GET: Todo
        //TodoContext Db = new TodoContext();
        //ToDoViewModel model = new ToDoViewModel();

        public ActionResult Index()
        {
            //used to create table in db 
            //Db.Task.Add(new Todo { TaskName = "abc" });
            //Db.SaveChanges();
            return View();
        }
    }
}