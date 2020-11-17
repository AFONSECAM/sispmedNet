using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Facturas
    {
        public int IdFact { get; set; }
        public string CodFact { get; set; }
        public string Concep { get; set; }
        public int Valor { get; set; }
        public string CodCita { get; set; }
    }
}
