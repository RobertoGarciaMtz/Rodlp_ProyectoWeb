using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class GrupoMoviController : Controller
    {
        // GET: Empresas
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            var list = context.CtGrupomovi;
            return View(list);
        }


        // GET: Empresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CtGrupomovi e)
        {
            try
            {
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                e.Status = 1;
                e.Usuario = currentUser;
                context.CtGrupomovi.Add(e);
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
            if (context.CtGrupomovi.Where(s => s.IdGrupoMov == id).First() is CtGrupomovi e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: Empresas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CtGrupomovi empEdit)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                var objectEdit = context.CtGrupomovi.FirstOrDefault(em => em.IdGrupoMov == empEdit.IdGrupoMov);
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                if (objectEdit != null)
                {
                    objectEdit.Descripcion = empEdit.Descripcion;
                    objectEdit.Usuario = currentUser;
                    context.CtGrupomovi.Update(objectEdit);
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
                var entity = context.CtGrupomovi.FirstOrDefault(ve => ve.IdGrupoMov == id);
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
                    context.CtGrupomovi.Update(entity);
                    context.SaveChanges();

                }

            }
            catch (Exception e)
            {
            }
        }
    }
}