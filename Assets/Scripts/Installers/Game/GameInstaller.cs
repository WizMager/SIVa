using Ecs.Game.Systems.Camera;
using Game.Models.Camera.Impl;
using Game.Services.TimeProvider.Impl;
using Zenject;

namespace Installers.Game
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindInitializeSystems();
            BindWindows();
            BindSystems();
            BindServices();
            OtherBinds();
        }

        private void BindInitializeSystems()
        {
            
        }
        
        private void BindSystems()
        {
            Container.BindInterfacesAndSelfTo<CameraBrainUpdateSystem>().AsSingle();
        }
        
        private void BindServices()
        {
            Container.BindInterfacesAndSelfTo<TimeProvider>().AsSingle();
        }

        private void BindWindows()
        {
            
        }
        
        private void OtherBinds()
        {
            Container.BindInterfacesAndSelfTo<CameraHolder>().AsSingle();
        }
    }
}