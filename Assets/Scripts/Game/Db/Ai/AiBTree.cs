using System.Collections.Generic;

namespace Game.Db.Ai
{
	public class AiBTree
	{
		public readonly EEnemyType EnemyType;
		public readonly List<BTreeRootTask> RootTasks = new List<BTreeRootTask>();

		public AiBTree(EEnemyType enemyType)
		{
			EnemyType = enemyType;
		}
	}
}