using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime? FechaPedido { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public int IdProducto { get; set; }
        public int IdVendedor { get; set; }

        public virtual Productos IdProductoNavigation { get; set; }
        public virtual Vendedor IdVendedorNavigation { get; set; }
    }
}
