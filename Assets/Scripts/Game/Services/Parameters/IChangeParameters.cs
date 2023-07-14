using Assets.Scripts.Game.Ecs.Utils.Characteristics;

namespace Assets.Scripts.Game.Services.Parameters
{
    public interface IChangeParameters
    {
        void ChangeParameter(float parameter, EParameters characteristics);
    }
}
