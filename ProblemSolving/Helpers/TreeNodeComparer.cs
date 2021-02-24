using System.Collections.Generic;

namespace Helpers
{
    public class TreeNodeComparer<T> : IEqualityComparer<GenericTreeNode<T>>
    {
        public bool Equals(GenericTreeNode<T> x, GenericTreeNode<T> y)
        {
            return x.val.Equals(y.val);
        }

        public int GetHashCode(GenericTreeNode<T> obj)
        {
            return obj.val.GetHashCode();
        }
    }
}