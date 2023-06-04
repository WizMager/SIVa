using UnityEngine;

namespace Game.Services.InputService
{
    public interface IInputService
    {
        Vector3 MovementInput { get; }
        Vector3 LookInput { get; }

        void Enable();
        void Disable();
    }
}