using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using ToDO_App_CodeFirst.Models.EF;

namespace ToDO_App_CodeFirst.Models
{
    public class ToDoModels
    {
        public int Id { get; set ; }

        public string Taskname { get; set; }

        public List<Task> TaskList { get; set; }
    }
}