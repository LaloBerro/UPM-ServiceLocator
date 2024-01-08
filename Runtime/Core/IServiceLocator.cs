namespace ServiceLocatorPattern
{
    public interface IServiceLocator
    {
        void Add<ServiceType>(ServiceType service);
        ServiceType Get<ServiceType>();
        void Remove<ServiceType>();
        bool IsContained<ServiceType>();
    }
}