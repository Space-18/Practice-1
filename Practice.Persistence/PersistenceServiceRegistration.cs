using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Practice.Application.Contracts.Persistence;
using Practice.Persistence.Repositories;

namespace Practice.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("cn"));
            });

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
