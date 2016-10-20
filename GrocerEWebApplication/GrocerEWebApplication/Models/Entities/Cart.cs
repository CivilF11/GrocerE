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
        
    }
}