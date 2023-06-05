using Ecs.Game.Extensions;
using Ecs.Views.Impl;
using Game.Db.PrefabBase;
using Game.Models.Camera;
using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Game.Systems.Initialize
{
    public class CameraInitializeSystem : IInitializeSystem
    {
        private readonly GameContext _game;
        private readonly ICameraHolder _cameraHolder;
        private readonly DiContainer _diContainer;
        private readonly IPrefabBase _prefabBase;

        public CameraInitializeSystem(
            GameContext game,
            ICameraHolder cameraHolder,
            DiContainer diContainer,
            IPrefabBase prefabBase
            )
        {
            _game = game;
            _cameraHolder = cameraHolder;
            _diContainer = diContainer;
            _prefabBase = prefabBase;
        }
        
        public void Initialize()
        {
            CreateCameras();
            
            var playerTransform = _game.PlayerEntity.Transform.Value;
            
            _cameraHolder.Follow = playerTransform;
            _cameraHolder.LookAt = playerTransform;

            _cameraHolder.DeactivateAllCameras();
            
            _cameraHolder.SetActiveCamera(ECameraType.Default);
        }

        private void CreateCameras()
        {
            var cameraView = Object.Instantiate(_prefabBase.GetPrefabWithName("MainCamera"))
                .GetComponent<CameraView>();
            _diContainer.Inject(cameraView);

            var virtualCameraView = Object.Instantiate(_prefabBase.GetPrefabWithName("VirtualCamera"))
                .GetComponent<VirtualCameraView>();
            _diContainer.Inject(virtualCameraView);
            
            _game.CreateCamera(cameraView);
            _game.CreateVirtualCamera(virtualCameraView);
        }
    }
}