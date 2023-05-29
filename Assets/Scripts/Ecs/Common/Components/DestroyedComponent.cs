using JCMG.EntitasRedux;

namespace Ecs.Common.Components
{
    [Action]
    [Game]
    [Scheduler]
    [Event(EventTarget.Self)]
    public class DestroyedComponent : IComponent
    {
        
    }
}