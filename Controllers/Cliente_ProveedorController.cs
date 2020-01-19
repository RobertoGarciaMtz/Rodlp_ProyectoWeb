using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class Cliente_ProveedorController : Controller
    {

        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            var list = context.TbPersonas;
            return View(list);
        }


        // GET: Empresas/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            ViewBag.TipoPersona = context.CtClienteprovedor.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdClienteProvedor.ToString() });
            ViewBag.Empresas = context.TbEmpresa.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Nombre, Value = s.IdEmpresa.ToString() });
            return View();
        }

        // POST: Empresas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbPersonas e)
        {
            try
            {
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                e.Status = 1;
                e.Usuario = currentUser;
                context.TbPersonas.Add(e);
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
            if (context.TbPersonas.Where(s => s.IdPersona == id).First() is TbPersonas e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: Empresas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TbPersonas empEdit)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                var objectEdit = context.TbPersonas.FirstOrDefault(em => em.IdPersona == empEdit.IdPersona);
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                if (objectEdit != null)
                {
                    objectEdit.Nombre = empEdit.Nombre;
                    objectEdit.Rfc = empEdit.Rfc;
                    objectEdit.Direccion = empEdit.Direccion;
                    objectEdit.Localidad = empEdit.Localidad;
                    objectEdit.Municipio = empEdit.Municipio;
                    objectEdit.Entidad = empEdit.Entidad;
                    objectEdit.Cp = empEdit.Cp;
                    objectEdit.Telefono = empEdit.Telefono;
                    objectEdit.EMail = empEdit.EMail;
                    objectEdit.Nombre = empEdit.Nombre;
                    objectEdit.ClienteProveedor = empEdit.ClienteProveedor;
                    objectEdit.Usuario = currentUser;
                    context.TbPersonas.Update(objectEdit);
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
                var entity = context.TbPersonas.FirstOrDefault(ve => ve.IdPersona == id);
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
                    context.TbPersonas.Update(entity);
                    context.SaveChanges();

                }

            }
            catch (Exception e)
            {
            }
        }
    }
}