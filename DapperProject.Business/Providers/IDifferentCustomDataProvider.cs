using DapperProject.DataAccess.Entities;
using System.Data;

namespace DapperProject.Business.Providers
{
    public interface IDifferentCustomDataProvider
    {
        Task<IEnumerable<DifferentCustomData>> GetAllDifferentCustomData(IDbConnection connection, IDbTransaction transaction);
    }
}
