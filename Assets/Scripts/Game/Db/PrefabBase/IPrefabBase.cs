using UnityEngine;

namespace Game.Db.PrefabBase
{
    public interface IPrefabBase
    {
        GameObject GetPrefabWithName(string prefabName);
    }
}