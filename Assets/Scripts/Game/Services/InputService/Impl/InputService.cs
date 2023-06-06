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
        private readonly GameContext _game;

        private Vector2 _previousMousePosition;

        public Vector3 MovementInput { get; private set; }
        public Vector2 ScreenMousePosition { get; private set; }

        public InputService(
            Controls controls,
            ActionContext action,
            GameContext game
            )
        {
            _controls = controls;
            _action = action;
            _game = game;
            
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
            var keyboardAndMouse = _controls.KeyboardAndMouse;
            
            var movementInput = keyboardAndMouse.Movement.ReadValue<Vector2>();
            MovementInput = new Vector3(movementInput.x, 0, movementInput.y);

            var mousePosition = keyboardAndMouse.MousePosition.ReadValue<Vector2>();
            
            if (_previousMousePosition != mousePosition)
            {
                ScreenMousePosition = mousePosition;

                _game.CreateEntity().IsMouseMove = true;
                _previousMousePosition = mousePosition;
            }
            
        }

        public void Dispose()
        {
            _controls.KeyboardAndMouse.Movement.started -= OnMovementStart;
            _controls.KeyboardAndMouse.Movement.canceled -= OnMovementCancel;
        }
    }
}