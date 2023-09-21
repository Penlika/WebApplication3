using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(string MaSV,string HoTenSV,double DiemSo)
        {
            try
            {
                var path = Server.MapPath("~/Data.txt");
                string[] lines = { MaSV, HoTenSV, DiemSo.ToString() };
                System.IO.File.WriteAllLines(path, lines);
                ViewBag.KetQua = "Ghi thành công";
            }
            catch(Exception ex)
            {
                ViewBag.KetQua = "Ghi thất bại";
            }
            return View("Index");
        }
        public ActionResult Open()
        {
            try
            {
                var path = Server.MapPath("~/Data.txt");
                string[] lines=System.IO.File.ReadAllLines(path);
                ViewBag.MaSV = lines[0];
                ViewBag.HoTenSV = lines[1];
                ViewBag.DiemSo = lines[2];
                ViewBag.KetQua = "Đọc thành công";
            }
            catch(Exception ex)
            {
                ViewBag.KetQua = "Đọc thất bại";
            }
            return View("Index");
        }
    }
}