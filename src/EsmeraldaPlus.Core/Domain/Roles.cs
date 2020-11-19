using System;
using System.Collections.Generic;

namespace EsmeraldaPlus.Core.Domain
{
    public partial class Roles
    {
        public Roles()
        {
            Cliente = new HashSet<Cliente>();
            Empleado = new HashSet<Empleado>();
            Usuarios = new HashSet<Usuarios>();
            Vendedor = new HashSet<Vendedor>();
        }

        public int IdRoles { get; set; }
        public string Rol { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }
        public virtual ICollection<Empleado> Empleado { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
        public virtual ICollection<Vendedor> Vendedor { get; set; }
    }
}
