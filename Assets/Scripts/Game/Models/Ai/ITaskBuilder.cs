using System.Collections.Generic;
using CleverCrow.Fluid.BTs.Trees;

namespace Game.Models.Ai
{
	public interface ITaskBuilder
	{
		string Name { get; }

		void Fill(BehaviorTreeBuilder builder, GameEntity entity, Dictionary<string, object> taskValues);

		void End(BehaviorTreeBuilder builder);
	}
}