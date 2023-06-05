using Cinemachine;
using Game.Models.Camera.Impl;
using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Views.Impl
{
    public class CameraView : ObjectView,
        IPositionAddedListener,
        IRotationAddedListener
    {
        [SerializeField] private Camera mainCamera;
        [SerializeField] private CinemachineBrain cinemachineBrain;

        [Inject] private CameraHolder _cameraHolder;

        public override void Link(IEntity entity, IContext context)
        {
            var self = (GameEntity) entity;
            
            _cameraHolder.Camera = mainCamera;
            _cameraHolder.SetBrain(cinemachineBrain);
            
            self.AddPositionAddedListener(this);
            self.AddRotationAddedListener(this);
            
            base.Link(entity, context);
        }

        public void OnPositionAdded(GameEntity entity, Vector3 value)
        {
            transform.position = value;
        }

        public void OnRotationAdded(GameEntity entity, Quaternion value)
        {
            transform.rotation = value;
        }
    }
}