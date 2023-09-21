using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class UpFileController : Controller
    {
        // GET: UpFile
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Upload()
        {
            var image = Request.Files["image"];
            var document = Request.Files["Document"];
            var path = Server.MapPath("~/UploadFile/");
            if (image!=null&& image.ContentLength > 0)
            {
                image.SaveAs(path+image.FileName);
                ViewBag.FileNameImage=image.FileName;
            }
            if(document!=null&& document.ContentLength > 0)
            {
                document.SaveAs(path+document.FileName);
                ViewBag.FileName=document.FileName;
                ViewBag.FileSize = document.ContentLength;
                ViewBag.FileStyle=document.ContentType;
            }
            return View();
        }
    }
}