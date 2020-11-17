using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Usuarios
    {
        public int IdUsua { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool? Estado { get; set; }
        public string NomRol { get; set; }
        public string NIdEmp { get; set; }
    }
}
