using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class CtFormaspago
    {
        public CtFormaspago()
        {
            TbMovimientos = new HashSet<TbMovimientos>();
        }

        public int IdFormaPago { get; set; }
        public string Descripcion { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual TbStatus StatusNavigation { get; set; }
        public virtual ICollection<TbMovimientos> TbMovimientos { get; set; }
    }
}
