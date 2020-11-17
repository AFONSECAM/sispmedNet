using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Kardex
    {
        public int Id { get; set; }
        public string CodIns { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set; }
        public int Stock { get; set; }
        public int PrecioU { get; set; }
    }
}
