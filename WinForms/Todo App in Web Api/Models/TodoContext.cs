namespace Todo_App_in_Web_Api.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TodoContext : DbContext
    {
        public TodoContext()
            : base("name=TodoContext")
        {
        }
        public DbSet<Todo> Task { get; set; }

        
        public class ToDoDbCreator : DropCreateDatabaseIfModelChanges<TodoContext>
        {

        }

    }
}
