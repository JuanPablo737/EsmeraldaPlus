using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsmeraldaPlus.Web.Controllers
{
    public class ProvedorController : Controller
    {
        // GET: HomeController3
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController3/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController3/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController3/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController3/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController3/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController3/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
