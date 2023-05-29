using Ecs.Action.Systems;
using Ecs.Game.Systems;
using Game.Services.TimeProvider.Impl;
using Game.Ui.TestUi;
using Zenject;

namespace Installers.Game
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindInitializeSystems();
            BindSystems();
            BindServices();
            BindWindows();
        }

        private void BindSystems()
        {
            Container.BindInterfacesAndSelfTo<TestCollideSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<TestUpdateSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<TestReactiveSystem>().AsSingle();
        }

        private void BindInitializeSystems()
        {
            Container.BindInterfacesAndSelfTo<TestInitializeSystem>().AsSingle();
        }

        private void BindServices()
        {
            Container.BindInterfacesAndSelfTo<TimeProvider>().AsSingle();
        }

        private void BindWindows()
        {
            Container.DeclareSignal<TestUiWindow>();
            Container.BindInterfacesAndSelfTo<TestUiWindow>().AsSingle();
        }
    }
}