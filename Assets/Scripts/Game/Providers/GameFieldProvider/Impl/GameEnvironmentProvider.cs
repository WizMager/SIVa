using Game.Utils;

namespace Game.Providers.GameFieldProvider.Impl
{
    public class GameEnvironmentProvider : IGameEnvironmentProvider
    {
        public GameEnvironment GameEnvironment { get; }
        
        public GameEnvironmentProvider(GameEnvironment gameEnvironment)
        {
            GameEnvironment = gameEnvironment;
        }
    }
}