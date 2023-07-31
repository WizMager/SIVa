using JCMG.EntitasRedux;

namespace Assets.Scripts.Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class UltimateEnergyComponent : IComponent
    {
        public float MaxValue;
        public float CurrentValue;
    }
}
