using DI_Service_LifeTime.Services.Inter;

namespace DI_Service_LifeTime.Services.InterImpl
{
    public class TransientGuidServiceImpl : ITransientGuidService
    {
        private readonly Guid id;
        public TransientGuidServiceImpl()
        {
            id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return id.ToString();
        }
    }
}
