using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models
{
    public class Item
    {
        //Properties for the items zzzzzzz
        private String _productName;
        private int _productID;
        private int _productPrice;

        public String ProductName
        {
            get
            {
                return _productName;
            }

            set
            {
                _productName = value;
            }
        }



        public int ProductID
        {
            get
            {
                return _productID;
            }

            set
            {
                _productID = value;
            }
        }



        public int ProductPrice
        {
            get
            {
                return _productPrice;
            }

            set
            {
                _productPrice = value;
            }
        }

        public Item(String productName, int productID, int productPrice)
        {
            ProductName = productName;

            ProductID = productID;

            ProductPrice = productPrice;
        }
    }
}