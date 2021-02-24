using System.Collections.Generic;

namespace Helpers
{
    public class TrieNodeComparer<T> : IEqualityComparer<TrieNode<T>>
    {
        public bool Equals(TrieNode<T> x, TrieNode<T> y)
        {
            return x.val.Equals(y.val);
        }

        public int GetHashCode(TrieNode<T> obj)
        {
            return obj.val.GetHashCode();
        }
    }
}