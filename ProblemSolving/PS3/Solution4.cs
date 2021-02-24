using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace PS3
{
    public class Solution4
    {
        private int modulo = 1_000_000_007;

        void Main(string[] args)
        {
            var sln = new Solution4();

            //sln.BuildTree(new[] {3, 9, 20, 15, 7}, new[] {9, 3, 15, 20, 7}).Print();
            //new Solution.BTreeConstructPreOrder().buildTree(new[] {3, 9, 20, 15, 7}, new[] {9, 3, 15, 20, 7}).Print();
            //new Solution.BTreeConstructPostOrder().BuildTree(new[] { 9, 3, 15, 20, 7 }, new[] { 9, 15, 7, 20, 3 }).Print();

            //sln.WordBreak("catsanddog", new List<string>{ "cat", "cats", "and", "sand", "dog" }).Print();

            //sln.Rob(new[] { 2, 7, 9, 3, 1 }).Print();

            //sln.LastSubstring1("cacacb").Print();

            //sln.CountRangeSum(new[] { 0, -3, -3, 1, 1, 2 }, 3, 5).Print();

            //sln.JobScheduling(new[] { 4, 2, 4, 8, 2 }, new[] { 5, 5, 5, 10, 8 }, new[] { 1, 2, 8, 10, 4 }).Print();

            //sln.longestValidParentheses("()()").Print();

            //sln.MaxProfit(new[] { 1, 2, 3, 4, 5 }).Print();
            //sln.MaxProfit(new[] { 3, 3, 5, 0, 0, 3, 1, 4 }).Print();

            //sln.ValidUtf8(new[] { 197, 130, 1 }).Print();

            //sln.cellsToBitmap(new int[] { 0, 1, 0, 1, 1, 0, 0, 1 }).Print();

            //sln.CandyCrush(new[]
            //{
            //    new[] {110, 5, 112, 113, 114},
            //    new[] {210, 211, 5, 213, 214},
            //    new[] {310, 311, 3, 313, 314},
            //    new[] {410, 411, 412, 5, 414},
            //    new[] {5, 1, 512, 3, 3},
            //    new[] {610, 4, 1, 613, 614},
            //    new[] {710, 1, 2, 713, 714},
            //    new[] {810, 1, 2, 1, 1},
            //    new[] {1, 1, 2, 2, 2},
            //    new[] {4, 1, 4, 4, 1014},
            //}).Print();

            //var buf = new char[4];
            //var obj = new Solution.Solution1();
            //obj.Read(buf, 1);
            //obj.Read(buf, 2);
            //obj.Read(buf, 1);

            //sln.NumberToWords(1000).Print();

            //sln.FindItinerary(new List<IList<string>>
            //{
            //    new List<string> {"JFK","SFO"},
            //    new List<string> {"JFK","ATL"},
            //    new List<string> {"SFO","ATL"},
            //    new List<string> {"ATL","JFK"},
            //    new List<string> {"ATL","SFO"},
            //}).Print();

            //sln.ReversePairs(new[] { 2, 4, 3, 5, 1 }).Print();

            //sln.CountSmaller(new[] { 5, 2, 6, 1 }).Print();
            //sln.CountSmaller(new[] { -1, -1 }).Print();

            //sln.CheckInclusion("adc", "dcda").Print();

            //sln.MinWindow("ADOBECODEBANC", "ABC").Print();

            //sln.MinimumTimeRequired(new []{ 1, 2, 4, 7, 8 }, 2).Print();

            //sln.HammingDistance(4, 1);

            //sln.LongestSubstring("ababbc", 2).Print();

            //sln.IsBipartite(new []
            //{
            //    new []{1, 3},
            //    new []{0, 2},
            //    new []{1, 3},
            //    new []{0, 2},
            //}).Print();

            //sln.Divide1(int.MinValue, -2).Print();

            //sln.NumDecodings("226").Print();

            //sln.MaxProfit(new[] {2, 1, 2, 0, 1}).Print();

            //sln.FindKthPositive(new[] { 2 }, 1).Print();
            //sln.FindKthPositive(new[] { 2 }, 2).Print();
            //sln.FindKthPositive(new[] { 2, 4 }, 1).Print();
            //sln.FindKthPositive(new[] { 2, 4 }, 2).Print();
            //sln.FindKthPositive(new []{2, 4}, 3).Print();

            //sln.GetDomain("http://news.yahoo.com").Print();

            //sln.LastStoneWeightII(new[] { 13, 1 }).Print();

            //sln.ShortestDistance(new[]
            //{
            //    new[] {0, 2, 1},
            //    new[] {1, 0, 2},
            //    new[] {0, 1, 0},
            //}).Print();

            //sln.KMPSearch("abcefgabceghab", "abceg").ToList().Print();
            //sln.ComputeLPSArray("AAACAAAA").Print();

            //sln.TupleSameProduct(new[] { 2, 3, 4, 6 }).Print();

            //sln.LargestSubmatrix(new[]
            //{
            //    new []{0, 0, 1},
            //    new []{1, 1, 1},
            //    new []{1, 0, 1},
            //}).Print();

            //sln.IsMatch("aa", "a*").Print();

            //var res = sln.BuildTree(new[] { 9, 3, 15, 20, 7 }, new[] { 9, 15, 7, 20, 3 });

            //sln.ShortestPathBinaryMatrix(new[]
            //{
            //    new[] {0, 0, 0},
            //    new[] {1, 1, 0},
            //    new[] {1, 1, 0},
            //}).Print();

            //sln.MaximumMinimumPath(new[]
            //{
            //    new[] {5, 4, 5},
            //    new[] {1, 2, 6},
            //    new[] {7, 4, 6},
            //}).Print();

            //sln.BuildPostfixExpression("2-3/(5*2)+1").Print();

            //sln.LadderLength("hit", "cog", new List<string> {"hot", "dot", "dog", "lot", "log", "cog"}).Print();

            //sln.CanCross(new[] { 0, 1, 3, 5, 6, 8, 12, 17 }).Print();

            //sln.GetPermutation(3, 4).Print();

            //sln.MinCharacters("dabadd", "cda").Print();
        }

        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                count++;
                n ^= (uint)(n & -n);
            }

            return count;
        }

        public int HammingWeight1(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                count += (n & 1) == 1 ? 1 : 0;
                n >>= 1;
            }

            return count;
        }

        public string ReverseVowels(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
            int low = 0, high = s.Length - 1;

            var sb = new StringBuilder(s);
            while (low < high)
            {
                while (low <= high && !vowels.Contains(char.ToLower(s[low])))
                    low++;
                while (high >= low && !vowels.Contains(char.ToLower(s[high])))
                    high--;
                if (low <= high)
                {
                    var temp = sb[low];
                    sb[low] = sb[high];
                    sb[high] = temp;
                }

                low++;
                high--;
            }

            return sb.ToString();
        }

        public bool RotateString(string A, string B)
        {
            if (string.IsNullOrEmpty(A) && string.IsNullOrEmpty(B))
                return true;
            if (string.IsNullOrEmpty(A) || string.IsNullOrEmpty(B))
                return false;
            if (A.Length != B.Length)
                return false;

            int lowA = 0, lowB = 0;
            while (lowA < A.Length)
            {
                while (lowB < B.Length && B[lowB] != A[lowA])
                    lowB++;

                if (lowB == B.Length) return false;

                int b = lowB;
                while (lowA < A.Length && B[b] == A[lowA])
                    b = (b + 1) % B.Length;
            }

            return lowA == A.Length;
        }

        public int MinCharacters(string a, string b)
        {
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
                return 0;
            if (string.IsNullOrEmpty(a))
                return b.Length;
            if (string.IsNullOrEmpty(b))
                return a.Length;

            return Math.Min(Operation1(a, b), Math.Min(Operation1(b, a), Operation2(a,b)));
        }

        private int Operation1(string a, string b)
        {
            int min = int.MaxValue;
            for (int i = 1; i < 26; i++)
            {
                int count = 0;
                foreach (var ch in a)
                    if(ch - 'a' >= i)
                        count++;
                foreach (var ch in b)
                    if (ch - 'a' < i)
                        count++;

                min = Math.Min(min, count);
            }
            return min;
        }

        private int Operation2(string a, string b)
        {
            var count = new int[26];
            foreach (var ch in a)
                count[ch - 'a']++;
            foreach (var ch in b)
                count[ch - 'a']++;

            return a.Length + b.Length - count.Max();
        }

        public string MaximumTime(string time)
        {
            char h = time[0], hh = time[1], m = time[3], mm = time[4];
            var sb = new StringBuilder(time.Length);

            if (h == '?')
            {
                if (hh == '?' || hh <= '3')
                    sb.Append(2);
                else sb.Append(1);
            }
            else sb.Append(h);

            if (hh == '?')
            {
                if (h == '?' || h == '2')
                    sb.Append(3);
                else sb.Append(9);
            }
            else sb.Append(hh);

            sb.Append(':');

            if (m == '?')
                sb.Append(5);
            else sb.Append(m);

            if (mm == '?')
                sb.Append(9);
            else sb.Append(mm);

            return sb.ToString();
        }

        public string GetPermutation(int n, int k)
        {
            var lst = Enumerable.Range(1, n).ToList();
            var factorials = GetFactorialsUpTo(n);

            k--;
            var sb = new StringBuilder();
            while (n != 0)
            {
                var leftMostItemIndex = k / factorials[n - 1];
                sb.Append(lst[leftMostItemIndex]);

                lst.RemoveAt(leftMostItemIndex);
                k = k % factorials[n - 1];
                n--;
            }

            return sb.ToString();
        }

        private int[] GetFactorialsUpTo(in int n)
        {
            var facts = new int[n + 1];
            facts[0] = 1;
            int i = 1;
            while (i <= n)
            {
                facts[i] = facts[i - 1] * i;
                i++;
            }

            return facts;
        }

        public bool CanCross(int[] stones)
        {
            var dp = new bool?[stones.Length, 2000];
            return CanCrossRec(stones, 0, 0, ref dp);
        }

        private bool CanCrossRec(int[] stones, int idx, int prevJump, ref bool?[,] dp)
        {
            if (idx == stones.Length - 1)
                return true;
            if (idx >= stones.Length)
                return false;

            if (dp[idx, prevJump].HasValue)
                return dp[idx, prevJump].Value;

            var couldReach = false;
            for (int i = prevJump - 1; i <= prevJump + 1; i++)
            {
                var nextStone = stones[idx] + i;
                if (nextStone > stones[idx])
                {
                    var nextIdx = -1;
                    for (int j = idx + 1; j < stones.Length; j++)
                    {
                        if (stones[j] == nextStone)
                        {
                            nextIdx = j;
                            break;
                        }
                        else if (stones[j] > nextStone)
                            break;
                    }

                    if (nextIdx != -1)
                        couldReach |= CanCrossRec(stones, nextIdx, i, ref dp);
                    if (couldReach)
                        break;
                }
            }

            dp[idx, prevJump] = couldReach;
            return couldReach;
        }

        public int[] NextGreaterElements(int[] nums)
        {
            var res = new int[nums.Length];
            var st = new Stack<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = -1;
                while (st.Count > 0 && nums[st.Peek()] < nums[i])
                    res[st.Pop()] = nums[i];
                st.Push(i);
            }

            if (st.Count > 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    while (st.Count > 0 && nums[st.Peek()] < nums[i])
                        res[st.Pop()] = nums[i];
                }
            }
            return res;
        }

        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            var dp = new int?[jobDifficulty.Length, d + 1];
            return MinDifficultyRec(jobDifficulty, 0, d, ref dp);
        }

        private int MinDifficultyRec(int[] jobDifficulty, int idx, int day, ref int?[,] dp)
        {
            if (idx == jobDifficulty.Length)
                return day == 0 ? 0 : -1;
            if (day < 1) return -1;

            if (dp[idx, day].HasValue)
                return dp[idx, day].Value;

            int currentDayDifficulty = int.MinValue;
            int totalDifficulty = int.MaxValue;
            for (int i = idx; i < jobDifficulty.Length; i++)
            {
                currentDayDifficulty = Math.Max(currentDayDifficulty, jobDifficulty[i]);
                var restDifficulty = MinDifficultyRec(jobDifficulty, i + 1, day - 1, ref dp);
                if (restDifficulty != -1)
                {
                    totalDifficulty = Math.Min(totalDifficulty, currentDayDifficulty + restDifficulty);
                }
            }

            dp[idx, day] = totalDifficulty;
            return dp[idx, day].Value;
        }

        public int NumKLenSubstrNoRepeats(string S, int K)
        {
            if (K > S.Length) return 0;
            int count = 0;
            var freq = new int[26];
            for (int i = 0; i < K; i++)
                freq[S[i] - 'a']++;
            if (IsUniqueChars(freq))
                count++;

            for (int i = 0; i < S.Length; i++)
            {
                freq[S[i - K] - 'a']--;
                freq[S[i] - 'a']++;

                if (IsUniqueChars(freq))
                    count++;
            }

            return count;
        }

        private bool IsUniqueChars(int[] freq)
        {
            foreach (var ch in freq)
            {
                if (ch > 1) return false;
            }
            return true;
        }

        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            var times = new int[26];
            int prev = 0;
            for (int i = 0; i < keysPressed.Length; i++)
            {
                var ch = keysPressed[i] - 'a';
                var duration = releaseTimes[i] - prev;
                prev = releaseTimes[i];
                times[ch] = Math.Max(times[ch], duration);
            }

            int max = 0, maxIdx = 0;
            for (int i = 0; i < times.Length; i++)
            {
                if (times[i] >= max)
                {
                    maxIdx = i;
                    max = times[i];
                }
            }

            return (char)('a' + maxIdx);
        }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord)) return 0;
            if (!wordList.Contains(beginWord)) wordList.Add(beginWord);
            if (CanMoveTo(beginWord, endWord))
                return 2;

            var adjList = new Dictionary<string, List<string>>();
            for (int i = 0; i < wordList.Count; i++)
            {
                for (int j = i + 1; j < wordList.Count; j++)
                {
                    string src = wordList[i], dst = wordList[j];
                    if (CanMoveTo(src, dst))
                    {
                        if (!adjList.ContainsKey(src))
                            adjList.Add(src, new List<string>());
                        adjList[src].Add(dst);

                        if (!adjList.ContainsKey(dst))
                            adjList.Add(dst, new List<string>());
                        adjList[dst].Add(src);
                    }
                }
            }

            var q = new Queue<string>();
            q.Enqueue(beginWord);
            var visited = new HashSet<string>();
            visited.Add(beginWord);

            int pathLength = 0;
            while (q.Count > 0)
            {
                pathLength++;
                var qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    var src = q.Dequeue();
                    if (src == endWord)
                        return pathLength;
                    if (adjList.ContainsKey(src))
                    {
                        foreach (var neighbor in adjList[src])
                        {
                            if (!visited.Contains(neighbor))
                            {
                                visited.Add(neighbor);
                                q.Enqueue(neighbor);
                            }
                        }
                    }
                }
            }

            return 0;
        }

        private bool CanMoveTo(string from, string to)
        {
            var foundDiff = false;
            for (int i = 0; i < from.Length; i++)
            {
                if (from[i] != to[i])
                {
                    if (!foundDiff) foundDiff = true;
                    else return false;
                }
            }

            return true;
        }

        private bool CanGoTo(string src, string dst)
        {
            int[] srcCount = new int[26], dstCount = new int[26];
            foreach (var ch in src)
                srcCount[ch - 'a']++;
            foreach (var ch in dst)
                dstCount[ch - 'a']++;
            var canSkip = 2;
            for (int i = 0; i < dstCount.Length; i++)
            {
                if (dstCount[i] != srcCount[i])
                {
                    if (Math.Abs(dstCount[i] - srcCount[i]) > 1)
                        return false;
                    else if (canSkip > 0)
                    {
                        canSkip--;
                    }
                    else return false;
                }
            }
            return true;
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
                return root;

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
                return root;
            if (left == null)
                return right;
            return left;
        }

        public int RomanToInt(string s)
        {
            var romanToInteger = new Dictionary<char, int>
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
                {'C', 100}, {'D', 500}, {'M', 1000}
            };

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && romanToInteger[s[i]] > romanToInteger[s[i - 1]])
                    total -= (romanToInteger[s[i - 1]] * 2);

                total += romanToInteger[s[i]];
            }

            return total;
        }

        public Node ExpTree(string s)
        {
            var inOrder = s.Replace(")", "").Replace("(", "").ToCharArray();
            var postOrder = BuildPostfixExpression(s);
            return BuildTreeNode(inOrder, postOrder);
        }

        private Node BuildTreeNode(char[] inOrder, char[] postOrder)
        {
            int inOrderIdx = inOrder.Length - 1, postOrderIdx = postOrder.Length - 1;
            return BuildTreeNodeRec(inOrder, postOrder, ref inOrderIdx, ref postOrderIdx, int.MinValue);
        }

        private Node BuildTreeNodeRec(char[] inOrder, char[] postOrder, ref int inOrderIdx, ref int postOrderIdx, in int maxValue)
        {
            if (postOrderIdx < 0)
                return null;
            if (inOrder[inOrderIdx] == maxValue)
            {
                inOrderIdx--;
                return null;
            }

            var node = new Node(postOrder[postOrderIdx--]);
            node.right = BuildTreeNodeRec(inOrder, postOrder, ref inOrderIdx, ref postOrderIdx, node.val);
            node.left = BuildTreeNodeRec(inOrder, postOrder, ref inOrderIdx, ref postOrderIdx, maxValue);

            return node;
        }

        public char[] BuildPostfixExpression(string expression)
        {
            var operatorsStack = new Stack<char>();
            var postfixExpression = new List<char>();

            foreach (var component in expression)
            {
                if (component == '(')
                {
                    operatorsStack.Push(component);
                }
                else if (component == ')')
                {
                    while (operatorsStack.Count > 0 && operatorsStack.Peek() != '(')
                        postfixExpression.Add(operatorsStack.Pop());
                    operatorsStack.Pop();
                }
                else if (IsOperator(component))
                {
                    while (operatorsStack.Count > 0 && Precede(operatorsStack.Peek(), component))
                        postfixExpression.Add(operatorsStack.Pop());
                    operatorsStack.Push(component);
                }
                else postfixExpression.Add(component);
            }

            while (operatorsStack.Count > 0)
                postfixExpression.Add(operatorsStack.Pop());

            return postfixExpression.ToArray();
        }

        private bool Precede(char operator1, char operator2)
        {
            if (operator1 == '(') return false;
            if (operator1 == basicOperators[0] || operator1 == basicOperators[1])
                return true;
            if (operator2 == basicOperators[0] || operator2 == basicOperators[1])
                return false;
            return true;
        }

        private char[] basicOperators = { '/', '*', '-', '+' };

        private bool IsOperator(char component)
        {
            return this.basicOperators.Contains(component);
        }

        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root == null) return null;
            root.left = RemoveLeafNodes(root.left, target);
            root.right = RemoveLeafNodes(root.right, target);
            if (root.left == null && root.right == null && root.val == target)
                return null;
            return root;
        }

        public class ParkingSystem
        {
            Dictionary<int, int> spots = new Dictionary<int, int>();

            public ParkingSystem(int big, int medium, int small)
            {
                spots.Add(1, big);
                spots.Add(2, medium);
                spots.Add(3, small);
            }

            public bool AddCar(int carType)
            {
                if (spots[carType] > 0)
                {
                    spots[carType]--;
                    return true;
                }
                return false;
            }
        }


        public string[] Spellchecker(string[] wordlist, string[] queries)
        {
            var exactHS = new HashSet<string>();
            var lowerHS = new Dictionary<string, string>();
            var vowelHS = new Dictionary<string, string>();

            foreach (var word in wordlist)
            {
                exactHS.Add(word);
                var lower = word.ToLower();
                if (!lowerHS.ContainsKey(lower)) lowerHS.Add(lower, word);
                var nonVowels = RemoveVowels(lower);
                if (!vowelHS.ContainsKey(nonVowels)) vowelHS.Add(nonVowels, word);
            }

            var arr = new string[queries.Length];
            int i = 0;
            foreach (var query in queries)
            {
                var ans = string.Empty;
                if (exactHS.Contains(query))
                    ans = query;
                else if (lowerHS.ContainsKey(query.ToLower()))
                    ans = lowerHS[query.ToLower()];
                else if (vowelHS.ContainsKey(RemoveVowels(query.ToLower())))
                    ans = vowelHS[RemoveVowels(query.ToLower())];
                arr[i++] = ans;
            }

            return arr;
        }

        private string RemoveVowels(string query)
        {
            var sb = new StringBuilder(query.Length);
            foreach (var ch in query)
                sb.Append(IsVowel(ch) ? '*' : ch);
            return sb.ToString();
        }

        private bool IsVowel(in char ch)
        {
            var vowels = new int[] { 'a', 'e', 'i', 'o', 'u' };
            return vowels.Contains(ch);
        }

        public int KSimilarity(string A, string B)
        {
            char[] a = A.ToCharArray(), b = B.ToCharArray();
            var q = new Queue<string>();
            q.Enqueue(A);
            var path = new Dictionary<string, int>();
            path.Add(A, 0);
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                if (node == B)
                    return path[node];

                var neighbors = GetANeighbors(node.ToCharArray(), b);

                foreach (var neighbor in neighbors)
                {
                    if (!path.ContainsKey(neighbor))
                    {
                        path.Add(neighbor, path[node] + 1);
                        q.Enqueue(neighbor);
                    }
                }
            }

            return -1;
        }

        private List<string> GetANeighbors(char[] a, char[] b)
        {
            int i = 0;
            for (; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    break;
            }

            var neighbors = new List<string>();
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] == b[i])
                {
                    SwapArray(a, i, j);
                    neighbors.Add(new string(a));
                    SwapArray(a, i, j);
                }
            }

            return neighbors;
        }

        private void SwapArray(char[] arr, int i, in int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null)
                return new List<double>();
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var lst = new List<double>();

            while (q.Count > 0)
            {
                var levelCount = q.Count;
                long sum = 0;
                for (int i = 0; i < levelCount; i++)
                {
                    var node = q.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }

                lst.Add(sum / (double)levelCount);
            }

            return lst;
        }

        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var dp = new List<string>[s.Length];
            return WordBreakRec(s, 0, wordDict.ToHashSet(), ref dp);
        }

        private List<string> WordBreakRec(string s, int i, HashSet<string> words, ref List<string>[] dp)
        {
            if (i == s.Length)
                return new List<string> { "" };
            if (dp[i] != null)
                return dp[i];

            var sb = new StringBuilder();
            var currentPath = new List<string>();
            for (int j = i; j < s.Length; j++)
            {
                sb.Append(s[j]);
                var word = sb.ToString();
                if (words.Contains(word))
                {
                    var restPath = WordBreakRec(s, j + 1, words, ref dp);
                    foreach (var path in restPath)
                    {
                        var statement = word;
                        if (path != string.Empty)
                            statement += " " + path;
                        currentPath.Add(statement);
                    }
                }
            }

            dp[i] = currentPath;

            return currentPath;
        }

        public bool WordBreak1(string s, IList<string> wordDict)
        {
            var dp = new bool?[s.Length];
            return WordBreakRec(s, 0, wordDict.ToHashSet(), ref dp);
        }

        private bool WordBreakRec(string s, int i, HashSet<string> words, ref bool?[] dp)
        {
            if (i == s.Length)
                return true;
            if (dp[i].HasValue)
                return dp[i].Value;

            var sb = new StringBuilder();
            var canConstruct = false;
            for (int j = i; j < s.Length; j++)
            {
                sb.Append(s[j]);
                if (words.Contains(sb.ToString()) && WordBreakRec(s, j + 1, words, ref dp))
                {
                    canConstruct = true;
                    break;
                }
            }

            dp[i] = canConstruct;

            return canConstruct;
        }

        public int SnakesAndLadders(int[][] board)
        {
            int rows = board.Length, cols = board[0].Length;
            var memo = new Dictionary<int, int>();
            var q = new Queue<int>();
            q.Enqueue(1);
            memo.Add(1, 0);
            int dst = rows * cols;
            while (q.Count > 0)
            {
                var src = q.Dequeue();
                if (src == dst)
                    return memo[src];
                for (int i = src + 1; i <= Math.Min(src + 6, rows * cols); i++)
                {
                    var (nx, ny) = GetCellIndexes(rows, cols, i);
                    var neighbor = board[nx][ny] != -1 ? board[nx][ny] : i;

                    if (!memo.ContainsKey(neighbor))
                    {
                        memo[neighbor] = memo[src] + 1;
                        q.Enqueue(neighbor);
                    }
                }
            }

            return -1;
        }

        private (int x, int y) GetCellIndexes(int rows, int cols, int i)
        {
            i--;
            var x = rows - (i / cols) - 1;
            var isIncreasing = (rows - x) % 2 == 1;
            var y = isIncreasing ? (i % cols) : (cols - (i % cols) - 1);
            return (x, y);
        }

        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return false;

            var q1 = new Queue<TreeNode>();
            var q2 = new Queue<TreeNode>();

            q1.Enqueue(root.left);
            q2.Enqueue(root.right);

            while (q2.Count > 0)
            {
                var node1 = q1.Count > 0 ? q1.Dequeue() : null;
                var node2 = q2.Count > 0 ? q2.Dequeue() : null;

                if (node1?.val != node2?.val)
                    return false;

                if (node1 != null)
                {
                    q1.Enqueue(node1.left);
                    q1.Enqueue(node1.right);
                }

                if (node2 != null)
                {
                    q2.Enqueue(node2.right);
                    q2.Enqueue(node2.left);
                }
            }

            return q1.Count == 0;
        }

        public bool IsSymmetric1(TreeNode root)
        {
            if (root == null) return false;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var level = new List<int>();

            TreeNode node = null;
            while (q.Count > 0)
            {
                var levelCount = q.Count;
                level.Clear();
                for (int i = 0; i < levelCount; i++)
                {
                    node = q.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }

                if (node != root && !IsPalindromeLevel(level))
                    return false;
            }

            return true;
        }

        private bool IsPalindromeLevel(List<int> level)
        {
            int low = 0, high = level.Count;
            while (low < high)
            {
                if (level[low] != level[high])
                    return false;
                low++;
                high++;
            }

            return true;
        }

        public int MaximumMinimumPath(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return -1;
            var directions = new[]
            {
                new[] {-1, 0}, new[] {1, 0}, new[] {0, 1}, new[] {0, -1},
            };
            int max = int.MinValue;

            var q = new Queue<(int x, int y, int minSoFar)>();
            q.Enqueue((0, 0, grid[0][0]));
            var visited = new HashSet<(int sx, int sy, int dx, int dy)>();
            while (q.Count > 0)
            {
                var src = q.Dequeue();
                if (src.x == grid.Length - 1 && src.y == grid[0].Length - 1)
                    max = Math.Max(src.minSoFar, max);

                foreach (var direction in directions)
                {
                    int newX = src.x + direction[0], newY = src.y + direction[1];
                    if (newX >= 0 && newX < grid.Length && newY >= 0 && newY < grid[0].Length &&
                        !visited.Contains((src.x, src.y, newX, newY)))
                    {
                        visited.Add((src.x, src.y, newX, newY));
                        q.Enqueue((newX, newY, Math.Min(src.minSoFar, grid[newX][newY])));
                    }
                }
            }

            return max;
        }

        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return -1;
            if (grid[0][0] == 1 || grid[grid.Length - 1][grid[0].Length - 1] == 1) return -1;
            var directions = new[]
            {
                new[] {-1, 0}, new[] {1, 0}, new[] {0, 1}, new[] {0, -1},
                new[] {-1, -1}, new[] {-1, 1}, new[] {1, -1}, new[] {1, 1},
            };
            var q = new Queue<(int x, int y, int cost)>();
            q.Enqueue((0, 0, 1));
            var visited = new HashSet<(int x, int y)>();
            visited.Add((0, 0));
            while (q.Count > 0)
            {
                var src = q.Dequeue();
                if (src.x == grid.Length - 1 && src.y == grid[0].Length - 1)
                    return src.cost;

                foreach (var direction in directions)
                {
                    int newX = src.x + direction[0], newY = src.y + direction[1];
                    if (newX >= 0 && newX < grid.Length && newY >= 0 && newY < grid[0].Length &&
                        grid[newX][newY] != 1 && !visited.Contains((newX, newY)))
                    {
                        visited.Add((newX, newY));
                        q.Enqueue((newX, newY, src.cost + 1));
                    }
                }
            }

            return -1;
        }

        public void GameOfLife(int[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    int liveNeighbors = CountLiveNeighbors(board, i, j);
                    if (board[i][j] == 1)
                    {
                        if (liveNeighbors < 2)
                        {
                            board[i][j] = -1;
                        }
                        else if (liveNeighbors > 3)
                        {
                            board[i][j] = -1;
                        }
                    }
                    else if (liveNeighbors == 3)
                    {
                        board[i][j] = -2;
                    }
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == -1)
                        board[i][j] = 0;
                    else if (board[i][j] == -2)
                        board[i][j] = 1;
                }
            }
        }

        private int CountLiveNeighbors(int[][] board, in int x, in int y)
        {
            var directions = new[]
            {
                new[] {-1, 0}, new[] {1, 0}, new[] {0, 1}, new[] {0, -1},
                new[] {-1, -1}, new[] {-1, 1}, new[] {1, -1}, new[] {1, 1},
            };
            int liveNeighbors = 0;
            foreach (var direction in directions)
            {
                int newX = x + direction[0], newY = y + direction[1];
                if (newX >= 0 && newX < board.Length && newY >= 0 && newY < board[0].Length &&
                    Math.Abs(board[newX][newY]) == 1)
                    liveNeighbors++;
            }

            return liveNeighbors;
        }

        public string MinWindow(string S, string T)
        {
            if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(T))
                return string.Empty;
            int left = -1, minLengh = int.MaxValue;
            int low = 0, high = 0, tIdx = 0;
            while (high < S.Length)
            {
                if (S[high] == T[tIdx])
                    tIdx++;
                if (tIdx == T.Length)
                {
                    while (low < high && S[low] != T[0])
                        low++;
                    if (minLengh > high - low + 1)
                    {
                        minLengh = high - low + 1;
                        left = low;
                    }

                    tIdx = 0;
                    high = low;
                    low++;
                }
                high++;
            }

            return minLengh == int.MaxValue ? string.Empty : S.Substring(left, minLengh);
        }

        public string MinWindow_WrongAsummption(string S, string T)
        {
            if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(T))
                return string.Empty;
            int left = -1, minLengh = int.MaxValue;

            var freqDic = new Dictionary<int, int>();
            foreach (var ch in T)
            {
                if (!freqDic.ContainsKey(ch))
                    freqDic.Add(ch, 0);
                freqDic[ch]++;
            }

            int low = 0, high = 0, matched = 0;
            while (high < S.Length)
            {
                var ch = S[high];
                if (freqDic.ContainsKey(ch))
                {
                    freqDic[ch]--;
                    if (freqDic[ch] == 0)
                        matched++;
                }

                while (low < high && matched == freqDic.Keys.Count)
                {
                    if (minLengh > high - low + 1)
                    {
                        minLengh = high - low + 1;
                        left = low;
                    }

                    ch = S[low];
                    if (freqDic.ContainsKey(ch))
                    {
                        if (freqDic[ch] == 0) matched--;
                        freqDic[ch]++;
                    }
                    low++;
                }
                high++;
            }

            return minLengh == int.MaxValue ? string.Empty : S.Substring(left, minLengh);
        }


        /*
            inorder = [9,3,15,20,7]
            postorder = [9,15,7,20,3]
            Return the following binary tree:

                3
               / \
              9  20
                /  \
               15   7
         */
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            int n = postorder.Length - 1;
            int inorderIndex = inorder.Length - 1;
            return BuildTreeRec(inorder, postorder, ref n, ref inorderIndex, int.MinValue);
        }

        private TreeNode BuildTreeRec(int[] inorder, int[] postorder, ref int n, ref int inOrderIndex, in int maxValue)
        {
            if (n < 0) return null;
            if (inorder[inOrderIndex] == maxValue)
            {
                inOrderIndex--;
                return null;
            }

            var node = new TreeNode(postorder[n--]);
            node.right = BuildTreeRec(inorder, postorder, ref n, ref inOrderIndex, node.val);
            node.left = BuildTreeRec(inorder, postorder, ref n, ref inOrderIndex, maxValue);
            return node;
        }

        public enum ColorEnum
        {
            None,
            Red,
            Blue
        }

        public class DirectedEdge
        {
            public int dst;
            public ColorEnum color;
        }

        public int[] ShortestAlternatingPaths(int n, int[][] red_edges, int[][] blue_edges)
        {
            var adjList = new Dictionary<int, List<DirectedEdge>>();
            foreach (var redEdge in red_edges)
            {
                int src = redEdge[0], dst = redEdge[1];
                if (!adjList.ContainsKey(src))
                    adjList.Add(src, new List<DirectedEdge>());
                adjList[src].Add(new DirectedEdge { color = ColorEnum.Red, dst = dst });
            }

            foreach (var blueEdge in blue_edges)
            {
                int src = blueEdge[0], dst = blueEdge[1];
                if (!adjList.ContainsKey(src))
                    adjList.Add(src, new List<DirectedEdge>());
                adjList[src].Add(new DirectedEdge { color = ColorEnum.Blue, dst = dst });
            }

            var dist = new int[n];
            Array.Fill(dist, int.MaxValue);
            dist[0] = 0;

            var q = new Queue<(int src, ColorEnum prevColor, int PrevPathLength)>();
            q.Enqueue((0, ColorEnum.None, 0));

            var visited = new HashSet<(int src, int dst, ColorEnum color)>();
            while (q.Count > 0)
            {
                var node = q.Dequeue();

                if (adjList.ContainsKey(node.src))
                    foreach (var directedEdge in adjList[node.src])
                    {
                        if (!visited.Contains((node.src, directedEdge.dst, directedEdge.color)) && directedEdge.color != node.prevColor)
                        {
                            visited.Add((node.src, directedEdge.dst, directedEdge.color));
                            dist[directedEdge.dst] = Math.Min(dist[directedEdge.dst], node.PrevPathLength + 1);
                            q.Enqueue((directedEdge.dst, directedEdge.color, node.PrevPathLength + 1));
                        }
                    }
            }

            for (int i = 0; i < dist.Length; i++)
            {
                if (dist[i] == int.MaxValue)
                    dist[i] = -1;
            }

            return dist;
        }

        public bool IsMatch(string s, string p)
        {
            var dp = new bool?[s.Length, p.Length];
            return IsMatchRec(s, p, 0, 0, ref dp);
        }

        private bool IsMatchRec(string s, string p, int si, int pi, ref bool?[,] dp)
        {
            if (p.Length == pi) return si == s.Length;

            if (dp[si, pi].HasValue) return dp[si, pi].Value;

            var isMatch = s[si] == p[pi] || p[pi] == '.';

            var ans = false;
            if (pi < p.Length - 1 && p[pi + 1] == '*')
            {
                ans = (isMatch && IsMatchRec(s, p, si + 1, pi, ref dp)) || IsMatchRec(s, p, si, pi + 2, ref dp);
            }
            else
            {
                ans = IsMatchRec(s, p, si + 1, pi + 1, ref dp);
            }

            dp[si, pi] = ans;
            return ans;
        }

        public class Codec
        {
            // Encodes a tree to a single string.
            public string serialize(TreeNode root)
            {
                var q = new Queue<TreeNode>();
                q.Enqueue(root);

                var sb = new StringBuilder();
                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    sb.Append((node == null ? "null" : node.val.ToString()) + ",");
                    if (node != null)
                    {
                        q.Enqueue(node.left);
                        q.Enqueue(node.right);
                    }
                }

                sb.Length--;
                return sb.ToString();
            }

            // Decodes your encoded data to tree.
            public TreeNode deserialize(string data)
            {
                if (data == "null") return null;
                var nodes = data.Split(',');
                var root = new TreeNode(int.Parse(nodes[0]));
                var q = new Queue<TreeNode>();
                q.Enqueue(root);
                for (int i = 1; i < nodes.Length; i += 2)
                {
                    var parent = q.Dequeue();
                    if (nodes[i] != "null")
                    {
                        parent.left = new TreeNode(int.Parse(nodes[i]));
                        q.Enqueue(parent.left);
                    }

                    if (nodes[i + 1] != "null")
                    {
                        parent.right = new TreeNode(int.Parse(nodes[i + 1]));
                        q.Enqueue(parent.right);
                    }
                }

                return root;
            }
        }

        public int LeastInterval(char[] tasks, int n)
        {
            if (n == 0 || tasks.Length == 0) return tasks.Length;

            var arr = new int[26];
            foreach (var task in tasks)
                arr[task - 'A']++;
            Array.Sort(arr, (a, b) => b - a);

            int emptySlots = arr[0] - 1;
            int emptySlotsSize = n * emptySlots;

            for (int i = 1; i < arr.Length; i++)
            {
                emptySlotsSize -= Math.Min(emptySlots, arr[i]);
            }

            emptySlotsSize = Math.Max(0, emptySlotsSize);

            return tasks.Length + emptySlotsSize;
        }

        public string AddBinary(string a, string b)
        {
            var maxLegth = a.Length < b.Length ? b.Length : a.Length;
            var sb = new StringBuilder(maxLegth + 1);
            int pos1 = a.Length - 1, pos2 = b.Length - 1;

            int carry = 0;
            while (pos1 >= 0 || pos2 >= 0)
            {
                int num1 = pos1 >= 0 ? a[pos1] - '0' : 0;
                int num2 = pos2 >= 0 ? b[pos2] - '0' : 0;
                int sum = num1 + num2 + carry;
                sb.Append(sum % 2);
                carry = sum / 2;

                pos2--;
                pos1--;
            }

            if (carry > 0)
                sb.Append(carry);

            return new string(sb.ToString().Reverse().ToArray());
        }

        public class MSPDSU
        {
            int[] parents;

            public MSPDSU(int N)
            {
                parents = new int[N + 1];
                for (var i = 0; i < parents.Length; i++)
                {
                    parents[i] = i;
                }
            }

            public void Union(int a, int b)
            {
                int aParent = Find(a), bParent = Find(b);
                if (aParent == bParent) return;

                parents[aParent] = bParent;
            }

            public int Find(int a)
            {
                if (parents[a] != a) parents[a] = Find(parents[a]);
                return parents[a];
            }

            public bool IsSameGroup(int a, int b)
            {
                return Find(a) == Find(b);
            }
        }

        public int MinCostToSupplyWater(int n, int[] wells, int[][] pipes)
        {
            int maxVirtualNode = 10_001;
            var edges = new List<(int src, int dst, int cost)>();
            foreach (var pipe in pipes)
            {
                edges.Add((pipe[0], pipe[1], pipe[2]));
            }

            for (int i = 0; i < wells.Length; i++)
            {
                edges.Add((i + 1, maxVirtualNode, wells[i]));
            }

            edges.Sort((edge1, edge2) => edge1.cost - edge2.cost);

            var totalCost = 0;
            var dsu = new MSPDSU(maxVirtualNode);
            foreach (var edge in edges)
            {
                if (!dsu.IsSameGroup(edge.src, edge.dst))
                {
                    dsu.Union(edge.src, edge.dst);
                    totalCost += edge.cost;
                }
            }

            return totalCost;
        }

        public int[][] ReconstructQueue(int[][] people)
        {
            Array.Sort(people, (person1, person2) =>
            {
                if (person1[0] == person2[0])
                    return person1[1] - person2[1];
                return person2[0] - person1[0];
            });

            var lst = new List<int[]>();
            foreach (var person in people)
            {
                lst.Insert(person[1], person);
            }

            return lst.ToArray();
        }

        public string LongestWord(string[] words)
        {
            Array.Sort(words, (s1, s2) =>
            {
                if (s1.Length == s2.Length)
                    return s2.CompareTo(s1);
                return s1.Length - s2.Length;
            });

            var hs = new HashSet<string>();
            string validOption = string.Empty;
            var sb = new StringBuilder(words[words.Length - 1]);
            foreach (var word in words)
            {
                sb.Clear();
                bool isValidOption = true;
                for (int i = 0; i < word.Length - 1; i++)
                {
                    sb.Append(word[i]);
                    if (!hs.Contains(sb.ToString()))
                    {
                        isValidOption = false;
                        break;
                    }
                }

                hs.Add(word);
                if (isValidOption)
                    validOption = word;
            }

            return validOption;
        }

        public string LongestPrefix(string s)
        {
            int n = s.Length;
            var lcp = new int[n];
            int len = 0, i = 1;
            while (i < n)
            {
                if (s[i] == s[len])
                {
                    len++;
                    lcp[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lcp[len - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            var longestPrefixMatchLen = lcp[n - 1];
            return s.Substring(n - longestPrefixMatchLen, longestPrefixMatchLen);
        }

        public int LargestSubmatrix(int[][] matrix)
        {
            int rows = matrix.Length, cols = matrix[0].Length;

            int max = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int window = 2; window <= cols; window++)
                {
                    var mask = new int[rows];
                    Array.Fill(mask, 1);
                    int currWindow = 1;
                    for (int j = i; j < Math.Min(i + window, cols); j++)
                    {
                        for (int k = 0; k < rows; k++)
                            mask[k] = (mask[k] & matrix[k][j]);

                        max = Math.Max(max, mask.Sum() * currWindow);
                        currWindow++;
                    }
                }
            }

            return max;
        }

        public int TupleSameProduct(int[] nums)
        {
            int sum = 0;
            var dic = new Dictionary<long, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    var mul = nums[i] * nums[j];
                    if (!dic.ContainsKey(mul))
                        dic.Add(mul, 1);
                    else
                    {
                        sum += 8 * dic[mul];
                        dic[mul]++;
                    }
                }
            }
            return sum;
        }

        public int CountGoodRectangles(int[][] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0) return 0;
            var dic = new Dictionary<int, int>();
            int maxSquare = 0;
            foreach (var rectangle in rectangles)
            {
                var square = Math.Min(rectangle[0], rectangle[1]);
                if (!dic.ContainsKey(square))
                    dic.Add(square, 0);
                dic[square]++;
                maxSquare = Math.Max(maxSquare, square);
            }

            return dic[maxSquare];
        }

        public IEnumerable<int> KMPSearch(string txt, string pattern)
        {
            int M = pattern.Length;
            int N = txt.Length;

            // create lps[] that will hold the longest 
            // prefix suffix values for pattern 
            var lps = ComputeLPSArray(pattern);

            int j = 0; // index for pattern[] 
            int i = 0; // index for txt[] 
            while (i < N)
            {
                if (txt[i] == pattern[j])
                {
                    j++;
                    i++;

                    if (j == M)
                    {
                        yield return i - M;
                        Console.WriteLine("Found pattern at index " + (i - j));
                        j = lps[j - 1];
                    }
                }
                // mismatch after j matches 
                else
                {
                    // Do not match lps[0..lps[j-1]] characters, 
                    // they will match anyway 
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i++;
                }
            }

            //yield return -1;
        }

        public int[] ComputeLPSArray(string pattern)
        {
            int M = pattern.Length;
            int[] lps = new int[M];
            // length of the previous longest prefix suffix 
            int len = 0;
            int i = 1;
            lps[0] = 0; // lps[0] is always 0 

            // the loop calculates lps[i] for i = 1 to M-1 
            while (i < M)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else // (pat[i] != pat[len]) 
                {
                    // This is tricky. Consider the example. 
                    // AAACAAAA and i = 7. The idea is similar 
                    // to search step. 
                    if (len != 0)
                    {
                        len = lps[len - 1];

                        // Also, note that we do not increment 
                        // i here 
                    }
                    else // if (len == 0) 
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }

            return lps;
        }


        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if (n == 0) return new List<int>();
            if (n == 1) return new List<int> { 0 };
            var graph = new Dictionary<int, List<int>>();
            var inDegrees = new Dictionary<int, int>();
            foreach (var edge in edges)
            {
                var (src, dst) = (edge[0], edge[1]);
                if (!graph.ContainsKey(src))
                    graph.Add(src, new List<int>());
                if (!graph.ContainsKey(dst))
                    graph.Add(dst, new List<int>());
                graph[src].Add(dst);
                graph[dst].Add(src);

                if (!inDegrees.ContainsKey(src))
                    inDegrees.Add(src, 0);
                if (!inDegrees.ContainsKey(dst))
                    inDegrees.Add(dst, 0);
                inDegrees[src]++;
                inDegrees[dst]++;
            }

            var q = new Queue<int>();
            foreach (var inDegree in inDegrees)
            {
                if (inDegree.Value == 1)
                    q.Enqueue(inDegree.Key);
            }

            while (n > 2)
            {
                var qCount = q.Count;
                n -= qCount;
                for (int i = 0; i < qCount; i++)
                {
                    var node = q.Dequeue();
                    foreach (var dst in graph[node])
                    {
                        inDegrees[dst]--;
                        if (inDegrees[dst] == 1)
                            q.Enqueue(dst);
                    }
                }
            }

            return q.ToArray();
        }

        public bool SequenceReconstruction(int[] org, IList<IList<int>> seqs)
        {
            var graph = new Dictionary<int, List<int>>();
            var inDegrees = new Dictionary<int, int>();
            foreach (var seq in seqs)
            {
                for (int i = 0; i < seq.Count; i++)
                {
                    int child = seq[i];
                    if (!graph.ContainsKey(child))
                        graph.Add(child, new List<int>());

                    if (!inDegrees.ContainsKey(child))
                        inDegrees.Add(child, 0);
                }

                for (int i = 0; i < seq.Count - 1; i++)
                {
                    int parent = seq[i], child = seq[i + 1];
                    if (!graph.ContainsKey(parent))
                        graph.Add(parent, new List<int>());
                    graph[parent].Add(child);

                    if (!inDegrees.ContainsKey(parent))
                        inDegrees.Add(parent, 0);
                    inDegrees[child]++;
                }
            }

            if (inDegrees.Count != org.Length) return false;

            var q = new Queue<int>();
            foreach (var inDegree in inDegrees)
            {
                if (inDegree.Value == 0)
                    q.Enqueue(inDegree.Key);
            }

            var orderIndex = 0;
            while (q.Count > 0)
            {
                if (q.Count > 1) return false;
                var node = q.Dequeue();
                if (orderIndex >= org.Length || node != org[orderIndex++]) return false;

                foreach (var child in graph[node])
                {
                    inDegrees[child]--;
                    if (inDegrees[child] == 0)
                        q.Enqueue(child);
                }
            }

            return orderIndex == org.Length;
        }

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var paths = new List<IList<int>>();
            AllPathsSourceTargetRec(graph, 0, graph.Length - 1, new List<int>(), ref paths);
            return paths;
        }

        private void AllPathsSourceTargetRec(int[][] graph, int start, int end, List<int> path, ref List<IList<int>> paths)
        {
            path.Add(start);
            if (start == end)
            {
                paths.Add(new List<int>(path));
            }
            else
            {
                foreach (var child in graph[start])
                {
                    AllPathsSourceTargetRec(graph, child, end, path, ref paths);
                }
            }
            path.RemoveAt(path.Count - 1);
        }

        public int ShortestDistance(int[][] grid)
        {
            var directions = new[] { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };
            int rows = grid.Length, cols = grid[0].Length, buildingsCount = 0;
            var canReach = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        buildingsCount++;

                        var visited = new HashSet<(int x, int y)>();
                        var q = new Queue<(int x, int y)>();
                        q.Enqueue((i, j));
                        int distance = 0;
                        while (q.Count > 0)
                        {
                            distance--;
                            var qCount = q.Count;
                            for (int k = 0; k < qCount; k++)
                            {
                                var (x, y) = q.Dequeue();
                                foreach (var direction in directions)
                                {
                                    int newX = x + direction[0], newY = y + direction[1];
                                    if (newX >= 0 && newX < rows && newY >= 0 && newY < cols && grid[newX][newY] != 1 && grid[newX][newY] != 2 && !visited.Contains((newX, newY)))
                                    {
                                        visited.Add((newX, newY));
                                        grid[newX][newY] += distance;
                                        q.Enqueue((newX, newY));
                                        canReach[newX, newY]++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            int min = int.MaxValue;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (canReach[i, j] == buildingsCount)
                        min = Math.Min(min, -grid[i][j]);
                }
            }

            return min == int.MaxValue ? -1 : min;
        }

        public Node TreeToDoublyList(Node root)
        {
            if (root == null) return root;
            var st = new Stack<Node>();
            AddToStack(st, root);
            var minNode = st.Peek();
            Node prev = null;

            while (st.Count > 0)
            {
                var node = st.Pop();
                node.left = prev;
                if (prev != null)
                    prev.right = node;
                AddToStack(st, node.right);
                prev = node;
            }

            prev.right = minNode;
            minNode.left = prev;

            return minNode;
        }

        private void AddToStack(Stack<Node> st, Node root)
        {
            while (root != null)
            {
                st.Push(root);
                root = root.left;
            }
        }

        public int[][] Multiply(int[][] A, int[][] B)
        {
            var result = new int[A.Length][];
            for (int i = 0; i < A.Length; i++)
                result[i] = new int[B[0].Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B[0].Length; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < B.Length; k++)
                        sum += A[i][k] * B[k][j];
                    result[i][j] = sum;
                }
            }

            return result;
        }

        public bool IsStrobogrammatic(string num)
        {
            if (string.IsNullOrEmpty(num)) return true;
            var dic = new Dictionary<char, char>
            {
                {'1', '1'},
                {'6', '9'},
                {'8', '8'},
                {'9', '6'},
                {'0', '0'},
            };
            var singles = new List<char> { '0', '1', '8' };

            int low = 0, high = num.Length - 1;

            while (low <= high)
            {
                if (low == high) return singles.Contains(num[low]);
                char left = num[low], right = num[high];
                if (!dic.ContainsKey(left) || !dic.ContainsKey(right) || dic[left] != right) return false;
                low++;
                high--;
            }

            return true;
        }

        public int LastStoneWeightII(int[] stones)
        {
            if (stones == null || stones.Length == 0) return 0;
            Array.Sort(stones);
            var totalSum = stones.Sum();
            var half = totalSum / 2 + 1;
            var dp = new bool[stones.Length, half];

            for (int i = 0; i < stones.Length; i++)
                dp[i, 0] = true;

            for (int sum = 1; sum < half; sum++)
                dp[0, sum] = stones[0] == sum;

            for (int i = 1; i < stones.Length; i++)
            {
                for (int sum = 1; sum < half; sum++)
                {
                    dp[i, sum] = dp[i - 1, sum] || (sum >= stones[i] && dp[i - 1, sum - stones[i]]);
                }
            }

            var acheived = 0;
            for (int sum = half - 1; sum >= 0; sum--)
            {
                if (dp[stones.Length - 1, sum])
                {
                    acheived = sum;
                    break;
                }
            }

            return Math.Abs(acheived - (totalSum - acheived));
        }

        public int NumWays(int steps, int arrLen)
        {
            var maxRightMove = Math.Min(steps, arrLen);
            var dp = new long[steps + 1, maxRightMove + 1];

            dp[1, 0] = 1;
            dp[1, 1] = 1;

            for (int step = 2; step <= steps; step++)
            {
                for (int pos = 0; pos < maxRightMove; pos++)
                {
                    dp[step, pos] = (dp[step - 1, pos] + dp[step - 1, pos + 1] + (pos > 0 ? dp[step - 1, pos - 1] : 0)) % modulo;
                }
            }

            return (int)dp[steps, 0];
        }

        public class HtmlParser
        {
            public List<String> GetUrls(String url) { return new List<string>(); }
        }

        public IList<string> Crawl(string startUrl, HtmlParser htmlParser)
        {
            var visited = new HashSet<string>();
            visited.Add(startUrl);
            CrawlRec(startUrl, htmlParser, visited);
            return visited.ToList();
        }

        private void CrawlRec(string startUrl, HtmlParser htmlParser, HashSet<string> visited)
        {
            var domain = GetDomain(startUrl);
            var children = htmlParser.GetUrls(startUrl);
            var tasks = new List<Task>();
            foreach (var childUrl in children)
            {
                if (GetDomain(childUrl) == domain && !visited.Contains(childUrl))
                {
                    visited.Add(childUrl);
                    tasks.Add(Task.Factory.StartNew(() => CrawlRec(childUrl, htmlParser, visited)));
                }
            }

            Task.WaitAll(tasks.ToArray());
        }

        public string GetDomain(string url)
        {
            var firstSlashes = url.IndexOf("//");
            var secondSlash = url.IndexOf("/", firstSlashes + 2);
            if (secondSlash == -1) secondSlash = url.Length;
            return url.Substring(firstSlashes + 2, secondSlash - firstSlashes - 2);
        }

        public int GetMissing(int[] arr, int idx)
        {
            return arr[idx] - idx - 1;
        }

        public int FindKthPositive(int[] arr, int k)
        {
            int n = arr.Length;
            if (GetMissing(arr, n - 1) < k) return arr[n - 1] + k - GetMissing(arr, n - 1);
            if (GetMissing(arr, 0) >= k) return k;

            int low = 0, high = n, missing;

            while (low != high)
            {
                var mid = low + (high - low) / 2;
                missing = GetMissing(arr, mid);
                if (missing < k)
                    low = mid + 1;
                else high = mid;
            }

            return arr[low - 1] + k - GetMissing(arr, low - 1);
        }

        public int MaxProfit(int[] prices)
        {
            int profit = 0, buy = int.MaxValue;
            foreach (var price in prices)
            {
                buy = Math.Min(buy, price);
                profit = Math.Max(profit, price - buy);
            }

            return profit;
        }

        public int MaxProfit(int k, int[] prices)
        {
            if (prices == null || prices.Length <= 1) return 0;
            if (k > prices.Length / 2) return MaxProfit_UnLimited(prices);

            int[] buy = new int[k + 1], profit = new int[k + 1];
            Array.Fill(buy, int.MaxValue);
            foreach (var price in prices)
            {
                for (int i = 1; i <= k; i++)
                {
                    buy[i] = Math.Min(buy[i], price - profit[i - 1]);
                    profit[i] = Math.Max(profit[i], price - buy[i]);
                }
            }

            return profit[k];
        }

        private int MaxProfit_UnLimited(int[] prices)
        {
            int totalProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                totalProfit += Math.Max(0, prices[i] - prices[i - 1]);
            }

            return totalProfit;
        }

        public int MaxProfit_2TransactionsMax(int[] prices)
        {
            int buy1 = int.MaxValue, buy2 = int.MaxValue;
            int profit1 = 0, profit2 = 0;

            foreach (var price in prices)
            {
                buy1 = Math.Min(buy1, price);
                profit1 = Math.Max(profit1, price - buy1);
                buy2 = Math.Min(buy2, price - profit1);
                profit2 = Math.Max(profit2, price - buy2);
            }

            return profit2;
            //int maxTransactions = 2;
            //var dp = new int?[prices.Length, maxTransactions + 1];
            //return MaxProfitRec(prices, 0, maxTransactions, ref dp);
        }

        private int MaxProfitRec(int[] prices, int i, in int maxTransactions, ref int?[,] dp)
        {
            if (i == prices.Length || maxTransactions == 0)
                return 0;

            if (dp[i, maxTransactions].HasValue) return dp[i, maxTransactions].Value;

            int includeOption = 0;
            for (int sellAt = i + 1; sellAt < prices.Length; sellAt++)
            {
                if (prices[sellAt] > prices[i])
                {
                    var profit = prices[sellAt] - prices[i] +
                                 MaxProfitRec(prices, sellAt + 1, maxTransactions - 1, ref dp);
                    includeOption = Math.Max(includeOption, profit);
                }
            }

            var excludeOption = MaxProfitRec(prices, i + 1, maxTransactions, ref dp);

            dp[i, maxTransactions] = Math.Max(includeOption, excludeOption);

            return dp[i, maxTransactions].Value;
        }

        public int MaxProfit_1Transaction(int[] prices)
        {
            if (prices == null || prices.Length <= 1) return 0;
            int min = prices[0], max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                max = Math.Max(max, prices[i] - min);
                if (prices[i] < min)
                    min = prices[i];
            }

            return max;
        }

        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var emailToIds = new Dictionary<string, int>();
            var emailToName = new Dictionary<string, string>();
            int emailId = 0;
            var dsuArr = new int[10000];
            for (int i = 0; i < dsuArr.Length; i++)
                dsuArr[i] = i;

            foreach (var accountEmails in accounts)
            {
                var name = "";
                foreach (var accountEmail in accountEmails)
                {
                    if (name == "")
                    {
                        name = accountEmail;
                        continue;
                    }

                    if (!emailToName.ContainsKey(accountEmail))
                        emailToName.Add(accountEmail, name);
                    if (!emailToIds.ContainsKey(accountEmail))
                        emailToIds.Add(accountEmail, emailId++);

                    Union(dsuArr, emailToIds[accountEmail], emailToIds[accountEmails[1]]);
                }
            }

            var parentToEmails = new Dictionary<int, List<string>>();
            foreach (var emailToId in emailToIds)
            {
                int parent = FindParent(dsuArr, emailToId.Value);
                if (!parentToEmails.ContainsKey(parent))
                    parentToEmails.Add(parent, new List<string>());
                parentToEmails[parent].Add(emailToId.Key);
            }

            var lst = new List<IList<string>>();
            foreach (var parentToEmail in parentToEmails)
            {
                var accountEmails = new List<string>(parentToEmail.Value);
                accountEmails.Sort(StringComparer.Ordinal);
                accountEmails.Insert(0, emailToName[accountEmails[0]]);
                lst.Add(accountEmails);
            }

            return lst;
        }

        private void Union(int[] dsuArr, int i, int j)
        {
            var ip = FindParent(dsuArr, i);
            var jp = FindParent(dsuArr, j);
            if (ip == jp) return;

            dsuArr[ip] = jp;
        }

        public int NumDecodings(string s)
        {
            var dp = new int?[s.Length];
            return NumDecodingsRec(s, 0, ref dp);
        }

        private int NumDecodingsRec(string s, int i, ref int?[] dp)
        {
            if (i == s.Length) return 1;

            if (dp[i].HasValue) return dp[i].Value;

            int options = 0;
            if (i < s.Length - 1)
            {
                int num = (s[i] - '0') * 10 + (s[i + 1] - '0');
                if (s[i] != '0' && num > 0 && num < 27)
                {
                    options += NumDecodingsRec(s, i + 2, ref dp);
                }
            }

            if (s[i] - '0' > 0)
            {
                options += NumDecodingsRec(s, i + 1, ref dp);
            }

            dp[i] = options;

            return options;
        }

        public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
        {
            int p1 = 0, p2 = 0;

            var res = new List<int[]>();
            while (p1 < firstList.Length && p2 < secondList.Length)
            {
                if (firstList[p1][0] <= secondList[p2][1] && firstList[p1][1] >= secondList[p2][0])
                {
                    res.Add(new[]
                        {Math.Max(firstList[p1][0], secondList[p2][0]), Math.Min(firstList[p1][1], secondList[p2][1])});
                }

                if (firstList[p1][1] >= secondList[p2][1])
                    p2++;
                else p1++;
            }

            return res.ToArray();
        }

        public bool IsMonotonic(int[] A)
        {
            if (A == null || A.Length == 0) return false;
            bool? isIncreasing = null;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == A[i - 1]) continue;

                if (!isIncreasing.HasValue)
                    isIncreasing = A[i] > A[i - 1];

                if ((A[i] < A[i - 1] && isIncreasing.Value) || (A[i] > A[i - 1] && !isIncreasing.Value)) return false;
            }

            return true;
        }

        public interface Robot
        {
            // Returns true if the cell in front is open and robot moves into the cell.
            // Returns false if the cell in front is blocked and robot stays in the current cell.
            public bool Move();

            // Robot will stay in the same cell after calling turnLeft/turnRight.
            // Each turn will be 90 degrees.
            public void TurnLeft();
            public void TurnRight();

            // Clean the current cell.
            public void Clean();
        }


        public void CleanRoom(Robot robot)
        {
            var directions = new[] { new[] { -1, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 0, -1 } };
            var visited = new HashSet<(int x, int y)>();
            CleanRoomRec(robot, 0, 0, 0, directions, ref visited);
        }

        private void CleanRoomRec(Robot robot, int orientation, int x, int y, int[][] directions, ref HashSet<(int x, int y)> visited)
        {
            robot.Clean();
            visited.Add((x, y));

            for (int i = 0; i < directions.Length; i++)
            {
                orientation = (orientation + 1) % 4;

                int newX = x + directions[orientation][0], newY = y + directions[orientation][1];
                if (!visited.Contains((newX, newY)) && robot.Move())
                {
                    CleanRoomRec(robot, orientation, newX, newY, directions, ref visited);
                    GoBack(robot);
                }
                robot.TurnRight();
            }
        }

        private void GoBack(Robot robot)
        {
            robot.TurnRight();
            robot.TurnRight();
            robot.Move();
            robot.TurnRight();
            robot.TurnRight();
        }

        public int NumberOfArithmeticSlices(int[] A)
        {
            if (A == null || A.Length < 3) return 0;
            var dp = new int?[A.Length];
            int sum = 0;
            NumberOfArithmeticSlicesRec(A, A.Length - 1, ref sum, ref dp);
            return sum;
        }

        private int NumberOfArithmeticSlicesRec(int[] A, int i, ref int sum, ref int?[] dp)
        {
            if (i < 2) return 0;

            if (dp[i].HasValue) return dp[i].Value;

            int res = 0;
            if (A[i] - A[i - 1] == A[i - 1] - A[i - 2])
            {
                res = 1 + NumberOfArithmeticSlicesRec(A, i - 1, ref sum, ref dp);
                sum += res;
            }
            else
            {
                res = NumberOfArithmeticSlicesRec(A, i - 1, ref sum, ref dp);
            }

            dp[i] = res;

            return res;
        }

        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int low = 0, high = 0, max = 1, countSoFar = 1;

            while (high < nums.Length)
            {
                while (high < nums.Length - 1 && nums[high] < nums[high + 1])
                {
                    countSoFar++;
                    high++;
                }

                max = Math.Max(max, countSoFar);

                countSoFar = 1;
                high++;
            }

            return max;
        }

        public int Divide1(int dividend, int divisor)
        {
            if (dividend == 0 || (dividend > 0 && divisor > 0 && dividend < divisor) || (dividend < 0 && divisor < 0 && dividend > divisor)) return 0;
            if (divisor == 1) return dividend;
            if (divisor == dividend) return 1;

            int sign = divisor < 0 ? -1 : 1;
            sign *= (dividend < 0) ? -1 : 1;

            if (Math.Abs(dividend - divisor) > int.MaxValue / 2) return int.MaxValue;

            dividend = dividend < 0 ? dividend * -1 : dividend;
            divisor = divisor < 0 ? divisor * -1 : divisor;

            int low = divisor, high = dividend;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;
                var mul = mid * divisor;
                if (mul < dividend)
                    low = mid + 1;
                else high = mid - 1;
            }

            return high * sign;
        }

        public bool IsBipartite(int[][] graph)
        {
            var visited = new bool[100];
            var color = new int[100];

            var q = new Queue<int>();

            for (int i = 0; i < graph.Length; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    q.Enqueue(i);
                    color[i] = 1;

                    while (q.Count > 0)
                    {
                        var node = q.Dequeue();

                        for (int j = 0; j < graph[node].Length; j++)
                        {
                            var neighbor = graph[node][j];
                            if (color[neighbor] != 0 && color[neighbor] == color[node])
                                return false;
                            color[neighbor] = 3 - color[node];
                            if (!visited[neighbor])
                            {
                                visited[neighbor] = true;
                                q.Enqueue(neighbor);
                            }
                        }
                    }
                }
            }

            return true;
        }

        public class BSTIterator
        {

            Stack<TreeNode> st = new Stack<TreeNode>();

            public BSTIterator(TreeNode root)
            {
                AddToStack(root);
            }

            public void AddToStack(TreeNode node)
            {
                while (node != null)
                {
                    st.Push(node);
                    node = node.left;
                }
            }

            public int Next()
            {
                if (st.Count == 0) return -1;
                var node = st.Pop();
                AddToStack(node.right);
                return node.val;
            }

            public bool HasNext()
            {
                return st.Count > 0;
            }
        }

        public char FindTheDifference(string s, string t)
        {
            var xor = 0;
            foreach (var ch in s)
                xor = xor ^ ch;
            foreach (var ch in t)
                xor = xor ^ ch;
            return (char)xor;
        }

        public int FindMin(int[] nums)
        {
            int low = 0, high = nums.Length - 1;

            while (low < high)
            {
                var mid = low + (high - low) / 2;

                if (mid < high && nums[mid] > nums[mid + 1])
                    return mid + 1;
                if (mid > low && nums[mid - 1] > nums[mid])
                    return mid;

                if (nums[mid] > nums[high])
                {
                    low = mid + 1;
                }
                else if (nums[mid] > nums[low])
                {
                    high = mid - 1;
                }
                else
                {
                    low++;
                    high--;
                }
            }

            return low;
        }

        public char NextGreatestLetter(char[] letters, char target)
        {
            if (letters == null || letters.Length == 0) return '\0';
            if (target >= letters[letters.Length - 1]) return letters[0];

            int low = 0, high = letters.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (target < letters[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return letters[low % letters.Length];
        }

        public int NumTrees(int n)
        {
            if (n <= 1) return n;
            var memo = new int?[n + 1];
            return NumTreesRec(n, ref memo);
        }

        private int NumTreesRec(int n, ref int?[] memo)
        {
            if (n <= 1) return 1;
            if (memo[n].HasValue) return memo[n].Value;

            var count = 0;
            for (int i = 1; i <= n; i++)
            {
                var leftSubTrees = NumTreesRec(i - 1, ref memo);
                var rightSubTrees = NumTreesRec(n - i, ref memo);
                count += leftSubTrees * rightSubTrees;
            }

            memo[n] = count;

            return count;
        }

        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n <= 0) return new List<TreeNode>();
            return GenerateTreesRec(1, n);
        }

        private List<TreeNode> GenerateTreesRec(int start, in int end)
        {
            if (start > end)
            {
                return new List<TreeNode> { null };
            }
            else
            {
                var lst = new List<TreeNode>();
                for (int i = start; i <= end; i++)
                {
                    var leftSubTrees = GenerateTreesRec(start, i - 1);
                    var rightSubTrees = GenerateTreesRec(i + 1, end);

                    foreach (var leftSubTree in leftSubTrees)
                    {
                        foreach (var rightSubTree in rightSubTrees)
                        {
                            var root = new TreeNode(i, leftSubTree, rightSubTree);
                            lst.Add(root);
                        }
                    }
                }
                return lst;
            }
        }

        public IList<string> LetterCasePermutation(string S)
        {
            var result = new List<string>();

            LetterCasePermutationRec(S.ToCharArray(), 0, ref result);

            return result;
        }

        private void LetterCasePermutationRec(char[] s, int i, ref List<string> result)
        {
            if (i == s.Length)
            {
                result.Add(new string(s));
            }
            else
            {
                int j = i;
                if (char.IsLetter(s[j]))
                {
                    s[j] = char.IsLower(s[j]) ? char.ToUpper(s[j]) : char.ToLower(s[j]);
                    LetterCasePermutationRec(s, j + 1, ref result);
                    s[j] = char.IsLower(s[j]) ? char.ToUpper(s[j]) : char.ToLower(s[j]);
                }
                LetterCasePermutationRec(s, j + 1, ref result);
            }
        }

        public class Node2
        {
            public int val;
            public Node2 left;
            public Node2 right;
            public Node2 parent;
        }

        public Node2 InorderSuccessor(Node2 x)
        {
            var st = new Stack<Node2>();

            var right = x.right;
            while (right != null)
            {
                st.Push(right);
                right = right.left;
            }

            if (st.Count > 0)
                return st.Pop();

            while (x.parent != null && x.parent.val < x.val)
            {
                x = x.parent;
            }

            return x.parent;
        }

        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            var st = new Stack<TreeNode>();

            AddToStack(st, root);
            TreeNode prev = null;
            while (st.Count > 0)
            {
                var node = st.Pop();
                if (prev != null)
                    return node;
                if (node.val == p.val)
                    prev = node;
                AddToStack(st, node.right);
            }

            return null;
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            var st = new Stack<TreeNode>();

            AddToStack(st, root);

            var list = new List<int>();
            while (st.Count > 0)
            {
                var node = st.Pop();
                list.Add(node.val);
                AddToStack(st, node.right);
            }

            return list;
        }

        private void AddToStack(Stack<TreeNode> st, TreeNode root)
        {
            while (root != null)
            {
                st.Push(root);
                root = root.left;
            }
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

        public Node Connect(Node root)
        {
            if (root == null) return root;
            var q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var qCount = q.Count;
                Node prev = null;
                for (int i = 0; i < qCount; i++)
                {
                    var node = q.Dequeue();
                    if (prev != null)
                        prev.next = node;
                    prev = node;

                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
            }

            return root;
        }

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            var result = new List<IList<int>>();
            var path = new List<int>();

            PathSumRec(root, sum, ref path, ref result);

            return result;
        }

        private void PathSumRec(TreeNode root, in int sum, ref List<int> path, ref List<IList<int>> result)
        {
            if (root == null)
                return;

            path.Add(root.val);

            if (root.val == sum && root.left == null && root.right == null)
            {
                result.Add(new List<int>(path));
            }
            else
            {
                PathSumRec(root.left, sum - root.val, ref path, ref result);
                PathSumRec(root.right, sum - root.val, ref path, ref result);
            }

            path.RemoveAt(path.Count - 1);
        }

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;

            ListNode odd = head, even = head.next, evenHead = even;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenHead;

            return head;
        }

        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return null;

            int len = 0;

            var node = head;
            while (node != null)
            {
                len++;
                node = node.next;
            }

            k = k % len;

            if (k == 0) return head;

            var moves = len - k;
            node = head;
            ListNode prev = null;
            while (moves > 0)
            {
                prev = node;
                node = node.next;
                moves--;
            }

            prev.next = null;
            var tempHead = node;
            while (node.next != null)
            {
                node = node.next;
            }

            node.next = head;

            return tempHead;
        }

        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] != i + 1 && nums[i] != nums[nums[i] - 1])
                    Swap(nums, nums[i] - 1, i);
                else i++;
            }

            var lst = new List<int>();
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                    lst.Add(i + 1);
            }

            return lst;
        }

        private void Swap(int[] nums, int i, in int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public bool CircularArrayLoop(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int slow = i, fast = i, direction = nums[i] > 0 ? 1 : -1;

                do
                {
                    slow = FindNext(nums, slow, direction);
                    fast = FindNext(nums, fast, direction);
                    if (fast != -1)
                        fast = FindNext(nums, fast, direction);
                } while (slow != -1 && fast != -1 && slow != fast);

                if (slow != -1 && slow == fast) return true;
            }

            return false;
        }

        private int FindNext(int[] nums, in int start, in int direction)
        {
            var newDirection = nums[start] > 0 ? 1 : -1;
            if (direction != newDirection) return -1;

            var newIndex = (nums[start] + start) % nums.Length;
            if (newIndex < 0) newIndex += nums.Length;

            return newIndex == start ? -1 : newIndex;
        }

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            return KSum(nums, target, 0, 4);
        }

        private IList<IList<int>> KSum(int[] nums, in int target, int start, int k)
        {
            var list = new List<IList<int>>();
            if (start == nums.Length || nums[start] * k > target || target > nums[nums.Length - 1] * k)
                return list;

            if (k == 2)
                return TwoSum(nums, target, start);

            for (int i = start; i <= nums.Length - k; i++)
            {
                if (i != start && nums[i] == nums[i - 1]) continue;
                var sets = KSum(nums, target - nums[i], i + 1, k - 1);
                foreach (var set in sets)
                {
                    set.Insert(0, nums[i]);
                    list.Add(new List<int>(set));
                }
            }

            return list;
        }

        private IList<IList<int>> TwoSum(int[] nums, in int target, in int start)
        {
            var res = new List<IList<int>>();
            var hs = new HashSet<int>();
            for (int i = start; i < nums.Length; i++)
            {
                if (res.Count == 0 || res[res.Count - 1][1] != nums[i])
                    if (hs.Contains(target - nums[i]))
                        res.Add(new List<int> { target - nums[i], nums[i] });
                hs.Add(nums[i]);
            }

            return res;
        }

        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            int left = 0, right = 0;

            int product = 1, count = 0;
            for (right = 0; right < nums.Length; right++)
            {
                product *= nums[right];

                while (product >= k && left < right)
                {
                    product = product / nums[left];
                    left++;
                }

                count += (right - left);
            }

            return count;
        }

        public int LongestSubstring(string s, int k)
        {
            var uniqueChars = new HashSet<char>();

            foreach (var ch in s)
                uniqueChars.Add(ch);
            var uniqueCharsCount = uniqueChars.Count;

            int maxLength = 0;
            for (int maxChars = 1; maxChars <= uniqueCharsCount; maxChars++)
            {
                int start = 0, end = 0, countAtLeastK = 0;
                var dic = new Dictionary<char, int>();
                while (end < s.Length)
                {
                    if (!dic.ContainsKey(s[end]))
                        dic.Add(s[end], 0);
                    dic[s[end]]++;
                    if (dic[s[end]] == k) countAtLeastK++;

                    while (dic.Keys.Count > maxChars)
                    {
                        if (dic[s[start]] == k) countAtLeastK--;
                        dic[s[start]]--;
                        if (dic[s[start]] == 0)
                            dic.Remove(s[start]);
                        start++;
                    }

                    if (countAtLeastK == maxChars && dic.Keys.Count == maxChars)
                        maxLength = Math.Max(maxLength, end - start + 1);
                    end++;
                }
            }

            return maxLength;
        }

        public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
            var dsuArr = new int[s.Length];
            for (int i = 0; i < dsuArr.Length; i++)
                dsuArr[i] = i;

            foreach (var allowedSwap in pairs)
            {
                int xParent = FindParent(dsuArr, allowedSwap[0]), yParent = FindParent(dsuArr, allowedSwap[1]);
                if (xParent != yParent) dsuArr[xParent] = yParent;
            }

            var groups = new Dictionary<int, List<char>>();
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                var parent = FindParent(dsuArr, i);
                if (!groups.ContainsKey(parent))
                    groups.Add(parent, new List<char>());

                groups[parent].Add(ch);
            }

            foreach (var kv in groups)
                kv.Value.Sort((ch1, ch2) => ch2 - ch1);

            var sb = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                var parent = FindParent(dsuArr, i);
                if (groups[parent].Count > 0)
                {
                    sb[i] = groups[parent][groups[parent].Count - 1];
                    groups[parent].RemoveAt(groups[parent].Count - 1);
                }
            }

            return sb.ToString();
        }

        public int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps)
        {
            var dsuArr = new int[source.Length];
            for (int i = 0; i < dsuArr.Length; i++)
                dsuArr[i] = i;

            foreach (var allowedSwap in allowedSwaps)
            {
                int xParent = FindParent(dsuArr, allowedSwap[0]), yParent = FindParent(dsuArr, allowedSwap[1]);
                if (xParent != yParent) dsuArr[xParent] = yParent;
            }

            var groups = new Dictionary<int, Dictionary<int, int>>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != target[i])
                {
                    int num = source[i];
                    var parent = FindParent(dsuArr, i);
                    if (!groups.ContainsKey(parent))
                        groups.Add(parent, new Dictionary<int, int>());

                    if (!groups[parent].ContainsKey(num))
                        groups[parent].Add(num, 0);
                    groups[parent][num]++;
                }
            }

            var canNotReplace = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != target[i])
                {
                    var dst = target[i];
                    var srcParent = FindParent(dsuArr, i);
                    if (groups[srcParent].ContainsKey(dst))
                    {
                        groups[srcParent][dst]--;
                        if (groups[srcParent][dst] == 0)
                            groups[srcParent].Remove(dst);
                    }
                    else canNotReplace++;
                }
            }

            return canNotReplace;
        }

        private int FindParent(int[] arr, int x)
        {
            if (x != arr[x]) arr[x] = FindParent(arr, arr[x]);
            return arr[x];
        }

        public int MaxScore(int[] cardPoints, int k)
        {
            int total = 0, max = 0, i;
            for (i = cardPoints.Length - k; i < cardPoints.Length; i++)
            {
                total += cardPoints[i];
            }

            i = 0;

            max = Math.Max(max, total);
            while (i < k)
            {
                total -= cardPoints[cardPoints.Length - k + i];
                total += cardPoints[i];
                max = Math.Max(max, total);
                i++;
            }

            return max;
        }

        public int TotalHammingDistance(int[] nums)
        {
            int total = 0;
            int[] bits = new int[32];

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                int j = 0;
                while (num > 0)
                {
                    bits[j] += (num & 1);
                    num >>= 1;
                    j++;
                }
            }

            foreach (var k in bits)
                total += k * (nums.Length - k);

            return total;
        }

        public int TotalHammingDistance_TLE(int[] nums)
        {
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    total += HammingDistance(nums[i], nums[j]);
                }
            }
            return total;
        }

        public int HammingDistance(int x, int y)
        {
            int diff = 0;
            int xor = x ^ y;

            while (xor != 0)
            {
                if (xor % 2 == 1)
                    diff++;
                xor >>= 1;
            }

            return diff;
        }

        public int MinimumTimeRequired(int[] jobs, int k)
        {
            Array.Sort(jobs);
            var workerSum = new int[k];
            int min = int.MaxValue;
            var visited = new bool[jobs.Length];
            MinimumTimeRequiredRec(jobs, 0, k, workerSum, ref visited, ref min);
            return min;
        }

        private void MinimumTimeRequiredRec(int[] jobs, int i, in int k, int[] workerSum, ref bool[] visited, ref int min) //, ref int?[,] dp
        {
            if (i == jobs.Length)
            {
                if (k <= 1)
                {
                    min = Math.Min(min, workerSum.Max());
                }

                return;
            }

            if (k == 0) return;

            var workerIndex = workerSum.Length - k;

            for (int j = i; j < jobs.Length; j++)
            {
                // Can skip
                if (workerSum[workerIndex] > 0)
                {
                    MinimumTimeRequiredRec(jobs, j, k - 1, workerSum, ref visited, ref min);
                }

                //if (!visited[j])
                {
                    //visited[j] = true;
                    workerSum[workerIndex] += jobs[j];
                    MinimumTimeRequiredRec(jobs, j + 1, k - 1, workerSum, ref visited, ref min);
                }
            }
        }

        public int[] Decode(int[] encoded, int first)
        {
            var arr = new int[encoded.Length + 1];
            arr[0] = first;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] ^ encoded[i - 1];
            }

            return arr;
        }

        public ListNode SwapNodes(ListNode head, int k)
        {
            var len = 0;
            ListNode node = head, first = null;
            while (node != null)
            {
                len++;
                if (k == len) first = node;
                node = node.next;
            }

            if (k > len)
                return head;

            var second = head;
            while (len > k)
            {
                len--;
                second = second.next;
            }

            var temp = first.val;
            first.val = second.val;
            second.val = temp;

            return head;
        }


        public IList<int> FindSubstring(string s, string[] words)
        {
            int wordLength = words[0].Length, wordsCount = words.Length;
            var wordsDic = new Dictionary<string, int>();
            for (int i = 0; i < wordsCount; i++)
            {
                if (!wordsDic.ContainsKey(words[i]))
                    wordsDic.Add(words[i], 0);
                wordsDic[words[i]]++;
            }

            var results = new List<int>();
            for (int i = 0; i <= s.Length - (wordsCount * wordLength); i++)
            {
                var seenWords = new Dictionary<string, int>();
                for (int j = 0; j < wordsCount; j++)
                {
                    var matchedWord = s.Substring(i + j * wordLength, wordLength);
                    if (wordsDic.ContainsKey(matchedWord))
                    {
                        if (!seenWords.ContainsKey(matchedWord))
                            seenWords.Add(matchedWord, 0);
                        seenWords[matchedWord]++;
                    }
                    else break;

                    if (seenWords[matchedWord] > wordsDic[matchedWord]) break;

                    if (j == wordsCount - 1) results.Add(i);
                }
            }

            return results;
        }

        public string MinWindow1(string s, string t)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || t.Length > s.Length) return string.Empty;
            var dic = new Dictionary<char, int>();

            for (int j = 0; j < t.Length; j++)
            {
                if (!dic.ContainsKey(t[j]))
                    dic.Add(t[j], 0);
                dic[t[j]]++;
            }

            int left = 0, right = 0, min = int.MaxValue, minLeft = 0, lengthMatch = 0;

            while (right < s.Length)
            {
                if (dic.ContainsKey(s[right]))
                {
                    dic[s[right]]--;
                    if (dic[s[right]] >= 0) lengthMatch++;
                }

                while (lengthMatch == t.Length)
                {
                    if (right - left + 1 < min)
                    {
                        min = right - left + 1;
                        minLeft = left;
                    }

                    if (dic.ContainsKey(s[left]))
                    {
                        if (dic[s[left]] == 0) lengthMatch--;
                        dic[s[left]]++;
                    }
                    left++;
                }

                right++;
            }

            return min == int.MaxValue ? string.Empty : s.Substring(minLeft, min);
        }

        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            if (string.IsNullOrEmpty(p) || string.IsNullOrEmpty(s) || p.Length > s.Length) return result;

            var pFreq = new Dictionary<char, int>();
            for (int i = 0; i < p.Length; i++)
            {
                if (!pFreq.ContainsKey(p[i]))
                    pFreq.Add(p[i], 0);
                pFreq[p[i]]++;
            }

            int start = 0, end = 0, matches = 0;
            while (end < s.Length)
            {
                var chIdx = s[end];
                if (pFreq.ContainsKey(chIdx))
                {
                    pFreq[chIdx]--;
                    if (pFreq[chIdx] == 0)
                        matches++;
                }

                if (matches == pFreq.Keys.Count) result.Add(start);

                if (end >= p.Length - 1)
                {
                    var startChIdx = s[start];
                    if (pFreq.ContainsKey(startChIdx))
                    {
                        if (pFreq[startChIdx] == 0)
                            matches--;
                        pFreq[startChIdx]++;
                    }
                    start++;
                }

                end++;
            }

            return result;
        }

        public bool CheckInclusion(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2) || s1.Length > s2.Length) return false;

            var s1Freq = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (!s1Freq.ContainsKey(s1[i]))
                    s1Freq.Add(s1[i], 0);
                s1Freq[s1[i]]++;
            }

            int start = 0, end = 0, matches = 0;
            while (end < s2.Length)
            {
                var chIdx = s2[end];
                if (s1Freq.ContainsKey(chIdx))
                {
                    s1Freq[chIdx]--;
                    if (s1Freq[chIdx] == 0)
                        matches++;
                }

                if (matches == s1Freq.Keys.Count) return true;

                if (end >= s1.Length - 1)
                {
                    var startChIdx = s2[start];
                    if (s1Freq.ContainsKey(startChIdx))
                    {
                        if (s1Freq[startChIdx] == 0)
                            matches--;
                        s1Freq[startChIdx]++;
                    }
                    start++;
                }

                end++;
            }

            return false;
        }

        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int onesCount = 0, start = 0, end = 0, maxReplacement = 1;

            while (end < nums.Length)
            {
                if (nums[end] == 1) onesCount++;

                if (end - start + 1 - onesCount > maxReplacement)
                {
                    if (nums[start] == 1)
                        onesCount--;
                    start++;
                }
                end++;
            }

            return end - start + 1;
        }

        public int CharacterReplacement(string s, int k)
        {
            var freqMap = new Dictionary<int, int>();
            int start = 0, end = 0, repeatCount = 0, max = 0;

            while (end < s.Length)
            {
                if (!freqMap.ContainsKey(s[end]))
                    freqMap.Add(s[end], 0);
                freqMap[s[end]]++;

                repeatCount = Math.Max(repeatCount, freqMap[s[end]]);
                if (1 + end - start - repeatCount > k)
                {
                    freqMap[s[start]]--;
                    start++;
                }

                max = Math.Max(max, end - start + 1);
                end++;
            }

            return max;
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var count = new int[101];
            for (int i = 0; i < nums.Length; i++)
                count[nums[i]]++;

            for (int i = 1; i < count.Length; i++)
                count[i] += count[i - 1];

            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] == 0 ? 0 : count[nums[i] - 1];
            }

            return result;
        }

        public IList<int> CountSmaller(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new List<int>();

            var result = new int[nums.Length];
            var sortedArr = (int[])nums.Clone();
            Array.Sort(sortedArr);

            var bitArr = new int[nums.Length + 1];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                int num = nums[i];
                var idx = BinarySearch_MinMaxIndex(sortedArr, num, true) + 1;
                result[i] = BitQuery1(bitArr, idx - 1);
                BitUpdate1(bitArr, idx, 1);
            }

            return result;
        }

        public int BitQuery1(int[] bitArr, int idx)
        {
            int sum = 0;
            while (idx > 0)
            {
                sum += bitArr[idx];
                idx -= idx & -idx;
            }
            return sum;
        }

        public void BitUpdate1(int[] bitArr, int idx, int val)
        {
            while (idx < bitArr.Length)
            {
                bitArr[idx] += val;
                idx += idx & -idx;
            }
        }

        public int BitQuery(int[] bitArr, int idx)
        {
            int sum = 0;
            while (idx < bitArr.Length)
            {
                sum += bitArr[idx];
                idx += idx & -idx;
            }
            return sum;
        }

        public void BitUpdate(int[] bitArr, int idx, int val)
        {
            while (idx > 0)
            {
                bitArr[idx] += val;
                idx -= idx & -idx;
            }
        }

        public int ReversePairs(int[] nums)
        {
            var sortedArr = (int[])nums.Clone();
            Array.Sort(sortedArr);

            int sum = 0;
            var bitArr = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                var idx = BinarySearch_MinMaxIndex(sortedArr, 2 * (long)num + 1) + 1;
                sum += BitQuery(bitArr, idx);
                idx = BinarySearch_MinMaxIndex(sortedArr, num) + 1;
                BitUpdate(bitArr, idx, 1);
            }

            return sum;
        }


        public int BinarySearch_MinMaxIndex(int[] nums, in long target, bool findMinIndex = true)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                // These 2 lines equal to if statement but less readable
                //int comparer = findMinIndex ? -1 : 0;
                //if (nums[mid] - target <= comparer)
                if ((findMinIndex && nums[mid] < target) || (!findMinIndex && nums[mid] <= target))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low >= 0 ? low : ~low;
        }

        public TreeNodeWithPayload<int> InsertNode(TreeNodeWithPayload<int> root, int val)
        {
            if (root == null) return new TreeNodeWithPayload<int>(val) { payload = 1 };
            else if (root.val == val) root.payload++;
            else if (val < root.val)
                root.left = InsertNode(root.left, val);
            else
            {
                root.payload++;
                root.right = InsertNode(root.right, val);
            }
            return root;
        }

        public int SearchNode(TreeNodeWithPayload<int> root, long target)
        {
            if (root == null) return 0;
            else if (root.val == target)
                return root.payload;
            else if (root.val > target)
                return root.payload + SearchNode(root.left, target);
            else return SearchNode(root.right, target);
        }

        public int ReversePairs_BST(int[] nums)
        {
            if (nums.Length <= 1) return 0;
            var sum = 0;
            TreeNodeWithPayload<int> head = null;
            for (int j = 0; j < nums.Length; j++)
            {
                sum += SearchNode(head, 2 * (long)nums[j] + 1);
                head = InsertNode(head, nums[j]);
            }

            return sum;
        }

        public class Employee
        {
            public int id;
            public int importance;
            public IList<int> subordinates;
        }

        public int GetImportance(IList<Employee> employees, int id)
        {
            var visited = new HashSet<int>();
            var employeesDic = new Dictionary<int, Employee>();
            foreach (var employee in employees)
                employeesDic.Add(employee.id, employee);

            return EmployeesDFS(employeesDic, id, ref visited);
        }

        private int EmployeesDFS(Dictionary<int, Employee> employeesDic, int id, ref HashSet<int> visited)
        {
            int impSum = employeesDic[id].importance;

            foreach (var subordinate in employeesDic[id].subordinates)
            {
                if (!visited.Contains(subordinate))
                {
                    visited.Add(subordinate);
                    impSum += EmployeesDFS(employeesDic, subordinate, ref visited);
                }
            }

            return impSum;
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p?.val != q?.val) return false;

            if (p != null)
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);

            return true;
        }

        public IList<string> FindItinerary1(IList<IList<string>> tickets)
        {
            var adjList = new Dictionary<string, List<string>>();
            var srcCounts = new Dictionary<string, bool[]>();

            foreach (var ticket in tickets)
            {
                var (src, dst) = (ticket[0], ticket[1]);
                if (!adjList.ContainsKey(src))
                    adjList.Add(src, new List<string>());
                if (!adjList.ContainsKey(dst))
                    adjList.Add(dst, new List<string>());

                adjList[src].Add(dst);
            }

            foreach (var kv in adjList)
            {
                srcCounts.Add(kv.Key, new bool[kv.Value.Count]);
                kv.Value.Sort();
            }

            var result = new List<string>();
            var path = new List<string> { "JFK" };
            FindItineraryRec(adjList, srcCounts, tickets.Count + 1, "JFK", ref path, ref result);

            return result;
        }

        private void FindItineraryRec(Dictionary<string, List<string>> adjList, Dictionary<string, bool[]> srcCounts,
            int flightsCount, string src, ref List<string> path, ref List<string> result)
        {
            if (path.Count == flightsCount)
            {
                result = new List<string>(path);
            }
            else
            {
                var destinations = adjList[src];
                for (int i = 0; i < destinations.Count; i++)
                {
                    var destination = destinations[i];
                    if (!srcCounts[src][i])
                    {
                        path.Add(destination);
                        srcCounts[src][i] = true;
                        FindItineraryRec(adjList, srcCounts, flightsCount, destination, ref path, ref result);
                        srcCounts[src][i] = false;
                        path.RemoveAt(path.Count - 1);
                        if (result.Count == flightsCount)
                            return;
                    }
                }
            }
        }

        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            var adjList = new Dictionary<string, List<string>>();

            foreach (var ticket in tickets)
            {
                var (src, dst) = (ticket[0], ticket[1]);
                if (!adjList.ContainsKey(src))
                    adjList.Add(src, new List<string>());

                adjList[src].Add(dst);
            }

            // Sort desc since we will traverse from end of list
            foreach (var kv in adjList)
                kv.Value.Sort((d1, d2) => d2.CompareTo(d1));

            var result = new List<string>(tickets.Count + 1);
            FindItineraryDFS(adjList, "JFK", ref result);

            return result;
        }


        protected void FindItineraryDFS(Dictionary<string, List<string>> adjList, string origin, ref List<string> result)
        {
            // Visit all the outgoing edges first.
            if (adjList.ContainsKey(origin))
            {
                var destList = adjList[origin];
                while (destList.Count > 0)
                {
                    // while we visit the edge, we trim it off from graph.
                    var dest = destList[destList.Count - 1];
                    destList.RemoveAt(destList.Count - 1);
                    FindItineraryDFS(adjList, dest, ref result);
                }
            }
            // add the airport to the head of the itinerary
            result.Insert(0, origin);
        }

        public int FindPairs(int[] nums, int k)
        {
            Array.Sort(nums);
            int count = 0;

            int low = 0, high = nums.Length;
            var hs = new HashSet<int>();

            if (k == 0)
            {
                while (low < nums.Length)
                {
                    int dupCount = 1;
                    while (low < nums.Length - 1 && nums[low] == nums[low + 1])
                    {
                        low++;
                        dupCount++;
                    }

                    if (dupCount >= 2) count++;
                }
            }
            else
            {
                while (low < nums.Length)
                {
                    while (low < nums.Length - 1 && nums[low] == nums[low + 1])
                        low++;

                    if (hs.Contains(nums[low] - k))
                        count++;

                    hs.Add(nums[low]);

                    low++;
                }
            }

            return count;
        }

        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";
            int b = 1_000_000_000, m = 1_000_000, t = 1_000;
            int billions = num / b;
            int millions = (num - billions * b) / m;
            int thousands = (num - billions * b - millions * m) / t;
            int rem = (num - billions * b - millions * m - thousands * t);

            var sb = new StringBuilder();

            if (billions > 0)
                sb.Append(One(billions) + " Billion");
            if (millions > 0)
                sb.Append((sb.Length > 0 ? " " : "") + Three(millions) + " Million");
            if (thousands > 0)
                sb.Append((sb.Length > 0 ? " " : "") + Three(thousands) + " Thousand");
            if (rem > 0)
                sb.Append((sb.Length > 0 ? " " : "") + Three(rem));

            return sb.ToString();
        }

        private string Two(in int i)
        {
            if (i < 10)
                return One(i);
            else if (i % 10 == 0)
                return TenDoubles(i);
            else if (i < 20)
                return LessThan20(i);

            else return TenDoubles((i / 10) * 10) + " " + One(i % 10);
        }

        private string Three(in int i)
        {
            if (i < 100)
                return Two(i);
            else if (i % 100 == 0)
                return One(i / 100) + " Hundred";
            else return One(i / 100) + " Hundred " + Two(i % 100);
        }

        private string TenDoubles(in int i)
        {
            string str;
            switch (i)
            {
                case 10:
                    str = "Ten";
                    break;
                case 20:
                    str = "Twenty";
                    break;
                case 30:
                    str = "Thirty";
                    break;
                case 40:
                    str = "Forty";
                    break;
                case 50:
                    str = "Fifty";
                    break;
                case 60:
                    str = "Sixty";
                    break;
                case 70:
                    str = "Seventy";
                    break;
                case 80:
                    str = "Eighty";
                    break;
                case 90:
                    str = "Ninety";
                    break;
                default:
                    str = "";
                    break;
            }

            return str;
        }


        private string LessThan20(in int i)
        {
            string str;
            switch (i)
            {
                case 11:
                    str = "Eleven";
                    break;
                case 12:
                    str = "Twelve";
                    break;
                case 13:
                    str = "Thirteen";
                    break;
                case 14:
                    str = "Fourteen";
                    break;
                case 15:
                    str = "Fifteen";
                    break;
                case 16:
                    str = "Sixteen";
                    break;
                case 17:
                    str = "Seventeen";
                    break;
                case 18:
                    str = "Eighteen";
                    break;
                case 19:
                    str = "Nineteen";
                    break;
                default:
                    str = "";
                    break;
            }

            return str;
        }


        private string One(in int i)
        {
            string str;
            switch (i)
            {
                case 1:
                    str = "One";
                    break;
                case 2:
                    str = "Two";
                    break;
                case 3:
                    str = "Three";
                    break;
                case 4:
                    str = "Four";
                    break;
                case 5:
                    str = "Five";
                    break;
                case 6:
                    str = "Six";
                    break;
                case 7:
                    str = "Seven";
                    break;
                case 8:
                    str = "Eight";
                    break;
                case 9:
                    str = "Nine";
                    break;
                default:
                    str = "";
                    break;
            }

            return str;
        }

        public class Reader4
        {
            public int Read4(char[] buf4)
            {
                buf4[0] = 'a';
                buf4[1] = 'b';
                buf4[2] = 'c';
                return 3;
            }
        }

        public class Solution1 : Reader4
        {
            char[] buffer4 = new char[4];
            private int lastConsumedIndex = 0;
            private int lastFetchedCount = 0;

            /**
             * @param buf Destination buffer
             * @param n   Number of characters to read
             * @return    The number of actual characters read
             */
            public int Read(char[] buf, int n)
            {
                int i = 0;
                n = FillBuf(buf, n, ref i);

                while (n > 0)
                {
                    lastFetchedCount = Read4(this.buffer4);
                    if (lastFetchedCount == 0) break;
                    lastConsumedIndex = 0;
                    n = FillBuf(buf, n, ref i);
                }

                return i;
            }

            private int FillBuf(char[] buf, int n, ref int i)
            {
                while (n > 0 && lastConsumedIndex < lastFetchedCount)
                {
                    buf[i++] = this.buffer4[lastConsumedIndex++];
                    n--;
                }

                return n;
            }
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            int max = 0;
            BTreeDiameterRec(root, ref max);
            return max;
        }

        private int BTreeDiameterRec(TreeNode root, ref int max)
        {
            if (root == null) return 0;
            var leftPath = BTreeDiameterRec(root.left, ref max);
            var rightPath = BTreeDiameterRec(root.right, ref max);
            max = Math.Max(max, leftPath + rightPath);
            return 1 + Math.Max(leftPath, rightPath);
        }

        public int[][] CandyCrush(int[][] board)
        {
            int rows = board.Length, cols = board[0].Length;
            var foundCells = false;
            do
            {
                foundCells = false;

                // Mark sets in cols & rows
                for (int row = 0; row < rows; row++)
                {
                    int low = 0, high = 0;
                    do
                    {
                        int count = 0;
                        while (high < cols && Math.Abs(board[row][high]) == Math.Abs(board[row][low]))
                        {
                            if (board[row][high] != 0)
                                count++;
                            high++;
                        }

                        if (count >= 3)
                        {
                            foundCells = true;
                            while (low < high)
                            {
                                if (board[row][low] > 0)
                                    board[row][low] = -board[row][low];
                                low++;
                            }
                        }

                        low = high;
                    } while (high < cols);
                }

                for (int col = 0; col < cols; col++)
                {
                    int low = 0, high = 0;
                    do
                    {
                        int count = 0;
                        while (high < rows && Math.Abs(board[high][col]) == Math.Abs(board[low][col]))
                        {
                            if (board[high][col] != 0)
                                count++;
                            high++;
                        }

                        if (count >= 3)
                        {
                            foundCells = true;
                            while (low < high)
                            {
                                if (board[low][col] > 0)
                                    board[low][col] = -board[low][col];
                                low++;
                            }
                        }

                        low = high;
                    } while (high < rows);
                }

                //board.Print();
                //Console.WriteLine();

                // Crush cells
                for (int col = 0; col < cols; col++)
                {
                    int read = rows - 1, write = rows - 1;

                    while (read >= 0)
                    {
                        if (board[read][col] > 0)
                            board[write--][col] = board[read][col];
                        read--;
                    }

                    while (write >= 0)
                    {
                        board[write--][col] = 0;
                    }
                }

                //board.Print();
                //Console.WriteLine();

            } while (foundCells);

            return board;
        }

        public string GetHint(string secret, string guess)
        {
            int[] count = new int[10];

            int hits = 0, miss = 0;
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == secret[i])
                {
                    hits++;
                }
                else
                {
                    if (count[guess[i] - '0'] > 0)
                        miss++;
                    if (count[secret[i] - '0'] < 0)
                        miss++;

                    count[secret[i] - '0']++;
                    count[guess[i] - '0']--;
                }
            }

            return $"{hits}A{miss}B";
        }

        public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
        {
            var map = new Dictionary<string, List<(int time, string website)>>();

            for (int i = 0; i < username.Length; i++)
            {
                if (map.ContainsKey(username[i]))
                {
                    map[username[i]].Add((timestamp[i], website[i]));
                }
                else
                {
                    var ss = new List<(int time, string website)> { (timestamp[i], website[i]) };
                    map.Add(username[i], ss);
                }
            }

            var sequenceCountsMap = new Dictionary<string, int>();
            var resultSequence = "";

            foreach (var kv in map)
            {
                kv.Value.Sort((t1, t2) => t1.time - t2.time);
                var userSet = new HashSet<string>();
                for (int i = 0; i < kv.Value.Count - 2; i++)
                {
                    for (int j = i + 1; j < kv.Value.Count - 1; j++)
                    {
                        for (int k = j + 1; k < kv.Value.Count; k++)
                        {
                            var key = kv.Value.ElementAt(i).website + " " + kv.Value.ElementAt(j).website + " " +
                                      kv.Value.ElementAt(k).website;
                            if (!userSet.Contains(key))
                            {
                                userSet.Add(key);
                                if (!sequenceCountsMap.ContainsKey(key))
                                    sequenceCountsMap.Add(key, 1);
                                else sequenceCountsMap[key]++;
                            }

                            if (resultSequence == "" || sequenceCountsMap[resultSequence] < sequenceCountsMap[key] ||
                                (sequenceCountsMap[resultSequence] == sequenceCountsMap[key] &&
                                 resultSequence.CompareTo(key) > 0))
                            {
                                resultSequence = key;
                            }
                        }
                    }
                }
            }

            return resultSequence == "" ? new List<string>() : resultSequence.Split(" ").ToList();
        }

        public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
        {
            int i = 0, j = 0;
            Array.Sort(slots1, (s1, s2) => s1[0] - s2[0]);
            Array.Sort(slots2, (s1, s2) => s1[0] - s2[0]);

            while (i < slots1.Length && j < slots2.Length)
            {
                int[] a = slots1[i], b = slots2[j];

                // intersection exist
                if (a[0] <= b[1] && b[0] <= a[1])
                {
                    int start = Math.Max(a[0], b[0]);
                    var intersectionLength = Math.Min(a[1], b[1]) - start;
                    if (intersectionLength >= duration) return new List<int> { start, start + duration };
                }

                if (a[1] < b[1])
                    i++;
                else j++;
            }

            return new List<int>();
        }

        public int cellsToBitmap(int[] cells)
        {
            int stateBitmap = 0x0;
            foreach (int cell in cells)
            {
                stateBitmap <<= 1;
                stateBitmap = (stateBitmap | cell);
            }
            return stateBitmap;
        }

        public int[] PrisonAfterNDays(int[] cells, int N)
        {
            var dic = new Dictionary<int, int>();
            var fastForwarded = false;
            while (N > 0)
            {
                if (!fastForwarded)
                {
                    var hash = cellsToBitmap(cells);
                    if (dic.ContainsKey(hash))
                    {
                        N = N % (dic[hash] - N);
                        fastForwarded = true;
                    }
                    else dic.Add(hash, N);
                }

                if (N > 0)
                {
                    N--;
                    cells = GetNextDay(cells);
                }
            }

            return cells;
        }

        private int[] GetNextDay(int[] cells)
        {
            var newCells = new int[cells.Length];
            for (int i = 1; i < cells.Length - 1; i++)
                newCells[i] = (cells[i - 1] == cells[i + 1]) ? 1 : 0;

            newCells[0] = newCells[cells.Length - 1] = 0;

            return cells;
        }

        public int FindMinDifference(IList<string> timePoints)
        {
            var minutesInDay = 24 * 60;
            var newTimes = new int[timePoints.Count];
            for (int i = 0; i < timePoints.Count; i++)
            {
                var parts = timePoints[i].Split(":");
                newTimes[i] = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
                //newTimes[i] = (newTimes[i] > minutesInDay / 2 ? )
            }
            Array.Sort(newTimes);

            int minDiff = int.MaxValue;
            for (int i = 0; i < newTimes.Length - 1; i++)
                minDiff = Math.Min(minDiff, newTimes[i + 1] - newTimes[i]);

            minDiff = Math.Min(minDiff, minutesInDay - newTimes[0] - newTimes[newTimes.Length - 1]);

            return minDiff;
        }

        public int MaxProfit1(int[] prices)
        {
            var dp = new int[prices.Length + 2];

            for (int buyAt = prices.Length - 2; buyAt >= 0; buyAt--)
            {
                var includeCurrentOption = 0;

                for (int sellAt = buyAt + 1; sellAt < prices.Length; sellAt++)
                {
                    var gain = prices[sellAt] - prices[buyAt] + dp[sellAt + 2];

                    includeCurrentOption = Math.Max(includeCurrentOption, gain);
                }

                var excludeCurrentOption = dp[buyAt + 1];

                dp[buyAt] = Math.Max(includeCurrentOption, excludeCurrentOption);
            }

            return dp[0];
        }

        public bool ValidUtf8(int[] data)
        {
            var least8Bits = 255;

            int bytesNum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                var num = data[i] & least8Bits;
                if (bytesNum == 0)
                {
                    int mask = 1 << 7;
                    while ((num & mask) != 0)
                    {
                        bytesNum++;
                        if (bytesNum > 4) return false;
                        mask >>= 1;
                    }
                    if (bytesNum == 1) return false;
                    else if (bytesNum == 0) continue;
                }
                else
                {
                    int mask1 = 1 << 7, mask2 = 1 << 6;
                    if ((num & mask1) != mask1 || (num & mask2) != 0) return false;
                }
                bytesNum--;
            }

            return bytesNum == 0;
        }

        public int MaxProfit_2Transactions(int[] prices)
        {
            int n = prices.Length;
            int[] left = new int[n], right = new int[n];

            int minLeft = prices[0], maxRight = prices[n - 1];
            for (int i = 1; i < prices.Length; i++)
            {
                left[i] = Math.Max(left[i - 1], prices[i] - minLeft);
                minLeft = Math.Min(minLeft, prices[i]);
            }

            for (int i = n - 2; i >= 0; i--)
            {
                right[i] = Math.Max(right[i + 1], maxRight - prices[i]);
                maxRight = Math.Max(maxRight, prices[i]);
            }

            int max = 0;
            for (int i = 0; i < n - 1; i++)
            {
                max = Math.Max(max, left[i] + right[i + 1]);
            }

            return max;
        }

        public class Trie
        {
            public class TrieNode
            {
                public string Word { get; set; }

                public TrieNode[] Children { get; set; } = new TrieNode[26];
            }

            public TrieNode[] root = new TrieNode[26];

            public Trie(string[] words = null)
            {
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
                var parent = root;
                for (int i = 0; i < word.Length; i++)
                {
                    var chIdx = word[i] - 'a';
                    var existingNode = parent[chIdx];
                    var newNode = new TrieNode { Word = i == word.Length - 1 ? word : null };
                    if (existingNode != null)
                    {
                        if (newNode.Word != null) existingNode.Word = newNode.Word;
                        parent = existingNode.Children;
                    }
                    else
                    {
                        parent[chIdx] = newNode;
                        parent = newNode.Children;
                    }
                }
            }
        }

        public IList<string> FindWords(char[][] board, string[] words)
        {
            var lst = new HashSet<string>();
            if (board == null || board.Length == 0 || words == null || words.Length == 0) return lst.ToList();
            var trie = new Trie(words);

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    FindWordRec(board, i, j, trie.root, ref lst);
                }
            }

            return lst.ToList();
        }

        private void FindWordRec(char[][] board, in int i, in int j, Trie.TrieNode[] options, ref HashSet<string> lst)
        {
            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] == '0') return;

            var existingNode = options[board[i][j] - 'a'];
            if (existingNode != null)
            {
                if (existingNode.Word != null)
                {
                    lst.Add(existingNode.Word);
                    existingNode.Word = null;
                }

                var temp = board[i][j];
                board[i][j] = '0';
                FindWordRec(board, i, j - 1, existingNode.Children, ref lst);
                FindWordRec(board, i, j + 1, existingNode.Children, ref lst);
                FindWordRec(board, i + 1, j, existingNode.Children, ref lst);
                FindWordRec(board, i - 1, j, existingNode.Children, ref lst);
                board[i][j] = temp;
            }
        }

        public int longestValidParentheses(String s)
        {
            int left = 0, right = 0, maxlength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    left++;
                }
                else
                {
                    right++;
                }

                if (left == right)
                {
                    maxlength = Math.Max(maxlength, 2 * right);
                }
                else if (right > left)
                {
                    left = right = 0;
                }
            }
            left = right = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(')
                {
                    left++;
                }
                else
                {
                    right++;
                }

                if (left == right)
                {
                    maxlength = Math.Max(maxlength, 2 * left);
                }
                else if (left > right)
                {
                    left = right = 0;
                }
            }
            return maxlength;
        }

        public int LengthLongestPath(string input)
        {
            var rs = new StreamReader(new MemoryStream(Encoding.ASCII.GetBytes(input)));

            string line;
            int maxFileLength = 0;
            var prefixesLength = new List<int> { 0 };
            while ((line = rs.ReadLine()) != null)
            {
                int i = 0;
                while (line[i] == '\t')
                    i++;
                while (i + 1 < prefixesLength.Count)
                    prefixesLength.RemoveAt(prefixesLength.Count - 1);

                prefixesLength.Add(prefixesLength[prefixesLength.Count - 1] + 1 /*1 For forward slash / */ + (line.Length - i));

                if (line.IndexOf('.', i, line.Length - i) != -1)
                {
                    maxFileLength = Math.Max(maxFileLength, prefixesLength[prefixesLength.Count - 1]);
                }
            }

            return maxFileLength == 0 ? maxFileLength : maxFileLength - 1;
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            var option = new List<int>();

            Array.Sort(candidates);

            CombinationSumRec(candidates, 0, target, option, ref result);
            return result;
        }

        private void CombinationSumRec(int[] candidates, int i, in int target, List<int> option, ref List<IList<int>> result)
        {
            if (target == 0)
                result.Add(new List<int>(option));
            if (target < 0 || i == candidates.Length) return;

            for (int j = i; j < candidates.Length; j++)
            {
                if (candidates[j] <= target)
                {
                    option.Add(candidates[j]);
                    CombinationSumRec(candidates, j, target - candidates[j], option, ref result);
                    option.RemoveAt(option.Count - 1);
                }
                else break;
            }
        }

        // Review this solution https://leetcode.com/problems/maximum-profit-in-job-scheduling/discuss/408957/DP%2BBinary-search-(Java)
        public class JobInfo
        {
            public int start;
            public int end;
            public int profit;

            public override string ToString()
            {
                return $"{start}|{end}|{profit}";
            }
        }

        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            var jobs = new List<JobInfo>();
            for (int i = 0; i < startTime.Length; i++)
                jobs.Add(new JobInfo { start = startTime[i], end = endTime[i], profit = profit[i] });

            jobs = jobs.OrderBy(job => job.start)
                .ToList();

            var dp = new int?[jobs.Count];

            return JobSchedulingRec(jobs, 0, ref dp);
        }

        private int JobSchedulingRec(List<JobInfo> jobs, int i, ref int?[] dp)
        {
            if (i == jobs.Count)
                return 0;

            if (dp[i].HasValue)
                return dp[i].Value;

            var currentJob = jobs[i];
            var next = GetNextIndex(jobs, i);
            var includeProfit = currentJob.profit + (next == -1 ? 0 : JobSchedulingRec(jobs, next, ref dp));
            var excludeProfit = JobSchedulingRec(jobs, i + 1, ref dp);

            dp[i] = Math.Max(includeProfit, excludeProfit);
            return dp[i].Value;
        }

        private int GetNextIndex(List<JobInfo> jobs, in int i)
        {
            for (int j = i + 1; j < jobs.Count; j++)
                if (jobs[j].start >= jobs[i].end) return j;
            return -1;
        }

        public int BinarySearch_MinMaxIndex(List<JobInfo> nums, int start, in JobInfo target, bool findMinIndex = true)
        {
            int low = start, high = nums.Count - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if ((findMinIndex && nums[mid].start < target.start) || (!findMinIndex && nums[mid].start <= target.start))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low >= 0 ? low : ~low;
        }

        public int[] SearchRange(int[] nums, int target)
        {
            var leftPos = BinarySearch_MinMaxIndex(nums, target, true);
            if (leftPos == nums.Length || nums[leftPos] != target)
                return new[] { -1, -1 };

            var rightPos = BinarySearch_MinMaxIndex(nums, target, false);
            return new[] { leftPos, rightPos - 1 };
        }

        public int BinarySearch_MinMaxIndex(int[] nums, in int target, bool findMinIndex = true)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                // These 2 lines equal to if statement but less readable
                //int comparer = findMinIndex ? -1 : 0;
                //if (nums[mid] - target <= comparer)
                if ((findMinIndex && nums[mid] < target) || (!findMinIndex && nums[mid] <= target))
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low >= 0 ? low : ~low;
        }

        public int SearchB(int[] nums, int target, bool leftSide)
        {
            int left = 0, right = nums.Length, mid;

            while (left < right)
            {
                mid = left + (right - left) / 2;

                if (nums[mid] > target || (leftSide && nums[mid] == target))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            var segTree = new NumArraySegTree(nums).segTree;
            int count = 0;
            for (int i = 1; i < segTree.Length; i++)
            {
                var sumRange = segTree[i];
                if (sumRange >= lower && sumRange <= upper)
                    count++;
            }

            for (int i = nums.Length - 1; i > 0; i--)
            {
                var next = 2 * i + 2;
                var prev = 2 * i - 1;

                if (next < segTree.Length)
                {
                    var sumRange = segTree[next] + segTree[i];
                    if (sumRange >= lower && sumRange <= upper)
                        count++;
                }

                if (prev > 0)
                {
                    var sumRange = segTree[next] + segTree[i];
                    if (sumRange >= lower && sumRange <= upper)
                        count++;
                }
            }

            return count;
        }

        public class NumArrayBit
        {
            public int[] bitArray;
            public NumArrayBit(int[] nums)
            {
                bitArray = new int[nums.Length + 1];
                for (int i = 0; i < nums.Length; i++)
                {
                    Update(i, nums[i]);
                }
            }

            public void Update(int i, int val)
            {
                var diff = val - SumRange(i, i);
                i++;
                while (i < bitArray.Length)
                {
                    bitArray[i] += diff;
                    i += i & -i;
                }
            }

            public int SumRange(int i, int j)
            {
                if (j < i) return 0;
                return Get(j) - Get(i - 1);
            }

            private int Get(int i)
            {
                if (i < 0) return 0;
                int sum = 0;
                i++;
                while (i > 0)
                {
                    sum += bitArray[i];
                    i -= i & -i;
                }
                return sum;
            }
        }

        public class NumArraySegTree
        {
            public int[] segTree;
            private int n = 0;

            public NumArraySegTree(int[] nums)
            {
                this.n = nums.Length;
                segTree = new int[n * 2];

                for (int i = 0; i < n; i++)
                    segTree[i + n] = nums[i];

                for (int i = n - 1; i > 0; i--)
                    segTree[i] = segTree[2 * i] + segTree[2 * i + 1];
            }

            public void Update(int i, int val)
            {
                i += n;
                var diff = val - segTree[i];

                while (i > 0)
                {
                    segTree[i] += diff;
                    i /= 2;
                }
            }

            public int SumRange(int i, int j)
            {
                i += n;
                j += n;
                int sum = 0;
                while (i <= j)
                {
                    if (i % 2 == 1) sum += segTree[i++];
                    if (j % 2 == 0) sum += segTree[j--];

                    i /= 2;
                    j /= 2;
                }

                return sum;
            }
        }

        public string LastSubstring1(string s)
        {
            int n = s.Length, i = 0, j = 1, k = 0;
            while (j + k < n)
            {
                if (s[i + k] == s[j + k]) k++;
                else if (s[i + k] < s[j + k])
                {
                    i = j++;
                    k = 0;
                }
                else
                {
                    j += k + 1;
                    k = 0;
                }
            }
            return s.Substring(i);
        }

        public int FirstMissingPositive(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] > 0 && nums[i] <= nums.Length && nums[i] != nums[nums[i] - 1])
                {
                    var targetIndex = nums[i] - 1;
                    var temp = nums[targetIndex];
                    nums[targetIndex] = nums[i];
                    nums[i] = temp;
                }
                else i++;
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1) return i + 1;
            }

            return i + 1;
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var currentPatchEnd = MoveK(head, k);
            if (currentPatchEnd == null) return head;

            var nextPatchStart = currentPatchEnd.next;
            ListNode prev = nextPatchStart, node = head;

            while (node != nextPatchStart)
            {
                var temp = node.next;
                node.next = prev;
                prev = node;
                node = temp;
            }

            head.next = ReverseKGroup(nextPatchStart, k);

            return prev;
        }

        private ListNode MoveK(ListNode head, int k)
        {
            while (--k > 0 && head != null)
                head = head.next;

            return head;
        }

        public bool IsMatch1(string s, string p)
        {
            var dp = new bool?[s.Length + 1, p.Length + 1];

            return IsMatchRec1(s, p, 0, 0, ref dp);
        }

        private bool IsMatchRec1(string s, string p, int si, int pi, ref bool?[,] dp)
        {
            if (pi == p.Length) return si == s.Length;
            if (dp[si, pi].HasValue) return dp[si, pi].Value;

            var isFirstMatch = si < s.Length && (s[si] == p[pi] || p[pi] == '.');

            var isMatch = false;
            if (pi + 1 < p.Length && p[pi + 1] == '*')
            {
                isMatch = (isFirstMatch && IsMatchRec1(s, p, si + 1, pi, ref dp)) ||
                          IsMatchRec1(s, p, si, pi + 2, ref dp);
            }
            else if (isFirstMatch)
            {
                isMatch = IsMatchRec1(s, p, si + 1, pi + 1, ref dp);
            }

            dp[si, pi] = isMatch;

            return isMatch;
        }

        public string DecodeString(string s)
        {
            int i = 0;
            return DecodeStringRec(s, ref i);
        }

        private string DecodeStringRec(string s, ref int i)
        {
            var sb = new StringBuilder();
            while (i < s.Length)
            {
                if (!char.IsDigit(s[i]))
                {
                    sb.Append(s[i]);
                    i++;
                }
                else
                {
                    var num = 0;
                    while (char.IsDigit(s[i]))
                    {
                        num = num * 10 + (s[i] - '0');
                        i++;
                    }

                    i++;

                    var str = DecodeStringRec(s, ref i);

                    while (num > 0)
                    {
                        sb.Append(str);
                        num--;
                    }

                    i++;
                }
            }

            return sb.ToString();
        }


        public int CountSubstrings(string s)
        {
            var dp = new bool[s.Length, s.Length];

            int totalCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                dp[i, i] = true;
                totalCount++;
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        if (j - i == 1 || dp[i + 1, j - 1])
                        {
                            dp[i, j] = true;
                            totalCount++;
                        }
                    }
                }
            }

            return totalCount;
        }

        public int Rob(int[] nums)
        {
            var dp = new int?[nums.Length];

            return RobRec(nums, 0, ref dp);
        }

        private int RobRec(int[] nums, int i, ref int?[] dp)
        {
            if (i >= nums.Length) return 0;

            if (dp[i].HasValue) return dp[i].Value;

            var option1 = RobRec(nums, i + 2, ref dp);
            if (option1 != -1)
                option1 += nums[i];

            var option2 = RobRec(nums, i + 1, ref dp);

            dp[i] = Math.Max(option1, option2);

            return dp[i].Value;
        }
    }
}