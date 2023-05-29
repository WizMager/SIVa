using Ecs.Managers;
using JCMG.EntitasRedux;

namespace Ecs.Action.Components
{
    [Action]
    public class TestCollideComponent : IComponent
    {
        public Uid TargetUid;
    }
}