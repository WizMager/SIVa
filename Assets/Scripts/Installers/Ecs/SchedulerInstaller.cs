using Ecs.Scheduler.Systems;
using Zenject;

namespace Installers.Ecs
{
    public class SchedulerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ExecuteScheduledActionSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<IntervalAccumulatorSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<IntervalSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<TimerSystem>().AsSingle();
            Container.BindInterfacesAndSelfTo<ElapsedSystem>().AsSingle();
        }
    }
}