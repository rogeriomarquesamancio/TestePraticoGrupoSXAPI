using backendDefault.Aplication.Interfaces;
using backendDefault.Domain;
using backendDefault.Domain.Entities;
using backendDefault.Domain.Interfaces;
using backendDefault.Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backendDefault.Aplication.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _empresaRepository;


        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public HttpResponseObj BuscarPorId(int idEmpresa)
        {
            var empresa = _empresaRepository.BuscarPorId(idEmpresa);
            if (empresa == null)
                return new HttpResponseObj("Empresa inválida");
            return new HttpResponseObj(empresa);
        }

        public HttpResponseObj BuscarEmpresaComColaboradores(int idEmpresa)
        {
            var empresa = _empresaRepository.BuscarEmpresaComColaboradores(idEmpresa);
            if (empresa == null)
                return new HttpResponseObj("Empresa inválida");
            return new HttpResponseObj(empresa);
        }

        public HttpResponseObj BuscarEmpresas()
        {
            var empresa = _empresaRepository.BuscarEmpresas();
            if (empresa == null)
                return new HttpResponseObj("Buscar por empresa inválida");
            return new HttpResponseObj(empresa);
        }

        public HttpResponseObj Adicionar(TblEmpresa novaEmpresa)
        {
            var empresa = _empresaRepository.Adicionar(novaEmpresa);
            if (empresa == null)
                return new HttpResponseObj("Empresa inválida");
            return new HttpResponseObj(empresa);
        }

    }
}
