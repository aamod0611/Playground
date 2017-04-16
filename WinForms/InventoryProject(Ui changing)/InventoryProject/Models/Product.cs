using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "ProductCode field is Required")]
        [Remote("IsProductCodeExists", "Home", ErrorMessage = "Product code already in use")]
        public int ProductCode { get; set; }

        [Required(ErrorMessage = "ProductName field is Required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only Alphabets are Allowed")]
        [Remote("ProductName", "Home", ErrorMessage = "Product code already in use")]
        public string ProductName { get; set; }


    
        public int CategoryID { get; set; }



        public int? IsDiscontinuedID { get; set; }


        [RegularExpression("^[0-9]*$", ErrorMessage = "UnitPrice must be numeric")]
        [Required(ErrorMessage = "UnitPrice field is Required")]
        public double UnitPrice { get; set; }


        [RegularExpression("^[0-9]*$", ErrorMessage = "QtyInStock must be numeric")]
        [Required(ErrorMessage = "QtyInStock field is Required")]
        public int QtyInStock { get; set; }


        [RegularExpression("^[0-9]*$", ErrorMessage = "ReOrderLevel must be numeric")]
        [Required(ErrorMessage = "ReOrderLevel field is Required")]
        public int ReOrderLevel { get; set; }

        public IsDiscontinued IsDiscontinued { get; set; }

        public Category Category { get; set; }
    }
}