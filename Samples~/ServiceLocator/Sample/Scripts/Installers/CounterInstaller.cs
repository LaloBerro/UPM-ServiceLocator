using ServiceLocatorPattern;
using ServiceLocatorPattern.Examples;

namespace ServiceLocator.Sample.Scripts.Installers
{
    public class CounterInstaller : ClassInstaller
    {
        public override void Install()
        {
            ICounterPresenter counterPresenter = ServiceLocatorInstance.Instance.Get<ICounterPresenter>();
            Counter counter = new Counter(counterPresenter);
            
            ServiceLocatorInstance.Instance.Add<Counter>(counter);
        }
    }
}