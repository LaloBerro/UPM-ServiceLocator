using UnityEngine;

namespace ServiceLocator.Sample.Scripts.Installers
{
    public class ContextInstaller : MonoBehaviour
    {
        [Header("References")] 
        [SerializeField] private ClassInstaller[] _classInstallers;

        private void Awake()
        {
            foreach (var classInstaller in _classInstallers)
            {
                classInstaller.Install();
            }
        }
    }
}