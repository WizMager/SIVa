using System;
using CleverCrow.Fluid.BTs.Tasks;
using CleverCrow.Fluid.BTs.Tasks.Actions;
using Game.Services.TimeProvider;

namespace Game.Models.Ai.Utils.Tasks.WaitTime
{
	public class WaitCustomTimeWithProvider : ActionBase
	{
		private readonly ITimeProvider _timeProvider;
		private float _endTime;

		public Func<float> DelayFunc;
		public Action ContinueLogic;

		public override string IconPath { get; } = $"{PACKAGE_ROOT}/Hourglass.png";

		public WaitCustomTimeWithProvider(ITimeProvider timeProvider)
		{
			_timeProvider = timeProvider;
		}

		protected override void OnStart()
		{
			_endTime = _timeProvider.DeltaTime + DelayFunc();
		}

		protected override TaskStatus OnUpdate()
		{
			if (_endTime < _timeProvider.DeltaTime)
				return TaskStatus.Success;
			ContinueLogic?.Invoke();
			return TaskStatus.Continue;
		}
	}
}