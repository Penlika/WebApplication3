﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [HitCounter]
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Send(MailInfo Model)
        {
            var mail = new SmtpClient("smtp.gmail.com", 25)
            {
                Credentials = new NetworkCredential("maituananhngunhuconcu@gmail.com", "ytta xevh drys dbcq"),
                EnableSsl = true
            };
            var m=new MailMessage();
            m.From = new MailAddress(Model.From);
            m.ReplyToList.Add(Model.From);
            m.To.Add(new MailAddress(Model.To));
            m.Subject = Model.Subject;
            m.Body = Model.Body;
            mail.Send(m);
            return View("Index");
        }
    }
}