using JCMG.EntitasRedux;

namespace Core.Systems
{
    public interface ILateSystem : ISystem
    {
        void Late();
    }
}