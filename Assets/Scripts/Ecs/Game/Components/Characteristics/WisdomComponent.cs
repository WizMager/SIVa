using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class WisdomComponent : IComponent
    {
        public float Value;
    }
}
