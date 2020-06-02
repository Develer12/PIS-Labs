using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3.Controllers
{
    public class DictController : Controller
    {
        Models.TelephoneDictionary telephoneDictionary = new Models.TelephoneDictionary();


        public ActionResult Index()
        {
            ViewBag.selectAll = telephoneDictionary.selectAll();
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.selectAll = telephoneDictionary.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Add(string surname, int number)
        {
            telephoneDictionary.insert(surname, number);
            ViewBag.selectAll = telephoneDictionary.selectAll();
            return View("Index");
        }

        public ActionResult Update()
        {
            ViewBag.selectAll = telephoneDictionary.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id, string surname, int number)
        {
            telephoneDictionary.update(id, surname, number);
            ViewBag.selectAll = telephoneDictionary.selectAll();
            return View("Index");
        }

        public ActionResult Delete()
        {
            ViewBag.selectAll = telephoneDictionary.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            telephoneDictionary.delete(id);
            ViewBag.selectAll = telephoneDictionary.selectAll();
            return View("Index");
        }
    }
}