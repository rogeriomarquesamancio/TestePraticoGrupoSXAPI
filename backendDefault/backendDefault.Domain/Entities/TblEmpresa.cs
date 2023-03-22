using backendDefault.Domain.Entities;
using System.Collections.Generic;

namespace backendDefault.Domain
{
    public partial class TblEmpresa
    {
        public TblEmpresa()
        {
            TblColaborador = new HashSet<TblColaborador>();
        }

        public int IdEmpresa { get; set; }
        public string Codigo { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<TblColaborador> TblColaborador { get; set; }

    }
}
