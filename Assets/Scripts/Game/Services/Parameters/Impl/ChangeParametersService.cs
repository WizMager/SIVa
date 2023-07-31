using Ecs.Extensions.UidGenerator;
using Ecs.Utils.Parameters;

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
                    var critRate = player.CritRate.Value;
                    critRate += changeParameter;
                    player.ReplaceCritRate(critRate);
                    break;
                case EParameters.Dexterity:
                    var dexterity = player.Dexterity.Value;
                    dexterity += changeParameter;
                    player.ReplaceDexterity(dexterity);
                    break;
                case EParameters.EnergyRecovery:
                    var energyRecovery = player.EnergyRecovery.Value;
                    energyRecovery += changeParameter;
                    player.ReplaceEnergyRecovery(energyRecovery);
                    break;
                case EParameters.HealthRecovery:
                    var healthRecovery = player.HealthRecovery.Value;
                    healthRecovery += changeParameter;
                    player.ReplaceHealthRecovery(healthRecovery);
                    break;
                case EParameters.Power:
                    var power = player.Power.Value;
                    power += changeParameter;
                    player.ReplacePower(power);
                    break;
                case EParameters.MoveSpeed:
                    var moveSpeed = player.MoveSpeed.Value;
                    moveSpeed += changeParameter;
                    player.ReplaceMoveSpeed(moveSpeed);
                    break;
                case EParameters.Wisdom:
                    var wisdom = player.Wisdom.Value;
                    wisdom += changeParameter;
                    player.ReplaceWisdom(wisdom);
                    break;
                case EParameters.Health:
                    var health = player.Health.CurrentValue;
                    health += changeParameter;
                    player.ReplaceHealth(health, health);
                    break;
                case EParameters.Mana:
                    var mana = player.Mana.CurrentValue;
                    mana += changeParameter;
                    player.ReplaceMana(mana, mana);
                    break;
                case EParameters.UltimateEnergy:
                    var ultimateEnergy = player.UltimateEnergy.CurrentValue;
                    ultimateEnergy += changeParameter;
                    player.ReplaceUltimateEnergy(ultimateEnergy, ultimateEnergy);
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
                    var critRate = target.CritRate.Value;
                    critRate += changeParameter;
                    target.ReplaceCritRate(critRate);
                    break;
                case EParameters.Dexterity:
                    var dexterity = target.Dexterity.Value;
                    dexterity += changeParameter;
                    target.ReplaceDexterity(dexterity);
                    break;
                case EParameters.EnergyRecovery:
                    var energyRecovery = target.EnergyRecovery.Value;
                    energyRecovery += changeParameter;
                    target.ReplaceEnergyRecovery(energyRecovery);
                    break;
                case EParameters.HealthRecovery:
                    var healthRecovery = target.HealthRecovery.Value;
                    healthRecovery += changeParameter;
                    target.ReplaceHealthRecovery(healthRecovery);
                    break;
                case EParameters.Power:
                    var power = target.Power.Value;
                    power += changeParameter;
                    target.ReplacePower(power);
                    break;
                case EParameters.MoveSpeed:
                    var moveSpeed = target.MoveSpeed.Value;
                    moveSpeed += changeParameter;
                    target.ReplaceMoveSpeed(moveSpeed);
                    break;
                case EParameters.Wisdom:
                    var wisdom = target.Wisdom.Value;
                    wisdom += changeParameter;
                    target.ReplaceWisdom(wisdom);
                    break;
                case EParameters.Health:
                    var health = target.Health.CurrentValue;
                    health += changeParameter;
                    target.ReplaceHealth(health, health);
                    break;
                case EParameters.Mana:
                    var mana = target.Mana.CurrentValue;
                    mana += changeParameter;
                    target.ReplaceMana(mana, mana);
                    break;
                case EParameters.UltimateEnergy:
                    var ultimateEnergy = target.UltimateEnergy.CurrentValue;
                    ultimateEnergy += changeParameter;
                    target.ReplaceUltimateEnergy(ultimateEnergy, ultimateEnergy);
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
