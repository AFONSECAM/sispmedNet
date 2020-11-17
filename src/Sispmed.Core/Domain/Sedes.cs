using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Sedes
    {
        public Sedes()
        {
            Empleados = new HashSet<Empleados>();
        }

        public int Id { get; set; }
        public string NomSede { get; set; }
        public string DirSede { get; set; }
        public string TelSede { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }
    }
}
