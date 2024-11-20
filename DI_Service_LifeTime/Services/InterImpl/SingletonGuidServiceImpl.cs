using DI_Service_LifeTime.Services.Inter;

namespace DI_Service_LifeTime.Services.InterImpl
{
    public class SingletonGuidServiceImpl : ISingletonGuidService
    {
        private readonly Guid id;
        public SingletonGuidServiceImpl()
        {
            id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return id.ToString();
        }
    }
}
