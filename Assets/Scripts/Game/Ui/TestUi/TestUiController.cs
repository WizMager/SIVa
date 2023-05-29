using Ecs.Scheduler.Extensions;
using Scheduler.Services.EcsTimerSequence;
using SimpleUi.Abstracts;
using UnityEngine;
using Zenject;

namespace Game.Ui.TestUi
{
    public class TestUiController : UiController<TestUiView>,
        IInitializable,
        ITestCounterAddedListener
    {
        private readonly GameContext _game;
        private readonly SchedulerContext _scheduler;
        
        public TestUiController(
            GameContext game,
            SchedulerContext scheduler)
        {
            _game = game;
            _scheduler = scheduler;
        }
        
        public void Initialize()
        {
            _scheduler.CreateTimerAction(() =>
            {
                _game.TestCounterEntity.AddTestCounterAddedListener(this);
                Debug.LogError(_game.TestCounter.Value);
            }, 0.1f);
            
            //sequencer dont created in zenject initialize method
            // EcsTimerSequence.Create()
            //     .Append(() =>
            //     {
            //         _game.TestCounterEntity.AddTestCounterAddedListener(this);
            //         Debug.LogError(_game.TestCounter.Value);
            //     }, 0.1f);
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