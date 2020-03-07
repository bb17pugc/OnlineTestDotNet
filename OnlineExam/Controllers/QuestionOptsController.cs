using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineExam.Models;

namespace OnlineExam.Controllers
{
    public class QuestionOptsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: QuestionOpts
        public ActionResult Index()
        {
            return View(db.QuestionOpts.ToList());
        }

        // GET: QuestionOpts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionOpt questionOpt = db.QuestionOpts.Find(id);
            if (questionOpt == null)
            {
                return HttpNotFound();
            }
            return View(questionOpt);
        }

        // GET: QuestionOpts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionOpts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Option,Correct")] QuestionOpt questionOpt)
        {
            if (ModelState.IsValid)
            {
                db.QuestionOpts.Add(questionOpt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(questionOpt);
        }

        // GET: QuestionOpts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionOpt questionOpt = db.QuestionOpts.Find(id);
            if (questionOpt == null)
            {
                return HttpNotFound();
            }
            return View(questionOpt);
        }

        // POST: QuestionOpts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Option,Correct")] QuestionOpt questionOpt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionOpt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(questionOpt);
        }

        // GET: QuestionOpts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionOpt questionOpt = db.QuestionOpts.Find(id);
            if (questionOpt == null)
            {
                return HttpNotFound();
            }
            return View(questionOpt);
        }

        // POST: QuestionOpts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuestionOpt questionOpt = db.QuestionOpts.Find(id);
            db.QuestionOpts.Remove(questionOpt);
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
