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
            double s = Stock.GetStockPrice();
            Random r =  new Random();
            
            List<Stock> sto = new List<Stock>
            {
                
            new Stock {ID = 1 , Name = "Vianet" , Price = r.Next(1,100) },
            new Stock {ID = 2 , Name = "Agritek", Price = r.Next(1,100) },
            new Stock {ID = 3 , Name = "Akamai",  Price = r.Next(1,100) },
            new Stock {ID = 4 , Name = "Baidu" ,  Price = r.Next(1,100) },
            new Stock {ID = 5 , Name = "Blinkx",  Price = r.Next(1,100) },
            new Stock {ID = 6 , Name = "Blucora", Price = r.Next(1,100) },
            new Stock {ID = 7 , Name = "Boingo" , Price = r.Next(1,100) },
            new Stock {ID = 8 , Name = "Brainybrawn", Price = r.Next(1,100)},
            new Stock {ID = 9 , Name = "Carbonite", Price = r.Next(1,100)},
            new Stock {ID = 10 , Name = "China Finance" , Price = r.Next(1,100)},
            new Stock {ID = 11, Name = "ChinaCache" , Price = r.Next(1,100)},
            new Stock {ID = 12, Name = "ADR", Price = r.Next(1,100)},
            new Stock {ID = 13, Name = "ChitrChatr", Price = r.Next(1,100)},
            new Stock {ID = 14, Name = "Cnova" , Price = r.Next(1,100)},
            new Stock {ID = 15, Name = "Cogent" , Price = r.Next(1,100)},
            new Stock {ID = 16, Name = "Crexendo", Price = r.Next(1,100)},
            new Stock {ID = 17, Name = "CrowdGather" , Price = r.Next(1,100)},
            new Stock {ID = 18, Name = "EarthLink", Price = r.Next(1,100)},
            new Stock {ID = 19, Name = "Eastern", Price = r.Next(1,100) },
            new Stock {ID = 20, Name = "ENDEXX", Price = r.Next(1,100) },
            new Stock {ID = 21, Name = "Envestnet" , Price = r.Next(1,100)},
            new Stock {ID = 22, Name = "Epazz", Price = r.Next(1,100) },
            new Stock {ID = 23, Name = "FlashZero" , Price = r.Next(1,100)},
            new Stock {ID = 24, Name = "Genesis" , Price = r.Next(1,100)},
            new Stock {ID = 25, Name = "InterNAP", Price = r.Next(1,100)},
            new Stock {ID = 26, Name = "MeetMe", Price = r.Next(1,100) },
            new Stock {ID = 27, Name = "Netease" , Price = r.Next(1,100)},
            new Stock {ID = 28, Name = "Qihoo", Price = r.Next(1,100) },

            };

           


                /*---test of work-----*/
                //int[] vs =Stock.initarr();
                //ViewBag.pri = vs;
                /*---------*/

                ViewBag.stock = sto;
                return View();
        }
        

        [HttpPost]
        public ActionResult Market(Stock sto)
        { 
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }
    }
}