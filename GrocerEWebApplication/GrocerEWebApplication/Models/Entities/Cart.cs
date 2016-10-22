using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models
{
    public class Cart
    {



        private Dictionary<String, Order> _contents;



        public Dictionary<String, Order> Contents
        {
            get
            {
                return _contents;
            }

            set
            {
                _contents = value;
            }
        }






        public Cart()
        {
            Contents = new Dictionary<String, Order>();
        }



        public double GetItemSubTotal()
        {
            double total = 0;

            foreach (KeyValuePair<String, Order> order in Contents)
            {
                total += order.Value.SubTotal;
            }

            return total;
        }


        public double GetItemTaxTotal()
        {
            double total = 0;

            foreach (KeyValuePair<String, Order> order in Contents)
            {
                total += order.Value.SubTotalTax;
            }

            return total;
        }



        public double GetFinalTotal()
        {
            return (GetItemSubTotal() + GetItemTaxTotal());
        }

    }
}