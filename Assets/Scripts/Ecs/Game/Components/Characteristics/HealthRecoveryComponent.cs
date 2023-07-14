using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class HealthRecoveryComponent : IComponent
    {
        public float Value;
    }
}
