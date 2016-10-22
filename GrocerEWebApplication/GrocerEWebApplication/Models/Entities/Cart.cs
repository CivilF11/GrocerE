using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models
{
    public class Cart
    {



        private List<Order> _contents;



        public List<Order> Contents
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
            Contents = new List<Order>();
        }



        public double GetItemSubTotal()
        {
            double total = 0;

            foreach (Order order in Contents)
            {
                total += order.SubTotal;
            }

            return total;
        }


        public double GetItemTaxTotal()
        {
            double total = 0;

            foreach (Order order in Contents)
            {
                total += order.SubTotalTax;
            }

            return total;
        }



        public double GetFinalTotal()
        {
            return (GetItemSubTotal() + GetItemTaxTotal());
        }

    }
}