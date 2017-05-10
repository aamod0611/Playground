using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryProject.Models
{
    public class IsDiscontinued
    {
        [Key]
        public int IsDiscontinuedID { get; set; }

        public string IsDiscontinuedOptions { get; set; }
    }
}