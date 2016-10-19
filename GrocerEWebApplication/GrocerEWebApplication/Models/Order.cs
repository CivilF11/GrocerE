using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models
{
    public class Order
    {

        private Item _item;

        private int _amount;




        public Item OrderList
        {
            get
            {
                return _item;
            }


            set
            {
                _item = value;
            }
        }




        public int Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = value;
            }
        }



        public Order(Item item, int amount)
        {
            _item = item;

            _amount = amount;
        }





    }
}