using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

namespace ProyectoWeb.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Usuarios  u)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(rodlpContext)) as rodlpContext;
                using (MD5 md5hash = MD5.Create())
                {
                    u.Contrasena = GetMd5Hash(md5hash, u.Contrasena);
                }
                u.Status = 1;
                u.Tipo = 2;
                context.Usuarios.Add(u);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)

            {

                return Content("" + e);

            }
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

    }
}