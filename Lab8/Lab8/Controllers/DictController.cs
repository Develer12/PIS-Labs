using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab8.Models;

namespace Lab8.Controllers
{
    public class DictController : Controller
    {

        private IPhoneDictionary repo;
        public DictController(IPhoneDictionary r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            return View(repo.selectAll());
        }

        public IActionResult Add()
        {
            return View(repo.selectAll());
        }

        [HttpPost]
        public IActionResult Add(string surname, string number)
        {
            repo.insert(surname, number);
            return RedirectToAction("Index");
        }

        public IActionResult Update()
        {
            return View(repo.selectAll());
        }

        [HttpPost]
        public IActionResult Update(int id, string surname, string number)
        {
            repo.update(id, surname, number);
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            return View(repo.selectAll());
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            repo.delete(id);
            return RedirectToAction("Index");
        }
    }
}