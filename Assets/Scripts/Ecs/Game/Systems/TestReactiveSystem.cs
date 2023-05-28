using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Game.Systems
{
    public class TestReactiveSystem : ReactiveSystem<GameEntity>
    {
        public TestReactiveSystem(GameContext context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.TestFloat);

        protected override bool Filter(GameEntity entity) => entity.HasTestFloat && entity.TestFloat.Value > 0 && !entity.IsDestroyed;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var gameEntity in entities)
            {
                if (gameEntity.IsTestUnique)
                {
                    Debug.Log($"[ReactiveSystem]: Unique entity value is {gameEntity.TestFloat.Value}"); 
                }
                else
                {
                    Debug.Log($"[ReactiveSystem]: Common entity value is {gameEntity.TestFloat.Value}"); 
                }
            }
        }
    }
}