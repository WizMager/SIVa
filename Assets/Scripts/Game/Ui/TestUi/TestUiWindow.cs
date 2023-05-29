using SimpleUi;

namespace Game.Ui.TestUi
{
    public class TestUiWindow : WindowBase
    {
        public override string Name => "TestWindow";
        
        protected override void AddControllers()
        {
            AddController<TestUiController>();
        }
    }
}