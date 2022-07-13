using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarcosCosta.Front.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.BearerToken = ConfigurationManager.AppSettings["BearerToken"].ToString();
            return View();
        }
    }
}