using Ecs.Game.Extensions;
using Ecs.Views.Impl;
using Game.Db.PrefabBase;
using Game.Providers.GameFieldProvider;
using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Game.Systems.Initialize
{
    public class PlayerInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly IPrefabBase _prefabBase;
        private readonly IGameEnvironmentProvider _gameEnvironmentProvider;
        private readonly DiContainer _diContainer;

        public PlayerInitializeSystem(
            GameContext game,
            IPrefabBase prefabBase,
            IGameEnvironmentProvider gameEnvironmentProvider,
            DiContainer diContainer
            )
        {
            _game = game;
            _prefabBase = prefabBase;
            _gameEnvironmentProvider = gameEnvironmentProvider;
            _diContainer = diContainer;
        }
        
        public void Initialize()
        {
            var gameEnvironment = _gameEnvironmentProvider.GameEnvironment;
            var playerSpawnPoint = gameEnvironment.PlayerSpawnPoint;

            CreatePlayer(playerSpawnPoint);
        }

        private void CreatePlayer(Transform playerSpawnPoint)
        {
            var playerView = Object.Instantiate(_prefabBase.GetPrefabWithName("Player"))
                .GetComponent<PlayerView>();
            _diContainer.Inject(playerView);

            _game.CreatePlayer(playerView, playerSpawnPoint);
        }
    }
}