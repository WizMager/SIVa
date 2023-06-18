using System;
using System.Collections.Generic;
using GraphProcessor;

namespace Plugins.NgpBehaviourTreeDesigner.Nodes
{
    public abstract class ABehaviourTreeNode : BaseNode
    {
        public List<ABehaviourTreeNode> ChildNodes
        {
            get
            {
                var outputNodes = GetOutputNodes();
                var res = new List<ABehaviourTreeNode>();
                foreach (var outputNode in outputNodes)
                {
                    var behaviourTreeNode = outputNode as ABehaviourTreeNode;
                    if (behaviourTreeNode == null)
                        throw new ArgumentException(
                            $"BehaviourTreeNode should have type ABehaviourTreeNode not {outputNode.GetType().Name}");
                    res.Add(behaviourTreeNode);
                }
                res.Sort(new RectComparer());
                return res;
            }
        }

        public virtual Dictionary<string, object> Values { get; } = new();
        
        private struct RectComparer : IComparer<ABehaviourTreeNode>
        {
            public int Compare(ABehaviourTreeNode x, ABehaviourTreeNode y)
            {
                return x.position.x.CompareTo(y.position.x);
            }
        }
    }
}