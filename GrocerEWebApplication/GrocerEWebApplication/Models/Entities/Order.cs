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




        public Item Item
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



        private Double SubTotal
        {
            get
            {
                return Item.Price * Amount;
            }
        }


        private Double SubTotalTax
        {
            //add 0.13 as constant
            get
            {
                return (SubTotal * 0.13);
            }
        }



        public Order(Item item, int amount)
        {
            _item = item;

            _amount = amount;
        }



       




    }
}