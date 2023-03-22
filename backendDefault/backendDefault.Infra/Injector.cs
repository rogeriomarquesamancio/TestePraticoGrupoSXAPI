using Microsoft.Extensions.DependencyInjection;
using backendDefault.Aplication.Interfaces;
using backendDefault.Aplication.Services;
using backendDefault.Domain.Interfaces;
using backendDefault.Infra.Repositories;

namespace backendDefault.Infra
{
    public static class Injector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region services
            services.AddScoped<IColaboradorService, ColaboradorService>();
            services.AddScoped<IEmpresaService, EmpresaService>();
            #endregion

            #region repository
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            #endregion
        }
    }
}
