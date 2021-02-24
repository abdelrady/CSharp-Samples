using System.Linq;

namespace PS3
{
    public class WordDictionary
    {
        class TrieNode
        {
            public TrieNode(bool isWord = false)
            {
                this.isWord = isWord;
                children = new TrieNode[26];
            }

            public bool isWord;

            public TrieNode[] children;
        }

        private TrieNode[] roots;

        /** Initialize your data structure here. */
        public WordDictionary()
        {
            roots = new TrieNode[26];
        }

        /** Inserts a word into the trie. */
        public void AddWord(string word)
        {
            var root = roots;
            for (int i = 0; i < word.Length; i++)
            {
                var chIdx = word[i] - 'a';
                var trieNode = new TrieNode();
                if (i == word.Length - 1)
                    trieNode.isWord = true;

                if (root[chIdx] != null)
                {
                    if (trieNode.isWord && !root[chIdx].isWord) root[chIdx].isWord = trieNode.isWord;
                    root = root[chIdx].children;
                }
                else
                {
                    root[chIdx] = trieNode;
                    root = trieNode.children;
                }
            }
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            return Search(word, 0, roots);
        }

        bool Search(string word, int start, TrieNode[] root)
        {
            if (root == null) return false;

            for (int i = start; i < word.Length; i++)
            {
                var ch = word[i];
                switch (ch)
                {
                    case '.':
                        if (i == word.Length - 1) return root.Any(child => child?.isWord ?? false);
                        foreach (var node in root)
                        {
                            if (node != null)
                            {
                                var found = Search(word, i + 1, node.children);
                                if (found) return true;
                            }
                        }
                        return false;
                    default:
                        var chIdx = ch - 'a';
                        if (root[chIdx] != null)
                        {
                            if (i == word.Length - 1 && root[chIdx].isWord) return true;
                            root = root[chIdx].children;
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
    }
}