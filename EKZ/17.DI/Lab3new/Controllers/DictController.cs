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
    }
}