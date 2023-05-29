using JCMG.EntitasRedux;

namespace Ecs.Game.Components
{
    [Game]
    [Unique]
    [Event(EventTarget.Self)]
    public class TestCounterComponent : IComponent
    {
        public int Value;
    }
}