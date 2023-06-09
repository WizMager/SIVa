﻿using Game.Services.TimeProvider;
using JCMG.EntitasRedux;
using Zenject;

namespace Ecs.Scheduler.Systems
{
    public class IntervalAccumulatorSystem : IUpdateSystem
    {
        private static readonly ListPool<SchedulerEntity> SchedulerEntityListPool = ListPool<SchedulerEntity>.Instance;

        private readonly IGroup<SchedulerEntity> _actionGroup;
        private readonly ITimeProvider _timeProvider;

        public IntervalAccumulatorSystem(SchedulerContext scheduler, ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
            _actionGroup = scheduler.GetGroup(SchedulerMatcher.AllOf(SchedulerMatcher.ScheduledAction,
                    SchedulerMatcher.IntervalAccumulator)
                .AnyOf(SchedulerMatcher.IntervalSec, SchedulerMatcher.TimerSec)
                .NoneOf(SchedulerMatcher.Paused, SchedulerMatcher.Destroyed));
        }

        public void Update()
        {
            var buffer = SchedulerEntityListPool.Spawn();
            _actionGroup.GetEntities(buffer);
            foreach (var action in buffer)
                action.ReplaceIntervalAccumulator(action.IntervalAccumulator.Value + _timeProvider.DeltaTime);

            SchedulerEntityListPool.Despawn(buffer);
        }
    }
}