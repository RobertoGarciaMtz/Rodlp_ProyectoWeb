using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class CuentasController : Controller
    {
        // GET: Empresas
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            var list = context.TbCuentas;
            return View(list);
        }


        // GET: Empresas/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            ViewBag.Grupos = context.CtGrupomovi.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdGrupoMov.ToString() });
            return View();
        }

        // POST: Empresas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbCuentas e)
        {
            try
            {
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                e.Status = 1;
                e.Usuario = currentUser;
                context.TbCuentas.Add(e);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Empresas/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            ViewBag.Grupos = context.CtGrupomovi.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdGrupoMov.ToString() });
            if (context.TbCuentas.Where(s => s.IdCuenta == id).First() is TbCuentas e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: Empresas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TbCuentas empEdit)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                var objectEdit = context.TbCuentas.FirstOrDefault(em => em.IdCuenta == empEdit.IdCuenta);
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                if (objectEdit != null)
                {
                    objectEdit.Descripcion = empEdit.Descripcion;
                    objectEdit.Grupo = empEdit.Grupo;
                    objectEdit.Usuario = currentUser;
                    context.TbCuentas.Update(objectEdit);
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
                var entity = context.TbCuentas.FirstOrDefault(ve => ve.IdCuenta == id);
                if (entity != null)
                {
                    if (entity.Status == 1)
                    {
                        entity.Status = 2;
                    }
                    else
                    {
                        entity.Status = 1;
                    }
                    context.TbCuentas.Update(entity);
                    context.SaveChanges();

                }

            }
            catch (Exception e)
            {
            }
        }
    }
}