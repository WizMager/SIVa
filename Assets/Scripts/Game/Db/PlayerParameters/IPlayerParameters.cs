using Assets.Scripts.Game.Utils;

namespace Game.Db.PlayerParameters
{
    public interface IPlayerParameters
    {
        public UnitParameters GetParametersByType(EUnitClass eUnitClass);
    }
}