using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestPract1.DataContext;
using TestPract1.Models;

namespace TestPract1.Controllers
{
    public class SemClassViewModelsController : Controller
    {
        private SemClassDB db = new SemClassDB();

        // GET: SemClassViewModels
        public ActionResult Index()
        {
            return View(db.SemClassViewModel.ToList());
        }

        // GET: SemClassViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SemClassViewModels semClassViewModels = db.SemClassViewModel.Find(id);
            if (semClassViewModels == null)
            {
                return HttpNotFound();
            }
            return View(semClassViewModels);
        }

        // GET: SemClassViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SemClassViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,courseName,courseNumber,semester")] SemClassViewModels semClassViewModels)
        {
            if (ModelState.IsValid)
            {
                db.SemClassViewModel.Add(semClassViewModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(semClassViewModels);
        }

        // GET: SemClassViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SemClassViewModels semClassViewModels = db.SemClassViewModel.Find(id);
            if (semClassViewModels == null)
            {
                return HttpNotFound();
            }
            return View(semClassViewModels);
        }

        // POST: SemClassViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,courseName,courseNumber,semester")] SemClassViewModels semClassViewModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(semClassViewModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(semClassViewModels);
        }

        // GET: SemClassViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SemClassViewModels semClassViewModels = db.SemClassViewModel.Find(id);
            if (semClassViewModels == null)
            {
                return HttpNotFound();
            }
            return View(semClassViewModels);
        }

        // POST: SemClassViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SemClassViewModels semClassViewModels = db.SemClassViewModel.Find(id);
            db.SemClassViewModel.Remove(semClassViewModels);
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
