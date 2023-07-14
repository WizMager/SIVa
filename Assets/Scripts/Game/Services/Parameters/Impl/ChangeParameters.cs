using Assets.Scripts.Game.Ecs.Utils.Characteristics;

namespace Assets.Scripts.Game.Services.Parameters.Impl
{
    public class ChangeParameters : IChangeParameters
    {
        private readonly GameContext _gameContext;

        public ChangeParameters(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        public void ChangeParameter(float changeParameter, EParameters characteristics)
        {
            var player = _gameContext.PlayerEntity;

            var parameter = player.UnitParameters.Value;

            switch (characteristics)
            {
                case EParameters.Armor:
                    parameter.Armor += changeParameter;
                    break;
                case EParameters.CreteRate:
                    parameter.CreteRate += changeParameter;
                    break;
                case EParameters.Dexterity:
                    parameter.Dexterity += changeParameter;
                    break;
                case EParameters.EnergyRecovery:
                    parameter.EnergyRecovery += changeParameter;
                    break;
                case EParameters.HealthRecovery:
                    parameter.HealthRecovery += changeParameter;
                    break;
                case EParameters.Power:
                    parameter.Power += changeParameter;
                    break;
                case EParameters.MoveSpeed:
                    parameter.MoveSpeed += changeParameter;
                    break;
                case EParameters.Wisdom:
                    parameter.Wisdom += changeParameter;
                    break;
            }

            player.ReplaceUnitParameters(parameter);

        }
    }
}
