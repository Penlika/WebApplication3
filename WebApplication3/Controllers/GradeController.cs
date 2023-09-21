using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class GradeController : Controller
    {
        SchoolContext db=new SchoolContext();
        // GET: Grade
        public ActionResult Index()
        {
            var result = from s in db.Grades
                         where s.Score >= 9
                         select new { s.Student.StudentName, s.GradeName, s.Score };
            return View();
        }
    }
}