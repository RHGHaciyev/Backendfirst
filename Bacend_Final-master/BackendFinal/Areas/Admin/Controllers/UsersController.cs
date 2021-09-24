using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BackendFinal.Models;

namespace BackendFinal.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private watcherEntities db = new watcherEntities();

        // GET: Admin/Users
        public ActionResult Index()
        {
            return View(db.User_reg.ToList());
        }

        // GET: Admin/Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_reg user_reg = db.User_reg.Find(id);
            if (user_reg == null)
            {
                return HttpNotFound();
            }
            return View(user_reg);
        }

        // GET: Admin/Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,surname,age,email,phone")] User_reg user_reg)
        {
            if (ModelState.IsValid)
            {
                db.User_reg.Add(user_reg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user_reg);
        }

        // GET: Admin/Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_reg user_reg = db.User_reg.Find(id);
            if (user_reg == null)
            {
                return HttpNotFound();
            }
            return View(user_reg);
        }

        // POST: Admin/Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,surname,age,email,phone")] User_reg user_reg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_reg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user_reg);
        }

        // GET: Admin/Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_reg user_reg = db.User_reg.Find(id);
            if (user_reg == null)
            {
                return HttpNotFound();
            }
            return View(user_reg);
        }

        // POST: Admin/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User_reg user_reg = db.User_reg.Find(id);
            db.User_reg.Remove(user_reg);
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
