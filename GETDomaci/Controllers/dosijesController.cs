using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GETDomaci.Models;

namespace GETDomaci.Controllers
{
    public class dosijesController : Controller
    {
        private mstudEntities1 db = new mstudEntities1();

        // GET: dosijes
        public ActionResult Index()
        {
            return View(db.dosijes.ToList());
        }

        // GET: dosijes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dosije dosije = db.dosijes.Find(id);
            if (dosije == null)
            {
                return HttpNotFound();
            }
            return View(dosije);
        }

        // GET: dosijes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: dosijes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "indeks,ime,prezime,datum_upisa,datum_rodjenja,mesto_rodjenja")] dosije dosije)
        {
            if (ModelState.IsValid)
            {
                db.dosijes.Add(dosije);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dosije);
        }

        // GET: dosijes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dosije dosije = db.dosijes.Find(id);
            if (dosije == null)
            {
                return HttpNotFound();
            }
            return View(dosije);
        }

        // POST: dosijes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "indeks,ime,prezime,datum_upisa,datum_rodjenja,mesto_rodjenja")] dosije dosije)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dosije).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dosije);
        }

        // GET: dosijes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dosije dosije = db.dosijes.Find(id);
            if (dosije == null)
            {
                return HttpNotFound();
            }
            return View(dosije);
        }

        // POST: dosijes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dosije dosije = db.dosijes.Find(id);
            db.dosijes.Remove(dosije);
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
