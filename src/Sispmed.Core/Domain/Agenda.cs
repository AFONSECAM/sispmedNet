using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Agenda
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFinal { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
    }
}
