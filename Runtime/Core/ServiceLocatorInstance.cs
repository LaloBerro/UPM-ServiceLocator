using SingletonPattern;

namespace ServiceLocatorPattern
{
    public class ServiceLocatorInstance : Singleton<ServiceLocatorInstance>
    {
        private readonly IServiceLocator _serviceLocator = new ServiceLocator();
        
        public void Add<ServiceType>(ServiceType service)
        {
            _serviceLocator.Add(service);
        }

        public ServiceType Get<ServiceType>()
        {
            return _serviceLocator.Get<ServiceType>();
        }

        public void Remove<ServiceType>()
        {
            _serviceLocator.Remove<ServiceType>();
        }

        public bool IsContained<ServiceType>()
        {
            return _serviceLocator.IsContained<ServiceType>();
        }
    }
}