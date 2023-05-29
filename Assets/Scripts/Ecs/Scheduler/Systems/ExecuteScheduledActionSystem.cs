using Game.Services.TimeProvider;
using JCMG.EntitasRedux;
using Zenject;

namespace Ecs.Scheduler.Systems
{
    public class ExecuteScheduledActionSystem : IUpdateSystem
    {
        private static readonly ListPool<SchedulerEntity> SchedulerEntityListPool = ListPool<SchedulerEntity>.Instance;

        private readonly IGroup<SchedulerEntity> _actionGroup;
        private readonly ITimeProvider _timeProvider;
        private readonly GameContext _game;

        public ExecuteScheduledActionSystem(
            SchedulerContext scheduler,
            ITimeProvider timeProvider,
            GameContext game
        )
        {
            _timeProvider = timeProvider;
            _game = game;
            _actionGroup = scheduler.GetGroup(SchedulerMatcher
                .AllOf(SchedulerMatcher.ScheduledAction, SchedulerMatcher.Accumulator)
                .AnyOf(SchedulerMatcher.IntervalSec, SchedulerMatcher.TimerSec)
                .NoneOf(SchedulerMatcher.Paused, SchedulerMatcher.Destroyed));
        }

        public void Update()
        {
            var buffer = SchedulerEntityListPool.Spawn();
            _actionGroup.GetEntities(buffer);
            foreach (var action in buffer)
            {
                var timeScale = 1f;
                if (action.HasTimeScaleTarget)
                {
                    var target = _game.GetEntityWithUid(action.TimeScaleTarget.Value);
                    // if (target.HasLocalTimeScale)
                    //     timeScale = target.LocalTimeScale.Value;
                }
                action.ReplaceAccumulator(action.Accumulator.Value + _timeProvider.DeltaTime * timeScale);
            }

            SchedulerEntityListPool.Despawn(buffer);
        }
    }
}