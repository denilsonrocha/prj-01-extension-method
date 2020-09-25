using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using prj_01_extension_method.Services;

namespace prj_01_extension_method.Config
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigDependency(
            this IServiceCollection services, IConfiguration configuration)
            {

                 services.AddTransient<ICalculoService,CalculoService>();

                return services;
            }
    }
}