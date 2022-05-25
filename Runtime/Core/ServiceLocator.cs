using System;
using System.Collections.Generic;
using SingletonPattern;

namespace ServiceLocatorPattern
{
    public class ServiceLocator : Singleton<ServiceLocator>
    {
        private readonly Dictionary<Type, object> _services;

        public ServiceLocator()
        {
            _services = new Dictionary<Type, object>();
        }

        public void AddService<ServiceType>(ServiceType service)
        {
            Type type = typeof(ServiceType);

            _services.Add(type, service);
        }

        public ServiceType GetService<ServiceType>()
        {
            Type type = typeof(ServiceType);

            if (!_services.TryGetValue(type, out var service))
                throw new Exception("There isn't a service with the type: " + type.Name);

            return (ServiceType)service;
        }

        public void RemoveService<ServiceType>()
        {
            Type type = typeof(ServiceType);

            if (!_services.ContainsKey(type))
                throw new Exception($"The service {type.Name} is not in the service locator. So you can't remove.");

            _services.Remove(type);
        }
    }
}