using DapperProject.Business.Entities;

namespace DapperProject.Business.Services
{
    public interface ICustomDataService
    {
        Task<CustomDataResult> GetCustomDataResult();
    }
}
