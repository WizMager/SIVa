using System.Collections.Generic;
using Ecs.Scheduler.Extensions;
using Game.Ui.TestUi;
using JCMG.EntitasRedux;
using Scheduler.Services.EcsTimerSequence;
using SimpleUi.Signals;
using UnityEngine;
using Zenject;

namespace Ecs.Action.Systems
{
    public class TestCollideSystem : ReactiveSystem<ActionEntity>
    {
        private readonly GameContext _game;
        private readonly SchedulerContext _scheduler;
        private readonly SignalBus _signalBus;
        
        public TestCollideSystem(
            ActionContext context,
            GameContext game,
            SchedulerContext scheduler
            ) : base(context)
        {
            _game = game;
            _scheduler = scheduler;
        }

        protected override ICollector<ActionEntity> GetTrigger(IContext<ActionEntity> context) =>
            context.CreateCollector(ActionMatcher.TestCollide);

        protected override bool Filter(ActionEntity entity) => entity.HasTestCollide && !entity.IsDestroyed;

        protected override void Execute(List<ActionEntity> entities)
        {
            foreach (var actionEntity in entities)
            {
                actionEntity.IsDestroyed = true;

                var entity = _game.GetEntityWithUid(actionEntity.TestCollide.TargetUid);

                EcsTimerSequence.Create()
                    .Append(() =>
                    {
                        entity.RemoveTestFloat();
                        Debug.Log("Remove TestFloatComponent");

                        var counter = _game.TestCounter.Value;
                        Debug.Log(counter);
                        _game.ReplaceTestCounter(counter + 1);
                    }, 2f)
                    .Run();
                
                //alternative but better use time sequencer
                // _scheduler.CreateTimerAction(() =>
                // {
                //     entity.RemoveTestFloat();
                // }, 2f);
            }
        }
    }
}