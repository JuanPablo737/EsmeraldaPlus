using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class Provedor
    {
        public Provedor()
        {
            Insumos = new HashSet<Insumos>();
        }

        public int IdProvedor { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public int CodTelefon { get; set; }
        public string Telefon { get; set; }

        public virtual TipoDeNumero CodTelefonNavigation { get; set; }
        public virtual ICollection<Insumos> Insumos { get; set; }
    }
}
