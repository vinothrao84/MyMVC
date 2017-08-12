using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyMVC.Models;

namespace MyMVC.Areas.User.Controllers
{
    public class UserContextsController : Controller
    {
        private DataMgmtEntities db = new DataMgmtEntities();

        // GET: User/UserContexts
        public ActionResult Index()
        {
            var userContexts = db.UserContexts.Include(u => u.Inventories);
            return View(userContexts.ToList());
        }

        // GET: User/UserContexts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserContext userContext = db.UserContexts.Find(id);
            if (userContext == null)
            {
                return HttpNotFound();
            }
            return View(userContext);
        }

        // GET: User/UserContexts/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.InventoryContexts, "ID", "Name");
            return View();
        }

        // POST: User/UserContexts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Username,Password,Email,DOB,Active")] UserContext userContext)
        {
            if (ModelState.IsValid)
            {
                db.UserContexts.Add(userContext);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.InventoryContexts, "ID", "Name", userContext.ID);
            return View(userContext);
        }

        // GET: User/UserContexts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserContext userContext = db.UserContexts.Find(id);
            if (userContext == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.InventoryContexts, "ID", "Name", userContext.ID);
            return View(userContext);
        }

        // POST: User/UserContexts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Username,Password,Email,DOB,Active")] UserContext userContext)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userContext).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.InventoryContexts, "ID", "Name", userContext.ID);
            return View(userContext);
        }

        // GET: User/UserContexts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserContext userContext = db.UserContexts.Find(id);
            if (userContext == null)
            {
                return HttpNotFound();
            }
            return View(userContext);
        }

        // POST: User/UserContexts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserContext userContext = db.UserContexts.Find(id);
            db.UserContexts.Remove(userContext);
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
