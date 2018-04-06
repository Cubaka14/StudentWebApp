using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GETDomaci.Models;
namespace GETDomaci.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Personal()
        {
            ViewBag.Message = "Student info page.";

            return View();
        }
        
    }
}