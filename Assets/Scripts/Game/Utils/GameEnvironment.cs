using System.Collections.Generic;
using UnityEngine;

namespace Game.Utils
{
    public class GameEnvironment : MonoBehaviour
    {
        [SerializeField] private Transform spawnPoint;

        public Transform SpawnPoint => spawnPoint;
    }
}