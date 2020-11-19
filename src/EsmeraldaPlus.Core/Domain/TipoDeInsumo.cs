using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class TipoDeInsumo
    {
        public TipoDeInsumo()
        {
            Insumos = new HashSet<Insumos>();
        }

        public int IdTipoDeInsumo { get; set; }
        public string Insumo { get; set; }

        public virtual ICollection<Insumos> Insumos { get; set; }
    }
}
