using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proyectoWebII_empresa_asp.net.Models;

namespace proyectoWebII_empresa_asp.net.Controllers
{
    public class Reunion_Controller : Controller
    {
        private CRM db = new CRM();

        // GET: Reunion_
        public ActionResult Index()
        {
            var reunion = db.Reunion.Include(r => r.Cliente).Include(r => r.usuario);
            return View(reunion.ToList());
        }

        // GET: Reunion_/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunion.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            return View(reunion);
        }

        // GET: Reunion_/Create
        public ActionResult Create()
        {
            ViewBag.id_cliente = new SelectList(db.Cliente, "ID", "nombre");
            ViewBag.id_usuario = new SelectList(db.usuario, "id", "nombre");
            return View();
        }

        // POST: Reunion_/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,titulo_reunion,fecha,id_usuario,id_cliente")] Reunion reunion)
        {
            if (ModelState.IsValid)
            {
                db.Reunion.Add(reunion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_cliente = new SelectList(db.Cliente, "ID", "nombre", reunion.id_cliente);
            ViewBag.id_usuario = new SelectList(db.usuario, "id", "nombre", reunion.id_usuario);
            return View(reunion);
        }

        // GET: Reunion_/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunion.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_cliente = new SelectList(db.Cliente, "ID", "nombre", reunion.id_cliente);
            ViewBag.id_usuario = new SelectList(db.usuario, "id", "nombre", reunion.id_usuario);
            return View(reunion);
        }

        // POST: Reunion_/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,titulo_reunion,fecha,id_usuario,id_cliente")] Reunion reunion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reunion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_cliente = new SelectList(db.Cliente, "ID", "nombre", reunion.id_cliente);
            ViewBag.id_usuario = new SelectList(db.usuario, "id", "nombre", reunion.id_usuario);
            return View(reunion);
        }

        // GET: Reunion_/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunion.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            return View(reunion);
        }

        // POST: Reunion_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reunion reunion = db.Reunion.Find(id);
            db.Reunion.Remove(reunion);
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
