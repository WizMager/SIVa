using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class PowerComponent : IComponent
    {
        public float Value;
    }
}
