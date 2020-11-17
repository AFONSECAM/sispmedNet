using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Empleados
    {
        public int Id { get; set; }
        public string TipoId { get; set; }
        public string NIdEmp { get; set; }
        public string PApe { get; set; }
        public string SApe { get; set; }
        public string PNom { get; set; }
        public string SNom { get; set; }
        public string Genero { get; set; }
        public DateTime? FecNac { get; set; }
        public int? Edad { get; set; }
        public string Arl { get; set; }
        public string Eps { get; set; }
        public string Rh { get; set; }
        public string DirRes { get; set; }
        public string CiuRes { get; set; }
        public string TelEmp { get; set; }
        public string EmailEmp { get; set; }
        public string ECivil { get; set; }
        public string NivlEdu { get; set; }
        public DateTime? FecIng { get; set; }
        public string NomCar { get; set; }
        public string NomSede { get; set; }
        public string Estado { get; set; }

        public virtual Roles NomCarNavigation { get; set; }
        public virtual Sedes NomSedeNavigation { get; set; }
        public virtual TiposId Tipo { get; set; }
    }
}
