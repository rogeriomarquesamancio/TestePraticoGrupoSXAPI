using backendDefault.Domain.DTO;
using backendDefault.Domain.Interfaces;
using backendDefault.Infra.Context;
using backendDefault.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using backendDefault.Domain;

namespace backendDefault.Infra.Repositories
{
    class EmpresaRepository : IEmpresaRepository
    {
        private readonly BaseRepository<TblEmpresa> _empresaRep;
        private readonly BaseRepository<TblColaborador> _colaboradorRep;

        public EmpresaRepository(SXContext empresa, SXContext colaborador)
        {
            _empresaRep = new BaseRepository<TblEmpresa>(empresa);
            _colaboradorRep = new BaseRepository<TblColaborador>(colaborador);
        }

        public TblEmpresa BuscarPorId(int idEmpresa)
        {
            try
            {
                var empresa = _empresaRep.GetByID(idEmpresa);
                return empresa;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public EmpresaColaboradoresDTO BuscarEmpresaComColaboradores(int idEmpresa)
        {
            try
            {
                var empresa = _empresaRep.Get()
                    .Where(empresa => empresa.IdEmpresa == idEmpresa)
                    .FirstOrDefault();

                var colaboradores = _colaboradorRep.Get()
                  .Where(colaborador => colaborador.IdEmpresa == idEmpresa)
                  .ToList();

                return new EmpresaColaboradoresDTO() { Empresa = empresa, Colaboradores = colaboradores };
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TblEmpresa> BuscarEmpresas()
        {
            try
            {

                var listaEmpresa = _empresaRep.Get().ToList();
                return listaEmpresa;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public TblEmpresa Adicionar(TblEmpresa empresa)
        {
            try
            {

                var empresaExistente = _empresaRep.Get()
                    .Where(c => c.Cnpj == empresa.Cnpj)
                    .Count();

                if (empresaExistente > 0)
                {
                    return null;
                }

                _empresaRep.Insert(empresa);
                _empresaRep.Commit();
                return empresa;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
