using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class InventarioController : Controller
    {
        // GET: Inventario
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            var list = context.TbInventario.ToList();
            foreach( TbInventario ti in list)
            {
                ti.EmpresaNavigation = context.TbEmpresa.Where(te => te.IdEmpresa == ti.Empresa).FirstOrDefault();
            }
            return View(list);
        }

        // GET: Inventario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inventario/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            ViewBag.Empresas = context.TbEmpresa.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Nombre, Value = s.IdEmpresa.ToString() });
            ViewBag.Facturas = context.TbFactura.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.IdFactura.ToString(), Value = s.IdFactura.ToString() });
            return View();
        }

        // POST: Inventario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbInventario ti)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                ti.Estado = 1;
                context.TbInventario.Add(ti);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return Content(""+e);
            }
        }

        // GET: Inventario/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            ViewBag.Empresas = context.TbEmpresa.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Nombre, Value = s.IdEmpresa.ToString() });
            ViewBag.Facturas = context.TbFactura.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.IdFactura.ToString(), Value = s.IdFactura.ToString() });
            if (context.TbInventario.Where(s => s.IdInventario == id).First() is TbInventario e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: Inventario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TbInventario empEdit)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                var objectEdit = context.TbInventario.FirstOrDefault(em => em.IdInventario == empEdit.IdInventario);
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                if (objectEdit != null)
                {
                    objectEdit.Matricula = empEdit.Matricula;
                    objectEdit.Cantidad = empEdit.Cantidad;
                    objectEdit.Empresa = empEdit.Empresa;
                    objectEdit.Nombre = empEdit.Nombre;
                    objectEdit.ParaFactura = empEdit.ParaFactura;
                    objectEdit.Vendedor = empEdit.Vendedor;
                    context.TbInventario.Update(empEdit);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public void Status(int id)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                var entity = context.TbInventario.FirstOrDefault(ve => ve.IdInventario == id);
                if (entity != null)
                {
                    if (entity.Estado == 1)
                    {
                        entity.Estado = 2;
                    }
                    else
                    {
                        entity.Estado = 1;
                    }
                    context.TbInventario.Update(entity);
                    context.SaveChanges();

                }

            }
            catch (Exception e)
            {
            }
        }
    }
}