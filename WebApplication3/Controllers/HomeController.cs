using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        ProductDB db=new ProductDB();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Category()
        {
            return PartialView(db.Categories);
        }
        public ActionResult JsonObject()
        {
            var student = new { Name = "anvxx", Class = "D21KPT" };
            return Json(student,JsonRequestBehavior.AllowGet);
        }
    }
}