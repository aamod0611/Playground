using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ToDO_App_CodeFirst.Models.EF
{
    public class ToDoContext : DbContext
    {
        public ToDoContext()
            : base("name=ToDoContext")
        {

        }
        public DbSet<Task> Task { get; set; }
    }
    public class ToDoDbCreator : DropCreateDatabaseIfModelChanges<ToDoContext>
    {

    }
}