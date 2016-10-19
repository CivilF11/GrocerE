using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrocerEWebApplication.Controllers
{
    public class ProductBrowserController : Controller
    {
        // GET: ProductBrowser
        public ActionResult Index()
        {
            return View();
        }
    }
}