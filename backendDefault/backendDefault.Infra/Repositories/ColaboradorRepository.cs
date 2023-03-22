using backendDefault.Domain.Interfaces;
using backendDefault.Infra.Context;
using backendDefault.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace backendDefault.Infra.Repositories
{
    class ColaboradorRepository : IColaboradorRepository
    {
        private readonly BaseRepository<TblColaborador> _colaboradorRep;

        public ColaboradorRepository(SXContext colaborador)
        {
            _colaboradorRep = new BaseRepository<TblColaborador>(colaborador);

        }

        public TblColaborador BuscarPorId(int id)
        {
            try
            {
                var colaborador = _colaboradorRep.GetByID(id);
                return colaborador;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public List<TblColaborador> BuscarColaboradoresPorIdEmpresa(int idEmpresa)
        {
            try
            {
                var lista = _colaboradorRep.Get()
                    .Where(colaborador => colaborador.IdEmpresa == idEmpresa)
                    .ToList();
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public TblColaborador Adicionar(TblColaborador colaborador)
        {
            try
            {
                var colaboradorExistente = _colaboradorRep.Get()
                    .Where(c => c.Cpf == colaborador.Cpf)
                    .Count();

                if (colaboradorExistente > 0)
                {
                    return null;
                }

                _colaboradorRep.Insert(colaborador);
                _colaboradorRep.Commit();
                return colaborador;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
