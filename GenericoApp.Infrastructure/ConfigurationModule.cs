using GenericoApp.Domain.FolhaPagamento.Repository;
using GenericoApp.Infrastructure.Context;
using GenericoApp.Infrastructure.Database;
using GenericoApp.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GenericoApp.Infrastructure
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(x =>
            {
                x.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();            

            return services;
        }
    }
}
