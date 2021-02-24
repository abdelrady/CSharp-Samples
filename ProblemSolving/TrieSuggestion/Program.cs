using System;
using System.Collections.Generic;
using System.Linq;

namespace TrieSuggestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);

            var trie = new Trie(products);
            var result = new List<IList<string>>(searchWord.Length);
            string prefix = string.Empty;
            for (int i = 0; i < searchWord.Length; i++)
            {
                prefix += searchWord[i];
                result.Add(trie.ListStartsWith(prefix, 3));
            }
            return result;
        }
    }


    public class Trie
    {
        public HashSet<TrieNode<char>> roots;
        /** Initialize your data structure here. */
        public Trie(string[] words = null)
        {
            roots = new HashSet<TrieNode<char>>(new TrieNodeComparer<char>());
            if (words != null)
            {
                foreach (var word in words)
                {
                    Insert(word);
                }
            }
        }

        public void Insert(string word)
        {
            var nodes = roots;
            TrieNode<char> parent = null;
            foreach (var ch in word)
            {
                var chNode = new TrieNode<char>(ch);
                if (nodes.TryGetValue(chNode, out parent))
                {
                    nodes = parent.children;
                }
                else
                {
                    parent = chNode;
                    nodes.Add(chNode);
                    nodes = chNode.children;
                }
            }

            parent.word = word;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var nodes = roots;
            foreach (var ch in word)
            {
                var chNode = new TrieNode<char>(ch);
                if (!nodes.Contains(chNode)) return false;
                var hashSetNode = nodes.First(n => n.val == ch);
                nodes = hashSetNode.children;
            }
            return nodes.Contains(new TrieNode<char>());
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var nodes = roots;
            foreach (var ch in prefix)
            {
                var chNode = new TrieNode<char>(ch);
                if (!nodes.Contains(chNode)) return false;
                var hashSetNode = nodes.First(n => n.val == ch);
                nodes = hashSetNode.children;
            }
            return true;
        }

        public IList<string> ListStartsWith(string prefix, int length)
        {
            var nodes = roots;
            TrieNode<char> parentNode = null;
            foreach (var ch in prefix)
            {
                var chNode = new TrieNode<char>(ch);
                if (!nodes.Contains(chNode)) return new List<string>();
                nodes.TryGetValue(chNode, out parentNode);
                nodes = parentNode.children;
            }

            var result = new List<string>();
            TraverseAndStore(parentNode, ref length, ref result);
            return result;
        }

        private void TraverseAndStore(in TrieNode<char> node, ref int length, ref List<string> result)
        {
            if (length == 0) return;
            if (node.word != null)
            {
                result.Add(node.word);
                length--;
            }
            if (length == 0) return;
            foreach (var child in node.children)
            {
                TraverseAndStore(child, ref length, ref result);
            }
        }
    }


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

    class TrieNodeComparer<T> : IEqualityComparer<TrieNode<T>>
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
