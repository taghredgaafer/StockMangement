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

            //string s = Stock.GetStockPrice();

            /*---test of work-----*/
            //int[] vs =Stock.initarr();
            //ViewBag.pri = vs;
            /*---------*/
            List<Stock> sto = Stock.GetAll();

            ViewBag.stock = sto;
                return View();
            
        }
        

        [HttpPost]
        public ActionResult Market(Stock sto)
        {
            ViewBag.stock = sto;
            return View("Order");
        }

        public ActionResult Order()
        {
            List<Stock> sto = Stock.GetAll();

            ViewBag.stock = sto;
            return View();
        }
    }
}