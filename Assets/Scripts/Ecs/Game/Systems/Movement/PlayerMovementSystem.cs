using Game.Services.InputService;
using Game.Services.TimeProvider;
using JCMG.EntitasRedux;

namespace Ecs.Game.Systems.Movement
{
    public class PlayerMovementSystem : IUpdateSystem
    {
        private readonly GameContext _game;
        private readonly IInputService _inputService;
        private readonly ITimeProvider _timeProvider;

        public PlayerMovementSystem(
            GameContext game,
            IInputService inputService,
            ITimeProvider timeProvider
            )
        {
            _game = game;
            _inputService = inputService;
            _timeProvider = timeProvider;
        }
        
        public void Update()
        {
            var player = _game.PlayerEntity;

            if (!player.IsMove) return;

            var movementInput = _inputService.MovementInput;
            var currentInput = player.MoveInput.Value;

            if (currentInput != movementInput)
            {
                player.ReplaceMoveInput(movementInput);
            }
            
            var changePosition = _inputService.MovementInput * _timeProvider.DeltaTime * player.MoveSpeed.Value;
            
            player.ReplacePosition(changePosition);
        }
    }
}