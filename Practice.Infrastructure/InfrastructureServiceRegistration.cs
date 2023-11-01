using Microsoft.Extensions.DependencyInjection;
using Practice.Application.Contracts.Insfrastructure;
using Practice.Infrastructure.Services;

namespace Practice.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IRequestExternalApiService, RequestExternalApiService>();

            return services;
        }
    }
}
