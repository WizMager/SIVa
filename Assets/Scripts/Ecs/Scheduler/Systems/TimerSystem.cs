using System.Collections.Generic;
using Game.Services.TimeProvider;
using JCMG.EntitasRedux;
using UnityEngine;

namespace Ecs.Scheduler.Systems
{
    public class TimerSystem : ReactiveSystem<SchedulerEntity>
    {
        private readonly ITimeProvider _timeProvider;

        public TimerSystem(SchedulerContext scheduler, ITimeProvider timeProvider) : base(scheduler)
        {
            _timeProvider = timeProvider;
        }

        protected override ICollector<SchedulerEntity> GetTrigger(IContext<SchedulerEntity> context) =>
            context.CreateCollector(SchedulerMatcher.Accumulator);

        protected override bool Filter(SchedulerEntity entity) =>
            entity.HasAccumulator
            && entity.HasTimerSec
            && !entity.IsPaused
            && !entity.IsDestroyed;

        protected override void Execute(List<SchedulerEntity> entities)
        {
            foreach (var action in entities)
            {
                action.Accumulator.Value += _timeProvider.DeltaTime;
                if (action.Accumulator.Value >= action.TimerSec.Value)
                {
                    action.ScheduledAction.Value.Invoke();
                }
            }
                
        }
    }
}