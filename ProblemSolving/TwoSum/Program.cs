using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Helpers;
using Math = System.Math;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = TwoSum(new[] {3, 2, 4}, 6);

            //Console.WriteLine(string.Join(", ", result));

            //var grid = new char[4][];
            //grid[0] = new[] { '1', '1', '0', '0', '0' };
            //grid[1] = new[] { '1', '1', '0', '0', '0' };
            //grid[2] = new[] { '0', '0', '1', '0', '0' };
            //grid[3] = new[] { '0', '0', '0', '1', '1' };
            //Console.WriteLine(NumIslands(grid));

            //var logs = new[]{"dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"};
            //foreach (var logFile in ReorderLogFiles(logs))
            //{
            //    Console.WriteLine(logFile);
            //}

            //var result = MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            //// -2,  1, -3, 4, -1, 2, 1, -5, 4
            //// -2, -1, -4, 0, -1, 1, 2, -3, 1
            //result = MaxSubArrayON(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            ////var result = MaxSubArray(new[] {1});
            //Console.WriteLine(result);

            //Console.WriteLine(IsValid("()[]{}"));

            //Console.WriteLine(MaxProfitON(new []{ 7, 2, 5, 3, 6, 1, 4 }));

            //Console.WriteLine(IsAlienSorted(new []{ "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz"));

            //var lCache = new Solution.LRUCache(2);
            //lCache.Put(1, 1);
            //lCache.Put(2, 2);
            //lCache.Get(1).Print();
            //lCache.Put(3, 3);
            //lCache.Get(2).Print();
            //lCache.Put(4, 4);
            //lCache.Get(1).Print();
            //lCache.Get(3).Print();
            //lCache.Get(4).Print();

            //Console.WriteLine(LongestPalindrome("babad"));

            //Console.WriteLine(LengthOfLongestSubstring("au"));
            //Console.WriteLine(LengthOfLongestSubstringO2N("abccdcbb"));
            //Console.WriteLine(LengthOfLongestSubstringON("abccdcbb"));

            //Console.WriteLine(OrangesRotting(new[]
            //    {new[] {2}, new[] {1}, new[] {1}, new[] {1}, new[] {2}, new[] {1}, new[] {1}}));
            //Console.WriteLine(OrangesRotting(new[]
            //    {new[] {2, 2}, new[] {1, 1}, new[] {0, 0}, new[] {2, 0}}));

            //var results = ProductExceptSelf(new[] { 1, 2, 3, 4 });
            //foreach (var i in results)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            // [[1,3],[2,6],[8,10],[15,18]]
            //var res = Merge(new[] {new[] {1, 3}, new[] {2, 6}, new[] {8, 10}, new[] {15, 18}});
            // [[2,3],[4,5],[6,7],[8,9],[1,10]]
            //var res = MergeON(new[] {new[] {2, 3}, new[] {4, 5}, new[] {6, 7}, new[] {8, 9}, new[] { 1, 10 } });
            //Console.WriteLine(res);

            //var results = GenerateParenthesis(3);
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //Console.WriteLine(AddStringsBetter("123", "1"));

            //Console.WriteLine(ValidPalindrome("eeccccbebaeeabebccceea"));

            var sln = new Solution();
            //sln.FindPermutations("abc").ForEach(Console.WriteLine);
            //Console.WriteLine(sal.CheckInclusion("adc", "dcda"));

            //var results =
            //    sal.TopKFrequentIterator(new[] {"i", "love", "leetcode", "i", "love", "coding"}, 2);
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //Console.WriteLine(sal.SumBitwise(-2, 9));

            //Console.WriteLine(sal.MinRemoveToMakeValid("lee(t(c)o)de)"));

            //Console.WriteLine(sal.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));

            //Console.WriteLine(sal.WordBreak2("applepenapple", new List<string>() { "apple", "pen" }));

            //sal.ThreeSum(new[] {0, 1, 1});

            //sal.TwoSum(new[] { 2, 3, 4 }, 6);

            //sal.ThreeSum(new[] { -1, 0, 1, 2, -1, -4 });

            //Console.WriteLine(sal.ThreeSumClosest(new[] { 1, 2, 4, 8, 16, 32, 64, 128}, 82));

            //sal.Merge(new[] { 2, 0 }, 1, new[] { 1 }, 1);

            //TreeNode one = new TreeNode(1),
            //    two = new TreeNode(2),
            //    three = new TreeNode(3),
            //    four = new TreeNode(4),
            //    five = new TreeNode(5);
            //one.left = two;
            //one.right = three;
            //two.left = four;
            //two.right = five;
            //Console.WriteLine(sln.DiameterOfBinaryTree(one));

            //sln.MoveZeroes(new int[] { 2, 1 });

            //Console.WriteLine(sln.CoinChange(new []{1, 2, 3}, 6));

            //sln.PartitionLabels("ababcbacadefegdehijhklij");

            //var result = sln.LetterCombinations("23");
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine(sln.BinarySearch(new []{ 0, 1, 2, 4, 5, 6, 7 }, 3));

            //Console.WriteLine(sln.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0));

            //var res = sln.Permute(new[] { 1, 2, 3 });
            //foreach (var re in res)
            //{
            //    foreach (var i in re)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(sln.DecodeString("3[a2[c]]"));

            //Console.WriteLine(sln.Exist(new []
            //{
            //    new Char[]{'A', 'B', 'C', 'E'},
            //    new Char[]{'S', 'F', 'C', 'S'},
            //    new Char[]{'A', 'D', 'E', 'E'},
            //}, "ABCB"));

            //Console.WriteLine(sln.Exist(new[]
            //{
            //    new Char[]{'A', 'B'},
            //    new Char[]{'C', 'D'},
            //}, "CDBA"));

            //Console.WriteLine(sln.Exist(new[]
            //{
            //    new Char[]{'A', 'B', 'C', 'E'},
            //    new Char[]{'S', 'F', 'E', 'S'},
            //    new Char[]{'A', 'D', 'E', 'E'},
            //}, "ABCESEEEFS"));

            //Console.WriteLine(sln.Calculate("2+3*4+1/5"));
            //Console.WriteLine(sln.Calculate("0-2147483647"));
            //Console.WriteLine(sln.Calculate("1-1+1"));

            //sln.IntervalIntersection(
            //    new int[][]
            //    {
            //        new int[] {0, 2},
            //        new int[] {5, 10},
            //        new int[] {13, 23},
            //        new int[] {24, 25},
            //    },
            //    new int[][]
            //    {
            //        new int[] {1, 5},
            //        new int[] {8, 12},
            //        new int[] {15, 24},
            //        new int[] {25, 26},
            //    }
            //);

            //sln.IsHappy(3);

            // 100 900 90 4
            //Console.WriteLine(sln.RomanToInt("MCMXCIV"));

            //3,5,1,6,2,0,8,null,null,7,4
            //var three = new TreeNode(3);
            //var five = new TreeNode(5);
            //var one = new TreeNode(1);
            //var six = new TreeNode(6);
            //var two = new TreeNode(2);
            //var zero = new TreeNode(0);
            //var eight = new TreeNode(8);
            //var seven = new TreeNode(7);
            //var four = new TreeNode(4);
            //three.left = five;
            //three.right = one;
            //five.left = six;
            //five.right = two;
            //two.left = seven;
            //two.right = four;
            //one.left = zero;
            //one.right = eight;
            //var lca = sln.LowestCommonAncestor(three, five, one);
            //Console.WriteLine(lca.val);

            //sln.Convert("PAYPALISHIRING", 3);

            // 7 -> 2 -> 4 -> 3
            //ListNode seven = new ListNode(7);
            //ListNode two = new ListNode(2);
            //ListNode four = new ListNode(4);
            //ListNode three = new ListNode(3);

            //seven.next = two;
            //two.next = four;
            //four.next = three;

            //ListNode five = new ListNode(5);
            //ListNode six = new ListNode(6);
            //ListNode four2 = new ListNode(4);
            //five.next = six;
            //six.next = four2;

            //sln.AddTwoNumbers(seven, five);

            //sln.FindAnagrams("baa", "aa");

            //sln.FindDuplicates(new[] { 4, 3, 2, 7, 8, 2, 3, 1 });

            //Console.WriteLine(sln.SubarraySum3(new[] {1, 1, 1}, 2));

            //sln.CombinationSum(new[] { 2, 3, 5 }, 8);

            //Console.WriteLine(sln.MyAtoi("4193 with words"));

            //Console.WriteLine(sln.MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.",
            //    new string[] {"hit"}));

            //var res = sln.SearchRange(new[] { 1, 3, 5, 7, 9, 11, 13 }, 5);
            //Console.WriteLine($"{res[0]} {res[1]}");

            //sln.AsteroidCollision(new[] {-2, 2, 1, -2});

            //sln.FindItinerary(new List<IList<string>>
            //{
            //    new List<string> {"MUC", "LHR"},
            //    new List<string> {"JFK", "MUC"},
            //    new List<string> {"SFO", "SJC"},
            //    new List<string> {"LHR", "SFO"},
            //});

            //Console.WriteLine(sln.IntToRoman(1994));

            //Console.WriteLine(sln.MinPathSum_O1Space(new int[][]
            //{
            //    new []{5,0,1,1,2,1,0,1,3,6,3,0,7,3,3,3,1},
            //    new []{1,4,1,8,5,5,5,6,8,7,0,4,3,9,9,6,0},
            //    new []{2,8,3,3,1,6,1,4,9,0,9,2,3,3,3,8,4},
            //    new []{3,5,1,9,3,0,8,3,4,3,4,6,9,6,8,9,9},
            //    new []{3,0,7,4,6,6,4,6,8,8,9,3,8,3,9,3,4},
            //    new []{8,8,6,8,3,3,1,7,9,3,3,9,2,4,3,5,1},
            //    new []{7,1,0,4,7,8,4,6,4,2,1,3,7,8,3,5,4},
            //    new []{3,0,9,6,7,8,9,2,0,4,6,3,9,7,2,0,7},
            //    new []{8,0,8,2,6,4,4,0,9,3,8,4,0,4,7,0,4},
            //    new []{3,7,4,5,9,4,9,7,9,8,7,4,0,4,2,0,4},
            //    new []{5,9,0,1,9,1,5,9,5,5,3,4,6,9,8,5,6},
            //    new []{5,7,2,4,4,4,2,1,8,4,8,0,5,4,7,4,7},
            //    new []{9,5,8,6,4,4,3,9,8,1,1,8,7,7,3,6,9},
            //    new []{7,2,3,1,6,3,6,6,6,3,2,3,9,9,4,4,8},
            //}));

            //Console.WriteLine(sln.MinSubArrayLen(4, new[] {1, 4, 4}));

            //Console.WriteLine(sln.MinKnightMoves(2,1));

            //Console.WriteLine(sln.MaximalSquare(new char[][]
            //{
            //    new char[]{'1','0','1','0','0'},
            //    new char[]{'1','0','1','1','1'},
            //    new char[]{'1','1','1','1','1'},
            //    //new char[]{'1','1','1','1','1'},
            //    new char[]{'1','0','0','1','0'},
            //}));

            //sln.FindDuplicate(new[]
            //{
            //    "root/a 1.txt(abcd) 2.txt(efgh)", "root/c 3.txt(abcd)", "root/c/d 4.txt(efgh)", "root 4.txt(efgh)"
            //});

            //sln.WordBreak("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
            //    new List<string>
            //{
            //    "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa"
            //});

            //sln.WordBreak("catsanddog", new List<string>
            //{
            //    "cat", "cats", "and", "sand", "dog"
            //});


            //Console.WriteLine(sln.LongestConsecutive(new[] { 0, 0, -1 }));

            //sln.MaxSlidingWindow(new[]
            //{
            //    -95, 92, -85, 59, -59, -14, 88, -39, 2, 92, 94, 79, 78, -58, 37, 48, 63, -91, 91, 74, -28, 39, 90, -9, -72, -88, -72, 93, 38, 14, -83, -2, 21, 4, -75, -65, 3, 63, 100, 59, -48, 43, 35, -49, 48, -36, -64, -13, -7, -29, 87, 34, 56, -39, -5, -27, -28, 10, -57, 100, -43, -98, 19, -59, 78, -28, -91, 67, 41, -64, 76, 5, -58, -89, 83, 26, -7, -82, -32, -76, 86, 52, -6, 84, 20, 51, -86, 26, 46, 35, -23, 30, -51, 54, 19, 30, 27, 80, 45, 22
            //}, 10);

            //Console.WriteLine(sln.Trap(new[]
            //{
            //    0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1
            //}));

            //Console.WriteLine(sln.FindMedianSortedArrays(new int[]{1,3}, new[] {2}));

            //ListNode _2 = new ListNode(-2), _11 = new ListNode(-1), _12 = new ListNode(-1), _13 = new ListNode(-1);
            //_2.next = _11;
            //_11.next = _12;
            //_12.next = _13;
            //sln.MergeKLists(new ListNode[]
            //{
            //    _2,
            //    null
            //});

            //Console.WriteLine(sln.NumberToWords(1_100_121));

            //Console.WriteLine(sln.findMinFee(new[] {1, 2, 5, 2, 1, 2}));

            //Console.WriteLine(sln.FindMaxSteal(new[] { 2, 5, 1, 3, 6, 2, 4 }));

            //Console.WriteLine(sln.ClimbStairs(3));

            //Console.WriteLine(sln.LongestPalindrome("a"));

            //Console.WriteLine(sln.CanPermutePalindrome("as"));

            //Console.WriteLine(sln.ShortestPalindrome("abcd"));

            //Console.WriteLine(sln.findMPPCuts("cdpdd"));

            //Console.WriteLine(sln.SmallestCommonElement(new[]
            //{
            //    new[] {1, 2, 3, 4, 5},
            //    new[] {2, 4, 5, 8, 10},
            //    new[] {3, 5, 7, 9, 11},
            //    new[] {1, 3, 5, 7, 9},
            //}));

            //Console.WriteLine(sln.FindMin(new[] { 6, 7, 8, 1, 2, 3, 4, 5 }));

            //Console.WriteLine(sln.MaxProfit(new[] { 1, 2, 3, 4, 5 }));

            //var _1 = new ListNode(0);
            //var _02 = new ListNode(0);
            //var _01 = new ListNode(1, _02);
            //Console.WriteLine(sln.IsPalindrome(_01));

            //Solution.MedianFinder m = new Solution.MedianFinder();
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(6);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(10);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(2);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(6);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(5);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(0);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(6);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(3);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(1);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(0);
            //Console.WriteLine(m.FindMedian());
            //m.AddNum(0);
            //Console.WriteLine(m.FindMedian());

            //Console.WriteLine(sln.Compress(new[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }));

            //Console.WriteLine(sln.Calculate("1 + 3 / (5 - (2 * 4)) + 10"));

            //var bog = new Solution.Boggle();
            //foreach (var word in bog.findAllWords())
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine(sln.Exist(new []
            //{
            //    new []{'A','B','C','E'},
            //    new []{  'S','F','C','S'},
            //    new []{'A','D','E','E'},
            //}, "SEEK"));

            //new Solution.WordsSearch().FindWords(new[] { new[] { 'a' } }, new[] { "a" });

            //var trie = new Solution.Trie();
            //trie.Insert("apple");
            //Console.WriteLine(trie.Search("apple"));   // returns true
            //Console.WriteLine(trie.Search("app"));     // returns false
            //Console.WriteLine(trie.StartsWith("app")); // returns true
            //trie.Insert("app");
            //Console.WriteLine(trie.Search("app1"));     // returns false

            //foreach (var diagonalPoint in sln.GetDiagonalPoints(3, 3, 4))
            //{
            //    Console.WriteLine($"({diagonalPoint.i}, {diagonalPoint.j})");
            //}

            //foreach (var shape in sln.SolveNQueens(4))
            //{
            //    foreach (var row in shape)
            //    {
            //        Console.WriteLine(row);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            //Console.WriteLine(sln.CountPrimes(25));

            //Console.WriteLine(sln.FirstBadVersion(5));

            //var log = new Solution.Logger();
            //Console.WriteLine(log.ShouldPrintMessage(1, "foo"));
            //Console.WriteLine(log.ShouldPrintMessage(8, "foo"));
            //Console.WriteLine(log.ShouldPrintMessage(11, "foo"));

            //sln.HighFive(new[]
            //{
            //    new[] {1, 89},
            //    new[] {1, 58},
            //    new[] {1, 77},
            //    new[] {1, 8},
            //    new[] {1, 98},
            //    new[] {1, 0},
            //    new[] {1, 54},
            //    new[] {1, 44},
            //    new[] {1, 31},
            //    new[] {1, 34},
            //    new[] {1, 43},
            //    new[] {1, 59},
            //    new[] {1, 0},
            //    new[] {1, 7},
            //    new[] {1, 39},
            //    new[] {1, 51},
            //    new[] {1, 50},
            //    new[] {1, 87},
            //    new[] {1, 93},
            //    new[] {1, 88}
            //});

            //var _41 = new TreeNode(4);
            //var _42 = new TreeNode(4);
            //var _31 = new TreeNode(3);
            //var _32 = new TreeNode(3);
            //var _21 = new TreeNode(2, _31, _41);
            //var _22 = new TreeNode(2, _42, _32);
            //var _1 = new TreeNode(1, _21, _22);
            //Console.WriteLine(sln.IsSymmetric(_1));

            //Console.WriteLine(sln.Search(new []{1,3,1,1,1}, 3));

            //Console.WriteLine(sln.Rob(new []{2, 1, 1, 2}));

            //Console.WriteLine(sln.MajorityElement(new[] { 1 }));

            //sln.SortedArrayToBST(new[] { -10, -3, 0, 5, 9 });

            //Console.WriteLine(sln.MinMoves(new []{1, 1, 2147483647}));

            //var _3 = new ListNode(3);
            //var _1 = new ListNode(1, _3);
            //var _2 = new ListNode(2, _1);
            //var _4 = new ListNode(4, _2);
            //sln.SortList(_4);
            //sln.InsertionSortList(_4);

            //var _1 = new TreeNode(0);
            //Console.WriteLine(sln.ClosestValue(_1, 2147483648.0));

            //Console.WriteLine(sln.IsIsomorphic("egg", "adc"));

            //sln.PrisonAfterNDays(new[] {0, 1, 0, 1, 1, 0, 0, 1}, 7);

            //Console.WriteLine(sln.LadderLength("hit", "cog",
            //    new List<string> { "hot", "dot", "dog", "lot", "log", "cog" }));

            //Console.WriteLine(sln.SearchMatrix(new int[1, 0]
            //{
            //    {}
            //}, 0));

            //var _6 = new TreeNode(6);
            //var _7 = new TreeNode(7);
            //var _4 = new TreeNode(4);
            //var _8 = new TreeNode(8);
            //var _4 = new TreeNode(4);
            //var _3 = new TreeNode(3, _4);
            //var _2 = new TreeNode(2, null, _3);
            //var _1 = new TreeNode(1, null, _2);
            //var _0 = new TreeNode(0, null, _1);
            //var res = sln.DistanceK(_0, _2, 2);
            //foreach (var num in res)
            //{
            //    Console.WriteLine(num);
            //}

            //var board = new[]
            //{
            //    new[] {-1, -1, -1, -1, -1, -1},
            //    new[] {-1, -1, -1, -1, -1, -1},
            //    new[] {-1, -1, -1, -1, -1, -1},
            //    new[] {-1, 35, -1, -1, 13, -1},
            //    new[] {-1, -1, -1, -1, -1, -1},
            //    new[] {-1, 15, -1, -1, -1, -1},
            //};
            //var moves = sln.SnakesAndLadders(ref board);
            //for (int i = 0; i < board.Length; i++)
            //{
            //    for (int j = 0; j < board.Length; j++)
            //    {
            //        Console.Write(moves[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(sln.ShortestPathBinaryMatrix(new[]
            //{
            //    new[] {0, 0, 0, 1},
            //    new[] {0, 0, 1, 0},
            //    new[] {0, 1, 0, 0},
            //    new[] {1, 0, 0, 0},

            //    //new []{0,0,0},
            //    //new []{1,1,0},
            //    //new []{1,1,0},
            //}));

            //sln.SuggestedProducts(new[] {"mobile", "mouse", "moneypot", "monitor", "mousepad"}, "mouse");

            //var snake = new Solution.SnakeGame(3, 3, new[]
            //{
            //    new[] {0, 1},
            //    new[] {0, 2},
            //    new[] {1, 2},
            //    new[] {2, 2},
            //    new[] {2, 1},
            //    new[] {2, 0},
            //    new[] {1, 0},
            //});
            //snake.Move("R").Print();
            //snake.Move("R").Print();
            //snake.Move("D").Print();
            //snake.Move("D").Print();
            //snake.Move("L").Print();
            //snake.Move("L").Print();
            //snake.Move("U").Print();
            //snake.Move("U").Print();
            //snake.Move("R").Print();
            //snake.Move("R").Print();
            //snake.Move("D").Print();
            //snake.Move("D").Print();
            //snake.Move("L").Print();
            //snake.Move("L").Print();
            //snake.Move("U").Print();
            //snake.Move("R").Print();
            //snake.Move("U").Print();
            //snake.Move("L").Print();
            ////snake.Print();
            //snake.Move("D").Print();
            //snake.Print();

            //Console.WriteLine(sln.ConnectSticks(new []{2,4,3}));
            //var x = 0;
            //sln.permute(0, new[] {3354, 4316, 3259, 4904, 4598, 474, 3166, 6322, 8080, 9009}, ref x);
            //Console.WriteLine(x);

            // 2->1->4->3->5
            //var _5 = new ListNode(5);
            //var _4 = new ListNode(4, _5);
            //var _3 = new ListNode(3, _4);
            //var _2 = new ListNode(2, _3);
            //var _1 = new ListNode(1, _2);
            //sln.ReverseBetween(_1, 2, 4);

            //sln.CombinationSum2(new int[] {10, 1, 2, 7, 6, 1, 5}, 8);

            //var lst = new Solution.StringPermutation().permuteString("bad");
            //foreach (var word in lst)
            //{
            //    Console.WriteLine(word);
            //}

            //sln.Subsets(new[] { 1, 2, 3 });

            //var fs = new Solution.FileSystem();
            //fs.Ls("/");
            //fs.Mkdir("/a/b/c");
            //fs.AddContentToFile("/a/b/c/d", "hello");
            //fs.Ls("/");
            //fs.ReadContentFromFile("/a/b/c/d");


            //var cache = new Solution.LFUCache(2);
            //cache.Put(1, 2);
            //cache.Put(2, 2);
            //cache.Get(1);
            //cache.Put(3, 3);
            //cache.Get(2);
            //cache.Get(3);
            //cache.Put(4, 4);
            //cache.Get(1);
            //cache.Get(3);
            //cache.Get(4);

            //Console.WriteLine(sln.MinWindow("bba", "ab"));

            //Console.WriteLine(sln.LengthOfLongestSubstringKDistinct("abaccc", 2));

            //Console.WriteLine(sln.BackspaceCompare("y#fo##f", "y#f#o##f"));

            //sln.PlusOne(new[] {9});
            //Console.WriteLine(sln.SumBitwise(3,1));

            //sln.LevelOrder(null);

            //var _5 = new TreeNode(5);
            //var _4 = new TreeNode(4);
            //var _3 = new TreeNode(3, null, _5);
            //var _2 = new TreeNode(2, _4);
            //var _1 = new TreeNode(1, _2, _3);
            //sln.ZigzagLevelOrder(_1);

            //sln.MedianSlidingWindow(new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3);
            //sln.MedianSlidingWindow(new[] { 2147483647, 2147483647 }, 2);
            //sln.MedianSlidingWindow(new[] {5, 5, 8, 1, 4, 7, 1, 3, 8, 4}, 8);

            //PriorityQueue<int> h = new PriorityQueue<int>(4);
            //h.Add(5);
            //h.Add(5);
            //h.Add(7);
            //h.Add(8);
            //Console.WriteLine(h.Peek());
            //h.Delete(5);
            //Console.WriteLine(h.Peek());

            //Console.WriteLine(sln.FrequencySort("abb"));

            //Console.WriteLine(sln.GetSum(3, 6));

            //sln.SingleNumberIII(new[] { 1, 2, 1, 3, 2, 5 });

            //Console.WriteLine(sln.NumberToWords(1234567));

            //Console.WriteLine(sln.NumDecodings("101"));

            //Console.WriteLine(sln.findMaxSumNonadjacent(new[]
            //{
            //    1,
            //    6,
            //    10,
            //    14,
            //    -5,
            //    -1,
            //    2,
            //    -1,
            //    3
            //}));

            //Console.WriteLine(sln.LengthOfLIS(new[] {10, 9, 2, 5, 3, 7, 101, 18}));

            //sln.NextPermutation(new []{1,2,3});

            //sln.SpiralOrder(new[]
            //{
            //    new[] {1, 2, 3},
            //    new[] {4, 5, 6},
            //    new[] {7, 8, 9},
            //});

            //var _5 = new ListNode(5);
            //var _4 = new ListNode(4, _5);
            //var _3 = new ListNode(3, _4);
            //var _2 = new ListNode(2, _3);
            //var _1 = new ListNode(1, _2);
            //sln.ReorderList(_1);

            //var _3 = new TreeNode(3);
            //var _6 = new TreeNode(6);
            //var _4 = new TreeNode(4, _3, _6);
            //var _1 = new TreeNode(1);
            //var _5 = new TreeNode(5, _1, _4);
            //Console.WriteLine(sln.IsValidBST(_5));

            //sln.DailyTemperatures1(new[] {55, 38, 53, 81, 61, 93, 97, 32, 43, 78});

            //Console.WriteLine(BSTHelper.countBST(19));

            //Console.WriteLine(sln.MaximalRectangle(new[]
            //{
            //    new []{'0', '0', '1', '0'},
            //    new []{'1', '1', '1', '1'},
            //    new []{'1', '1', '1', '1'},
            //    new []{'1', '1', '1', '0'},
            //    new []{'1', '1', '0', '0'},
            //    new []{'1', '1', '1', '1'},
            //    new []{'1', '1', '1', '0'}
            //}));

            //sln.FourSum(new[] { 0, 0, 0, 0 }, 0);


            // 2->1->4->3->5
            //var _5 = new ListNode(5);
            //var _4 = new ListNode(4, _5);
            //var _3 = new ListNode(3, _4);
            //var _2 = new ListNode(2, _3);
            //var _1 = new ListNode(1, _2);
            //var newHead = sln.ReverseKGroup(_1, 2);

            //sln.BstFromPreorder(new[] { 8, 5, 1, 7, 10, 12 });

            //Console.WriteLine(sln.CanFinish(2, new[]
            //{
            //    new[] {1, 0}
            //}));

            //Console.WriteLine(new Solution.Solution2().FindCelebrity(2));

            //Console.WriteLine(sln.CountComponents(10, new[]
            //{
            //    new[] {5, 6},
            //    new[] {0, 2},
            //    new[] {1, 7},
            //    new[] {5, 9},
            //    new[] {1, 8},
            //    new[] {3, 4},
            //    new[] {0, 6},
            //    new[] {0, 7},
            //    new[] {0, 3},
            //    new[] {8, 9}
            //}));

            //Console.WriteLine(sln.AreSentencesSimilarTwo(
            //    new[] { "a", "very", "delicious", "meal" },
            //    new[] { "one", "really", "delicious", "dinner" },
            //    new List<IList<string>>
            //    {
            //        new List<string> {"great", "good"}, new List<string> {"extraordinary", "good"},
            //        new List<string> {"well", "good"}, new List<string> {"wonderful", "good"},
            //        new List<string> {"excellent", "good"}, new List<string> {"fine", "good"},
            //        new List<string> {"nice", "good"}, new List<string> {"any", "one"},
            //        new List<string> {"some", "one"}, new List<string> {"unique", "one"},
            //        new List<string> {"the", "one"}, new List<string> {"an", "one"}, new List<string> {"single", "one"},
            //        new List<string> {"a", "one"}, new List<string> {"truck", "car"}, new List<string> {"wagon", "car"},
            //        new List<string> {"automobile", "car"}, new List<string> {"auto", "car"},
            //        new List<string> {"vehicle", "car"}, new List<string> {"entertain", "have"},
            //        new List<string> {"drink", "have"}, new List<string> {"eat", "have"},
            //        new List<string> {"take", "have"}, new List<string> {"fruits", "meal"},
            //        new List<string> {"brunch", "meal"}, new List<string> {"breakfast", "meal"},
            //        new List<string> {"food", "meal"}, new List<string> {"dinner", "meal"},
            //        new List<string> {"super", "meal"}, new List<string> {"lunch", "meal"},
            //        new List<string> {"possess", "own"}, new List<string> {"keep", "own"},
            //        new List<string> {"have", "own"}, new List<string> {"extremely", "very"},
            //        new List<string> {"actually", "very"}, new List<string> {"really", "very"},
            //        new List<string> {"super", "very"}
            //    }));

            //Console.WriteLine(sln.AlienOrder(new[]
            //{
            //    "za", "zb", "ca", "cb"
            //}));

            //sln.CriticalConnections(4, new List<IList<int>>
            //{
            //    new List<int>
            //    {
            //        0, 1
            //    },
            //    new List<int>
            //    {
            //        1, 2
            //    },
            //    new List<int>
            //    {
            //        2, 0
            //    },
            //    new List<int>
            //    {
            //        1, 3
            //    }
            //});

            //Console.WriteLine(sln.LongestCommonSubsequence("abcde", "ace"));

            //Console.WriteLine(sln.FindMinimumDeletions(new []{ 4, 2, 3, 6, 10, 1, 12 }));

            //Console.WriteLine(sln.FindLIS(new[] { -4, 10, 3, 7, 15 }));
        }

        public class Solution
        {
            public int FindSumLIS(int[] nums)
            {
                var max = FindSumLISRec(nums, 0, -1);
                return max;
            }

            private int FindSumLISRec(int[] nums, int curr, int prev)
            {
                if (curr == nums.Length) return 0;

                int c1 = 0;
                if (prev == -1 || nums[curr] > nums[prev])
                    c1 = 1 + FindLISRec(nums, curr + 1, curr);
                var c2 = FindLISRec(nums, curr + 1, prev);

                return Math.Max(c1, c2);
            }

            public int FindLIS(int[] nums)
            {
                var max = FindLISRec(nums, 0, -1);
                return max;
            }

            private int FindLISRec(int[] nums, int curr, int prev)
            {
                if (curr == nums.Length) return 0;

                int c1 = 0;
                if (prev == -1 || nums[curr] > nums[prev])
                    c1 = 1 + FindLISRec(nums, curr + 1, curr);
                var c2 = FindLISRec(nums, curr + 1, prev);

                return Math.Max(c1, c2);
            }

            //public int FindMinimumDeletions(int[] nums)
            //{
            //    var min = int.MaxValue;

            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        var required = 0;
            //        for (int j = i + 1; j < nums.Length; j++)
            //        {
            //            if (nums[j] <= nums[i]) required++;
            //        }
            //        if(nums.Length - required > )
            //        min = Math.Min(min, required);
            //    }

            //    return min;
            //}


            public int LongestCommonSubsequence(string text1, string text2)
            {
                if (text2.Length > text1.Length)
                {
                    var temp = text1;
                    text1 = text2;
                    text2 = temp;
                }

                int[] curr = new int[text2.Length + 1], prev = new int[text2.Length + 1];
                for (int i = 1; i <= text1.Length; i++)
                {
                    for (int j = 1; j <= text2.Length; j++)
                    {
                        if (text1[i - 1] == text2[j - 1])
                        {
                            curr[j] = 1 + prev[j - 1];
                        }
                        else
                        {
                            curr[j] = Math.Max(prev[j], curr[j - 1]);
                        }
                    }

                    var temp = prev;
                    prev = curr;
                    curr = temp;
                }

                return curr[text2.Length];
            }

            public int LongestCommonSubsequence_BottomUp(string text1, string text2)
            {
                int maxLength = 0;
                var dp = new int?[text1.Length, text2.Length];

                maxLength = LongestCommonSubsequenceRec(ref text1, ref text2, ref dp, 0, 0);

                return maxLength;
            }

            public int LongestCommonSubsequenceRec(ref string text1, ref string text2, ref int?[,] dp, int i1, int i2)
            {
                if (i1 >= text1.Length || i2 >= text2.Length) return 0;

                if (dp[i1, i2].HasValue) return dp[i1, i2].Value;

                if (text1[i1] == text2[i2])
                    dp[i1, i2] = 1 + LongestCommonSubsequenceRec(ref text1, ref text2, ref dp, i1 + 1, i2 + 1);
                else
                {
                    var c1 = LongestCommonSubsequenceRec(ref text1, ref text2, ref dp, i1 + 1, i2);
                    var c2 = LongestCommonSubsequenceRec(ref text1, ref text2, ref dp, i1, i2 + 1);
                    dp[i1, i2] = Math.Max(c1, c2);
                }
                return dp[i1, i2].Value;
            }

            public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
            {
                var hs = new List<List<int>>(n);
                var id = new int[n];
                var low = new int[n];
                for (int i = 0; i < n; i++)
                {
                    id[i] = -1;
                    hs.Add(new List<int>(2));
                }

                foreach (var connection in connections)
                {
                    hs[connection[0]].Add(connection[1]);
                    hs[connection[1]].Add(connection[0]);
                }

                var res = new List<IList<int>>();
                CriticalConnectionsRec2(ref hs, -1, 0, ref id, ref low, ref res);

                return res;
            }

            private int lastId = 0;

            private void CriticalConnectionsRec2(ref List<List<int>> hs, int parent, int node,
                ref int[] id, ref int[] low, ref List<IList<int>> res)
            {
                id[node] = low[node] = lastId++;

                foreach (var ne in hs.ElementAt(node))
                {
                    if (parent == ne) continue;
                    if (id[ne] == -1)
                    {
                        CriticalConnectionsRec2(ref hs, node, ne, ref id, ref low, ref res);
                        low[node] = Math.Min(low[node], low[ne]);
                        if (id[node] < low[ne])
                        {
                            res.Add(new List<int>(2) { node, ne });
                        }
                    }
                    else
                    {
                        low[node] = Math.Min(low[node], low[ne]);
                    }
                }
            }

            public IList<IList<int>> CriticalConnections_Valid(int n, IList<IList<int>> connections)
            {
                var hs = new List<List<int>>();
                for (int i = 0; i < n; i++)
                {
                    hs.Add(new List<int>());
                }

                foreach (var connection in connections)
                {
                    hs.ElementAt(connection[0]).Add(connection[1]);
                    hs.ElementAt(connection[1]).Add(connection[0]);
                }

                var res = new List<IList<int>>();
                var gDepth = new int[hs.Count];
                var visited = new bool[hs.Count];
                var depth = 0;
                TraverseGraphRec(ref hs, ref gDepth, ref visited, -1, 0, ref depth, ref res);
                return res;
            }

            public void TraverseGraphRec(ref List<List<int>> hs, ref int[] gDepth, ref bool[] visited, int parent,
                int node, ref int depth, ref List<IList<int>> res)
            {
                visited[node] = true;
                gDepth[node] = depth++;
                var currentDepth = gDepth[node];
                foreach (var neighbor in hs.ElementAt(node))
                {
                    if (neighbor == parent) continue;
                    if (!visited[neighbor])
                        TraverseGraphRec(ref hs, ref gDepth, ref visited, node, neighbor, ref depth, ref res);
                    gDepth[node] = Math.Min(gDepth[node], gDepth[neighbor]);
                    if (currentDepth < gDepth[neighbor])
                    {
                        res.Add(new List<int>
                        {
                            node,
                            neighbor
                        });
                    }
                }
            }

            public IList<IList<int>> CriticalConnections3(int n, IList<IList<int>> connections)
            {
                var inDegrees = new int[n];
                var outDegrees = new int[n];

                foreach (var connection in connections)
                {
                    inDegrees[connection[0]]++;
                    inDegrees[connection[1]]++;
                    outDegrees[connection[0]]++;
                    outDegrees[connection[1]]++;
                }

                var res = new List<IList<int>>();
                foreach (var connection in connections)
                {
                    inDegrees[connection[0]]--;
                    inDegrees[connection[1]]--;
                    if (inDegrees[connection[0]] == 0 || inDegrees[connection[1]] == 0)
                        res.Add(new List<int> { connection[0], connection[1] });
                    inDegrees[connection[0]]++;
                    inDegrees[connection[1]]++;
                }

                return res;
            }

            public IList<IList<int>> CriticalConnections_Old(int n, IList<IList<int>> connections)
            {
                var hs = new HashSet<GraphNode<int>>();
                for (int i = 0; i < n; i++)
                {
                    hs.Add(new GraphNode<int>(i));
                }

                foreach (var connection in connections)
                {
                    hs.ElementAt(connection[0]).neighbors.Add(hs.ElementAt(connection[1]));
                    hs.ElementAt(connection[1]).neighbors.Add(hs.ElementAt(connection[0]));
                }

                var res = new List<IList<int>>();
                foreach (var connection in connections)
                {
                    hs.ElementAt(connection[0]).neighbors.Remove(hs.ElementAt(connection[1]));
                    hs.ElementAt(connection[1]).neighbors.Remove(hs.ElementAt(connection[0]));

                    if (!CanReach(hs.Count, hs.ElementAt(connection[0]), hs.ElementAt(connection[1])))
                    {
                        res.Add(new List<int> { connection[0], connection[1] });
                    }

                    hs.ElementAt(connection[0]).neighbors.Add(hs.ElementAt(connection[1]));
                    hs.ElementAt(connection[1]).neighbors.Add(hs.ElementAt(connection[0]));
                }

                return res;
            }

            private bool CanReach(int count, GraphNode<int> first, GraphNode<int> second)
            {
                bool[] visited = new bool[count];

                var q = new Queue<GraphNode<int>>();
                q.Enqueue(first);

                while (q.Count > 0)
                {
                    var v = q.Dequeue();
                    visited[v.val] = true;
                    foreach (var vNeighbor in v.neighbors)
                    {
                        if (vNeighbor.val == second.val) return true;
                        if (!visited[vNeighbor.val])
                        {
                            visited[vNeighbor.val] = true;
                            q.Enqueue(vNeighbor);
                        }
                    }
                }

                return false;
            }

            private bool IsGraphConnected(ref HashSet<GraphNode<int>> hs)
            {
                bool[] visited = new bool[hs.Count];

                var q = new Queue<GraphNode<int>>();
                q.Enqueue(hs.ElementAt(0));

                int count = 0;
                while (q.Count > 0)
                {
                    var v = q.Dequeue();
                    visited[v.val] = true;
                    count++;
                    foreach (var vNeighbor in v.neighbors)
                    {
                        if (!visited[vNeighbor.val])
                        {
                            visited[vNeighbor.val] = true;
                            q.Enqueue(vNeighbor);
                        }
                    }
                }

                return count == hs.Count;
            }

            public string AlienOrder(string[] words)
            {
                var v = new Dictionary<char, GraphNode<char>>();

                for (int i = 0; i < words.Length; i++)
                {
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!v.ContainsKey(words[i][j]))
                        {
                            v.Add(words[i][j], new GraphNode<char>(words[i][j]));
                        }
                    }
                }

                // Build the graph
                for (int i = 0; i < words.Length - 1; i++)
                {
                    var firstWord = words[i];
                    var secondWord = words[i + 1];
                    if (firstWord.Length > secondWord.Length && firstWord.StartsWith(secondWord)) return string.Empty;
                    for (int j = 0; j < Math.Min(firstWord.Length, secondWord.Length); j++)
                    {
                        if (firstWord[j] == secondWord[j]) continue;
                        var firstChar = v[firstWord[j]];
                        var secondChar = v[secondWord[j]];
                        if (!firstChar.neighbors.Contains(secondChar))
                        {
                            firstChar.neighbors.Add(secondChar);
                        }

                        break;
                    }
                }

                // Build indegrees
                var inDegrees = new int[26];
                for (int i = 0; i < 26; i++)
                {
                    inDegrees[i] = v.ContainsKey((char)('a' + i)) ? 0 : -1;
                }

                foreach (var kv in v)
                {
                    foreach (var neighbor in kv.Value.neighbors)
                    {
                        inDegrees[neighbor.val - 'a']++;
                    }
                }

                var q = new Queue<GraphNode<char>>();
                for (int i = 0; i < 26; i++)
                {
                    if (inDegrees[i] == 0) q.Enqueue(v[(char)('a' + i)]);
                }

                var lst = new StringBuilder();
                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    lst.Append(node.val);
                    foreach (var neighbor in node.neighbors)
                    {
                        inDegrees[neighbor.val - 'a']--;
                        if (inDegrees[neighbor.val - 'a'] == 0) q.Enqueue(v[neighbor.val]);
                    }
                }

                return lst.Length < v.Keys.Count ? "" : lst.ToString();
            }

            public IList<int> NumIslands2(int m, int n, int[][] positions)
            {
                if (m == 0 || n == 0) return new List<int> { 0 };
                var res = new List<int>(positions.Length);
                int height = m, width = n;
                var set = new DSU(height * width);
                set._componentsCount = 0;

                foreach (var position in positions)
                {
                    var (i, j) = (position[0], position[1]);
                    if (set.parents[i * width + j] == -1)
                    {
                        set.parents[i * width + j] = i * width + j;
                        set.sizes[i * width + j] = 1;
                        set._componentsCount++;

                        if (j + 1 < width && set.parents[i * width + (j + 1)] != -1)
                            set.Union(i * width + j, i * width + (j + 1));
                        if (j - 1 >= 0 && set.parents[i * width + (j - 1)] != -1)
                            set.Union(i * width + j, i * width + (j - 1));
                        if (i + 1 < height && set.parents[(i + 1) * width + j] != -1)
                            set.Union(i * width + j, (i + 1) * width + j);
                        if (i - 1 >= 0 && set.parents[(i - 1) * width + j] != -1)
                            set.Union(i * width + j, (i - 1) * width + j);
                    }

                    res.Add(set._componentsCount);
                }

                return res;
            }

            public int NumIslands(char[][] grid)
            {
                if (grid.Length == 0 || grid[0].Length == 0) return 0;

                int height = grid.Length, width = grid[0].Length;
                var set = new DSU(height * width);

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (grid[i][j] == '1')
                        {
                            if (j + 1 < width && grid[i][j + 1] == '1') set.Union(i * width + j, i * width + (j + 1));
                            if (i + 1 < height && grid[i + 1][j] == '1') set.Union(i * width + j, (i + 1) * width + j);
                            grid[i][j] = '0';
                        }
                        else
                        {
                            set.sizes[i * width + j] = 0;
                            set.parents[i * width + j] = -1;
                            set._componentsCount--;
                        }
                    }
                }

                return set._componentsCount;
            }

            public bool AreSentencesSimilarTwo(string[] words1, string[] words2, IList<IList<string>> pairs)
            {
                if (words1.Length != words2.Length) return false;
                int lastPos = 0;
                var posDic = new Dictionary<string, int>();

                for (int i = 0; i < words1.Length; i++)
                {
                    if (!posDic.ContainsKey(words1[i])) posDic.Add(words1[i], lastPos++);
                    if (!posDic.ContainsKey(words2[i])) posDic.Add(words2[i], lastPos++);
                }

                foreach (var pair in pairs)
                {
                    if (!posDic.ContainsKey(pair[0])) posDic.Add(pair[0], lastPos++);
                    if (!posDic.ContainsKey(pair[1])) posDic.Add(pair[1], lastPos++);
                }

                var parents = new int[lastPos];
                var rank = new int[lastPos];
                for (int i = 0; i < parents.Length; i++)
                {
                    parents[i] = i;
                }

                foreach (var pair in pairs)
                {
                    var p1 = FindGraphParent(ref parents, posDic[pair[0]]);
                    var p2 = FindGraphParent(ref parents, posDic[pair[1]]);
                    if (rank[p1] >= rank[p2])
                    {
                        parents[posDic[pair[1]]] = p1;
                        parents[p2] = p1;
                        rank[p1]++;
                    }
                    else
                    {
                        parents[posDic[pair[0]]] = p2;
                        parents[p1] = p2;
                        rank[p2]++;
                    }
                }

                for (int i = 0; i < words2.Length; i++)
                {
                    if (words1[i] == words2[i]) continue;
                    if (FindGraphParent(ref parents, parents[posDic[words1[i]]]) !=
                        FindGraphParent(ref parents, parents[posDic[words2[i]]])) return false;
                }

                return true;
            }

            public bool AreSentencesSimilar(string[] words1, string[] words2, IList<IList<string>> pairs)
            {
                if (words1.Length != words2.Length) return false;

                var dic = new Dictionary<string, HashSet<string>>();
                foreach (var pair in pairs)
                {
                    AddToDic(ref dic, pair[0], pair[1]);
                    AddToDic(ref dic, pair[1], pair[0]);
                }

                for (int i = 0; i < words1.Length; i++)
                {
                    if (words1[i] == words2[i]) continue;
                    if (dic.ContainsKey(words1[i]))
                    {
                        if (!dic[words1[i]].Contains(words2[i])) return false;
                    }
                    else return false;
                }

                return true;
            }

            private static void AddToDic(ref Dictionary<string, HashSet<string>> dic, string key, string val)
            {
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(val);
                }
                else dic.Add(key, new HashSet<string> { val });
            }

            public bool ValidTree(int n, int[][] edges)
            {
                var v = new int[n];
                var rank = new int[n];

                for (int i = 0; i < n; i++)
                {
                    v[i] = i;
                }

                int count = n;
                for (int i = 0; i < edges.Length; i++)
                {
                    var p1 = FindGraphParent(ref v, edges[i][0]);
                    var p2 = FindGraphParent(ref v, edges[i][1]);
                    if (p1 != p2)
                    {
                        if (rank[p1] >= rank[p2])
                        {
                            v[edges[i][1]] = p1;
                            v[p2] = p1;
                            rank[p1]++;
                        }
                        else
                        {
                            v[edges[i][0]] = p2;
                            v[p1] = p2;
                            rank[p2]++;
                        }

                        count--;
                    }
                    else return false;
                }

                return count == 1;
            }

            public class Vertex
            {
                public int val;
                public bool isVisited;
                public List<Vertex> adjList = new List<Vertex>();

                public Vertex(int val)
                {
                    this.val = val;
                }
            }

            public bool ValidTreeOld(int n, int[][] edges)
            {
                var vertices = new List<Vertex>();
                for (int i = 0; i < n; i++)
                {
                    vertices.Add(new Vertex(i));
                }

                for (int i = 0; i < edges.Length; i++)
                {
                    if (vertices[edges[i][0]].isVisited && vertices[edges[i][1]].isVisited) return false;
                    vertices[edges[i][0]].isVisited = true;
                    vertices[edges[i][1]].isVisited = true;
                }

                for (int i = 0; i < n; i++)
                {
                    if (!vertices[i].isVisited) return false;
                }

                return true;
            }

            public int FindCircleNum(int[][] M)
            {
                int n = M.Length;
                if (n < 2) return n;
                int[] v = new int[n];
                int[] rank = new int[n];
                for (int i = 0; i < n; i++)
                {
                    v[i] = i;
                }

                int count = n;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (M[i][j] == 1)
                        {
                            var p1 = FindGraphParent(ref v, i);
                            var p2 = FindGraphParent(ref v, j);
                            if (p1 != p2)
                            {
                                if (rank[p1] >= rank[p2])
                                {
                                    v[j] = p1;
                                    v[p2] = p1;
                                    rank[p1]++;
                                }
                                else
                                {
                                    v[i] = p2;
                                    v[p1] = p2;
                                    rank[p2]++;
                                }

                                count--;
                            }
                        }
                    }
                }

                return count;
            }

            public int CountComponents(int n, int[][] edges)
            {
                if (n < 2) return n;
                int[] v = new int[n];
                int[] rank = new int[n];
                for (int i = 0; i < n; i++)
                {
                    v[i] = i;
                }

                int count = n;
                foreach (var edge in edges)
                {
                    //[[5, 6],[0, 2],[1, 7],[5, 9],[1, 8],[3, 4],[0, 6],[0, 7],[0, 3],[8, 9]]
                    //5-6-9
                    //0-2
                    //1-7-8
                    //3-4
                    var p1 = FindGraphParent(ref v, edge[0]);
                    var p2 = FindGraphParent(ref v, edge[1]);
                    if (p1 != p2)
                    {
                        if (rank[p1] >= rank[p2])
                        {
                            v[edge[1]] = p1;
                            v[p2] = p1;
                            rank[p1]++;
                        }
                        else
                        {
                            v[edge[0]] = p2;
                            v[p1] = p2;
                            rank[p2]++;
                        }

                        count--;
                    }
                }

                return count;
            }

            private int FindGraphParent(ref int[] v, int n)
            {
                if (v[n] != n) v[n] = FindGraphParent(ref v, v[n]);
                return v[n];
            }


            public class GraphNode<T>
            {
                public T val;
                public IList<GraphNode<T>> neighbors;

                public GraphNode()
                {
                    val = default(T);
                    neighbors = new List<GraphNode<T>>();
                }

                public GraphNode(T _val)
                {
                    val = _val;
                    neighbors = new List<GraphNode<T>>();
                }

                public GraphNode(T _val, List<GraphNode<T>> _neighbors)
                {
                    val = _val;
                    neighbors = _neighbors;
                }
            }

            public class Node : GraphNode<int>
            {
                public Node(int val) : base(val)
                {

                }
            }

        }
    }
}