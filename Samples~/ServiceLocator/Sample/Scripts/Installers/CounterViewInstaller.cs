using ServiceLocatorPattern;
using ServiceLocatorPattern.Examples;
using UnityEngine;

namespace ServiceLocator.Sample.Scripts.Installers
{
    public class CounterViewInstaller : ClassInstaller
    {
        [Header("References")] 
        [SerializeField] private CounterView _counterView; 
        
        public override void Install()
        {
            ServiceLocatorInstance.Instance.Add<ICounterView>(_counterView);
        }
    }
}