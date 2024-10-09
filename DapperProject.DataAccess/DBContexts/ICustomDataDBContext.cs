using DapperProject.DataAccess.Entities;
using System.Data;

namespace DapperProject.DataAccess.DBContexts
{
    public interface ICustomDataDBContext
    {
        Task<IEnumerable<CustomData>> GetAllCustomDataAsync(IDbConnection connection, IDbTransaction transaction);
    }
}
