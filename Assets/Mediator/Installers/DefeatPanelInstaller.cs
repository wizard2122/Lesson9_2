using UnityEngine;
using Zenject;

namespace Mediator.Installers
{
    public class DefeatPanelInstaller : MonoInstaller
    {
        [SerializeField] private DefeatPanel _defeatPanelPrefab;
        [SerializeField] private Transform _parent;

        public override void InstallBindings()
        {
            BindInstance();
        }

        private void BindInstance()
        {
            DefeatPanel defeatPanel = Container.InstantiatePrefabForComponent<DefeatPanel>(_defeatPanelPrefab, _parent);
            Container.BindInterfacesAndSelfTo<DefeatPanel>().FromInstance(defeatPanel).AsSingle();
        }
    }
}