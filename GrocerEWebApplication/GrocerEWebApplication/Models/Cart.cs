using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models
{
    public class Cart
    {
        private List<Order> _contents;

        private Double _subTotal;



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



        public Double SubTotal
        {
            get
            {
                //todo implement
                return _subTotal;
            }
        }




        public Cart()
        {

            Contents = new List<Order>();

        }
        
    }
}