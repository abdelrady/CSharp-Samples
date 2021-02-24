using System;
using System.Collections.Generic;
using Algo;

namespace BTree_NextRight
{
    class Program
    {
        static void Main(string[] args)
        {
            var bTree = new BinaryTree<int>();
            bTree.Add(10);
            bTree.Add(5);
            bTree.Add(15);
            bTree.Add(2);
            bTree.Add(1);
            bTree.Add(17);
            bTree.Add(13);
            //      10
            //    5    15
            //   2   13   17
            //  1
            bTree.PreOrderTraversal(a => Console.Write(a + " "));

            NextRight(bTree);

            Console.WriteLine();
        }

        public static void NextRight(BinaryTree<int> bTree)
        {
            //var s = new System.Collections.Generic.Stack<BinaryTreeNode<int>>();
            var s = new Queue<BinaryTreeNode<int>>();
            var q = new Queue<BinaryTreeNode<int>>();

            s.Enqueue(bTree.GetHead());
            do
            {
                while (s.Count > 0)
                {
                    var node = s.Dequeue();
                    if (node.Left != null) q.Enqueue(node.Left);
                    if (node.Right != null) q.Enqueue(node.Right);
                }

                if (q.Count > 0)
                {
                    BinaryTreeNode<int> leftNode = q.Dequeue();
                    s.Enqueue(leftNode);
                    while (q.Count > 0)
                    {
                        var rightNode = q.Dequeue();
                        s.Enqueue(rightNode);
                        leftNode.NextRight = rightNode;
                        Console.WriteLine($"Node: {leftNode.Value}, Right: {leftNode.NextRight.Value}");
                        leftNode = rightNode;
                    }
                    Console.WriteLine($"Node: {leftNode.Value}, Right: {leftNode.NextRight?.Value}");
                }

            } while (s.Count > 0);

        }

    }
}
