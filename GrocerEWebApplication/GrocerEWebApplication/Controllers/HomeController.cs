﻿using GrocerEWebApplication.Models;
using GrocerEWebApplication.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrocerEWebApplication.Controllers
{
    public class HomeController : Controller
    {

        private InventoryManager _inventory;

        private Cart _shoppingCart;


        public HomeController()
        {
            _inventory = new InventoryManager();

            _shoppingCart = new Cart();
        }



        // GET: Home
        public ActionResult Index()
        {
            return View("Index", _inventory.Inventory);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Inventory()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ShoppingCart()
        {
            return View(_shoppingCart.Contents);
        }



        public ActionResult AddToCart()
        {
            int id = int.Parse(Request.Form.AllKeys[0]);

            Item item = _inventory.GetItemByID(id);

            if (item != null)
            {
                Order order = new Order(item, 1);

                _shoppingCart.Contents.Add(order);
            }

            return View("Index", _inventory.Inventory);
        }
    }
}