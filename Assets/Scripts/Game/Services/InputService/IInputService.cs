using UnityEngine;

namespace Game.Services.InputService
{
    public interface IInputService
    {
        Vector3 MovementInput { get; }
        Vector2 ScreenMousePosition { get; }

        void Enable();
        void Disable();
    }
}