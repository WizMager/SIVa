using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace Plugins.NgpBehaviourTreeDesigner.Editor
{
	public class GraphAssetCallbacks
	{
		[MenuItem("Assets/Create/Behaviour tree", false, 10)]
		public static void CreateGraphPorcessor()
		{
			var graph = ScriptableObject.CreateInstance<BehaviourTreeGraph>();
			ProjectWindowUtil.CreateAsset(graph, "BehaviourTreeGraph.asset");
		}
	
		[OnOpenAsset(0)]
		public static bool OnBaseGraphOpened(int instanceID, int line)
		{
			var asset = EditorUtility.InstanceIDToObject(instanceID) as BehaviourTreeGraph;

			if (asset != null)
			{
				EditorWindow.GetWindow<BehaviourTreeGraphWindow>().InitializeGraph(asset);
				return true;
			}
			return false;
		}
	}
}
