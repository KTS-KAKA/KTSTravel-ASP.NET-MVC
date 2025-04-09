using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KTSTRAVEL.Models;

namespace KTSTRAVEL.Controllers
{
    public class userAccountsController : Controller
    {
        private TravelKTSEntities db = new TravelKTSEntities();

        // GET: userAccounts
        public ActionResult Index()
        {
            var userAccounts = db.userAccounts.Include(u => u.userAccount2);
            return View(userAccounts.ToList());
        }

        // GET: userAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userAccount userAccount = db.userAccounts.Find(id);
            if (userAccount == null)
            {
                return HttpNotFound();
            }
            return View(userAccount);
        }

        // GET: userAccounts/Create
        public ActionResult Create()
        {
            ViewBag.personId = new SelectList(db.userAccounts, "userId", "fullName");
            return View();
        }

        // POST: userAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userId,fullName,email,phoneNumber,password,role,createdAt,status,dateEdited,personId")] userAccount userAccount)
        {
            if (ModelState.IsValid)
            {
                db.userAccounts.Add(userAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.personId = new SelectList(db.userAccounts, "userId", "fullName", userAccount.personId);
            return View(userAccount);
        }

        // GET: userAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userAccount userAccount = db.userAccounts.Find(id);
            if (userAccount == null)
            {
                return HttpNotFound();
            }
            ViewBag.personId = new SelectList(db.userAccounts, "userId", "fullName", userAccount.personId);
            return View(userAccount);
        }

        // POST: userAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userId,fullName,email,phoneNumber,password,role,createdAt,status,dateEdited,personId")] userAccount userAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.personId = new SelectList(db.userAccounts, "userId", "fullName", userAccount.personId);
            return View(userAccount);
        }

        // GET: userAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            userAccount userAccount = db.userAccounts.Find(id);
            if (userAccount == null)
            {
                return HttpNotFound();
            }
            return View(userAccount);
        }

        // POST: userAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            userAccount userAccount = db.userAccounts.Find(id);
            db.userAccounts.Remove(userAccount);
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
