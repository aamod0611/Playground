using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public int ProductCode { get; set; }

        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        public string IsDiscontinued { get; set; }

        public double UnitPrice { get; set; }

        public int QtyInStock { get; set; }

        public int ReOrderLevel { get; set; }

        public Category Category { get; set; }
    }
}