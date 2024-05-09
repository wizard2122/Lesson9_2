using Zenject;

namespace Mediator.Installers
{
    public class LevelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<Level>().AsSingle();
        }
    }
}