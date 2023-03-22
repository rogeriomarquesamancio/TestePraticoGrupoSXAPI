using backendDefault.Domain.DTO;
using System.Collections.Generic;

namespace backendDefault.Domain.Interfaces
{
    public interface IEmpresaRepository
    {
        TblEmpresa BuscarPorId(int idEmpresa);
        EmpresaColaboradoresDTO BuscarEmpresaComColaboradores(int idEmpresa);
        List<TblEmpresa> BuscarEmpresas();
        TblEmpresa Adicionar(TblEmpresa empresa);
    }
}
