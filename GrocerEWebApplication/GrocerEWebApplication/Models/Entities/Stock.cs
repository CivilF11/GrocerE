using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models
{
    public class Stock
    {

        private Item _item;

        private int _quantity;



        public Item Item
        {
            get
            {
                return _item;
            }
        }



        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                _quantity = value;
            }
        }



        public Stock(Item item)
        {
            _item = item;

            _quantity = 0;
        }



        public void AddStock(int amount)
        {
            _quantity += amount;
        }



        public void RemoveStock(int amount)
        {
            _quantity -= amount;
        }
            


    }
}