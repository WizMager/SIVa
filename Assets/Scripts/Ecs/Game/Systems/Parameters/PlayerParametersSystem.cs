namespace Assets.Scripts.Ecs.Game.Systems.Parameters
{
    public class PlayerParametersSystem // this for ... what?
    {
        private readonly GameContext _game;

        public PlayerParametersSystem(
            GameContext gameContext)
        {
            _game = gameContext;
        }

        public void PlayerParameters()
        {
            var player = _game.PlayerEntity;

        }
    }
}
