using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMangement.Models
{
    public class Order
    {
        public Nullable<int> Fk_StockID { get; set; }


        public static double GetNewPrice()
        {
            double Price = 50 + new Random().NextDouble();
            return Price;
        }
        private Double _price = Order.GetNewPrice();
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
        public int Comession
        {
            get { return _comession; }
            set { _comession = value; }
        }
    }
}