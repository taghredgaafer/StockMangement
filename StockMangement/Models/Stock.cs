using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMangement.Models
{
    public class Stock
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
      
        public static double /*string*/ GetStockPrice()
        {
            double randomStockPrice = 50 + new Random().NextDouble();
            //return randomStockPrice.ToString("C");
            return randomStockPrice;
        }
        private double _price; /*= Stock.GetStockPrice();*/
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

      


        /******** try to generate non repeated random nuber ******/
        public static int[] initarr()
        {
            int[] arr = new int[2];
            Random r = new Random();
            int tmp;
            for (int i = 0; i < arr.Length; i++)
            {
                tmp = r.Next(20);
                while (IsDup(tmp, arr))
                {
                    tmp = r.Next(20);

                }
                arr[i] = tmp;
            }
            return arr;
        }
        public static bool IsDup(int tmp, int[] arr)
        {
            foreach (var item in arr)
            {
                if (item == tmp)
                { return true; }

            }
            return false;
        }


    }
}