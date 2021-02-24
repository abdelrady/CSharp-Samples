using System;

namespace _44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;

        var lengthA = GetLength(headA);
        var lengthB = GetLength(headB);
        var diff = lengthA - lengthB;
        ListNode nodeA = headA, nodeB = headB;

        if (diff > 0)
        {
            while (diff != 0)
            {
                nodeA = nodeA.next;
                diff--;
            }
        }
        else if (diff < 0)
        {
            while (diff != 0)
            {
                nodeB = nodeB.next;
                diff++;
            }
        }

        while (nodeA != null && nodeB != null)
        {
            if (nodeA == nodeB)
                return nodeA;
            nodeA = nodeA.next;
            nodeB = nodeB.next;
        }
        return null;
    }

    public int GetLength(ListNode node)
    {
        var n = node;
        var count = 0;
        while (n != null)
        {
            count++;
            n = n.next;
        }
        return count;
    }
}
