using Core.LoadingProcessor.Impls;
using Core.SceneLoading;
using Core.SceneLoading.Impls;
using Zenject;

namespace Installers.Project
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<LoadingProcessor>().AsSingle();
            Container.Bind<ISceneLoadingManager>().To<SceneLoadingManager>().AsSingle();
            SignalBusInstaller.Install(Container);

            Bind();
            BindProjectWindows();
        }
        
        private void Bind()
        {
            
        }
        
        private void BindProjectWindows()
        {
            
        }
    }
}