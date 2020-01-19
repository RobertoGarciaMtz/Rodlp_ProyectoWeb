using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string ReturnURL)
        {
            if (User.Identity.IsAuthenticated == false)
            {
                if (ReturnURL != null)
                    ViewData.Add("ReturnURL", ReturnURL);
                else
                    ViewData.Add("ReturnURL", "");
                return View();
            }
            else
            {
                return RedirectToAction("Inicio", "Principal"); //Action,Controller
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index(Usuarios model)
        {
            string pass = "";
            try
            {
                var tc = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                using (MD5 md5hash = MD5.Create())
                {
                    pass = SignupController.GetMd5Hash(md5hash, model.Contrasena);
                }
                Usuarios log = tc.Usuarios.Where(p => p.NomUsuario == model.NomUsuario && p.Contrasena == pass).FirstOrDefault();

                if (log != null)
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, model.NomUsuario));

                    var userIdentity = new ClaimsIdentity(claims, "login");
                    var principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync("PKAT", principal);

                    HttpContext.Session.SetInt32("idUsuario", log.IdUsuario);
                    HttpContext.Session.SetString("nomUsuario", log.NomUsuario);
                    HttpContext.Session.SetInt32("tipoUsuario", log.Tipo);
                    return RedirectToAction("Index", "Home");

                }
            }catch(Exception e)
            {
                return Content("" + e);
            }
                
            

            return RedirectToAction("Index", "Login");

        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync("PKAT");
            return RedirectToAction("Index", "Login");
        }

        [HttpGet]
        public ActionResult Perfil()
        {
            var idUsuario = HttpContext.Session.GetInt32("idUsuario");
            return Content(""+idUsuario);
        }
    }
}