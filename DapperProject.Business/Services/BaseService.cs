using DapperProject.DataAccess.Factories;
using System.Data;

namespace DapperProject.Business.Services
{
    public abstract class BaseService
    {
        private readonly IDbConnectionFactories _dbFactories;

        public BaseService(IDbConnectionFactories dbFactories)
        {
            _dbFactories = dbFactories;
        }

        public async Task<T?> TransactionalFunction<T>(Func<IDbConnection, IDbTransaction, Task<T?>> transactionalTasks)
        {
            T? result = default;

            using (var connection = _dbFactories.GetDbConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    result = await transactionalTasks(connection, transaction);

                    transaction.Commit();
                }

                connection.Close();
            }

            return result;
        }
    }
}
