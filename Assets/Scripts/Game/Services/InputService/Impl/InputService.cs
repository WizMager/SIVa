using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Game.Services.InputService.Impl
{
    public class InputService : IInputService,
        IInitializeSystem, 
        IUpdateSystem,
        IDisposable
    {
        private readonly Controls _controls;
        
        public Vector3 InputVector { get; private set; }

        public InputService(Controls controls)
        {
            _controls = controls;
            Enable();
        }
        
        public void Initialize()
        {
            
        }

        public void Enable()
        {
            _controls.Enable();
        }

        public void Disable()
        {
            _controls.Disable();
        }
        
        public void Update()
        {
            var input = _controls.KeyboardAndMouse.Movement.ReadValue<Vector2>();

            InputVector = new Vector3(input.x, 0, input.y);
        }

        public void Dispose()
        {
            
        }
    }
}