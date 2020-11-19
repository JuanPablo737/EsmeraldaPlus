using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class PedidoHasComprovantePedido
    {
        public int IdPedido { get; set; }
        public int IdComprovante { get; set; }

        public virtual ComprobantePedido IdComprovanteNavigation { get; set; }
        public virtual Pedido IdPedidoNavigation { get; set; }
    }
}
