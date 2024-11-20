using DI_Service_LifeTime.Services.Inter;

namespace DI_Service_LifeTime.Services.InterImpl
{
    public class ScopedGuidServiceImpl : IScopedGuidService
    {
        private readonly Guid id;
        public ScopedGuidServiceImpl() 
        {
            id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return id.ToString();
        }
    }
}
