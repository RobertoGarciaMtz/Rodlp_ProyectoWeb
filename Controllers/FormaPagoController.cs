using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb.Controllers
{
    public class FormaPagoController : Controller
    {
        // GET: FormaPago
        public ActionResult Index()
        {
            return View();
        }

        // GET: FormaPago/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FormaPago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormaPago/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FormaPago/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FormaPago/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FormaPago/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FormaPago/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}