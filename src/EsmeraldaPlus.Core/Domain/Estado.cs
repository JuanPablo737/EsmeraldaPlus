using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class Estado
    {
        public Estado()
        {
            Produccion = new HashSet<Produccion>();
        }

        public int IdEstado { get; set; }
        public string EstadoProducto { get; set; }

        public virtual ICollection<Produccion> Produccion { get; set; }
    }
}
