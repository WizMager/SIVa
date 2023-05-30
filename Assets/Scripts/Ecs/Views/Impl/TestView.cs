using JCMG.EntitasRedux;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using Zenject;

namespace Ecs.Views.Impl
{
    public class TestView : ObjectView,
        ITestFloatAddedListener
    {
        [SerializeField] private Collider testViewCollider;
        
        private GameEntity _self;

        [Inject] private ActionContext _action;

        public override void Link(IEntity entity, IContext context)
        {
            _self = (GameEntity) entity;
            
            _self.AddTestFloatAddedListener(this);
            
            base.Link(entity, context);

            testViewCollider.OnTriggerEnterAsObservable().Subscribe(OnTriggerEnterObservable).AddTo(testViewCollider);
        }

        public void OnTestFloatAdded(GameEntity entity, float value)
        {
            transform.position = Vector3.forward * value;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            return;
            
            if (other.name != "TestFinishCollider") return;

            _action.CreateEntity().AddTestCollide(_self.Uid.Value);
        }
        
        private void OnTriggerEnterObservable(Collider other)
        {
            if (other.name != "TestFinishCollider") return;

            _action.CreateEntity().AddTestCollide(_self.Uid.Value);
        }
    }
}