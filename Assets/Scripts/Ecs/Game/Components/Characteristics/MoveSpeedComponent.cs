using JCMG.EntitasRedux;

namespace Ecs.Game.Components.Characteristics
{
    [Game]
    [Event(EventTarget.Self)]
    public class MoveSpeedComponent : IComponent
    {
        public float Value;
    }
}
