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
        

        public ActionResult Add()
        {
           
            return View();
        }
        public ActionResult Sales()
        {
            return View();
        }
        public ActionResult Contact()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(MVCEmail model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: itsupport ({1})</p><p>Message:</p><p></p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("Aamod0611@gmail.com"));  // replace with valid value 
                message.From = new MailAddress("itsupport@creativecapsule.com");  // replace with valid value
                message.Subject = "Require stock ";
                message.Body =body;
                message.IsBodyHtml = true;

                ServicePointManager.ServerCertificateValidationCallback =
    delegate (object s, X509Certificate certificate,
             X509Chain chain, SslPolicyErrors sslPolicyErrors)
    { return true; };


                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "user@outlook.com",  // replace with valid value
                        Password = "password"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "zuari.creativecapsule.local";
                    smtp.Port = 25;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

        public ActionResult PostSalesProduct(OrderItem data)
        {
            Product p = Db.Product.Where(x => x.ProductID == data.ProductID).Single();

            if (data.OrderQuantity < p.QtyInStock)
            {
                p.QtyInStock = p.QtyInStock - data.OrderQuantity;
                Db.OrderItem.Add(new OrderItem { Rate = data.Rate, OrderQuantity = data.OrderQuantity, ProductID = data.ProductID, CategoryID = data.CategoryID });
                if(p.QtyInStock< p.ReOrderLevel)
                {
                    Db.SaveChanges();
                    return RedirectToAction("Contact");
                }
                Db.SaveChanges();
            }
            else
            {
                return RedirectToAction("QuantityNotFound");
            }
            return View();
        }
        public ActionResult QuantityNotFound()
        {
            return View();
        }

        public ActionResult Sent()
        {
            return View();
        }
    }
}
