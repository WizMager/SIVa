using CleverCrow.Fluid.BTs.Trees;
using Zenject;

namespace Game.Models.Ai
{
	public interface IBehaviourTreeFactory : IFactory<GameEntity, IBehaviorTree>
	{
	}
}