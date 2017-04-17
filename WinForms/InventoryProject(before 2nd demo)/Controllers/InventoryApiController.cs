using InventoryProject.Models;
using InventoryProject.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;

namespace InventoryProject.Controllers
{
    [RoutePrefix("api/InventoryApi")]
    public class InventoryApiController : ApiController
    {
        InventoryContext Db = new InventoryContext();
        Product products = new Product();
        [HttpGet]
        [Route("GetProduct")]
        public IEnumerable<Product> GetProduct()
        {

            return Db.Product.ToList();

        }

    [HttpDelete]
        public void DeleteDetail(int id)
        {

            var del = Db.Product.First(x => x.ProductID == id);
            Db.Product.Remove(del);
            Db.SaveChanges();

        }

        [HttpPost]
        [Route("PostData")]
        public void PostData([FromBody]Product data)
        {
            if (ModelState.IsValid)
            {
                Db.Product.Add(new Product { CategoryID = data.CategoryID, ProductCode = data.ProductCode, ProductName = data.ProductName, IsDiscontinuedID = data.IsDiscontinuedID, UnitPrice = data.UnitPrice, QtyInStock = data.QtyInStock, ReOrderLevel = data.ReOrderLevel });
                Db.SaveChanges();
            }
        }

        [HttpPut]
        public void EditDetails(int Id,Product p)
        {

            var EditValue = Db.Product.First(x => x.ProductID == Id);
            EditValue.ProductName = p.ProductName;
            EditValue.ProductCode = p.ProductCode;          
            EditValue.UnitPrice = p.UnitPrice;
            EditValue.QtyInStock = p.QtyInStock;
            EditValue.ReOrderLevel = p.ReOrderLevel;
            Db.SaveChanges();

        }


        [HttpGet]
        [Route("GetCategory")]
        public IEnumerable<Category> GetCategory()
        {
   
            return Db.Category.ToList();

        }

        [HttpGet]
        [Route("GetIsDiscontinued")]
        public IEnumerable<IsDiscontinued> GetIsDiscontinued()
        {

            return Db.IsDiscontinued.ToList();

        }



        [HttpGet]
        [Route("GetProductList")]
        public IEnumerable<Product> GetProductList(int Prodvalue)
        {          
                var ProdList = Db.Product.Where(c => c.CategoryID == Prodvalue && c.IsDiscontinuedID == 2);
                return ProdList;
            
        }
        [HttpGet]
        [Route("GetQuantity")]
        public int GetQuantity(int id)
        {
            int quantity = Db.Product.Where(c => c.ProductID == id).Select(x=>x.QtyInStock).Single();
            return quantity;

        }

        [HttpGet]
        [Route("GetRate")]
        public int GetRate(int id)
        {        
            double Rate = Db.Product.Where(c => c.ProductID == id).Select(x =>x.UnitPrice).Single();
            var pp = Convert.ToInt32(Rate);
            return pp;

        }

        [HttpPost]
        [Route("PostSalesData")]
        public async void PostSalesData([FromBody]OrderItem data)
        {
            if (ModelState.IsValid)
            {
                //ProductQuantity Vm = new ProductQuantity();
                Product p = Db.Product.Where(x => x.ProductID == data.ProductID).Single();              
                    p.QtyInStock = p.QtyInStock - data.OrderQuantity;
                    Db.OrderItem.Add(new OrderItem { Rate = data.Rate, OrderQuantity = data.OrderQuantity, ProductID = data.ProductID, CategoryID = data.CategoryID });
                    if (p.QtyInStock < p.ReOrderLevel)
                    {
                        Db.SaveChanges();

                        var body = "<p>Email From: itsupport (itsupport@creativecapsule.com)</p><p>Message: I want more product</p><p></p>";
                        var message = new MailMessage();
                        message.To.Add(new MailAddress("Aamod0611@gmail.com"));  // replace with valid value 
                        message.From = new MailAddress("itsupport@creativecapsule.com");  // replace with valid value
                        message.Subject = "Require stock ";
                        message.Body = body;
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

                        }

                    }
                
                
                Db.SaveChanges();                
            }
        }
       }
    }
