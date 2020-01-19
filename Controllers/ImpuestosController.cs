using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class ImpuestosController : Controller
    {
        // GET: Impuestos
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            var list = context.TbImpuestos;
            return View(list);
        }

        // GET: Impuestos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Impuestos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Impuestos/Create
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

        // GET: Impuestos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Impuestos/Edit/5
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

        // GET: Impuestos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Impuestos/Delete/5
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