using backendDefault.Domain;
using backendDefault.Domain.Util;

namespace backendDefault.Aplication.Interfaces
{
    public interface IEmpresaService
    {
        HttpResponseObj BuscarPorId(int idEmpresa);
        HttpResponseObj BuscarEmpresaComColaboradores(int idEmpresa);
        HttpResponseObj BuscarEmpresas();
        HttpResponseObj Adicionar(TblEmpresa empresa);
    }
}
