using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class CtTipocomprobante
    {
        public CtTipocomprobante()
        {
            TbMovimientos = new HashSet<TbMovimientos>();
        }

        public int IdComprobante { get; set; }
        public string Descripcion { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual TbStatus StatusNavigation { get; set; }
        public virtual ICollection<TbMovimientos> TbMovimientos { get; set; }
    }
}
