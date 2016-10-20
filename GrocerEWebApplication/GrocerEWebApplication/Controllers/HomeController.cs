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


        public HomeController()
        {
            _inventory = new InventoryManager();
        }



        // GET: Home
        public ActionResult Index()
        {
            return View(_inventory.Inventory);
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
            return View();
        }
    }
}