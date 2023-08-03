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
                actionEntity.IsDestroyed = true;

                var targetUid = actionEntity.TakeDamage.target;

                var target = _game.GetEntityWithUid(targetUid);

                var maxHealth = target.Health.MaxValue;

                var currentHealth = target.Health.CurrentValue;

                var damageWhithoutArmor = 100 * (1 + (target.Power.Value * 0.001f)); // from formula

                var armorCheck = damageWhithoutArmor * (target.Armor.Value * 0.001f);

                var finalDamage = damageWhithoutArmor - armorCheck;

                var healtAfterDamage = currentHealth - finalDamage;

                if (healtAfterDamage <= 0)
                {
                    target.IsDead = true;
                    target.ReplaceHealth(maxHealth, 0);
                }                
                else target.ReplaceHealth(maxHealth, healtAfterDamage);
            }
        }
    }
}
