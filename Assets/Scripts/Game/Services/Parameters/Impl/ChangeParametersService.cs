using Ecs.Extensions.UidGenerator;
using Ecs.Utils.Characteristics;

namespace Game.Services.Parameters.Impl
{
    public class ChangeParametersService : IChangeParametersService
    {
        private readonly GameContext _gameContext;

        public ChangeParametersService(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        public void ChangePlayerParameter(EParameters characteristics, float changeParameter)
        {
            var player = _gameContext.PlayerEntity;

            switch (characteristics)
            {
                case EParameters.Armor:
                    var armor = player.Armor.Value;
                    armor += changeParameter;
                    player.ReplaceArmor(armor);
                    break;
                case EParameters.CritRate:
                    break;
                case EParameters.Dexterity:
                    break;
                case EParameters.EnergyRecovery:
                    break;
                case EParameters.HealthRecovery:
                    break;
                case EParameters.Power:
                    break;
                case EParameters.MoveSpeed:
                    var moveSpeed = player.MoveSpeed.Value;
                    moveSpeed += changeParameter;
                    player.ReplaceMoveSpeed(moveSpeed);
                    break;
                case EParameters.Wisdom:
                    break;
            }
        }

        public void ChangeTargetParameter(Uid targetUid, EParameters characteristic, float changeParameter)
        {
            var target = _gameContext.GetEntityWithUid(targetUid);
            
            switch (characteristic)
            {
                case EParameters.Armor:
                    var armor = target.Armor.Value;
                    armor += changeParameter;
                    target.ReplaceArmor(armor);
                    break;
                case EParameters.CritRate:
                    break;
                case EParameters.Dexterity:
                    break;
                case EParameters.EnergyRecovery:
                    break;
                case EParameters.HealthRecovery:
                    break;
                case EParameters.Power:
                    break;
                case EParameters.MoveSpeed:
                    break;
                case EParameters.Wisdom:
                    break;
            }
        }

        private void ChangeDexterity(float value, GameEntity targetEntity)
        {
            var armor = targetEntity.Armor.Value;
            var energyRecover = targetEntity.EnergyRecovery.Value;

            armor += value / 100 * 0.5f;
            
            targetEntity.ReplaceArmor(armor);
        }
    }
}
