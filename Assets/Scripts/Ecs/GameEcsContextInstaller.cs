using Core.Systems;
using Core.Systems.Impl;
using Ecs.Extensions;

namespace Ecs
{
    public class GameEcsContextInstaller : AEcsContextInstaller
    {
        protected override void BindContexts()
        {
            BindContext<GameContext>();
            
            Container.BindDestroyedCleanup<GameContext, GameEntity>(GameMatcher.Destroyed);
            
            BindEventSystem<GameEventSystems>();

            var mainFeature = new GameFeature();
            Container.Bind<GameFeature>().FromInstance(mainFeature).WhenInjectedInto<Bootstrap>();
        }
    }
}