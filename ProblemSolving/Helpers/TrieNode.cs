using System.Collections.Generic;

namespace Helpers
{
    public class TrieNode<T>
    {
        public T val;
        public string word;
        public HashSet<TrieNode<T>> children;
        public TrieNode(T val = default(T), HashSet<TrieNode<T>> children = null)
        {
            this.val = val;
            this.children = children ?? new HashSet<TrieNode<T>>(new TrieNodeComparer<T>());
        }
    }


    public class TrieNodeCh
    {
        public char val;
        public string word;
        public SortedSet<TrieNodeCh> children;
        public TrieNodeCh(char val = default(char), SortedSet<TrieNodeCh> children = null)
        {
            this.val = val;
            this.children = children ?? new SortedSet<TrieNodeCh>(new TrieNodeSetComparer());
        }
    }

    public class TrieNodeSetComparer : IComparer<TrieNodeCh>
    {
        public int Compare(TrieNodeCh x, TrieNodeCh y)
        {
            return y.val.CompareTo(x.val);
        }
    }
}