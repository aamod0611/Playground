using firstmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDO_App_CodeFirst.Models;
using ToDO_App_CodeFirst.Models.EF;

namespace ToDO_App_CodeFirst.Controllers
{

    public class ToDoController : Controller
    {
        ToDoContext Db = new ToDoContext();
        // GET: ToDo
        public ActionResult Index()
        {
            ToDoModels model = new ToDoModels();
            model.TaskList = Db.Task.ToList();
            return View(model);
        }
        public ActionResult AddItem(ToDoModels model)
        {
            if (model.Id == 0)
            {
                Db.Task.Add(new Task { TaskName = model.Taskname });
                Db.SaveChanges();
            }
            else
            {
                Task EditToDo = Db.Task.First(x => x.Id == model.Id);
                EditToDo.Id = model.Id;
                EditToDo.TaskName = model.Taskname;
                Db.SaveChanges();

                //newdata.Deletekey = 0;
            }
            return RedirectToAction("Index");
        }
        public ActionResult RemoveItem(ToDoModels model)
        {
              Task toDo = Db.Task.First(x => x.Id == model.Id);

            Db.Task.Remove(toDo);

            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EditItem(ToDoModels model)
        {


            Task toDo = Db.Task.First(x => x.Id == model.Id);
            model.Id = toDo.Id;
            model.Taskname = toDo.TaskName;
            model.TaskList = Db.Task.ToList();
            return View("Index", model);

           
        }
    }
}