using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace Ecs.Scheduler.Systems
{
    public class IntervalSystem : ReactiveSystem<SchedulerEntity>
    {
        public IntervalSystem(SchedulerContext scheduler) : base(scheduler)
        {
        }

        protected override ICollector<SchedulerEntity> GetTrigger(IContext<SchedulerEntity> context) =>
            context.CreateCollector(SchedulerMatcher.IntervalAccumulator);

        protected override bool Filter(SchedulerEntity entity) =>
            entity.HasIntervalAccumulator
            && entity.HasIntervalSec
            && !entity.IsPaused
            && !entity.IsDestroyed;

        protected override void Execute(List<SchedulerEntity> entities)
        {
            foreach (var action in entities)
                if (action.IntervalAccumulator.Value >= action.IntervalSec.Value)
                {
                    action.IntervalAccumulator.Value -= action.IntervalSec.Value;
                    action.ScheduledAction.Value.Invoke();
                }
        }
    }
}