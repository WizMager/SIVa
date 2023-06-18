using CleverCrow.Fluid.BTs.Trees;

namespace Game.Models.Ai.Tasks.Default.TaskParents
{
	public abstract class ATaskParentBuilder : ATaskBuilder
	{
		public override void End(BehaviorTreeBuilder builder)
			=> builder.End();
	}
}