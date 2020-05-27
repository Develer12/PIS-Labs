using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace Lab3new.Controllers
{
    public class DictController : Controller
    {

        TelephoneDll.IPhoneDictionary repo;
        public DictController(TelephoneDll.IPhoneDictionary r)
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<TelephoneDll.IPhoneDictionary>().To<TelephoneDll.TelephoneDictionary>();
            repo = ninjectKernel.Get<TelephoneDll.IPhoneDictionary>();
            repo = r;
        }

        public ActionResult Index()
        {
            ViewBag.selectAll = repo.selectAll();
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.selectAll = repo.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Add(string surname, int number)
        {
            repo.insert(surname, number);
            ViewBag.selectAll = repo.selectAll();
            return View("Index");
        }

        public ActionResult Update()
        {
            ViewBag.selectAll = repo.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id, string surname, int number)
        {
            repo.update(id, surname, number);
            ViewBag.selectAll = repo.selectAll();
            return View("Index");
        }

        public ActionResult Delete()
        {
            ViewBag.selectAll = repo.selectAll();
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repo.delete(id);
            ViewBag.selectAll = repo.selectAll();
            return View("Index");
        }
    }
}