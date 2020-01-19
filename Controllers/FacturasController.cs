using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class FacturasController : Controller
    {
        // GET: Facturas
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            var list = context.TbFactura;
            return View(list);
        }

        // GET: Facturas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Facturas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Facturas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbFactura tf)
        {
            try
            {
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                context.TbFactura.Add(tf);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Facturas/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            if (context.TbFactura.Where(s => s.IdFactura == id).First() is TbFactura e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: Facturas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TbFactura empEdit)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                var objectEdit = context.TbFactura.FirstOrDefault(em => em.IdFactura == empEdit.IdFactura);
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                if (objectEdit != null)
                {
                    objectEdit.Nombre = empEdit.Nombre;
                    objectEdit.Apellidos = empEdit.Apellidos;
                    objectEdit.Cantidad = empEdit.Cantidad;
                    objectEdit.Emisor = empEdit.Emisor;
                    objectEdit.Fecha = empEdit.Fecha;
                    objectEdit.Precio = empEdit.Precio;
                    objectEdit.Rfc = empEdit.Rfc;
                    context.TbFactura.Update(objectEdit);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Facturas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Facturas/Delete/5
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