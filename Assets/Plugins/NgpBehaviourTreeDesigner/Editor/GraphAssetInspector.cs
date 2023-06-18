using GraphProcessor;
using UnityEditor;
using UnityEngine.UIElements;

namespace Plugins.NgpBehaviourTreeDesigner.Editor
{
	[CustomEditor(typeof(BehaviourTreeGraph), true)]
	public class GraphAssetInspector : GraphInspector
	{
		// protected override void CreateInspector()
		// {
		// }

		protected override void CreateInspector()
		{
			base.CreateInspector();

			root.Add(new Button(() => EditorWindow.GetWindow<BehaviourTreeGraphWindow>().InitializeGraph(target as BaseGraph))
			{
				text = "Open base graph window"
			});
			
			root.Add(new Button(() => EditorWindow.GetWindow<BehaviourTreeGraphWindow1>().InitializeGraph(target as BaseGraph))
			{
				text = "Open base graph window 1"
			});
			
			root.Add(new Button(() => EditorWindow.GetWindow<BehaviourTreeGraphWindow2>().InitializeGraph(target as BaseGraph))
			{
				text = "Open base graph window 2"
			});
			
			root.Add(new Button(() => EditorWindow.GetWindow<BehaviourTreeGraphWindow3>().InitializeGraph(target as BaseGraph))
			{
				text = "Open base graph window 3"
			});
		}
	}
}
