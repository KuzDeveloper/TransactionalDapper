using DapperProject.Business.Entities;
using DapperProject.Business.Providers;
using DapperProject.DataAccess.Factories;

namespace DapperProject.Business.Services
{
    public class CustomDataService : BaseService, ICustomDataService
    {
        private readonly ICustomDataProvider _customDataProvider;
        private readonly IDifferentCustomDataProvider _differentCustomDataProvider;

        public CustomDataService(IDbConnectionFactories dbFactories,
            ICustomDataProvider customDataProvider,
            IDifferentCustomDataProvider differentCustomDataProvider)
            : base(dbFactories)
        {
            _customDataProvider = customDataProvider;
            _differentCustomDataProvider = differentCustomDataProvider;
        }

        public async Task<CustomDataResult> GetCustomDataResult()
        {
            return await TransactionalFunction(async (connection, transaction) =>
            {
                var customData = await _customDataProvider.GetAllCustomData(connection, transaction);
                var differentCustomData = await _differentCustomDataProvider.GetAllDifferentCustomData(connection, transaction);

                var result = new CustomDataResult(customData, differentCustomData);

                return result;
            });
        }
    }
}
