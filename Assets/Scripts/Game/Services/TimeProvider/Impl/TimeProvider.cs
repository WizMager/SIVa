using JCMG.EntitasRedux;
using UnityEngine;

namespace Game.Services.TimeProvider.Impl
{
    public class TimeProvider : ITimeProvider, IUpdateSystem
    {
        public float DeltaTime { get; private set; }
        
        public void Update()
        {
            DeltaTime = Time.deltaTime;
        }
    }
}