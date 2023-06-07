using System.Collections.Generic;
using Game.Models.Camera;
using Game.Services.InputService;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Game.Systems.Movement
{
    public class RotatePlayerBodySystem : ReactiveSystem<GameEntity>
    {
        private readonly GameContext _game;
        private readonly IInputService _inputService;
        private readonly ICameraHolder _cameraHolder;

        public RotatePlayerBodySystem(
            GameContext context,
            IInputService inputService,
            ICameraHolder cameraHolder
        ) : base(context)
        {
            _game = context;
            _inputService = inputService;
            _cameraHolder = cameraHolder;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.MouseMove);

        protected override bool Filter(GameEntity entity) => entity.IsMouseMove && !entity.IsDestroyed;

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var gameEntity in entities)
            {
                gameEntity.IsDestroyed = true;
                
                var player = _game.PlayerEntity;

                var playerPosition = player.Transform.Value.position;
                playerPosition.y = 0;
                var screenMousePosition = _inputService.ScreenMousePosition;

                var worldMousePosition = _cameraHolder.GetScreenToWorldMousePosition(screenMousePosition);
                worldMousePosition.y = 0;
            
                if (worldMousePosition == Vector3.zero) return;
            
                player.ReplaceRotation(Quaternion.LookRotation(worldMousePosition - playerPosition));
            }
        }
    }
}