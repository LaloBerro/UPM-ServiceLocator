using System;
using System.Collections.Generic;

namespace ServiceLocatorPattern
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly Dictionary<Type, object> _services = new();

        public void Add<ServiceType>(ServiceType service)
        {
            Type type = typeof(ServiceType);

            _services.Add(type, service);
        }

        public ServiceType Get<ServiceType>()
        {
            Type type = typeof(ServiceType);

            if (!_services.TryGetValue(type, out var service))
                throw new Exception("There isn't a service with the type: " + type.Name);

            return (ServiceType)service;
        }

        public void Remove<ServiceType>()
        {
            Type type = typeof(ServiceType);

            if (!_services.ContainsKey(type))
                throw new Exception($"The service {type.Name} is not in the service locator. So you can't remove.");

            _services.Remove(type);
        }

        public bool IsContained<ServiceType>()
        {
            Type type = typeof(ServiceType);

            return _services.ContainsKey(type);
        }
    }
}