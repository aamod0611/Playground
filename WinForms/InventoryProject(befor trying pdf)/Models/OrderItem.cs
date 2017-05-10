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

        [RegularExpression("^[0-9]*$", ErrorMessage = "OrderQuantity must be numeric")]
        [Required(ErrorMessage = "OrderQuantity field is Required")]    
        public int OrderQuantity { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Rate must be numeric")]
        [Required(ErrorMessage = "Rate field is Required")]      
        public int Rate { get; set; }

        public Category Category { get; set; }

        public Product Product { get; set; }
    }
}