namespace EmployeeForm_In_Api.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("name=EmployeeContext")
        {
        }
        public DbSet<EmployeeData> employeeData { get; set; }

        public DbSet<Designation> designationName { get; set; }

        public DbSet<Ratings> ratings { get; set; }

        public DbSet<Skills> skills { get; set; }

        public DbSet<SkillTypes> skilltype { get; set; }

        public DbSet<EmployeeSummery> EmployeeSummery { get; set; }

        public class ToDoDbCreator : DropCreateDatabaseIfModelChanges<EmployeeContext>
        {

        }
    }
}
