using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class CreteRateComponent : IComponent
    {
        public float Value;
    }
}
