using backendDefault.Domain.Entities;
using backendDefault.Domain.Util;

namespace backendDefault.Aplication.Interfaces
{
    public interface IColaboradorService
    {
        HttpResponseObj BuscarPorId(int idColaborador);
        HttpResponseObj BuscarColaboradoresPorIdEmpresa(int idEmpresa);
        HttpResponseObj Adicionar(TblColaborador colaborador);
    }
}
