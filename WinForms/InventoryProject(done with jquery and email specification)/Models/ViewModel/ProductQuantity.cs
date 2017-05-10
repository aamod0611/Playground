using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryProject.Models.ViewModel
{
    public class ProductQuantity
    {
      
        public int ProductID { get; set; }
        public List<OrderItem> list1 { get; set; }
        public List<Product> list { get; set; }
    }
}