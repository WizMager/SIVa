using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace Ecs.Scheduler.Systems
{
    public class ElapsedSystem : ReactiveSystem<SchedulerEntity>
    {
        public ElapsedSystem(SchedulerContext scheduler) : base(scheduler)
        {
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
                if (action.Accumulator.Value >= action.TimerSec.Value)
                    action.IsDestroyed = true;
        }
    }
}