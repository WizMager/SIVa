using System;
using JCMG.EntitasRedux;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Services.InputService.Impl
{
    public class InputService : IInputService,
        IInitializeSystem, 
        IUpdateSystem,
        IDisposable
    {
        private readonly Controls _controls;
        private readonly ActionContext _action;
        
        public Vector3 MovementInput { get; private set; }
        public Vector3 LookInput { get; private set; }

        public InputService(
            Controls controls,
            ActionContext action
            )
        {
            _controls = controls;
            _action = action;
            
            Enable();
        }
        
        public void Initialize()
        {
            _controls.KeyboardAndMouse.Movement.started += OnMovementStart;
            _controls.KeyboardAndMouse.Movement.canceled += OnMovementCancel;
        }
        
        private void OnMovementStart(InputAction.CallbackContext obj)
        {
            _action.CreateEntity().AddMovementInput(true);
        }

        private void OnMovementCancel(InputAction.CallbackContext obj)
        {
            _action.CreateEntity().AddMovementInput(false);
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
            var movementInput = _controls.KeyboardAndMouse.Movement.ReadValue<Vector2>();
            var lookInput = _controls.KeyboardAndMouse.Look.ReadValue<Vector2>();

            MovementInput = new Vector3(movementInput.x, 0, movementInput.y);
        }

        public void Dispose()
        {
            _controls.KeyboardAndMouse.Movement.started -= OnMovementStart;
            _controls.KeyboardAndMouse.Movement.canceled -= OnMovementCancel;
        }
    }
}