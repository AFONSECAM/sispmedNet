using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class TiposId
    {
        public TiposId()
        {
            Acompanantes = new HashSet<Acompanantes>();
            Empleados = new HashSet<Empleados>();
        }

        public int Id { get; set; }
        public string TipoId { get; set; }
        public string NomTipo { get; set; }

        public virtual ICollection<Acompanantes> Acompanantes { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
