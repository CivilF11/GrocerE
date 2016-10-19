using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerEWebApplication.Models
{
    public class Account
    {
        private String _username;

        private String _password;

        private String _name;

        private DateTime _joinDate;

        private String _shippingAddress;



        public String Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }



        public String Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }



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



        public String ShippingAddress
        {
            get
            {
                return _shippingAddress;
            }

            set
            {
                _shippingAddress = value;
            }
        }


        public DateTime JoinDate
        {
            get
            {
                return _joinDate;
            }
        }
        
        /*
         * Other properties needed:
         * 
         * Order history
         */


        public Account(String username, String password, String name)
        {
            Username = username;

            Password = password;

            Name = name;

            _joinDate = DateTime.Now;
        }



        


    }
}