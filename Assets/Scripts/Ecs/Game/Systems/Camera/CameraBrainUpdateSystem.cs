using Core.Systems;
using Game.Models.Camera;

namespace Ecs.Game.Systems.Camera
{
    public class CameraBrainUpdateSystem : ILateSystem
    {
        private readonly ICameraHolder _cameraHolder;

        public CameraBrainUpdateSystem(ICameraHolder cameraHolder)
        {
            _cameraHolder = cameraHolder;
        }
        
        public void Late()
        {
            _cameraHolder.Update();
        }
    }
}