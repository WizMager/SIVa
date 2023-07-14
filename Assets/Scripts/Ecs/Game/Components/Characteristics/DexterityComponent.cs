using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class DexterityComponent : IComponent
    {
        public float Value;
    }
}
