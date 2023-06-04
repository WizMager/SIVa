using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Views.Impl
{
    public class CameraView : ObjectView,
        IPositionAddedListener,
        IRotationAddedListener
    {
        [SerializeField] private Vector3 cameraOffset;

        public Vector3 CameraOffset => cameraOffset;

        public override void Link(IEntity entity, IContext context)
        {
            var self = (GameEntity) entity;
            
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