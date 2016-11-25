using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FullHCMS.Models;
using FullHCMS.DAL;

namespace FullHCMS.Controllers
{
    public class HomeController : Controller
    {
        private FullHouseContext db;

        public HomeController()
        {
            db = new FullHouseContext();
        }

        public HomeController(FullHouseContext contextDB)
        {
            this.db = contextDB; 
        }

        // GET: Home
        public ActionResult Index()
        {
            var homes = db.Homes.Include(h => h.Seller);
            return View(homes.ToList());
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.SellerId = new SelectList(db.Sellers, "SellerId", "FullName");
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HomeId,Title,LongDescription,price,size,CompanyId,SellerId,Address1,Address2,PostalCode,State,City")] Home home)
        {
            if (ModelState.IsValid)
            {
                db.Homes.Add(home);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SellerId = new SelectList(db.Sellers, "SellerId", "FullName", home.SellerId);
            return View(home);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Home home = db.Homes.Find(id);
            if (home == null)
            {
                return HttpNotFound();
            }
            ViewBag.SellerId = new SelectList(db.Sellers, "SellerId", "FullName", home.SellerId);
            return View(home);
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HomeId,Title,LongDescription,price,size,CompanyId,SellerId,Address1,Address2,PostalCode,State,City")] Home home)
        {
            if (ModelState.IsValid)
            {
                db.Entry(home).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SellerId = new SelectList(db.Sellers, "SellerId", "FullName", home.SellerId);
            return View(home);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Home home = db.Homes.Find(id);
            db.Homes.Remove(home);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
