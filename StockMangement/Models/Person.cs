using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMangement.Models
{
    public class Person
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

        public  List<Order> Orders { get { return Order.ord; } set { Orders = value ; } }
       
        public Person()
        {
            Orders = new List<Order>(Order.GetAll());
        }
       
        public static List<Person> per = new List<Person>
        {
            new Person {ID =1 , Name = "person one", Orders = Order.ord.ToList()   },
            new Person {ID =2 , Name = "person two", Orders = Order.ord.ToList()  },
        };
        public static List<Person> GetAll()
        {
            return Person.per;
        }
    }
}