namespace InventoryProject.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InventoryContext : DbContext
    {
        public InventoryContext()
            : base("name=InventoryContext")
        {
        }
        public DbSet<Category> Category { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<IsDiscontinued> IsDiscontinued { get; set; }
        

        public class ToDoDbCreator : DropCreateDatabaseIfModelChanges<InventoryContext>
        {

        }
    }
}
