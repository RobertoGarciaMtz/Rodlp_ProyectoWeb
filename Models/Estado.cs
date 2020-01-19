using System;
using System.Collections.Generic;

namespace ProyectoWeb.Models
{
    public partial class Estado
    {
        public Estado()
        {
            TbInventario = new HashSet<TbInventario>();
        }

        public int Edo { get; set; }
        public string EdoActual { get; set; }

        public virtual ICollection<TbInventario> TbInventario { get; set; }
    }
}
