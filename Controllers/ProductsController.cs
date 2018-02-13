using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        // GET: Products/Details
        public ActionResult Details(string Blackview)
        {
            // check for an empty blackview
            if(Blackview == null)
            {
                //return View("Error");
                return RedirectToAction("Index");
            }


            ViewBag.Blackview = Blackview;
            return View();
        }
    }
}