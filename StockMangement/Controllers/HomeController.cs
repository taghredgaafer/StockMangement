using StockMangement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StockMangement.Controllers
{
    public class HomeController : Controller
    {

       [HttpGet]
        public ActionResult Market()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Market(Sotck sto)
        { 
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }
    }
}