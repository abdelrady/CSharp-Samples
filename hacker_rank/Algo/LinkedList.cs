using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo
{
    public class LinkedList<T> where T : IComparable<T>
    {
        public LinkedList()
        {

        }

        public LinkedList(params T[] initialData)
        {
            foreach (var item in initialData)
            {
                this.Append(item);
            }
        }

        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        public override string ToString()
        {
            var s = new StringBuilder();
            var n = Head;
            while (n != null)
            {
                s.Append(n.Value + " ");
                n = n.Next;
            }

            return s.ToString();
        }

        public void Append(T val)
        {
            var node = new Node<T>(val);
            var n = Head;
            if (n == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Prev = Tail;
                Tail = node;
            }
        }

        public Node<T> Find(T val)
        {
            Node<T> foundNode = null;
            Node<T> head = Head, tail = Tail;
            while (foundNode == null && head != tail)
            {
                if (head.Value.Equals(val))
                    foundNode = head;
                if (tail.Value.Equals(val))
                    foundNode = tail;
                if (head.Next != null) head = head.Next;
                if (tail.Next != null) tail = tail.Prev;
            }

            return foundNode;
        }

        public void Delete(T val)
        {
            var foundNode = Find(val);
            DeleteNode(foundNode);
        }

        private void DeleteNode(Node<T> foundNode)
        {
            if (foundNode != null)
            {
                if (Tail == foundNode)
                    Tail = Tail.Prev;
                if (Head == foundNode)
                    Head = Head.Next;
                if (foundNode.Next != null)
                    foundNode.Next.Prev = foundNode.Prev;
                if (foundNode.Prev != null)
                    foundNode.Prev.Next = foundNode.Next;
            }
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

        public void DeleteDuplicates()
        {
            var hs = new HashSet<T>();
            var n = Head;
            while (n != null)
            {
                if (hs.Contains(n.Value))
                {
                    DeleteNode(n);
                }
                else hs.Add(n.Value);
                n = n.Next;
            }
        }

        public Node<T> KTHFromLast(int k)
        {
            var n = Tail;
            while (--k != 0 && n != null)
            {
                n = n.Prev;
            }
            return n;
        }
        public Node<T> KTHFromLastSinglyList(int k)
        {
            var q = new Queue<Node<T>>();
            var n = Head;
            while (n != null)
            {
                if (q.Count >= k)
                    q.Dequeue();
                q.Enqueue(n);
                n = n.Next;
            }
            return q.ElementAt(0);
        }

        /// <summary>
        /// Idea is to use 2 pointers and keep K distance between them
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public Node<T> KTHFromLastSinglyListNoBuffer(int k)
        {
            Node<T> p1 = Head, p2 = Head;
            for (int i = 0; i < k; i++)
            {
                if (p1 == null)
                    return null;
                p1 = p1.Next;
            }

            while (p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }
            return p2;
        }

        public void Partition(T k)
        {
            var n = Head;
            Node<T> foundNode = Find(k);
            Head = Tail = new Node<T>(foundNode.Value);
            while (n != null)
            {
                var nextNode = n.Next;
                if (n.Value.CompareTo(k) > 0 || (n.Value.CompareTo(k) == 0 && foundNode != n))
                {
                    // TODO maintain Prev
                    Tail.Next = n;
                    Tail = n;
                }
                else if (n.Value.CompareTo(k) < 0)
                {
                    // TODO maintain Prev
                    n.Next = Head;
                    Head = n;
                }

                n = nextNode;
            }

            Tail.Next = null;
            Head.Prev = null;
        }

        public LinkedList<T> Reverse()
        {
            Node<T> n1 = Head, n2 = Tail;
            while (n1!=null && n2!=null && n1 != n2 && n1.Prev != n2)
            {
                var temp = n1.Value;
                n1.Value = n2.Value;
                n2.Value = temp;
                n1 = n1.Next;
                n2 = n2.Prev;
            }
            return this;
        }

        public bool IsPalindromeSingly()
        {
            return false;
            // Look at page 218 in Hacking the coding Interview
            //Node n1 = Head;
            //var s = new Stack<T>();
            //var popIfDifferentOnce = true;

            //while (n1 != null)
            //{
            //    if (s.Count == 0 || (!popIfDifferentOnce && !s.Peek().Equals(n1.Value))
            //        s.Push(n1.Value);
            //    else s.Pop();
            //    n1 = n1.Next;
            //}

            //return s.Count == 0;
        }

        public bool IsPalindrome()
        {
            Node<T> n1 = Head, n2 = Tail;
            while (n1 != null && n2 != null && n1 != n2 && n1.Prev != n2)
            {
                if (!n1.Value.Equals(n2.Value))
                    return false;
                n1 = n1.Next;
                n2 = n2.Prev;
            }

            return true;
        }

        public static LinkedList<int> SumLists(LinkedList<int> l1, LinkedList<int> l2, bool fromHead = true)
        {
            var l3 = new LinkedList<int>();
            Node<int> n1 = fromHead ? l1.Head : l1.Tail, n2 = fromHead ? l2.Head : l2.Tail;
            int carry = 0;
            while (n1 != null || n2 != null)
            {
                var sum = (n1?.Value ?? 0) + (n2?.Value ?? 0) + carry;
                carry = sum / 10;
                l3.Append(sum % 10);
                n1 = fromHead ? n1?.Next : n1?.Prev;
                n2 = fromHead ? n2?.Next : n2?.Prev;
            }

            if (carry > 0)
                l3.Append(carry);
            return l3;
        }
    }
}
