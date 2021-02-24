using System;
using System.Collections.Generic;

namespace _45
{
    class Program
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node()
            {
            }

            public Node(int _val, Node _next, Node _random)
            {
                val = _val;
                next = _next;
                random = _random;
            }
        }

        Dictionary<Node, Node> dic = new Dictionary<Node, Node>();

        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            var node = head;
            Node lastNode = null, newHead = null;
            while (node != null)
            {
                var newNode = CloneNode(node);
                if (newHead == null) lastNode = newHead = newNode;
                else
                {
                    lastNode.next = newNode;
                    lastNode = lastNode.next;
                }

                if (node != node.next) node = node.next;
                else node = null;
            }

            return newHead;
        }

        public Node CloneNode(Node node)
        {
            if (node == null) return null;
            Node newNode = null;
            if (this.dic.ContainsKey(node))
                newNode = this.dic[node];
            else
            {
                dic.Add(node, new Node(node.val, null, null));
                newNode = this.dic[node];
                newNode.next = CloneNode(node.next);
                newNode.random = CloneNode(node.random);
            }

            return newNode;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
}