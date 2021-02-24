using System;
using System.Collections.Generic;
using System.Linq;

namespace _43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode head = null, node = null, lastNode = null;
        
        while(l1 != null || l2 != null){
            if(l2 == null || (l1?.val ?? int.MaxValue) < (l2.val)){
                node = new ListNode(l1.val);
                l1 = l1.next;
            } else {
                node = new ListNode(l2.val);
                l2 = l2.next;
            }
            
            if(head == null) {
                head = node;
                lastNode = node;
            }
            else {
                lastNode.next = node;
                lastNode = node;
            }
        }
        return head;
    }
    
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode head = null, node = null, lastNode = null;
            var h = new MinHeap<ListNode>(new ListNodeComparer());
            foreach (var listNode in lists)
            {
                if (listNode != null) h.Add(listNode);
            }

            while (h.Count > 0)
            {
                var minLi = h.ExtractDominating();
                node = new ListNode(minLi.val);
                minLi = minLi.next;
                if(minLi != null) h.Add(minLi);
                if (head == null)
                {
                    head = node;
                    lastNode = node;
                }
                else
                {
                    lastNode.next = node;
                    lastNode = node;
                }
            }
            return head;
        }
        public ListNode MergeKLists2(ListNode[] lists)
        {
            ListNode head = null, node = null, lastNode = null;

            while (lists.Any(li => li != null))
            {
                var minLi = GetMinNode(lists, out var i);
                node = new ListNode(minLi.val);
                lists[i] = lists[i].next;
                if (head == null)
                {
                    head = node;
                    lastNode = node;
                }
                else
                {
                    lastNode.next = node;
                    lastNode = node;
                }
            }
            return head;
        }

        private ListNode GetMinNode(ListNode[] lists, out int idx)
        {
            ListNode minNode = null;
            idx = -1;
            for (int i = 0; i < lists.Length; i++)
            {
                if (minNode == null || (lists[i] != null && lists[i].val < minNode.val))
                {
                    minNode = lists[i];
                    idx = i;
                }
            }

            return minNode;
        }
    }

    internal class ListNodeComparer : Comparer<ListNode>
    {
        public override int Compare(ListNode x, ListNode y)
        {
            if (x == null && y != null)
                return 1;
            else if (y == null && x != null)
                return -1;
            else if (y != null && x != null)
                return 0;
            return x.val.CompareTo(y.val);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
