using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Insumos
    {
        public int Id { get; set; }
        public string CodIns { get; set; }
        public string NomIns { get; set; }
        public string Labora { get; set; }
        public string Concen { get; set; }
        public string Pres { get; set; }
        public string Unid { get; set; }
        public int PrecioU { get; set; }
        public DateTime? FecVen { get; set; }
        public string NomCate { get; set; }
    }
}
