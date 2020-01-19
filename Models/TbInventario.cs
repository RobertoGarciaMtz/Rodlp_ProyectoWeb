using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class TbInventario
    {
        public int IdInventario { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public string Vendedor { get; set; }
        public string Cantidad { get; set; }
        public int? Empresa { get; set; }
        public int? Estado { get; set; }
        public int ParaFactura { get; set; }

        public virtual TbEmpresa EmpresaNavigation { get; set; }
        public virtual Estado EstadoNavigation { get; set; }
        public virtual TbFactura ParaFacturaNavigation { get; set; }
    }
}
