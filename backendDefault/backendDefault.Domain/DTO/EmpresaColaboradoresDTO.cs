using backendDefault.Domain.Entities;
using System.Collections.Generic;

namespace backendDefault.Domain.DTO
{
    public partial class EmpresaColaboradoresDTO
    {
        public TblEmpresa Empresa { get; set; }
        public List<TblColaborador> Colaboradores { get; set; }

    }
}
