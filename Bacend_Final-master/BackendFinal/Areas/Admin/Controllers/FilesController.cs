using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;
using BackendFinal.Models;

namespace BackendFinal.Areas.Admin.Controllers
{
    public class FilesController : Controller
    {
        private watcherEntities db = new watcherEntities();

        // GET: Admin/Files
        public ActionResult Index()
        {
            return View(db.Files.ToList());
        }

        // GET: Admin/Files/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        // GET: Admin/Files/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Files/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Exclude = "file_path")] HttpPostedFileBase file_path, Models.File file)
        {
            Models.File newFile = new Models.File();
            if (ModelState.IsValid)
            {
                if (file_path.ContentLength > 0)

                {
                    var file_extention = Path.GetExtension(file_path.FileName);
                    var file_new_name = file.file_name + file_extention;
                    var file_src = Path.Combine(Server.MapPath("~/Public/"), file_new_name);
                    file_path.SaveAs(file_src);
                    newFile.file_name = file_new_name;
                    newFile.file_type = MimeMapping.GetMimeMapping(file_path.FileName);
                    newFile.file_size = file_path.ContentLength.ToString();
                    newFile.file_path = "/Public/" + file_new_name;
                }
                db.Files.Add(newFile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

                return View(newFile);
        }

        // GET: Admin/Files/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        // POST: Admin/Files/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,file_name,file_type,file_size,file_path")] Models.File file)
        {
            if (ModelState.IsValid)
            {
                db.Entry(file).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(file);
        }

        // GET: Admin/Files/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.File file = db.Files.Find(id);
            if (file == null)
            {
                return HttpNotFound();
            }
            return View(file);
        }

        // POST: Admin/Files/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           Models.File file = db.Files.Find(id);
            db.Files.Remove(file);
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
