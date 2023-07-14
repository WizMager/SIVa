using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class ArmorComponent : IComponent
    {
        public float Value;
    }
}
