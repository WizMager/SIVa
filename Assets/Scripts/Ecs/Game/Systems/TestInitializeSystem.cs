using Ecs.Views.Impl;
using Game.Db.PrefabBase;
using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Game.Systems
{
    public class TestInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly DiContainer _diContainer;
        private readonly IPrefabBase _prefabBase;

        public TestInitializeSystem(
            GameContext game,
            DiContainer diContainer,
            IPrefabBase prefabBase
        )
        {
            _game = game;
            _diContainer = diContainer;
            _prefabBase = prefabBase;
        }
        
        public void Initialize()
        {
            CreateUnique();
            CreateCommon(2);
            Debug.Log("[Initialize System]: Done");
        }

        private void CreateUnique()
        {
            var view = Object.Instantiate(_prefabBase.GetPrefabWithName("CubeTestView")).GetComponent<TestView>();
            _diContainer.Inject(view);
            
            var entity = _game.CreateEntity();
            entity.IsTestUnique = true;
            entity.AddTestFloat(0);

            view.Link(entity, _game);
        }

        private void CreateCommon(int number)
        {
            for (int i = 0; i < number; i++)
            {
                var view = Object.Instantiate(_prefabBase.GetPrefabWithName("CubeTestView")).GetComponent<TestView>();
                _diContainer.Inject(view);
                
                var entity = _game.CreateEntity();
                entity.AddTestFloat(0);
                
                view.Link(entity, _game);
            }
        }
    }
}