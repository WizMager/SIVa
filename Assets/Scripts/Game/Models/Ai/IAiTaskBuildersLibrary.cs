namespace Game.Models.Ai
{
	public interface IAiTaskBuildersLibrary
	{
		ITaskBuilder Get(string name);
	}
}