using SimpleUi.Abstracts;

namespace Game.Ui.TestUi
{
    public class TestUiController : UiController<TestUiView>,
        IUiInitialize,
        ITestCounterAddedListener
    {
        private readonly GameContext _game;
        
        public TestUiController(GameContext game)
        {
            _game = game;
        }
        
        public void Initialize()
        {
            _game.TestCounterEntity.AddTestCounterAddedListener(this);
        }
        
        public override void OnShow()
        {
            View.titleText.text = "0 cubes touch FinishCollider";
        }

        public void OnTestCounterAdded(GameEntity entity, int value)
        {
            View.titleText.text = $"{value} cubes touch FinishCollider";
        }
    }
}