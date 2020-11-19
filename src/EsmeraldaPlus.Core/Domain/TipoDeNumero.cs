using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class TipoDeNumero
    {
        public TipoDeNumero()
        {
            Cliente = new HashSet<Cliente>();
            Empleado = new HashSet<Empleado>();
            Provedor = new HashSet<Provedor>();
            Vendedor = new HashSet<Vendedor>();
        }

        public int CodTelefon { get; set; }
        public string TipoDeNumero1 { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
        public virtual ICollection<Provedor> Provedor { get; set; }
        public virtual ICollection<Vendedor> Vendedor { get; set; }
    }
}
