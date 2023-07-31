using Assets.Scripts.Ecs.Utils;
using Ecs.Extensions.UidGenerator;
using Ecs.Views;
using JCMG.EntitasRedux;
using System;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Ecs.Views.Impl
{
    public class EnemyView : ObjectView, IDamageable
    {
        public Uid uid;
        [Inject] private ActionContext _action;

        public override void Link(IEntity entity, IContext context)
        {
            var self = (GameEntity) entity;

            uid = self.Uid.Value;

            base.Link(entity, context);
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer.ToString() == "Player")
            {
                other.transform.TryGetComponent(out IDamageable damageable);                
                _action.CreateEntity().AddTakeDamage(true);
            }            
        }

        public Uid GetEnemyUid()
        {
            return uid;
        }
    }
}
