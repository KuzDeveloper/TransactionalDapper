using DapperProject.DataAccess.Enums;
using System.Data;
using System.Data.SqlClient;

namespace DapperProject.DataAccess.Factories
{
    public class DbConnectionFactories : IDbConnectionFactories
    {
        private readonly string _connectionString;
        private readonly DBTypes _dbType;

        public DbConnectionFactories(string connectionString, DBTypes dbType)
        {
            _connectionString = connectionString;
            _dbType = dbType;
        }

        public IDbConnection GetDbConnection()
        {
            switch (_dbType)
            {
                case DBTypes.SQL: return new SqlConnection(_connectionString);
                default: throw new NotImplementedException();
            }
        }
    }
}
