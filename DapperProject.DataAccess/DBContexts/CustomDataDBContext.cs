using DapperProject.DataAccess.Entities;
using System.Data;
using Dapper;
using DapperProject.DataAccess.SQLScripts;

namespace DapperProject.DataAccess.DBContexts
{
    public class CustomDataDBContext : ICustomDataDBContext
    {
        public Task<IEnumerable<CustomData>> GetAllCustomDataAsync(IDbConnection connection, IDbTransaction transaction)
        {
            return connection.ExecuteScalarAsync<IEnumerable<CustomData>>(
                CustomDataScripts.GetAllCustomData,
                transaction: transaction);
        }
    }
}
