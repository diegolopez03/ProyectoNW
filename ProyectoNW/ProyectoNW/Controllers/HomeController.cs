using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoNW.Data;
using ProyectoNW.Models;

namespace ProyectoNW.Controllers
{
    public class HomeController : Controller
    {
        private ProyectoNWContext db = new ProyectoNWContext();
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Provider);
            return View(products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Galeria(int? id)
        {

            var products = db.Products.Include(p => p.Category).Include(p => p.Provider).Where(c => c.CategoryKey == id);
            return View(products.ToList());

            
        }



    }
}