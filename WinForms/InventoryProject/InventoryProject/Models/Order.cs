using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryProject.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public double TotalPrice { get; set; }

    }
}