using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RP_ASPweb.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        IDbCrud db;
        public MenuController(IDbCrud context)
        {
            db = context; 

        }
        public ActionResult Index()
        {
            return View();
        }

     

        public ActionResult ListSuplier()
        {
            var items = db.GetAllSuplier();
            return View(items);
        }

        public ActionResult Operations()
        {
            return View();
        }
    }
}