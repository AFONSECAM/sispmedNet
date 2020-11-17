using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Citas
    {
        public int IdCita { get; set; }
        public string CodCita { get; set; }
        public string Descr { get; set; }
        public string Obs { get; set; }
        public string EstCita { get; set; }
        public string NIdPac { get; set; }
        public string NIdAcom { get; set; }
        public string NomSede { get; set; }
        public string NomIps { get; set; }
        public string NomProc { get; set; }
    }
}
