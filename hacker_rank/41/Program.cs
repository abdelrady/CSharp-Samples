using System;
using System.Collections.Generic;

namespace _41
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
        }

        public Node(int _val, IList<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }

    public class Solution
    {
        Dictionary<Node, Node> dic = new Dictionary<Node, Node>();

        public static void Main()
        {

        }

        public Node CloneGraph(Node node)
        {
            if (node == null)
                return node;

            return this.Clone(node);
        }
        public Node Clone(Node node)
        {
            if (this.dic.ContainsKey(node))
                return this.dic[node];
            var cList = new List<Node>();
            var newNode = new Node(node.val, cList);
            dic.Add(node, newNode);
            foreach (var child in node.neighbors)
            {
                cList.Add(this.Clone(child));
            }
            return this.dic[node];
        }
    }
}
