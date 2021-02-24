using System;
using System.Collections.Generic;

namespace _42
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public ListNode AddTwoNumbersII(ListNode l1, ListNode l2)
        {
            ListNode n1 = l1, n2 = l2;
            int carry = 0, opRes = 0, i = 0, sum = 0;
            var st1 = new Stack<int>();
            var st2 = new Stack<int>();

            while (n1 != null)
            {
                st1.Push(n1.val);
                n1 = n1.next;
            }

            while (n2 != null)
            {
                st2.Push(n2.val);
                n2 = n2.next;
            }

            ListNode head = null;
            while (st1.Count > 0 || st2.Count > 0 || carry > 0)
            {
                opRes = (st1.Count > 0 ? st1.Pop() : 0) + (st2.Count > 0 ? st2.Pop() : 0) + carry;
                sum = (opRes % 10);
                carry = opRes / 10;
                var node = new ListNode(0);
                node.val = sum;
                if (head == null) head = node;
                else
                {
                    node.next = head;
                    head = node;
                }
            }
            return head;
        }
        public ListNode AddTwoNumbersI(ListNode l1, ListNode l2)
        {
            ListNode n1 = l1, n2 = l2;
            int carry = 0, opRes = 0, i = 0, sum = 0;
            var result = new ListNode(0);
            var node = result;
            while ((n1 != null || n2 != null) || carry > 0)
            {
                opRes = (n1?.val ?? 0) + (n2?.val ?? 0) + carry;
                sum = (opRes % 10);
                carry = opRes / 10;
                node.val = sum;
                if (n1 != null) n1 = n1.next;
                if (n2 != null) n2 = n2.next;
                if ((n1 != null || n2 != null) || carry > 0)
                {
                    node.next = new ListNode(0);
                    node = node.next;
                }

            }
            return result;
        }
    }
}
