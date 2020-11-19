using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public DateTime? FechaIngresoProducto { get; set; }
        public int? CantidadProducto { get; set; }
        public int IdProducto { get; set; }
        public int? CantidadInsumo { get; set; }
        public int IdInsumos { get; set; }
        public DateTime? FechaIngresoInsumos { get; set; }

        public virtual Insumos IdInsumosNavigation { get; set; }
        public virtual Productos IdProductoNavigation { get; set; }
    }
}
