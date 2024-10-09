using System.Data;

namespace DapperProject.DataAccess.Factories
{
    public interface IDbConnectionFactories
    {
        IDbConnection GetDbConnection();
    }
}
