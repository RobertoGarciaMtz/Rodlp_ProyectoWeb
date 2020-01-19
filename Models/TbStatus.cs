using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class TbStatus
    {
        public TbStatus()
        {
            CtClienteprovedor = new HashSet<CtClienteprovedor>();
            CtFormaspago = new HashSet<CtFormaspago>();
            CtGrupomovi = new HashSet<CtGrupomovi>();
            CtIngresoegreso = new HashSet<CtIngresoegreso>();
            CtMetodopago = new HashSet<CtMetodopago>();
            CtMonedas = new HashSet<CtMonedas>();
            CtProyecto = new HashSet<CtProyecto>();
            CtTipocomprobante = new HashSet<CtTipocomprobante>();
            TbCuentas = new HashSet<TbCuentas>();
            TbEmpresa = new HashSet<TbEmpresa>();
            TbImpuestos = new HashSet<TbImpuestos>();
            TbMovimientos = new HashSet<TbMovimientos>();
            TbPersonas = new HashSet<TbPersonas>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdStatus { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CtClienteprovedor> CtClienteprovedor { get; set; }
        public virtual ICollection<CtFormaspago> CtFormaspago { get; set; }
        public virtual ICollection<CtGrupomovi> CtGrupomovi { get; set; }
        public virtual ICollection<CtIngresoegreso> CtIngresoegreso { get; set; }
        public virtual ICollection<CtMetodopago> CtMetodopago { get; set; }
        public virtual ICollection<CtMonedas> CtMonedas { get; set; }
        public virtual ICollection<CtProyecto> CtProyecto { get; set; }
        public virtual ICollection<CtTipocomprobante> CtTipocomprobante { get; set; }
        public virtual ICollection<TbCuentas> TbCuentas { get; set; }
        public virtual ICollection<TbEmpresa> TbEmpresa { get; set; }
        public virtual ICollection<TbImpuestos> TbImpuestos { get; set; }
        public virtual ICollection<TbMovimientos> TbMovimientos { get; set; }
        public virtual ICollection<TbPersonas> TbPersonas { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
