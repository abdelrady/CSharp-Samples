using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SwapNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] indexes = new int[n][];

            for (int indexesRowItr = 0; indexesRowItr < n; indexesRowItr++)
            {
                indexes[indexesRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), indexesTemp => Convert.ToInt32(indexesTemp));
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            int[] queries = new int[queriesCount];

            for (int queriesItr = 0; queriesItr < queriesCount; queriesItr++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[queriesItr] = queriesItem;
            }

            int[][] result = swapNodes(indexes, queries);

            textWriter.WriteLine(String.Join("\n", result.Select(x => String.Join(" ", x))));

            textWriter.Flush();
            textWriter.Close();
        }

        /*
     * Complete the swapNodes function below.
     */
        static int[][] swapNodes(int[][] indexes, int[] queries)
        {
            var tree = BuildTree(indexes);

            Console.WriteLine(tree.GetInOrderTraversalList());
            return new[] { new[] { 0 } };
        }

        private static Tree<int> BuildTree(int[][] indexes)
        {
            var tree = new Tree<int>();
            var root = tree.AddNode(1);
            Node<int> parent = root;
            var queue = new Queue<Node<int>>();

            foreach (var pair in indexes)
            {
                if (pair[0] != -1) queue.Enqueue(tree.AddNode(pair[0], parent));
                if (pair[1] != -1) queue.Enqueue(tree.AddNode(pair[1], parent, false));
                parent = queue.Count > 0 ? queue.Dequeue() : null;
            }

            return tree;
        }
    }

    public class Node<T>
    {
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public T Value { get; set; }
    }

    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public string GetInOrderTraversalList()
        {
            var list = new List<T>();
            InOrderTraverse(Root, ref list);
            return string.Join(" ", list);
        }

        private void InOrderTraverse(Node<T> node, ref List<T> list)
        {
            if (node == null) return;
            InOrderTraverse(node.Left, ref list);
            list.Add(node.Value);
            InOrderTraverse(node.Right, ref list);
        }

        public Node<T> AddNode(T value, Node<T> parent = null, bool onLeft = true)
        {
            var node = new Node<T> { Value = value };
            if (parent == null) Root = node;
            if (parent != null)
            {
                if (onLeft) parent.Left = node;
                parent.Right = node;
            }
            return node;
        }
    }
}
