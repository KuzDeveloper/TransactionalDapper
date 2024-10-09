using DapperProject.DataAccess.Entities;

namespace DapperProject.Business.Entities
{
    public class CustomDataResult
    {
        public IEnumerable<CustomData> CustomData { get; private set; }
        public IEnumerable<DifferentCustomData> DifferentCustomData { get; private set; }

        public CustomDataResult(IEnumerable<CustomData> customData,
            IEnumerable<DifferentCustomData> differentCustomData)
        {
            CustomData = customData;
            DifferentCustomData = differentCustomData;
        }
    }
}
