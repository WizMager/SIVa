using JCMG.EntitasRedux;

namespace Ecs.Game.Components
{
    [Game]
    [Event(EventTarget.Self)]
    public class TestFloatComponent : IComponent
    {
        public float Value;
    }
}