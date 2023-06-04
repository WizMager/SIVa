using Ecs.Extensions.UidGenerator;
using Ecs.Views.Impl;
using UnityEngine;

namespace Ecs.Game.Extensions
{
    public static class GameExtension
    {
        public static GameEntity CreatePlayer(this GameContext context, PlayerView playerView, Transform spawnPoint)
        {
            var playerEntity = context.CreateEntity();
            playerEntity.AddUid(UidGenerator.Next());
            playerEntity.AddPosition(spawnPoint.position);
            playerEntity.AddRotation(spawnPoint.rotation);
            playerEntity.IsPlayer = true;
            
            playerView.Link(playerEntity, context);

            return playerEntity;
        }

        public static GameEntity CreateCamera(this GameContext context, CameraView cameraView, Transform spawnPoint)
        {
            var cameraEntity = context.CreateEntity();
            cameraEntity.AddUid(UidGenerator.Next());
            cameraEntity.AddPosition(spawnPoint.position);
            cameraEntity.AddRotation(spawnPoint.rotation);
            cameraEntity.IsCamera = true;
            
            cameraView.Link(cameraEntity, context);

            return cameraEntity;
        }
    }
}