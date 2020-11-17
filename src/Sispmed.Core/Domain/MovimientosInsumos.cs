using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class MovimientosInsumos
    {
        public int IdMovi { get; set; }
        public string CodMovi { get; set; }
        public DateTime? FecMovi { get; set; }
        public string CodIns { get; set; }
        public string NomIns { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public string Concep { get; set; }
        public string NIdEmp { get; set; }
        public string NIdProv { get; set; }
    }
}
