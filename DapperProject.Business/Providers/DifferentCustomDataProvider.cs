using DapperProject.DataAccess.DBContexts;
using DapperProject.DataAccess.Entities;
using System.Data;

namespace DapperProject.Business.Providers
{
    public class DifferentCustomDataProvider : IDifferentCustomDataProvider
    {
        private readonly IDifferentCustomDataDBContext _differentCustomDataDBContext;

        public DifferentCustomDataProvider(IDifferentCustomDataDBContext differentCustomDataDBContext)
        {
            _differentCustomDataDBContext = differentCustomDataDBContext;
        }

        public Task<IEnumerable<DifferentCustomData>> GetAllDifferentCustomData(IDbConnection connection, IDbTransaction transaction)
        {
            return _differentCustomDataDBContext.GetAllDifferentCustomDataAsync(connection, transaction);
        }
    }
}
