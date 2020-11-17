using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Gastos
    {
        public int Id { get; set; }
        public string CodGasto { get; set; }
        public DateTime FecGasto { get; set; }
        public string ForPago { get; set; }
        public string Concep { get; set; }
        public int Valor { get; set; }
    }
}
