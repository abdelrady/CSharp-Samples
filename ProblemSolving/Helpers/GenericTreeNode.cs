using System.Collections.Generic;

namespace Helpers
{
    public class GenericTreeNode<T>
    {
        public T val;
        public HashSet<GenericTreeNode<T>> children;
        public GenericTreeNode(T val = default(T), HashSet<GenericTreeNode<T>> children = null)
        {
            this.val = val;
            this.children = children ?? new HashSet<GenericTreeNode<T>>(new TreeNodeComparer<T>());
        }
    }
}