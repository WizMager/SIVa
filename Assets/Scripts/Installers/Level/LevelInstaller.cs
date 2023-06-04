using Ecs.Action.Systems;
using Ecs.Game.Systems.Initialize;
using Ecs.Game.Systems.Movement;
using Game.Providers.GameFieldProvider;
using Game.Providers.GameFieldProvider.Impl;
using Game.Services.InputService.Impl;
using Game.Utils;
using UnityEngine;
using Zenject;

namespace Installers.Level
{
    public class LevelInstaller : MonoInstaller
    {
        [SerializeField] private GameEnvironment gameEnvironment;
        
        public override void InstallBindings()
        {
            var gameFieldProvider = new GameEnvironmentProvider(gameEnvironment);

            Container.Bind<IGameEnvironmentProvider>().FromInstance(gameFieldProvider).AsSingle();
            
            Container.BindInterfacesAndSelfTo<InputService>().AsSingle();
            
            BindInitializeSystems();
            BindSystems();
        }
        
        private void BindInitializeSystems()
        {
            Container.BindInterfacesAndSelfTo<PlayerInitializeSystem>().AsSingle();
        }
        
        private void BindSystems()
        {
            Container.BindInterfacesAndSelfTo<MovementInputSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerMovementSystem>().AsSingle();
        }
    }
}