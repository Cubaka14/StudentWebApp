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
    public class ispitsController : Controller
    {
        private mstudEntities1 db = new mstudEntities1();

        // GET: ispits
        public ActionResult Index()
        {
            var ispits = db.ispits.Include(i => i.dosije).Include(i => i.ispitni_rok).Include(i => i.predmet);
            return View(ispits.ToList());
        }

        // GET: ispits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ispit ispit = db.ispits.Find(id);
            if (ispit == null)
            {
                return HttpNotFound();
            }
            return View(ispit);
        }

        // GET: ispits/Create
        public ActionResult Create()
        {
            ViewBag.indeks = new SelectList(db.dosijes, "indeks", "ime");
            ViewBag.godina_roka = new SelectList(db.ispitni_rok, "godina_roka", "naziv");
            ViewBag.id_predmeta = new SelectList(db.predmets, "id_predmeta", "sifra");
            return View();
        }

        // POST: ispits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "indeks,id_predmeta,godina_roka,oznaka_roka,ocena,datum_ispita,bodovi")] ispit ispit)
        {
            if (ModelState.IsValid)
            {
                db.ispits.Add(ispit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.indeks = new SelectList(db.dosijes, "indeks", "ime", ispit.indeks);
            ViewBag.godina_roka = new SelectList(db.ispitni_rok, "godina_roka", "naziv", ispit.godina_roka);
            ViewBag.id_predmeta = new SelectList(db.predmets, "id_predmeta", "sifra", ispit.id_predmeta);
            return View(ispit);
        }

        // GET: ispits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ispit ispit = db.ispits.Find(id);
            if (ispit == null)
            {
                return HttpNotFound();
            }
            ViewBag.indeks = new SelectList(db.dosijes, "indeks", "ime", ispit.indeks);
            ViewBag.godina_roka = new SelectList(db.ispitni_rok, "godina_roka", "naziv", ispit.godina_roka);
            ViewBag.id_predmeta = new SelectList(db.predmets, "id_predmeta", "sifra", ispit.id_predmeta);
            return View(ispit);
        }

        // POST: ispits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "indeks,id_predmeta,godina_roka,oznaka_roka,ocena,datum_ispita,bodovi")] ispit ispit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ispit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.indeks = new SelectList(db.dosijes, "indeks", "ime", ispit.indeks);
            ViewBag.godina_roka = new SelectList(db.ispitni_rok, "godina_roka", "naziv", ispit.godina_roka);
            ViewBag.id_predmeta = new SelectList(db.predmets, "id_predmeta", "sifra", ispit.id_predmeta);
            return View(ispit);
        }

        // GET: ispits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ispit ispit = db.ispits.Find(id);
            if (ispit == null)
            {
                return HttpNotFound();
            }
            return View(ispit);
        }

        // POST: ispits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ispit ispit = db.ispits.Find(id);
            db.ispits.Remove(ispit);
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
