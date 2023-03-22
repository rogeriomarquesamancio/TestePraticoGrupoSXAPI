using System;
using System.Collections.Generic;

namespace backendDefault.Domain.Entities
{
    public partial class TblUser
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
    }
}
