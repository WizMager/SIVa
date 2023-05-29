using Core.SceneLoading;
using Zenject;

namespace Game.Project.Managers
{
    public class SplashManager : IInitializable
    {
        private readonly ISceneLoadingManager _sceneLoadingManager;

        public SplashManager(ISceneLoadingManager sceneLoadingManager)
        {
            _sceneLoadingManager = sceneLoadingManager;
        }
        
        public void Initialize()
        {
            _sceneLoadingManager.LoadGameFromSplash();
        }
    }
}