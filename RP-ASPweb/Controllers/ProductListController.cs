using BLL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RP_ASPweb.Controllers
{
    public class ProductListController : Controller
    {
        // GET: Product
        IDbCrud db;
        //IDiscount dis; 
        public ProductListController(IDbCrud context )
        {
            db = context;
            
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListProduct()
        {
           // var items = db.GetAllProducts().Where(i => i.UnitPrice.HasValue).Select(i => i.UnitPrice).ToList();
            var items = db.GetAllProducts();

            return View(items);
        }

        public ActionResult Discounts()
        {
           int dec = 0;
            
             var items = db.GetAllProducts().Where(i => i.UnitPrice.HasValue).Select(i => i.UnitPrice).ToList();
            foreach (var item in items)
            {
              //  dec = new Discounts(0).GetDiscountedPrice(item);
            }
            
            return View(items);
        }
    }
}