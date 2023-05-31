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
        }
    }
}