using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Todo_App_in_Web_Api.Models;
using Todo_App_in_Web_Api.ViewModels;

namespace Todo_App_in_Web_Api.Controllers
{
    public class TodoDetailsController : ApiController
    {
        TodoContext Db = new TodoContext();
        ToDoViewModel model = new ToDoViewModel();
        public IEnumerable<Todo> GetDetails()
        {
            model.TaskList = Db.Task.ToList();

            return model.TaskList;
        }

        public void PostPersonalDetails([FromBody] ToDoViewModel model)
        {
            Db.Task.Add(new Todo { TaskName = model.TaskName });
            Db.SaveChanges();

        }
        [HttpDelete]
        public void DeleteDetails(int Id)
        {

            Todo todo = Db.Task.First(x => x.Id == Id);
            Db.Task.Remove(todo);
            Db.SaveChanges();

        }

        [HttpPut]
        public void EditDetails(int Id, [FromBody]string item)
        {

            Todo toDo = Db.Task.First(x => x.Id == Id);
            toDo.TaskName = item;
            Db.SaveChanges();

        }

    }
}
