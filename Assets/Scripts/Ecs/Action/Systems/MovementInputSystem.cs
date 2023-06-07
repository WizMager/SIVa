using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace Ecs.Action.Systems
{
    public class MovementInputSystem : ReactiveSystem<ActionEntity>
    {
        private readonly GameContext _game;
        
        public MovementInputSystem(
            ActionContext context,
            GameContext game
            ) : base(context)
        {
            _game = game;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context) =>
            context.CreateCollector(ActionMatcher.MovementInput);

        protected override bool Filter(ActionEntity entity) => entity.HasMovementInput && !entity.IsDestroyed;

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                actionEntity.IsDestroyed = true;

                var isMove = actionEntity.MovementInput.IsMove;

                _game.PlayerEntity.IsMove = isMove;
            }
        }
    }
}