using Game.Utils.Animations;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Views.Impl
{
    public class PlayerView : ObjectView,
        IPositionAddedListener,
        IRotationAddedListener,
        IMoveInputAddedListener
    {
        [SerializeField] private CharacterController characterController;
        [SerializeField] private GameObject playerBody;
        [SerializeField] private Animator playerAnimator;
        
        public override void Link(IEntity entity, IContext context)
        {
            var self = (GameEntity) entity;
            self.AddPositionAddedListener(this);
            self.AddRotationAddedListener(this);
            self.AddMoveInputAddedListener(this);
            
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
        public void OnMoveInputAdded(GameEntity entity, Vector3 value)
        {
            var rotation = playerBody.transform.rotation.y;

            if (rotation >= -0.25 && rotation <= 0.25)
            {
                playerAnimator.SetFloat(AnimationKeys.HorizontalMove, value.x);
                playerAnimator.SetFloat(AnimationKeys.VerticalMove, value.z);
            }
            else if (rotation >= 0.75 || rotation <= -0.75)
            {
                playerAnimator.SetFloat(AnimationKeys.HorizontalMove, -value.x);
                playerAnimator.SetFloat(AnimationKeys.VerticalMove, -value.z);
            }

            if (rotation > 0.25 && rotation < 0.75)
            {
                playerAnimator.SetFloat(AnimationKeys.HorizontalMove, -value.z);
                playerAnimator.SetFloat(AnimationKeys.VerticalMove, value.x);
            }
            else if (rotation > -0.75 && rotation < -0.25)
            {
                playerAnimator.SetFloat(AnimationKeys.HorizontalMove, value.z);
                playerAnimator.SetFloat(AnimationKeys.VerticalMove, -value.x);
            }
        }
       
    }
}