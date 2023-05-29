using Game.Utils;

namespace Game.Providers.GameFieldProvider
{
    public interface IGameEnvironmentProvider
    {
        public GameEnvironment GameEnvironment { get; }
    }
}