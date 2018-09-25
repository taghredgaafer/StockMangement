using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMangement.Models
{
    public class Order
    { // here i need to look again //
        public Nullable<int> Fk_StockID { get /*{return  ; }*/; set /*{; }*/; } 



        private Double _price;
        public Double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private int _comession;
        public  int Comession
        {
            get { return _comession; }
            set { _comession = value; }
        }

        public static List<Order> ord = new List<Order>
        {
            new Order { Fk_StockID = 1 , Price = 40 , Quantity = 10 , Comession = 10},
            new Order { Fk_StockID = 2 , Price = 55 , Quantity = 20 , Comession = 40}
        };

        public static List<Order> GetAll()
        {
            return Order.ord;
        }
    }
}