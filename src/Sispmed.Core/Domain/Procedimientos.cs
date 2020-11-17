using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Procedimientos
    {
        public int Id { get; set; }
        public string CodProc { get; set; }
        public string NomProc { get; set; }
        public string ConProc { get; set; }
        public int ValProc { get; set; }
        public int? Estado { get; set; }
    }
}
