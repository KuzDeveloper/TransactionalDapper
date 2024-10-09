using DapperProject.DataAccess.Entities;
using System.Data;

namespace DapperProject.Business.Providers
{
    public interface ICustomDataProvider
    {
        Task<IEnumerable<CustomData>> GetAllCustomData(IDbConnection connection, IDbTransaction transaction);
    }
}
