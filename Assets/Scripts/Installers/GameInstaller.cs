using Ecs.Game.Systems;
using Game.Services.TimeProvider.Impl;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindSystems();
            BindServices();
        }

        private void BindSystems()
        {
            Container.BindInterfacesAndSelfTo<TestInitializeSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<TestUpdateSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<TestReactiveSystem>().AsSingle();
        }
        
        private void BindServices()
        {
            Container.BindInterfacesAndSelfTo<TimeProviderService>().AsSingle();
        }
    }
}