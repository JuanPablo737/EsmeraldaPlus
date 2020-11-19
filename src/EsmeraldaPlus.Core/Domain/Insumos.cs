using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class Insumos
    {
        public Insumos()
        {
            Inventario = new HashSet<Inventario>();
            Produccion = new HashSet<Produccion>();
        }

        public int IdInsumos { get; set; }
        public int IdTipoDeInsumo { get; set; }
        public int IdProvedor { get; set; }

        public virtual Provedor IdProvedorNavigation { get; set; }
        public virtual TipoDeInsumo IdTipoDeInsumoNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
        public virtual ICollection<Produccion> Produccion { get; set; }
    }
}
