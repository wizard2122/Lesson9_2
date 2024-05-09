using Zenject;

namespace Mediator.Installers
{
    public class GameplayMediatorInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameplayMediator>().AsSingle();
        }
    }
}