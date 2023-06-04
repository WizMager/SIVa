using UnityEngine;

namespace Game.Db.PlayerParameters.Impl
{
    [CreateAssetMenu(menuName = "Settings/PlayerParameters", fileName = "PlayerParameters")]
    public class PlayerParameters : ScriptableObject, IPlayerParameters
    {
        [SerializeField] private float moveSpeed;

        public float MoveSpeed => moveSpeed;
    }
}