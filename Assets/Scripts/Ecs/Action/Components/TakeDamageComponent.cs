using Ecs.Extensions.UidGenerator;
using JCMG.EntitasRedux;

namespace Assets.Scripts.Ecs.Action.Components
{
    [Action]
    public class TakeDamageComponent : IComponent
    {
        public Uid target;
        public Uid attaker;
    }
}
