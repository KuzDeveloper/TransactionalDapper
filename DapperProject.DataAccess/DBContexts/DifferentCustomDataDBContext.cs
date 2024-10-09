using DapperProject.DataAccess.Entities;
using System.Data;
using Dapper;
using DapperProject.DataAccess.SQLScripts;

namespace DapperProject.DataAccess.DBContexts
{
    public class DifferentCustomDataDBContext : IDifferentCustomDataDBContext
    {
        public Task<IEnumerable<DifferentCustomData>> GetAllDifferentCustomDataAsync(IDbConnection connection, IDbTransaction transaction)
        {
            return connection.ExecuteScalarAsync<IEnumerable<DifferentCustomData>>(
                DifferentCustomDataScripts.GetAllDifferentCustomData,
                transaction: transaction);
        }
    }
}
