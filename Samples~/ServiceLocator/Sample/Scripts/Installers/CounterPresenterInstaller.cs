using ServiceLocatorPattern;
using ServiceLocatorPattern.Examples;

namespace ServiceLocator.Sample.Scripts.Installers
{
    public class CounterPresenterInstaller : ClassInstaller
    {
        public override void Install()
        {
            ICounterView counterView = ServiceLocatorInstance.Instance.Get<ICounterView>();
            ICounterPresenter counterPresenter = new CounterPresenter(counterView);
            
            ServiceLocatorInstance.Instance.Add<ICounterPresenter>(counterPresenter);
        }
    }
}