using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Views.Impl
{
    public class TestView : ObjectView,
        ITestFloatAddedListener
    {
        public override void Link(IEntity entity, IContext context)
        {
            var self = (GameEntity) entity;
            
            self.AddTestFloatAddedListener(this);
            
            base.Link(entity, context);
        }

        public void OnTestFloatAdded(GameEntity entity, float value)
        {
            transform.position = Vector3.forward * value; 
        }
    }
}