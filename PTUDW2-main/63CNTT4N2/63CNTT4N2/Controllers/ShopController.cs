using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _63CNTT4N2.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Chenkout() 
        {
            return View();
        }

        public ActionResult Confirmation()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }
    }
}