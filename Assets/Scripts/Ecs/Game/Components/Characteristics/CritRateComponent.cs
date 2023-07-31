using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class CritRateComponent : IComponent
    {
        public float Value;
    }
}
