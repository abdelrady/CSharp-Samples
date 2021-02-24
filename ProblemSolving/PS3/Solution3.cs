using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace PS3
{
    public class Solution3
    {
        private int modulo = 1_000_000_007;
        
        void Main(string[] args)
        {
            var sln = new Solution();

            //sln.CoinChangeList(new[] { 1, 2, 5 }, 11).Print();

            //sln.FindReplaceString("abcd", new[] { 0, 2 }, new[] { "ab", "ec" }, new[] { "eee", "ffff" }).Print();

            //sln.TotalFruit(new[] {0, 1, 2, 2}).Print();

            //sln.PeakIndexInMountainArray(new []{24, 69, 100, 99, 79, 78, 67, 36, 26, 19}).Print();

            //var bit = new Solution.CountSmallerBIT();
            //bit.countSmaller(new[] { 5, 7, 6, -3 }).Print();

            //var bit = new Solution.NumArray(new[] { 1, 3, 5 });
            //bit.SumRange(0, 2).Print();
            //bit.Update(1, 2);
            //bit.SumRange(0, 2).Print();

            //sln.NextClosestTime("19:34").Print();
            //sln.NextClosestTime("23:59").Print();

            //sln.MaxDistToClosest(new[] { 1, 0, 0, 0, 1, 0, 1 }).Print();
            //sln.MaxDistToClosest(new[] { 0, 1 }).Print();

            //sln.Interpret("G()(al)").Print();

            //sln.MaxOperations(new []{ 1, 2, 3, 4 }, 5).Print();
            //sln.MaxOperations(new []{ 3, 1, 3, 4, 3 }, 6).Print();

            //sln.ConcatenatedBinary(12).Print();

            //var bin1 = new int?[] { 1, 2, 3, 4, 5, 6, null, null, null, 7, 8 }.BuildTreeFromArray();
            //var bin2 = new int?[] { 1, 3, 2, null, 6, 4, 5, null, null, null, null, 8, 7 }.BuildTreeFromArray();
            //sln.FlipEquiv(bin1, bin2).Print();

            //var clndr = new Solution.MyCalendar();
            //clndr.Book(47, 50).Print();
            //clndr.Book(33, 41).Print();
            //clndr.Book(39, 45).Print();
            //clndr.Book(33, 42).Print();
            //clndr.Book(25, 32).Print();
            //clndr.Book(26, 35).Print();
            //clndr.Book(19, 25).Print();
            //clndr.Book(3, 8).Print();
            //clndr.Book(8, 13).Print();
            //clndr.Book(18, 27).Print();

            //clndr.Book(10, 20).Print();
            //clndr.Book(15, 25).Print();
            //clndr.Book(20, 30).Print();

            //var clndr = new Solution.MyCalendarTwo();
            //clndr.Book(10, 20).Print();
            //clndr.Book(50, 60).Print();
            //clndr.Book(10, 40).Print();
            //clndr.Book(5, 15).Print();
            //clndr.Book(5, 10).Print();
            //clndr.Book(25, 55).Print();

            //sln.Reverse(1534236469).Print();

            //sln.SplitArray(new[] { 7, 2, 5, 10, 8 }, 2).Print();
            //sln.SplitArray(new[] { 1, 4, 4 }, 3).Print();
            //sln.SplitArray(new[] { 2, 3, 1, 1, 1, 1, 1 }, 5).Print();

            //sln.CalcEquation(new List<IList<string>>
            //{
            //    new List<string>{"a","b"},
            //    new List<string>{"b","c"},
            //    new List<string>{"bc","cd"},
            //},
            //    new[] { 1.5, 2.5, 5.0 },
            //    new List<IList<string>>
            //    {
            //        new List<string>{"a","c"},
            //        new List<string>{"c","b"},
            //        new List<string>{"bc","cd"},
            //        new List<string>{"cd","bc"},
            //    }).Print();

            //sln.CountNodes(new TreeNode(1)).Print();

            //sln.Shuffle(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 5);

            //sln.MyPow(2.00000, - 2147483648).Print();

            //sln.CountPrimes(15).Print();

            //sln.CanPartition(new []{ 1, 5, 5, 11 }).Print();

            //sln.MincostTickets(new[] {1, 4, 6, 7, 8, 20}, new[] {2, 7, 15}).Print();

            //sln.CountSmaller(new[] { 2, 0, 1 }).Print();

            //var arr = new[]
            //{
            //    new []{2147483647,0,2147483647,2147483647,0,2147483647,-1,2147483647}
            //};
            //sln.WallsAndGates(arr);
            //arr.Print();

            //sln.MinEatingSpeed(new[] { 30, 11, 23, 4, 20 }, 6).Print();
            //sln.MinEatingSpeed(new[] { 312884470 }, 968709470).Print();

            //sln.MincostTickets(new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 }, new []{ 2, 7, 15 }).Print();

            //sln.IsSubsequence("acb", "ahbgdc").Print();

            //sln.MaxIndexBinarySearch(new []{1,2,2,4,20}, 6).Print();

            //sln.FindClosestElements(new[] {0, 0, 1, 2, 3, 3, 4, 7, 7, 8},
            //    3,
            //    5).Print();

            //sln.MaximizeSweetness(new []{5, 6, 7, 8, 9, 1, 2, 3, 4}, 8).Print();

            //sln.minmaxGasDist(new []{1,2,3,4,5,6,7,8,10}, 10).Print();

            //sln.FindRadius(new []{ 1, 5, 15 }, new []{3, 6}).Print();

            //sln.FindRadius(
            //    new[] {282475249, 622650073, 984943658, 144108930, 470211272, 101027544, 457850878, 458777923},
            //    new[]
            //    {
            //        823564440, 115438165, 784484492, 74243042, 114807987, 137522503, 441282327, 16531729, 823378840,
            //        143542612
            //    }).Print();

            //var arr = new[]
            //{
            //    new []{'X','O','X','O','X','O','O','O','X','O'},
            //    new []{'X','O','O','X','X','X','O','O','O','X'},
            //    new []{'O','O','O','O','O','O','O','O','X','X'},
            //    new []{'O','O','O','O','O','O','X','O','O','X'},
            //    new []{'O','O','X','X','O','X','X','O','O','O'},
            //    new []{'X','O','O','X','X','X','O','X','X','O'},
            //    new []{'X','O','X','O','O','X','X','O','X','O'},
            //    new []{'X','X','O','X','X','O','X','O','O','X'},
            //    new []{'O','O','O','O','X','O','X','O','X','O'},
            //    new []{'X','X','O','X','X','X','X','O','O','O'}
            //};
            //sln.Solve(arr);
            //arr.Print();

            //sln.MinDifficulty(new []{ 11, 111, 22, 222, 33, 333, 44, 444 }, 6).Print();
            //sln.MinDifficulty(new[] { 7, 1, 7, 1, 7, 1 }, 3).Print();
            //sln.MinDifficulty(new[] { 920, 539, 840, 271, 685, 491, 802, 635, 240, 339, 353, 483, 65, 945, 122, 944, 638, 618, 873, 382, 183, 891, 582, 839, 781, 331, 178, 888, 437, 490, 411, 47, 327, 977, 135, 408, 454, 963 }, 1).Print();

            //sln.JobScheduling(new[] { 1, 2, 3, 4, 6 }, new[] { 3, 5, 10, 6, 9 }, new[] { 20, 20, 100, 70, 60 }).Print();
            //sln.JobScheduling(new[] { 1, 1, 1 }, new[] { 2, 3, 4 }, new[] { 5, 6, 4 }).Print();

            //sln.Crawl("http://news.yahoo.com/news/topics/", new Solution.HtmlParser()).Print();

            //sln.CanCompleteCircuit(new[] { 1, 2, 3, 4, 5 }, new[] { 3, 4, 5, 1, 2 }).Print();

            //sln.MinPartitions("27346209830709182346").Print();

            //sln.CanPartitionKSubsets(new[] { 10, 10, 10, 7, 7, 7, 7, 7, 7, 6, 6, 6 }, 3).Print();

            //sln.MaxSumAfterPartitioning(new []{ 1, 4, 1, 5, 7, 3, 6, 1, 9, 9, 3 }, 4).Print();

            //sln.getLengthOfOptimalCompression("aaabcccd", 2).Print();
            //new Solution.StringCompressionII().getLengthOfOptimalCompression("aaabcccd", 2).Print();

            //sln.MincostToHireWorkers(new[] { 10, 20, 5 }, new[] { 70, 50, 30 }, 2).Print();

            //sln.NextClosestTime("23:59").Print();

            //sln.MinmaxGasDist(new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9).Print();

            //sln.MinmaxGasDist(new[] { 23, 24, 36, 39, 46, 56, 57, 65, 84, 98 }, 1).Print();

            //(1e-6).ToString("F10").Print();
            //(1.0 / (10 ^ 6)).Print();


            //var _6 = new Solution.Codec5.Node(6);
            //var _5 = new Solution.Codec5.Node(5);
            //var _4 = new Solution.Codec5.Node(4);
            //var _3 = new Solution.Codec5.Node(3, new List<Solution.Codec5.Node> { _5, _6 });
            //var _2 = new Solution.Codec5.Node(2);
            //var _1 = new Solution.Codec5.Node(1, new List<Solution.Codec5.Node> { _2, _3, _4 });

            //var codec = new Solution.Codec5();
            //var str = codec.serialize(_1);
            //str.Print();
            //var tree = codec.deserialize(str);
            //var tree = codec.deserialize("1,!,2,3,4,5,!,!,6,7,!,8,!,9,10,!,!,11,!,12,!,13,!,!,14");


            //var _6 = new Solution.Codec.Node(6);
            //var _5 = new Solution.Codec.Node(5);
            //var _4 = new Solution.Codec.Node(4);
            //var _3 = new Solution.Codec.Node(3, new List<Solution.Codec.Node> { _5, _6 });
            //var _2 = new Solution.Codec.Node(2);
            //var _1 = new Solution.Codec.Node(1, new List<Solution.Codec.Node> { _2, _3, _4 });
            //var codec = new Solution.Codec();
            //var newNtree = codec.encode(_1);

            //sln.FindAllConcatenatedWordsInADict(new[]
            //        {"cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat"})
            //    .Print();

            //sln.FindAllConcatenatedWordsInADict(new[]
            //        {"a","b","ab","abc", "c"})
            //    .Print();

            //var words = ReadInputFile("430517822.txt").Replace("\"", "").Split(",").ToArray();

            //sln.FindAllConcatenatedWordsInADict(words)
            //    .Print();

            //var streamChecker = new Solution.StreamChecker(new[] { "cd", "f", "kl" });
            //streamChecker.Query('a').Print();          // return false
            //streamChecker.Query('b').Print();          // return false
            //streamChecker.Query('c').Print();          // return false
            //streamChecker.Query('d').Print();          // return true, because 'cd' is in the wordlist
            //streamChecker.Query('e').Print();          // return false
            //streamChecker.Query('f').Print();          // return true, because 'f' is in the wordlist
            //streamChecker.Query('g').Print();          // return false
            //streamChecker.Query('h').Print();          // return false
            //streamChecker.Query('i').Print();          // return false
            //streamChecker.Query('j').Print();          // return false
            //streamChecker.Query('k').Print();          // return false
            //streamChecker.Query('l').Print();          // return true, because 'kl' is in the wordlist


            //var acs = new Solution.AutocompleteSystem(new[] { "i love you", "island", "iroman", "i love leetcode" }, new[] { 5, 3, 2, 2 });
            //acs.Input('i').Print();
            //acs.Input(' ').Print();
            //acs.Input('a').Print();
            //acs.Input('#').Print();
            //acs.Input('i').Print();
            //acs.Input(' ').Print();
            //acs.Input('a').Print();
            //acs.Input('#').Print();
            //acs.Input('i').Print();
            //acs.Input(' ').Print();
            //acs.Input('a').Print();
            //acs.Input('#').Print();

            //sln.PalindromePairs(new[] { "abcd", "dcba", "lls", "s", "sssll" }).Print();
            //sln.PalindromePairs(new[] { "a", "" }).Print();

            //var p = new Solution.EulerPath();
            //p.crackSafe(2, 2).Print();

            //sln.FindSecretWord(new[] { "acckzz", "ccbazz", "eiowzz", "abcczz" }, new Solution.Master());

            //sln.CombinationSum(new[] { 2, 3, 6, 7 }, 7).Print();

            //sln.JudgePoint24(new []{ 4, 1, 8, 7 }).Print();
            //sln.JudgePoint24(new []{ 1, 2, 1, 2 }).Print();
            //sln.JudgePoint24(new []{ 1, 3, 4, 6}).Print();
            //sln.JudgePoint24(new[]{ 3, 9, 7, 7 }).Print();

            //sln.HitBricks(new[]
            //    {
            //        new[] {1, 0, 0, 0},
            //        new[] {1, 1, 1, 0},
            //    },
            //    new[] {new []{ 1, 0 } }).Print();

            //sln.StrobogrammaticInRange("50", "100").Print();

            //sln.ConfusingNumber(6).Print();

            //sln.ConfusingNumber(916).Print();
            //sln.ConfusingNumberII(20).Print();

            //var wf = new Solution.WordFilter(new[] { "cabaabaaaa", "ccbcababac", "bacaabccba", "bcbbcbacaa", "abcaccbcaa", "accabaccaa", "cabcbbbcca", "ababccabcb", "caccbbcbab", "bccbacbcba" });
            //wf.F("bccbacbcba", "a").Print();
            //wf.F("ab", "abcaccbcaa").Print();
            //wf.F("a", "aa").Print();
            //wf.F("cabaaba", "abaaaa").Print();
            //wf.F("cacc", "accbbcbab").Print();
            //wf.F("ccbcab", "bac").Print();
            //wf.F("bac", "cba").Print();
            //wf.F("ac", "accabaccaa").Print();
            //wf.F("bcbb", "aa").Print();
            //wf.F("ccbca", "cbcababac").Print();

            //sln.IsMatch("aa", "a").Print();
            //sln.IsMatch("aa", "*").Print();
            //sln.IsMatch("cb", "?a").Print();
            //sln.IsMatch("adceb", "*a*b").Print();
            //sln.IsMatch("", "******").Print();
            //sln.IsMatch("acdcb", "a*c?b").Print();

            //var tree = new int?[] {8, 3, 10, 1, 6, null, 14, null, null, 4, 7, 13}.BuildTreeFromArray();
            //var tree = new int?[] { 1, null, 2, null, 0, 3 }.BuildTreeFromArray();
            //sln.MaxAncestorDiff(tree).Print();

            //var firstMoveBoard = sln.UpdateBoard(new[]
            //{
            //    new []{'E', 'E', 'E', 'E', 'E'},
            //    new []{'E', 'E', 'M', 'E', 'E'},
            //    new []{'E', 'E', 'E', 'E', 'E'},
            //    new []{'E', 'E', 'E', 'E', 'E'},
            //},
            //    new[] { 3, 0 });
            //firstMoveBoard.Print();
            //Console.WriteLine();
            //sln.UpdateBoard(firstMoveBoard, new[] { 0, 2 }).Print();

            //sln.MaxSumOfThreeSubarrays(new[] { 1, 2, 1, 2, 6, 7, 5, 1 }, 2).Print();

            //sln.MinWindow("cnhczmccqouqadqtmjjzl", "mm").Print();
            //sln.MinWindow("fgrqsqsnodwmxzkzxwqegkndaa", "kzed").Print();

            //sln.SumFourDivisors(new []{ 21, 4, 7 }).Print();

            //sln.SelfDividingNumbers(1,22).Print();

            //sln.CanArrange(new []{1, 2, 3, 4, 5, 10, 6, 7, 8, 9}, 5).Print();

            //sln.IsUgly(4).Print();

            //sln.NumPrimeArrangements(100).Print();

            //sln.CountPrimes(6).Print();

            //sln.NumSquares(12).Print();
            //sln.NumSquares(43).Print();

            //sln.StringShift("abcdefg", new []{new []{0,1}, new []{1, 4}}).Print();

            //sln.GetPermutation(4, 10).Print();

            //sln.IslandPerimeter(new[]
            //{
            //    new []{0, 1, 0, 0},
            //    new []{1, 1, 1, 0},
            //    new []{0, 1, 0, 0},
            //    new []{1, 1, 0, 0},
            //}).Print();

            //sln.GroupStrings(new[] { "abc", "bcd", "acef", "xyz", "az", "ba", "a", "z" }).Print();

            //var tree = sln.Str2tree("4(2(3)(1))(6(5))");

            //sln.MaximumUniqueSubarray(new []{ 5, 2, 1, 2, 5, 2, 1, 2, 5 }).Print();

            //sln.ReformatNumber("1-23-45 6").Print();
            //sln.ReformatNumber("123 4-567").Print();
            //sln.ReformatNumber("123 4-5678").Print();
            //sln.ReformatNumber("12").Print();
            //sln.ReformatNumber("--17-5 229 35-39475 ").Print();

            //var sln1 = new Solution.Solution1();
            //sln1.MaxResult(new []{ 1, -1, -2, 4, -7, 3 }, 2).Print();
            //sln1.MaxResult(new []{ 10, -5, -2, 4, 0, 3 }, 3).Print();
            //sln1.MaxResult(new []{ 1, -5, -20, 4, -1, 3, -6, -3 }, 2).Print();

            //sln.LargestIsland(new[]
            //{
            //    new[] {1,0,1},
            //    new[] {0,0,0},
            //    new[] {0,1,1},
            //}).Print();

            //sln.NumFriendRequests(new[] { 73, 106, 39, 6, 26, 15, 30, 100, 71, 35, 46, 112, 6, 60, 110 }).Print();

            //sln.NumSubseq(new[] { 3, 5, 6, 7 }, 9).Print();

            //sln.AddBoldTag("abcxyz123", new[] {"abc", "123"}).Print();

            //sln.IsValidPalindrome("abcdeca", 1).Print();

            //sln.IsValidPalindrome(
            //    "fcgihcgeadfehgiabegbiahbeadbiafgcfchbcacedbificicihibaeehbffeidiaiighceegbfdggggcfaiibefbgeegbcgeadcfdfegfghebcfceiabiagehhibiheddbcgdebdcfegaiahibcfhheggbheebfdahgcfcahafecfehgcgdabbghddeadecidicchfgicbdbecibddfcgbiadiffcifiggigdeedbiiihfgehhdegcaffaggiidiifgfigfiaiicadceefbhicfhbcachacaeiefdcchegfbifhaeafdehicfgbecahidgdagigbhiffhcccdhfdbd",
            //    216).Print();

            //sln.FindMedianSortedArrays(new []{1,3}, new []{2}).Print();

            //sln.NumDecodings("*********").Print();

            //sln.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2).Print();

            //sln.TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2).Print();

            //sln.LongestDupSubstring("nnpxouomcofdjuujloanjimymadkuepightrfodmauhrsy").Print();

            //sln.CalcPrefixLen("cabcababc").Print();

            //sln.FindLength(new[] { 1, 2, 3, 2, 1 }, new[] { 3, 2, 1, 4, 7 }).Print();

            //sln.ShortestPalindrome("aacecaaa").Print();

            //sln.QueryString("0110", 3).Print();

            //sln.RepeatedSubstringPattern("abab").Print();

            //sln.FindAnagrams("abab", "ab").Print();

            //(int.MaxValue - int.MinValue).Print();

            //sln.MajorityElement(new[] {4, 2, 1, 1}).Print();

            //sln.IsMajorityElement(new[] { 2, 4, 5, 5, 5, 5, 5, 6, 6 }, 5).Print();

            //sln.CountPairs(new[] {1, 1, 1, 3, 3, 3, 7}).Print();

            //sln.WaysToSplit(new[] { 1, 2, 2, 2, 5, 0 }).Print();

            //sln.BuildTree(new[] {3, 9, 20, 15, 7}, new[] {9, 3, 15, 20, 7}).Print();
            //new Solution.BTreeConstructPreOrder().buildTree(new[] {3, 9, 20, 15, 7}, new[] {9, 3, 15, 20, 7}).Print();
            //new Solution.BTreeConstructPostOrder().BuildTree(new[] { 9, 3, 15, 20, 7 }, new[] { 9, 15, 7, 20, 3 }).Print();

            //sln.WordBreak("catsanddog", new List<string>{ "cat", "cats", "and", "sand", "dog" }).Print();

            //sln.Rob(new[] { 2, 7, 9, 3, 1 }).Print();

            //sln.LastSubstring1("cacacb").Print();

            //sln.CountRangeSum(new[] { 0, -3, -3, 1, 1, 2 }, 3, 5).Print();
        }

        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var dp = new List<string>[s.Length];
            return WordBreakConstructRec(s, 0, wordDict.ToHashSet(), ref dp);
        }

        private IList<string> WordBreakConstructRec(string s, int i, HashSet<string> wordsDic, ref List<string>[] dp)
        {
            if (i == s.Length)
                return new List<string> {""};

            if (dp[i] != null)
                return dp[i];

            var options = new List<string>();
            var sb = new StringBuilder();
            for (int j = i; j < s.Length; j++)
            {
                sb.Append(s[j]);
                var word = sb.ToString();
                if (wordsDic.Contains(word))
                {
                    var restWords = WordBreakConstructRec(s, j + 1, wordsDic, ref dp);
                    if (restWords.Count > 0)
                    {
                        foreach (var restWord in restWords)
                            options.Add(word + (restWord.Length > 0 ? (" " + restWord) : restWord));
                    }
                }
            }

            dp[i] = options;

            return dp[i];
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dic = new Dictionary<string, List<string>>();
            foreach (var str in strs)
            {
                var hash = new int[26];
                for (int i = 0; i < str.Length; i++)
                    hash[str[i] - 'a']++;

                var sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i]);
                    sb.Append('#');
                }

                var hashStr = sb.ToString();
                if (dic.ContainsKey(hashStr))
                {
                    dic[hashStr].Add(str);
                }
                else
                {
                    dic.Add(hashStr, new List<string> { str });
                }
            }

            var result = new List<IList<string>>();
            foreach (var list in dic.Values)
                result.Add(list);

            return result;
        }


        public class Solution10
        {
            public class Node
            {
                public int val;
                public IList<Node> children;

                public Node() { }

                public Node(int _val)
                {
                    val = _val;
                }

                public Node(int _val, IList<Node> _children)
                {
                    val = _val;
                    children = _children;
                }
            }

            public IList<int> Postorder(Node root)
            {
                if (root == null) return new List<int>();

                var st = new Stack<Node>();
                st.Push(root);
                var ls = new LinkedList<int>();
                while (st.Count > 0)
                {
                    var node = st.Pop();
                    ls.AddFirst(node.val);
                    foreach (var child in node.children)
                    {
                        if (child != null)
                            st.Push(child);
                    }
                }

                return ls.ToList();
            }

            public IList<IList<int>> LevelOrder(Node root)
            {
                var res = new List<IList<int>>();
                if (root == null) return res;
                var q = new Queue<Node>();
                q.Enqueue(root);
                while (q.Count > 0)
                {
                    var qCount = q.Count;
                    var lst = new List<int>();
                    for (int i = 0; i < qCount; i++)
                    {
                        var node = q.Dequeue();
                        lst.Add(node.val);

                        foreach (var child in node.children)
                        {
                            q.Enqueue(child);
                        }
                    }
                    res.Add(lst);
                }

                return res;
            }

            public IList<int> Preorder(Node root)
            {
                if (root == null) return new List<int>();

                var st = new Stack<Node>();
                st.Push(root);
                var ls = new List<int>();
                while (st.Count > 0)
                {
                    var node = st.Pop();
                    ls.Add(node.val);
                    for (int i = node.children.Count - 1; i >= 0; i--)
                    {
                        st.Push(node.children[i]);
                    }
                }

                return ls.ToList();
            }
        }

        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null) return new List<int>();

            var st = new Stack<TreeNode>();
            st.Push(root);
            var ls = new LinkedList<int>();
            while (st.Count > 0)
            {
                var node = st.Pop();
                ls.AddFirst(node.val);
                if (node.left != null)
                    st.Push(node.left);
                if (node.right != null)
                    st.Push(node.right);
            }

            return ls.ToList();
        }

        public IList<int> PostorderTraversal1(TreeNode root)
        {
            var lst = new List<int>();
            PostorderTraversalRec(root, lst);

            return lst;
        }

        private void PostorderTraversalRec(TreeNode root, List<int> lst)
        {
            if (root == null) return;
            PostorderTraversalRec(root.left, lst);
            PostorderTraversalRec(root.right, lst);
            lst.Add(root.val);
        }

        public class BTreeConstructPostOrder
        {
            private int inIdx = 0;
            private int post = 0;

            public TreeNode BuildTree(int[] inorder, int[] postorder)
            {
                post = postorder.Length - 1;
                inIdx = inorder.Length - 1;
                return Build(postorder, inorder, int.MinValue);
            }

            private TreeNode Build(int[] postorder, int[] inorder, in int max)
            {
                if (post < 0) return null;

                if (inorder[inIdx] == max)
                {
                    inIdx--;
                    return null;
                }

                var node = new TreeNode(postorder[post--]);

                node.right = Build(postorder, inorder, node.val);

                node.left = Build(postorder, inorder, max);

                return node;
            }
        }

        public class BTreeConstructPreOrder
        {
            private int inIdx = 0;
            private int pre = 0;

            public TreeNode buildTree(int[] preorder, int[] inorder)
            {
                return build(preorder, inorder, int.MinValue);
            }

            private TreeNode build(int[] preorder, int[] inorder, int stop)
            {
                if (pre >= preorder.Length) return null;
                if (inorder[inIdx] == stop)
                {
                    inIdx++;
                    return null;
                }
                TreeNode node = new TreeNode(preorder[pre++]);
                node.left = build(preorder, inorder, node.val);
                node.right = build(preorder, inorder, stop);
                return node;
            }
        }


        int rootIdx = 0;
        private Dictionary<int, int> treeNodesIndexDic;
        private int[] preorder;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || preorder.Length == 0) return null;
            this.preorder = preorder;
            treeNodesIndexDic = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
                treeNodesIndexDic.Add(inorder[i], i);
            return BuildTreeHelper(0, inorder.Length);
        }

        private TreeNode BuildTreeHelper(int left, in int right)
        {
            if (left == right) return null;
            var rootVal = preorder[rootIdx++];
            var root = new TreeNode(rootVal);
            var rootPos = treeNodesIndexDic[rootVal];

            root.left = BuildTreeHelper(left, rootPos);
            root.right = BuildTreeHelper(rootPos + 1, right);
            return root;
        }

        public int WaysToSplit(int[] nums)
        {
            int ways = 0;
            int[] subArraysSum = new int[3];
            WaysToSplitRec(nums, 0, 0, subArraysSum, ref ways);
            return ways;
        }

        private void WaysToSplitRec(int[] nums, int i, int subCount, int[] subArraysSum, ref int ways)
        {
            if (i == nums.Length)
            {
                if (subCount == 3 && subArraysSum[2] >= subArraysSum[1])
                    ways++;
                return;
            }

            if (subCount > 2) return;

            for (int j = i; j < nums.Length; j++)
            {
                subArraysSum[subCount] += nums[j];
                if (subCount == 0 || subArraysSum[subCount] >= subArraysSum[subCount - 1])
                    WaysToSplitRec(nums, j + 1, subCount + 1, subArraysSum, ref ways);
            }

            for (int j = i; j < nums.Length; j++)
                subArraysSum[subCount] -= nums[j];
        }

        public int CountPairs(int[] deliciousness)
        {
            int modulo = 1_000_000_007;
            Array.Sort(deliciousness);

            var sum = 0;
            for (int i = 0; i < deliciousness.Length; i++)
            {
                int res = 0;
                int dup = 0;
                for (int j = i + 1; j < deliciousness.Length; j++)
                {
                    var isValid = Math.Log(deliciousness[i] + deliciousness[j], 2) % 1 == 0;
                    if (isValid)
                    {
                        if (deliciousness[i] == deliciousness[j])
                            dup++;
                        else res++;
                    }
                }

                sum = ((sum % modulo) + (res % modulo)) % modulo;
                while (i + 1 < deliciousness.Length && deliciousness[i + 1] == deliciousness[i])
                {
                    i++;
                    sum = ((sum % modulo) + (res % modulo)) % modulo;
                }

                //int n = dup, k = 2, nck = 1;
                //for (int j = n - k + 1; j <= n; j++)
                //    nck *= j;
                //nck /= 2;
                int nck = (dup * (dup + 1)) / 2;

                sum = ((sum % modulo) + (nck % modulo)) % modulo;
            }

            return sum;
        }

        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            if (boxTypes == null || boxTypes.Length == 0 || truckSize == 0) return 0;
            Array.Sort(boxTypes, (arr1, arr2) => arr2[1] - arr1[1]);

            int i = 0, sum = 0;
            while (truckSize > 0 && i < boxTypes.Length)
            {
                var picked = Math.Min(truckSize, boxTypes[i][0]);
                sum += picked * boxTypes[i][1];
                truckSize -= boxTypes[i][0];
                i++;
            }

            return sum;
        }

        public bool IsMajorityElement(int[] nums, int target)
        {
            var minIndex = BinarySearch_Modified(nums, target);
            var maxIndex = BinarySearch_Modified(nums, target, false) - 1;

            return (maxIndex - minIndex + 1) > (nums.Length / 2);
        }


        public int BinarySearch_Modified(int[] nums, in int target, bool findMinIndex = true)
        {
            int low = 0, high = nums.Length - 1;
            int comparer = findMinIndex ? -1 : 0;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (nums[mid] - target <= comparer)
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

        public IList<int> MajorityElement(int[] nums)
        {
            int? candidateA = null, candidateB = null;
            int countA = 0, countB = 0;

            foreach (var num in nums)
            {
                if (candidateA == num)
                {
                    countA++;
                }
                else if (candidateB == num)
                {
                    countB++;
                }
                else if (countA == 0)
                {
                    candidateA = num;
                    countA++;
                }
                else if (countB == 0)
                {
                    candidateB = num;
                    countB++;
                }
                else
                {
                    countA--;
                    countB--;
                }
            }

            var res = new List<int>();

            countB = countA = 0;

            foreach (var num in nums)
            {
                if (num == candidateA)
                    countA++;
                if (num == candidateB)
                    countB++;
            }

            if (candidateA.HasValue && countA > nums.Length / 3)
                res.Add(candidateA.Value);
            if (candidateB.HasValue && countB > nums.Length / 3)
                res.Add(candidateB.Value);

            return res;
        }

        public IList<int> FindAnagrams(string s, string p)
        {
            long hashS = 0, hashP = 0, baseNum = 26, modulo = (long)Math.Pow(2, 32), lastBasePower = 1;

            var occ = new List<int>();
            for (int i = 0; i < p.Length; i++)
            {
                hashS = (hashS * baseNum % modulo + s[i] - 'a') % modulo;
                hashP = (hashP * baseNum % modulo + p[i] - 'a') % modulo;
                lastBasePower = lastBasePower * baseNum % modulo;
            }

            if (hashS == hashP) occ.Add(0);

            for (int i = p.Length; i < s.Length; i++)
            {
                hashS = ((hashS * baseNum % modulo) - (lastBasePower * s[i - p.Length])) % modulo;
                hashS = (hashS + (s[i] - 'a')) % modulo;
                if (hashS == hashP) occ.Add(i - p.Length + 1);
            }

            return occ;
        }


        public int RepeatedStringMatch(string a, string b)
        {
            var sb = new StringBuilder();
            int count = 0;
            while (sb.Length < b.Length)
            {
                sb.Append(a);
                count++;
            }

            if (sb.ToString().IndexOf(b) >= 0) return count;

            sb.Append(a);
            count++;
            if (sb.ToString().IndexOf(b) >= 0) return count;
            return -1;
        }


        public int RepeatedStringMatch1(string a, string b)
        {
            int n = b.Length;
            if (a.Contains(b)) return 1;
            if (b == string.Empty) return 0;
            var firstOcc = b.IndexOf(a);
            if (firstOcc < 0) return -1;
            if (!a.Contains(b.Substring(0, firstOcc))) return -1;
            var repeat = firstOcc > 0 ? 2 : 1;
            int lastIndex = firstOcc;
            while (firstOcc < n && firstOcc != -1)
            {
                lastIndex = firstOcc + a.Length;
                firstOcc = b.IndexOf(a, firstOcc + a.Length);
                if (firstOcc > 0) repeat++;
            }

            if (lastIndex < n)
            {
                if (a.Contains(b.Substring(lastIndex))) repeat++;
                else return -1;
            }

            return repeat;
        }

        public bool RepeatedSubstringPattern(string s)
        {
            var n = s.Length;
            if (n <= 1) return false;
            if (n == 2) return s[0] == s[1];
            var divisors = new List<int>();

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (i != 1 && n / i != i)
                    {
                        divisors.Add(n / i);
                    }
                }
            }

            foreach (var divisor in divisors)
            {
                var divisorHash = s.Substring(0, divisor).GetHashCode();
                int cutStart = divisor;
                while (cutStart < n)
                {
                    var cutHash = s.Substring(cutStart, divisor).GetHashCode();
                    if (cutHash != divisorHash) break;
                    cutStart += divisor;
                }

                if (cutStart == n) return true;
            }

            return false;
        }


        public bool RepeatedSubstringPattern_KMP(string s)
        {
            var matches = new int[s.Length];
            int index = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[index])
                {
                    index++;
                    matches[i] = index;
                }
                else
                {
                    index = matches[i - 1];

                    while (index > 0 && s[i] != s[index])
                    {
                        index = matches[index - 1];
                    }

                    if (s[i] == s[index])
                    {
                        index++;
                    }

                    matches[i] = index;
                }
            }

            var lastPrefixMatchLength = matches[s.Length - 1];
            return lastPrefixMatchLength > 0 && s.Length % (s.Length - lastPrefixMatchLength) == 0;
        }


        public bool QueryString(string S, int N)
        {
            for (int i = 1; i <= N; i++)
            {
                var idx = StrStr_RabinKarp_Binary(S, Convert.ToString(i, 2));
                if (idx < 0) return false;
            }

            return true;
        }

        public int StrStr_RabinKarp_Binary(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            int L = needle.Length;
            if (L > haystack.Length) return -1;
            if (L == haystack.Length) return needle.Equals(haystack) ? 0 : -1;

            long needleHash = 0, haystackHash = 0, baseA = 2, modulo1 = (long)Math.Pow(2, 32), lastPower = 1;
            for (int i = 0; i < L; i++)
            {
                needleHash = (needleHash * baseA % modulo1 + (needle[i] - '0')) % modulo1;
                haystackHash = (haystackHash * baseA % modulo1 + (haystack[i] - '0')) % modulo1;
                lastPower = lastPower * baseA;
            }

            if (needleHash == haystackHash) return 0;

            for (int i = L; i < haystack.Length; i++)
            {
                haystackHash = (haystackHash * baseA % modulo1 - (lastPower * (haystack[i - L] - '0') % modulo1) + modulo1) % modulo1;
                haystackHash = (haystackHash % modulo1 + (haystack[i] - '0')) % modulo1;
                if (needleHash == haystackHash) return i - L + 1;
            }

            return -1;
        }


        public string ShortestPalindrome(string s)
        {
            var temp = s + "#" + new string(s.Reverse().ToArray());
            int[] table = GetKMPTable(temp);

            //get the maximum palin part in s starts from 0
            return new string(s.Substring(table[table.Length - 1]).Reverse().ToArray()) + s;
        }

        private int[] GetKMPTable(string str)
        {
            var matches = new int[str.Length];

            int index = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[index])
                {
                    index++;
                    matches[i] = index;
                }
                else
                {
                    index = matches[i - 1];
                    while (index > 0 && str[i] != str[index])
                        index = matches[index - 1];

                    if (str[i] == str[index])
                        index++;

                    matches[i] = index;
                }
            }

            return matches;
        }





















        public int[] getTable(String s)
        {
            //get lookup table
            int[] table = new int[s.Length];

            //pointer that points to matched char in prefix part

            int index = 0;
            //skip index 0, we will not match a string with itself
            for (int i = 1; i < s.Length; i++)
            {
                if (s[index] == s[i])
                {
                    //we can extend match in prefix and postfix
                    table[i] = table[i - 1] + 1;
                    index++;
                }
                else
                {
                    //match failed, we try to match a shorter substring

                    //by assigning index to table[i-1], we will shorten the match string length, and jump to the 
                    //prefix part that we used to match postfix ended at i - 1
                    index = table[i - 1];

                    while (index > 0 && s[index] != s[i])
                    {
                        //we will try to shorten the match string length until we revert to the beginning of match (index 1)
                        index = table[index - 1];
                    }

                    //when we are here may either found a match char or we reach the boundary and still no luck
                    //so we need check char match
                    if (s[index] == s[i])
                    {
                        //if match, then extend one char 
                        index++;
                    }

                    table[i] = index;
                }

            }

            return table;
        }


        public int FindLength(int[] A, int[] B)
        {
            int minLength = Math.Min(A.Length, B.Length);
            int low = 0, high = minLength;

            int lastOption = 0;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (RabinKarpLen(A, B, mid))
                {
                    low = mid + 1;
                    lastOption = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return lastOption;
        }

        public bool RabinKarpLen(int[] A, int[] B, int L)
        {
            long hashA = 0, hashB = 0, basePowerL = 1, modulo1 = (long)Math.Pow(2, 32);
            int baseNum = 101;
            var hashesA = new Dictionary<long, List<int>>();
            var hashesB = new Dictionary<long, List<int>>();
            int i = 0;
            for (; i < A.Length; i++)
            {
                if (i < L)
                    basePowerL = (basePowerL * baseNum) % modulo1;

                if (i < L)
                {
                    hashA = (hashA * baseNum + A[i]) % modulo1;
                    hashB = (hashB * baseNum + B[i]) % modulo1;
                }
                else
                {
                    AddToHash(hashesA, hashA, i - L);
                    AddToHash(hashesB, hashB, i - L);

                    hashA = (hashA * baseNum % modulo1 - (basePowerL * A[i - L] % modulo1) + modulo1) % modulo1;
                    hashA = (hashA + A[i]) % modulo1;

                    hashB = (hashB * baseNum % modulo1 - (basePowerL * B[i - L] % modulo1) + modulo1) % modulo1;
                    hashB = (hashB + B[i]) % modulo1;
                }
            }

            AddToHash(hashesA, hashA, i - L);
            AddToHash(hashesB, hashB, i - L);

            foreach (var kvA in hashesA)
            {
                if (hashesB.ContainsKey(kvA.Key))
                {
                    foreach (var j in kvA.Value)
                    {
                        foreach (var k in hashesB[kvA.Key])
                        {
                            bool foundMatch = true;
                            for (int m = 0; m < L; m++)
                            {
                                if (A[j + m] != B[k + m])
                                {
                                    foundMatch = false;
                                    break;
                                }
                            }
                            if (foundMatch) return true;
                        }
                    }
                }
            }

            return false;
        }

        private void AddToHash(Dictionary<long, List<int>> hashesA, in long hashA, int idx)
        {
            if (!hashesA.ContainsKey(hashA))
                hashesA.Add(hashA, new List<int>());
            hashesA[hashA].Add(idx);
        }

        public int FindLength_SlidingWindow(int[] A, int[] B)
        {
            int M = A.Length;
            int N = B.Length;

            // i is beginning of string B window
            int maxCnt = 0;
            for (int offset = -N; offset < M; offset++)
            {
                int aPos = Math.Max(offset, 0);
                int bPos = aPos - offset;

                int cnt = 0;
                // run along string B
                while (bPos < N && aPos < M)
                {
                    if (A[aPos] == B[bPos])
                    {
                        cnt++;
                        maxCnt = Math.Max(maxCnt, cnt);
                    }
                    else
                    {
                        cnt = 0;
                    }
                    aPos++;
                    bPos++;
                }
            }
            return maxCnt;
        }

        public int FindLength_DP(int[] A, int[] B)
        {
            var dp = new int[A.Length + 1, B.Length + 1];

            var max = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                for (int j = B.Length - 1; j >= 0; j--)
                {
                    if (A[i] == B[j])
                    {
                        dp[i, j] = dp[i + 1, j + 1] + 1;
                        if (max < dp[i, j])
                            max = dp[i, j];
                    }
                }
            }
            return max;
        }

        public int StrStr(string haystack, string needle)
        {
            int t = 0; // the position of the current character in text
            int p = 0; // the position of the current character in pattern

            int tLen = haystack.Length;
            int pLen = needle.Length;

            int[] prefixLen = CalcPrefixLen(needle);

            while (t < tLen)
            {
                if (needle[p] == haystack[t])
                {
                    p++;
                    t++;

                    if (p == pLen)
                    {
                        // occurrence found, if only first occurrence is needed then you could halt here
                        return t - pLen;
                    }
                }
                else
                {
                    p = prefixLen[p];
                    if (p < 0)
                    {
                        t++;
                        p++;
                    }
                }
            }

            return -1;
        }


        /**
         * implementation is based on the pseudo code from Wikipedia: https://en.wikipedia.org/wiki/Knuth%E2%80%93Morris%E2%80%93Pratt_algorithm
         * @param text
         * @param pattern
         * @return
         */
        public List<int> Search(string text, string pattern)
        {
            int t = 0; // the position of the current character in text
            int p = 0; // the position of the current character in pattern

            int tLen = text.Length;
            int pLen = pattern.Length;

            List<int> matches = new List<int>();
            int[] prefixLen = CalcPrefixLen(pattern);

            while (t < tLen)
            {
                if (pattern[p] == text[t])
                {
                    p++;
                    t++;

                    if (p == pLen)
                    {
                        // occurrence found, if only first occurrence is needed then you could halt here
                        matches.Add(t - p);
                        p = prefixLen[p]; // reset
                    }
                }
                else
                {
                    p = prefixLen[p];
                    if (p < 0)
                    {
                        t++;
                        p++;
                    }
                }
            }

            return matches;
        }

        /**
	 * creates an array of length pattern.length()+1
	 * @param pattern "abcxxxabcyyy"
	 * @return [-1, 0, 0, 0, 0, 0, 0, 1, 2, 3, 0, 0, 0]
	 */
        public int[] CalcPrefixLen(string pattern)
        {
            int patternLen = pattern.Length;
            int[] ar = new int[patternLen + 1];
            ar[0] = -1;
            ar[1] = 0;

            int prefixLen = 0;
            int i = 1;

            while (i < patternLen)
            {
                if (pattern[prefixLen] == pattern[i])
                {
                    prefixLen++;
                    i++;
                    ar[i] = prefixLen;

                }
                else if (prefixLen > 0)
                {
                    prefixLen = ar[prefixLen]; // note  that we do not increment i here

                }
                else
                {
                    i++;
                    ar[i] = 0; // 'prefixLen' reached 0, so save that into ar[] and move forward
                }
            }

            return ar;
        }


        public int StrStr_RabinKarp(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;
            int L = needle.Length;
            if (L > haystack.Length) return -1;
            if (L == haystack.Length) return needle.Equals(haystack) ? 0 : -1;

            long needleHash = 0, haystackHash = 0, baseA = 26, modulo1 = (long)Math.Pow(2, 32), lastPower = 1;
            for (int i = 0; i < L; i++)
            {
                needleHash = (needleHash * baseA % modulo1 + (needle[i] - 'a')) % modulo1;
                haystackHash = (haystackHash * baseA % modulo1 + (haystack[i] - 'a')) % modulo1;
                lastPower = lastPower * baseA;
            }

            //if (needleHash == haystackHash && haystack.Substring(0, L) == needle) return 0;
            if (needleHash == haystackHash) return 0;

            for (int i = L; i < haystack.Length; i++)
            {
                haystackHash = (haystackHash * baseA % modulo1 - (lastPower * (haystack[i - L] - 'a') % modulo1) + modulo1) % modulo1;
                haystackHash = (haystackHash % modulo1 + (haystack[i] - 'a')) % modulo1;
                if (needleHash == haystackHash) return i - L + 1;
            }

            return -1;
        }

        public int LongestRepeatingSubstring(string S)
        {
            int low = 0, high = S.Length;

            int lastOption = 0;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (RabinKarpLen(S, mid))
                {
                    low = mid + 1;
                    lastOption = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return lastOption;
        }


        public bool RabinKarpLen(string s, int L)
        {
            var map = new Dictionary<long, List<int>>();
            long hash = 0, basePowerL = 1, modulo1 = (long)Math.Pow(2, 32);
            int baseNum = 26;
            for (int i = 0; i < L; i++)
            {
                basePowerL = (basePowerL * baseNum) % modulo1;
                hash = (hash * baseNum + (s[i] - 'a')) % modulo1;
            }
            map.Add(hash, new List<int> { 0 });
            for (int j = L; j < s.Length; j++)
            {
                hash = (hash * baseNum % modulo1 - ((basePowerL * (s[j - L] - 'a')) % modulo1) + modulo1) % modulo1;
                hash = (hash + (s[j] - 'a')) % modulo1;
                int startIdx = j - L + 1;
                if (!map.ContainsKey(hash))
                    map.Add(hash, new List<int> { startIdx });
                else
                {
                    var str = s.Substring(startIdx, L);
                    foreach (var i in map[hash])
                    {
                        if (str == s.Substring(i, L))
                            return true;
                    }
                    map[hash].Add(startIdx);
                }
            }

            return false;
        }

        public string LongestDupSubstring(string s)
        {
            int low = 0, high = s.Length;

            string lastOption = string.Empty;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                var duplicateStr = RabinKarp(s, mid);

                if (duplicateStr != string.Empty)
                {
                    low = mid + 1;
                    lastOption = duplicateStr;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return lastOption;
        }

        public string RabinKarp(string s, int L)
        {
            var map = new Dictionary<long, List<int>>();
            long hash = 0, basePowerL = 1, modulo1 = (long)Math.Pow(2, 32);
            int baseNum = 26;
            for (int i = 0; i < L; i++)
            {
                basePowerL = (basePowerL * baseNum) % modulo1;
                hash = (hash * baseNum + (s[i] - 'a')) % modulo1;
            }
            map.Add(hash, new List<int> { 0 });
            for (int j = L; j < s.Length; j++)
            {
                hash = (hash * baseNum % modulo1 - ((basePowerL * (s[j - L] - 'a')) % modulo1) + modulo1) % modulo1;
                hash = (hash + (s[j] - 'a')) % modulo1;
                int startIdx = j - L + 1;
                if (!map.ContainsKey(hash))
                    map.Add(hash, new List<int> { startIdx });
                else
                {
                    var str = s.Substring(startIdx, L);
                    foreach (var i in map[hash])
                    {
                        if (str == s.Substring(i, L))
                            return str;
                    }
                    map[hash].Add(startIdx);
                }
            }

            return string.Empty;
        }

        public string LargestNumber(int[] nums)
        {
            var sb = new StringBuilder();
            var arr = nums
                .Select(x => x.ToString())
                .OrderByDescending(x => x, Comparer<string>.Create((a, b) =>
                {
                    return String.Compare((a + b), b + a, StringComparison.Ordinal);
                }));

            foreach (var i in arr)
            {
                sb.Append(i);
            }

            return sb[0] == '0' ? "0" : sb.ToString();
        }

        public ListNode SortList(ListNode head)
        {
            if (head.next == null) return head;

            var mid = GetMidNode(head);

            var leftSortedPartition = SortList(head);
            var rightSortedPartition = SortList(mid);

            return Merge(leftSortedPartition, rightSortedPartition);
        }

        private ListNode GetMidNode(ListNode head)
        {
            ListNode slow = head, fast = head.next;
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next?.next;
            }

            slow.next = null;
            return slow;
        }


        public ListNode Merge(ListNode a, ListNode b)
        {
            ListNode newHead = new ListNode(), curr = newHead;

            while (a != null && b != null)
            {
                if (a.val < b.val)
                {
                    curr.next = a;
                    curr = curr.next;
                    a = a.next;
                }
                else
                {
                    curr.next = b;
                    curr = curr.next;
                    b = b.next;
                }
            }

            curr.next = a ?? b;

            return newHead.next;
        }

        public ListNode RemoveZeroSumSublists(ListNode head)
        {
            var dic = new Dictionary<int, ListNode>();

            ListNode newHead = new ListNode(), node = newHead;
            newHead.next = head;

            int sum = 0;
            while (node != null)
            {
                sum += node.val;
                if (!dic.ContainsKey(sum))
                    dic.Add(sum, null);

                dic[sum] = node;
                node = node.next;
            }

            node = head;
            sum = 0;
            while (node != null)
            {
                sum += node.val;
                var lastNodeWithSameComulativeSum = dic[sum];

                node.next = lastNodeWithSameComulativeSum.next;
                node = node.next;
            }

            return newHead.next;
        }

        public ListNode Partition(ListNode head, int x)
        {
            ListNode before = new ListNode(-1), beforeHead = before;
            ListNode afterHead = new ListNode(-1), after = afterHead;

            while (head != null)
            {
                if (head.val < x)
                {
                    before.next = head;
                    before = before.next;
                }
                else
                {
                    after.next = head;
                    after = after.next;
                }

                head = head.next;
            }

            after.next = null;
            before.next = afterHead.next;

            return beforeHead.next;
        }


        public int ClimbStairs(int n)
        {
            int[] dp = new int[n + 1];
            return ClimbStairsRec(n, ref dp);
        }

        private int ClimbStairsRec(in int i, ref int[] dp)
        {
            if (i < 0) return 0;

            if (i == 0) return 1;

            if (dp[i] > 0) return dp[i];

            dp[i] = ClimbStairsRec(i - 2, ref dp) + ClimbStairsRec(i - 1, ref dp);

            return dp[i];
        }

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var inDegrees = new int[numCourses];
            var outDegrees = new List<int>[numCourses];

            foreach (var prerequisite in prerequisites)
            {
                inDegrees[prerequisite[0]]++;
                outDegrees[prerequisite[1]] ??= new List<int>();
                outDegrees[prerequisite[1]].Add(prerequisite[0]);
            }

            var q = new Queue<int>();
            for (int i = 0; i < inDegrees.Length; i++)
            {
                if (inDegrees[i] == 0)
                    q.Enqueue(i);
            }

            var coursesOrder = new List<int>();
            while (q.Count > 0)
            {
                var prerequisite = q.Dequeue();
                coursesOrder.Add(prerequisite);
                if (outDegrees[prerequisite] != null)
                    foreach (var i in outDegrees[prerequisite])
                    {
                        inDegrees[i]--;
                        if (inDegrees[i] == 0)
                            q.Enqueue(i);
                    }
            }

            return inDegrees.Any(x => x != 0) ? new int[0] : coursesOrder.ToArray();
        }

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var inDegrees = new int[numCourses];
            var outDegrees = new List<int>[numCourses];

            foreach (var prerequisite in prerequisites)
            {
                inDegrees[prerequisite[0]]++;
                outDegrees[prerequisite[1]] ??= new List<int>();
                outDegrees[prerequisite[1]].Add(prerequisite[0]);
            }

            var q = new Queue<int>();
            for (int i = 0; i < inDegrees.Length; i++)
            {
                if (inDegrees[i] == 0)
                    q.Enqueue(i);
            }

            while (q.Count > 0)
            {
                var prerequisite = q.Dequeue();
                if (outDegrees[prerequisite] != null)
                    foreach (var i in outDegrees[prerequisite])
                    {
                        inDegrees[i]--;
                        if (inDegrees[i] == 0)
                            q.Enqueue(i);
                    }
            }

            return !inDegrees.Any(x => x != 0);
        }

        public ListNode removeElements(ListNode head, int val)
        {
            if (head == null) return null;
            while (head != null && head.val == val)
            {
                head = head.next;
            }

            var newHead = head;
            if (newHead == null) return null;

            ListNode node = head.next, prev = head;
            while (node != null)
            {
                if (node.val == val)
                {
                    prev.next = node.next;
                }
                else
                {
                    prev = node;
                }
                node = node.next;
            }

            return newHead;
        }

        public int Fib(int N)
        {
            if (N <= 0) return 0;
            if (N == 1) return 1;

            int prevPrev = 0, prev = 1, curr = 2;

            while (curr <= N)
            {
                var temp = prev + prevPrev;
                prevPrev = prev;
                prev = temp;
                curr++;
            }
            return prev;
        }

        public IList<int> DistanceK(TreeNode root, TreeNode target, int K)
        {
            var parentsDic = new Dictionary<TreeNode, TreeNode>();

            // Fill parents DIC
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            parentsDic.Add(root, null);
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                if (node.left != null)
                {
                    parentsDic.Add(node.left, node);
                    q.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    parentsDic.Add(node.right, node);
                    q.Enqueue(node.right);
                }
            }

            // BFS on target node
            var dist = 0;
            var seen = new HashSet<TreeNode>();
            q.Enqueue(null);
            q.Enqueue(target);
            seen.Add(target);
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                // Level ended
                if (node == null)
                {
                    if (dist == K)
                    {
                        return q.Select(i => i.val).ToList();
                    }

                    if (q.Count > 0)
                    {
                        dist++;
                        q.Enqueue(null);
                    }
                }
                else
                {
                    if (node.left != null && !seen.Contains(node.left))
                    {
                        q.Enqueue(node.left);
                        seen.Add(node.left);
                    }

                    if (node.right != null && !seen.Contains(node.right))
                    {
                        q.Enqueue(node.right);
                        seen.Add(node.right);
                    }

                    if (parentsDic[node] != null && !seen.Contains(parentsDic[node]))
                    {
                        q.Enqueue(parentsDic[node]);
                        seen.Add(parentsDic[node]);
                    }
                }
            }

            return new List<int>();
        }

        public IList<string> FindRepeatedDnaSequences(string s)
        {
            int L = 10, dnaBase = 4, lastElementMultiplyFactor = (int)Math.Pow(4, L - 1);
            if (s.Length < L) return new List<string>();

            var dnaElements = new Dictionary<char, int> { { 'A', 0 }, { 'C', 1 }, { 'G', 2 }, { 'T', 3 } };
            var hash = 0;
            for (int i = 0; i < L; i++)
                hash = (hash * dnaBase) + dnaElements[s[i]];

            var unique = new HashSet<int>();
            unique.Add(hash);

            var duplicateSequences = new HashSet<string>();
            for (int i = L; i < s.Length; i++)
            {
                hash -= (dnaElements[s[i - L]] * lastElementMultiplyFactor);
                hash = hash * dnaBase + dnaElements[s[i]];
                if (unique.Contains(hash))
                {
                    duplicateSequences.Add(s.Substring(i - L + 1, L));
                }
                else unique.Add(hash);
            }

            return duplicateSequences.ToList();
        }

        public int[] DailyTemperatures(int[] T)
        {
            var res = new int[T.Length];
            var monoSt = new Stack<int>();
            for (int i = 0; i < T.Length; i++)
            {
                while (monoSt.Count > 0 && T[i] > T[monoSt.Peek()])
                {
                    var j = monoSt.Pop();
                    res[j] = i - j;
                }

                monoSt.Push(i);
            }
            return res;
        }

        public int OrangesRotting(int[][] grid)
        {
            if (grid.Length == 0 || grid[0].Length == 0) return 0;
            var q = new Queue<(int row, int col)>();
            var visited = new bool[grid.Length, grid[0].Length];
            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 2)
                    {
                        q.Enqueue((row, col));
                        visited[row, col] = true;
                    }
                }
            }

            var iMoves = new int[] { 0, 0, -1, 1 };
            var jMoves = new int[] { -1, 1, 0, 0 };

            int days = 0;
            while (q.Count > 0)
            {
                int qCount = q.Count;
                days++;
                for (int start = 0; start < qCount; start++)
                {
                    var rotten = q.Dequeue();

                    for (int i = 0; i < iMoves.Length; i++)
                    {
                        int newRow = rotten.row + iMoves[i], newCol = rotten.col + jMoves[i];
                        if (newRow >= 0 && newRow < grid.Length && newCol >= 0 && newCol < grid[newRow].Length
                            && !visited[newRow, newCol] && grid[newRow][newCol] == 1)
                        {
                            grid[newRow][newCol] = 2;
                            visited[newRow, newCol] = true;
                            q.Enqueue((newRow, newCol));

                        }
                    }
                }

            }

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        return -1;
                    }
                }
            }

            return days == 0 ? 0 : (days - 1);
        }

        public IList<string> TopKFrequent(string[] words, int k)
        {
            var freqDic = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!freqDic.ContainsKey(word))
                    freqDic.Add(word, 0);
                freqDic[word]++;
            }

            var unique = new string[freqDic.Keys.Count];
            int i = 0;
            foreach (var kv in freqDic)
            {
                unique[i++] = kv.Key;
            }

            var pivot = QuickSelectWords(unique, freqDic, 0, unique.Length - 1, unique.Length - k);
            var res = unique.Skip(pivot).Take(unique.Length - pivot).ToArray();
            Array.Sort(res, (s1, s2) =>
            {
                if (freqDic[s1] == freqDic[s2]) return s1.CompareTo(s2);
                return freqDic[s2].CompareTo(freqDic[s1]);
            });
            return res;
        }

        private int QuickSelectWords(string[] words, Dictionary<string, int> freqDic, int left, in int right, in int k)
        {
            string pivot = words[right];
            int writeIndex = left;
            string temp;
            for (int i = left; i < right; i++)
            {
                if (freqDic[words[i]] <= freqDic[pivot])
                {
                    temp = words[writeIndex];
                    words[writeIndex++] = words[i];
                    words[i] = temp;
                }
            }

            temp = words[writeIndex];
            words[writeIndex] = words[right];
            words[right] = temp;

            var orderSize = writeIndex - left;
            if (orderSize == k) return writeIndex;
            else if (orderSize > k)
            {
                return QuickSelectWords(words, freqDic, left, writeIndex - 1, k);
            }
            else
            {
                return QuickSelectWords(words, freqDic, writeIndex + 1, right, k - orderSize - 1);
            }
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            var freqDic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!freqDic.ContainsKey(num))
                    freqDic.Add(num, 0);
                freqDic[num]++;
            }

            var unique = new int[freqDic.Keys.Count];
            int i = 0;
            foreach (var kv in freqDic)
            {
                unique[i++] = kv.Key;
            }

            var pivot = QuickSelect(unique, freqDic, 0, unique.Length - 1, unique.Length - k);
            return unique.Skip(pivot).Take(unique.Length - pivot).ToArray();
        }

        private int QuickSelect(int[] nums, Dictionary<int, int> freqDic, int left, in int right, in int k)
        {
            int pivot = nums[right], writeIndex = left, temp;
            for (int i = left; i < right; i++)
            {
                if (freqDic[nums[i]] <= freqDic[pivot])
                {
                    temp = nums[writeIndex];
                    nums[writeIndex++] = nums[i];
                    nums[i] = temp;
                }
            }

            temp = nums[writeIndex];
            nums[writeIndex] = nums[right];
            nums[right] = temp;

            var orderSize = writeIndex - left;
            if (orderSize == k) return writeIndex;
            else if (orderSize > k)
            {
                return QuickSelect(nums, freqDic, left, writeIndex - 1, k);
            }
            else
            {
                return QuickSelect(nums, freqDic, writeIndex + 1, right, k - orderSize - 1);
            }
        }

        public int MaximalSquare(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return 0;
            int rows = matrix.Length, cols = matrix[0].Length;
            var dp = new int[matrix.Length, cols];

            int max = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = matrix[i][j] - '0';
                    }
                    else
                    {
                        if (matrix[i][j] == '1')
                        {
                            dp[i, j] = Math.Min(dp[i - 1, j], Math.Min(dp[i - 1, j - 1], dp[i, j - 1])) + 1;
                        }
                    }

                    max = Math.Max(max, dp[i, j]);
                }
            }

            return max * max;
        }

        public string LongestPalindrome(string s)
        {
            int minI = 0, maxI = 0;
            var dp = new bool[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                dp[i, i] = true;
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
                            if (j - i > maxI - minI)
                            {
                                minI = i;
                                maxI = j;
                            }
                        }
                    }
                }
            }

            return s.Substring(minI, maxI - minI + 1);
        }

        public int NumDecodings(string s)
        {
            var dp = new Dictionary<int, int>();
            return NumDecodingsRec(s, 0, ref dp);
        }

        private int NumDecodingsRec(string s, int i, ref Dictionary<int, int> dp)
        {
            if (i == s.Length) return 1;

            if (dp.ContainsKey(i)) return dp[i];

            int options = 0;
            if (s[i] == '*' || s[i] - '0' > 0)
            {
                options = (s[i] == '*' ? 9 : 1) * NumDecodingsRec(s, i + 1, ref dp) % modulo;
            }

            // 10 to 26
            if (s.Length - i >= 2 && s[i] != '0')
            {
                if (s[i] == '*' || s[i + 1] == '*')
                {
                    var perm = 1;
                    if (s[i] == '*' && s[i + 1] == '*')
                    {
                        perm = 15;
                    }
                    else if (s[i] != '*')
                    {
                        if (s[i] == '1')
                        {
                            perm = 9;
                        }
                        else if (s[i] == '2')
                        {
                            perm = 6;
                        }
                        else perm = 0;
                    }
                    else
                    {
                        if (s[i + 1] - '0' <= 6)
                        {
                            perm = 2;
                        }
                        else
                        {
                            perm = 1;
                        }
                    }

                    options = ((options % modulo) + (perm * NumDecodingsRec(s, i + 2, ref dp) % modulo)) % modulo;
                }
                else
                {
                    var num = (s[i] - 48) * 10 + (s[i + 1] - 48);
                    if (num > 0 && num <= 26)
                    {
                        options += 1 * NumDecodingsRec(s, i + 2, ref dp);
                    }
                }
            }

            dp.Add(i, options);
            return options;
        }

        public class MinStack
        {
            Stack<int> st = new Stack<int>();
            Stack<int[]> minSt = new Stack<int[]>();

            /** initialize your data structure here. */
            public MinStack()
            {

            }

            public void Push(int x)
            {
                st.Push(x);
                if (minSt.Count == 0 || x <= minSt.Peek()[0])
                {
                    if (minSt.Count == 0 || x < minSt.Peek()[0])
                        minSt.Push(new[] { x, 1 });
                    else minSt.Peek()[1]++;
                }
            }

            public void Pop()
            {
                if (st.Peek() == minSt.Peek()[0])
                    minSt.Peek()[1]--;

                if (minSt.Peek()[1] == 0)
                    minSt.Pop();

                st.Pop();
            }

            public int Top()
            {
                return st.Peek();
            }

            public int GetMin()
            {
                return minSt.Peek()[0];
            }
        }


        public int MaxProfit(int[] prices)
        {
            int max = 0, minSoFar = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (minSoFar != int.MaxValue)
                    max = Math.Max(max, prices[i] - minSoFar);
                if (prices[i] < minSoFar)
                    minSoFar = prices[i];
            }

            return max;
        }

        public int maxSubArray(int[] nums)
        {
            int currSum = nums[0], maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                currSum = Math.Max(nums[i], nums[i] + currSum);
                maxSum = Math.Max(maxSum, currSum);
            }

            return maxSum;
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                var temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }

            int m = nums1.Length, n = nums2.Length;
            int iMin = 0, iMax = m, halfSize = (m + n + 1) / 2;

            while (iMin <= iMax)
            {
                var i = (iMax + iMin) / 2;
                var j = halfSize - i;

                if (j < n && nums1[i - 1] > nums2[j])
                {
                    iMax = i - 1;
                }
                else if (i < m && nums2[j - 1] > nums1[i])
                {
                    iMin = i + 1;
                }
                else
                {
                    double leftMax = 0;
                    if (i == 0)
                    {
                        leftMax = nums2[j - 1];
                    }
                    else if (j == 0)
                    {
                        leftMax = nums1[i - 1];
                    }
                    else
                    {
                        leftMax = Math.Max(nums1[i - 1], nums2[j - 1]);
                    }

                    if ((m + n) % 2 == 1) return leftMax;

                    double rightMin = 0;

                    if (i == m)
                    {
                        rightMin = nums2[j];
                    }
                    else if (j == n)
                    {
                        rightMin = nums1[i];
                    }
                    else
                    {
                        rightMin = Math.Min(nums1[i], nums2[j]);
                    }

                    return (leftMax + rightMin) / 2;
                }
            }

            return -1;
        }

        public bool HalvesAreAlike(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var n = s.Length;
            int count = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (vowels.Contains(s[i]))
                    count++;
            }

            for (int i = s.Length / 2; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                    count--;
            }

            return count == 0;
        }

        public class MyCircularQueue
        {
            private int[] arr;
            private int readIndex = 0;
            private int writeIndex = 0;
            private int count = 0;

            public MyCircularQueue(int k)
            {
                arr = new int[k];

            }

            public bool EnQueue(int value)
            {
                if (!IsFull())
                {
                    arr[writeIndex++] = value;
                    writeIndex = writeIndex % arr.Length;
                    count++;
                    return true;
                }

                return false;
            }

            public bool DeQueue()
            {
                if (!IsEmpty())
                {
                    var value = arr[readIndex++];
                    readIndex = readIndex % arr.Length;
                    count--;
                    return true;
                }

                return false;
            }

            public int Front()
            {
                if (!IsEmpty())
                    return arr[readIndex];
                return -1;
            }

            public int Rear()
            {
                if (!IsEmpty())
                {
                    var prevIndex = writeIndex - 1;
                    if (prevIndex < 0) prevIndex += arr.Length;
                    return arr[prevIndex];
                }
                return -1;
            }

            public bool IsEmpty()
            {
                return count == 0;
            }

            public bool IsFull()
            {
                return count == arr.Length;
            }
        }

        public class ParkingSystem
        {
            private Dictionary<int, int> spots;

            public ParkingSystem(int big, int medium, int small)
            {
                spots = new Dictionary<int, int>
                {
                    {1, big},
                    {2, medium},
                    {3, small},
                };
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


        //public int NumMusicPlaylists(int N, int L, int K)
        //{
        //    int count = 0;
        //    NumMusicPlaylistsRec(N, L, K, ref count);

        //    return count;
        //}

        //private void NumMusicPlaylistsRec(in int N, in int L, in int K, ref int count)
        //{
        //    if (L == 0)
        //    {
        //        if (N == 0)
        //        {
        //            count++;
        //        }
        //        return;
        //    }

        //    for (int i = N; i >= 1; i--)
        //    {
        //        NumMusicPlaylistsRec(i, L - 1, K);
        //    }
        //}

        public int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0 || intervals[0].Length == 0) return 0;
            Array.Sort(intervals, (it1, it2) => it1[1] - it2[1]);

            int minRemoval = 0;
            var prevInterval = intervals[0];

            for (int i = 1; i < intervals.Length; i++)
            {
                var currInterval = intervals[i];

                if (currInterval[0] < prevInterval[1])
                {
                    minRemoval++;
                }
                else prevInterval = currInterval;
            }

            return minRemoval;
        }

        public TreeNode BalanceBST(TreeNode root)
        {
            var lst = new List<int>();
            InOrderBST(root, lst);
            return SortedArrayToBST(lst.ToArray());
        }

        private void InOrderBST(TreeNode node, List<int> nums)
        {
            if (node == null) return;
            InOrderBST(node.left, nums);
            nums.Add(node.val);
            InOrderBST(node.right, nums);
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBSTRec(nums, 0, nums.Length - 1);
        }

        private TreeNode SortedArrayToBSTRec(int[] nums, int left, int right)
        {
            if (left > right) return null;
            var mid = (left + right) / 2;
            var node = new TreeNode(nums[mid]);
            node.left = SortedArrayToBSTRec(nums, left, mid - 1);
            node.right = SortedArrayToBSTRec(nums, mid + 1, right);
            return node;
        }

        public int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            var lst = new List<int>();
            int rows = nums.Count, cols = nums.Max(l => l.Count);
            var groups = new List<List<int>>(rows + cols);
            for (int i = 0; i < rows + cols; i++)
            {
                groups.Add(new List<int>());
            }

            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = 0; j < nums[i].Count; j++)
                {
                    groups[i + j].Add(nums[i][j]);
                }
            }

            foreach (var group in groups)
            {
                lst.AddRange(group);
            }

            return lst.ToArray();
        }

        public bool IsValidPalindrome(string s, int k)
        {
            var dp = new int?[s.Length, s.Length];
            return IsValidPalindromeRec(s, 0, s.Length - 1, ref dp) <= k;
        }

        private int IsValidPalindromeRec(string s, int i, int j, ref int?[,] dp)
        {
            if (i == j) return 0;
            if (i == j - 1) return s[i] == s[j] ? 0 : 1;

            if (dp[i, j].HasValue) return dp[i, j].Value;

            var removals = 0;
            if (s[i] == s[j])
            {
                removals = IsValidPalindromeRec(s, i + 1, j - 1, ref dp);
            }
            else
            {
                removals = IsValidPalindromeRec(s, i + 1, j, ref dp);
                removals = Math.Min(removals, IsValidPalindromeRec(s, i, j - 1, ref dp));
                removals += 1;
            }

            dp[i, j] = removals;
            return removals;
        }

        public bool IsToeplitzMatrix(int[][] matrix)
        {
            int rows = matrix.Length, cols = matrix[0].Length;
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var prevDCell = (x: i - 1, y: j - 1);
                    if (prevDCell.x < 0 || prevDCell.x >= rows || prevDCell.y < 0 || prevDCell.y >= cols)
                        continue;
                    if (matrix[prevDCell.x][prevDCell.y] != matrix[i][j])
                        return false;
                }
            }

            return true;
        }

        public string BoldWords(string[] words, string S)
        {
            return AddBoldTag(S, words);
        }

        public string AddBoldTag(string s, string[] dict)
        {
            var intervals = new List<(int start, int end)>();

            foreach (var word in dict)
            {
                int occ = -1;
                while ((occ = s.IndexOf(word, occ + 1)) != -1)
                {
                    intervals.Add((occ, occ + word.Length - 1));
                }
            }

            intervals = intervals.OrderBy(interval => interval.start).ToList();
            var ls = new LinkedList<(int start, int end)>();
            foreach (var interval in intervals)
            {
                if (ls.Last == null || interval.start > ls.Last.Value.end + 1)
                {
                    ls.AddLast(interval);
                }
                else
                {
                    var last = ls.Last.Value;
                    ls.RemoveLast();
                    last.end = Math.Max(last.end, interval.end);
                    ls.AddLast(last);
                }
            }

            var sb = new StringBuilder(s.Length + ls.Count * 7);

            var prevIntervalEnd = -1;
            foreach (var interval in ls)
            {
                sb.Append(s.Substring(prevIntervalEnd + 1, interval.start - prevIntervalEnd - 1));
                sb.Append("<b>");
                sb.Append(s.Substring(interval.start, interval.end - interval.start + 1));
                sb.Append("</b>");
                prevIntervalEnd = interval.end;
            }

            sb.Append(s.Substring(prevIntervalEnd + 1));

            return sb.ToString();
        }

        public class RandomizedCollection
        {
            private Dictionary<int, int> ItemsExistence;
            Random r = new Random();
            private int totalCount = 0;

            /** Initialize your data structure here. */
            public RandomizedCollection()
            {
                ItemsExistence = new Dictionary<int, int>();
            }

            /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
            public bool Insert(int val)
            {
                totalCount++;
                if (ItemsExistence.ContainsKey(val))
                {
                    ItemsExistence[val]++;
                    return false;
                }
                else
                {
                    ItemsExistence.Add(val, 1);
                    return true;
                }
            }

            /** Removes a value from the collection. Returns true if the collection contained the specified element. */
            public bool Remove(int val)
            {
                if (ItemsExistence.ContainsKey(val))
                {
                    ItemsExistence[val]--;
                    if (ItemsExistence[val] == 0)
                        ItemsExistence.Remove(val);
                    totalCount--;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            /** Get a random element from the collection. */
            public int GetRandom()
            {
                var rnd = r.Next(1, totalCount + 1);
                foreach (var kv in ItemsExistence)
                {
                    rnd -= kv.Value;
                    if (rnd <= 0)
                        return kv.Key;
                }

                return -1;
            }
        }

        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);

            if (target <= nums[0]) return 0;

            var total = 0;
            var midIndex = Array.BinarySearch(nums, target / 2 + 1);
            if (midIndex < 0) midIndex = ~midIndex;
            total += midIndex % modulo;

            var max = target - nums[0] + 1;
            var maxIndex = Array.BinarySearch(nums, max);
            if (maxIndex < 0) maxIndex = ~maxIndex;

            for (int i = 2; i < maxIndex; i++)
            {
                total = (total % modulo + Permute(maxIndex, i) % modulo) % modulo;
            }

            // add 1 for xCx (3c3 ~ permute 3 in 3 locations)
            total = (total + 1) % modulo;

            return total;
        }

        private int Permute(in int n, in int k)
        {
            var total = 1;
            for (int i = k + 1; i <= n; i++)
            {
                total = (((total % modulo) * (i % modulo)) % modulo);
            }

            for (int i = 2; i <= n - k; i++)
            {
                total /= i;
            }

            return total;
        }


        public int FindMaxLength(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            dic.Add(0, -1);

            int sum = 0, max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i] == 0 ? 1 : -1;

                if (dic.ContainsKey(sum))
                    max = Math.Max(max, i - dic[sum]);

                if (!dic.ContainsKey(sum))
                    dic.Add(sum, i);
            }

            return max;
        }

        public IList<string> RemoveSubfolders(string[] folder)
        {
            if (folder == null || folder.Length <= 1) return folder;

            Array.Sort(folder);

            var lst = new List<string>();
            lst.Add(folder[0]);
            int low = 0, high = 1;

            while (high < folder.Length)
            {
                if (!folder[high].StartsWith(folder[low] + "/"))
                {
                    low = high;
                    lst.Add(folder[high]);
                }

                high++;
            }

            return lst;
        }

        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            var arr12 = MergeTwoIdenticalLists(arr1, arr2);
            var arr123 = MergeTwoIdenticalLists(arr12, arr3);
            return arr123;
        }

        private int[] MergeTwoIdenticalLists(int[] arr1, int[] arr2)
        {
            int left = 0, right = 0;
            var lst = new List<int>();
            while (left < arr1.Length && right < arr2.Length)
            {
                if (arr1[left] == arr2[right])
                {
                    lst.Add(arr1[left]);
                    left++;
                    right++;
                    continue;
                }

                if (arr1[left] < arr2[right])
                {
                    left++;
                }
                else
                {
                    right++;
                }
            }

            return lst.ToArray();
        }


        public int NumFriendRequests(int[] ages)
        {
            Array.Sort(ages);

            int requests = 0, left = 0, right = 1, duplicatesCount = 0;

            while (right < ages.Length)
            {
                while (left < right && ages[left] <= (0.5 * ages[right] + 7))
                    left++;

                requests += right - left;

                if (ages[right] == ages[right - 1] && ages[right] > 14)
                    duplicatesCount++;
                else duplicatesCount = 0;

                requests += duplicatesCount;

                right++;
            }

            return requests;
        }

        private bool CanFriendRequest(int a, int b)
        {
            if (b > a)
                return false;
            if (b > 100 && a < 100)
                return false;
            if (b <= (0.5 * a + 7))
                return false;

            return true;
        }

        public int SumNumbers(TreeNode root)
        {
            var sum = 0;
            if (root == null) return sum;
            SumNumbersRec(root, 0, ref sum);
            return sum;
        }

        private void SumNumbersRec(TreeNode node, int prevSum, ref int sum)
        {
            prevSum = prevSum * 10 + node.val;

            if (node.left != null) SumNumbersRec(node.left, prevSum, ref sum);
            if (node.right != null) SumNumbersRec(node.right, prevSum, ref sum);

            if (node.left == null && node.right == null)
                sum += prevSum;
        }

        public int ShortestBridge(int[][] A)
        {
            var foundFirstIsland = false;
            var hs = new HashSet<(int x, int y)>();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] == 1)
                    {
                        DFSAndMark(A, hs, i, j);
                        foundFirstIsland = true;
                        break;
                    }
                }

                if (foundFirstIsland)
                    break;
            }

            var q = new Queue<(int x, int y, int distance)>();
            foreach (var neighbor in hs)
            {
                A[neighbor.x][neighbor.y] = -1;
                q.Enqueue((neighbor.x, neighbor.y, 1));
            }

            while (q.Count > 0)
            {
                var neighbor = q.Dequeue();

                if (AddNeighborToQueue(A, q, neighbor.x + 1, neighbor.y, neighbor.distance))
                    return neighbor.distance;
                if (AddNeighborToQueue(A, q, neighbor.x - 1, neighbor.y, neighbor.distance))
                    return neighbor.distance;
                if (AddNeighborToQueue(A, q, neighbor.x, neighbor.y + 1, neighbor.distance))
                    return neighbor.distance;
                if (AddNeighborToQueue(A, q, neighbor.x, neighbor.y - 1, neighbor.distance))
                    return neighbor.distance;
            }

            return -1;
        }

        private bool AddNeighborToQueue(int[][] grid, Queue<(int x, int y, int distance)> q, int x, int y, int distance)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length || grid[x][y] == -1)
                return false;

            if (grid[x][y] == 1)
                return true;

            grid[x][y] = -1;
            q.Enqueue((x, y, distance + 1));
            return false;
        }

        private void DFSAndMark(int[][] grid, HashSet<(int x, int y)> hs, in int x, in int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length)
                return;

            if (grid[x][y] == 1)
            {
                grid[x][y] = -1;
                DFSAndMark(grid, hs, x + 1, y);
                DFSAndMark(grid, hs, x - 1, y);
                DFSAndMark(grid, hs, x, y + 1);
                DFSAndMark(grid, hs, x, y - 1);
            }
            else
            {
                hs.Add((x, y));
            }
        }

        public class IslandsDSU
        {
            private readonly int _cols;
            private int[] parent;
            public int[] size;

            public IslandsDSU(int[][] grid)
            {
                _cols = grid[0].Length;
                var n = grid.Length * _cols;
                parent = new int[n];
                size = new int[n];
                for (int i = 0; i < n; i++)
                    parent[i] = i;
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < _cols; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            var x = i * _cols + j;
                            size[x] = 1;
                        }
                    }
                }
            }

            public void Union(int i, int j)
            {
                int pi = Find(i), pj = Find(j);

                if (pi == pj) return;

                if (size[pi] >= size[pj])
                {
                    parent[pj] = parent[pi];
                    size[pi] += size[pj];
                }
                else
                {
                    parent[pi] = parent[pj];
                    size[pj] += size[pi];
                }

            }

            public int Find(in int x)
            {
                if (x != parent[x]) parent[x] = Find(parent[x]);
                return parent[x];
            }

            public int Size(int i)
            {
                return size[i];
            }

        }

        public int LargestIsland(int[][] grid)
        {
            int rows = grid.Length, cols = grid[0].Length;
            var dsu = new IslandsDSU(grid);
            var q = new Queue<(int x, int y)>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        DFSConnect(grid, dsu, (i, j), (i, j));
                    }
                    else if (grid[i][j] == 0)
                    {
                        q.Enqueue((i, j));
                    }
                }
            }

            int maxSize = dsu.size[0];
            while (q.Count > 0)
            {
                var cell = q.Dequeue();
                var validNeighbors = new HashSet<int>();

                AddCellNeighbor(dsu, grid, validNeighbors, cell.x + 1, cell.y);
                AddCellNeighbor(dsu, grid, validNeighbors, cell.x - 1, cell.y);
                AddCellNeighbor(dsu, grid, validNeighbors, cell.x, cell.y + 1);
                AddCellNeighbor(dsu, grid, validNeighbors, cell.x, cell.y - 1);

                var currentSize = 1; // current turned cell
                foreach (var validNeighbor in validNeighbors)
                    currentSize += dsu.size[validNeighbor];
                maxSize = Math.Max(maxSize, currentSize);
            }

            return maxSize;
        }

        private void AddCellNeighbor(IslandsDSU dsu, int[][] grid, HashSet<int> validNeighbors, int x, int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length)
                return;
            var parent = dsu.Find(x * grid[0].Length + y);
            validNeighbors.Add(parent);
        }

        private void DFSConnect(int[][] grid, IslandsDSU dsu, (int x, int y) parent, (int x, int y) move)
        {
            if (move.x < 0 || move.x >= grid.Length || move.y < 0 || move.y >= grid[0].Length ||
                grid[move.x][move.y] != 1)
                return;

            grid[move.x][move.y] = -1;

            var cols = grid[0].Length;
            dsu.Union(parent.x * cols + parent.y, move.x * cols + move.y);

            DFSConnect(grid, dsu, parent, (move.x, move.y + 1));
            DFSConnect(grid, dsu, parent, (move.x, move.y - 1));
            DFSConnect(grid, dsu, parent, (move.x + 1, move.y));
            DFSConnect(grid, dsu, parent, (move.x - 1, move.y));
        }

        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length, writeIndex = 0;
            var dq = new LinkedList<(int i, int val)>();
            var result = new int[n - k + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                while (dq.Last != null && dq.Last.Value.val <= nums[i])
                {
                    dq.RemoveLast();
                }

                dq.AddLast((i, nums[i]));

                while (dq.First != null && dq.First.Value.i <= i - k)
                {
                    dq.RemoveFirst();
                }

                if (i >= k - 1)
                {
                    result[writeIndex++] = dq.First.Value.val;
                }
            }

            return result;
        }

        public class Solution1
        {
            private int[] segTree;
            private int n;

            public int MaxResult(int[] nums, int k)
            {
                this.n = nums.Length;
                int maxToI = nums[nums.Length - 1];
                InitSegTree();

                Update(nums.Length - 1, nums[nums.Length - 1]);
                for (int i = nums.Length - 2; i >= 0; i--)
                {
                    int maxMoveIndex = Math.Min(i + k, nums.Length - 1);
                    var maxInWindow = Query(i + 1, maxMoveIndex);
                    maxToI = maxInWindow + nums[i];
                    Update(i, maxToI);
                }

                return maxToI;
            }

            private void InitSegTree()
            {
                segTree = new int[n * 2];
                Array.Fill(segTree, int.MinValue);
            }

            private int Query(int i, int j)
            {
                i += n;
                j += n;
                int max = int.MinValue;

                while (i <= j)
                {
                    if (j % 2 == 0)
                    {
                        max = Math.Max(segTree[j], max);
                        j--;
                    }

                    if (i % 2 == 1)
                    {
                        max = Math.Max(segTree[i], max);
                        i++;
                    }

                    i /= 2;
                    j /= 2;
                }

                return max;
            }

            private void Update(int i, int val)
            {
                i += n;

                segTree[i] = val;

                while (i > 0)
                {
                    var parent = i / 2;
                    segTree[parent] = Math.Max(segTree[parent], segTree[i]);
                    i = parent;
                }
            }
        }

        public int MaxResult_DP(int[] nums, int k)
        {
            var dp = new int?[nums.Length];
            return MaxResultRec(nums, k, 0, ref dp);
        }

        private int MaxResultRec(int[] nums, in int k, int i, ref int?[] dp)
        {
            //if (i >= nums.Length) return 0;
            if (i == nums.Length - 1) return nums[i];

            if (dp[i].HasValue)
                return dp[i].Value;

            int maxMove = Math.Min(i + k, nums.Length - 1), max = int.MinValue;
            for (int j = i + 1; j <= maxMove; j++)
            {
                max = Math.Max(max, MaxResultRec(nums, k, j, ref dp));
            }

            dp[i] = nums[i] + max;

            return dp[i].Value;
        }


        public string ReformatNumber(string number)
        {
            number = number.Replace(" ", "").Replace("-", "");

            var sb = new StringBuilder();
            while (number.Length > 0)
            {
                if (number.Length > 4)
                {
                    sb.Append(number.Substring(0, 3));
                    sb.Append("-");
                    number = number.Substring(3);
                }
                else if (number.Length == 4)
                {
                    sb.Append(number.Substring(0, 2));
                    sb.Append("-");
                    sb.Append(number.Substring(2, 2));
                    number = string.Empty;
                }
                else
                {
                    sb.Append(number);
                    number = string.Empty;
                }
            }

            return sb.ToString();
        }

        public int MaximumUniqueSubarray(int[] nums)
        {
            var hs = new HashSet<int>();
            int low = 0, high = 0, currSum = 0, maxSum = 0;

            while (high < nums.Length)
            {
                while (hs.Contains(nums[high]))
                {
                    currSum -= nums[low];
                    hs.Remove(nums[low]);
                    low++;
                }

                hs.Add(nums[high]);
                currSum += nums[high];
                if (maxSum < currSum)
                    maxSum = currSum;
                high++;
            }

            return maxSum;
        }

        public TreeNode Str2tree(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;
            int i = 0, num = 0, sign = 1;
            if (s[i] == '-')
            {
                sign = -1;
                i++;
            }
            while (i < s.Length && s[i] != '(')
            {
                num = num * 10 + (s[i] - '0');
                i++;
            }

            var node = new TreeNode(num * sign);

            var left = i;
            var right = GetLastPosition(s, i);
            node.left = left + 1 < s.Length ? Str2tree(s.Substring(left + 1, right - left - 1)) : null;

            i = right + 1;
            left = i;
            right = GetLastPosition(s, i);
            node.right = left + 1 < s.Length ? Str2tree(s.Substring(left + 1, right - left - 1)) : null;
            return node;
        }

        private static int GetLastPosition(string s, int i)
        {
            int openCount = 1;
            i++;
            while (i < s.Length && openCount != 0)
            {
                if (s[i] == '(')
                    openCount++;
                else if (s[i] == ')')
                    openCount--;
                i++;
            }
            return i - 1;
        }

        public IList<IList<string>> GroupStrings(string[] strings)
        {
            var lst = new List<IList<string>>();
            var groups = strings.GroupBy(s => s.Length).Select(ig => ig.ToArray()).ToArray();
            foreach (var group in groups)
            {
                var dic = new Dictionary<string, List<string>>();
                dic.Add(group[0], new List<string> { group[0] });
                for (int i = 1; i < group.Length; i++)
                {
                    var foundMatch = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (CanSwitchTo(group[i], group[j]))
                        {
                            dic[group[j]].Add(group[i]);
                            foundMatch = true;
                            break;
                        }
                    }

                    if (!foundMatch)
                        dic.Add(group[i], new List<string> { group[i] });
                }

                foreach (var kv in dic)
                {
                    lst.Add(kv.Value);
                }
            }

            return lst;
        }

        private bool CanSwitchTo(string s, string t)
        {
            if (s == t) return true;
            var diff = s[0] - t[0];
            diff = diff < 0 ? diff + 26 : diff;
            for (int i = 1; i < s.Length; i++)
            {
                var cdiff = s[i] - t[i];
                cdiff = cdiff < 0 ? cdiff + 26 : cdiff;
                if (cdiff != diff)
                    return false;
            }
            return true;
        }

        public int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
            int rows = grid.Length, cols = grid[0].Length;
            var moves = new[] { new[] { 0, -1 }, new[] { 0, 1 }, new[] { -1, 0 }, new[] { 1, 0 } };
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        var q = new Queue<(int x, int y)>();
                        grid[i][j] = -1;
                        q.Enqueue((i, j));
                        while (q.Count > 0)
                        {
                            var cell = q.Dequeue();

                            var borders = 0;

                            foreach (var move in moves)
                            {
                                var (x, y) = (move[0] + cell.x, move[1] + cell.y);
                                var validState = IsValidCellMove(grid, x, y);
                                switch (validState)
                                {
                                    case CellMoveState.Invalid:
                                        borders++;
                                        break;
                                    case CellMoveState.Valid:
                                        grid[x][y] = -1;
                                        q.Enqueue((x, y));
                                        break;
                                    case CellMoveState.PrevNeighbor:
                                        break;
                                    default:
                                        throw new ArgumentOutOfRangeException();
                                }
                            }

                            perimeter += borders;
                        }

                        return perimeter;
                    }
                }
            }

            return perimeter;
        }

        public enum CellMoveState
        {
            Invalid,
            Valid,
            PrevNeighbor
        }

        private CellMoveState IsValidCellMove(int[][] grid, in int x, in int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length || grid[x][y] == 0)
                return CellMoveState.Invalid;
            return grid[x][y] == -1 ? CellMoveState.PrevNeighbor : CellMoveState.Valid;
        }

        public int ClosestValue(TreeNode root, double target)
        {
            if (root == null) return -1;
            TreeNode node = root, lowerBound = null, upperBound = null;

            while (node != null)
            {
                if (target > node.val)
                {
                    lowerBound = node;
                    node = node.right;
                }
                else
                {
                    upperBound = node;
                    node = node.left;
                }
            }

            if (upperBound != null && lowerBound != null)
                return target - lowerBound.val > upperBound.val - target ? upperBound.val : lowerBound.val;
            return upperBound?.val ?? lowerBound?.val ?? 0;
        }

        public class Codec_Urls
        {
            private int MaxTinyLength = 8;
            Random r = new Random();
            Dictionary<string, string> hashToUrlDic = new Dictionary<string, string>();
            private string baseUrl = "http://tinyurl.com/";

            // Encodes a URL to a shortened URL
            public string encode(string longUrl)
            {
                string hash;
                do
                {
                    hash = GetHashString(longUrl);
                } while (hashToUrlDic.ContainsKey(hash));
                hashToUrlDic.Add(hash, longUrl);
                return $"{baseUrl}{hash}";
            }

            private string GetHashString(string longUrl)
            {
                var sb = new StringBuilder(MaxTinyLength);
                var options = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                for (int i = 0; i < MaxTinyLength; i++)
                    sb.Append(options[r.Next(options.Length)]);
                return sb.ToString();
            }

            // Decodes a shortened URL to its original URL.
            public string decode(string shortUrl)
            {
                var hash = shortUrl.Replace(baseUrl, "");
                return hashToUrlDic.ContainsKey(hash) ? hashToUrlDic[hash] : string.Empty;
            }
        }

        public double AngleClock(int hour, int minutes)
        {
            hour = hour % 12;
            double hoursAngles = hour * 30;
            hoursAngles += minutes / 2.0; //minutes / 60 * 30

            var minutesAngles = 6 * minutes;

            var result = Math.Abs(minutesAngles - hoursAngles);
            return result > 180 ? 360 - result : result;
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

        public string StringShift(string s, int[][] shift)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            int leftShift = 0, rightShift = 0;

            foreach (var sh in shift)
            {
                if (sh[0] == 0)
                    leftShift += sh[1];
                if (sh[0] == 1)
                    rightShift += sh[1];
            }

            var shifts = leftShift - rightShift;
            if (shifts == 0)
                return s;

            //var sb = new StringBuilder(s);
            if (shifts > 0)
            {
                shifts = shifts % s.Length;
                //for (int i = 0; i <= s.Length / 2; i++)
                //{
                //    var mod = (i - shifts) % s.Length;
                //    if (mod < 0) mod += s.Length;

                //    var temp = sb[shifts > 0 ? mod : i];
                //    sb[shifts > 0 ? mod : i] = sb[shifts > 0 ? i : mod];
                //    sb[shifts > 0 ? i : mod] = temp;
                //}
                return s.Substring(shifts) + s.Substring(0, shifts);
            }
            else
            {
                shifts = -shifts;
                shifts = shifts % s.Length;

                return s.Substring(s.Length - shifts) + s.Substring(0, s.Length - shifts);
                //for (int i = s.Length - 1; i >= s.Length / 2; i--)
                //{
                //    var mod = (i + shifts) % s.Length;
                //    var temp = sb[mod];
                //    sb[mod] = sb[i];
                //    sb[i] = temp;
                //}
            }
        }

        public int NumSquares(int n)
        {
            int sqrt = (int)Math.Sqrt(n);

            int min = n, num = n;
            for (int i = sqrt; i > 0; i--)
            {
                int factors = 0, oldI = i, i2 = oldI * oldI;
                while (num > 0)
                {
                    factors += (num / i2);
                    num %= i2;
                    oldI--;
                    i2 = oldI * oldI;
                }

                if (factors > 0)
                    min = Math.Min(factors, min);
                num = n;
            }

            return min;
        }


        public int NumPrimeArrangements(int n)
        {
            var countPrimes = CountPrimes(n + 1);
            long res = 1;
            for (int i = countPrimes; i > 0; i--)
            {
                res = (res * i) % modulo;
                res %= modulo;
            }

            for (int i = n - countPrimes; i > 0; i--)
            {

                res = (res * i) % modulo;
                res %= modulo;
            }

            return (int)res;
            //return (int)((Factorial(countPrimes) % modulo) * (Factorial(n - countPrimes) % modulo) % modulo);
        }

        public long Factorial(long n)
        {
            var factorial = 1;
            for (int i = 2; i <= n; i++)
                factorial = ((factorial % modulo) * (i % modulo)) % modulo;

            return factorial;
        }

        public bool IsUgly(int num)
        {
            if (num < 1) return false;
            if (num == 1) return true;

            var allowedPrimes = new HashSet<int> { 2, 3, 5 };
            for (int i = 2; i < 6 && num > 0; i++)
            {
                while (num % i == 0)
                    num /= i;
            }

            return num == 1;
        }

        public bool CanArrange(int[] arr, int k)
        {
            var kMods = new int[k + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                var x = arr[i];
                var rem = ((x % k) + k) % k;
                kMods[rem]++;
            }

            int pairsCount = 0;
            for (int i = 0; i < kMods.Length; i++)
            {
                while (kMods[i] > 0)
                {
                    int j = i;
                    if (kMods[(k - j) % k] > 0)
                    {
                        kMods[i]--;
                        kMods[(k - j) % k]--;
                        pairsCount++;
                        if (kMods[i] < 0)
                            return false;
                    }
                    else return false;
                }
            }

            return arr.Length / 2 == pairsCount;
        }

        public int NthMagicalNumber(int N, int A, int B)
        {
            int low = Math.Min(A, B), high = N * Math.Max(A, B);
            // 2, 6
            // 1 * 2, 2 * 2, 3 * 2 ... then 2 * 6 = 12 ... keep going for first elem 4 * 2, 5 * 2 < 12 then 3 * 6 then 6 * 2 and so on
            return 0;
        }

        public IList<int> SelfDividingNumbers(int left, int right)
        {
            var lst = new List<int>();
            for (int num = left; num <= right; num++)
            {
                if (IsDivisibleOnBits(num))
                {
                    lst.Add(num);
                }
            }

            return lst;
        }

        private bool IsDivisibleOnBits(in int num)
        {
            var n = num;
            while (n != 0)
            {
                var mod = n % 10;
                if (mod == 0) return false;
                if (num % mod != 0) return false;
                n /= 10;
            }
            return true;
        }

        public bool CheckPerfectNumber(int num)
        {
            if (num <= 1) return false;

            var sum = 1;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum += (num / i);
                    sum += i;
                }
            }

            return sum == num;
        }

        public int SumFourDivisors(int[] nums)
        {
            var totalSum = 0;
            foreach (var num in nums)
            {
                int sum = 0, count = 0;
                for (int i = 1; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += (num / i);
                        sum += i;
                        count += num / i == i ? 1 : 2;
                    }
                }

                if (count == 4)
                    totalSum += sum;
            }

            return totalSum;
        }

        public string MinWindow(string S, string T)
        {
            if (S.Length < T.Length) return string.Empty;
            int left = 0, right = 0, tIdx = 0;
            var minStr = new string(' ', S.Length + 1);
            while (right < S.Length)
            {
                if (S[right] == T[tIdx])
                {
                    tIdx++;
                    // Found T
                    if (tIdx == T.Length)
                    {
                        // Narrow the window
                        while (S[left] != T[0])
                            left++;

                        var subStr = S.Substring(left, right - left + 1);
                        // Found better solution
                        if (minStr.Length > subStr.Length)
                            minStr = subStr;

                        tIdx = 0;
                        right = left;
                        left++;
                    }
                }
                right++;
            }

            return minStr.Length == S.Length + 1 ? string.Empty : minStr;
        }

        public int[] MaxSumOfThreeSubarrays(int[] nums, int k)
        {
            // Review this video https://www.youtube.com/watch?v=sSjz_Cf4Bkw
            int currOneSum = 0, currTwoSum = 0, currThreeSum = 0;
            int currOneTotalSum = 0, currTwoTotalSum = 0, currThreeTotalSum = 0;
            int bestOneSumIdx = 0;
            int[] bestTwoSumIdx = { 0, k };
            int[] bestThreeSumIdx = { 0, k, k * 2 };

            for (int i = 0; i < k * 3; i++)
            {
                currOneTotalSum += i < k ? nums[k] : 0;
                currTwoTotalSum += i < 2 * k ? nums[k] : 0;
                currThreeTotalSum += i < 3 * k ? nums[k] : 0;
            }

            currOneSum = currOneTotalSum;
            currTwoSum = currTwoTotalSum - currOneTotalSum;
            currThreeSum = currThreeTotalSum - currTwoTotalSum;

            int n = nums.Length;
            for (int i = 1; i <= n - 3 * k; i++)
            {
                currOneSum += nums[i + k - 1];
                currOneSum -= nums[i + 0 * k - 1];
                if (currOneSum > currOneTotalSum)
                {
                    currOneTotalSum = currOneSum;
                    bestOneSumIdx = i;
                }

                currTwoSum += nums[i + 2 * k - 1];
                currTwoSum -= nums[i + 1 * k - 1];
                if (currTwoSum + currOneTotalSum > currTwoTotalSum)
                {
                    currTwoTotalSum = currTwoSum + currOneTotalSum;
                    bestTwoSumIdx = new[] { bestOneSumIdx, i + k };
                }

                currThreeSum += nums[i + 3 * k - 1];
                currThreeSum -= nums[i + 2 * k - 1];
                if (currThreeSum + currTwoTotalSum > currThreeTotalSum)
                {
                    currThreeTotalSum = currThreeSum + currTwoTotalSum;
                    bestThreeSumIdx = new[] { bestTwoSumIdx[0], bestTwoSumIdx[1], i + 2 * k };
                }
            }

            return bestThreeSumIdx;
        }

        public int[] MaxSumOfThreeSubarrays1(int[] nums, int k)
        {
            var dp = new int?[3][];
            for (int i = 0; i < dp.Length; i++)
                dp[i] = new int?[nums.Length];

            var sum = 0;
            var prefixSum = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                prefixSum[i] = sum;
            }

            MaxSumOfThreeSubarraysRec(prefixSum, idx: 0, subArrayIdx: 0, k, ref dp);

            var res = new int[3];
            int maxSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dp[0][i].HasValue)
                    break;
                for (int j = i + k; j < nums.Length; j++)
                {
                    if (!dp[1][j].HasValue)
                        break;
                    for (int l = j + k; l < nums.Length; l++)
                    {
                        if (!dp[2][l].HasValue)
                            break;

                        sum = dp[0][i].Value + dp[1][j].Value + dp[2][l].Value;
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            res = new[] { i, j, l };
                        }
                    }
                }
            }

            return res;
        }

        private int MaxSumOfThreeSubarraysRec(int[] prefixSum, int idx, int subArrayIdx, int k, ref int?[][] dp)
        {
            if (subArrayIdx >= 3) return -1;
            if (idx + k > prefixSum.Length || prefixSum.Length - (3 - subArrayIdx) * k - idx < 0) return -1;
            if (dp[subArrayIdx][idx].HasValue)
                return dp[subArrayIdx][idx].Value;
            dp[subArrayIdx][idx] = prefixSum[idx + k - 1] - (idx == 0 ? 0 : prefixSum[idx - 1]);

            MaxSumOfThreeSubarraysRec(prefixSum, idx + k, subArrayIdx + 1, k, ref dp);

            MaxSumOfThreeSubarraysRec(prefixSum, idx + 1, subArrayIdx, k, ref dp);

            return dp[subArrayIdx][idx].Value;
        }

        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0) return board;
            var (x, y) = (click[0], click[1]);
            if (board[x][y] == 'M')
            {
                board[x][y] = 'X';
                return board;
            }
            else if (board[x][y] == 'E')
            {
                var movingDirections = new[]
                {
                    new[] {-1, -1}, new[] {-1, 0}, new[] {-1, 1},
                    new[] {0, -1}, new[] {0, 1},
                    new[] {1, -1}, new[] {1, 0}, new[] {1, 1}
                };

                var q = new LinkedList<(int i, int j)>();
                q.AddLast((x, y));
                while (q.Count > 0)
                {
                    var (i, j) = q.First();
                    q.RemoveFirst();

                    int minesAround = 0;
                    foreach (var movingDirection in movingDirections)
                    {
                        int newX = i + movingDirection[0], newY = j + movingDirection[1];
                        if (IsValidMineSweeperMove(board, newX, newY))
                        {
                            if (board[newX][newY] == 'M' || board[newX][newY] == 'X')
                                minesAround++;
                        }
                    }

                    if (minesAround > 0)
                    {
                        board[i][j] = (char)(minesAround + '0');
                    }
                    else
                    {
                        board[i][j] = 'B';
                        foreach (var movingDirection in movingDirections)
                        {
                            int newX = i + movingDirection[0], newY = j + movingDirection[1];
                            if (IsValidMineSweeperMove(board, newX, newY))
                            {
                                q.AddLast((newX, newY));
                                board[newX][newY] = 'B';
                            }
                        }
                    }
                }
            }

            return board;
        }

        private bool IsValidMineSweeperMove(char[][] board, in int x, in int y)
        {
            if (x < 0 || x >= board.Length || y < 0 || y >= board[0].Length || board[x][y] == 'B')
                return false;
            return true;
        }

        bool Knows(int a, int b)
        {
            return false;
        }

        public int FindCelebrity(int n)
        {
            var celeberties = new HashSet<int>();
            for (int i = 0; i < n; i++)
                celeberties.Add(i);

            var next = 0;
            celeberties.Remove(0);
            while (celeberties.Count > 0)
            {
                var celeberty = celeberties.ElementAt(0);
                if (Knows(next, celeberty))
                {
                    next = celeberty;
                    celeberties.Remove(next);
                }
                else
                {
                    celeberties.Remove(celeberty);
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (next == i) continue;
                if (Knows(next, i) || !Knows(i, next)) return -1;
            }

            return next;
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public int MaxDepth(Node root)
        {
            return MaxDepthRec(root);
        }

        private int MaxDepthRec(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            var max = 0;
            foreach (var childNode in node.children)
            {
                max = Math.Max(max, MaxDepthRec(childNode));
            }

            return max + 1;
        }

        public int MaxAncestorDiff(TreeNode root)
        {
            return MaxAncestorDiffRec1(root, root.val, root.val);
        }

        private int MaxAncestorDiffRec1(TreeNode root, in int minVal, in int maxVal)
        {
            if (root == null)
            {
                return Math.Abs(maxVal - minVal);
            }

            var left = MaxAncestorDiffRec1(root.left, Math.Min(minVal, root.val), Math.Max(maxVal, root.val));
            var right = MaxAncestorDiffRec1(root.right, Math.Min(minVal, root.val), Math.Max(maxVal, root.val));

            return Math.Max(left, right);
        }


        public int MaxAncestorDiff1(TreeNode root)
        {
            int max = 0;

            MaxAncestorDiffRec(root, ref max);

            return max;
        }

        private (int min, int max) MaxAncestorDiffRec(TreeNode node, ref int max)
        {
            if (node.left == null && node.right == null)
                return (node.val, node.val);

            var (leftMin, leftMax) = node.left != null ? MaxAncestorDiffRec(node.left, ref max) : (node.val, node.val);
            var (rightMin, rightMax) = node.right != null ? MaxAncestorDiffRec(node.right, ref max) : (node.val, node.val);

            var absMin = Math.Min(leftMin, rightMin);
            var absMax = Math.Max(leftMax, rightMax);

            var option1 = Math.Abs(node.val - absMin);
            var option2 = Math.Abs(node.val - absMax);

            max = Math.Max(max, Math.Max(option1, option2));

            return (Math.Min(node.val, absMin), Math.Max(node.val, absMax));
        }

        //public int[] MaxSumOfThreeSubarrays(int[] nums, int k)
        //{
        //    var dp = new int?[3, nums.Length];
        //    return MaxSumOfThreeSubarraysRec(nums, 0, subArrayMaxSize: k, currentSubArrayIndex: 0, ref dp);
        //}

        //private int[] MaxSumOfThreeSubarraysRec(int[] nums, int i, in int subArrayMaxSize, int currentSubArrayIndex, ref int?[,] dp)
        //{


        //}

        public bool IsMatch(string s, string p)
        {
            var dp = new bool?[s.Length + 1, p.Length + 1];
            return IsMatchRec(s, p, 0, 0, ref dp);
        }

        private bool IsMatchRec(string s, string p, int si, int pi, ref bool?[,] dp)
        {
            if (pi == p.Length) return si == s.Length;
            if (si >= s.Length) return p.Substring(pi).All(ch => ch == '*');
            if (dp[si, pi].HasValue) return dp[si, pi].Value;

            var isCurrentCharMatch = s[si] == p[pi] || p[pi] == '?';

            bool isMatch = false;
            if (isCurrentCharMatch)
                isMatch = IsMatchRec(s, p, si + 1, pi + 1, ref dp);
            else if (p[pi] == '*')
            {
                isMatch = IsMatchRec(s, p, si + 1, pi, ref dp) ||
                          IsMatchRec(s, p, si, pi + 1, ref dp) ||
                          IsMatchRec(s, p, si + 1, pi + 1, ref dp);
            }

            dp[si, pi] = isMatch;
            return isMatch;
        }

        public class WordFilter
        {
            class TrieNodeEqualityComparer : IEqualityComparer<TrieNode>
            {
                public bool Equals(TrieNode x, TrieNode y)
                {
                    return x.ch.Equals(y.ch);
                }

                public int GetHashCode(TrieNode obj)
                {
                    return obj.ch.GetHashCode();
                }
            }

            class RemainingWordEqualityComparer : IEqualityComparer<RemainingWord>
            {
                public bool Equals(RemainingWord x, RemainingWord y)
                {
                    return x.word.Equals(y.word);
                }

                public int GetHashCode(RemainingWord obj)
                {
                    return obj.word.GetHashCode();
                }
            }

            public class RemainingWord
            {
                public string word;
                public int index;
            }

            public class TrieNode
            {
                public TrieNode(char ch)
                {
                    this.ch = ch;
                    children = new HashSet<TrieNode>(new TrieNodeEqualityComparer());
                    remainingWords = new HashSet<RemainingWord>(new RemainingWordEqualityComparer());
                }

                public char ch;

                public HashSet<TrieNode> children;
                public HashSet<RemainingWord> remainingWords;

                public override string ToString()
                {
                    return this.ch.ToString();
                }
            }

            public HashSet<TrieNode> roots;

            public void AddWord(string word, int wordIndex = -1)
            {
                var root = roots;

                var remainingWord = new string(word.Reverse().ToArray());
                var remWord = new RemainingWord { word = remainingWord, index = wordIndex };
                for (int i = 0; i < word.Length; i++)
                {
                    var trieNode = new TrieNode(word[i]);

                    if (root.TryGetValue(trieNode, out var foundTrie))
                    {
                        foundTrie.remainingWords.Remove(remWord);
                        foundTrie.remainingWords.Add(remWord);
                        root = foundTrie.children;
                    }
                    else
                    {
                        trieNode.remainingWords.Remove(remWord);
                        trieNode.remainingWords.Add(remWord);
                        root.Add(trieNode);
                        root = trieNode.children;
                    }
                }
            }

            public WordFilter(string[] words)
            {
                roots = new HashSet<TrieNode>(new TrieNodeEqualityComparer());
                for (int i = 0; i < words.Length; i++)
                {
                    AddWord(words[i], i);
                }
            }

            public int F(string prefix, string suffix)
            {
                suffix = new string(suffix.Reverse().ToArray());
                var root = this.roots;
                if (root == null) return -1;

                TrieNode foundTrie = null;
                for (int i = 0; i < prefix.Length; i++)
                {
                    var ch = prefix[i];

                    var trieNode = new TrieNode(ch);
                    if (root.TryGetValue(trieNode, out foundTrie))
                        root = foundTrie.children;
                    else
                        return -1;
                }

                if (foundTrie != null)
                {
                    var matchWord = foundTrie.remainingWords.Where(rem => rem.word.StartsWith(suffix))
                        .OrderByDescending(rem => rem.index).FirstOrDefault();
                    if (matchWord != null)
                        return matchWord.index;
                }
                return -1;
            }
        }

        public class RangeModule
        {
            class Interval
            {
                public int start;
                public int end;
            }

            private List<Interval> intervals;

            public RangeModule()
            {
                intervals = new List<Interval>();
            }

            public void AddRange(int left, int right)
            {
                int i = 0, n = intervals.Count;

                while (i < n && intervals[i].start < left)
                {
                    i++;
                }

                if (i == 0 || left > intervals[i].end)
                {
                    intervals.Add(new Interval { start = left, end = right });
                }
                else
                {
                    intervals[i].end = Math.Max(intervals[i].end, right);
                }

                while (i + 1 < intervals.Count)
                {
                    if (intervals[i + 1].start <= intervals[i].end)
                    {
                        intervals[i].end = Math.Max(intervals[i].end, intervals[i + 1].end);
                        intervals.RemoveAt(i + 1);
                    }
                    else break;
                }
            }

            public bool QueryRange(int left, int right)
            {
                return false;
            }

            public void RemoveRange(int left, int right)
            {
                int i = 0, n = intervals.Count;
                while (i < n && intervals[i].end < left)
                {
                    i++;
                }

                if (intervals[i].start == left && intervals[i].end == right)
                {
                    intervals.RemoveAt(i);
                }
                else
                {
                    if (intervals[i].start == left)
                    {

                    }
                    else if (intervals[i].end == right)
                    {

                    }
                    else
                    {

                    }
                }

                //var newInterval = new Interval{start = }
            }
        }


        Dictionary<int, int> ConfusingNumberDic = new Dictionary<int, int>
        {
            {0, 0},
            {1, 1},
            {6, 9},
            {9, 6},
            {8, 8},
        };
        Dictionary<long, bool> IsConfusingDic = new Dictionary<long, bool>();

        public int ConfusingNumberII(int N)
        {
            int count = 0;
            ConfusingNumberIIRec(N, 0, ref count);
            return count;
        }

        private void ConfusingNumberIIRec(in long N, long current, ref int count)
        {
            if (ConfusingNumber(current))
                count++;

            foreach (var key in ConfusingNumberDic.Keys)
            {
                var next = current * 10 + key;
                if (next <= N)
                {
                    if (next != 0)
                        ConfusingNumberIIRec(N, next, ref count);
                }
                else break;
            }
        }

        public bool ConfusingNumber(long number)
        {
            if (IsConfusingDic.ContainsKey(number))
                return IsConfusingDic[number];

            long reverse = 0, src = number;

            while (number != 0)
            {
                var mod = (int)(number % 10);
                if (!ConfusingNumberDic.ContainsKey(mod))
                    return false;
                reverse = reverse * 10 + ConfusingNumberDic[mod];
                number = number / 10;
            }

            IsConfusingDic[number] = reverse != src;
            return IsConfusingDic[number];
        }


        public int ConfusingNumberII(int low, int high)
        {
            var lst = new HashSet<string>();

            int minLength = low.ToString().Length, maxLength = high.ToString().Length;
            for (int l = minLength; l <= maxLength; l++)
            {
                var arr = new char[l];
                GenerateConfusingNumber(arr, 0, ref lst);
            }

            string lowStr = low.ToString(), highStr = high.ToString();
            return lst.Where(s =>
                {
                    return (s.Length > lowStr.Length || s.CompareTo(lowStr) > 0) &&
                           (s.Length < highStr.Length || s.CompareTo(highStr) <= 0);
                })
                .Count(ConfusingNumber);
        }

        private void GenerateConfusingNumber(char[] arr, int i, ref HashSet<string> lst)
        {
            if (i == arr.Length)
            {
                lst.Add(new string(arr));
                return;
            }

            var options = new[] { '0', '1', '6', '9', '8' };

            foreach (var option in options)
            {
                arr[i] = option;
                GenerateConfusingNumber(arr, i + 1, ref lst);
            }
        }

        public bool ConfusingNumber(string str)
        {
            var dic = new Dictionary<char, char>
            {
                {'0','0'},
                {'1','1'},
                {'6','9'},
                {'9','6'},
                {'8','8'},
            };

            var sb = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                //if (!dic.ContainsKey(str[i])) return false;
                sb[str.Length - i - 1] = dic[str[i]];
            }

            return new string(sb) != str;
        }

        public bool IsPalindrome(string word, in int i)
        {
            if (i >= word.Length) return false;
            int low = i, high = word.Length - 1;
            while (low < high)
            {
                if (word[low++] != word[high--]) return false;
            }
            return true;
        }

        public int StrobogrammaticInRange(string low, string high)
        {
            var dic = new Dictionary<char, char>
            {
                {'0','0'},
                {'1','1'},
                {'6','9'},
                {'9','6'},
                {'8','8'},
            };
            var identicalToSelf = new[] { '0', '1', '8' };

            var lst = new List<string>();

            int minLength = low.Length, maxLength = high.Length;
            for (int i = minLength; i <= maxLength; i++)
            {
                var sb = new char[i];
                FindStrobogrammaticRec1(sb, 0, i, ref dic, ref identicalToSelf, ref lst);
            }

            return lst.Count(s =>
            {
                return (s.Length > low.Length || s.CompareTo(low) >= 0) &&
                       (s.Length < high.Length || s.CompareTo(high) <= 0);
            });
        }

        private void FindStrobogrammaticRec1(char[] sb, int i, in int n, ref Dictionary<char, char> dic, ref char[] identicalToSelf, ref List<string> lst)
        {
            if (n == 0)
            {
                lst.Add(new string(sb));
                return;
            }

            if (n >= 2)
            {
                foreach (var kv in dic)
                {
                    if (i == 0 && kv.Key == '0') continue;
                    sb[i] = kv.Key;
                    sb[sb.Length - i - 1] = kv.Value;
                    FindStrobogrammaticRec1(sb, i + 1, n - 2, ref dic, ref identicalToSelf, ref lst);
                }
            }

            if (n == 1)
            {
                foreach (var i1 in identicalToSelf)
                {
                    sb[i] = i1;
                    FindStrobogrammaticRec1(sb, i + 1, n - 1, ref dic, ref identicalToSelf, ref lst);
                }
            }

        }

        public class BricksDSU
        {
            private readonly int _rows;
            private readonly int _cols;
            private int[] parent;
            public int[] size;

            public BricksDSU(int n, int rows, int cols)
            {
                _rows = rows;
                _cols = cols;
                parent = new int[n];
                size = new int[n];
                Array.Fill(size, 1);
                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                }
            }

            public void Union(int i, int j)
            {
                int pi = Find(i), pj = Find(j);

                if (pi == pj) return;

                if (size[pi] >= size[pj] || IsTopCell(pi))
                {
                    parent[pj] = parent[pi];
                    size[pi] += size[pj];
                    if (IsTopCell(pi))
                        size[size.Length - 1] += size[pj];
                }
                else
                {
                    parent[pi] = parent[pj];
                    size[pj] += size[pi];
                    if (IsTopCell(pj))
                        size[size.Length - 1] += size[pi];
                }

            }

            private bool IsTopCell(in int pi)
            {
                return pi < _cols;
            }

            private int Find(in int x)
            {
                if (x != parent[x]) parent[x] = Find(parent[x]);
                return parent[x];
            }

            public int Size(int i)
            {
                return size[i];
            }

            public int SizeTop()
            {
                return size[size.Length - 1];
            }
        }

        public int[] HitBricks(int[][] grid, int[][] hits)
        {
            var result = new int[hits.Length];
            int rows = grid.Length, cols = grid[0].Length;
            foreach (var hit in hits)
            {
                if (grid[hit[0]][hit[1]] == 0)
                    grid[hit[0]][hit[1]] = -1;
                else grid[hit[0]][hit[1]] = 0;
            }

            var dsu = new BricksDSU(rows * cols + 1, rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (i == 0)
                            dsu.Union(i * cols + j, rows * cols);
                        if (IsValidGridMove(grid, i + 1, j))
                            dsu.Union(i * cols + j, (i + 1) * cols + j);
                        if (IsValidGridMove(grid, i, j + 1))
                            dsu.Union(i * cols + j, i * cols + j + 1);
                    }
                }
            }


            int step = hits.Length - 1;
            for (int x = hits.Length - 1; x >= 0; x--)
            {
                var hit = hits[x];
                if (grid[hit[0]][hit[1]] == -1)
                {
                    grid[hit[0]][hit[1]] = 0;
                    result[step--] = 0;
                    continue;
                }

                grid[hit[0]][hit[1]] = 1;

                var currentSize = dsu.SizeTop();

                var (i, j) = (hit[0], hit[1]);
                if (IsValidGridMove(grid, i + 1, j))
                {
                    dsu.Union(i * cols + j, (i + 1) * cols + j);
                }

                if (IsValidGridMove(grid, i - 1, j))
                {
                    dsu.Union(i * cols + j, (i - 1) * cols + j);
                }

                if (IsValidGridMove(grid, i, j + 1))
                {
                    dsu.Union(i * cols + j, i * cols + j + 1);
                }

                if (IsValidGridMove(grid, i, j - 1))
                {
                    dsu.Union(i * cols + j, i * cols + j - 1);
                }

                if (i == 0)
                    dsu.Union(i * cols + j, rows * cols);
                //var q = new Queue<(int x, int y)>();
                //q.Enqueue((hit[0], hit[1]));
                //var visited = new bool[rows, cols];
                //while (q.Count > 0)
                //{
                //    var (i, j) = q.Dequeue();
                //    if(visited[i, j]) continue;
                //    visited[i, j] = true;

                //    if (IsValidGridMove(grid, i + 1, j))
                //    {
                //        dsu.Union(i * cols + j, (i + 1) * cols + j);
                //        q.Enqueue((i + 1, j));
                //    }

                //    if (IsValidGridMove(grid, i - 1, j))
                //    {
                //        dsu.Union(i * cols + j, (i - 1) * cols + j);
                //        q.Enqueue((i - 1, j));
                //    }

                //    if (IsValidGridMove(grid, i, j + 1))
                //    {
                //        dsu.Union(i * cols + j, i * cols + j + 1);
                //        q.Enqueue((i, j + 1));
                //    }

                //    if (IsValidGridMove(grid, i, j - 1))
                //    {
                //        dsu.Union(i * cols + j, i * cols + j - 1);
                //        q.Enqueue((i, j - 1));
                //    }
                //}

                result[step--] = Math.Max(0, dsu.SizeTop() - currentSize - 1);
            }

            return result;
        }

        private bool IsValidGridMove(int[][] grid, in int i, int j)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != 1)
                return false;
            return true;
        }

        public bool JudgePoint24(int[] nums)
        {
            return JudgePoint24Rec(nums.Select(n => (double)n).ToList());
        }

        private bool JudgePoint24Rec(List<double> arr)
        {
            double eps = 0.001;
            if (arr.Count == 1)
            {
                //if(arr[0] >= 23 && arr[0] < 25) arr[0].Print();
                if (Math.Abs(arr[0] - 24) < eps)
                    return true;
                return false;
            }

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    double p1 = arr[i], p2 = arr[j];
                    var firstPairOps = new List<double>
                    {
                        p1 + p2, p1 - p2, p2 - p1, p1 * p2
                    };

                    if (Math.Abs(p2) > eps)
                        firstPairOps.Add(p1 / p2);
                    if (Math.Abs(p1) > eps)
                        firstPairOps.Add(p2 / p1);

                    arr.RemoveAt(i);
                    arr.RemoveAt(j);

                    foreach (var firstPairOp in firstPairOps)
                    {
                        arr.Add(firstPairOp);
                        if (JudgePoint24Rec(arr))
                            return true;
                        arr.RemoveAt(arr.Count - 1);
                    }

                    arr.Insert(j, p2);
                    arr.Insert(i, p1);
                }
            }

            return false;
        }

        public bool JudgePoint241(int[] nums)
        {
            var ops = new int[] { '/', '*', '+', '-' };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    for (int op1 = 0; op1 < ops.Length; op1++)
                    {
                        var ij = Eval((double)nums[i], (double)nums[j], ops, op1);
                        for (int k = 0; k < nums.Length; k++)
                        {
                            if (k == j || k == i) continue;
                            for (int l = 0; l < nums.Length; l++)
                            {
                                if (l == k || l == j || l == i) continue;
                                for (int op2 = 0; op2 < ops.Length; op2++)
                                {
                                    var kl = Eval((double)nums[k], (double)nums[l], ops, op2);
                                    for (int op3 = 0; op3 < ops.Length; op3++)
                                    {
                                        var total = Eval(ij, kl, ops, op3);
                                        if (total >= 23 && total < 26) total.Print();
                                        if (Math.Abs(total - 24.0) < 0.4) return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        private double Eval(double ij, double kl, int[] ops, in int opIndex)
        {
            double eps = 0.001;
            switch (ops[opIndex])
            {
                case '/':
                    return Math.Abs(kl) > eps ? (ij / kl) : 100;
                case '*':
                    return ij * kl;
                case '+':
                    return ij + kl;
                case '-':
                    return ij - kl;
            }
            return 0;
        }

        public class ListEqualityComparer : IEqualityComparer<List<int>>
        {
            public bool Equals(List<int> x, List<int> y)
            {
                if (x == null && y == null) return true;
                if (x == null || y == null) return false;
                if (x.Count != y.Count) return false;
                for (int i = 0; i < x.Count; i++)
                {
                    if (x[i] != y[i]) return false;
                }

                return true;
            }

            public int GetHashCode(List<int> obj)
            {
                return string.Join("|", obj).GetHashCode();
            }
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            if (target <= 0) return new List<IList<int>>();
            if (candidates == null || candidates.Length == 0) return new List<IList<int>>();
            Array.Sort(candidates);
            if (target < candidates[0]) return new List<IList<int>>();
            var dp = new HashSet<List<int>>[target + 1];
            CombinationSumRec(candidates, target, ref dp);

            var lst = new List<IList<int>>();
            foreach (var s in dp[target])
                lst.Add(s);

            return lst;
        }

        private HashSet<List<int>> CombinationSumRec(int[] candidates, in int target, ref HashSet<List<int>>[] dp)
        {
            if (target == 0)
                return new HashSet<List<int>>(new ListEqualityComparer()) { new List<int>() };
            if (target < 0)
                return null;

            if (dp[target] != null)
                return dp[target];

            dp[target] = new HashSet<List<int>>();
            foreach (var candidate in candidates)
            {
                if (target - candidate >= 0)
                {
                    var paths = CombinationSumRec(candidates, target - candidate, ref dp);
                    if (paths != null)
                    {
                        foreach (var path in paths)
                        {
                            path.Add(candidate);
                            path.Sort();
                            dp[target].Add(new List<int>(path));
                        }
                    }
                }
                else break;
            }

            return dp[target];
        }

        public bool CanConvert(string str1, string str2)
        {
            if (str1 == str2) return true;
            var map = new Dictionary<char, char>();
            for (int i = 0; i < str1.Length; i++)
            {
                if (!map.ContainsKey(str1[i]))
                    map.Add(str1[i], str2[i]);

                if (map[str1[i]] != str2[i]) return false;
            }

            return map.Values.Distinct().Count() < 26;
        }

        public bool CanConvert1(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) && string.IsNullOrEmpty(str2))
                return true;
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2) || str1.Length != str2.Length)
                return false;
            var adjList = new Dictionary<char, HashSet<char>>();

            for (int i = 0; i < str1.Length; i++)
            {
                if (!adjList.ContainsKey(str1[i]))
                    adjList.Add(str1[i], new HashSet<char>());

                if (!adjList.ContainsKey(str2[i]))
                    adjList.Add(str2[i], new HashSet<char>());

                adjList[str1[i]].Add(str2[i]);
                if (adjList[str1[i]].Count > 1) return false;
            }


            foreach (var kv in adjList)
            {
                var visited = new bool[26];
                var st = new Stack<char>();
                st.Push(kv.Key);
                int cyclesCount = 0;
                while (st.Count > 0)
                {
                    var node = st.Pop();
                    visited[node - 'a'] = true;
                    foreach (var child in adjList[node])
                    {
                        if (visited[child - 'a'])
                        {
                            if (kv.Key == child)
                                cyclesCount++;
                            if (cyclesCount >= 2)
                                return false;
                        }
                        else st.Push(child);
                    }
                }
            }

            return true;
        }

        public class Master
        {
            public int guess(String word)
            {
                switch (word)
                {
                    case "acckzz":
                        return 6;
                    case "ccbazz":
                        return 3;
                    case "eiowzz":
                        return 2;
                    case "abcczz":
                        return 4;
                }

                return -1;
            }
        }

        public void FindSecretWord(String[] wordlist, Master master)
        {
            var adjList = new Dictionary<string, Dictionary<int, HashSet<string>>>();

            for (int i = 0; i < wordlist.Length; i++)
            {
                for (int j = 0; j < wordlist.Length; j++)
                {
                    if (i == j) continue;
                    MeasureDistance(adjList, wordlist[i], wordlist[j]);
                }
            }

            var visited = new HashSet<string>();
            var st = new Stack<string>();
            st.Push(wordlist[0]);

            var prevGuess = 0;
            while (st.Count > 0)
            {
                var node = st.Pop();
                visited.Add(node);
                var match = master.guess(node);
                if (match == 6) return;
                if (match <= prevGuess) continue;
                prevGuess = match;
                foreach (var childNode in adjList[node][match].OrderBy(w => adjList[w].Keys.Max()))
                {
                    adjList[childNode][match].Remove(node);
                    if (!visited.Contains(childNode))
                        st.Push(childNode);
                }
            }
        }

        private void MeasureDistance(Dictionary<string, Dictionary<int, HashSet<string>>> adjList, string word1, string word2)
        {
            int count = 0;
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] == word2[i])
                    count++;
            }

            if (!adjList.ContainsKey(word1))
                adjList.Add(word1, new Dictionary<int, HashSet<string>>());
            if (!adjList.ContainsKey(word2))
                adjList.Add(word2, new Dictionary<int, HashSet<string>>());

            if (!adjList[word1].ContainsKey(count))
                adjList[word1].Add(count, new HashSet<string>());
            if (!adjList[word2].ContainsKey(count))
                adjList[word2].Add(count, new HashSet<string>());

            adjList[word1][count].Add(word2);
            adjList[word2][count].Add(word1);
        }

        public class EulerPath
        {
            HashSet<String> seen;
            StringBuilder ans;

            public String crackSafe(int n, int k)
            {
                if (n == 1 && k == 1) return "0";
                seen = new HashSet<String>();
                ans = new StringBuilder();

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < n - 1; ++i)
                    sb.Append("0");
                String start = sb.ToString();

                dfs(start, k);
                ans.Append(start);
                return ans.ToString();
            }

            public void dfs(String node, int k)
            {
                for (int x = 0; x < k; ++x)
                {
                    String nei = node + x;
                    if (!seen.Contains(nei))
                    {
                        seen.Add(nei);
                        dfs(nei.Substring(1), k);
                        ans.Append(x);
                    }
                }
            }
        }

        public IList<IList<int>> PalindromePairs(string[] words)
        {
            var trie = new DicTrie();

            for (int i = 0; i < words.Length; i++)
            {
                trie.AddWord(words[i], i);
            }

            var ppairs = new List<IList<int>>();
            for (int j = 0; j < words.Length; j++)
            {
                var word = words[j];
                var root = trie.roots;
                if (word == string.Empty)
                {
                    foreach (var remainingPalindromeIndex in trie.remainingPalindromes)
                    {
                        ppairs.Add(new List<int> { j, remainingPalindromeIndex });
                        ppairs.Add(new List<int> { remainingPalindromeIndex, j });
                    }
                }
                var reverse = new String(word.Reverse().ToArray());
                for (int i = 0; i < reverse.Length; i++)
                {
                    var isAtLastIndex = i == reverse.Length - 1;
                    var ch = reverse[i];
                    if (root.TryGetValue(new DicTrie.TrieNode1(ch), out var foundNode))
                    {
                        if (foundNode.word != null)
                        {
                            if (j != foundNode.wordIndex)
                            {
                                if (isAtLastIndex)
                                {
                                    ppairs.Add(new List<int> { j, foundNode.wordIndex });
                                }

                                if (i + 1 < reverse.Length && trie.IsPalindrome(reverse, i + 1))
                                {
                                    ppairs.Add(new List<int> { foundNode.wordIndex, j });
                                }
                            }
                        }

                        if (isAtLastIndex)
                        {
                            foreach (var remainingPalindromeIndex in foundNode.remainingPalindromes)
                            {
                                if (j != remainingPalindromeIndex)
                                    ppairs.Add(new List<int> { j, remainingPalindromeIndex });
                            }
                        }
                        root = foundNode.children;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return ppairs;
        }

        public int MinPathSum(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;
            int m = grid.Length, n = grid[0].Length;
            var memo = new int?[m + 1, n + 1];
            return MinPathSumRec(grid, 0, 0, memo);
        }

        private int MinPathSumRec(int[][] grid, int x, int y, int?[,] memo)
        {
            if (x >= grid.Length || y >= grid[x].Length) return int.MaxValue;
            if (x == grid.Length - 1 && y == grid[x].Length - 1) return grid[x][y];

            if (memo[x, y].HasValue) return memo[x, y].Value;

            memo[x, y] = grid[x][y] + Math.Min(MinPathSumRec(grid, x + 1, y, memo), MinPathSumRec(grid, x, y + 1, memo));
            return memo[x, y].Value;
        }

        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0].Length == 0)
                return 0;
            int m = obstacleGrid.Length, n = obstacleGrid[0].Length;
            var memo = new int?[m + 1, n + 1];
            return UniquePathsWithObstaclesRec(obstacleGrid, 0, 0, memo);
        }

        private int UniquePathsWithObstaclesRec(int[][] obstacleGrid, in int x, in int y, int?[,] memo)
        {
            if (x >= obstacleGrid.Length || y >= obstacleGrid[x].Length) return 0;
            if (obstacleGrid[x][y] == 1) return 0;
            if (x == obstacleGrid.Length - 1 && y == obstacleGrid[x].Length - 1) return 1;

            if (memo[x, y].HasValue) return memo[x, y].Value;

            memo[x, y] = UniquePathsWithObstaclesRec(obstacleGrid, x + 1, y, memo) + UniquePathsWithObstaclesRec(obstacleGrid, x, y + 1, memo);
            return memo[x, y].Value;
        }

        public int UniquePaths(int m, int n)
        {
            var memo = new int?[m + 1, n + 1];
            return UniquePathsRec(m, n, memo);
        }

        private int UniquePathsRec(in int m, in int n, int?[,] memo)
        {
            if (m == 0 || n == 0) return 0;
            if (m == 1 && n == 1) return 1;

            if (memo[m, n].HasValue) return memo[m, n].Value;

            memo[m, n] = UniquePathsRec(m - 1, n, memo) + UniquePathsRec(m, n - 1, memo);
            return memo[m, n].Value;
        }

        public class ACSTrie
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

            class SentenceFrequencyEqualityComparer : IEqualityComparer<SentenceFrequency>
            {
                public bool Equals(SentenceFrequency x, SentenceFrequency y)
                {
                    return x.sentence.Equals(y.sentence);
                }

                public int GetHashCode(SentenceFrequency obj)
                {
                    return obj.sentence.GetHashCode();
                }
            }

            public class SentenceFrequency
            {
                public string sentence;
                public int frequency;
            }

            public class TrieNode1
            {
                public TrieNode1(char ch, string word = null)
                {
                    this.ch = ch;
                    this.word = word;
                    children = new HashSet<TrieNode1>(new TrieNode1EqualityComparer());
                    sentences = new SortedSet<SentenceFrequency>(Comparer<SentenceFrequency>.Create((s1, s2) =>
                    {
                        if (s1.frequency == s2.frequency) return s1.sentence.CompareTo(s2.sentence);
                        return s2.frequency - s1.frequency;
                    }));
                }

                public char ch;
                public string word;

                public SortedSet<SentenceFrequency> sentences;
                public HashSet<TrieNode1> children;

                public override string ToString()
                {
                    return this.ch.ToString();
                }
            }

            public HashSet<TrieNode1> roots;

            /** Initialize your data structure here. */
            public ACSTrie()
            {
                roots = new HashSet<TrieNode1>(new TrieNode1EqualityComparer());
            }

            /** Inserts a word into the trie. */
            public void AddWord(string word, int freq)
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
                        AddSentence(word, freq, foundTrie);
                        root = foundTrie.children;
                    }
                    else
                    {
                        AddSentence(word, freq, trieNode);
                        root.Add(trieNode);
                        root = trieNode.children;
                    }
                }
            }

            private static void AddSentence(string word, int freq, TrieNode1 trieNode)
            {
                var sentence = new SentenceFrequency { sentence = word, frequency = freq - 1 };
                //if (trieNode.sentences.Contains(sentence, new SentenceFrequencyEqualityComparer()))
                trieNode.sentences.Remove(sentence);
                sentence.frequency++;
                trieNode.sentences.Remove(sentence);
                trieNode.sentences.Add(sentence);
            }

            /** Returns if the word is in the trie. */
            public List<SentenceFrequency> Search(string word)
            {
                return Search(word, 0, roots);
            }

            public List<SentenceFrequency> Search(string word, int start, HashSet<TrieNode1> root)
            {
                if (root == null) return new List<SentenceFrequency>();

                for (int i = start; i < word.Length; i++)
                {
                    var ch = word[i];
                    var trieNode = new TrieNode1(ch);
                    if (root.TryGetValue(trieNode, out var foundTrie))
                    {
                        if (i == word.Length - 1)
                            return foundTrie.sentences.Take(3).ToList();
                        root = foundTrie.children;
                    }
                    else
                    {
                        return new List<SentenceFrequency>();
                    }
                }

                return new List<SentenceFrequency>();
            }

        }

        public class AutocompleteSystem
        {
            ACSTrie trie = new ACSTrie();
            private List<char> stream = new List<char>();

            public AutocompleteSystem(string[] sentences, int[] times)
            {
                for (int i = 0; i < sentences.Length; i++)
                {
                    trie.AddWord(sentences[i], times[i]);
                }
            }

            public IList<string> Input(char c)
            {
                if (c == '#')
                {
                    var sentence = new string(stream.ToArray());
                    var prevFrequency = trie.Search(sentence).FirstOrDefault();
                    trie.AddWord(sentence, (prevFrequency?.frequency ?? 0) + 1);
                    stream = new List<char>();
                    return new List<string>();
                }
                else
                {
                    stream.Add(c);
                    var sentence = new string(stream.ToArray());
                    return trie.Search(sentence).Select(s => s.sentence).ToList();
                }
            }
        }

        public class StreamChecker
        {
            DicTrie trie = new DicTrie();
            List<char> stream = new List<char>();

            public StreamChecker(string[] words)
            {
                foreach (var word in words)
                {
                    trie.AddWord(new string(word.Reverse().ToArray()));
                }
            }

            public bool Query(char letter)
            {
                stream.Add(letter);
                var root = trie.roots;
                for (int i = stream.Count - 1; i >= 0; i--)
                {
                    if (root.TryGetValue(new DicTrie.TrieNode1(stream[i]), out var node))
                    {
                        if (node.word != null)
                            return true;
                        root = node.children;
                    }
                    else return false;
                }

                return false;
            }
        }

        class ConcatenatedWordsTrie
        {
            private static Node root;

            public List<String> findAllConcatenatedWordsInADict(String[] words)
            {
                if (words == null || words.Length == 0)
                    return new List<string>();

                root = new Node();
                buildTrie(words);

                var result = new List<string>();
                foreach (var word in words)
                {
                    if (isConcatenated(word, 0, 0))
                        result.Add(word);
                }
                return result;
            }

            // Return true if word starting from index is concatenated
            bool isConcatenated(String word, int index, int countConcatenatedWords)
            {
                if (index == word.Length)
                    return countConcatenatedWords >= 2;

                Node ptr = root;
                for (int i = index; i < word.Length; i++)
                {
                    if (ptr.children[word[i] - 'a'] == null)
                        return false;
                    ptr = ptr.children[word[i] - 'a'];

                    if (ptr.isWordEnd)
                        if (isConcatenated(word, i + 1, countConcatenatedWords + 1))
                            return true;
                }

                return false;
            }

            private void buildTrie(String[] words)
            {
                Node ptr;
                foreach (var word in words)
                {
                    ptr = root;
                    foreach (char ch in word.ToCharArray())
                    {
                        int order = ch - 'a';
                        if (ptr.children[order] == null)
                        {
                            ptr.children[order] = new Node();
                        }
                        ptr = ptr.children[order];
                    }
                    ptr.isWordEnd = true;
                }
            }

            class Node
            {
                public Node[] children;
                public bool isWordEnd;

                public Node()
                {
                    children = new Node[26];
                    isWordEnd = false;
                }
            }
        }

        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            if (words == null || words.Length <= 1) return new List<string>();
            Array.Sort(words, (s1, s2) => s1.Length - s2.Length);

            var hs = new HashSet<string>();
            var lst = new List<string>();
            foreach (var word in words)
            {
                if (WordBreak1(word, hs))
                    lst.Add(word);
                hs.Add(word);
            }

            return lst;
        }

        public bool WordBreak1(string s, HashSet<string> wordDict)
        {
            if (wordDict.Count == 0) return false;
            var dp = new bool?[s.Length];
            return WordBreakRec(s, 0, wordDict, ref dp);
        }

        private bool WordBreakRec(string s, int start, HashSet<string> words, ref bool?[] dp)
        {
            if (start == s.Length) return true;

            if (dp[start].HasValue) return dp[start].Value;

            var sb = new StringBuilder();
            for (int end = start; end < s.Length; end++)
            {
                sb.Append(s[end]);
                if (words.Contains(sb.ToString()) && WordBreakRec(s, end + 1, words, ref dp))
                {
                    dp[start] = true;
                    return dp[start].Value;
                }
            }

            dp[start] = false;
            return dp[start].Value;
        }

        public class DicTrie
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
                    remainingPalindromes = new List<int>();
                }

                public char ch;
                public string word;

                public HashSet<TrieNode1> children;
                public List<int> remainingPalindromes;
                public int wordIndex = -1;

                public override string ToString()
                {
                    return this.ch.ToString();
                }
            }

            public HashSet<TrieNode1> roots;
            public List<int> remainingPalindromes;


            /** Initialize your data structure here. */
            public DicTrie()
            {
                roots = new HashSet<TrieNode1>(new TrieNode1EqualityComparer());
                remainingPalindromes = new List<int>();
            }

            public bool IsPalindrome(string word, in int i)
            {
                if (i >= word.Length) return false;
                int low = i, high = word.Length - 1;
                while (low < high)
                {
                    if (word[low++] != word[high--]) return false;
                }
                return true;
            }

            /** Inserts a word into the trie. */
            public void AddWord(string word, int wordIndex = -1)
            {
                var root = roots;
                if (IsPalindrome(word, 0))
                    this.remainingPalindromes.Add(wordIndex);

                for (int i = 0; i < word.Length; i++)
                {
                    var trieNode = new TrieNode1(word[i]);
                    if (i == word.Length - 1)
                    {
                        trieNode.word = word;
                        trieNode.wordIndex = wordIndex;
                    }

                    var isRemainingPalindrome = IsPalindrome(word, i + 1);
                    if (root.TryGetValue(trieNode, out var foundTrie))
                    {
                        if (trieNode.word != null && foundTrie.word == null) foundTrie.word = trieNode.word;
                        if (isRemainingPalindrome)
                            foundTrie.remainingPalindromes.Add(wordIndex);
                        root = foundTrie.children;
                    }
                    else
                    {
                        if (isRemainingPalindrome)
                            trieNode.remainingPalindromes.Add(wordIndex);
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
                            if (i == word.Length - 1 && root.Any(child => child.word != null)) return true;
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

            public bool CanBeConstructured(string word, bool skipExists = true)
            {
                var possibleParts = new List<int>();
                var r = this.roots;
                // Find possible words/cuts
                for (int i = 0; i < word.Length; i++)
                {
                    var ch = word[i];
                    if (r.TryGetValue(new TrieNode1(ch), out var n))
                    {
                        if (n.word != null)
                            possibleParts.Add(n.word.Length);
                        r = n.children;
                    }
                    else
                    {
                        //possibleParts.Add(word.Substring(i));
                        break;
                    }
                }

                foreach (var possiblePart in possibleParts)
                {
                    if (possiblePart == word.Length)
                    {
                        if (skipExists)
                            continue;
                        return true;
                    }
                    if (CanBeConstructured(word.Substring(possiblePart), false))
                        return true;
                }

                return false;
            }
        }

        public IList<string> FindAllConcatenatedWordsInADict1(string[] words)
        {
            if (words == null || words.Length <= 1) return new List<string>();
            var trie = new DicTrie();
            foreach (var word in words)
            {
                trie.AddWord(word);
            }

            var lst = new List<string>();
            foreach (var rootNode in trie.roots)
            {
                DFSTrie(rootNode, trie, 0, ref lst);
            }

            return lst;
        }

        private void DFSTrie(DicTrie.TrieNode1 node, DicTrie trie, int wordsCount, ref List<string> lst)
        {
            if (node.word != null)
            {
                wordsCount++;
                if (wordsCount > 1)
                {
                    if (trie.CanBeConstructured(node.word))
                        lst.Add(node.word);
                }
            }

            foreach (var child in node.children)
            {
                DFSTrie(child, trie, wordsCount, ref lst);
            }
        }

        public class Codec
        {
            public class Node
            {
                public int val;
                public IList<Node> children = new List<Node>();

                public Node() { }

                public Node(int _val)
                {
                    val = _val;
                }

                public Node(int _val, IList<Node> _children)
                {
                    val = _val;
                    children = _children;
                }

                public override string ToString()
                {
                    return val.ToString();
                }
            }

            // Encodes an n-ary tree to a binary tree.
            public TreeNode encode(Node root)
            {
                if (root == null) return null;

                var q = new Queue<Node>();
                q.Enqueue(root);

                var dic = new Dictionary<Node, TreeNode>();
                while (q.Count > 0)
                {
                    var parent = q.Dequeue();
                    if (!dic.ContainsKey(parent))
                        dic.Add(parent, new TreeNode(parent.val));
                    var newParent = dic[parent];

                    if (parent.children != null)
                    {
                        TreeNode prevSibling = null;
                        for (int i = 0; i < parent.children.Count; i++)
                        {
                            var child = parent.children[i];
                            var newChild = new TreeNode(child.val);
                            if (i == 0)
                            {
                                newParent.left = newChild;
                            }

                            if (prevSibling != null)
                            {
                                prevSibling.right = newChild;
                            }

                            prevSibling = newChild;
                            q.Enqueue(child);
                            dic.Add(child, newChild);
                        }
                    }
                }

                return dic[root];
            }

            // Decodes your binary tree to an n-ary tree.
            public Node decode(TreeNode root)
            {
                if (root == null) return null;
                var q = new Queue<TreeNode>();
                q.Enqueue(root);

                var nq = new Queue<Node>();
                nq.Enqueue(null);
                Node newTreeNode = null;
                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    var prevNode = nq.Dequeue();
                    var newNode = new Node(node.val, new List<Node>());
                    if (newTreeNode == null)
                        newTreeNode = newNode;

                    prevNode?.children.Add(newNode);

                    var child = node.left;
                    while (child != null)
                    {
                        q.Enqueue(child);
                        nq.Enqueue(newNode);
                        //newNode.children.Add(child);
                        child = child.right;
                    }
                    //if(node.left != null) q.Enqueue(null);
                    //nq.Enqueue(newNode);
                }

                return newTreeNode;
            }
        }


        public class Codec5
        {
            public class Node
            {
                public int val;
                public IList<Node> children = new List<Node>();

                public Node() { }

                public Node(int _val)
                {
                    val = _val;
                }

                public Node(int _val, IList<Node> _children)
                {
                    val = _val;
                    children = _children;
                }

                public override string ToString()
                {
                    return val.ToString();
                }
            }

            // Encodes a tree to a single string.
            public string serialize(Node root)
            {
                if (root == null) return string.Empty;
                var sb = new StringBuilder();
                var q = new Queue<Node>();
                q.Enqueue(root);
                q.Enqueue(null);

                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    sb.Append((node == null ? "!" : node.val.ToString()) + ",");

                    if (node == null)
                    {
                        continue;
                    }

                    foreach (var child in node.children)
                    {
                        q.Enqueue(child);
                    }
                    q.Enqueue(null);
                }

                return sb.ToString();
            }

            // Decodes your encoded data to tree.
            public Node deserialize(string data)
            {
                if (string.IsNullOrEmpty(data)) return null;
                var values = data.Split(',', StringSplitOptions.RemoveEmptyEntries);

                int i = 0;
                var root = new Node(int.Parse(values[i++]), new List<Node>());

                i++; // skip first null

                var q = new Queue<Node>();
                q.Enqueue(root);

                while (q.Count > 0)
                {
                    var parent = q.Dequeue();

                    while (i < values.Length)
                    {
                        var val = values[i];
                        i++;
                        if (val == "!")
                            break;
                        var child = new Node(int.Parse(val), new List<Node>());
                        parent.children.Add(child);
                        q.Enqueue(child);
                    }
                }

                return root;
            }
        }


        public double minmaxGasDist1(int[] stations, int K)
        {
            double lo = 0, hi = 1e8;
            while (hi - lo > 1e-6)
            {
                double mi = (lo + hi) / 2.0;
                if (possible(mi, stations, K))
                    hi = mi;
                else
                    lo = mi;
            }
            return lo;
        }

        public bool possible(double D, int[] stations, int K)
        {
            int used = 0;
            for (int i = 0; i < stations.Length - 1; ++i)
                used += (int)((stations[i + 1] - stations[i]) / D);
            return used <= K;
        }

        public double MinmaxGasDist(int[] stations, int K)
        {
            int maxDistance = int.MinValue;

            for (int i = 0; i < stations.Length - 1; i++)
            {
                var diff = stations[i + 1] - stations[i];
                if (diff > maxDistance)
                {
                    maxDistance = diff;
                }
            }

            double low = 0, high = maxDistance + 1;
            double margin = 1e-6;
            while (high - low > margin)
            {
                var midDistance = (high + low) / 2.0;
                int usedStations = 0;
                for (int i = 0; i < stations.Length - 1; i++)
                {
                    var diff = stations[i + 1] - stations[i];

                    usedStations += (int)(Math.Ceiling(diff / midDistance)) - 1;
                    //usedStations += (int)(diff / midDistance);
                }

                if (usedStations <= K)
                {
                    high = midDistance;
                }
                else
                {
                    low = midDistance;
                }
            }

            return low;
        }

        public string NextClosestTime(string time)
        {
            int maxMinutes = 24 * 60;

            var components = new int[4];
            int j = 0;
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] == ':')
                    continue;
                components[j++] = time[i] - '0';
            }

            var timeInMinutes = int.Parse(time.Substring(0, time.IndexOf(':'))) * 60;
            timeInMinutes += int.Parse(time.Substring(time.IndexOf(':') + 1));

            int closestMinutes = maxMinutes;
            string closest = time;
            foreach (var h1 in components)
            {
                foreach (var h2 in components)
                {
                    int hours = h1 * 10 + h2;
                    if (hours < 24)
                    {
                        foreach (var m1 in components)
                        {
                            foreach (var m2 in components)
                            {
                                int mins = m1 * 10 + m2;
                                if (mins < 60)
                                {
                                    int diff = ((hours * 60 + mins) - timeInMinutes + maxMinutes) % maxMinutes;
                                    if (diff != 0 && diff < closestMinutes)
                                    {
                                        closestMinutes = diff;
                                        closest = $"{h1}{h2}:{m1}{m2}";
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return closest;
        }

        public int SmallestDivisor(int[] nums, int threshold)
        {
            if (nums == null || nums.Length == 0) return 1;
            int low = 1, high = nums.Max();
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                var sumDivision = 0;
                foreach (var num in nums)
                {
                    sumDivision += (int)Math.Ceiling(num / (double)mid);
                }

                if (sumDivision <= threshold)
                {
                    high = mid - 1;
                }
                else low = mid + 1;
            }

            return high + 1;
        }

        public class WorkerWage
        {
            public int quality;
            public int wage;
            public double percentage => wage / (double)quality;
        }

        public double MincostToHireWorkers(int[] quality, int[] wage, int K)
        {
            if (quality == null || quality.Length == 0) return 0;
            var workers = new WorkerWage[quality.Length];
            for (int i = 0; i < quality.Length; i++)
                workers[i] = new WorkerWage { wage = wage[i], quality = quality[i] };
            Array.Sort(workers, (ww1, ww2) =>
            {
                var diff = ww1.percentage - ww2.percentage;
                if (diff > 0) return 1;
                else if (diff < 0) return -1;
                return 0;
            });

            int maxWorkers = Math.Min(K, quality.Length);

            double selectedPercentage = 0, paySum = 0;
            for (int i = maxWorkers - 1; i >= 0; i--)
            {
                if (i == maxWorkers - 1)
                {
                    selectedPercentage = workers[i].percentage;
                }

                paySum += selectedPercentage * workers[i].quality;
            }

            return paySum;
        }

        public class StringCompressionII
        {
            int[][] dp;
            public int getLengthOfOptimalCompression(String ss, int k)
            {
                char[] s = ss.ToCharArray();

                dp = new int[s.Length][];
                for (int i = 0; i < s.Length; i++)
                {
                    dp[i] = new int[k + 1];
                    Array.Fill(dp[i], -1);
                }

                int res = dfs(s, 0, k);
                // for(int[] row : dp) System.out.println(Arrays.toString(row));
                return res;
            }

            private int dfs(char[] s, int curIdx, int rest)
            {
                // reach end or we can simply delete all
                if (curIdx == s.Length || s.Length - curIdx <= rest) return 0;

                if (dp[curIdx][rest] != -1) return dp[curIdx][rest];

                int[] freq = new int[26];
                int most = 0, res = int.MaxValue; // most is the highest frequency

                // i - curIdx + 1 - most. count of chars we need to delete
                // but we cannot break. Because when most change, rest could also change.
                // So we must iterate to end
                for (int i = curIdx; i < s.Length; i++)
                {
                    int currentChar = s[i] - 'a';
                    freq[currentChar]++;
                    most = Math.Max(most, freq[currentChar]);
                    int nonFrequentCharsCount = (i - curIdx + 1 - most);
                    if (rest >= nonFrequentCharsCount) // only recurse when we can delete all other chars
                        res = Math.Min(res, getLen(most) + 1 + dfs(s, i + 1, rest - nonFrequentCharsCount));
                }
                dp[curIdx][rest] = res;
                return res;
            }

            private int getLen(int most)
            {
                if (most == 1) return 0;
                if (most < 10) return 1;
                if (most < 99) return 2;
                return 3;
            }
        }

        private int calcLen(int len)
        {
            if (len == 0) return 0;
            else if (len == 1) return 1;
            else if (len < 10) return 2;
            else if (len < 100) return 3;
            else return 4;
        }

        public int getLengthOfOptimalCompression(String s, int k)
        {
            int n = s.Length;
            int[][] dp = new int[n + 1][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[k + 1];
                if (i > 0)
                    Array.Fill(dp[i], int.MaxValue);
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    if (j > 0) dp[i][j] = dp[i - 1][j - 1];
                    int removed = 0, cnt = 0, p;
                    for (p = i; p > 0; p--)
                    {
                        if (s[p - 1] == s[i - 1]) cnt++;
                        else if (++removed > j) break;
                        dp[i][j] = Math.Min(dp[i][j], dp[p - 1][j - removed] + calcLen(cnt));
                    }
                }
            }
            return dp[n][k];
        }

        //public class RLEItem
        //{
        //    public char ch;
        //    public int count;
        //    public int strLength => count <= 1 ? 1 : (1 + count.ToString().Length);
        //}

        //public int GetLengthOfOptimalCompression(string s, int k)
        //{
        //    var lst = new List<RLEItem>();
        //    int count = 1;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (i == s.Length - 1 || s[i] != s[i + 1])
        //        {
        //            lst.Add(new RLEItem{ch = s[i], count = count});
        //            count = 0;
        //        }

        //        count++;
        //    }

        //    int minLength = s.Length;
        //    return GetLengthOfOptimalCompressionRec(lst, prev: -1, curr: 0, totalLength: 0, k, ref minLength);
        //}

        //private void GetLengthOfOptimalCompressionRec(List<RLEItem> lst, int prev, int curr, int totalLength, in int k, ref int minLength)
        //{
        //    if (k == 0 || curr == lst.Count)
        //    {
        //        for (int i = curr; i < lst.Count; i++)
        //            totalLength += lst[i].strLength;
        //        minLength = Math.Min(minLength, totalLength);
        //        return;
        //    }

        //    var currentItem = lst[curr];

        //    if(currentItem.strLength )
        //}

        public class Codec1
        {

            // Encodes a list of strings to a single string.
            public string encode(IList<string> strs)
            {
                if (strs == null || strs.Count == 0)
                    return string.Empty;

                var sb = new StringBuilder();
                foreach (var str in strs)
                {
                    var encodedStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
                    sb.Append(encodedStr.Length + "=");
                    sb.Append(encodedStr);
                }

                return sb.ToString();
            }

            // Decodes a single string to a list of strings.
            public IList<string> decode(string s)
            {
                var lst = new List<string>();

                if (string.IsNullOrEmpty(s))
                    return lst;

                int i = 0;
                while (i < s.Length)
                {
                    int count = 0;
                    while (s[i] != '=')
                    {
                        count = count * 10 + (s[i] - '0');
                        i++;
                    }

                    i++;

                    var decodedStr = Convert.FromBase64String(s.Substring(i, count));

                    lst.Add(Encoding.UTF8.GetString(decodedStr));

                    i += count;
                }

                return lst;
            }
        }


        public int[] DecompressRLElist(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
                return new int[0];
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i += 2)
            {
                if (i == nums.Length - 1) break;
                for (int j = 0; j < nums[i]; j++)
                {
                    list.Add(nums[i + 1]);
                }
            }
            return list.ToArray();
        }

        public int Compress(char[] chars)
        {
            if (chars == null || chars.Length == 0)
                return 0;

            int writeIndex = -1, count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == chars.Length - 1 || chars[i + 1] != chars[i])
                {
                    chars[++writeIndex] = chars[i];
                    if (count > 1)
                    {
                        foreach (var ch in count.ToString())
                            chars[++writeIndex] = ch;
                    }
                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            return writeIndex + 1;
        }

        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            if (arr == null || arr.Length == 0 || k == 0)
                return 0;

            if (k == 1)
                return arr.Sum();

            var dp = new int?[arr.Length];
            return MaxSumAfterPartitioningRec(arr, k, 0, ref dp);
        }

        private int MaxSumAfterPartitioningRec(int[] arr, in int k, int i, ref int?[] dp)
        {
            if (i == arr.Length)
                return 0;

            if (dp[i].HasValue)
                return dp[i].Value;

            int maxInK = 0, localMax = 0;
            for (int j = i; j < Math.Min(i + k, arr.Length); j++)
            {
                maxInK = Math.Max(maxInK, arr[j]);
                var option = maxInK * (j - i + 1) + MaxSumAfterPartitioningRec(arr, k, j + 1, ref dp);
                localMax = Math.Max(localMax, option);
            }

            dp[i] = localMax;
            return localMax;
        }

        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k <= 0) return false;
            var sum = nums.Sum();
            if (sum % k != 0) return false;
            var subSetMax = sum / k;
            if (nums.Any(n => n > subSetMax))
                return false;

            var visited = new bool[nums.Length];
            return CanPartitionKSubsetsRec(nums, 0, 0, subSetMax, k, ref visited);
        }

        private bool CanPartitionKSubsetsRec(int[] nums, int i, int subSetSum, in int subSetMax, in int k,
            ref bool[] visited)
        {
            if (k == 0)
                return true;

            if (i == nums.Length)
                return false;

            if (subSetSum == subSetMax)
            {
                return CanPartitionKSubsetsRec(nums, 0, 0, subSetMax, k - 1, ref visited);
            }

            for (int j = i; j < nums.Length; j++)
            {
                if (!visited[j] && subSetSum + nums[j] <= subSetMax)
                {
                    visited[j] = true;

                    if (CanPartitionKSubsetsRec(nums, j + 1, subSetSum + nums[j], subSetMax, k, ref visited))
                        return true;

                    visited[j] = false;
                }
            }

            return false;
        }


        public bool CanPartitionKSubsets3(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k <= 0) return false;
            var sum = nums.Sum();
            if (sum % k != 0) return false;
            var subSetMax = sum / k;

            Array.Sort(nums);
            int low = 0, high = nums.Length - 1;
            if (nums[nums.Length - 1] > subSetMax)
                return false;

            while (low <= high)
            {
                if (nums[high] == subSetMax)
                {
                    high--;
                    k--;
                }
                else
                {
                    var leftRightSum = nums[high] + nums[low];
                    if (leftRightSum == subSetMax)
                    {
                        high--;
                        low++;
                        k--;
                    }
                    else if (leftRightSum < subSetMax)
                    {
                        low++;
                    }
                    else return false;
                }
                if (k < 0)
                    return false;
            }

            return k == 0;
        }


        public bool CanPartition(int[] nums)
        {
            if (nums == null || nums.Length == 0) return false;
            var sum = nums.Sum();
            if (sum % 2 == 1) return false;
            var target = sum / 2;

            if (nums.Any(n => n == target)) return true;

            var dp = new bool?[nums.Length, target + 1];
            return CanPartitionDP(nums, 0, target, ref dp);
        }

        private bool CanPartitionDP(int[] nums, int i, in int target, ref bool?[,] dp)
        {
            if (target == 0)
                return true;
            if (target < 0 || i == nums.Length)
                return false;

            if (dp[i, target].HasValue) return dp[i, target].Value;

            dp[i, target] = CanPartitionDP(nums, i + 1, target - nums[i], ref dp)
                            || CanPartitionDP(nums, i + 1, target, ref dp);
            return dp[i, target].Value;
        }

        //public int MaxHeight(int[][] cuboids)
        //{
        //    Array.Sort(cuboids, (a, b) => a[0] * a[1] - b[0] * b[1]);

        //    return MaxHeightRec(cuboids, 0, )
        //}

        public int MinPartitions(string n)
        {
            if (string.IsNullOrEmpty(n)) return 0;
            int count = 0;
            var sb = new StringBuilder(n.Length);
            while (!string.IsNullOrEmpty(n))
            {
                foreach (var ch in n)
                {
                    sb.Append(ch == '0' ? 0 : 1);
                }

                var next = sb.ToString();
                sb.Clear();
                for (int i = 0; i < n.Length; i++)
                    sb.Append(n[i] - next[i]);
                count++;
                n = sb.ToString().TrimStart('0');
                sb.Clear();
            }

            return count;
        }

        public int NumberOfMatches(int n)
        {
            if (n <= 0)
                return 0;
            int matches = 0;

            while (n != 1)
            {
                matches += n / 2;
                n = (int)Math.Ceiling(n / 2.0);
            }

            return matches;
        }

        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int surplus = 0, deficit = 0, start = -1;

            for (int i = 0; i < gas.Length; i++)
            {
                surplus += gas[i] - cost[i];
                if (surplus < 0)
                {
                    deficit += surplus;
                    surplus = 0;
                    start = i + 1;
                }
            }

            return surplus + deficit >= 0 ? start : -1;
        }

        public class HtmlParser
        {
            public List<String> GetUrls(String url)
            {
                return new List<string>
                {
                    "http://news.yahoo.com",
                    "http://news.yahoo.com/news",
                    "http://news.yahoo.com/news/topics/",
                    "http://news.google.com",
                    "http://news.yahoo.com/us"
                };
            }
        }

        private HtmlParser htmlParser;
        HashSet<string> visited = new HashSet<string>();

        public void CrawlPage(string url)
        {
            int httpPrefixEnd = 7;
            var neighbors = this.htmlParser.GetUrls(url);
            var urlDomain = GetUrlDomain(url, httpPrefixEnd);
            var tasks = new List<Task>();
            foreach (var neighbor in neighbors)
            {
                if (urlDomain == GetUrlDomain(neighbor, httpPrefixEnd))
                {
                    if (!this.visited.Contains(neighbor))
                    {
                        lock (this)
                        {
                            if (!this.visited.Contains(neighbor))
                                visited.Add(neighbor);
                        }
                        tasks.Add(Task.Factory.StartNew(() => CrawlPage(neighbor)));
                    }
                }
            }

            Task.WaitAll(tasks.ToArray());
        }

        public IList<string> Crawl(string startUrl, HtmlParser htmlParser)
        {
            this.htmlParser = htmlParser;
            this.visited.Add(startUrl);
            CrawlPage(startUrl);
            return this.visited.ToList();
        }

        public IList<string> Crawl_SingleThreaded(string startUrl, HtmlParser htmlParser)
        {
            var allLinks = new List<string>();
            var visited = new HashSet<string>();
            int httpPrefixEnd = 7;
            var q = new Queue<string>();
            q.Enqueue(startUrl);
            visited.Add(startUrl);
            while (q.Count > 0)
            {
                var nextUrl = q.Dequeue();
                allLinks.Add(nextUrl);
                var urlDomain = GetUrlDomain(nextUrl, httpPrefixEnd);
                var neighbors = htmlParser.GetUrls(nextUrl);
                foreach (var neighbor in neighbors)
                {
                    if (!visited.Contains(neighbor) && urlDomain == GetUrlDomain(neighbor, httpPrefixEnd))
                    {
                        q.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return allLinks;
        }

        private static string GetUrlDomain(string nextUrl, int httpPrefixEnd)
        {
            var slashIndex = nextUrl.IndexOf('/', httpPrefixEnd);
            if (slashIndex == -1) slashIndex = nextUrl.Length;
            return nextUrl.Substring(httpPrefixEnd, slashIndex - httpPrefixEnd);
        }

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
            var globalMaxProfit = currentJob.profit;
            //var startPoint = jobs.BinarySearch(i + 1, jobs.Count - i - 1, new JobInfo {start = currentJob.end},
            //    Comparer<JobInfo>.Create((a, b) => a.start - b.start));
            var startPoint = MinIndexBinarySearch(jobs, i + 1, currentJob.end);
            startPoint = startPoint < 0 ? ~startPoint : startPoint;
            for (int j = startPoint; j < jobs.Count; j++)
            {
                var maxProfit = currentJob.profit;
                var nextProfit = JobSchedulingRec(jobs, j, ref dp);
                // Can merge
                if (currentJob.end <= jobs[j].start)
                    maxProfit = currentJob.profit + nextProfit;
                // Can't merge, then either current job profit is higher or next jobs combined is higher
                maxProfit = Math.Max(maxProfit, nextProfit);
                globalMaxProfit = Math.Max(globalMaxProfit, maxProfit);
            }

            dp[i] = globalMaxProfit;
            return globalMaxProfit;
        }

        public int MinIndexBinarySearch(List<JobInfo> jobs, int startIndex, in int profit)
        {
            int low = startIndex, high = jobs.Count - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (jobs[mid].start < profit)
                {
                    low = mid + 1;
                }
                else
                {
                    high = high - 1;
                }
            }

            return low >= 0 ? low : ~low;
        }


        public int MinDifficulty(int[] jobDifficulty, int d)
        {
            var dp = new int?[jobDifficulty.Length, d + 1];
            var res = MinDifficultyDP(jobDifficulty, d, 0, ref dp);
            return res == int.MaxValue ? -1 : res;
        }

        private int MinDifficultyDP(int[] jobDifficulty, in int d, int i, ref int?[,] dp)
        {
            if (i == jobDifficulty.Length && d == 0) return 0;
            if (i >= jobDifficulty.Length || d < 0) return int.MaxValue;

            if (dp[i, d].HasValue)
                return dp[i, d].Value;

            int maxForCurrentCut = 0, minMaxToEnd = int.MaxValue;
            for (int j = i; j < jobDifficulty.Length; j++)
            {
                maxForCurrentCut = Math.Max(maxForCurrentCut, jobDifficulty[j]);
                var remResult = MinDifficultyDP(jobDifficulty, d - 1, j + 1, ref dp);
                if (remResult != int.MaxValue)
                    minMaxToEnd = Math.Min(minMaxToEnd, maxForCurrentCut + remResult);
            }

            dp[i, d] = minMaxToEnd;
            return minMaxToEnd;
        }

        public int MinDifficulty1(int[] jobDifficulty, int d)
        {
            int cutMax = 0, cutsCount = 1, sum = int.MaxValue;
            var dp = new int?[jobDifficulty.Length, d + 1];
            MinDifficultyRec1(jobDifficulty, d, 0, cutMax, cutsCount, 0, ref sum, ref dp);
            return sum;
        }

        private int MinDifficultyRec1(int[] jobDifficulty, in int d, int i, int cutMax, int cutsCount, int total,
            ref int sum, ref int?[,] dp)
        {
            if (i >= jobDifficulty.Length || d < cutsCount)
            {
                if (i >= jobDifficulty.Length && cutsCount == d)
                {
                    sum = Math.Min(total, sum);
                    return total;
                }
                return -1;
            }

            if (dp[i, cutsCount].HasValue)
                return dp[i, cutsCount].Value;

            var cutMaxInclude = Math.Max(cutMax, jobDifficulty[i]);
            var includeResult = MinDifficultyRec1(jobDifficulty, d, i + 1, cutMaxInclude, cutsCount, total - cutMax + cutMaxInclude, ref sum, ref dp);

            int excludeResult = -1;
            if (i != 0)
                excludeResult = MinDifficultyRec1(jobDifficulty, d, i + 1, jobDifficulty[i], cutsCount + 1, total + jobDifficulty[i], ref sum, ref dp);

            if (includeResult != -1 && excludeResult != -1)
                dp[i, cutsCount] = Math.Min(includeResult, excludeResult);
            dp[i, cutsCount] = includeResult != -1 ? includeResult : excludeResult;
            return dp[i, cutsCount].Value;
        }

        public int MinDifficulty3(int[] jobDifficulty, int d)
        {
            int cutMax = 0, cutsCount = 1;
            return MinDifficultyRec(jobDifficulty, d, 0, cutMax, cutsCount).max;
        }

        private (bool success, int max) MinDifficultyRec(int[] jobDifficulty, in int d, int i, int cutMax, int cutsCount)
        {
            if (i >= jobDifficulty.Length)
            {
                if (cutsCount == d)
                    return (true, cutMax);
                return (false, 0);
            }

            if (jobDifficulty.Length - i < d - cutsCount)
                return (false, 0);

            var cutMaxInclude = Math.Max(cutMax, jobDifficulty[i]);
            var includeResult = MinDifficultyRec(jobDifficulty, d, i + 1, cutMaxInclude, cutsCount);

            var excludeResult = (success: false, max: 0);
            if (i != 0)
            {
                excludeResult = MinDifficultyRec(jobDifficulty, d, i + 1, jobDifficulty[i], cutsCount + 1);
            }

            if (excludeResult.success && includeResult.success)
                return (true, Math.Min(includeResult.max, excludeResult.max));

            return (includeResult.success || excludeResult.success,
                includeResult.success ? includeResult.max : excludeResult.max);
        }

        public void Solve(char[][] board)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0) return;

            int rows = board.Length, cols = board[0].Length;
            var q = new Queue<(int i, int j)>();

            for (int j = 0; j < cols; j++)
                if (board[0][j] == 'O')
                    q.Enqueue((0, j));

            for (int j = 0; j < cols; j++)
                if (board[rows - 1][j] == 'O')
                    q.Enqueue((rows - 1, j));

            for (int i = 0; i < rows; i++)
                if (board[i][0] == 'O')
                    q.Enqueue((i, 0));

            for (int i = 0; i < rows; i++)
                if (board[i][cols - 1] == 'O')
                    q.Enqueue((i, cols - 1));

            foreach (var pair in q)
                DFSMarkVisited(board, pair.i, pair.j);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i][j] == 'O')
                        board[i][j] = 'X';
                    if (board[i][j] == 'Z')
                        board[i][j] = 'O';
                }
            }
        }

        private void DFSMarkVisited(char[][] board, int i, in int j)
        {
            if (!IsValidCell(board, i, j))
                return;
            board[i][j] = 'Z';
            DFSMarkVisited(board, i, j + 1);
            DFSMarkVisited(board, i, j - 1);
            DFSMarkVisited(board, i - 1, j);
            DFSMarkVisited(board, i + 1, j);
        }

        //private void DFSFlip(char[][] board, in int i, in int j, ref bool[,] visited)
        //{
        //    if (!IsValidCell(board, i, j, ref visited))
        //        return;

        //    visited[i, j] = true;

        //    board[i][j] = 'X';

        //    DFSFlip(board, i, j - 1, ref visited);
        //    DFSFlip(board, i, j + 1, ref visited);
        //    DFSFlip(board, i - 1, j, ref visited);
        //    DFSFlip(board, i + 1, j, ref visited);
        //}

        private static bool IsEdgeCell(char[][] board, int i, int j)
        {
            return (i == 0 || i == board.Length - 1) || (j == 0 || j == board[i].Length - 1);
        }

        private bool IsValidCell(char[][] board, in int i, in int j)
        {
            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length) return false;
            if (board[i][j] != 'O') return false;
            return true;
        }

        public int FindRadius(int[] houses, int[] heaters)
        {
            if (houses == null || houses.Length == 0 || heaters == null || heaters.Length == 0) return -1;
            Array.Sort(heaters);
            int globalMax = int.MinValue;
            foreach (var house in houses)
            {
                var houseIndexAmongHeaters = Array.BinarySearch(heaters, house);
                if (houseIndexAmongHeaters < 0) houseIndexAmongHeaters = ~houseIndexAmongHeaters;
                if (houseIndexAmongHeaters == heaters.Length) houseIndexAmongHeaters--;
                int left, right;
                int max = int.MinValue;
                if (heaters[houseIndexAmongHeaters] == house)
                {
                    left = houseIndexAmongHeaters > 0 ? houseIndexAmongHeaters - 1 : houseIndexAmongHeaters;
                    right = houseIndexAmongHeaters < heaters.Length - 1 ? houseIndexAmongHeaters + 1 : houseIndexAmongHeaters;
                }
                else
                {
                    left = houseIndexAmongHeaters > 0 ? houseIndexAmongHeaters - 1 : houseIndexAmongHeaters;
                    right = houseIndexAmongHeaters;
                }
                max = Math.Min(Math.Abs(heaters[left] - house), Math.Abs(heaters[right] - house));
                globalMax = Math.Max(globalMax, max);
            }

            return globalMax;
        }

        public int FindRadius1(int[] houses, int[] heaters)
        {
            if (houses == null || houses.Length == 0 || heaters == null || heaters.Length == 0) return -1;
            Array.Sort(houses);
            Array.Sort(heaters);
            int[] dist = new int[houses.Length];
            Array.Fill(dist, int.MaxValue);
            for (int i = 0; i < heaters.Length; i++)
            {
                var heater = heaters[i];
                int heaterPos = Array.BinarySearch(houses, heater);
                if (heaterPos < 0) heaterPos = ~heaterPos;
                if (heaterPos == houses.Length) heaterPos--;
                int left = heaterPos, right = heaterPos + 1;
                while (left >= 0)
                {
                    if (dist[left] > Math.Abs(heater - houses[left]))
                        dist[left] = Math.Abs(heater - houses[left]);
                    else break;
                    left--;
                }

                int rightLimit = houses[houses.Length - 1];
                if (i < heaters.Length - 1)
                {
                    rightLimit = (heaters[i + 1] - heater) / 2 + heater;
                }
                while (right < houses.Length && houses[right] <= rightLimit)
                {
                    if (dist[right] > Math.Abs(heater - houses[right]))
                        dist[right] = Math.Abs(heater - houses[right]);
                    else break;
                    right++;
                }
            }

            return dist.Max();
        }

        public int MaximizeSweetness(int[] sweetness, int K)
        {
            if (sweetness == null || sweetness.Length < K) return 0;
            if (K == 0) return sweetness.Sum();
            int min = int.MaxValue, max = 0;

            foreach (var i in sweetness)
            {
                if (min > i) min = i;
                max += i;
            }

            int maxMinCut = int.MinValue;
            while (min <= max)
            {
                int sweetnessCut = min + (max - min) / 2;

                int cutsCount = 0, sweetnesSoFar = 0, minCutSweetness = int.MaxValue;
                for (int i = 0; i < sweetness.Length; i++)
                {
                    sweetnesSoFar += sweetness[i];
                    if (sweetnesSoFar >= sweetnessCut)
                    {
                        cutsCount++;
                        minCutSweetness = Math.Min(minCutSweetness, sweetnesSoFar);
                        sweetnesSoFar = 0;
                        if (cutsCount > K + 1)
                            break;
                    }
                }

                if (cutsCount < K + 1)
                {
                    max = sweetnessCut - 1;
                }
                else
                {
                    maxMinCut = Math.Max(maxMinCut, minCutSweetness);
                    min = sweetnessCut + 1;
                }
            }

            return maxMinCut;
        }

        public class TopVotedCandidate
        {
            private int[] times;
            private int[] persons;

            public TopVotedCandidate(int[] persons, int[] times)
            {
                this.times = times;

                int maxKey = -1;
                this.persons = new int[persons.Length];
                var dic = new Dictionary<int, int>();
                for (int i = 0; i < persons.Length; i++)
                {
                    if (!dic.ContainsKey(persons[i]))
                        dic.Add(persons[i], 0);

                    dic[persons[i]]++;
                    if (maxKey == -1 || dic[persons[maxKey]] <= dic[persons[i]])
                        maxKey = i;

                    this.persons[i] = persons[maxKey];
                }
            }

            public int Q(int t)
            {
                if (this.times.Length == 0 || this.persons.Length == 0) return -1;
                var idx = Array.BinarySearch(times, t);

                if (idx >= 0)
                    return this.persons[idx];
                idx = ~idx;
                return idx == 0 ? -1 : this.persons[idx - 1];
            }
        }

        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            if (arr == null || arr.Length == 0 || k <= 0) return new List<int>();

            var mid = MaxIndexBinarySearch(arr, x);
            if (mid < 0) mid = ~mid;

            int low = mid;
            int high = mid + 1;

            var result = new List<int>();
            while (low >= 0 || high < arr.Length)
            {
                int lowDist = low >= 0 ? Math.Abs(x - arr[low]) : int.MaxValue;
                int highDist = high < arr.Length ? Math.Abs(x - arr[high]) : int.MaxValue;
                if (lowDist <= highDist)
                {
                    result.Add(arr[low]);
                    low--;
                }
                else
                {
                    result.Add(arr[high]);
                    high++;
                }
                k--;
                if (k == 0) break;
            }

            result.Sort();
            return result;
        }

        public int MaxIndexBinarySearch(int[] arr, in int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (arr[mid] <= x)
                {
                    low = mid + 1;
                }
                else
                {
                    high = high - 1;
                }
            }

            var resultIndex = low - 1 >= 0 ? (low - 1) : ~(low - 1);
            if (arr[resultIndex] == x) return resultIndex;
            else
            {
                if (resultIndex - 1 < 0 || (resultIndex < arr.Length && arr[resultIndex] - x < x - arr[resultIndex - 1]))
                    return resultIndex;
                return resultIndex - 1;
            }
        }

        public bool IsSubsequence(string s, string t)
        {
            int sIdx = 0, tIdx = 0;

            while (sIdx < s.Length && tIdx < t.Length)
            {
                if (s[sIdx] == t[tIdx])
                    sIdx++;
                tIdx++;
            }

            return sIdx == s.Length;
        }


        public bool IsSubsequence_BSearch(string s, string t)
        {
            if (string.IsNullOrEmpty(s) && !string.IsNullOrEmpty(t)) return true;

            var dic = new Dictionary<char, List<int>>();
            for (int i = 0; i < t.Length; i++)
            {
                var ch = t[i];
                if (!dic.ContainsKey(ch))
                    dic.Add(ch, new List<int>());
                dic[ch].Add(i);
            }

            int prevCharIndex = -1;
            foreach (var ch in s)
            {
                if (!dic.ContainsKey(ch)) return false;

                var searchSpace = dic[ch];
                prevCharIndex = searchSpace.BinarySearch(prevCharIndex);
                if (prevCharIndex < 0)
                    prevCharIndex = ~prevCharIndex;
                if (prevCharIndex >= searchSpace.Count)
                    return false;
                prevCharIndex = searchSpace[prevCharIndex] + 1;
            }

            return true;
        }

        public int MincostTickets(int[] days, int[] costs)
        {
            if (days == null || days.Length == 0 || costs == null || costs.Length < 3) return 0;

            var dp = new int?[367];
            var willTravel = new bool[367];
            foreach (var day in days)
                willTravel[day] = true;
            MincostTicketsDP(willTravel, costs, 0, ref dp);
            return dp[days[0]].Value;
        }

        private int MincostTicketsDP(bool[] willTravel, int[] costs, int day, ref int?[] dp)
        {
            if (day >= willTravel.Length) return 0;
            if (dp[day].HasValue) return dp[day].Value;

            int minCost = int.MaxValue;
            if (!willTravel[day])
            {
                minCost = MincostTicketsDP(willTravel, costs, day + 1, ref dp);
            }
            else
            {
                for (int i = 0; i < costs.Length; i++)
                {
                    minCost = Math.Min(minCost,
                        costs[i] + MincostTicketsDP(willTravel, costs, day + GetMaxDaysCoverage(i), ref dp));
                }
            }

            dp[day] = minCost;
            return minCost;
        }

        private int GetMaxDaysCoverage(in int i)
        {
            switch (i)
            {
                case 0:
                    return 1;
                case 1:
                    return 7;
                default:
                    return 30;
            }
        }

        public int MinEatingSpeed(int[] piles, int H)
        {
            int max = piles.Max();
            int min = (int)Math.Ceiling(max / (decimal)H);

            while (min <= max)
            {
                int canEatPerHour = min + ((max - min) >> 1);

                int hours = 0, i = 0;
                while (hours <= H && i < piles.Length)
                {
                    hours += (int)Math.Ceiling(piles[i] / (double)canEatPerHour);
                    i++;
                }

                if (hours <= H)
                    max = canEatPerHour - 1;
                else min = canEatPerHour + 1;
            }

            return max + 1;
        }

        public int MaxLevelSum(TreeNode root)
        {
            if (root == null) return 1;
            int maxLevel = 0, level = 0;
            long maxSum = long.MinValue;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                level++;
                long sum = 0;
                var qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    var node = q.Dequeue();
                    sum += node.val;
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
                if (maxSum < sum)
                {
                    maxSum = sum;
                    maxLevel = level;
                }
            }

            return maxLevel;
        }

        public IList<int> LargestValues(TreeNode root)
        {
            if (root == null) return new List<int>();

            var result = new List<int>();
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int max = int.MinValue;
                var qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    var node = q.Dequeue();
                    max = Math.Max(max, node.val);
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
                result.Add(max);
            }

            return result;
        }

        public void WallsAndGates(int[][] rooms)
        {
            if (rooms == null || rooms.Length == 0 || rooms[0].Length == 0) return;
            int rows = rooms.Length, cols = rooms[0].Length;
            var moves = new[] { new[] { 0, -1 }, new[] { 0, 1 }, new[] { -1, 0 }, new[] { 1, 0 } };
            var q = new Queue<(int x, int y, int dist)>();
            //var visited = new bool[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (rooms[i][j] == 0)
                    {
                        //visited[i, j] = true;
                        q.Enqueue((i, j, 1));
                    }
                }
            }

            while (q.Count > 0)
            {
                int qCount = q.Count;
                for (int k = 0; k < qCount; k++)
                {
                    var parent = q.Dequeue();
                    foreach (var move in moves)
                    {
                        var neighbor = (x: parent.x + move[0], y: parent.y + move[1], parent.dist + 1);
                        if (IsValidMove(rooms, neighbor, rows, cols/*, visited*/))
                        {
                            //visited[neighbor.x, neighbor.y] = true;
                            if (rooms[neighbor.x][neighbor.y] > parent.dist)
                            {
                                rooms[neighbor.x][neighbor.y] = parent.dist;
                                q.Enqueue(neighbor);
                            }
                        }
                    }
                }
            }

        }

        private bool IsValidMove(int[][] rooms, (int x, int y, int dist) neighbor, in int rows, in int cols/*, bool[,] visited*/)
        {
            if (neighbor.x < 0 || neighbor.x >= rows || neighbor.y < 0 || neighbor.y >= cols ||
                rooms[neighbor.x][neighbor.y] == -1 || rooms[neighbor.x][neighbor.y] == 0
                //|| visited[neighbor.x, neighbor.y]
            )
                return false;
            return true;
        }

        public class FreqStack
        {
            Dictionary<int, Stack<int>> frequenciesDic = new Dictionary<int, Stack<int>>();
            Dictionary<int, int> itemsFrequency = new Dictionary<int, int>();
            private int maxFreq = 0;

            public FreqStack()
            {

            }

            public void Push(int x)
            {
                if (!itemsFrequency.ContainsKey(x))
                    itemsFrequency.Add(x, 0);
                itemsFrequency[x]++;

                var newFrequency = itemsFrequency[x];
                if (!frequenciesDic.ContainsKey(newFrequency))
                    frequenciesDic.Add(newFrequency, new Stack<int>());

                frequenciesDic[newFrequency].Push(x);

                if (newFrequency > maxFreq) maxFreq = newFrequency;
            }

            public int Pop()
            {
                if (maxFreq == 0) return -1;

                var item = frequenciesDic[maxFreq].Pop();
                itemsFrequency[item]--;

                if (frequenciesDic[maxFreq].Count == 0)
                {
                    frequenciesDic.Remove(maxFreq);
                    maxFreq--;
                }
                return item;
            }
        }

        public class BSTNode
        {
            public int val;
            public int leftNodesCount;

            public BSTNode left;
            public BSTNode right;
        }

        public IList<int> CountSmaller(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return new List<int>();

            var result = new int[nums.Length];
            var root = new BSTNode { val = nums[nums.Length - 1] };
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                result[i] = InsertNode(root, nums[i]);
            }

            return result;
        }

        private int InsertNode(BSTNode node, int num)
        {
            var newNode = new BSTNode { val = num };
            var count = 0;
            while (node != null)
            {
                if (num <= node.val)
                {
                    node.leftNodesCount++;
                    if (node.left == null)
                    {
                        node.left = newNode;
                        break;
                    }
                    else node = node.left;
                }
                else
                {
                    count += node.leftNodesCount + 1;
                    if (node.right == null)
                    {
                        node.right = newNode;
                        break;
                    }
                    else node = node.right;
                }
            }

            return count;
        }

        public int MincostTickets1(int[] days, int[] costs)
        {
            if (days == null || days.Length == 0 || costs == null || costs.Length < 3) return 0;

            return MincostTicketsRec(days, costs, 0, days[0], costs[0]);
        }

        private int MincostTicketsRec(int[] days, int[] costs, int dayIndex, int maxDayIndex, int cost)
        {
            if (dayIndex == days.Length) return cost;

            int option1 = int.MaxValue;
            if (days[dayIndex] <= maxDayIndex)
            {
                option1 = MincostTicketsRec(days, costs, dayIndex + 1, maxDayIndex, cost);
            }
            else
            {
                for (int i = 0; i < costs.Length; i++)
                {
                    option1 = Math.Min(option1, MincostTicketsRec(days, costs, dayIndex, days[dayIndex] + GetMaxDaysCoverage(i) - 1, cost + costs[i]));
                }
            }

            return option1;
        }

        public bool CanPartitionKSubsets1(int[] nums, int k)
        {
            if (nums.Length == 0)
                return false;
            int totalSum = 0;
            // find sum of all array elements
            foreach (int num in nums)
                totalSum += num;
            // if totalSum is odd,it cannot be partitioned into equal sum subset
            if (totalSum % k != 0) return false;
            int subSetSum = totalSum / k;
            var dp = new bool[subSetSum + 1];
            dp[0] = true;
            foreach (int curr in nums)
            {
                for (int j = subSetSum; j >= curr; j--)
                {
                    dp[j] |= dp[j - curr];
                    if (j == subSetSum && dp[j]) return true;
                }
            }
            return dp[subSetSum];
        }

        public bool CanPartition2(int[] nums)
        {
            if (nums.Length == 0)
                return false;
            int totalSum = 0;
            // find sum of all array elements
            foreach (int num in nums)
            {
                totalSum += num;
            }
            // if totalSum is odd,it cannot be partitioned into equal sum subset
            if (totalSum % 2 != 0) return false;
            int subSetSum = totalSum / 2;
            var dp = new bool[subSetSum + 1];
            dp[0] = true;
            foreach (int curr in nums)
            {
                for (int j = subSetSum; j >= curr; j--)
                {
                    dp[j] |= dp[j - curr];
                    if (j == subSetSum && dp[j]) return true;
                }
            }
            return dp[subSetSum];
        }

        public bool CanPartition3(int[] nums)
        {
            if (nums == null || nums.Length < 2) return false;
            var sum = nums.Sum();
            if (sum % 2 == 1) return false;
            if (sum == 0) return true;
            var target = sum / 2;
            var dp = new bool?[nums.Length, target + 1];
            return CanPartitionRec(nums, 0, target, ref dp);
        }

        private bool CanPartitionRec(int[] nums, int i, in int target, ref bool?[,] dp)
        {
            if (target == 0) return true;
            if (i >= nums.Length || target < 0) return false;

            if (dp[i, target].HasValue) return dp[i, target].Value;

            if (target - nums[i] >= 0)
            {
                dp[i, target] = CanPartitionRec(nums, i + 1, target - nums[i], ref dp);
                if (dp[i, target].Value) return true;
            }

            dp[i, target] = CanPartitionRec(nums, i + 1, target, ref dp);
            return dp[i, target].Value;
        }

        public int CountPrimes(int n)
        {
            if (n <= 2) return 0;
            var isPrime = new bool[n];
            Array.Fill(isPrime, true);
            isPrime[0] = false;
            isPrime[1] = false;
            for (int i = 2; i * i < n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < n; j += i)
                        isPrime[j] = false;
                }
                //int factor = i;
                //while (i * factor < n)
                //{
                //    //Console.WriteLine($"{i}*{factor}");
                //    range[i * factor] = false;
                //    factor++;
                //}
            }

            return isPrime.Count(b => b);
        }

        public int CountPrimes_N1_5(int n)
        {
            if (n <= 2) return 0;
            int res = 1;
            for (int i = 3; i < n; i++)
            {
                res += IsPrime(i) ? 1 : 0;
            }

            return res;
        }

        private bool IsPrime(in int num)
        {
            for (int i = 0; i * i <= num; i++)
                if (num % i == 0) return false;
            return true;
        }

        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (x == 0) return 0;
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }

            double result = x;
            n--;
            while (n > 0)
            {
                if (n % 2 == 1)
                    result *= x;
                x *= x;
                n /= 2;
            }

            return result;
        }

        public int[] Shuffle(int[] nums, int n)
        {
            for (int i = 2 * n - 1; i >= 0; i--)
            {
                int k = i;
                do
                {
                    k = k / 2;
                    if (k % 2 == 1)
                        k += n;
                } while (k > i);

                Swap(nums, i, k);
                nums.Print();
            }

            return nums;
        }

        private void Swap(int[] nums, in int i, in int k)
        {
            var temp = nums[i];
            nums[i] = nums[k];
            nums[k] = temp;
        }

        public int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            var st = new Stack<int>();
            st.Push(-1);
            int i = 0;
            for (; i < heights.Length; i++)
            {
                while (st.Peek() != -1 && heights[st.Peek()] > heights[i])
                {
                    var height = heights[st.Pop()];
                    var width = i - st.Peek() - 1;
                    maxArea = Math.Max(maxArea, height * width);
                }

                st.Push(i);
            }

            while (st.Peek() != -1)
            {
                var height = heights[st.Pop()];
                var width = i - st.Peek() - 1;
                maxArea = Math.Max(maxArea, height * width);
            }

            return maxArea;
        }

        public int MaximalRectangle(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return 0;
            int rows = matrix.Length, cols = matrix[0].Length, maxArea = 0;
            int[,] dp = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        dp[i, j] = j - 1 >= 0 && dp[i, j - 1] != 0 ? dp[i, j - 1] + 1 : 1;

                        int minWidth = dp[i, j];
                        // Calc max rect from current i to row = 0
                        for (int k = i; k >= 0; k--)
                        {
                            minWidth = Math.Min(minWidth, dp[k, j]);
                            int height = i - k + 1;
                            maxArea = Math.Max(maxArea, minWidth * height);
                        }
                    }
                }
            }

            return maxArea;
        }

        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            var height = CalcHeight(root);
            int lastLevelMaxNodes = (int)Math.Pow(2, height - 1);

            int low = 0, high = lastLevelMaxNodes - 1;

            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (IsNodeExist(root, lastLevelMaxNodes - 1, mid))
                    low = mid + 1;
                else high = mid - 1;
            }

            return (int)Math.Pow(2, height - 1) - 1 + low;
        }

        private bool IsNodeExist(TreeNode node, int width, int mid)
        {
            while (width > 0 && node != null)
            {
                if (mid <= width / 2)
                    node = node.left;
                else
                {
                    node = node.right;
                    mid -= (int)Math.Ceiling(width / 2d);
                }
                width /= 2;
            }

            return node != null;
        }

        private int CalcHeight(TreeNode node)
        {
            int height = 0;
            while (node != null)
            {
                height++;
                node = node.left;
            }
            return height;
        }

        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            var nodes = new Dictionary<string, Dictionary<string, double>>();

            int i = 0;
            for (; i < equations.Count; i++)
            {
                var (n1, n2) = (equations[i][0], equations[i][1]);

                if (!nodes.ContainsKey(n1))
                    nodes.Add(n1, new Dictionary<string, double>());
                if (!nodes.ContainsKey(n2))
                    nodes.Add(n2, new Dictionary<string, double>());

                nodes[n1].Add(n2, values[i]);
                nodes[n2].Add(n1, 1 / values[i]);
            }

            var result = new double[queries.Count];
            i = 0;
            var visited = new HashSet<string>();
            foreach (var query in queries)
            {
                var (n1, n2) = (query[0], query[1]);

                if (!nodes.ContainsKey(n1) || !nodes.ContainsKey(n2))
                    result[i] = -1;
                else if (n1 == n2)
                    result[i] = 1;
                else
                {
                    visited.Add(n1);
                    var res = DFSQuery(n1, n2, nodes, 1.0, ref visited);
                    result[i] = res != double.MaxValue ? res : -1;
                    visited.Clear();
                }

                i++;
            }

            return result;
        }

        private double DFSQuery(string n1, string n2,
            Dictionary<string, Dictionary<string, double>> adjList, double product,
            ref HashSet<string> visited)
        {
            if (n1 == n2) return product;


            if (adjList[n1].ContainsKey(n2) && !visited.Contains(n2))
                return product * adjList[n1][n2];

            foreach (var child in adjList[n1])
            {
                if (!visited.Contains(child.Key))
                {
                    visited.Add(child.Key);
                    var result = DFSQuery(child.Key, n2, adjList, product * child.Value, ref visited);
                    visited.Remove(child.Key);

                    if (result != double.MaxValue) return result;
                }
            }

            return double.MaxValue;
        }

        public int SplitArray(int[] nums, int m)
        {
            int max = int.MinValue, sum = 0, n = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                max = Math.Max(max, nums[i]);
                sum += nums[i];
            }

            int low = max, high = sum, minSubarraySum = sum;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int sumSoFar = 0, subArraysCount = 1;
                for (int i = 0; i < n; i++)
                {
                    if (sumSoFar + nums[i] <= mid)
                        sumSoFar += nums[i];
                    else
                    {
                        sumSoFar = nums[i];
                        subArraysCount++;
                    }
                }

                if (subArraysCount <= m)
                {
                    minSubarraySum = Math.Min(minSubarraySum, mid);
                    high = mid - 1;
                }
                else low = mid + 1;
            }

            return minSubarraySum;
        }

        public int SplitArray_DP(int[] nums, int m)
        {
            int sum = 0, n = nums.Length;
            var prefixSum = new int[n + 1];
            var dp = new int[n + 1, m + 1];
            for (int i = 0; i < n; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + nums[i];
            }

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= m; j++)
                {
                    dp[i, j] = int.MaxValue;
                }
            }

            dp[0, 0] = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], Math.Max(dp[k, j - 1], (prefixSum[i] - prefixSum[k])));
                    }
                }
            }

            return dp[n, m];
        }

        public int Reverse(int x)
        {
            var res = 0;

            bool isNegative = false;
            if (x < 0)
            {
                isNegative = true;
                x = -x;
            }

            while (x > 0)
            {
                if (res < int.MaxValue / 10 || (res == int.MaxValue / 10 && x % 10 <= 7))
                {
                    res = res * 10;
                    res += (x % 10);
                    x = x / 10;
                }
                else return 0;
            }

            return res * (isNegative ? -1 : 1);
        }

        public int NumJewelsInStones(string J, string S)
        {
            bool[] jDic = new bool[128];
            for (int i = 0; i < J.Length; i++)
            {
                jDic[J[i]] = true;
            }

            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (jDic[S[i]])
                    count++;
            }

            return count;
        }

        public class MyHashMap
        {

            int?[] arr = new int?[1000001];
            /** Initialize your data structure here. */
            public MyHashMap()
            {

            }

            /** value will always be non-negative. */
            public void Put(int key, int value)
            {
                var index = GetHashIndex(key);
                arr[index] = value;
            }

            private int GetHashIndex(int key)
            {
                var hash = key.GetHashCode();
                var index = hash % arr.Length;
                return index;
            }

            /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
            public int Get(int key)
            {
                var index = GetHashIndex(key);
                if (arr[index].HasValue) return arr[index].Value;
                return -1;
            }

            /** Removes the mapping of the specified value key if this map contains a mapping for the key */
            public void Remove(int key)
            {
                var index = GetHashIndex(key);
                arr[index] = null;
            }
        }

        //public bool RepeatedSubstringPattern(string s)
        //{
        //    var arr = new int[26];

        //}

        public class MyCalendarTwo
        {
            List<(int start, int end)> list1 = new List<(int start, int end)>();
            List<(int start, int end)> list2 = new List<(int start, int end)>();

            public MyCalendarTwo()
            {

            }

            public bool Book(int start, int end)
            {
                foreach (var pair in list2)
                {
                    if (start < pair.end && end > pair.start) return false;
                }

                foreach (var pair in list1)
                {
                    if (start < pair.end && end > pair.start)
                    {
                        list2.Add((Math.Max(start, pair.start), Math.Min(end, pair.end)));
                    }
                }

                list1.Add((start, end));
                return true;
            }
        }


        public class MyCalendar
        {
            List<(int start, int end)> list = new List<(int start, int end)>();

            public MyCalendar()
            {
            }

            public bool Book(int start, int end)
            {
                if (list.Count == 0)
                {
                    list.Add((start, end));
                    return true;
                }

                int low = 0, high = list.Count - 1;

                while (low <= high)
                {
                    var mid = low + (high - low) / 2;

                    if (list[mid].start == start) return false;

                    if (start < list[mid].end)
                    {
                        high = mid - 1;
                    }
                    else low = mid + 1;
                }

                //var prev = low == 0 ? (start: 0, end: 0) : list[low - 1];
                //var next = low == list.Count ? (start: int.MaxValue, end: int.MaxValue) : list[low];

                if (low == list.Count || start < list[low].start && end <= list[low].start)
                {
                    if (low == list.Count)
                        list.Add((start, end));
                    else list.Insert(low, (start, end));
                    return true;
                }

                return false;
            }
        }

        public class RandomizedSet
        {
            private HashSet<int> set;
            private Random rnd;

            /** Initialize your data structure here. */
            public RandomizedSet()
            {
                set = new HashSet<int>();
                rnd = new Random();
            }

            /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
            public bool Insert(int val)
            {
                return set.Add(val);
            }

            /** Removes a value from the set. Returns true if the set contained the specified element. */
            public bool Remove(int val)
            {
                return set.Remove(val);
            }

            /** Get a random element from the set. */
            public int GetRandom()
            {
                return set.ElementAt(rnd.Next(0, set.Count));
            }
        }

        public class Logger
        {
            Dictionary<string, int> messageLog = new Dictionary<string, int>();

            /** Initialize your data structure here. */
            public Logger()
            {

            }

            /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
                If this method returns false, the message will not be printed.
                The timestamp is in seconds granularity. */
            public bool ShouldPrintMessage(int timestamp, string message)
            {
                if (!messageLog.ContainsKey(message))
                {
                    messageLog.Add(message, timestamp);
                    return true;
                }
                else
                {
                    if (messageLog[message] + 10 <= timestamp)
                    {
                        messageLog[message] = timestamp;
                        return true;
                    }
                }

                return false;
            }
        }

        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if ((root1 == null || root2 == null) || root1.val != root2.val) return false;

            return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right)) ||
                   (FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
        }

        public bool FlipEquiv_iterative(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if ((root1 == null || root2 == null) || root1.val != root2.val) return false;
            Queue<TreeNode> q1 = new Queue<TreeNode>(), q2 = new Queue<TreeNode>();

            q1.Enqueue(root1);
            q2.Enqueue(root2);

            while (q1.Count > 0 && q2.Count > 0)
            {
                var n1 = q1.Dequeue();
                var n2 = q2.Dequeue();

                if (n1.left?.val == n2.left?.val && n1.right?.val == n2.right?.val)
                {
                    if (n1.left != null) q1.Enqueue(n1.left);
                    if (n1.right != null) q1.Enqueue(n1.right);
                    if (n2.left != null) q2.Enqueue(n2.left);
                    if (n2.right != null) q2.Enqueue(n2.right);
                    continue;
                }

                if (n1.left?.val != n2.right?.val || n1.right?.val != n2.left?.val) return false;

                if (n1.left != null) q1.Enqueue(n1.left);
                if (n1.right != null) q1.Enqueue(n1.right);
                if (n2.right != null) q2.Enqueue(n2.right);
                if (n2.left != null) q2.Enqueue(n2.left);
            }

            return q1.Count == q2.Count;
        }

        public int ConcatenatedBinary(int n)
        {
            int pow = 1, total = 0;
            int mod = 1_000_000_007;

            for (int i = n; i > 0; i--)
            {
                var num = i;
                while (num > 0)
                {
                    if (num % 2 == 1) total = (total + pow) % mod;
                    pow <<= 1;
                    pow %= mod;
                    num >>= 1;
                }
            }

            return total;
        }

        public int ConcatenatedBinary1(int n)
        {
            int mod = (int)Math.Pow(10, 9) + 7;
            string bin = Convert.ToString(n, 2);
            int pow = 0, total = 0;
            for (int i = n; i > 0; i--)
            {
                bin = bin.TrimStart('0');
                total += (BinToDec(bin, pow) % mod);
                total %= mod;
                pow += bin.Length;

                bin = Subtract1(bin);
            }

            return total;
        }

        private string Subtract1(string bin)
        {
            int x = Convert.ToInt32(bin, 2);
            int m = 1;

            // Flip all the set bits 
            // until we find a 1 
            while (!((x & m) > 0))
            {
                x = x ^ m;
                m <<= 1;
            }

            // flip the rightmost 
            // 1 bit 
            x = x ^ m;
            return Convert.ToString(x, 2);
        }

        private int BinToDec(string bin, int pow)
        {
            int sum = 0;
            int mod = (int)Math.Pow(10, 9) + 7;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                if (bin[i] == '1')
                {
                    sum += (int)Math.Pow(2, pow) % mod;
                    sum %= mod;
                }
                pow++;
            }

            return sum;
        }

        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);

            int left = 0, right = nums.Length - 1, count = 0;

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == k)
                {
                    count++;
                    left++;
                    right--;
                }
                else if (sum < k)
                {
                    left++;
                }
                else right--;
            }

            return count;
        }

        public string Interpret(string command)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'G')
                    sb.Append(command[i]);

                else if (command[i] == ')')
                {
                    if (command[i - 1] == '(')
                        sb.Append('o');
                    else sb.Append("al");
                }
            }

            return sb.ToString();
        }

        /**
 * // This is the robot's control interface.
 * // You should not implement it, or speculate about its implementation
 * interface Robot {
 *     // Returns true if the cell in front is open and robot moves into the cell.
 *     // Returns false if the cell in front is blocked and robot stays in the current cell.
 *     public bool Move();
 *
 *     // Robot will stay in the same cell after calling turnLeft/turnRight.
 *     // Each turn will be 90 degrees.
 *     public void TurnLeft();
 *     public void TurnRight();
 *
 *     // Clean the current cell.
 *     public void Clean();
 * }
 */

        public class Robot
        {
            public bool Move()
            {
                return true;
            }

            public void TurnLeft()
            {

            }

            public void TurnRight()
            {

            }

            public void Clean()
            {

            }
        }

        public void CleanRoom(Robot robot)
        {
            CleanRoomRec(robot, 0, 0, 0);
        }

        private int[][] dirs = new int[][] { new[] { -1, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 0, -1 } };
        HashSet<(int row, int col)> cellVisited = new HashSet<(int row, int col)>();

        private void CleanRoomRec(Robot robot, int row, int col, int direction)
        {
            cellVisited.Add((row, col));
            robot.Clean();

            for (int i = 0; i < dirs.Length; i++)
            {
                var nextOrientation = (direction + i) % 4;

                int nextRow = row + dirs[nextOrientation][0], nextCol = col + dirs[nextOrientation][1];

                if (!cellVisited.Contains((nextRow, nextCol)) && robot.Move())
                {
                    CleanRoomRec(robot, nextRow, nextCol, nextOrientation);
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

        public enum RobotOrientation
        {
            Up,
            Left,
            Down,
            Right
        }

        public void CleanRoom1(Robot robot)
        {
            var dirs = new Dictionary<RobotOrientation, (int row, int col)>
            {
                {RobotOrientation.Left, (0, -1)},
                {RobotOrientation.Right, (0, 1)},
                {RobotOrientation.Up, (-1, 0)},
                {RobotOrientation.Down, (1, 0)},
            };
            var stack = new Stack<(int row, int col, RobotOrientation orientation)>();
            var visited = new HashSet<(int row, int col)>();

            var currentPosition = (row: 0, col: 0, orientation: RobotOrientation.Up);
            visited.Add((0, 0));
            AddNeighbors(dirs, currentPosition, visited, stack);

            while (stack.Count > 0)
            {
                var nextStep = stack.Pop();

                var movedToNewCell = false;
                // Move accordingly
                movedToNewCell = Move(currentPosition, nextStep, robot);

                if (movedToNewCell)
                {
                    robot.Clean();

                    AddNeighbors(dirs, nextStep, visited, stack);

                    currentPosition = nextStep;
                }
            }
        }

        private static void AddNeighbors(Dictionary<RobotOrientation, (int row, int col)> dirs, (int row, int col, RobotOrientation orientation) currentPosition,
            HashSet<(int row, int col)> visited, Stack<(int row, int col, RobotOrientation orientation)> stack)
        {
            var (nextStepRow, nextStepCol) = (0, 0);
            foreach (var dir in dirs)
            {
                if (dir.Key == currentPosition.orientation) continue;
                (nextStepRow, nextStepCol) = (currentPosition.row + dir.Value.row, currentPosition.col + dir.Value.col);

                if (!visited.Contains((nextStepRow, nextStepCol)))
                    stack.Push((nextStepRow, nextStepCol, dir.Key));
            }

            (nextStepRow, nextStepCol) = (currentPosition.row + dirs[currentPosition.orientation].row,
                currentPosition.col + dirs[currentPosition.orientation].col);
            if (!visited.Contains((nextStepRow, nextStepCol)))
                stack.Push((nextStepRow, nextStepCol, currentPosition.orientation));
        }

        private bool Move((int row, int col, RobotOrientation orientation) currentPos,
            (int row, int col, RobotOrientation orientation) nextPos, Robot robot)
        {
            // TODO 
            return robot.Move();
        }

        //1,0,0,0,1,0,1
        //0,1,2,3,0,1,0
        //0,3,2,1,0,1,0
        public int MaxDistToClosest(int[] seats)
        {
            int maxEmpty = 0, empty = 0, lastFill = -1;

            int i = 0;
            for (; i < seats.Length; i++)
            {
                if (seats[i] != 0)
                {
                    empty = lastFill >= 0 ? (i - lastFill) / 2 : (i - lastFill - 1);
                    maxEmpty = Math.Max(maxEmpty, empty);
                    lastFill = i;
                }
            }

            empty = i - lastFill - 1;
            maxEmpty = Math.Max(maxEmpty, empty);

            return maxEmpty;
        }

        public string NextClosestTime3(string time)
        {
            var sections = time.Split(":");
            var (hours, minutes) = (sections[0], sections[1]);

            var start = int.Parse(hours) * 60;
            start += int.Parse(minutes);

            int maxElapsed = 24 * 60, answer = start;
            var allowedNumbers = time.Where(ch => ch != ':').Select(ch => ch - '0').ToArray();

            foreach (var hh in allowedNumbers)
            {
                foreach (var h in allowedNumbers)
                {
                    if (hh * 10 + h < 24)
                    {
                        foreach (var mm in allowedNumbers)
                        {
                            foreach (var m in allowedNumbers)
                            {
                                if (mm * 10 + m < 60)
                                {
                                    var next = (hh * 10 + h) * 60 + mm * 10 + m;
                                    var currElapsed = next < start ? (next - start + 24 * 60) : (next - start);
                                    if (currElapsed > 0 && currElapsed < maxElapsed)
                                    {
                                        answer = next;
                                        maxElapsed = currElapsed;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return $"{answer / 60 / 10}{answer / 60 % 10}:{answer % 60 / 10}{answer % 60 % 10}";
        }

        public string NextClosestTime2(string time)
        {
            var sections = time.Split(":");
            var (hours, minutes) = (sections[0], sections[1]);

            var curr = 0;
            curr += int.Parse(hours) * 60;
            curr += int.Parse(minutes);

            var max = 24 * 60;
            var allowedNumbers = time.Where(ch => ch != ':').Select(ch => ch - '0').ToArray();
            while (true)
            {
                curr++;
                curr %= max;
                var validOption = IsValidHour(curr, allowedNumbers);
                if (validOption != string.Empty) return validOption;
            }
        }

        private string IsValidHour(in int curr, int[] allowedNumbers)
        {
            int hh = curr / 60 / 10, h = curr / 60 % 10, mm = curr % 60 / 10, m = curr % 60 % 10;
            if (allowedNumbers.Contains(hh) && allowedNumbers.Contains(h) && allowedNumbers.Contains(mm) &&
                allowedNumbers.Contains(m))
                return $"{hh}{h}:{mm}{m}";
            return string.Empty;
        }

        public string NextClosestTime1(string time)
        {
            var sections = time.Split(":");
            var (hours, minutes) = (sections[0], sections[1]);
            if (minutes.Length == 1) minutes = "0" + minutes;
            if (hours.Length == 1) hours = "0" + hours;
            char[] minutesArr = minutes.ToArray(), hoursArray = hours.ToArray();

            var possibleResults = new List<string>();
            //var result = GetValidOptions(minutesArr, options, hours, ref possibleResults);
            //if (result != string.Empty) return result;
            return string.Empty;
        }

        private string GetValidOptions(char[] minutesArr, char[] options, string hours, ref List<string> possibleResults)
        {
            for (int i = minutesArr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < options.Length; j++)
                {
                    var temp = minutesArr[i];
                    minutesArr[i] = options[j];
                    if (IsValid(minutesArr))
                    {
                        var option = new string(hours) + ":" + new string(minutesArr);
                        if (minutesArr[i] > temp)
                        {
                            return option;
                        }
                        else possibleResults.Add(option);
                    }

                    minutesArr[i] = temp;
                }
            }

            return string.Empty;
        }

        private bool IsValid(char[] arr, bool isHours = false)
        {
            var num = int.Parse(new string(arr));
            if (isHours)
                return num >= 0 && num < 24;
            return num >= 0 && num < 60;
        }


        public class NumArray
        {
            int[] bitArray;

            public NumArray(int[] nums)
            {
                bitArray = new int[nums.Length + 1];

                for (int i = 0; i < nums.Length; i++)
                {
                    Update(i, nums[i]);
                }
            }

            public int Get(int i)
            {
                if (i < 0) return 0;
                i++;
                var sum = 0;
                while (i != 0)
                {
                    sum += bitArray[i];
                    i -= i & -i;
                }

                return sum;
            }

            public int SumRange(int i, int j)
            {
                if (i > j) return 0;
                return Get(j) - Get(i - 1);
            }

            public void Update(int i, int val)
            {
                var oldVal = SumRange(i, i);
                oldVal = bitArray[i];
                var diff = val - oldVal;
                Set(i, diff);
            }

            private void Set(int i, int diff)
            {
                i++;
                while (i < bitArray.Length)
                {
                    bitArray[i] += diff;
                    i += i & -i;
                }
            }
        }

        public class CountSmallerBIT
        {
            public List<int> countSmaller(int[] nums)
            {
                List<int> res = new List<int>();
                if (nums == null || nums.Length == 0)
                {
                    return res;
                }
                // find min value and minus min by each elements, plus 1 to avoid 0 element
                int min = int.MaxValue;
                int max = int.MinValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    min = (nums[i] < min) ? nums[i] : min;
                }
                int[] nums2 = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    nums2[i] = nums[i] - min + 1;
                    max = Math.Max(nums2[i], max);
                }
                int[] tree = new int[max + 1];
                for (int i = nums2.Length - 1; i >= 0; i--)
                {
                    res.Insert(0, get(nums2[i] - 1, tree));
                    update(nums2[i], tree);
                }
                return res;
            }
            private int get(int i, int[] tree)
            {
                int num = 0;
                while (i > 0)
                {
                    num += tree[i];
                    i -= i & (-i);
                }
                return num;
            }
            private void update(int i, int[] tree)
            {
                while (i < tree.Length)
                {
                    tree[i]++;
                    i += i & (-i);
                }
            }
        }
        public int PeakIndexInMountainArray(int[] arr)
        {
            if (arr == null || arr.Length <= 2) return -1;
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                var mid = low + (high - low) / 2;

                if (mid > 0 && mid + 1 < arr.Length && arr[mid] > arr[mid + 1] && arr[mid] > arr[mid - 1])
                    return mid;

                else if ((mid > 0 && arr[mid - 1] < arr[mid]) || (mid + 1 < arr.Length && arr[mid] < arr[mid + 1]))
                    low = mid + 1;
                else high = mid - 1;
            }

            return low;
        }

        public int TotalFruit(int[] tree)
        {
            var map = new Dictionary<int, int>();

            int left = 0, right = 0, maxWidth = 0;

            while (right < tree.Length)
            {
                if (map.ContainsKey(tree[right]))
                    map[tree[right]]++;
                else map.Add(tree[right], 1);

                while (map.Keys.Count > 2)
                {
                    map[tree[left]]--;
                    if (map[tree[left]] == 0)
                        map.Remove(tree[left]);
                    left++;
                }

                maxWidth = Math.Max(maxWidth, right - left + 1);

                right++;
            }

            return maxWidth;
        }

        public string FindReplaceString(string S, int[] indexes, string[] sources, string[] targets)
        {
            var dic = new Dictionary<int, int>();
            for (int j = 0; j < indexes.Length; j++)
                if (MatchFound(S, indexes[j], sources[j]))
                    dic.Add(indexes[j], j);

            var sb = new StringBuilder();
            int i = 0;
            while (i < S.Length)
            {
                if (dic.ContainsKey(i))
                {
                    sb.Append(targets[dic[i]]);
                    i += sources[dic[i]].Length;
                    continue;
                }
                sb.Append(S[i]);
                i++;
            }

            return sb.ToString();
        }

        private bool MatchFound(string s, in int i, string source)
        {
            if (i + source.Length > s.Length) return false;
            return s.Substring(i, source.Length) == source;
        }

        public List<int> CoinChangeList(int[] coins, int amount)
        {
            int max = amount + 1;
            var dp = new int[amount + 1];
            for (int m = 1; m <= amount; m++)
                dp[m] = max;

            for (int c = 0; c < coins.Length; c++)
            {
                for (int m = 1; m <= amount; m++)
                {
                    if (m - coins[c] >= 0)
                        dp[m] = Math.Min(dp[m], dp[m - coins[c]] + 1);
                }
            }

            if (dp[amount] > amount) return new List<int>();

            var result = new List<int>(dp[amount]);
            int coinIndex = coins.Length - 1;
            while (amount > 0 && coinIndex >= 0)
            {
                if (amount >= coins[coinIndex])
                {
                    result.Insert(0, coins[coinIndex]);
                    amount -= coins[coinIndex];
                }
                else coinIndex--;
            }

            return result;
        }

        public int CoinChange(int[] coins, int amount)
        {
            int max = amount + 1;
            var dp = new int[amount + 1];
            for (int m = 1; m <= amount; m++)
                dp[m] = max;

            for (int c = 0; c < coins.Length; c++)
            {
                for (int m = 1; m <= amount; m++)
                {
                    if (m - coins[c] >= 0)
                        dp[m] = Math.Min(dp[m], dp[m - coins[c]] + 1);
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }

        public int CoinChangeV1(int[] coins, int amount)
        {
            int max = amount + 1;
            var dp = new int[coins.Length, amount + 1];
            for (int c = 0; c < coins.Length; c++)
            {
                for (int m = 1; m <= amount; m++)
                    dp[c, m] = max;
            }

            for (int c = 0; c < coins.Length; c++)
            {
                for (int m = 1; m <= amount; m++)
                {
                    dp[c, m] = c > 0 ? dp[c - 1, m] : max;
                    if (m - coins[c] >= 0)
                        dp[c, m] = Math.Min(dp[c, m], dp[c, m - coins[c]] + 1);
                }
            }

            return dp[coins.Length - 1, amount] > amount ? -1 : dp[coins.Length - 1, amount];
        }
    }
}