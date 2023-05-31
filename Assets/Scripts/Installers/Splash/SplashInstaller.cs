using Zenject;

namespace Installers.Splash
{
    public class SplashInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<SplashManager>().AsSingle().NonLazy();
        }
    }
}