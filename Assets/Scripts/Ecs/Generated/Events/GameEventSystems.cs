//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.7.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameEventSystems : Feature
{
	public GameEventSystems(Contexts contexts)
	{
		Add(new GameDestroyedAddedEventSystem(contexts)); // priority: 0
		Add(new LinkRemovedEventSystem(contexts)); // priority: 0
		Add(new TestCounterAddedEventSystem(contexts)); // priority: 0
		Add(new TestCounterRemovedEventSystem(contexts)); // priority: 0
		Add(new TestFloatAddedEventSystem(contexts)); // priority: 0
	}
}
