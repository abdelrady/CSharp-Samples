using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helpers
{
    public static class TreeExtensions
    {
        public static TreeNode BuildTreeFromArray(this int[] arr)
        {
            return BuildTreeFromArray(arr.Select(i => (int?)i).ToArray());
        }

        public static TreeNode BuildTreeFromArray(this int?[] arr)
        {
            if (arr == null || arr.Length == 0 || !arr[0].HasValue) return null;
            var root = new TreeNode(arr[0].Value);
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var i = 1;
            while (i < arr.Length)
            {
                var parent = q.Dequeue();
                if (arr[i].HasValue)
                {
                    parent.left = new TreeNode(arr[i].Value);
                    q.Enqueue(parent.left);
                }
                i++;

                if (i < arr.Length && arr[i].HasValue)
                {
                    parent.right = new TreeNode(arr[i].Value);
                    q.Enqueue(parent.right);
                }
                i++;
            }
            return root;
        }
    }
}
