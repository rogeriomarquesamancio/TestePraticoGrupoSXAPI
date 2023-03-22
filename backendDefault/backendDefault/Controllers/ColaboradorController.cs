using backendDefault.Aplication.Interfaces;
using backendDefault.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using backendDefault.Domain.Util;

namespace backendDefault.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradorService _colaboradorService;
        public ColaboradorController(IColaboradorService colaboradorService)
        {
            _colaboradorService = colaboradorService;
        }

        [HttpGet]
        public HttpResponseObj BuscarPorId(int idColaborador)
        {
            var colaborador = _colaboradorService.BuscarPorId(idColaborador);
            return colaborador;
        }

        [HttpGet]
        public HttpResponseObj BuscarColaboradoresPorIdEmpresa(int idEmpresa)
        {
            var listaColaboradores = _colaboradorService.BuscarColaboradoresPorIdEmpresa(idEmpresa);
            return listaColaboradores;
        }

        [HttpPost]
        public HttpResponseObj Adicionar(TblColaborador novoColaborador)
        {
            var colaborador = _colaboradorService.Adicionar(novoColaborador);
            return colaborador;
        }
    }
}
