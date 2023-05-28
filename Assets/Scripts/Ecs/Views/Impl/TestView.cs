using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Views.Impl
{
    public class TestView : ObjectView,
        ITestFloatAddedListener
    {
        private GameEntity _self;

        public override void Link(IEntity entity, IContext context)
        {
            _self = (GameEntity) entity;
            
            _self.AddTestFloatAddedListener(this);
            
            base.Link(entity, context);
        }

        public void OnTestFloatAdded(GameEntity entity, float value)
        {
            transform.position = Vector3.forward * value;
        }
    }
}