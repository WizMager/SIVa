using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Game.Components.Movement
{
    [Game]
    [Event(EventTarget.Self)]
    public class MoveInputComponent : IComponent
    {
        public Vector3 Value;
    }
}