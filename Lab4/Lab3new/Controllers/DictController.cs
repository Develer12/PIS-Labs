using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab3new.Models;

namespace Lab3new.Controllers
{
    public class DictController : Controller
    {
        PhoneContext db = new PhoneContext();

        public ActionResult Index()
        {
            return View(db.Telephone);
        }

        public ActionResult Add()
        {
            return View(db.Telephone);
        }

        [HttpPost]
        public ActionResult Add(string surname, string number)
        {
            if (surname == null && number == null)
            {
                return HttpNotFound();
            }

            Telephone tel = new Telephone();
            tel.number = number;
            tel.surname = surname;

            db.Telephone.Add(tel);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            return View(db.Telephone);
        }

        [HttpPost]
        public ActionResult Update(int? id, string surname, string number)
        {
            if (id == null && surname == null && number == null)
            {
                return HttpNotFound();
            }

            Telephone tel = db.Telephone.Find(id);
            if (tel != null)
            {
                tel.surname = surname;
                tel.number = number;
                db.Entry(tel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }

        public ActionResult Delete()
        {
            return View(db.Telephone);
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }


            Telephone tel = db.Telephone.Find(id);
            if (tel != null)
            {
                db.Telephone.Remove(tel);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}