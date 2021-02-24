using System;
using System.Collections.Generic;

namespace TreeTraversal_Insufficient
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        static void Main(string[] args)
        {
            /**
             Input
[1,2,3,4,-99,-99,7,8,9,-99,-99,12,13,-99,14]
1
Output
[1,2,3,null,null,null,7,null,14]
Expected
[1,2,3,4,null,null,7,8,9,null,14]
             */
            
            var _7 = new TreeNode(7);
            _7.left = new TreeNode(-99);
            _7.right = new TreeNode(14);

            var _n992 = new TreeNode(-99);
            _n992.left = new TreeNode(12);
            _n992.right = new TreeNode(13);

            var _n991 = new TreeNode(-99);
            _n991.left = new TreeNode(-99);
            _n991.right = new TreeNode(-99);


            var _4 = new TreeNode(4);
            _4.left = new TreeNode(8);
            _4.right = new TreeNode(9);


            var _3 = new TreeNode(3);
            _3.left = _n992;
            _3.right = _7;


            var _2 = new TreeNode(2);
            _2.left = _4;
            _2.right = _n991;

            var root = new TreeNode(1);
            root.left = _2;
            root.right = _3;

            PrintTree(root);

            var newRoot = SufficientSubset(root, 1);

            PrintTree(newRoot);
        }

        private static void PrintTree(TreeNode newRoot)
        {
            var node = newRoot;
            var q = new Queue<TreeNode>();
            q.Enqueue(node);
            Console.Write("[");
            Console.Write(node.val + ", ");
            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.Write((node.left?.val.ToString() ?? "null") + ", ");
                Console.Write((node.right?.val.ToString() ?? "null") + ", ");
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            Console.Write("]");
            Console.WriteLine();
        }

        public static TreeNode SufficientSubset(TreeNode root, int limit)
        {
            var st = new Stack<(TreeNode, TreeNode)>();
            st.Push((null, root));
            long sum = 0;
            while (st.Count > 0)
            {
                var nodes = st.Pop();
                var node = nodes.Item2;
                sum += node.val;
                if (node.left != null)
                {
                    if (IsInsufficient(node.left, sum, limit))
                        node.left = null;
                    else
                    {
                        if (!IsLeaf(node.left)) st.Push((node, node.left));
                    }
                }

                if (node.right != null)
                {
                    if (IsInsufficient(node.right, sum, limit))
                        node.right = null;
                    else
                    {
                        if (!IsLeaf(node.right)) st.Push((node, node.right));
                    }
                }

                if (nodes.Item1 != null && IsInsufficient(node, sum, limit))
                {
                    if (nodes.Item1.left == node)
                        nodes.Item1.left = null;
                    else if (nodes.Item1.right == node)
                        nodes.Item1.right = null;
                }
            }

            return root;
        }

        public static bool IsInsufficient(TreeNode node, long sum, int limit)
        {
            if (IsLeaf(node) && sum + node.val < limit) //leaf
            {
                return true;
            }
            return false;
        }

        private static bool IsLeaf(TreeNode node)
        {
            return node.left == null && node.right == null;
        }
    }
}
