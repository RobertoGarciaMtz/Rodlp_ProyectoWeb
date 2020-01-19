using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Contrasena { get; set; }
        public int? Status { get; set; }

        public int Tipo { get; set; }
        public virtual TbStatus StatusNavigation { get; set; }
    }
}
