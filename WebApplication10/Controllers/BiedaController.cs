using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class BiedaController : Controller
    {
        private MyDbContext db = new MyDbContext();


        // GET: Bieda
        public ActionResult Index()
        {
            var list = db.Countries.ToList();

            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Country model)
        {
            if (ModelState.IsValid)
            {
                db.Countries.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}