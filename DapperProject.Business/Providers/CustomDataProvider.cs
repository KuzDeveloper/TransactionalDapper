using DapperProject.DataAccess.DBContexts;
using DapperProject.DataAccess.Entities;
using System.Data;

namespace DapperProject.Business.Providers
{
    public class CustomDataProvider : ICustomDataProvider
    {
        private readonly ICustomDataDBContext _customDataDBContext;

        public CustomDataProvider(ICustomDataDBContext customDataDBContext)
        {
            _customDataDBContext = customDataDBContext;
        }

        public Task<IEnumerable<CustomData>> GetAllCustomData(IDbConnection connection, IDbTransaction transaction)
        {
            return _customDataDBContext.GetAllCustomDataAsync(connection, transaction);
        }
    }
}
