using backendDefault.Aplication.Interfaces;
using backendDefault.Domain.Entities;
using backendDefault.Domain.Interfaces;
using backendDefault.Domain.Util;

namespace backendDefault.Aplication.Services
{
    public class ColaboradorService : IColaboradorService
    {
        private readonly IColaboradorRepository _colaboradorRepository;
        public ColaboradorService(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        public HttpResponseObj BuscarPorId(int idColaborador)
        {
            var colaborador = _colaboradorRepository.BuscarPorId(idColaborador);
            if (colaborador == null)
                return new HttpResponseObj("Colaborador inválido");
            return new HttpResponseObj(colaborador);
        }

        public HttpResponseObj BuscarColaboradoresPorIdEmpresa(int idEmpresa)
        {
            var colaborador = _colaboradorRepository.BuscarColaboradoresPorIdEmpresa(idEmpresa);
            if (colaborador == null)
                return new HttpResponseObj("Busca por empresa inválida");
            return new HttpResponseObj(colaborador);
        }

        public HttpResponseObj Adicionar(TblColaborador novoColaborador)
        {
            var colaborador = _colaboradorRepository.Adicionar(novoColaborador);
            if (colaborador == null)
                return new HttpResponseObj("Colaborador inválido");
            return new HttpResponseObj(colaborador);
        }
    }
}
