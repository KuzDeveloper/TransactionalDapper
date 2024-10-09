using DapperProject.Business.Entities;
using DapperProject.Business.Services;
using DapperProject.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DapperProject.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomDataController : ControllerBase
    {
        private readonly ICustomDataService _customDataService;

        public CustomDataController(ICustomDataService customDataService)
        {
            _customDataService = customDataService;
        }

        [HttpGet(Name = "GetAllCustomData")]
        public async Task<CustomDataResult> GetAllCustomData()
        {
            return await _customDataService.GetCustomDataResult();
        }
    }
}
