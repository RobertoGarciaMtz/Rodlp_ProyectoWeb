using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class MovimientosController : Controller
    {
        // GET: Movimientos
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            var list = context.TbMovimientos.ToList();
            foreach(TbMovimientos tm in list)
            {
                tm.IdCuentaNavigation = context.TbCuentas.Where(tc => tc.IdCuenta == tm.IdCuenta).FirstOrDefault();
                tm.IdCuentaNavigation.GrupoNavigation = context.CtGrupomovi.Where( cg => cg.IdGrupoMov == tm.IdCuentaNavigation.Grupo).FirstOrDefault();
                tm.IdEmpresasNavigation = context.TbEmpresa.Where(te => te.IdEmpresa == tm.IdEmpresas).FirstOrDefault();
                tm.IdFormPagoNavigation = context.CtFormaspago.Where(cf => cf.IdFormaPago == tm.IdFormPago).FirstOrDefault();
                tm.IdMetodoPagoNavigation = context.CtMetodopago.Where(cm => cm.IdMetodo == tm.IdMetodoPago).FirstOrDefault();
                tm.IdMonedasNavigation = context.CtMonedas.Where(cm => cm.IdMoneda == tm.IdMonedas).FirstOrDefault();
                tm.IdPersonasNavigation = context.TbPersonas.Where(tp => tp.IdPersona == tm.IdPersonas).FirstOrDefault();
                tm.IdProyectoNavigation = context.CtProyecto.Where(cp => cp.IdProyectos == tm.IdProyecto).FirstOrDefault();
                tm.IdTipoComprobanteNavigation = context.CtTipocomprobante.Where(ct => ct.IdComprobante == tm.IdTipoComprobante).FirstOrDefault();
                tm.IngresoEgresoNavigation = context.CtIngresoegreso.Where(ci => ci.IdIe == tm.IngresoEgreso).FirstOrDefault();
                tm.StatusNavigation = context.TbStatus.Where(ts => ts.IdStatus == tm.Status).FirstOrDefault();

            }
            return View(list);
        }

        // GET: Movimientos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movimientos/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            ViewBag.Proyectos = context.CtProyecto.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdProyectos.ToString() });
            ViewBag.IngEgre = context.CtIngresoegreso.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdIe.ToString() });
            ViewBag.Empresas = context.TbEmpresa.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Nombre, Value = s.IdEmpresa.ToString() });
            ViewBag.Personas = context.TbPersonas.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Nombre, Value = s.IdPersona.ToString() });
            ViewBag.Cuentas = context.TbCuentas.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdCuenta.ToString() });
            ViewBag.Metodos = context.CtMetodopago.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdMetodo.ToString() });
            ViewBag.Formas = context.CtFormaspago.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdFormaPago.ToString() });
            ViewBag.Monedas = context.CtMonedas.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdMoneda.ToString() });
            ViewBag.TipoComprobante = context.CtTipocomprobante.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdComprobante.ToString() });
            return View();
        }

        // POST: Movimientos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbMovimientos m)
        {
            try
            {
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                m.Status = 1;
                m.Usuario = currentUser;
                context.TbMovimientos.Add(m);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Movimientos/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
            ViewBag.Proyectos = context.CtProyecto.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdProyectos.ToString() });
            ViewBag.IngEgre = context.CtIngresoegreso.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdIe.ToString() });
            ViewBag.Empresas = context.TbEmpresa.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Nombre, Value = s.IdEmpresa.ToString() });
            ViewBag.Personas = context.TbPersonas.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Nombre, Value = s.IdPersona.ToString() });
            ViewBag.Cuentas = context.TbCuentas.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdCuenta.ToString() });
            ViewBag.Metodos = context.CtMetodopago.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdMetodo.ToString() });
            ViewBag.Formas = context.CtFormaspago.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdFormaPago.ToString() });
            ViewBag.Monedas = context.CtMonedas.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdMoneda.ToString() });
            ViewBag.TipoComprobante = context.CtTipocomprobante.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdComprobante.ToString() });
            if (context.TbMovimientos.Where(s => s.IdMovimiento == id).First() is TbMovimientos e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: Movimientos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TbMovimientos edit)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                var objectEdit = context.TbMovimientos.FirstOrDefault(em => em.IdMovimiento == edit.IdMovimiento);
                var currentUser = HttpContext.Session.GetString("nomUsuario");
                if (objectEdit != null)
                {
                    objectEdit.Folio = edit.Folio;
                    objectEdit.IdProyecto = edit.IdProyecto;
                    objectEdit.IngresoEgreso = edit.IngresoEgreso;
                    objectEdit.Fecha = edit.Fecha;
                    objectEdit.Rfc = edit.Rfc;
                    objectEdit.IdEmpresas = edit.IdEmpresas;
                    objectEdit.IdPersonas = edit.IdPersonas;
                    objectEdit.IdMetodoPago = edit.IdMetodoPago;
                    objectEdit.IdFormPago = edit.IdFormPago;
                    objectEdit.IdMonedas = edit.IdMonedas;
                    objectEdit.IdTipoComprobante = edit.IdTipoComprobante;
                    objectEdit.Concepto = edit.Concepto;
                    objectEdit.PrecioUnitario = edit.PrecioUnitario;
                    objectEdit.Descuento = edit.Descuento;
                    objectEdit.Subtotal = edit.Subtotal;
                    objectEdit.Iva = edit.Iva;
                    objectEdit.RetIva = edit.RetIva;
                    objectEdit.RetIsr = edit.RetIsr;
                    objectEdit.Ieps = edit.Ieps;
                    objectEdit.Total = edit.Total;
                    objectEdit.Uuid = edit.Uuid;
                    objectEdit.ImpuestosLocales = edit.ImpuestosLocales;
                    objectEdit.Usuario = currentUser;
                    context.TbMovimientos.Update(objectEdit);
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
                var entity = context.TbMovimientos.FirstOrDefault(ve => ve.IdMovimiento == id);
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
                    context.TbMovimientos.Update(entity);
                    context.SaveChanges();

                }

            }
            catch (Exception e)
            {
            }
        }
    }
}