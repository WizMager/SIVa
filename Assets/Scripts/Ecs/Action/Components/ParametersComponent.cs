using Assets.Scripts.Game.Ecs.Utils.Characteristics;
using Ecs.Extensions.UidGenerator;
using JCMG.EntitasRedux;

namespace Assets.Scripts.Ecs.Action.Components
{
    [Action]
    public class ParametersComponent : IComponent
    {
        public EParameters CharType;
        public float Value;
        public Uid uid;
    }
}
