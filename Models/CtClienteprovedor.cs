using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class CtClienteprovedor
    {
        public int IdClienteProvedor { get; set; }
        public string Descripcion { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual TbStatus StatusNavigation { get; set; }
    }
}
