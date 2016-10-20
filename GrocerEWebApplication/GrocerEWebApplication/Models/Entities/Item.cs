using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models
{
    public class Item
    {

        private String _name;

        private int _id;

        private Double _price;



        public String Name
        {
            get
            {
                return _name;
            }


            set
            {
                _name = value;
            }
        }



        public int ID
        {
            get
            {
                return _id;
            }
        }


        public Double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }



        public Item(int id, String name, Double price)
        {
            _id = id;

            _name = name;

            _price = price;
        }

    }
}