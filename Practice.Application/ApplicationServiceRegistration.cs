using Microsoft.Extensions.DependencyInjection;
using Practice.Application.Mappings;
using System.Reflection;

namespace Practice.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(x=>x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(typeof(UsuarioAutoMapperProfile));

            return services;
        }
    }
}
