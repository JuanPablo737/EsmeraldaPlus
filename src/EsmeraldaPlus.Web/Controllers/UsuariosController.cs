using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsmeraldaPlus.Web.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: HomeController8
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController8/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController8/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController8/Create
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

        // GET: HomeController8/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController8/Edit/5
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

        // GET: HomeController8/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController8/Delete/5
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
