using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Views.Impl
{
    public class PlayerView : ObjectView,
        IPositionAddedListener,
        IRotationAddedListener
    {
        [SerializeField] private CharacterController characterController;
        [SerializeField] private GameObject playerBody;
        
        public override void Link(IEntity entity, IContext context)
        {
            var self = (GameEntity) entity;
            self.AddPositionAddedListener(this);
            self.AddRotationAddedListener(this);
            
            base.Link(entity, context);
        }

        public void OnPositionAdded(GameEntity entity, Vector3 value)
        {
            characterController.Move(value);
        }

        public void OnRotationAdded(GameEntity entity, Quaternion value)
        {
            playerBody.transform.rotation = value;
        }
    }
}