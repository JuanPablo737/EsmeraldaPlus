using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class EmpleadoHasProductos
    {
        public int IdEmpleado { get; set; }
        public int IdProducto { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
        public virtual Productos IdProductoNavigation { get; set; }
    }
}
