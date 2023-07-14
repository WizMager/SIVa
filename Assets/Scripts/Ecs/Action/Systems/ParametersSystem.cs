using JCMG.EntitasRedux;
using System.Collections.Generic;
using Assets.Scripts.Game.Ecs.Utils.Characteristics;

namespace Assets.Scripts.Ecs.Action.Systems
{
    public class ParametersSystem : ReactiveSystem<ActionEntity>
    {
        private readonly GameContext _game;

        public ParametersSystem(
            ActionContext context,
            GameContext game) : base(context)
        {
            _game = game;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context) => context.CreateCollector(ActionMatcher.Parameters);

        protected override bool Filter(ActionEntity entity) => entity.HasParameters && !entity.IsDestroyed;

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                actionEntity.IsDestroyed = true;

                var parameters = actionEntity.Parameters;

                var entity = _game.GetEntityWithUid(parameters.uid);

                switch (parameters.CharType)
                {
                    case EParameters.Armor:
                        var targetArmor = entity.Armor.Value;
                        targetArmor += parameters.Value;
                        entity.ReplaceArmor(targetArmor);
                        break;
                    case EParameters.CreteRate:
                        var targetCritRate = entity.CreteRate.Value;
                        targetCritRate += parameters.Value;
                        entity.ReplaceCreteRate(targetCritRate);
                        break;
                    case EParameters.Dexterity:
                        var targetDexterity = entity.Dexterity.Value;
                        targetDexterity += parameters.Value;
                        entity.ReplaceDexterity(targetDexterity);
                        break;
                    case EParameters.EnergyRecovery:
                        var targetEnergyRecovery = entity.EnergyRecovery.Value;
                        targetEnergyRecovery += parameters.Value;
                        entity.ReplaceEnergyRecovery(targetEnergyRecovery);
                        break;
                    case EParameters.HealthRecovery:
                        var targetHealthRecovery = entity.HealthRecovery.Value;
                        targetHealthRecovery += parameters.Value;
                        entity.ReplaceHealthRecovery(targetHealthRecovery);
                        break;
                    case EParameters.Power:
                        var targetPower = entity.Power.Value;
                        targetPower += parameters.Value;
                        entity.ReplacePower(targetPower);
                        break;
                    case EParameters.MoveSpeed:
                        var targetSpeed = entity.MoveSpeed.Value;
                        targetSpeed += parameters.Value;
                        entity.ReplaceMoveSpeed(targetSpeed);
                        break;
                    case EParameters.Wisdom:
                        var targetWisdom = entity.Wisdom.Value;
                        targetWisdom += parameters.Value;
                        entity.ReplaceWisdom(targetWisdom);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
