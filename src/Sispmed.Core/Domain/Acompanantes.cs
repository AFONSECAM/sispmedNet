using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Acompanantes
    {
        public int Id { get; set; }
        public string TipoId { get; set; }
        public string NIdAcom { get; set; }
        public string PApe { get; set; }
        public string SApe { get; set; }
        public string PNom { get; set; }
        public string SNom { get; set; }
        public int Edad { get; set; }
        public string TelAcom { get; set; }
        public string MailAcom { get; set; }
        public string ParPac { get; set; }
        public string NIdPac { get; set; }

        public virtual Pacientes NIdPacNavigation { get; set; }
        public virtual TiposId Tipo { get; set; }
    }
}
