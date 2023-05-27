using System;
using UnityEngine;

namespace Game.Db.PrefabBase.Impl
{
    [CreateAssetMenu(fileName = "PrefabBase", menuName = "Settings/PrefabBase")]
    public class PrefabBase : ScriptableObject, IPrefabBase
    {
        [SerializeField] private GameObject[] prefabs;
        
        public GameObject GetPrefabWithName(string prefabName)
        {
            foreach (var prefab in prefabs)
            {
                if (prefab.name != prefabName) continue;

                return prefab;
            }

            throw new Exception($"[{nameof(PrefabBase)}]: There is no prefabs with name {prefabName}!");
        }
    }
}