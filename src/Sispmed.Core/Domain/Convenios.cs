using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Convenios
    {
        public int Id { get; set; }
        public string CodConv { get; set; }
        public DateTime FecAper { get; set; }
        public string NomIps { get; set; }
        public string NomConv { get; set; }
        public string Resolu { get; set; }
        public string ObjConv { get; set; }
        public int DurConv { get; set; }
        public int CosConv { get; set; }
        public int Estado { get; set; }
    }
}
