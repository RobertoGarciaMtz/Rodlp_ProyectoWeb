using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class TbPersonas
    {
        public TbPersonas()
        {
            TbMovimientos = new HashSet<TbMovimientos>();
        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Municipio { get; set; }
        public string Entidad { get; set; }
        public string Cp { get; set; }
        public string Telefono { get; set; }
        public string EMail { get; set; }
        public string NombreEmpresa { get; set; }
        public int? ClienteProveedor { get; set; }
        public int? Status { get; set; }
        public string Usuario { get; set; }

        public virtual TbStatus StatusNavigation { get; set; }
        public virtual ICollection<TbMovimientos> TbMovimientos { get; set; }
    }
}
