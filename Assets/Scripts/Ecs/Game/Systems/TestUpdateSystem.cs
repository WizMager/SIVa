using System.Linq;
using Game.Services.TimeProvider;
using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Game.Systems
{
    public class TestUpdateSystem : IUpdateSystem
    {
        private static readonly ListPool<GameEntity> ListPool = ListPool<GameEntity>.Instance;

        private readonly IGroup<GameEntity> _testGroup;

        private readonly GameContext _game;
        private readonly ITimeProviderService _timeProviderService;

        public TestUpdateSystem(
            GameContext game,
            ITimeProviderService timeProviderService
            )
        {
            _game = game;
            _timeProviderService = timeProviderService;

            _testGroup = _game.GetGroup(GameMatcher.AllOf(GameMatcher.TestFloat).NoneOf(GameMatcher.Destroyed));
        }
        
        public void Update()
        {
            Debug.Log($"[UpdateSystem] Delta time is {_timeProviderService.DeltaTime}");
            
            AddToUnique();

            var testEntities = ListPool.Spawn();
            _testGroup.GetEntities(testEntities);

            foreach (var entity in testEntities)
            {
                var floatValue = entity.TestFloat.Value; 
                entity.ReplaceTestFloat(floatValue + _timeProviderService.DeltaTime);
            }
            
            ListPool.Despawn(testEntities);
        }

        private void AddToUnique()
        {
            var unique = _game.TestUniqueEntity;
            
            if (!unique.HasTestFloat) return;
            
            var floatValue = unique.TestFloat.Value;
            unique.ReplaceTestFloat(floatValue + _timeProviderService.DeltaTime);
        }
    }
}