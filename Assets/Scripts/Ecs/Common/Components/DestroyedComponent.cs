using JCMG.EntitasRedux;

namespace Ecs.Common.Components
{
    [Action]
    [Game]
    [Event(EventTarget.Self)]
    public class DestroyedComponent : IComponent
    {
        
    }
}