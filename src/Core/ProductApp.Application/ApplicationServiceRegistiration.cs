using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProductApp.Application
{
    public static class ApplicationServiceRegistiration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assembly);
            services.AddMediatR(assembly);

            return services;
        }
    }
}
