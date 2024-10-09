using DapperProject.DataAccess.DBContexts;
using DapperProject.DataAccess.Enums;
using DapperProject.DataAccess.Factories;

namespace DapperProject.WebApi.CustomDependencyInjections
{
    public static class DataAccessDependencyInjections
    {
        public static IServiceCollection AddCustomConfigurations(this IServiceCollection services)
        {
            var dataAccessProjectPath = Path.GetFullPath(".\\..\\DapperProject.DataAccess");
            var dbFactories = new DbConnectionFactories(
                $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dataAccessProjectPath}\\DapperTestDB.mdf;Trusted_Connection=True;MultipleActiveResultSets=true",
                DBTypes.SQL);

            return services
                .AddTransient<IDbConnectionFactories>(_ => dbFactories)
                .AddTransient<ICustomDataDBContext, CustomDataDBContext>()
                .AddTransient<IDifferentCustomDataDBContext, DifferentCustomDataDBContext>();
        }
    }
}
