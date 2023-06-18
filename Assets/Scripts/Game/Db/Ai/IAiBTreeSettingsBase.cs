using System.Collections.Generic;

namespace Game.Db.Ai
{
	public interface IAiBTreeSettingsBase
	{
		List<BTreeRootTask> Get(EEnemyType enemyType);
	}
}