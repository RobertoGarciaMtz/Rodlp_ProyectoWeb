using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class TbEmpresa
    {
        public TbEmpresa()
        {
            TbInventario = new HashSet<TbInventario>();
            TbMovimientos = new HashSet<TbMovimientos>();
        }

        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual TbStatus StatusNavigation { get; set; }
        public virtual ICollection<TbInventario> TbInventario { get; set; }
        public virtual ICollection<TbMovimientos> TbMovimientos { get; set; }
    }
}
