using Mediator.Scripts;
using Zenject;

namespace Mediator.Installers
{
    public class InputHandlerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputHandler>().AsSingle();
        }
    }
}