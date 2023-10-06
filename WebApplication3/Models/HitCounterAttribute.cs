using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class HitCounterAttribute : ActionFilterAttribute
    {
        private void UpdateCounter()
        {
            try
            {
                var f = new StreamReader(HttpContext.Current.Server.MapPath("~/HitCounter.txt"));
                var line = f.ReadLine();
                var count = 1;
                if (line != null)
                {
                    count = Convert.ToInt32(line);
                }
                f.Close();
                var sw = new StreamWriter(HttpContext.Current.Server.MapPath("~/HitCounter.txt"));
                sw.WriteLine(++count);
                sw.Close();
            }
            catch (Exception ex)
            {
            }
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            UpdateCounter();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}