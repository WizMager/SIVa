using JCMG.EntitasRedux;

namespace Ecs.Game.Components
{
    [Game]
    [Unique]
    [Event(EventTarget.Self)]
    [Event(EventTarget.Self, EventType.Removed)]
    public class TestCounterComponent : IComponent
    {
        public int Value;
    }
}