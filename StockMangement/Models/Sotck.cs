﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMangement.Models
{
    public class Sotck
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

        private int _price;
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}