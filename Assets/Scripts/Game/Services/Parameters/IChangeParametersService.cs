using Ecs.Extensions.UidGenerator;
using Ecs.Utils.Parameters;

namespace Game.Services.Parameters
{
    public interface IChangeParametersService
    {
        void ChangePlayerParameter(EParameters characteristics, float parameter);
        void ChangeTargetParameter(Uid targetUid, EParameters characteristic, float changeParameter);
    }
}
