using CleverCrow.Fluid.BTs.Tasks;
using CleverCrow.Fluid.BTs.Tasks.Actions;
using Ecs.Extensions.UidGenerator;
using Game.Services.TimeProvider;

namespace Game.Models.Ai.Utils.Tasks.WaitTime
{
    public class WaitTimeWithTimeScale : ActionBase
    {
        private readonly ITimeProvider _timeMonitor;
        private readonly GameContext _game;

        private float _timePassed;

        public float Delay = 1;
        public Uid? TimeScaleTarget;

        public override string IconPath { get; } = $"{PACKAGE_ROOT}/Hourglass.png";

        public WaitTimeWithTimeScale(ITimeProvider timeProvider, GameContext game)
        {
            _timeMonitor = timeProvider;
            _game = game;
        }

        protected override void OnStart()
        {
            _timePassed = 0;
        }

        protected override TaskStatus OnUpdate()
        {
            var timeScale = 1f;

            _timePassed += _timeMonitor.DeltaTime * timeScale;

            if (_timePassed < Delay)
            {
                return TaskStatus.Continue;
            }

            return TaskStatus.Success;
        }
    }
}