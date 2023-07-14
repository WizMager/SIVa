using Ecs.Extensions.UidGenerator;
using Ecs.Utils.Characteristics;

namespace Game.Services.Parameters
{
    public interface IChangeParametersService
    {
        void ChangePlayerParameter(EParameters characteristics, float parameter);
        void ChangeTargetParameter(Uid targetUid, EParameters characteristic, float changeParameter);
    }
}
