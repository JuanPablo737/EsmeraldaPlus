using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class Vendedor
    {
        public Vendedor()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdVendedor { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public int CodTelefon { get; set; }
        public string Telefon { get; set; }
        public int IdRoles { get; set; }

        public virtual TipoDeNumero CodTelefonNavigation { get; set; }
        public virtual Roles IdRolesNavigation { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}
