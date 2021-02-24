using System;
using System.Collections.Generic;

namespace _38
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override string ToString()
        {
            return val.ToString();
        }
    }

    public class Solution
    {
        static void Main(string[] args)
        {
            //Input: 1->2->3->4->5->NULL

            var _5 = new ListNode(5);
            var _4 = new ListNode(4);
            var _3 = new ListNode(3);
            var _2 = new ListNode(2);
            var _1 = new ListNode(1);
            _1.next = _2;
            _2.next = _3;
            _3.next = _4;
            _4.next = _5;

            //var newHead = new Solution().ReverseList(_1);

            //while (newHead != null)
            //{
            //    Console.Write(newHead.val);
            //    newHead = newHead.next;
            //}

            //Console.WriteLine();

            _5.next = _2;
            //Console.WriteLine(new Solution().HasCycle(_1, out var cycleStart));
            //Console.WriteLine(cycleStart.val);
            findStartOfLoop(_1);
        }

        public ListNode ReverseList(ListNode head)
        {
            var node = head;
            var st = new Stack<ListNode>();
            while (node != null)
            {
                st.Push(node);
                node = node.next;
            }

            node = null;
            while (st.Count > 0)
            {
                if (node == null)
                    head = node = st.Pop();
                else
                {
                    node.next = st.Pop();
                    node = node.next;
                    if (st.Count == 0)
                        node.next = null;
                }
            }
            return head;
        }
        public static void findStartOfLoop(ListNode n)
        {

            ListNode fast, slow;
            fast = slow = n;
            do
            {
                fast = fast.next.next;
                slow = slow.next;
            } while (fast != slow);

            fast = n;
            do
            {
                fast = fast.next;
                slow = slow.next;
            } while (fast != slow);

            Console.WriteLine(" Start of Loop : " + fast.val);
        }

        public bool HasCycle(ListNode head, out ListNode cycleStart)
        {
            cycleStart = null;
            var res = false;
            if (head == null)
                return false;
            // 1->2->1
            if (head.next != null && head.next == head.next.next)
                return true;

            // 1>2>3>4>5>2
            var slow = head;
            var fast = head.next?.next;
            while (fast?.next != null)
            {
                if (slow == fast)
                {
                    res = true;
                    break;
                }
                slow = slow.next;
                fast = fast.next?.next;
            }

            if (slow != fast)
                return false;

            if (res)
            {

                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }

                cycleStart = slow;
            }
            return res;
        }
    }
}
