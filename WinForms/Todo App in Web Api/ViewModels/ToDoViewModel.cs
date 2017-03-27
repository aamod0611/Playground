using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Todo_App_in_Web_Api.Models;

namespace Todo_App_in_Web_Api.ViewModels
{
    public class ToDoViewModel
    {
        public int Id { get; set; }

        public string TaskName { get; set; }

        public List<Todo> TaskList { get; set; }
    }
}