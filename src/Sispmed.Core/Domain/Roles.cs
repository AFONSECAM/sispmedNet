using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Roles
    {
        public Roles()
        {
            Empleados = new HashSet<Empleados>();
        }

        public int Id { get; set; }
        public string NomRol { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
