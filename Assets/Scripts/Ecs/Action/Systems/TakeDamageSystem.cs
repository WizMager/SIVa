using JCMG.EntitasRedux;
using System.Collections.Generic;

namespace Assets.Scripts.Ecs.Action.Systems
{
    public class TakeDamageSystem : ReactiveSystem<ActionEntity>
    {
        private readonly GameContext _game;

        public TakeDamageSystem(
            ActionContext context,
            GameContext game
            ) : base(context)
        {
            _game = game;
        }
        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context) =>
           context.CreateCollector(ActionMatcher.TakeDamage);

        protected override bool Filter(ActionEntity entity) => entity.HasTakeDamage && !entity.IsDestroyed;

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                var isDead = actionEntity.TakeDamage.IsTakeDamage;

                _game.PlayerEntity.IsDead = isDead;

                actionEntity.IsDestroyed = true;
            }
        }
    }
}
