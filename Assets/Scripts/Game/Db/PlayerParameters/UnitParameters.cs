using Assets.Scripts.Game.Utils;
using System;

namespace Assets.Scripts.Game.Db.PlayerParameters
{
    [Serializable]
    public class UnitParameters
    {
        public float Armor;
        public float CreteRate;
        public float Dexterity;
        public float EnergyRecovery;
        public float HealthRecovery;
        public float Power;
        public float Speed;
        public float Wisdom;

        public UnitClass unitClass;
    }
}
