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
            return View(repo.selectAll());
        }

        public ActionResult Add()
        {
            return View(repo.selectAll());
        }

        [HttpPost]
        public ActionResult Add(string surname, string number)
        {
            repo.insert(surname, number);
            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            return View(repo.selectAll());
        }

        [HttpPost]
        public ActionResult Update(int id, string surname, string number)
        {
            repo.update(id, surname, number);
            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            return View(repo.selectAll());
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repo.delete(id);
            return RedirectToAction("Index");
        }
    }
}