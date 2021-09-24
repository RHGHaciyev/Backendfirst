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
    public class C_News_categoryController : Controller
    {
        private watcherEntities db = new watcherEntities();

        // GET: Admin/C_News_category
        public ActionResult Index()
        {
            var c_News_category = db.C_News_category.Include(c => c.category).Include(c => c.type);
            return View(c_News_category.ToList());
        }

        // GET: Admin/C_News_category/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_News_category c_News_category = db.C_News_category.Find(id);
            if (c_News_category == null)
            {
                return HttpNotFound();
            }
            return View(c_News_category);
        }

        // GET: Admin/C_News_category/Create
        public ActionResult Create()
        {
            ViewBag.categoryID = new SelectList(db.categories, "id", "name");
            ViewBag.type_id = new SelectList(db.types, "id", "name");
            return View();
        }

        // POST: Admin/C_News_category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,category_name,photo,title,author,dates,text,pages,type_id,categoryID")] C_News_category c_News_category)
        {
            if (ModelState.IsValid)
            {
                db.C_News_category.Add(c_News_category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.categoryID = new SelectList(db.categories, "id", "name", c_News_category.categoryID);
            ViewBag.type_id = new SelectList(db.types, "id", "name", c_News_category.type_id);
            return View(c_News_category);
        }

        // GET: Admin/C_News_category/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_News_category c_News_category = db.C_News_category.Find(id);
            if (c_News_category == null)
            {
                return HttpNotFound();
            }
            ViewBag.categoryID = new SelectList(db.categories, "id", "name", c_News_category.categoryID);
            ViewBag.type_id = new SelectList(db.types, "id", "name", c_News_category.type_id);
            return View(c_News_category);
        }

        // POST: Admin/C_News_category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,category_name,photo,title,author,dates,text,pages,type_id,categoryID")] C_News_category c_News_category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_News_category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.categoryID = new SelectList(db.categories, "id", "name", c_News_category.categoryID);
            ViewBag.type_id = new SelectList(db.types, "id", "name", c_News_category.type_id);
            return View(c_News_category);
        }

        // GET: Admin/C_News_category/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_News_category c_News_category = db.C_News_category.Find(id);
            if (c_News_category == null)
            {
                return HttpNotFound();
            }
            return View(c_News_category);
        }

        // POST: Admin/C_News_category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            C_News_category c_News_category = db.C_News_category.Find(id);
            db.C_News_category.Remove(c_News_category);
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
