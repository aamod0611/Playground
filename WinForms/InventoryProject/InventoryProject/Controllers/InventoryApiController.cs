using InventoryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InventoryProject.Controllers
{
    [RoutePrefix("api/InventoryApi")]
    public class InventoryApiController : ApiController
    {
        InventoryContext Db = new InventoryContext();

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
            Db.Product.Add(new Product { CategoryID = data.CategoryID, ProductCode = data.ProductCode,  ProductName = data.ProductName, IsDiscontinued = data.IsDiscontinued, UnitPrice = data.UnitPrice, QtyInStock = data.QtyInStock, ReOrderLevel = data.ReOrderLevel });
            Db.SaveChanges();
        }

        [HttpPut]
        public void EditDetails(int Id, [FromBody]string ProductName)
        {

            var EditValue = Db.Product.First(x => x.ProductID == Id);
            EditValue.ProductName = ProductName;
            Db.SaveChanges();

        }

        [HttpGet]
        [Route("GetCategory")]
        public IEnumerable<Category> GetCategory()
        {
   
            return Db.Category.ToList();

        }

        [HttpGet]
        [Route("GetProductList")]
        public IEnumerable<Product> GetProductList(int Prodvalue)
        {
            var ProdList = Db.Product.Where(c => c.CategoryID == Prodvalue);
            return ProdList;

        }
        [HttpPost]
        [Route("PostSalesData")]
        public void PostSalesData([FromBody]OrderItem data)
        {
            Db.OrderItem.Add(new OrderItem {  Rate = data.Rate, OrderQuantity = data.OrderQuantity, ProductID = data.ProductID, CategoryID = data.CategoryID});
            Db.SaveChanges();
        }















    }
}
