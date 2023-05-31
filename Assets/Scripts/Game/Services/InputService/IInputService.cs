using UnityEngine;

namespace Game.Services.InputService
{
    public interface IInputService
    {
        Vector3 InputVector { get; }

        void Enable();
        void Disable();
    }
}