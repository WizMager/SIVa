using System;
using CleverCrow.Fluid.BTs.Tasks;
using CleverCrow.Fluid.BTs.Tasks.Actions;
using Game.Services.TimeProvider;

namespace Game.Models.Ai.Utils.Tasks.WaitTime
{
	public class WaitTimeWithProvider : ActionBase
	{
		private readonly ITimeProvider _timeProvider;
		private float _endTime;

		public float Delay = 1;
		public Action StartLogic;
		public Action ContinueLogic;

		public override string IconPath { get; } = $"{PACKAGE_ROOT}/Hourglass.png";

		public WaitTimeWithProvider(ITimeProvider timeProvider)
		{
			_timeProvider = timeProvider;
		}

		protected override void OnStart()
		{
			_endTime = _timeProvider.DeltaTime + Delay;
			StartLogic?.Invoke();
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