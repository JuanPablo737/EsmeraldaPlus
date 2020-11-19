using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class ComprobantePedido
    {
        public int IdComprobante { get; set; }
        public int? Cantidad { get; set; }
        public int? CostoUnitario { get; set; }
        public int? Total { get; set; }
        public int IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
