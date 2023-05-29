using Core.Systems.Impl;
using JCMG.EntitasRedux;
using Zenject;

namespace Installers.Ecs
{
    public abstract class AEcsContextInstaller : MonoInstaller
    {
        private Contexts _contexts;
        
        public override void InstallBindings()
        {
            _contexts = Contexts.SharedInstance;
            Container.BindInstance(_contexts).WhenInjectedInto<Bootstrap>();
            Container.BindInterfacesTo<Bootstrap>().AsSingle().NonLazy();
            
            BindContexts();
        }

        protected abstract void BindContexts();

        protected void BindContext<T>() where T : IContext
        {
            foreach (var ctx in _contexts.AllContexts)
            {
                if (ctx is T context)
                {
                    Container.BindInterfacesAndSelfTo<T>().FromInstance(context).AsSingle();
                }
            }
        }
        
        protected void BindEventSystem<TEventSystem>()
            where TEventSystem : Feature
        {
            Container.BindInterfacesTo<TEventSystem>().AsSingle().WithArguments(_contexts);
        }
    }
}