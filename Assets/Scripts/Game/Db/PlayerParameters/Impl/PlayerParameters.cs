using Assets.Scripts.Game.Db.PlayerParameters;
using Assets.Scripts.Game.Utils;
using System;
using UnityEngine;

namespace Game.Db.PlayerParameters.Impl
{
    [CreateAssetMenu(menuName = "Settings/PlayerParameters", fileName = "PlayerParameters")]
    public class PlayerParameters : ScriptableObject, IPlayerParameters
    {
        [SerializeField] private UnitParameters[] unitParameters;

        public UnitParameters GetParametersByType(UnitClass unitClass)
        {
            foreach (var item in unitParameters)
            {
                if (item.unitClass != unitClass) continue;
                return item;                
            }
            throw new Exception($"{nameof(PlayerParameters)}; there is no parameters with UnitClass {unitClass} ");
        }        
    }
}