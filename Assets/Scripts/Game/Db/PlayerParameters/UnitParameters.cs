using System;
using Assets.Scripts.Game.Utils;
using Game.Db.PlayerParameters.Vo;

namespace Game.Db.PlayerParameters
{
    [Serializable]
    public class UnitParameters
    {
        public ParameterVo[] parameters;

        public EUnitClass eUnitClass;
    }
}
