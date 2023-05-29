using JCMG.EntitasRedux;
using UnityEngine;
using Zenject;

namespace Ecs.Views.Impl
{
    public class TestView : ObjectView,
        ITestFloatAddedListener
    {
        private GameEntity _self;

        [Inject] private ActionContext _action;

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
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.name != "TestFinishCollider") return;

            _action.CreateEntity().AddTestCollide(_self.Uid.Value);
        }
    }
}