using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Recaudos
    {
        public int Id { get; set; }
        public string CodReca { get; set; }
        public DateTime? FecReca { get; set; }
        public string Concep { get; set; }
        public int Valor { get; set; }
    }
}
