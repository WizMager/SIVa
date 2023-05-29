using Core.Systems;
using Core.Systems.Impl;
using Ecs.Extensions;

namespace Installers.Ecs
{
    public class GameEcsContextInstaller : AEcsContextInstaller
    {
        protected override void BindContexts()
        {
            BindContext<GameContext>();
            BindContext<ActionContext>();
            BindContext<SchedulerContext>();
            
            Container.BindDestroyedCleanup<GameContext, GameEntity>(GameMatcher.Destroyed);
            Container.BindDestroyedCleanup<ActionContext, ActionEntity>(ActionMatcher.Destroyed);
            Container.BindDestroyedCleanup<SchedulerContext, SchedulerEntity>(SchedulerMatcher.Destroyed);
            
            BindEventSystem<GameEventSystems>();
            BindEventSystem<ActionEventSystems>();
            BindEventSystem<SchedulerEventSystems>();

            var mainFeature = new GameFeature();
            Container.Bind<GameFeature>().FromInstance(mainFeature).WhenInjectedInto<Bootstrap>();
        }
    }
}