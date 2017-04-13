using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryProject.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }

        public int? CategoryID { get; set; }

        public int? ProductID { get; set; }

        public int OrderQuantity { get; set; }

        public double Rate { get; set; }

        public Category Category { get; set; }

        public Product Product { get; set; }
    }
}