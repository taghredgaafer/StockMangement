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

            List<Stock> sto = new List<Stock>
            {
            new Stock {ID = 1 , Name = "Vianet" , Price = s+20  },
            new Stock {ID = 2 , Name = "Agritek", Price = s+10 },
            new Stock {ID = 3 , Name = "Akamai",  Price = s+30},
            new Stock {ID = 4 , Name = "Baidu" ,  Price = s+70},
            new Stock {ID = 5 , Name = "Blinkx",  Price = s+12},
            new Stock {ID = 6 , Name = "Blucora", Price = s+26 },
            new Stock {ID = 7 , Name = "Boingo" , Price = s+37},
            new Stock {ID = 8 , Name = "Brainybrawn", Price = s+42},
            new Stock {ID = 9 , Name = "Carbonite", Price = s },
            new Stock {ID = 10 , Name = "China Finance" , Price = s},
            new Stock {ID = 11, Name = "ChinaCache" , Price = s},
            new Stock {ID = 12, Name = "ADR", Price = s},
            new Stock {ID = 13, Name = "ChitrChatr", Price = s},
            new Stock {ID = 14, Name = "Cnova" , Price = s},
            new Stock {ID = 15, Name = "Cogent" , Price = s},
            new Stock {ID = 16, Name = "Crexendo", Price = s},
            new Stock {ID = 17, Name = "CrowdGather" , Price = s},
            new Stock {ID = 18, Name = "EarthLink", Price = s},
            new Stock {ID = 19, Name = "Eastern", Price = s },
            new Stock {ID = 20, Name = "ENDEXX", Price = s },
            new Stock {ID = 21, Name = "Envestnet" , Price = s},
            new Stock {ID = 22, Name = "Epazz", Price = s },
            new Stock {ID = 23, Name = "FlashZero" , Price = s},
            new Stock {ID = 24, Name = "Genesis" , Price = s},
            new Stock {ID = 25, Name = "InterNAP", Price = s},
            new Stock {ID = 26, Name = "MeetMe", Price = s },
            new Stock {ID = 27, Name = "Netease" , Price = s},
            new Stock {ID = 28, Name = "Qihoo", Price = s },

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