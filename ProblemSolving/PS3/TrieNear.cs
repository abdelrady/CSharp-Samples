using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS3
{
    class TrieNear
    {
        public class WordDictionary
        {
            class TrieNode1EqualityComparer : IEqualityComparer<TrieNode1>
            {
                public bool Equals(TrieNode1 x, TrieNode1 y)
                {
                    return x.ch.Equals(y.ch);
                }

                public int GetHashCode(TrieNode1 obj)
                {
                    return obj.ch.GetHashCode();
                }
            }

            public class TrieNode1
            {
                public TrieNode1(char ch, string word = null)
                {
                    this.ch = ch;
                    this.word = word;
                    children = new HashSet<TrieNode1>(new TrieNode1EqualityComparer());
                }

                public char ch;
                public string word;

                public HashSet<TrieNode1> children;
            }

            public HashSet<TrieNode1> roots;

            /** Initialize your data structure here. */
            public WordDictionary()
            {
                roots = new HashSet<TrieNode1>(new TrieNode1EqualityComparer());
            }

            /** Inserts a word into the trie. */
            public void AddWord(string word)
            {
                var root = roots;
                for (int i = 0; i < word.Length; i++)
                {
                    var trieNode = new TrieNode1(word[i]);
                    if (i == word.Length - 1)
                    {
                        trieNode.word = word;
                    }

                    if (root.TryGetValue(trieNode, out var foundTrie))
                    {
                        if (trieNode.word != null && foundTrie.word == null) foundTrie.word = trieNode.word;
                        root = foundTrie.children;
                    }
                    else
                    {
                        root.Add(trieNode);
                        root = trieNode.children;
                    }
                }
            }

            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                return Search(word, 0, roots);
            }

            public bool Search(string word, int start, HashSet<TrieNode1> root)
            {
                if (root == null) return false;

                for (int i = start; i < word.Length; i++)
                {
                    var ch = word[i];
                    switch (ch)
                    {
                        case '.':
                            if (i == word.Length - 1 && root.Any(child=>child.word != null)) return true;
                            foreach (var node in root)
                            {
                                var found = Search(word, i + 1, node.children);
                                if (found) return true;
                            }
                            return false;
                            break;
                        default:
                            var trieNode = new TrieNode1(ch);
                            if (root.TryGetValue(trieNode, out var foundTrie))
                            {
                                if (i == word.Length - 1 && foundTrie.word != null) return true;
                                root = foundTrie.children;
                            }
                            else
                            {
                                return false;
                            }
                            break;
                    }
                }
                return false;
            }

            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                var root = roots;
                for (int i = 0; i < prefix.Length; i++)
                {
                    var trieNode = new TrieNode1(prefix[i]);
                    if (root.TryGetValue(trieNode, out var foundTrie))
                    {
                        root = foundTrie.children;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
