using Ecs.Views.Impl;
using Game.Db.PrefabBase;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Game.Systems
{
    public class TestInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly IPrefabBase _prefabBase;

        public TestInitializeSystem(
            GameContext game,
            IPrefabBase prefabBase
            )
        {
            _game = game;
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
                
                var entity = _game.CreateEntity();
                entity.AddTestFloat(0);
                
                view.Link(entity, _game);
            }
        }
    }
}