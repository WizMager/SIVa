using UnityEngine;

namespace Game.Services.RandomProvider.Impl
{
    public class RandomProvider : IRandomProvider
    {
        public float Value => Random.value;
        
        public int Range(int min, int max) => Random.Range(min, max);
        public float Range(float min, float max) => Random.Range(min, max);
    }
}