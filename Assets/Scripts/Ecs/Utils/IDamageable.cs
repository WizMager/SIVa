using Ecs.Extensions.UidGenerator;

namespace Assets.Scripts.Ecs.Utils
{
    public interface IDamageable
    {
        public Uid GetEnemyUid();
    }
}
