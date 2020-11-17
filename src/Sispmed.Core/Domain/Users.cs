using System;
using System.Collections.Generic;

namespace Sispmed.Web
{
    public partial class Users
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RememberToken { get; set; }
        public string Cargo { get; set; }
        public string NIdEmp { get; set; }
        public string Estado { get; set; }
    }
}
