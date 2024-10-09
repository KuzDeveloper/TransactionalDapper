using DapperProject.Business.Providers;
using DapperProject.Business.Services;

namespace DapperProject.WebApi.CustomDependencyInjections
{
    public static class BusinessDependencyInjections
    {
        public static IServiceCollection AddCustomConfigurations(this IServiceCollection services)
        {
            return services
                .AddTransient<ICustomDataService, CustomDataService>()
                .AddTransient<ICustomDataProvider, CustomDataProvider>()
                .AddTransient<IDifferentCustomDataProvider, DifferentCustomDataProvider>();
        }
    }
}
