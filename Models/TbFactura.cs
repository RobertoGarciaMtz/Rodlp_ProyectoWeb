using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class TbFactura
    {
        public TbFactura()
        {
            TbInventario = new HashSet<TbInventario>();
        }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Rfc { get; set; }
        public string Fecha { get; set; }
        public int? Cantidad { get; set; }
        public double? Precio { get; set; }
        public string Emisor { get; set; }
        public int IdFactura { get; set; }

        public virtual ICollection<TbInventario> TbInventario { get; set; }
    }
}
