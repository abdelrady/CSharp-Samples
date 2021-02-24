using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Helpers;

namespace TwoSum
{
    public class ProblemSet2
    {
        public int[] SortedSquares(int[] A)
        {
            var mid = Array.BinarySearch(A, 0);

            int left, right;
            if (mid < 0)
            {
                mid = ~mid;
            }

            left = mid - 1;
            right = mid;

            int[] sq = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (left < 0)
                {
                    sq[i] = (int) Math.Pow(A[right], 2);
                    right++;
                }
                else if (right >= A.Length)
                {
                    sq[i] = (int) Math.Pow(A[left], 2);
                    left--;
                }
                else
                {
                    var leftSq = (int) Math.Pow(A[left], 2);
                    var rightSq = (int) Math.Pow(A[right], 2);
                    if (leftSq < rightSq)
                    {
                        sq[i] = leftSq;
                        left--;
                    }
                    else
                    {
                        sq[i] = rightSq;
                        right++;
                    }
                }
            }

            return sq;
        }

        public string ReverseWords(string s)
        {
            if (s == null || s.Length == 0) return s;
            var sb = new StringBuilder(s);
            int start = 0, end;
            char temp;
            for (int i = 0; i < sb.Length; i++)
            {
                if ((sb[i] == ' ' || i == sb.Length - 1) && i > start)
                {
                    end = sb[i] == ' ' ? i - 1 : i;
                    while (start < end)
                    {
                        temp = sb[start];
                        sb[start++] = sb[end];
                        sb[end--] = temp;
                    }

                    start = i + 1;
                }
            }

            return sb.ToString();
        }

        public class Relation
        {
            public bool Knows(int a, int b)
            {
                if (Math.Abs(b - a) == 1)
                    return true;
                return false;
            }
        }

        public class Solution2 : Relation
        {
            public int FindCelebrity(int n)
            {
                var visited = new HashSet<int>();
                for (int i = 0; i < n; i++)
                {
                    var isCelebrity = true;
                    visited.Add(i);
                    for (int j = 0; j < n; j++)
                    {
                        if (j == i) continue;
                        if (Knows(i, j))
                        {
                            isCelebrity = false;
                            if (!visited.Contains(j))
                            {
                                i = j;
                            }

                            break;
                        }
                    }

                    if (isCelebrity) return i;
                }

                return -1;
            }
        }

        public int FindJudge(int N, int[][] trust)
        {
            if (N <= 0 || trust.Length < N - 1) return -1;

            var inDegrees = new int[N + 1];

            foreach (var t in trust)
            {
                inDegrees[t[1]]++;
                inDegrees[t[0]]--;
            }

            for (int i = 1; i <= N; i++)
            {
                if (inDegrees[i] == N - 1) return i;
            }

            return -1;
        }

        public int FindJudge_Old(int N, int[][] trust)
        {
            if (N <= 0 || trust.Length < N - 1) return -1;

            var inDegrees = new int[N + 1];
            var outDegrees = new int[N + 1];

            foreach (var t in trust)
            {
                inDegrees[t[1]]++;
                outDegrees[t[0]]++;
            }

            for (int i = 1; i <= N; i++)
            {
                if (inDegrees[i] == N - 1 && outDegrees[i] == 0) return i;
            }

            return -1;
        }

        public class GraphNode<T>
        {
            public T val;
            public IList<GraphNode<T>> neighbors;

            public GraphNode()
            {
                val = default(T);
                neighbors = new List<GraphNode<T>>();
            }

            public GraphNode(T _val)
            {
                val = _val;
                neighbors = new List<GraphNode<T>>();
            }

            public GraphNode(T _val, List<GraphNode<T>> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }

        public class Node : GraphNode<int>
        {
            public Node(int val) : base(val)
            {

            }
        }

        public Node CloneGraph(Node node)
        {
            if (node == null) return null;

            var q = new Queue<GraphNode<int>>();
            q.Enqueue(node);

            var visited = new bool[101];
            var dic = new Node[101];
            var newNodesChildren = new HashSet<int>[101];

            dic[node.val] = new Node(node.val);
            while (q.Count > 0)
            {
                var n = q.Dequeue();
                var newNode = dic[n.val];
                newNodesChildren[newNode.val] = newNodesChildren[newNode.val] ?? new HashSet<int>();
                visited[n.val] = true;

                foreach (var ne in n.neighbors)
                {
                    if (!visited[ne.val]) q.Enqueue(ne);
                    Node newChild;
                    if (dic[ne.val] == null)
                    {
                        newChild = new Node(ne.val);
                        dic[ne.val] = newChild;
                    }
                    else
                    {
                        newChild = dic[ne.val];
                    }

                    if (!newNodesChildren[newNode.val].Contains(newChild.val))
                    {
                        newNodesChildren[newNode.val].Add(newChild.val);
                        newNode.neighbors.Add(newChild);
                    }
                }
            }

            return dic[node.val];
        }

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            if (prerequisites == null || prerequisites.Length == 0)
                return Enumerable.Range(0, numCourses).ToArray();
            //if (numCourses <= 1) return new int[] {0};
            var inDegrees = new int[numCourses];
            var adjList = new List<List<int>>();

            for (int i = 0; i < numCourses; i++)
                adjList.Add(new List<int>());

            foreach (var prerequisite in prerequisites)
            {
                adjList[prerequisite[0]].Add(prerequisite[1]);
                inDegrees[prerequisite[1]]++;
            }

            var q = new Queue<int>();
            for (int i = 0; i < inDegrees.Length; i++)
            {
                if (inDegrees[i] == 0)
                {
                    q.Enqueue(i);
                }
            }

            int[] res = new int[numCourses];
            int index = 0;
            while (q.Count > 0)
            {
                var at = q.Dequeue();
                foreach (var to in adjList[at])
                {
                    inDegrees[to]--;
                    if (inDegrees[to] == 0) q.Enqueue(to);
                }

                res[numCourses - index] = at;
                index++;
            }

            return index == numCourses ? res : new int[0];
        }

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (numCourses <= 1 || prerequisites == null || prerequisites.Length == 0) return true;
            var inDegrees = new int[numCourses];
            var adjList = new List<List<int>>();

            for (int i = 0; i < numCourses; i++)
                adjList.Add(new List<int>());

            foreach (var prerequisite in prerequisites)
            {
                adjList[prerequisite[0]].Add(prerequisite[1]);
                inDegrees[prerequisite[1]]++;
            }

            var q = new Queue<int>();
            for (int i = 0; i < inDegrees.Length; i++)
            {
                if (inDegrees[i] == 0)
                {
                    q.Enqueue(i);
                }
            }

            int index = 0;
            while (q.Count > 0)
            {
                var at = q.Dequeue();
                foreach (var to in adjList[at])
                {
                    inDegrees[to]--;
                    if (inDegrees[to] == 0) q.Enqueue(to);
                }

                index++;
            }

            return index == numCourses;
        }

        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (preorder == null || preorder.Length == 0) return null;

            TreeNode root = new TreeNode(preorder[0]), p = root;
            var st = new Stack<TreeNode>();

            for (int i = 1; i < preorder.Length; i++)
            {
                var node = new TreeNode(preorder[i]);
                p = FindNodePosition(ref p, ref node, ref st);
            }

            return root;
        }

        private static TreeNode FindNodePosition(ref TreeNode p, ref TreeNode node, ref Stack<TreeNode> st)
        {
            if (node.val < p.val)
            {
                p.left = node;
                st.Push(p);
                p = p.left;
            }
            else
            {
                if (st.Count == 0 || node.val < st.Peek().val)
                {
                    p.right = node;
                    p = p.right;
                }
                else
                {
                    p = st.Pop();
                    p = FindNodePosition(ref p, ref node, ref st);
                }
            }

            return p;
        }

        //public ListNode SwapPairs(ListNode head)
        //{
        //    if (head == null || head.next == null) return head;

        //    return ReverseKGroup(head, 2);
        //}

        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;
            ListNode node = head, prev = head;
            while (node != null)
            {
                if (node.val == val)
                {
                    if (node == prev)
                    {
                        head = node.next;
                        prev = prev.next;
                    }
                    else
                    {
                        prev.next = node.next;
                    }
                }
                else
                {
                    prev = node;
                }

                node = node?.next;
            }

            return head;
        }

        public class BSTIterator
        {
            Stack<TreeNode> st = new Stack<TreeNode>();

            public BSTIterator(TreeNode root)
            {
                Iterator(root);
            }

            private void Iterator(TreeNode root)
            {
                while (root != null)
                {
                    st.Push(root);
                    root = root.left;
                }
            }

            /** @return the next smallest number */
            public int Next()
            {
                var item = st.Pop();

                if (item.right != null)
                {
                    item = item.right;
                }

                Iterator(item);

                return item.val;
            }

            /** @return whether we have a next smallest number */
            public bool HasNext()
            {
                return st.Count > 0;
            }
        }

        /**
         * Your BSTIterator object will be instantiated and called as such:
         * BSTIterator obj = new BSTIterator(root);
         * int param_1 = obj.Next();
         * bool param_2 = obj.HasNext();
         */

        public IList<int> InorderTraversal(TreeNode root)
        {
            var lst = new List<int>();
            InorderTraversalRec(root, ref lst);
            return lst;
        }

        private void InorderTraversalRec(TreeNode node, ref List<int> lst)
        {
            if (node == null) return;
            InorderTraversalRec(node.left, ref lst);
            lst.Add(node.val);
            InorderTraversalRec(node.right, ref lst);
        }

        public class Codec
        {

            // Encodes a tree to a single string.
            public string serialize(TreeNode root)
            {
                if (root == null) return null;
                var sb = new StringBuilder();
                var q = new Queue<TreeNode>();
                q.Enqueue(root);
                sb.Append((root == null ? "null" : root.val.ToString()) + ",");
                while (q.Count > 0)
                {
                    var parent = q.Dequeue();
                    sb.Append("," + (parent.left == null ? "null" : parent.left.val.ToString()));
                    sb.Append("," + (parent.right == null ? "null" : parent.right.val.ToString()));
                    if (parent.left != null) q.Enqueue(parent.left);
                    if (parent.right != null) q.Enqueue(parent.right);
                }

                //PreOrderTraversal(root, ref sb);
                return sb.ToString();
            }

            private void PreOrderTraversal(TreeNode node, ref StringBuilder sb)
            {
                sb.Append((node?.val == null ? "null" : node.val.ToString()) + ",");
                if (node != null) PreOrderTraversal(node.left, ref sb);
                if (node != null) PreOrderTraversal(node.right, ref sb);
            }

            // Decodes your encoded data to tree.
            public TreeNode deserialize(string data)
            {
                if (data == null) return null;
                var nodes = data.Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(s => s == "null" ? (int?) null : int.Parse(s))
                    .ToList();
                var i = 0;
                var root = new TreeNode(nodes[i++] ?? 0);
                var q = new Queue<TreeNode>();
                q.Enqueue(root);
                while (q.Count > 0 && i < nodes.Count)
                {
                    var parent = q.Dequeue();
                    var left = nodes[i++];
                    if (left.HasValue)
                    {
                        parent.left = new TreeNode(left.Value);
                        q.Enqueue(parent.left);
                    }

                    var right = nodes[i++];
                    if (right.HasValue)
                    {
                        parent.right = new TreeNode(right.Value);
                        q.Enqueue(parent.right);
                    }
                }

                return root;
            }
        }

        public ListNode Partition(ListNode head, int x)
        {
            var node = head;
            while (node != null)
            {
                if (node.val == x) break;
                node = node.next;
            }

            ListNode writeNode = head, currNode = head, prev = null;

            while (currNode != null)
            {
                if (writeNode != currNode && currNode.val < x)
                {
                    if (prev != null) prev.next = currNode.next;
                    if (writeNode.val >= x && writeNode.val > currNode.val)
                    {
                        var temp = writeNode;
                        writeNode = currNode;
                        head = currNode;
                        writeNode.next = temp;
                    }
                    else
                    {
                        var temp = writeNode.next;
                        writeNode.next = currNode;
                        currNode.next = temp;
                        writeNode = writeNode.next;
                    }
                }

                prev = currNode;
                currNode = currNode.next;
            }

            return head;
        }

        public void SortColors(int[] nums)
        {
            int curr = 0, p0 = 0, p2 = nums.Length - 1;

            while (curr < p2)
            {
                if (nums[curr] == 0)
                {
                    (nums[curr], nums[p0]) = (nums[p0], nums[curr]);
                    p0++;
                    curr++;
                }
                else if (nums[curr] == 2)
                {
                    (nums[curr], nums[p2]) = (nums[p2], nums[curr]);
                    p2--;
                }
                else curr++;
            }
            //var arr = new int[3];
            //foreach (var num in nums)
            //{
            //    arr[num]++;
            //}

            //var idx = 0;
            //for (int i = 0

        }
    }
}
