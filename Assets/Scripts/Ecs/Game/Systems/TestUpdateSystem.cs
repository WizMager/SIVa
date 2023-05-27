using System.Linq;
using Game.Services.TimeProvider;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Game.Systems
{
    public class TestUpdateSystem : IUpdateSystem
    {
        private readonly GameContext _game;
        private readonly ITimeProviderService _timeProviderService;

        public TestUpdateSystem(
            GameContext game,
            ITimeProviderService timeProviderService
            )
        {
            _game = game;
            _timeProviderService = timeProviderService;
        }
        
        public void Update()
        {
            Debug.Log($"[UpdateSystem] Delta time is {_timeProviderService.DeltaTime}");
            
            AddToUnique();
            
            var groupEntities = _game.GetGroup(GameMatcher.AllOf(GameMatcher.TestFloat).NoneOf(GameMatcher.Destroyed));

            foreach (var entity in groupEntities)
            {
                var floatValue = entity.TestFloat.Value; 
                entity.ReplaceTestFloat(floatValue + _timeProviderService.DeltaTime);
            }
        }

        private void AddToUnique()
        {
            var unique = _game.TestUniqueEntity;
            var floatValue = unique.TestFloat.Value;
            unique.ReplaceTestFloat(floatValue + _timeProviderService.DeltaTime);
        }
    }
}