using UnityEngine;

namespace ServiceLocatorPattern
{
    public class ServiceLocatorTest : MonoBehaviour
    {
        private void Awake()
        {
            ServiceLocator.Instance.AddService<IMyInterface>(new MyClass());
        }

        private void Start()
        {
            ServiceLocator.Instance.GetService<IMyInterface>().Test();
        }
    }
}