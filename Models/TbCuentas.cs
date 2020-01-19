using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class TbCuentas
    {
        public TbCuentas()
        {
            TbMovimientos = new HashSet<TbMovimientos>();
        }

        public int IdCuenta { get; set; }
        public string Descripcion { get; set; }
        public int? Grupo { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual CtGrupomovi GrupoNavigation { get; set; }
        public virtual TbStatus StatusNavigation { get; set; }
        public virtual ICollection<TbMovimientos> TbMovimientos { get; set; }
    }
}
