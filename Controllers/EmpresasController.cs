using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class EmpresasController : Controller
    {
        // GET: Empresas
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            var list = context.TbEmpresa;
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
        public ActionResult Create(TbEmpresa e)
        {
            try
            {
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                e.Status = 1;
                e.Usuario = currentUser;
                context.TbEmpresa.Add(e);
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
            if( context.TbEmpresa.Where( s => s.IdEmpresa == id ).First() is TbEmpresa e )
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: Empresas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TbEmpresa empEdit)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                var objectEdit = context.TbEmpresa.FirstOrDefault(em => em.IdEmpresa == empEdit.IdEmpresa);
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                if (objectEdit != null)
                {
                    objectEdit.Nombre = empEdit.Nombre;
                    objectEdit.Rfc = empEdit.Rfc;
                    objectEdit.Direccion = empEdit.Direccion;
                    objectEdit.Ciudad = empEdit.Ciudad;
                    objectEdit.Estado = empEdit.Estado;
                    objectEdit.Usuario = currentUser;
                    context.TbEmpresa.Update(objectEdit);
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
                var entity = context.TbEmpresa.FirstOrDefault(ve => ve.IdEmpresa == id);
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
                    context.TbEmpresa.Update(entity);
                    context.SaveChanges();

                }

            }
            catch (Exception e)
            {
            }
        }

    }
}