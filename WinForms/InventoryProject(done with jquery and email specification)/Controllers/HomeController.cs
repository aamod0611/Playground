using InventoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Text;

namespace InventoryProject.Controllers
{
    public class HomeController : Controller
    {
        InventoryContext Db = new InventoryContext();
        public ActionResult Index()
        {
           // Db.Category.Add(new Category { CategoryName = "Mobile" });
           // Db.SaveChanges();
          
            return View();
        }
        public ActionResult Add()
        {        
            return View();
        }
        public ActionResult Sales()
        {
            return View();
        }
        public JsonResult IsProductCodeExists(int ProductCode)
        {
            //check if any of the UserName matches the UserName specified in the Parameter using the ANY extension method.  
            return Json(!Db.Product.Any(x => x.ProductCode == ProductCode), JsonRequestBehavior.AllowGet);
        }
        public JsonResult ProductName(string ProductName)
        {
            //check if any of the UserName matches the UserName specified in the Parameter using the ANY extension method.  
            return Json(!Db.Product.Any(x => x.ProductName == ProductName), JsonRequestBehavior.AllowGet);
        }
      
        public void DownloadCsv()
        {
            var download = Db.Product.Where(x => x.QtyInStock < x.ReOrderLevel).ToList();
            string facsCsv = GetCsvString(download);

            // Return the file content with response body. 
            Response.ContentType = "text/csv";
            Response.AddHeader("Content-Disposition", "attachment; filename=QuantityInStock.csv");
            Response.Write(facsCsv);
            Response.End();
        }


        private string GetCsvString(IEnumerable<Product> QuantityInStock)
        {
            StringBuilder csv = new StringBuilder();

            csv.AppendLine("ProductCode,ProductName,QtyInStock,CategoryID,ReOrderLevel");

            foreach (Product Quantity in QuantityInStock)
            {
                csv.Append(Quantity.ProductCode + ",");
                csv.Append(Quantity.ProductName + ",");                
                csv.Append(Quantity.QtyInStock + ",");
                csv.Append(Quantity.CategoryID + ",");
                csv.Append(Quantity.ReOrderLevel);

                csv.AppendLine();
            }

            return csv.ToString();
        }


    }
}
