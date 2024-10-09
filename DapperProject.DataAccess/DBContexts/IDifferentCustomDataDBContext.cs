using DapperProject.DataAccess.Entities;
using System.Data;

namespace DapperProject.DataAccess.DBContexts
{
    public interface IDifferentCustomDataDBContext
    {
        Task<IEnumerable<DifferentCustomData>> GetAllDifferentCustomDataAsync(IDbConnection connection, IDbTransaction transaction);
    }
}
