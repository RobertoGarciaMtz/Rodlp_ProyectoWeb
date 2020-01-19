using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class TbImpuestos
    {
        public int IdImpuesto { get; set; }
        public string NombreImpuesto { get; set; }
        public double? Porcentaje { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual TbStatus StatusNavigation { get; set; }
    }
}
