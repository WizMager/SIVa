using Ecs.Managers;
using Ecs.Views.Impl;
using Game.Db.PrefabBase;
using Game.Providers.GameFieldProvider;
using Game.Ui.TestUi;
using JCMG.EntitasRedux;
using SimpleUi.Signals;
using UnityEngine;
using Zenject;

namespace Ecs.Game.Systems
{
    public class TestInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly DiContainer _diContainer;
        private readonly IPrefabBase _prefabBase;
        private readonly IGameEnvironmentProvider _gameEnvironmentProvider;
        private readonly SignalBus _signalBus;

        public TestInitializeSystem(
            GameContext game,
            DiContainer diContainer,
            IPrefabBase prefabBase,
            IGameEnvironmentProvider gameEnvironmentProvider,
            SignalBus signalBus
        )
        {
            _game = game;
            _diContainer = diContainer;
            _prefabBase = prefabBase;
            _gameEnvironmentProvider = gameEnvironmentProvider;
            _signalBus = signalBus;
        }
        
        public void Initialize()
        {
            CreateUnique();
            CreateCommon(2);
            CreateCounter();
            
            _signalBus.OpenWindow<TestUiWindow>();
            Debug.Log("[Initialize System]: Done");
        }

        private void CreateUnique()
        {
            var spawnPoint = _gameEnvironmentProvider.GameEnvironment.SpawnPoint;
            var view = Object.Instantiate(_prefabBase.GetPrefabWithName("CubeTestView"), spawnPoint.position, spawnPoint.rotation).GetComponent<TestView>();
            _diContainer.Inject(view);
            
            var entity = _game.CreateEntity();
            entity.IsTestUnique = true;
            entity.AddTestFloat(0);
            entity.AddUid(UidGenerator.Next());

            view.Link(entity, _game);
        }

        private void CreateCommon(int number)
        {
            var spawnPoint = _gameEnvironmentProvider.GameEnvironment.SpawnPoint;
            
            for (int i = 0; i < number; i++)
            {
                var view = Object.Instantiate(_prefabBase.GetPrefabWithName("CubeTestView"), spawnPoint.position, spawnPoint.rotation).GetComponent<TestView>();
                _diContainer.Inject(view);
                
                var entity = _game.CreateEntity();
                entity.AddTestFloat(0);
                entity.AddUid(UidGenerator.Next());
                
                view.Link(entity, _game);
            }
        }
        
        private void CreateCounter()
        {
            var entity = _game.CreateEntity();
            entity.AddTestCounter(0);
        }
    }
}