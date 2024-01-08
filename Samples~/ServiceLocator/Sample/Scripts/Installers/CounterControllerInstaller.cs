using ServiceLocatorPattern;
using ServiceLocatorPattern.Examples;

namespace ServiceLocator.Sample.Scripts.Installers
{
    public class CounterControllerInstaller : ClassInstaller
    {
        private CounterController _counterController;
        
        public override void Install()
        {
            ICounterView counterView = ServiceLocatorInstance.Instance.Get<ICounterView>();
            Counter counter = ServiceLocatorInstance.Instance.Get<Counter>();
            _counterController = new CounterController(counterView, counter);
            
            ServiceLocatorInstance.Instance.Add<CounterController>(_counterController);
        }

        private void OnDestroy()
        {
            _counterController.Dispose();
        }
    }
}