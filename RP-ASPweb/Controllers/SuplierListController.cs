using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RP_ASPweb.Controllers
{
    public class SuplierListController : Controller
    {
        IDbCrud db;
        public SuplierListController(IDbCrud context)
        {
            db = context;

        }
        // GET: SuplierList
        public ActionResult ListSuplier()
        {
            var item = db.GetAllSuplier();
            return View(item);
        }
    }
}