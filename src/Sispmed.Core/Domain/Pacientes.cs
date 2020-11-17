using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Pacientes
    {
        public Pacientes()
        {
            Acompanantes = new HashSet<Acompanantes>();
        }

        public int Id { get; set; }
        public string TipoId { get; set; }
        public string NIdPac { get; set; }
        public string PApe { get; set; }
        public string SApe { get; set; }
        public string PNom { get; set; }
        public string SNom { get; set; }
        public string Genero { get; set; }
        public DateTime? FNaci { get; set; }
        public int? Edad { get; set; }
        public string Regimen { get; set; }
        public string Rh { get; set; }
        public string Ciudad { get; set; }
        public string DirResi { get; set; }
        public string TelPac { get; set; }
        public string EmailPac { get; set; }
        public string ECivil { get; set; }
        public string NomSede { get; set; }
        public string NomIps { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Acompanantes> Acompanantes { get; set; }
    }
}
