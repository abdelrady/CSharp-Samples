using System;
using System.Collections.Generic;
using System.Linq;

namespace _39
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
        public TreeNode nextRight;

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class Solution
    {
        static void Main(string[] args)
        {
            var _5 = new TreeNode(5);
            var _1 = new TreeNode(1);
            var _4 = new TreeNode(4);
            var _3 = new TreeNode(3);
            var _6 = new TreeNode(6);

            _4.left = _3;
            _4.right = _6;

            _5.left = _1;
            _5.right = _4;

            Console.WriteLine(new Solution().IsValidBST(_5));

            foreach (var i in new Solution().InorderTraversal(_5))
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //       [6,2,8,0,4,7,9,null,null,3,5]
            var __0 = new TreeNode(0);
            var __1 = new TreeNode(1);
            var __2 = new TreeNode(2);
            var __3 = new TreeNode(3);
            var __4 = new TreeNode(4);
            var __5 = new TreeNode(5);
            var __6 = new TreeNode(6);
            var __7 = new TreeNode(7);
            var __8 = new TreeNode(8);

            //[3,5,1,6,2,0,8,null,null,7,4]
            __3.left = __5;
            __3.right = __1;
            __5.left = __6;
            __5.right = __2;
            __1.left = __0;
            __1.right = __8;
            __2.left = __7;
            __2.left = __4;

            var lca = new Solution().LowestCommonAncestor1(__3, __5, __4);
            Console.WriteLine(lca.val);
        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var node = root;
            while (node != null)
            {
                if (p.val > node.val && q.val > node.val)
                {
                    node = node.right;
                }
                else if (p.val < node.val && q.val < node.val)
                {
                    node = node.left;
                }
                else return node;
            }
            return null;
        }

        public TreeNode LowestCommonAncestor1(TreeNode root, TreeNode p, TreeNode q)
        {
            var hs1 = new HashSet<TreeNode>();
            var hs2 = new HashSet<TreeNode>();
            FindNodeTreeRecursive(root, p, hs1);
            FindNodeTreeRecursive(root, q, hs2);

            var hs = hs1.Count > hs2.Count ? hs2 : hs1;
            var resIndex = -1;
            for (int i = 0; i < hs.Count; i++)
            {
                if (hs1.ElementAt(i) == hs2.ElementAt(i))
                {
                    resIndex = i;
                }
                else break;
            }
            return resIndex < 0 ? null : hs.ElementAt(resIndex);
        }

        private bool FindNodeTreeRecursive(TreeNode root, TreeNode p, HashSet<TreeNode> hs)
        {
            var node = root;
            if (node == null) return false;
            hs.Add(node);
            if (node.val == p.val)
                return true;
            if ((node.left != null && FindNodeTreeRecursive(node.left, p, hs)) ||
                (node.right != null && FindNodeTreeRecursive(node.right, p, hs)))
                return true;
            hs.Remove(node);
            return false;
        }

        // Not working
        private void FindNodeTree(TreeNode root, TreeNode p, HashSet<TreeNode> hs)
        {
            var node = root;
            var q = new Queue<TreeNode>();
            while (node != null)
            {
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
                hs.Add(node);
                if (node.val == p.val)
                    break;
                if (node.left == null && node.right == null)
                    hs.Remove(node);
                q.TryDequeue(out node);
            }
        }

        private void FindNodeBTree(TreeNode root, TreeNode p, HashSet<TreeNode> hs)
        {
            var node = root;
            while (node != null)
            {
                hs.Add(node);
                if (node.val == p.val)
                    break;
                node = p.val > node.val ? node.right : node.left;
            }
        }

        public IList<IList<int>> LevelOrder2(TreeNode root)
        {
            var res = new List<IList<int>>();
            var pQ = new Queue<TreeNode>();
            if (root == null) return res;
            pQ.Enqueue(root);
            res.Add(new List<int> { root.val });

            do
            {
                var levelLst = new List<TreeNode>();
                while (pQ.Count > 0)
                {
                    var node = pQ.Dequeue();
                    if (node.left != null) levelLst.Add(node.left);
                    if (node.right != null) levelLst.Add(node.right);
                }

                foreach (var p in levelLst)
                {
                    pQ.Enqueue(p);
                }
                if (levelLst.Any()) res.Add(levelLst.Select(i => i.val).ToList());
            } while (pQ.Count > 0);

            return res;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();
            var pQ = new Queue<TreeNode>();
            if (root == null) return res;
            pQ.Enqueue(root);
            res.Add(new List<int> { root.val });
            var levelItems = 1;
            do
            {
                var levelLst = new List<int>();
                var currentLevelItems = levelItems;
                levelItems = 0;
                for (int i = 0; i < currentLevelItems; i++)
                {
                    var node = pQ.Dequeue();
                    if (node.left != null)
                    {
                        pQ.Enqueue(node.left);
                        levelLst.Add(node.left.val);
                        levelItems++;
                    }

                    if (node.right != null)
                    {
                        pQ.Enqueue(node.right);
                        levelLst.Add(node.right.val);
                        levelItems++;
                    }
                }

                if (levelLst.Any()) res.Add(levelLst);
            } while (pQ.Count > 0);

            return res;
        }

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            return null;
        }

        public TreeNode Connect(TreeNode root)
        {
            if (root == null) return root;
            var node = root;
            var q = new Queue<TreeNode>();

            while (node != null)
            {
                q.Enqueue(node.left);
                q.Enqueue(node.right);
                if (node.left != null)
                {
                    node.left.nextRight = node.right;
                }

                if (node.right != null && node.nextRight != null)
                {
                    node.right.nextRight = node.nextRight.left;
                }

                node = q.Dequeue();
            }

            return root;
        }
        public TreeNode Connect3(TreeNode root)
        {
            if (root == null) return root;
            var node = root;
            var q = new Queue<TreeNode>();

            while (node != null)
            {
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
                if (node.left != null)
                {
                    node.left.nextRight = node.right ?? FindNextNodeOnSameLevel(node);
                }

                if (node.right != null)
                {
                    node.right.nextRight = FindNextNodeOnSameLevel(node);
                }

                q.TryDequeue(out node);
            }

            return root;
        }

        private TreeNode FindNextNodeOnSameLevel(TreeNode node)
        {
            node = node.nextRight;
            while (node != null)
            {
                if (node.left != null) return node.left;
                if (node.right != null) return node.right;
                node = node.nextRight;
            }
            return null;
        }

        public TreeNode Connect2(TreeNode root)
        {
            if (root == null) return null;
            var s = new Queue<TreeNode>();
            var q = new Queue<TreeNode>();

            s.Enqueue(root);
            do
            {
                while (s.Count > 0)
                {
                    var node = s.Dequeue();
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }

                if (q.Count > 0)
                {
                    var leftNode = q.Dequeue();
                    s.Enqueue(leftNode);
                    while (q.Count > 0)
                    {
                        var rightNode = q.Dequeue();
                        s.Enqueue(rightNode);
                        leftNode.nextRight = rightNode;
                        leftNode = rightNode;
                    }
                }

            } while (s.Count > 0);
            return root;
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            var lst = new List<int>();
            foreach (var i in InorderTraversalIterator(root))
            {
                lst.Add(i);
            }

            return lst;
        }
        public IEnumerable<int> InorderTraversalIterator(TreeNode root)
        {
            var current = root;
            var s = new Stack<TreeNode>();
            var goLeft = true;

            while (current != null)
            {
                if (goLeft)
                {
                    while (current.left != null)
                    {
                        s.Push(current);
                        current = current.left;
                    }
                }

                yield return current.val;

                if (current.right != null)
                {
                    current = current.right;
                    goLeft = true;
                }
                else
                {
                    s.TryPop(out current);
                    goLeft = false;
                }
            }
        }
        public bool IsValidBST(TreeNode root)
        {
            if (root == null) return true;
            return InOrderTraverseWithCheck(root);
            /*var s = new Queue<TreeNode>();
            s.Enqueue(root);
            while(s.Count > 0){
                var node = s.Dequeue();
            if(node.left != null){
                if(node.left.val >= node.val)
                    return false;
                s.Enqueue(node.left);

            } 
            if(node.right != null){
                if(node.right.val <= node.val)
                    return false;
                            s.Enqueue(node.right);

            } 
            }

            return true;*/
        }

        public bool InOrderTraverseWithCheck(TreeNode root)
        {
            var s = new Stack<TreeNode>();
            s.Push(root);
            var goLeft = true;
            int? prevValue = null;
            var current = s.Pop();

            while (current != null)
            {
                if (goLeft)
                {
                    while (current.left != null)
                    {
                        s.Push(current);
                        current = current.left;
                    }
                }

                if (prevValue != null && prevValue >= current.val)
                    return false;
                prevValue = current.val;

                if (current.right != null)
                {
                    current = current.right;
                    goLeft = true;
                }
                else
                {
                    s.TryPop(out current);
                    goLeft = false;
                }

            }

            return true;
        }
    }
}
