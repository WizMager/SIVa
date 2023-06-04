using UnityEngine;

namespace Game.Utils
{
    public class GameEnvironment : MonoBehaviour
    {
        [SerializeField] private Transform playerSpawnPoint;

        public Transform PlayerSpawnPoint => playerSpawnPoint;
    }
}