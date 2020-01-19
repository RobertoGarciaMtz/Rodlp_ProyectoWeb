using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class TbMovimientos
    {
        public string Folio { get; set; }
        public int? IdMovimiento { get; set; }
        public int? IdProyecto { get; set; }
        public int? IngresoEgreso { get; set; }
        public DateTime? Fecha { get; set; }
        public string Rfc { get; set; }
        public int? IdEmpresas { get; set; }
        public int? IdPersonas { get; set; }
        public int? IdCuenta { get; set; }
        public int? IdMetodoPago { get; set; }
        public int? IdFormPago { get; set; }
        public int? IdMonedas { get; set; }
        public int? IdTipoComprobante { get; set; }
        public string Concepto { get; set; }
        public double? PrecioUnitario { get; set; }
        public float? Descuento { get; set; }
        public double? Subtotal { get; set; }
        public float? Iva { get; set; }
        public float? RetIva { get; set; }
        public float? RetIsr { get; set; }
        public float? Ieps { get; set; }
        public double? Total { get; set; }
        public string Uuid { get; set; }
        public int? ImpuestosLocales { get; set; }
        public string RutaArchivo { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual TbCuentas IdCuentaNavigation { get; set; }
        public virtual TbEmpresa IdEmpresasNavigation { get; set; }
        public virtual CtFormaspago IdFormPagoNavigation { get; set; }
        public virtual CtMetodopago IdMetodoPagoNavigation { get; set; }
        public virtual CtMonedas IdMonedasNavigation { get; set; }
        public virtual TbPersonas IdPersonasNavigation { get; set; }
        public virtual CtProyecto IdProyectoNavigation { get; set; }
        public virtual CtTipocomprobante IdTipoComprobanteNavigation { get; set; }
        public virtual CtIngresoegreso IngresoEgresoNavigation { get; set; }
        public virtual TbStatus StatusNavigation { get; set; }
    }
}
