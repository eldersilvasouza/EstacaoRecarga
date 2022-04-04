using EstacaoRecarga.Application;
using EstacaoRecarga.Data;
using EstacaoRecarga.Data.Repositories;
using EstacaoRecarga.Domain.Interfaces.Repositories;
using EstacaoRecarga.Domain.Interfaces.Services;
using EstacaoRecarga.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacaoRecarga.Web.Configs
{
    public static class DependecyInjection
    {
        public static IServiceCollection ResolveDependecies (this IServiceCollection services)
        {
            services.AddScoped<EstacaoContext>();

            services.AddScoped<IRecargaApplication,RecargaApplication >();
            services.AddScoped<IRecargaService, RecargaService>();

            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));



            return services;
        }





    }
}
