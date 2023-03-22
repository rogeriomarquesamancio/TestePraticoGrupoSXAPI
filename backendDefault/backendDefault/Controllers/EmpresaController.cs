using backendDefault.Aplication.Interfaces;
using backendDefault.Domain;
using Microsoft.AspNetCore.Mvc;
using backendDefault.Domain.Util;

namespace backendDefault.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;
        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        [HttpGet]
        public HttpResponseObj BuscarPorId(int idEmpresa)
        {
            var empresa = _empresaService.BuscarPorId(idEmpresa);
            return empresa;
        }

        [HttpGet]
        public HttpResponseObj BuscarEmpresaComColaboradores(int idEmpresa)
        {
            var empresa = _empresaService.BuscarEmpresaComColaboradores(idEmpresa);
            return empresa;
        }

        [HttpGet]
        public HttpResponseObj BuscarEmpresas()
        {
            var listaEmpresas = _empresaService.BuscarEmpresas();
            return listaEmpresas;
        }

        [HttpPost]
        public HttpResponseObj Adicionar(TblEmpresa novaEmpresa)
        {
            var empresa = _empresaService.Adicionar(novaEmpresa);
            return empresa;
        }
    }
}
