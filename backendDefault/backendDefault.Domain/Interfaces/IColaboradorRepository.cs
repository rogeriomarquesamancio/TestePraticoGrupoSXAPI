using backendDefault.Domain.Entities;
using System.Collections.Generic;

namespace backendDefault.Domain.Interfaces
{
    public interface IColaboradorRepository
    {
        TblColaborador BuscarPorId(int idColaborador);
        List<TblColaborador> BuscarColaboradoresPorIdEmpresa(int idEmpresa);
        TblColaborador Adicionar(TblColaborador colaborador);
    }
}
