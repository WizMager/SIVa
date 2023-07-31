using System;
using Ecs.Utils.Parameters;

namespace Game.Db.PlayerParameters.Vo
{
    [Serializable]
    public class ParameterVo
    {
        public EParameters parameter;
        public float value;
    }
}