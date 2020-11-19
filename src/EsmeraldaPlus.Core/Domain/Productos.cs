using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class Productos
    {
        public Productos()
        {
            Inventario = new HashSet<Inventario>();
            Pedido = new HashSet<Pedido>();
        }

        public int IdProducto { get; set; }
        public int IdTipoDeProductos { get; set; }

        public virtual TipoDeProductos IdTipoDeProductosNavigation { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
