using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class CtGrupomovi
    {
        public CtGrupomovi()
        {
            TbCuentas = new HashSet<TbCuentas>();
        }

        public int IdGrupoMov { get; set; }
        public string Descripcion { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual TbStatus StatusNavigation { get; set; }
        public virtual ICollection<TbCuentas> TbCuentas { get; set; }
    }
}
