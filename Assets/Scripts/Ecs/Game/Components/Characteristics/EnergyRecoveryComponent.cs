using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class EnergyRecoveryComponent : IComponent
    {
        public float Value;
    }
}
