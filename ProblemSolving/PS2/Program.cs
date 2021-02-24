using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Xml.Schema;
using Helpers;
using Int32 = System.Int32;
using Math = System.Math;

namespace PS2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();

            //Console.WriteLine(sln.LengthOfLIS(new[] {10, 9, 2, 5, 3, 7, 101, 18}));

            //Console.WriteLine(sln.MaxSubArrayLen(new[] { -2, -1, 2, 1}, 1));

            //Console.WriteLine(sln.IsPredecessor("abc", "abcd"));
            //Console.WriteLine(sln.IsPredecessor("abc", "abdc"));
            //Console.WriteLine(sln.IsPredecessor("abc", "adbc"));
            //Console.WriteLine(sln.IsPredecessor("abc", "abdd"));
            //var arr = new[] { "ksqvsyq", "ks", "kss", "czvh", "zczpzvdhx", "zczpzvh", "zczpzvhx", "zcpzvh", "zczvh", "gr", "grukmj", "ksqvsq", "gruj", "kssq", "ksqsq", "grukkmj", "grukj", "zczpzfvdhx", "gru" };
            //Console.WriteLine(sln.LongestStrChain(arr));

            //sln.Subsets(new[] {1, 2, 3}).Print();

            //sln.SubsetsWithDup(new[] {1, 3, 3, 5}).Print();

            //sln.Permute2(new[] { 1, 2, 3 }).Print();

            //sln.PermuteUnique(new[] { 1, 2, 2 }).Print();

            //var nums = new[] { 1, 5, 1 };
            //sln.NextPermutation(nums);
            //nums.Print();

            //sln.GenerateAbbreviations("BAT").Print();

            //Console.WriteLine(sln.GetMaxLen(new[] { 1000000000, 1000000000 }));

            //sln.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2).Print();

            //Console.WriteLine(sln.CoinChange(new []{1,2,5}, 5));

            //Console.WriteLine(sln.Change(5, new[] { 1, 2, 5 }));

            //Console.WriteLine(sln.MissingElement(new []{4, 7, 9, 10}, 3));

            //Console.WriteLine(sln.FirstMissingPositive(new int[] { 2,1 }));

            //var ms = new MissingNumber();
            //ms.FindKthPositive(new[] {2}, 1).Print();

            //sln.OrangesRotting(new[]
            //{
            //    new[] {0, 2},
            //}).Print();

            //sln.GenerateMatrix(4).Print();

            //sln.Partition("aab").Print();

            //sln.MinCut("aaabaa").Print();
            //sln.IsPalindrome(new StringBuilder("ababababababababababababcbabababababababababababa")).Print();

            //sln.ReverseWords("   ").Print();

            //var sln1 = new Solution.Solution1(new int[0]);
            //sln1.Shuffle().Print();
            //sln1.Shuffle().Print();
            //sln1.Shuffle().Print();
            //sln1.Shuffle().Print();
            //sln1.Shuffle().Print();
            //sln1.Shuffle().Print();
            //sln1.Shuffle().Print();
            //sln1.Shuffle().Print();

            //sln.FindDiagonalOrder(new[]
            //{
            //    new[] {1, 2, 3},
            //    new[] {4, 5, 6},
            //    new[] {7, 8, 9},
            //}).Print();

            //sln.ModifyString("?qe?").Print();

            //sln.NumTriplets(new []{ 1, 1 }, new []{ 1, 1, 1 }).Print();
            //[], nums2 = []

            //sln.MinCost("abaaac", new[] { 1, 2, 3, 4, 1, 5 }).Print();

            //sln.MaxNumEdgesToRemove(4, new[]
            //{
            //    new[] {3, 1, 2},
            //    new[] {3, 2, 3},
            //    new[] {1, 1, 3},
            //    new[] {1, 2, 4},
            //    new[] {1, 1, 2},
            //    new[] {2, 3, 4},

            //    //new []{3,1,2},
            //    //new []{3,2,3},
            //    //new []{1,1,4},
            //    //new []{2,1,4}

            //    //new []{1,1,2},
            //    //new []{2,1,2}
            //}).Print();

            //sln.SimplifyPath("/a//b////c/d//././/../../../..").Print();

            //var comparer = new Solution.MultiDimensionalComparer();
            ////comparer.GetHashCode(new[]
            ////    {
            ////        new[] {1, 2, 3},
            ////        new[] {4, 0, 5}
            ////    }).Print();
            //var hs = new HashSet<int[][]>(comparer);
            //hs.Add(new[]
            //{
            //    new[] {1, 2, 3},
            //    new[] {4, 0, 5}
            //});
            //hs.Add(new[]
            //{
            //    new[] {1, 2, 3},
            //    new[] {4, 0, 5}
            //});
            //hs.Count.Print();

            //comparer.GetHashCode(new []
            //{
            //    new[] {1, 1, 0},
            //    new[] {0, 1, 1},
            //}).Print();
            //comparer.GetHashCode(new[]
            //{
            //    new[] {1, 1, 1},
            //    new[] {0, 1, 0}
            //}).Print();
            //comparer.Equals(new[]
            //{
            //    new[] {1, 1, 0},
            //    new[] {0, 1, 1},
            //}, new[]
            //{
            //    new[] {1, 1, 1},
            //    new[] {0, 1, 0}
            //}).Print();

            //sln.NumDistinctIslands(new[]
            //{
            //    //[[],[],[],[],[]]
            //    new[] {1, 1, 0},
            //    new[] {0, 1, 1},
            //    new[] {0, 0, 0},
            //    new[] {1, 1, 1},
            //    new[] {0, 1, 0}
            //}).Print();

            //sln.CheckIfPrerequisite(5,
            //    new[]
            //    {
            //        new[] {0, 1},
            //        new[] {1, 2},
            //        new[] {2, 3},
            //        new[] {3, 4},
            //    },
            //    new[]
            //    {
            //        new[] {0, 4},
            //        new[] {4, 0},
            //        new[] {1, 3},
            //        new[] {3, 0},
            //    }).Print();

            //sln.SequenceReconstruction(new[] { 4, 1, 5, 2, 6, 3 }, new List<IList<int>>
            //{
            //    new List<int> {5,2,6,3},
            //    new List<int> {4,1,5,2},
            //}).Print();

            //sln.IsRectangleOverlap(new[]
            //    {
            //        4,0,6,6
            //    },
            //    new[]
            //    {
            //        -5,-3,4,2
            //    }).Print();

            //sln.SolveCoinChange(new[] { 1, 2, 5 }, 7).Print();

            //sln.LongestRepeatedSubstring("Geeky");

            //var suffix = new Solution.SuffixArray("abab".ToCharArray());
            //suffix.getSa().Print();

            //sln.LastSubstring("ababaa").Print();

            //sln.FindTargetSumWays(new []{ 1, 1, 1, 1, 1 }, 3).Print();

            //sln.SingleNonDuplicate(new[] { 3, 3, 7, 7, 10, 11, 11 }).Print();

            //var _12 = new TreeNode(12);
            //var _11 = new TreeNode(11);
            //var _10 = new TreeNode(10);
            //var _9 = new TreeNode(9);
            //var _8 = new TreeNode(8);
            //var _7 = new TreeNode(7);
            //var _6 = new TreeNode(6, _12);
            //var _5 = new TreeNode(5, _10, _11);
            //var _4 = new TreeNode(4, _8, _9);
            //var _3 = new TreeNode(3, _6, _7);
            //var _2 = new TreeNode(2, _4, _5);
            //var _1 = new TreeNode(1, _2, _3);
            //sln.BoundaryOfBinaryTree(_1).Print();

            //sln.SuggestedProducts(new[] {"mobile", "mouse", "moneypot", "monitor", "mousepad"}, "mouse").Print();

            //sln.MaxProductPath(new[]
            //{
            //    new[] {4,3},
            //}).Print();

            //Console.WriteLine(sln.ReorderSpaces("  this   is  a sentence ") + "|");

            //sln.ValidateStackSequences(new[]
            //    {
            //        1, 2, 3, 4, 5
            //    },
            //    new[]
            //    {
            //        4, 3, 5, 1, 2
            //    }).Print();

            //sln.MinOperations(new []{ "d1/", "d2/", "../", "d21/", "./" }).Print();
            //sln.MinOperations(new []{ "d1/", "d2/", "./", "d3/", "../", "d31/" }).Print();
            //sln.MinOperations(new []{ "d1/", "../", "../", "../" }).Print();

            //sln.MaximumRequests(3, new[]
            //{
            //    //[[1, 2],[1, 2],[2, 2],[0, 2],[2, 1],[1, 1],[1, 2]]
            //    new[]{ 1, 2 },
            //    new[] {1, 2},
            //    new[] {2, 2},
            //    new[] {0, 2},
            //    new[] {2, 1},
            //    new[] {1, 1},
            //    new[] {1, 2},
            //}).Print();

            //sln.Search(new[] { 4, 5, 6, 7, 0, 1 }, 4).Print();
            //sln.Search(new[] { 4, 5, 6, 7, 0, 1 }, 5).Print();
            //sln.Search(new[] { 4, 5, 6, 7, 0, 1 }, 6).Print();
            //sln.Search(new[] { 4, 5, 6, 7, 0, 1 }, 7).Print();
            //sln.Search(new[] { 4, 5, 6, 7, 0, 1 }, 0).Print();
            //sln.Search(new[] { 4, 5, 6, 7, 0, 1 }, 1).Print();
            //sln.Search(new[] { 4, 5, 6, 7, 0, 1 }, 2).Print();

            //sln.SingleNonDuplicate(new[] {0, 1, 1, 3, 3, 4, 4, 8, 8}).Print();

            //sln.Find132pattern(new[] { -2, 1, 2, -2, 1, 2 }).Print();

            //sln.Permute(new []{1,2,3}).Print();

            //Solution.Trie trie = new Solution.Trie();

            //trie.Insert("apple");
            //trie.Search("apple").Print();   // returns true
            //trie.Search("app").Print();     // returns false
            //trie.StartsWith("app").Print(); // returns true
            //trie.Insert("app");
            //trie.Search("app").Print();     // returns true

            //sln.SpecialArray(new[] {0, 0}).Print();

            //var _12 = new TreeNode(12);
            //var _8 = new TreeNode(8);
            //var _6 = new TreeNode(6);
            //var _2 = new TreeNode(2);
            //var _3 = new TreeNode(3, _12, _8);
            //var _7 = new TreeNode(7, _6);
            //var _9 = new TreeNode(9, null, _2);
            //var _4 = new TreeNode(4, _7, _9);
            //var _10 = new TreeNode(10, _3);
            //var _1 = new TreeNode(1, _10, _4);

            //sln.IsEvenOddTree(_1).Print();

            //sln.GroupAnagrams(new[] { "bdddddddddd", "bbbbbbbbbbc" }).Print();

            //sln.ShortestDistance(new[]
            //{
            //    new[] {0, 0, 1, 0, 0},
            //    new[] {0, 0, 0, 0, 0},
            //    new[] {0, 0, 0, 1, 0},
            //    new[] {1, 1, 0, 1, 1},
            //    new[] {0, 0, 0, 0, 0},
            //}, new[] {0, 4}, new[] {3, 2}).Print();

            //var res = sln.RemoveInvalidParentheses(")(f");
            //res.Print();

            //var rle1 = new Solution.RLE("heeellooo");
            //rle1.key.Print();
            //rle1.counts.Print();

            //sln.ExpressiveWords("zzzzzyyyyy", new []{"zzyy", "zy", "zyy"}).Print();
            //["RLEIterator","next","next","next","next"]
            //[[[]],[2],[1],[1],[2]]
            //var relI = new Solution.RLEIterator(new int[] { 3, 8, 0, 9, 2, 5 });
            //relI.Next(2).Print();
            //relI.Next(1).Print();
            //relI.Next(1).Print();
            //relI.Next(2).Print();

            //sln.PartitionLabels("qiejxqfnqceocmy").Print();

            //sln.ComputeArea(-2,
            //    -2,
            //    2,
            //    2,
            //    3,
            //    3,
            //    4,
            //    4).Print();

            //sln.maxCoins(new[] { 3, 1, 5, 8 });

            //Console.WriteLine(sln.execCount);

            //sln.LongestValidParentheses("(()").Print();

            //sln.LongestValidParentheses("()()()").Print();

            //sln.ReachingPoints(1, 1, 3, 5).Print();

            //sln.ReachingPoints(35,
            //    13,
            //    45595,
            //    99009).Print();

            //sln.MaximalNetworkRank(5, new []
            //{
            //    new []{2, 3},
            //    new []{0,3},
            //    new []{0,4},
            //    new []{4,1},
            //}).Print();

            //sln.CheckPalindromeFormation("cdeoo", "oooab").Print();

            //sln.LeastInterval(new[] { 'A', 'A', 'A', 'B', 'B', 'B', 'C', 'C', 'C', 'D', 'D', 'E' }, 2).Print();

            //var lfu = new Solution.LFUCache(2);
            //lfu.Put(1, 1);
            //lfu.Put(2, 2);
            //lfu.Get(1).Print();
            //lfu.Put(3, 3);
            //lfu.Get(2).Print();
            //lfu.Get(3).Print();
            //lfu.Put(4, 4);
            //lfu.Get(1).Print();
            //lfu.Get(3).Print();
            //lfu.Get(4).Print();

            //lfu.Put(3, 1);
            //lfu.Put(2, 1);
            //lfu.Put(2, 2);
            //lfu.Put(4, 4);
            //lfu.Get(2);

            //sln.LongestSubstring("baaabcb", 3).Print();

            //sln.CanJump(new []{ 2, 3, 1, 1, 4 }).Print();
            //sln.Jump(new[] { 4, 1, 1, 3, 1, 1, 1 }).Print();
            sln.MinJumps(new[] {100, -23, -23, 404, 100, 23, 23, 23, 3, 404}).Print();
            sln.MinJumps(new[] { 7, 6, 9, 6, 9, 6, 9, 7 }).Print();
            sln.MinJumps(new[] {6,1,9}).Print();
        }

        public class Solution
        {
            public int MinJumps(int[] arr)
            {

                if (arr == null || arr.Length < 2) return 0;
                var dic = new Dictionary<int, List<int>>();
                var end = arr.Length - 1;
                for (int i = 0; i <= end; i++)
                {
                    if (dic.ContainsKey(arr[i]))
                    {
                        dic[arr[i]].Add(i);
                    }
                    else dic.Add(arr[i], new List<int> { i });
                }

                var visited = new bool[arr.Length];
                var q = new Queue<(int idx, int jumps, bool canGoBack)>();
                q.Enqueue((0, 0, false));
                visited[0] = true;
                while (q.Count > 0)
                {
                    var pos = q.Dequeue();
                    //if (visited[pos.idx]) continue;
                    if (pos.idx == end)
                    {
                        return pos.jumps;
                    }
                    else
                    {
                        var lst = dic[arr[pos.idx]];
                        for (int i = lst.Count - 1; i >= 0; i--)
                        {
                            var idx = lst[i];
                            if (pos.idx != idx && !visited[idx])
                            {
                                q.Enqueue((idx, pos.jumps + 1, true));
                                visited[idx] = true;
                            }
                        }
                        dic[arr[pos.idx]].Clear();
                        
                        int next = pos.idx + 1, prev = pos.idx - 1;
                        if (next <= end && !visited[next])
                        {
                            q.Enqueue((next, pos.jumps + 1, false));
                            visited[next] = true;
                        }

                        if (prev >= 0 && !visited[prev] && pos.canGoBack)
                        {
                            q.Enqueue((prev, pos.jumps + 1, pos.canGoBack));
                            visited[prev] = true;
                        }
                    }
                }

                return int.MaxValue;
            }

            public int MinJumps1(int[] arr)
            {
                //var dp = new int?[arr.Length];
                //return MinJumpsRec(arr, 0, ref dp);

                if (arr == null || arr.Length < 2) return 0;
                var dic = new Dictionary<int, List<int>>();
                var end = arr.Length - 1;
                for (int i = 0; i <= end; i++)
                {
                    if (dic.ContainsKey(arr[i]))
                    {
                        dic[arr[i]].Add(i);
                    }
                    else dic.Add(arr[i], new List<int> {i});
                }

                var dist = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    dist[i] = int.MaxValue;
                }
                var q = new Queue<(int idx, int jumps, bool canGoBack)>();
                q.Enqueue((0, 0, false));
                var min = int.MaxValue;
                while (q.Count > 0)
                {
                    var pos = q.Dequeue();
                    if(dist[pos.idx] < pos.jumps) continue;
                    if (pos.idx == end)
                    {
                        min = Math.Min(min, pos.jumps);
                    }
                    else
                    {
                        int next = pos.idx + 1, prev = pos.idx - 1;
                        if (next <= end && dist[next] > (pos.jumps + 1)) q.Enqueue((next, pos.jumps + 1, false)); //
                        if (pos.canGoBack && prev >= 0 && dist[prev] > (pos.jumps + 1)) q.Enqueue((prev, pos.jumps + 1, true));
                        foreach (var idx in dic[arr[pos.idx]])
                        {
                            if(pos.idx != idx && dist[idx] > (pos.jumps + 1)) q.Enqueue((idx, pos.jumps + 1, true));
                        }
                    }
                    dist[pos.idx] = Math.Min(dist[pos.idx], pos.jumps + 1);
                }

                return min;
            }

            //private int MinJumpsRec(int[] arr, int i, ref int?[] dp)
            //{
            //    if (i < 0 || i >= arr.Length) return Int32.MaxValue;
            //    if (i == arr.Length - 1) return 0;

            //    if (dp[i].HasValue) return dp[i].Value;

            //    dp[i] = int.MaxValue;
            //    var option = MinJumpsRec(arr, i + 1, ref dp);
            //    dp[i] = Math.Min(dp[i].Value, option);
            //    option = MinJumpsRec(arr, i - 1, ref dp);
            //    dp[i] = Math.Min(dp[i].Value, option);
            //    option = MinJumpsRec(arr, i + 1, ref dp);
            //    dp[i] = Math.Min(dp[i].Value, option);
            //}

            public bool CanReach(int[] arr, int start)
            {
                if (arr == null || start < 0 || start >= arr.Length || arr.Length == 0) return false;
                
                var q = new Queue<int>();
                q.Enqueue(start);

                while (q.Count > 0)
                {
                    var pos = q.Dequeue();
                    if (arr[pos] == 0) return true;
                    else if(arr[pos] < 0) continue;
                    int next = pos + arr[pos], prev = pos - arr[pos];
                    if (next < arr.Length && arr[next] >= 0) q.Enqueue(next);
                    if (prev >= 0 && arr[prev] >= 0) q.Enqueue(prev);
                    arr[pos] = -1 * arr[pos];
                }

                return false;
            }

            public int Jump(int[] nums)
            {
                if (nums.Length < 2) return 0;
                
                var maxPos = nums[0];
                var maxDist = nums[0];
                int jumps = 1;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (maxDist < i)
                    {
                        maxDist = maxPos;
                        jumps++;
                    }
                    maxPos = Math.Max(maxPos, i + nums[i]);
                }

                return jumps;
            }

            public int JumpON2(int[] nums)
            {
                var dist = new int[nums.Length];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    dist[i] = int.MaxValue;
                }

                for (int i = nums.Length - 2; i >= 0; i--)
                {
                    var furthest = Math.Min(nums.Length - 1, i + nums[i]);
                    var minDist = Math.Min(dist[i + 1], dist[furthest]);
                    dist[i] = minDist + 1;
                }

                return dist[0];
            }

            public bool CanJump(int[] nums)
            {
                var lastGoodPos = nums.Length - 1;
                for (int i = nums.Length - 2; i >= 0; i--)
                {
                    if (i + nums[i] >= lastGoodPos)
                    {
                        lastGoodPos = i;
                    }
                }
                return lastGoodPos == 0;
            }

            public bool CanJump1(int[] nums)
            {
                var dp = new bool?[nums.Length];
                return CanJumpRec(nums, 0, ref dp);
            }

            private bool CanJumpRec(int[] nums, int i, ref bool?[] dp)
            {
                if (i >= nums.Length - 1) return true;
                else if (dp[i].HasValue) return dp[i].Value;
                else if (nums[i] == 0) dp[i] = false;
                else if (i + nums[i] >= (nums.Length - 1)) dp[i] = true;
                else
                {
                    int max = 0, maxIdx = i;
                    for (int j = i + 1; j <= i + nums[i]; j++)
                    {
                        if ((maxIdx + max) <= (j + nums[j]))
                        {
                            max = nums[j];
                            maxIdx = j;
                        }
                    }

                    if (maxIdx != i)
                    {
                        var canJump = CanJumpRec(nums, maxIdx, ref dp);
                        dp[i] = canJump;
                    }
                }

                return dp[i] ?? false;
            }

            public int LongestSubstring(string s, int k)
            {
                if (string.IsNullOrEmpty(s)) return 0;
                var statsArr = new int[26];
                for (int i = 0; i < s.Length; i++)
                {
                    statsArr[s[i] - 'a']++;
                }

                var countArr = new int[26];
                int left = 0, right = 0, max = 0;
                while (left < s.Length)
                {
                    while (right < s.Length && statsArr[s[right] - 'a'] >= k)
                    {
                        countArr[s[right] - 'a']++;
                        right++;
                        if (IsAtLeastK(countArr, k, out int length))
                        {
                            max = Math.Max(max, length);
                        }
                    }

                    while (left < right)
                    {
                        countArr[s[left] - 'a']--;
                        left++;
                        if (IsAtLeastK(countArr, k, out int length))
                        {
                            max = Math.Max(max, length);
                        }
                    }

                    for (int i = 0; i < 26; i++)
                    {
                        countArr[i] = 0;
                    }

                    left = right = right + 1;
                }

                return max;
            }

            public int LongestSubstring2(string s, int k)
            {
                if (string.IsNullOrEmpty(s)) return 0;
                var statsArr = new int[26];
                for (int i = 0; i < s.Length; i++)
                {
                    statsArr[s[i] - 'a']++;
                }

                var countArr = new int[26];
                int max = 0;
                LongestSubstringRec(s, 0, k, ref max, ref statsArr, countArr);
                return max;
            }

            private void LongestSubstringRec(string s, int i, in int k, ref int max, ref int[] statsArr, int[] countArr)
            {
                if (i == s.Length) return;

                int chId = s[i] - 'a';
                countArr[chId]++;
                if (countArr[chId] >= k)
                {
                    if (IsAtLeastK(countArr, k, out int length))
                    {
                        max = Math.Max(max, length);
                    }
                }

                if (statsArr[chId] >= k)
                    LongestSubstringRec(s, i + 1, k, ref max, ref statsArr, countArr);

                LongestSubstringRec(s, i + 1, k, ref max, ref statsArr, new int[26]);
            }

            private bool IsAtLeastK(int[] countArr, in int k, out int length)
            {
                length = 0;
                for (int i = 0; i < 26; i++)
                {
                    if (countArr[i] != 0 && countArr[i] < k) return false;
                    length += countArr[i];
                }
                return true;
            }

            public class FreqItem : IComparable<FreqItem>
            {
                public int key;
                public int value;
                public int freq = 1;
                public int timestamp;
                public int CompareTo(FreqItem other)
                {
                    if (this.freq == other.freq) return this.timestamp.CompareTo(other.timestamp);
                    return this.freq.CompareTo(other.freq);
                }
            }

            public class LFUCache
            {
                private readonly int _capacity;
                Dictionary<int, DoublyListNode<FreqItem>> dic;
                Dictionary<int, DoublyLinkedList<FreqItem>> freqDic;
                private int minFreq = 1;

                public LFUCache(int capacity)
                {
                    _capacity = capacity;
                    dic = new Dictionary<int, DoublyListNode<FreqItem>>(capacity);
                    freqDic = new Dictionary<int, DoublyLinkedList<FreqItem>>();
                }

                public int Get(int key)
                {
                    if (_capacity == 0) return -1;
                    if (dic.ContainsKey(key))
                    {
                        UpdateItem(key, null);

                        return dic[key].val.value;
                    }
                    return -1;
                }

                public void Put(int key, int value)
                {
                    if (_capacity == 0) return;
                    if (dic.ContainsKey(key))
                    {
                        // Increase freq
                        UpdateItem(key, value);
                    }
                    else
                    {
                        var item = new FreqItem { key = key, value = value };
                        if (dic.Keys.Count >= _capacity)
                        {
                            var removedItem = freqDic[minFreq].head;
                            freqDic[minFreq].RemoveHead();
                            dic.Remove(removedItem.val.key);
                        }
                        minFreq = 1;

                        var valueNode = new DoublyListNode<FreqItem>(item);
                        InsertIntoFreqDic(item, valueNode);
                        dic.Add(key, valueNode);
                    }
                }

                private void InsertIntoFreqDic(FreqItem item, DoublyListNode<FreqItem> valueNode)
                {
                    if (freqDic.ContainsKey(item.freq))
                        freqDic[item.freq].InsertAtTail(valueNode);
                    else freqDic.Add(item.freq, new DoublyLinkedList<FreqItem>().InsertAtTail(valueNode));
                }

                private void UpdateItem(int key, int? value)
                {
                    var item = dic[key];
                    freqDic[item.val.freq].Remove(item);
                    if (minFreq == item.val.freq && freqDic[item.val.freq].head == null)
                        minFreq++;
                    item.val.freq++;
                    if (value.HasValue) item.val.value = value.Value;
                    InsertIntoFreqDic(item.val, item);
                }
            }

            public class LFUCache2
            {
                private readonly int _capacity;
                private Dictionary<int, FreqItem> keyValuePairsDic;
                private SortedDictionary<FreqItem, int> sortedPairsDic;
                private int timestamp;

                public LFUCache2(int capacity)
                {
                    _capacity = capacity;
                    keyValuePairsDic = new Dictionary<int, FreqItem>(capacity);
                    sortedPairsDic = new SortedDictionary<FreqItem, int>(Comparer<FreqItem>.Create((item1, item2) =>
                    {
                        if (item1.freq == item2.freq) return item1.timestamp.CompareTo(item2.timestamp);
                        return item1.freq.CompareTo(item2.freq);
                    }));
                    timestamp = 0;
                }

                public int Get(int key)
                {
                    if (_capacity == 0) return -1;
                    if (keyValuePairsDic.ContainsKey(key))
                    {
                        var item = UpdateFreqItem(key, null);

                        return item.value;
                    }

                    return -1;
                }

                private FreqItem UpdateFreqItem(int key, int? value)
                {
                    var item = keyValuePairsDic[key];
                    keyValuePairsDic.Remove(key);
                    sortedPairsDic.Remove(item);

                    item.freq++;
                    item.timestamp = timestamp++;
                    if (value.HasValue) item.value = value.Value;

                    keyValuePairsDic.Add(key, item);
                    sortedPairsDic.Add(item, key);
                    return item;
                }

                public void Put(int key, int value)
                {
                    if (_capacity == 0) return;
                    if (keyValuePairsDic.ContainsKey(key))
                    {
                        UpdateFreqItem(key, value);
                    }
                    else
                    {
                        if (keyValuePairsDic.Count >= _capacity)
                        {
                            var minKey = sortedPairsDic.Keys.Min();
                            var removedItem = sortedPairsDic[minKey];
                            sortedPairsDic.Remove(minKey);
                            keyValuePairsDic.Remove(removedItem);
                        }
                        var item = new FreqItem { key = key, value = value, timestamp = timestamp++, freq = 1 };
                        sortedPairsDic.Add(item, key);
                        keyValuePairsDic.Add(key, item);
                    }
                }
            }

            public IList<IList<int>> VerticalTraversal(TreeNode root)
            {
                var dic = new Dictionary<int, List<(int nodeValue, int horizLevel)>>();
                int min = 0, max = 0;

                VerticalTraversalRec(root, 0, 0, ref min, ref max, ref dic);

                var lst = new List<IList<int>>();
                if (min == max)
                {
                    AddLevel(dic, min, lst);
                }
                else
                {
                    for (int i = min; i <= max; i++)
                    {
                        AddLevel(dic, i, lst);
                    }
                }
                return lst;
            }

            private static void AddLevel(Dictionary<int, List<(int nodeValue, int horizLevel)>> dic, int i, List<IList<int>> lst)
            {
                dic[i].Sort(Comparer<(int nodeValue, int horizLevel)>.Create((t1, t2) =>
                {
                    if (t1.horizLevel == t2.horizLevel) return t1.nodeValue - t2.nodeValue;
                    else return t1.horizLevel.CompareTo(t2.horizLevel);
                }));
                lst.Add(dic[i].Select(x => x.nodeValue).ToList());
            }

            private void VerticalTraversalRec(TreeNode node, int horizLevel, int order, ref int min, ref int max, ref Dictionary<int, List<(int nodeValue, int horizLevel)>> dic)
            {
                if (node == null) return;

                if (min > order) min = order;
                if (max < order) max = order;

                if (dic.ContainsKey(order)) dic[order].Add((node.val, horizLevel));
                else dic.Add(order, new List<(int nodeValue, int horizLevel)> { (node.val, horizLevel) });

                VerticalTraversalRec(node.left, horizLevel + 1, order - 1, ref min, ref max, ref dic);
                VerticalTraversalRec(node.right, horizLevel + 1, order + 1, ref min, ref max, ref dic);
            }

            public bool ReachingPoints(int sx, int sy, int tx, int ty)
            {
                while (tx > 0 && ty > 0)
                {
                    if (sx == tx && sy == ty) return true;
                    if (tx - ty > 0)
                    {
                        tx -= ty;
                    }
                    else ty -= tx;
                }

                return false;
            }

            public int LeastInterval(char[] tasks, int n)
            {
                if (n == 0) return tasks.Length;

                var tasksCountDic = new Dictionary<char, int>();
                for (int i = 0; i < tasks.Length; i++)
                {
                    if (tasksCountDic.ContainsKey(tasks[i]))
                    {
                        tasksCountDic[tasks[i]]++;
                    }
                    else tasksCountDic.Add(tasks[i], 1);
                }

                var processingQueue = new Deque<(char name, int count)>();

                foreach (var task in tasksCountDic.OrderBy(x => x.Value))
                {
                    processingQueue.AddToFront((task.Key, task.Value));
                }

                var nextAvailableTasksDic = new Dictionary<int, (char name, int count)>();

                int time = 0;
                while (processingQueue.Count > 0 || nextAvailableTasksDic.Keys.Count > 0)
                {
                    ++time;
                    if (nextAvailableTasksDic.ContainsKey(time))
                    {
                        processingQueue.AddToFront(nextAvailableTasksDic[time]);
                        nextAvailableTasksDic.Remove(time);
                    }

                    if (processingQueue.Count > 0)
                    {
                        var task = processingQueue.RemoveFromFront();
                        task.count--;
                        if (task.count > 0)
                        {
                            nextAvailableTasksDic.Add(time + n + 1, task);
                        }
                    }
                }

                return time;
            }

            public bool CheckPalindromeFormation(string a, string b)
            {
                if (IsPalindrome(a) || IsPalindrome(b)) return true;

                for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
                {
                    int j = 0;
                    bool isPalindrome = true;
                    while (j <= i)
                    {
                        if (a[j] != b[b.Length - j - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                        j++;
                    }

                    if (isPalindrome) return true;

                    j = 0;
                    isPalindrome = true;
                    while (j < i + 1)
                    {
                        if (b[j] != a[a.Length - j - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                        j++;
                    }

                    if (isPalindrome) return true;
                }

                return false;
            }

            public bool IsPalindrome(string s)
            {
                if (string.IsNullOrEmpty(s)) return true;
                var n = s.Length;
                for (int i = 0; i < Math.Ceiling(n / 2.0); i++)
                {
                    if (s[i] != s[n - i - 1]) return false;
                }
                return true;
            }

            class Edge
            {
                public int start;
                public int end;
            }

            public int MaximalNetworkRank(int n, int[][] roads)
            {
                if (n < 2) return 0;
                var v = new List<List<Edge>>(n);
                for (int i = 0; i < n; i++)
                {
                    v.Add(new List<Edge>());
                }

                foreach (var road in roads)
                {
                    var edge = new Edge { end = road[1], start = road[0] };
                    v[road[0]].Add(edge);
                    v[road[1]].Add(edge);
                }

                v = v.OrderByDescending(x => x.Count).ToList();

                int max = 0;
                var hs = new Dictionary<Edge, int>();

                for (int j = 0; j < v.Count; j++)
                {
                    hs.Clear();
                    foreach (var edge in v[j])
                    {
                        hs.Add(edge, 1);
                    }

                    for (int i = j + 1; i < v.Count; i++)
                    {
                        foreach (var edge in v[i])
                        {
                            if (!hs.ContainsKey(edge)) hs.Add(edge, 1);
                            else hs[edge]++;
                        }
                        max = Math.Max(max, hs.Keys.Count);
                        foreach (var edge in v[i])
                        {
                            hs[edge]--;
                            if (hs[edge] == 0) hs.Remove(edge);
                        }
                    }
                }

                return max;
            }

            public int MaxDepth(string s)
            {
                if (string.IsNullOrEmpty(s)) return 0;

                var st = new Stack<char>();
                int maxDepth = 0, depth = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case '(':
                            st.Push('(');
                            maxDepth = Math.Max(maxDepth, st.Count);
                            break;
                        case ')':
                            st.Pop();
                            //depth++;
                            //if (st.Count == 0)
                            //{
                            //    depth = 0;
                            //}
                            break;
                        default:
                            break;
                    }
                }

                return maxDepth;
            }

            public bool ReachingPoints1(int sx, int sy, int tx, int ty)
            {
                if (sx > tx || sy > ty) return false;

                var dp = new Dictionary<(int, int), bool>();

                return ReachingPointsRec(sx, sy, tx, ty, ref dp);
            }

            private bool ReachingPointsRec(in int sx, in int sy, in int tx, in int ty, ref Dictionary<(int, int), bool> dp)
            {
                if (sx > tx || sy > ty) return false;
                if (sx == tx && sy == ty)
                {
                    UpdateDP(sx, sy, dp, true);
                }
                if (dp.ContainsKey((sx, sy))) return dp[(sx, sy)];

                var option1 = ReachingPointsRec(sx + sy, sy, tx, ty, ref dp);
                if (option1)
                {
                    UpdateDP(sx, sy, dp, true);
                }
                else
                {
                    var option2 = ReachingPointsRec(sx, sx + sy, tx, ty, ref dp);
                    UpdateDP(sx, sy, dp, option2);
                }
                return dp[(sx, sy)];
            }

            private static void UpdateDP(int sx, int sy, Dictionary<(int, int), bool> dp, bool val)
            {
                if (dp.ContainsKey((sx, sy)))
                {
                    dp[(sx, sy)] = val;
                }
                else dp.Add((sx, sy), val);
            }

            public int execCount = 0;

            public int LongestValidParentheses(string s)
            {
                var st = new Stack<(char ch, int idx)>();

                int idx, max = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case '(':
                            st.Push(('(', i));
                            break;
                        case ')':
                            if (st.Count > 0 && st.Peek().ch == '(')
                            {
                                st.Pop();
                                idx = st.Count == 0 ? -1 : st.Peek().idx;
                                max = Math.Max(max, i - idx);
                            }
                            else
                            {
                                st.Push((')', i));
                            }
                            break;
                    }
                }

                idx = st.Count == 0 ? -1 : st.Peek().idx;
                max = Math.Max(max, s.Length - 1 - idx);

                return max;
            }

            public int LongestValidParentheses1(string s)
            {
                var n = s.Length;
                var dp = new int?[n + 1, n + 1];
                LongestValidParenthesesRec(s, 0, 0, 0, ref dp);

                return dp[0, 0] ?? 0;
            }

            private int LongestValidParenthesesRec(string s, int i, int open, int close, ref int?[,] dp)
            {
                int count = open - close;

                if (count < 0) return 0;

                if (count == 0 && open > 0)
                {
                    dp[i, count] = Math.Max(dp[i, count] ?? 0, open * 2);
                }

                if (i == s.Length) return dp[i, count] ?? 0;

                //if (dp[i, count].HasValue) return dp[i, count].Value;

                int option1 = 0;
                switch (s[i])
                {
                    case '(':
                        option1 = LongestValidParenthesesRec(s, i + 1, open + 1, close, ref dp);
                        break;
                    case ')':
                        option1 = LongestValidParenthesesRec(s, i + 1, open, close + 1, ref dp);
                        break;
                }
                var option2 = LongestValidParenthesesRec(s, i + 1, 0, 0, ref dp);

                dp[i, count] = Math.Max(dp[i, count] ?? 0, Math.Max(option1, option2));

                return dp[i, count] ?? 0;
            }

            //private int LongestValidParenthesesRec(string s, int i, int open, int close, ref int?[,] dp, ref int max)
            //{
            //    int count = open - close;
            //    if (count < 0) return 0;

            //    if (count == 0)
            //    {
            //        max = Math.Max(max, open * 2);
            //        dp[i, count] = open * 2;
            //    }

            //    if (dp[i, count].HasValue) return dp[i, count].Value;
            //    if (i == s.Length) return dp[i, count] ?? 0;

            //    int value = 0;
            //    for (int j = i; j <= s.Length; j++)
            //    {
            //        switch (s[i])
            //        {
            //            case '(':
            //                value = Math.Max(value,
            //                    LongestValidParenthesesRec(s, i + 1, j == i ? (open + 1) : 0, j == i ? close : 0,
            //                        ref dp, ref max));
            //                break;
            //            case ')':
            //                value = Math.Max(value,
            //                    LongestValidParenthesesRec(s, i + 1, j == i ? open : 0, j == i ? (close + 1) : 0,
            //                        ref dp, ref max));
            //                break;
            //        }
            //        //LongestValidParenthesesRec(s, i + 1, 0, 0, ref dp, ref max);
            //    }

            //    dp[i, count] = value;

            //    return dp[i, count].Value;
            //}

            public int maxCoins(int[] iNums)
            {
                int[] nums = new int[iNums.Length + 2];
                int n = 1;
                foreach (int x in iNums) if (x > 0) nums[n++] = x;
                nums[0] = nums[n++] = 1;


                int[,] memo = new int[n, n];
                return burst(memo, nums, 0, n - 1);
            }

            public int burst(int[,] memo, int[] nums, int left, int right)
            {
                execCount++;
                Console.WriteLine($"Left: {left}, Right: {right}");
                if (left + 1 == right) return 0;
                if (memo[left, right] > 0)
                {
                    Console.WriteLine($"Left: {left}, Right: {right}, Memo: {memo[left, right]}");
                    return memo[left, right];
                }
                int ans = 0;
                for (int i = left + 1; i < right; ++i)
                {
                    ans = Math.Max(ans, nums[left] * nums[i] * nums[right]
                                     + burst(memo, nums, left, i) + burst(memo, nums, i, right));
                    Console.WriteLine();
                }
                memo[left, right] = ans;
                return ans;
            }

            public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
            {
                //return (Math.Max(C, G) - Math.Min(A, E)) * (Math.Max(H, D) - Math.Min(B, F)); 

                int intersection = 0;
                if (!(C <= E || G <= A || B <= H || D <= F))
                {
                    intersection = ((Math.Min(C, G) - Math.Max(A, E)) * (Math.Min(D, H) - Math.Max(B, F)));
                }
                return ((C - A) * (D - B)) + ((G - E) * (H - F)) - (intersection > 0 ? intersection : 0);
            }

            public IList<int> PartitionLabels(string S)
            {
                var startPos = new int[26];
                var endPos = new int[26];

                for (int i = 0; i < 26; i++)
                {
                    startPos[i] = endPos[i] = -1;
                }

                for (int i = 0; i < S.Length; i++)
                {
                    if (startPos[S[i] - 'a'] == -1) startPos[S[i] - 'a'] = i;
                    endPos[S[i] - 'a'] = i;
                }

                var lst = new List<int>();
                int prevSize = 0;
                for (int i = 0; i < S.Length; i++)
                {
                    int maxWidth = endPos[S[i] - 'a'];
                    for (int j = i + 1; j <= maxWidth; j++)
                    {
                        maxWidth = Math.Max(maxWidth, endPos[S[j] - 'a']);
                    }

                    lst.Add(maxWidth + 1 - prevSize);
                    prevSize = maxWidth + 1;
                    i = maxWidth;
                }

                return lst;
            }

            public bool IsRectangleOverlap(int[] rec1, int[] rec2)
            {
                int x11 = rec1[0], y11 = rec1[1], x12 = rec1[2], y12 = rec1[3];
                int x21 = rec2[0], y21 = rec2[1], x22 = rec2[2], y22 = rec2[3];

                return !(x12 <= x21 ||   // left
                         y12 <= y21 ||   // bottom
                         x11 >= x22 ||   // right
                         y11 >= y22);    // top
            }

            public class FirstUnique
            {
                class ItemFreqComparer : IEqualityComparer<ItemFrequency>
                {
                    public bool Equals(ItemFrequency f1, ItemFrequency f2)
                    {
                        return f1.val.Equals(f2.val);
                    }

                    public int GetHashCode(ItemFrequency obj)
                    {
                        return obj.val.GetHashCode();
                    }
                }

                class ItemFrequency
                {
                    public int val;
                    public int freq;
                    public bool isDeleted;
                }

                private HashSet<ItemFrequency> hs = new HashSet<ItemFrequency>(new ItemFreqComparer());
                Dictionary<int, ItemFrequency> freqDic = new Dictionary<int, ItemFrequency>();

                public FirstUnique(int[] nums)
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        AddToDic(nums[i]);
                    }
                }

                private void AddToDic(int num)
                {
                    if (freqDic.ContainsKey(num))
                    {
                        freqDic[num].isDeleted = true;
                        freqDic[num].freq++;
                    }
                    else
                    {
                        var item = new ItemFrequency { val = num, freq = 1 };
                        hs.Add(item);
                        freqDic.Add(num, item);
                    }
                }

                public int ShowFirstUnique()
                {
                    if (hs.Count > 0)
                    {
                        int lastIdx = 0;
                        while (lastIdx < hs.Count && hs.ElementAt(lastIdx).isDeleted)
                            lastIdx++;
                        return lastIdx < hs.Count ? hs.ElementAt(lastIdx).val : -1;
                    }
                    return -1;
                }

                public void Add(int value)
                {
                    AddToDic(value);
                }
            }


            public class RLEIterator
            {
                private readonly int[] _arr;
                int _lastIdx = 0;

                public RLEIterator(int[] A)
                {
                    this._arr = A;
                }

                public int Next(int n)
                {
                    if (_lastIdx >= _arr.Length) return -1;

                    var res = -1;
                    while (_lastIdx < _arr.Length && n > 0)
                    {
                        var tempN = n;
                        n = this._arr[_lastIdx] <= n ? n - this._arr[_lastIdx] : 0;
                        this._arr[_lastIdx] = this._arr[_lastIdx] <= tempN ? 0 : (this._arr[_lastIdx] - tempN);
                        if (n == 0)
                        {
                            res = _lastIdx + 1 < _arr.Length ? _arr[_lastIdx + 1] : -1;
                        }

                        if (this._arr[_lastIdx] == 0)
                        {
                            _lastIdx += 2;
                        }
                    }

                    return n == 0 ? res : -1;
                }
            }

            public class RLE
            {
                public string key;
                public List<int> counts = new List<int>();

                public RLE(string s)
                {
                    var sb = new StringBuilder(s.Length);

                    int lastDiffCharIdx = -1;

                    for (int i = 0; i < s.Length; i++)
                    {
                        if (i == s.Length - 1 || s[i] != s[i + 1])
                        {
                            sb.Append(s[i]);
                            counts.Add(i - lastDiffCharIdx);
                            lastDiffCharIdx = i;
                        }
                    }

                    key = sb.ToString();
                }
            }

            public int ExpressiveWords(string S, string[] words)
            {
                if (string.IsNullOrEmpty(S)) return 0;
                var sRle = new RLE(S);

                int match = 0;
                foreach (var word in words)
                {
                    var wRle = new RLE(word);

                    if (wRle.key == sRle.key)
                    {
                        var isValid = true;
                        for (int i = 0; i < sRle.key.Length; i++)
                        {
                            if (sRle.counts[i] < 3 && sRle.counts[i] != wRle.counts[i] || sRle.counts[i] < wRle.counts[i])
                            {
                                isValid = false;
                                break;
                            }
                        }
                        if (isValid) match++;
                    }
                }

                return match;
            }

            //public int ExpressiveWords(string S, string[] words)
            //{
            //    char groupCh = '\0';
            //    int groupChCount = 0;

            //    int[] sOccurrences = new int[S.Length];
            //    sOccurrences[0] = 1;
            //    for (int i = 1; i < S.Length; i++)
            //    {
            //        if (S[i] == S[i - 1])
            //        {
            //            sOccurrences[i] = sOccurrences[i - 1] + 1;
            //        }
            //        else sOccurrences[i] = 1;
            //    }

            //    foreach (var word in words)
            //    {
            //        int wOccurrence = 1;
            //        int wIdx = 0;
            //        for (int i = 0; i < S.Length; i++)
            //        {
            //            if (S[i] != word[wIdx])
            //            {
            //                if (wIdx == 0 || i == 0 || S[i] != S[i - 1]) break;

            //            }
            //            else
            //            {
            //                wIdx++;
            //            }
            //        }
            //    }
            //}

            public IList<string> RemoveInvalidParentheses(string s)
            {
                if (string.IsNullOrEmpty(s)) return new List<string> { "" };

                var lst = new HashSet<string>();
                var st = new StringBuilder();
                RemoveInvalidParenthesesRec(s, 0, 0, 0, ref st, ref lst);
                return lst.ToList();
            }

            private void RemoveInvalidParenthesesRec(string s, int i, int openCount, int closeCount, ref StringBuilder st, ref HashSet<string> lst)
            {
                if (closeCount > openCount) return;
                if (i == s.Length)
                {
                    if (openCount == closeCount)
                    {
                        if (lst.Count == 0 || lst.ElementAt(0).Length == st.Length)
                        {
                            lst.Add(st.ToString());
                        }
                    }
                    return;
                }

                if (!new[] { '(', ')' }.Contains(s[i]))
                {
                    st.Append(s[i]);
                    RemoveInvalidParenthesesRec(s, i + 1, openCount, closeCount, ref st, ref lst);
                    st.Length--;
                }
                else
                {
                    var isOpenParentheses = s[i] == '(';
                    st.Append(s[i]);
                    RemoveInvalidParenthesesRec(s, i + 1, isOpenParentheses ? openCount + 1 : openCount,
                        isOpenParentheses ? closeCount : closeCount + 1, ref st, ref lst);
                    st.Length--;

                    RemoveInvalidParenthesesRec(s, i + 1, openCount, closeCount, ref st, ref lst);
                }
            }

            enum Direction
            {
                Initial,
                Left,
                Right,
                Up,
                Down
            }

            public int ShortestDistance(int[][] maze, int[] start, int[] destination)
            {
                int min = int.MaxValue;

                if (start[0] == destination[0] && start[1] == destination[1])
                {
                    return 0;
                }
                ShortestDistanceRec(ref maze, Direction.Initial, 0, start[0], start[1], destination[0], destination[1],
                    ref min);

                return min == Int32.MaxValue ? -1 : (min - 1);
            }

            private void ShortestDistanceRec(ref int[][] maze, Direction direction, int count, int startI, int startJ, int endI, int endJ, ref int min)
            {
                if (!IsValid(ref maze, startI, startJ)) return;

                maze[startI][startJ] = 2;
                count++;

                switch (direction)
                {
                    case Direction.Initial:
                        if (IsValid(ref maze, startI, startJ - 1))
                        {
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI, startJ - 1, endI, endJ,
                                ref min);
                            maze[startI][startJ] = 0;
                        }
                        if (IsValid(ref maze, startI, startJ + 1))
                        {
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI, startJ + 1, endI, endJ,
                                ref min);
                            maze[startI][startJ] = 0;
                        }
                        if (IsValid(ref maze, startI - 1, startJ))
                        {
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI - 1, startJ, endI, endJ,
                                ref min);
                            maze[startI][startJ] = 0;
                        }
                        if (IsValid(ref maze, startI + 1, startJ))
                        {
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI + 1, startJ, endI, endJ,
                                ref min);
                            maze[startI][startJ] = 0;
                        }
                        break;
                    case Direction.Left:
                        if (IsValid(ref maze, startI, startJ - 1))
                        {
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI, startJ - 1, endI, endJ,
                                ref min);
                            maze[startI][startJ] = 0;
                        }
                        else
                        {

                            if (startI == endI && startJ == endJ)
                            {
                                min = Math.Min(min, count);
                                return;
                            }
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI, startJ, endI, endJ,
                                ref min);
                        }
                        break;
                    case Direction.Right:
                        if (IsValid(ref maze, startI, startJ + 1))
                        {
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI, startJ + 1, endI, endJ,
                                ref min);
                            maze[startI][startJ] = 0;
                        }
                        else
                        {
                            if (startI == endI && startJ == endJ)
                            {
                                min = Math.Min(min, count);
                                return;
                            }
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI, startJ, endI, endJ,
                                ref min);
                        }
                        break;
                    case Direction.Up:
                        if (IsValid(ref maze, startI - 1, startJ))
                        {
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI - 1, startJ, endI, endJ,
                                ref min);
                            maze[startI][startJ] = 0;
                        }
                        else
                        {
                            if (startI == endI && startJ == endJ)
                            {
                                min = Math.Min(min, count);
                                return;
                            }
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI, startJ, endI, endJ,
                                ref min);
                        }
                        break;
                    case Direction.Down:
                        if (IsValid(ref maze, startI + 1, startJ))
                        {
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI + 1, startJ + 1, endI, endJ,
                                ref min);
                            maze[startI][startJ] = 0;
                        }
                        else
                        {
                            if (startI == endI && startJ == endJ)
                            {
                                min = Math.Min(min, count);
                                return;
                            }
                            ShortestDistanceRec(ref maze, Direction.Initial, count, startI, startJ, endI, endJ,
                                ref min);
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
                }

                //maze[startI][startJ] = 0;

            }

            private bool IsValid(ref int[][] maze, int startI, int startJ)
            {
                if (startI < 0 || startI >= maze.Length || startJ < 0 || startJ >= maze[startI].Length) return false;

                if (maze[startI][startJ] != 0) return false;
                return true;
            }


            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                var dic = new Dictionary<string, List<string>>();
                var lst = new List<IList<string>>();

                foreach (var str in strs)
                {
                    var anagramCode = CalcAnagram(str);

                    if (dic.ContainsKey(anagramCode))
                    {
                        dic[anagramCode].Add(str);
                    }
                    else dic.Add(anagramCode, new List<string> { str });
                }

                foreach (var kv in dic)
                {
                    lst.Add(kv.Value);
                }

                return lst;
            }

            private string CalcAnagram(string str)
            {
                int[] occurrences = new int[26];
                for (int i = 0; i < str.Length; i++)
                {
                    occurrences[str[i] - 'a']++;
                }

                var sb = new StringBuilder(26);
                for (int i = 0; i < 26; i++)
                {
                    sb.Append(occurrences[i] + '|');
                }

                return sb.ToString();
            }

            public bool IsValid(string s)
            {
                if (string.IsNullOrEmpty(s)) return true;

                var dic = new Dictionary<char, char>
                {
                    {'{', '}'},
                    {'(', ')'},
                    {'[', ']'},
                };

                var st = new Stack<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    if (dic.ContainsKey(s[i]))
                    {
                        st.Push(s[i]);
                    }
                    else
                    {
                        if (st.Count == 0 || dic[st.Pop()] != s[i]) return false;
                    }
                }

                return st.Count == 0;
            }

            //public int MinimumOneBitOperations(int n)
            //{
            //    var binary = new StringBuilder(Convert.ToString(n, 2));

            //    var minOps = 0;
            //    for (int i = 0; i < binary.Length; i++)
            //    {
            //        if(binary[i] == '0') continue;

            //        if (i == 0) minOps++;
            //        if(i - 1 > 0)
            //    }
            //}

            public bool IsEvenOddTree(TreeNode root)
            {
                if (root == null) return false;

                var q = new Queue<TreeNode>();
                q.Enqueue(root);
                q.Enqueue(null);

                int levels = 0, prev = 0;
                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    if (node == null)
                    {
                        levels++;

                        if (q.Count > 0)
                        {
                            q.Enqueue(null);
                            prev = levels % 2 == 1 ? int.MaxValue : 0;
                        }
                    }
                    else
                    {
                        var isEvenLevel = levels % 2 == 0;
                        var isOddNodeValue = node.val % 2 == 1;
                        if ((isEvenLevel && node.val <= prev)) return false;
                        if ((!isEvenLevel && node.val >= prev)) return false;
                        if ((isEvenLevel && !isOddNodeValue) || (!isEvenLevel && isOddNodeValue)) return false;
                        if (node.left != null) q.Enqueue(node.left);
                        if (node.right != null) q.Enqueue(node.right);
                        prev = node.val;
                    }
                }

                return true;
            }

            public static int first(int[] arr, int low,
                int high, int x)
            {
                if (high >= low)
                {
                    int mid = low + (high - low) / 2;

                    if ((mid == 0 || x > arr[mid - 1])
                        && arr[mid] == x)
                        return mid;
                    else if (x > arr[mid])
                        return first(arr, (mid + 1),
                            high, x);
                    else
                        return first(arr, low,
                            (mid - 1), x);
                }

                return Array.BinarySearch(arr, x);
            }

            public int SpecialArray(int[] nums)
            {
                if (nums == null || nums.Length == 0) return -1;
                Array.Sort(nums);

                for (int i = 1; i <= 100; i++)
                {
                    var idx = first(nums, 0, nums.Length, i);

                    if (idx < 0) idx = ~idx;

                    if (nums.Length - idx == i) return i;
                }

                return -1;
            }

            public class Trie
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

                class TrieNode1
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

                private HashSet<TrieNode1> roots;

                /** Initialize your data structure here. */
                public Trie()
                {
                    roots = new HashSet<TrieNode1>(new TrieNode1EqualityComparer());
                }

                /** Inserts a word into the trie. */
                public void Insert(string word)
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
                    var root = roots;
                    for (int i = 0; i < word.Length; i++)
                    {
                        var trieNode = new TrieNode1(word[i]);
                        if (root.TryGetValue(trieNode, out var foundTrie))
                        {
                            if (i == word.Length - 1 && foundTrie.word != null) return true;
                            root = foundTrie.children;
                        }
                        else
                        {
                            return false;
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

            public IList<IList<int>> Permute(int[] nums)
            {
                var lst = new List<IList<int>>();

                PermuteRec(ref nums, 0, ref lst);

                return lst;
            }

            private void PermuteRec(ref int[] nums, int i, ref List<IList<int>> lst)
            {
                if (i == nums.Length)
                {
                    lst.Add(new List<int>(nums));
                    return;
                }

                for (int j = i; j < nums.Length; j++)
                {
                    var temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;

                    PermuteRec(ref nums, i + 1, ref lst);

                    temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }

            public bool Find132pattern(int[] nums)
            {
                if (nums == null || nums.Length < 3) return false;
                int minI = int.MaxValue;
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    minI = Math.Min(minI, nums[j]);
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[k] < nums[j] && minI < nums[k]) return true;
                    }
                }

                return false;
            }

            public bool Find132pattern1(int[] nums)
            {
                if (nums == null || nums.Length < 3) return false;
                var arrSorted = nums.OrderBy(n => n).ToArray();
                var dic = new Dictionary<int, HashSet<int>>();
                int k = 0;
                for (; k < nums.Length; k++)
                {
                    if (dic.ContainsKey(nums[k])) dic[nums[k]].Add(k);
                    else
                    {
                        var lst = new HashSet<int>();
                        lst.Add(k);
                        dic.Add(nums[k], lst);
                    }
                }

                for (int i = 0; i < nums.Length - 2; i++)
                {
                    var idx = Array.BinarySearch(arrSorted, 0, arrSorted.Length, nums[i]);
                    if (idx < 0) idx = ~idx;
                    for (k = idx + 1; k < arrSorted.Length; k++)
                    {
                        foreach (var i1 in dic[arrSorted[k]])
                        {
                            if (i1 > i && nums[i1] > nums[i])
                            {
                                for (int j = i + 1; j < i1; j++)
                                {
                                    if (nums[i1] < nums[j]) return true;
                                }
                            }
                        }
                    }
                }

                return false;
            }

            public int TwoSumLessThanK(int[] A, int K)
            {
                Array.Sort(A);

                int i = 0, j = A.Length - 1;

                int max = int.MinValue;
                while (i < j)
                {
                    if (A[i] + A[j] < K)
                    {
                        max = Math.Max(max, A[i] + A[j]);
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }

                return max == int.MinValue ? -1 : max;
            }

            public int SumEvenGrandparent(TreeNode root)
            {
                if (root == null) return 0;
                var total = 0;
                var q = new Queue<(TreeNode parent, TreeNode node)>();
                q.Enqueue((null, root));

                while (q.Count > 0)
                {
                    var pair = q.Dequeue();

                    var isGrandParentEven = pair.parent != null && pair.parent.val % 2 == 0;

                    if (pair.node.left != null)
                    {
                        q.Enqueue((pair.node, pair.node.left));
                        if (isGrandParentEven)
                        {
                            total += pair.node.left.val;
                        }
                    }

                    if (pair.node.right != null)
                    {
                        q.Enqueue((pair.node, pair.node.right));
                        if (isGrandParentEven)
                        {
                            total += pair.node.right.val;
                        }
                    }

                }

                return total;
            }

            public string[] ReorderLogFiles(string[] logs)
            {
                if (logs == null || logs.Length == 0) return logs;

                return logs.OrderBy(s => s, Comparer<string>.Create(new Comparison<string>((log1, log2) =>
                {
                    var parts1 = log1.Split(" ", 2);
                    var parts2 = log2.Split(" ", 2);

                    var firstChar1 = parts1[1][0];
                    var firstChar2 = parts2[1][0];
                    var isFirstANumber = firstChar1 >= '0' && firstChar1 <= '9';
                    var isSecondANumber = firstChar2 >= '0' && firstChar2 <= '9';
                    if (isFirstANumber && isSecondANumber)
                    {
                        return -1;
                    }
                    else if (isFirstANumber || isSecondANumber)
                    {
                        if (isFirstANumber) return 1;
                        else return -1;
                    }
                    else
                    {
                        if (parts1[1].CompareTo(parts2[1]) == 0) return parts1[0].CompareTo(parts2[0]);
                        return parts1[1].CompareTo(parts2[1]);
                    }
                }))).ToArray();
            }

            public int SingleNonDuplicate(int[] nums)
            {
                int low = 0, high = nums.Length;

                while (low < high)
                {
                    var mid = low + (high - low) / 2;

                    if (mid > 0 && nums[mid] == nums[mid - 1])
                    {
                        if (mid % 2 == 0)
                            high = mid;
                        else low = mid + 1;
                    }
                    else if (mid + 1 < nums.Length && nums[mid] == nums[mid + 1])
                    {
                        if (mid % 2 == 1)
                            high = mid;
                        else low = mid + 1;
                    }
                    else
                    {
                        return nums[mid];
                    }
                }

                return -1;
            }

            public IList<IList<int>> LevelOrder(TreeNode root)
            {
                if (root == null) return new List<IList<int>>();

                var q = new Queue<TreeNode>();
                q.Enqueue(root);
                q.Enqueue(null);
                var lst = new List<IList<int>>();
                var level = new List<int>();
                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    if (node == null)
                    {
                        if (q.Count > 0)
                            q.Enqueue(null);
                        lst.Add(new List<int>(level));
                        level.Clear();
                    }
                    else
                    {
                        level.Add(node.val);
                        if (node.left != null) q.Enqueue(node.left);
                        if (node.right != null) q.Enqueue(node.right);
                    }
                }

                return lst;
            }

            public int Search(int[] nums, int target)
            {
                int low = 0, high = nums.Length;

                while (low < high)
                {
                    var mid = low + (high - low) / 2;

                    if (nums[mid] == target) return mid;

                    if (nums[mid] > nums[low])
                    {
                        if (target >= nums[low] && target < nums[mid])
                        {
                            high = mid;
                        }
                        else low = mid + 1;
                    }
                    else
                    {
                        if (target > nums[mid] && target <= nums[high - 1])
                        {
                            low = mid + 1;
                        }
                        else high = mid;
                    }
                }

                return -1;
            }

            public ListNode ReverseList(ListNode head)
            {
                ListNode node = head, prev = null;

                while (node != null)
                {
                    var temp = node.next;
                    node.next = prev;
                    prev = node;
                    node = temp;
                }

                return prev;
            }

            public int FirstUniqChar(string s)
            {
                if (string.IsNullOrEmpty(s)) return -1;

                var charOccurrences = new Dictionary<char, int>();

                for (int i = 0; i < s.Length; i++)
                {
                    var idx = s[i] - 'a';
                    if (charOccurrences.ContainsKey(s[i])) charOccurrences[s[i]] = -1;
                    else charOccurrences.Add(s[i], i);
                }

                foreach (var kv in charOccurrences)
                {
                    if (kv.Value >= 0) return kv.Value;
                }

                return -1;
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

                int level = 0, levelNodesCount = 1;
                Node prev = null;
                while (q.Count > 0)
                {
                    var node = q.Dequeue();
                    levelNodesCount--;
                    if (prev != null) prev.next = node;
                    prev = node;

                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);

                    if (levelNodesCount == 0)
                    {
                        prev = null;
                        level++;
                        levelNodesCount = (int)Math.Pow(2, level);
                    }
                }

                return root;
            }

            public int LengthOfLongestSubstring(string s)
            {
                if (string.IsNullOrEmpty(s)) return 0;

                var max = 1;
                var hs = new HashSet<char>();
                int left = 0, right = 0;
                hs.Add(s[left]);

                while (right < (s.Length - 1))
                {
                    right++;
                    if (hs.Contains(s[right]))
                    {
                        while (left < right && hs.Contains(s[right]))
                        {
                            hs.Remove(s[left]);
                            left++;
                        }
                    }
                    hs.Add(s[right]);
                    max = Math.Max(max, hs.Count);
                }

                return max;
            }

            public int MaximumRequests(int n, int[][] requests)
            {
                if (requests == null || requests.Length == 0) return 0;
                var dic = new Dictionary<(int src, int dest), int>();

                var total = 0;
                foreach (var request in requests)
                {
                    if (request[0] == request[1])
                    {
                        total++;
                        continue;
                    }

                    var key = (request[0], request[1]);
                    if (dic.ContainsKey(key)) dic[key]++;
                    else
                    {
                        dic.Add(key, 1);
                    }

                    var rev = (request[1], request[0]);
                    if (dic.ContainsKey(rev)) dic[rev]++;
                    else
                    {
                        dic.Add(rev, 1);
                    }
                }

                foreach (var request in requests)
                {
                    if (request[0] == request[1])
                    {
                        continue;
                    }

                    var key = (request[0], request[1]);
                    var rev = (request[1], request[0]);
                    var found = dic.TryGetValue(rev, out var val);
                    if (found && val > 0)
                    {
                        dic[key]--;
                        dic[rev]--;
                        total++;
                    }
                }

                return total;
            }

            public int MaximumRequests1(int n, int[][] requests)
            {
                if (requests == null || requests.Length == 0) return 0;
                int[] inDegrees = new int[n], outDegrees = new int[n];
                var total = 0;
                foreach (var request in requests)
                {
                    if (request[0] == request[1])
                    {
                        total++;
                        continue;
                    }
                    inDegrees[request[1]]++;
                    outDegrees[request[0]]++;
                }

                for (int i = 0; i < n; i++)
                {
                    total += inDegrees[i] <= outDegrees[i] ? inDegrees[i] : outDegrees[i];
                    //inDegrees[]
                }

                return total;
            }

            public class Building
            {
                public Building(int id)
                {
                    Id = id;
                }

                public int Id { get; set; }

                public int Vacant { get; set; } = 0;

                public List<Building> Moves { get; set; } = new List<Building>();
            }

            public int MaximumRequests2(int n, int[][] requests)
            {
                if (requests == null || requests.Length == 0) return 0;

                var blds = new List<Building>(n);
                for (int i = 0; i < n; i++)
                {
                    blds.Add(new Building(i));
                }

                var total = 0;


                foreach (var request in requests)
                {
                    if (request[0] == request[1])
                    {
                        total++;
                        continue;
                    }
                    var src = blds[request[0]];
                    var target = blds[request[1]];
                    if (target.Vacant > 0)
                    {
                        total++;
                        src.Vacant++;
                        target.Vacant--;
                    }
                    else
                    {
                        src.Moves.Add(target);
                    }
                }

                foreach (var src in blds)
                {
                    foreach (var dest in src.Moves)
                    {
                        if (dest.Vacant > 0)
                        {
                            total++;
                            src.Vacant++;
                            dest.Vacant--;
                        }
                    }
                }

                return total;
            }

            public int MinOperations(string[] logs)
            {
                if (logs == null || logs.Length == 0) return 0;

                var st = new Stack<string>();
                foreach (var log in logs)
                {
                    switch (log)
                    {
                        case "../":
                            if (st.Count > 0) st.Pop();
                            break;
                        case "./":
                            continue;
                            break;
                        default:
                            st.Push(log);
                            break;
                    }
                }

                return st.Count;
            }

            public bool ValidateStackSequences(int[] pushed, int[] popped)
            {
                int i = 0, j = 0;

                var st = new Stack<int>();

                while (i < pushed.Length || j < popped.Length)
                {
                    if (i < pushed.Length && pushed[i] == popped[j])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        if (j < popped.Length && st.Count > 0 && st.Peek() == popped[j])
                        {
                            st.Pop();
                            j++;
                        }
                        else if (i < pushed.Length) st.Push(pushed[i++]);
                        else return false;
                    }
                }

                return st.Count == 0;
            }

            public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
            {
                var map = new Dictionary<string, List<(int time, string website)>>();

                for (int i = 0; i < username.Length; i++)
                {
                    if (map.ContainsKey(username[i]))
                    {
                        map[username[i]].Add((timestamp[i], website[i]));
                        map[username[i]].Sort();
                    }
                    else
                    {
                        var ss = new List<(int time, string website)>();
                        ss.Add((timestamp[i], website[i]));
                        map.Add(username[i], ss);
                    }
                }

                var sequenceCountsMap = new Dictionary<string, int>();
                var resultSequence = "";
                int resultSequenceCount = 0;

                foreach (var kv in map)
                {
                    for (int i = 0; i < kv.Value.Count; i++)
                    {
                        for (int j = i + 1; j < kv.Value.Count; j++)
                        {
                            for (int k = j + 1; k < kv.Value.Count; k++)
                            {
                                var key = kv.Value.ElementAt(i).website + " " + kv.Value.ElementAt(j).website + " " +
                                          kv.Value.ElementAt(k).website;
                                if (sequenceCountsMap.ContainsKey(key))
                                {
                                    sequenceCountsMap[key]++;
                                }
                                else
                                {
                                    sequenceCountsMap.Add(key, 1);
                                }

                                if (resultSequence == "" || resultSequenceCount < sequenceCountsMap[key] ||
                                    (resultSequenceCount == sequenceCountsMap[key] &&
                                     resultSequence.CompareTo(key) > 0))
                                {
                                    resultSequence = key;
                                    resultSequenceCount = sequenceCountsMap[key];
                                }
                            }
                        }
                    }
                }

                return resultSequence == "" ? new List<string>() : resultSequence.Split(" ").ToList();
            }

            public int MaxUniqueSplit(string s)
            {
                var hs = new HashSet<string>();
                return MaxUniqueSplitHelper(s, ref hs);
            }

            private int MaxUniqueSplitHelper(string s, ref HashSet<string> hs)
            {
                int max = 0;
                for (int i = 1; i <= s.Length; i++)
                {
                    var subString = s.Substring(0, i);
                    if (!hs.Contains(subString))
                    {
                        hs.Add(subString);
                        max = Math.Max(max, 1 + MaxUniqueSplitHelper(s.Substring(i), ref hs));
                        hs.Remove(subString);
                    }
                }
                return max;
            }

            public int MaxProductPath(int[][] grid)
            {
                if (grid == null || grid.Length == 0 || grid[0].Length == 0) return -1;
                long max = int.MinValue;
                MaxProductPathRec(ref grid, 0, 0, 1, ref max);
                return max >= 0 ? (int)(max % (1e9 + 7)) : -1;
            }

            private void MaxProductPathRec(ref int[][] grid, int i, int j, long product, ref long max)
            {
                if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length) return;

                product *= grid[i][j];
                if (product == 0 || (i == grid.Length - 1 && j == grid[i].Length - 1))
                {
                    max = Math.Max(max, product);
                    return;
                }

                MaxProductPathRec(ref grid, i + 1, j, product, ref max);
                MaxProductPathRec(ref grid, i, j + 1, product, ref max);
            }

            public string ReorderSpaces(string text)
            {
                if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text)) return text;

                var foundChar = false;
                int wordsCount = 0, spacesCount = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (!foundChar && (text[i] >= 'a' && text[i] <= 'z'))
                    {
                        foundChar = true;
                        wordsCount++;
                    }

                    if (text[i] == ' ')
                    {
                        spacesCount++;
                        foundChar = false;
                    }
                }

                if (spacesCount == 0) return text;

                var spaceAppendCount = wordsCount > 1 ? spacesCount / (wordsCount - 1) : spacesCount;
                var sb = new StringBuilder(text.Length);
                var arr = text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    sb.Append(arr[i]);
                    if (i < arr.Length - 1)
                    {
                        sb.Append(' ', spaceAppendCount);
                    }
                }
                //var foundSpace = false;
                //foundChar = false;
                //for (int i = 0; i < text.Length; i++)
                //{
                //    if (text[i] != ' ')
                //    {
                //        foundSpace = false;
                //        foundChar = true;
                //        sb.Append(text[i]);
                //    }
                //    else if (foundChar && !foundSpace)
                //    {
                //        if(wordsCount > 0)
                //        foundSpace = true;
                //        sb.Append(' ', spaceAppendCount);
                //        wordsCount--;
                //    }
                //    else
                //    {
                //        foundSpace = true;
                //        foundChar = false;
                //    }
                //}

                if (wordsCount == 1 || spacesCount % (wordsCount - 1) != 0)
                {
                    sb.Append(' ', wordsCount == 1 ? spacesCount : spacesCount % (wordsCount - 1));
                }

                return sb.ToString();
            }

            //public class Trie
            //{
            //    private HashSet<GenericTreeNode<char>> roots;
            //    /** Initialize your data structure here. */
            //    public Trie(string[] arr)
            //    {
            //        roots = new HashSet<GenericTreeNode<char>>(new TreeNodeComparer<char>());

            //        foreach (var s in arr)
            //        {
            //            Insert(s);
            //        }
            //    }

            //    /** Inserts a word into the trie. */
            //    public void Insert(string word)
            //    {
            //        var nodes = roots;
            //        foreach (var ch in word)
            //        {
            //            var chNode = new GenericTreeNode<char>(ch);
            //            var hashSetNode = nodes.FirstOrDefault(n => n.val == ch);
            //            if (hashSetNode != null) //nodes.Contains(chNode)
            //            {
            //                nodes = hashSetNode.children;
            //            }
            //            else
            //            {
            //                nodes.Add(chNode);
            //                nodes = chNode.children;
            //            }
            //        }
            //        nodes.Add(new GenericTreeNode<char>());
            //    }

            //    /** Returns if the word is in the trie. */
            //    public bool Search(string word)
            //    {
            //        var nodes = roots;
            //        foreach (var ch in word)
            //        {
            //            var chNode = new GenericTreeNode<char>(ch);
            //            if (!nodes.Contains(chNode)) return false;
            //            var hashSetNode = nodes.First(n => n.val == ch);
            //            nodes = hashSetNode.children;
            //        }
            //        return nodes.Contains(new GenericTreeNode<char>());
            //    }

            //    /** Returns if there is any word in the trie that starts with the given prefix. */
            //    public bool StartsWith(string prefix)
            //    {
            //        var nodes = roots;
            //        foreach (var ch in prefix)
            //        {
            //            var chNode = new GenericTreeNode<char>(ch);
            //            if (!nodes.Contains(chNode)) return false;
            //            var hashSetNode = nodes.First(n => n.val == ch);
            //            nodes = hashSetNode.children;
            //        }
            //        return true;
            //    }

            //    public IList<string> Find(string searchWord)
            //    {
            //        var root = roots;
            //        string lastWord = null;
            //        for (int i = 0; i < searchWord.Length; i++)
            //        {
            //            var node = new GenericTreeNode<char>(searchWord[i]);
            //            if (root.TryGetValue(node, out node))
            //            {
            //                root = node.children;
            //                if (node.word != null)
            //                {
            //                    lastWord = node.word;
            //                }
            //            }
            //            else
            //            {
            //                return new List<string>();
            //            }
            //        }

            //        var res = new List<string>();
            //        if (lastWord != null)
            //        {
            //            res.Add(lastWord);
            //        }

            //        var st = new Stack<TrieNodeCh>(root);
            //        while (res.Count < 3)
            //        {
            //            if (st.Count == 0) break;
            //            var item = st.Pop();
            //            if (item.word != null)
            //            {
            //                res.Add(item.word);
            //            }
            //            foreach (var child in item.children)
            //            {
            //                st.Push(child);
            //            }
            //        }

            //        return res;
            //    }

            //    public class GenericTreeNode<T>
            //    {
            //        public T val;
            //        public HashSet<GenericTreeNode<T>> children;
            //        public GenericTreeNode(T val = default(T), HashSet<GenericTreeNode<T>> children = null)
            //        {
            //            this.val = val;
            //            this.children = children ?? new HashSet<GenericTreeNode<T>>(new TreeNodeComparer<T>());
            //        }
            //    }

            //    class TreeNodeComparer<T> : IEqualityComparer<GenericTreeNode<T>>
            //    {
            //        public bool Equals(GenericTreeNode<T> x, GenericTreeNode<T> y)
            //        {
            //            return x.val.Equals(y.val);
            //        }

            //        public int GetHashCode(GenericTreeNode<T> obj)
            //        {
            //            return obj.val.GetHashCode();
            //        }
            //    }

            //}

            //public class Trie
            //{
            //    SortedSet<TrieNodeCh> lst = new SortedSet<TrieNodeCh>(new TrieNodeSetComparer());

            //    public Trie(string[] arr)
            //    {
            //        foreach (var s in arr)
            //        {
            //            var root = lst;
            //            TrieNodeCh node = null;
            //            foreach (var ch in s)
            //            {
            //                node = new TrieNodeCh(ch);
            //                if (root.TryGetValue(node, out var node2))
            //                {
            //                    root = node2.children;
            //                    node = node2;
            //                }
            //                else
            //                {
            //                    root.Add(node);
            //                    root = node.children;
            //                }
            //            }
            //            node.word = s;
            //        }
            //    }

            //    public IList<string> Find(string searchWord)
            //    {
            //        var root = lst;
            //        string lastWord = null;
            //        for (int i = 0; i < searchWord.Length; i++)
            //        {
            //            var node = new TrieNodeCh(searchWord[i]);
            //            if (root.TryGetValue(node, out node))
            //            {
            //                root = node.children;
            //                if (node.word != null)
            //                {
            //                    lastWord = node.word;
            //                }
            //            }
            //            else
            //            {
            //                return new List<string>();
            //            }
            //        }

            //        var res = new List<string>();
            //        if (lastWord != null)
            //        {
            //            res.Add(lastWord);
            //        }

            //        var st = new Stack<TrieNodeCh>(root);
            //        while (res.Count < 3)
            //        {
            //            if (st.Count == 0) break;
            //            var item = st.Pop();
            //            if (item.word != null)
            //            {
            //                res.Add(item.word);
            //            }
            //            foreach (var child in item.children)
            //            {
            //                st.Push(child);
            //            }
            //        }

            //        return res;
            //    }
            //}

            //public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
            //{
            //    var trie = new Trie(products);

            //    var lst = new List<IList<string>>();
            //    for (int i = 0; i < searchWord.Length; i++)
            //    {
            //        lst.Add(trie.Search(searchWord.Substring(0, i + 1)));
            //    }

            //    return lst;
            //}

            public IList<int> BoundaryOfBinaryTree(TreeNode root)
            {
                if (root == null) return new List<int>();

                var left = new HashSet<TreeNode>();
                var node = root;
                while (node != null)
                {
                    left.Add(node);
                    if (node != root && node.left == null && node.right != null)
                    {
                        node = node.right;
                        continue;
                    }
                    node = node.left;
                }

                PreOrderTraversal(root, ref left);
                //var q = new Queue<TreeNode>();
                //q.Enqueue(root);

                //while (q.Count > 0)
                //{
                //    var item = q.Dequeue();
                //    if (item.left == null && item.right == null)
                //    {
                //        left.Add(item);
                //    }
                //    else
                //    {
                //        if (item.left != null)
                //            q.Enqueue(item.left);
                //        if (item.right != null)
                //            q.Enqueue(item.right);
                //    }
                //}

                node = root;
                var right = new HashSet<TreeNode>();
                while (node != null)
                {
                    right.Add(node);
                    if (node != root && node.right == null && node.left != null)
                    {
                        node = node.left;
                        continue;
                    }
                    node = node.right;
                }

                for (int i = right.Count - 1; i >= 0; i--)
                {
                    left.Add(right.ElementAt(i));
                }

                return left.Select(n => n.val).ToList();
            }

            private void PreOrderTraversal(TreeNode node, ref HashSet<TreeNode> left)
            {
                if (node == null) return;
                if (node.left == null && node.right == null)
                {
                    left.Add(node);
                }
                else
                {
                    PreOrderTraversal(node.left, ref left);
                    PreOrderTraversal(node.right, ref left);
                }
            }

            public class FizzBuzz
            {
                private int n, curr;

                public FizzBuzz(int n)
                {
                    this.n = n;
                    curr = 1;
                }

                // printFizz() outputs "fizz".
                public void Fizz(Action printFizz)
                {
                    if (curr <= n && curr % 3 == 0)
                    {
                        lock (this)
                        {
                            curr++;
                        }
                        printFizz();
                    }
                }

                // printBuzzz() outputs "buzz".
                public void Buzz(Action printBuzz)
                {
                    if (curr <= n && curr % 5 == 0)
                    {
                        lock (this)
                        {
                            curr++;
                        }
                        printBuzz();
                    }
                }

                // printFizzBuzz() outputs "fizzbuzz".
                public void Fizzbuzz(Action printFizzBuzz)
                {
                    if (curr <= n && curr % 15 == 0)
                    {
                        lock (this)
                        {
                            curr++;
                        }
                        printFizzBuzz();
                    }
                }

                // printNumber(x) outputs "x", where x is an integer.
                public void Number(Action<int> printNumber)
                {
                    if (curr <= n && curr % 3 != 0 && curr % 5 != 0)
                    {
                        printNumber(curr);
                        lock (this)
                        {
                            curr++;
                        }
                    }
                }
            }

            public int SingleNonDuplicate1(int[] nums)
            {
                if (nums == null || nums.Length == 0) return -1;
                if (nums.Length == 1) return nums[0];

                int low = 0, high = nums.Length, mid;

                while (low < high)
                {
                    mid = low + (high - low) / 2;

                    if (mid > 0 && nums[mid] == nums[mid - 1])
                    {
                        if (mid % 2 == 0)
                        {
                            high = mid;
                        }
                        else
                        {
                            low = mid + 1;
                        }
                    }
                    else if (mid < nums.Length - 1 && nums[mid] == nums[mid + 1])
                    {
                        if (mid % 2 == 1)
                        {
                            high = mid;
                        }
                        else
                        {
                            low = mid + 1;
                        }
                    }
                    else
                    {
                        return nums[mid];
                    }
                }

                return -1;
            }

            public int FindTargetSumWays(int[] nums, int S)
            {
                int?[][] dp = new int?[nums.Length][];
                for (int i = 0; i < nums.Length; i++)
                {
                    dp[i] = new int?[2001];
                }
                return FindTargetSumWaysRec(ref nums, 0, 0, S, ref dp);
            }

            private int FindTargetSumWaysRec(ref int[] nums, int i, int sum, in int target, ref int?[][] dp)
            {
                if (i == nums.Length)
                {
                    return sum == target ? 1 : 0;
                }

                if (!dp[i][sum + 1000].HasValue)
                {
                    var add = FindTargetSumWaysRec(ref nums, i + 1, sum + nums[i], target, ref dp);
                    var subtract = FindTargetSumWaysRec(ref nums, i + 1, sum - nums[i], target, ref dp);

                    dp[i][sum + 1000] = add + subtract;
                }
                return dp[i][sum + 1000].Value;
            }

            public string LastSubstring(string s)
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

            public String LastSubstring_SuffixArray(String s)
            {
                if (string.IsNullOrEmpty(s)) return string.Empty;

                var suffix = new SuffixArray(s.ToCharArray());
                var suffixArr = suffix.getSa();
                return s.Substring(suffixArr[suffixArr.Length - 1]);
            }

            public class SuffixArray
            {
                private class Suffix : IComparable<Suffix>
                {
                    // Starting position of suffix in text
                    public readonly int index, len;
                    readonly char[] text;

                    public Suffix(char[] text, int index)
                    {
                        this.len = text.Length - index;
                        this.index = index;
                        this.text = text;
                    }

                    // Compare the two suffixes inspired by Robert Sedgewick and Kevin Wayne
                    public int CompareTo(Suffix other)
                    {
                        if (this == other) return 0;
                        int min_len = Math.Min(len, other.len);
                        for (int i = 0; i < min_len; i++)
                        {
                            if (text[index + i] < other.text[other.index + i]) return -1;
                            if (text[index + i] > other.text[other.index + i]) return +1;
                        }
                        return len - other.len;
                    }

                    public String toString()
                    {
                        return new String(text, index, len);
                    }

                }

                // Wrapper class to help sort suffix ranks
                class SuffixRankTuple : IComparable<SuffixRankTuple>
                {
                    public int firstHalf, secondHalf, originalIndex;

                    // Sort Suffix ranks first on the first half then the second half
                    public int CompareTo(SuffixRankTuple other)
                    {
                        int cmp = firstHalf.CompareTo(other.firstHalf);
                        if (cmp == 0) return secondHalf.CompareTo(other.secondHalf);
                        return cmp;
                    }

                    public override String ToString()
                    {
                        return originalIndex + " -> (" + firstHalf + ", " + secondHalf + ")";
                    }
                }

                // Length of the suffix array
                protected readonly int N;

                // T is the text
                protected char[] T;

                // The sorted suffix array values.
                protected int[] sa;

                // Longest Common Prefix array
                protected int[] lcp;

                private bool constructedSa = false;
                private bool constructedLcpArray = false;

                public SuffixArray(char[] text)
                {
                    if (text == null) throw new ArgumentNullException("Text cannot be null.");
                    this.T = text;
                    this.N = text.Length;
                }

                public int getTextLength()
                {
                    return T.Length;
                }

                // Returns the suffix array.
                public int[] getSa()
                {
                    buildSuffixArray();
                    return sa;
                }

                // Returns the LCP array.
                public int[] getLcpArray()
                {
                    buildLcpArray();
                    return lcp;
                }

                // Builds the suffix array by calling the construct() method.
                protected void buildSuffixArray()
                {
                    if (constructedSa) return;
                    construct();
                    constructedSa = true;
                }

                // Builds the LCP array by first creating the SA and then running the kasai algorithm.
                protected void buildLcpArray()
                {
                    if (constructedLcpArray) return;
                    buildSuffixArray();
                    kasai();
                    constructedLcpArray = true;
                }

                protected static int[] toIntArray(String s)
                {
                    if (s == null) return null;
                    int[] t = new int[s.Length];
                    for (int i = 0; i < s.Length; i++) t[i] = s[i];
                    return t;
                }

                // Contains all the suffixes of the SuffixArray
                Suffix[] suffixes;

                // The suffix array construction algorithm is left undefined
                // as there are multiple ways to do this.

                // Suffix array construction. This actually takes O(n^2log(n)) time since sorting takes on
                // average O(nlog(n)) and each String comparison takes O(n).
                protected void constructSlow()
                {
                    sa = new int[N];
                    suffixes = new Suffix[N];

                    for (int i = 0; i < N; i++) suffixes[i] = new Suffix(T, i);

                    Array.Sort(suffixes);

                    for (int i = 0; i < N; i++)
                    {
                        Suffix suffix = suffixes[i];
                        sa[i] = suffix.index;
                        Console.WriteLine(i);
                        suffixes[i] = null;
                    }

                    suffixes = null;
                }

                protected void constructMed()
                {
                    sa = new int[N];

                    // Maintain suffix ranks in both a matrix with two rows containing the
                    // current and last rank information as well as some sortable rank objects
                    int[][] suffixRanks = new int[2][];
                    suffixRanks[0] = new int[N];
                    suffixRanks[1] = new int[N];
                    SuffixRankTuple[] ranks = new SuffixRankTuple[N];

                    // Assign a numerical value to each character in the text
                    for (int i = 0; i < N; i++)
                    {
                        suffixRanks[0][i] = T[i];
                        ranks[i] = new SuffixRankTuple();
                    }

                    // O(log(n))
                    for (int pos = 1; pos < N; pos *= 2)
                    {

                        for (int i = 0; i < N; i++)
                        {
                            SuffixRankTuple suffixRank = ranks[i];
                            suffixRank.firstHalf = suffixRanks[0][i];
                            suffixRank.secondHalf = i + pos < N ? suffixRanks[0][i + pos] : -1;
                            suffixRank.originalIndex = i;
                        }

                        // O(nlog(n))
                        Array.Sort(ranks);

                        int newRank = 0;
                        suffixRanks[1][ranks[0].originalIndex] = 0;

                        for (int i = 1; i < N; i++)
                        {

                            SuffixRankTuple lastSuffixRank = ranks[i - 1];
                            SuffixRankTuple currSuffixRank = ranks[i];

                            // If the first half differs from the second half
                            if (currSuffixRank.firstHalf != lastSuffixRank.firstHalf
                                || currSuffixRank.secondHalf != lastSuffixRank.secondHalf) newRank++;

                            suffixRanks[1][currSuffixRank.originalIndex] = newRank;
                        }

                        // Place top row (current row) to be the last row
                        suffixRanks[0] = suffixRanks[1];

                        // Optimization to stop early
                        if (newRank == N - 1) break;
                    }

                    // Fill suffix array
                    for (int i = 0; i < N; i++)
                    {
                        sa[i] = ranks[i].originalIndex;
                        ranks[i] = null;
                    }

                    // Cleanup
                    suffixRanks[0] = suffixRanks[1] = null;
                    suffixRanks = null;
                    ranks = null;
                }


                private static readonly int DEFAULT_ALPHABET_SIZE = 256;

                int alphabetSize = DEFAULT_ALPHABET_SIZE;
                int[] sa2, rank, tmp, c;


                protected void construct()
                {
                    sa = new int[N];
                    sa2 = new int[N];
                    rank = new int[N];
                    c = new int[Math.Max(alphabetSize, N)];

                    int i, p, r;
                    for (i = 0; i < N; ++i) c[rank[i] = T[i]]++;
                    for (i = 1; i < alphabetSize; ++i) c[i] += c[i - 1];
                    for (i = N - 1; i >= 0; --i) sa[--c[T[i]]] = i;
                    for (p = 1; p < N; p <<= 1)
                    {
                        for (r = 0, i = N - p; i < N; ++i) sa2[r++] = i;
                        for (i = 0; i < N; ++i) if (sa[i] >= p) sa2[r++] = sa[i] - p;
                        Array.Fill(c, 0, 0, alphabetSize);
                        for (i = 0; i < N; ++i) c[rank[i]]++;
                        for (i = 1; i < alphabetSize; ++i) c[i] += c[i - 1];
                        for (i = N - 1; i >= 0; --i) sa[--c[rank[sa2[i]]]] = sa2[i];
                        for (sa2[sa[0]] = r = 0, i = 1; i < N; ++i)
                        {
                            if (!(rank[sa[i - 1]] == rank[sa[i]]
                                  && sa[i - 1] + p < N
                                  && sa[i] + p < N
                                  && rank[sa[i - 1] + p] == rank[sa[i] + p])) r++;
                            sa2[sa[i]] = r;
                        }
                        tmp = rank;
                        rank = sa2;
                        sa2 = tmp;
                        if (r == N - 1) break;
                        alphabetSize = r + 1;
                    }
                }

                // Use Kasai algorithm to build LCP array
                // http://www.mi.fu-berlin.de/wiki/pub/ABI/RnaSeqP4/suffix-array.pdf
                private void kasai()
                {
                    lcp = new int[N];
                    int[] inv = new int[N];
                    for (int i = 0; i < N; i++) inv[sa[i]] = i;
                    for (int i = 0, len = 0; i < N; i++)
                    {
                        if (inv[i] > 0)
                        {
                            int k = sa[inv[i] - 1];
                            while ((i + len < N) && (k + len < N) && T[i + len] == T[k + len]) len++;
                            lcp[inv[i]] = len;
                            if (len > 0) len--;
                        }
                    }
                }

            }

            public int LongestRepeatedSubstring(string str)
            {
                // Get all substrings
                var n = str.Length;
                var substrings = new string[n];
                int lastIndex = 0;
                for (int i = 0; i < n; i++)
                {
                    var option = new char[n - i];
                    for (int j = i; j < n; j++)
                    {
                        option[j - i] = str[j];
                    }
                    substrings[lastIndex++] = new string(option);
                    Console.WriteLine(substrings[lastIndex - 1]);
                }

                // Order substrings

                // for each pair (i+1, i) generate LPS array (longest common prefix)

                // loop on the array and fix max

                return 0;
            }

            public int SolveCoinChange(int[] denominations, int amount)
            {
                var lst = new List<List<int>>();
                SolveCoinChangeRec(ref denominations, 0, amount, new List<int>(), ref lst);
                lst.ForEach(x => x.Print());
                return -1;
            }

            private void SolveCoinChangeRec(ref int[] denominations, int i, in int amount, List<int> option, ref List<List<int>> lst)
            {
                if (amount == 0)
                {
                    lst.Add(new List<int>(option));
                }
                if (amount < 0 || i >= denominations.Length) return;

                for (int j = i; j < denominations.Length; j++)
                {
                    option.Add(denominations[j]);
                    SolveCoinChangeRec(ref denominations, j, amount - denominations[j], option, ref lst);
                    option.RemoveAt(option.Count - 1);
                }
            }

            public int MaximumProduct(int[] nums)
            {
                if (nums == null || nums.Length < 3) return 0;
                Array.Sort(nums);
                int n = nums.Length - 1;
                return Math.Max(nums[n] * nums[n - 1] * nums[n - 2], nums[0] * nums[1] * nums[n]);
            }

            public IList<IList<int>> Generate(int numRows)
            {
                var result = new List<IList<int>>();
                List<int> prevRow = null;
                for (int i = 1; i <= numRows; i++)
                {
                    var row = new List<int>(i);
                    for (int j = 0; j < i; j++)
                    {
                        if (j == 0 || j == i - 1)
                            row.Add(1);
                        else row.Add(prevRow[j - 1] + prevRow[j]);
                    }
                    prevRow = row;
                    result.Add(row);
                }

                return result;
            }

            public int[] RunningSum(int[] nums)
            {
                if (nums == null || nums.Length == 0) return new int[0];

                for (int i = 1; i < nums.Length; i++)
                {
                    nums[i] += nums[i - 1];
                }
                return nums;
            }

            //public bool IsRectangleOverlap(int[] rec1, int[] rec2)
            //{
            //    int ax1 = rec1[0], ay1 = rec1[1], ax2 = rec1[2], ay2 = rec1[3];
            //    int bx1 = rec2[0], by1 = rec2[1], bx2 = rec2[2], by2 = rec2[3];

            //    if ((bx1 >= ax1 && bx1 <= ax2 && by1 >= ay1 && by1 <= ay2)
            //        || (ax1 >= bx1 && ax1 <= bx2 && ay1 >= by1 && ay1 <= by2))
            //    {
            //        return Math.Abs(bx1 - ax2) > 0 && Math.Abs(by1 - ay2) > 0;
            //    }

            //    return false;
            //}

            public int PivotIndex(int[] nums)
            {
                if (nums == null || nums.Length == 0) return -1;
                int leftSum = 0;

                int total = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    total += nums[i];
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (leftSum == total - nums[i] - leftSum) return i;
                    leftSum += nums[i];
                }

                return -1;
            }

            public bool SequenceReconstruction(int[] org, IList<IList<int>> seqs)
            {
                var inDegrees = new Dictionary<int, int>();
                var graph = new Dictionary<int, HashSet<int>>();

                foreach (var seq in seqs)
                {
                    for (int i = 0; i < seq.Count; i++)
                    {
                        int child = seq[i];
                        if (!inDegrees.ContainsKey(child))
                            inDegrees.Add(child, 0);

                        if (!graph.ContainsKey(child))
                            graph.Add(child, new HashSet<int>());
                    }
                }

                foreach (var seq in seqs)
                {
                    for (int i = 0; i < seq.Count - 1; i++)
                    {
                        int parent = seq[i], child = seq[i + 1];
                        if (!graph[parent].Contains(child))
                        {
                            inDegrees[child]++;
                            graph[parent].Add(child);
                        }
                    }
                }

                if (inDegrees.Count != org.Length) return false;

                var q = new Queue<int>();
                foreach (var inDegree in inDegrees)
                {
                    if (inDegree.Value == 0) q.Enqueue(inDegree.Key);
                }

                int lastIndex = 0;
                while (q.Count > 0)
                {
                    if (q.Count > 1) return false;
                    var source = q.Dequeue();

                    if (source != org[lastIndex++]) return false;

                    foreach (var child in graph[source])
                    {
                        inDegrees[child]--;
                        if (inDegrees[child] == 0) q.Enqueue(child);
                    }
                }

                return lastIndex == org.Length;
            }


            public IList<bool> CheckIfPrerequisite(int n, int[][] prerequisites, int[][] queries)
            {
                if (n == 0) return new List<bool>();

                var pGraph = new List<HashSet<int>>();
                var dGraph = new List<HashSet<int>>();

                for (int i = 0; i < n; i++)
                {
                    pGraph.Add(new HashSet<int>());
                    dGraph.Add(new HashSet<int>());
                }

                if (prerequisites != null)
                {
                    for (int i = 0; i < prerequisites.Length; i++)
                    {
                        var prerequisite = prerequisites[i];

                        pGraph[prerequisite[0]].Add(prerequisite[1]);
                        foreach (var dependency in dGraph[prerequisite[0]])
                        {
                            pGraph[dependency].Add(prerequisite[1]);
                            dGraph[prerequisite[1]].Add(dependency);
                        }
                        dGraph[prerequisite[1]].Add(prerequisite[0]);
                    }
                }

                var result = new List<bool>(queries.Length);
                foreach (var query in queries)
                {
                    result.Add(pGraph[query[0]].Contains(query[1]));
                }

                return result;
            }

            public class MultiDimensionalComparer : ArrayComparer<int>
            {

            }

            /// <summary>
            /// Compares two arrays to see if the values inside of the array are the same. This is
            /// dependent on the type contained in the array having a valid Equals() override.
            /// </summary>
            /// <typeparam name="T">The type of data stored in the array</typeparam>
            public class ArrayComparer<T> : IEqualityComparer<T[][]>
            {
                /// <summary>
                /// Gets the hash code for the contents of the array since the default hash code
                /// for an array is unique even if the contents are the same.
                /// </summary>
                /// <remarks>
                /// See Jon Skeet (C# MVP) response in the StackOverflow thread 
                /// http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
                /// </remarks>
                /// <param name="array">The array to generate a hash code for.</param>
                /// <returns>The hash code for the values in the array.</returns>
                public int GetHashCode(T[][] array)
                {
                    // if non-null array then go into unchecked block to avoid overflow
                    if (array != null)
                    {
                        unchecked
                        {
                            int hash = 17;

                            // get hash code for all items in array
                            foreach (var item in array)
                            {
                                hash = hash * 23 + ((item != null) ? GetHashCode(item) : 0);
                            }

                            return hash;
                        }
                    }

                    // if null, hash code is zero
                    return 0;
                }

                public int GetHashCode(T[] array)
                {
                    // if non-null array then go into unchecked block to avoid overflow
                    if (array != null)
                    {
                        unchecked
                        {
                            int hash = 17;

                            // get hash code for all items in array
                            foreach (var item in array)
                            {
                                hash = hash * 23 + ((item != null) ? item.GetHashCode() : 0);
                            }

                            return hash;
                        }
                    }

                    // if null, hash code is zero
                    return 0;
                }

                /// <summary>
                /// Compares the contents of both arrays to see if they are equal. This depends on 
                /// typeparameter T having a valid override for Equals().
                /// </summary>
                /// <param name="firstArray">The first array to compare.</param>
                /// <param name="secondArray">The second array to compare.</param>
                /// <returns>True if firstArray and secondArray have equal contents.</returns>
                public bool Equals(T[][] firstArray, T[][] secondArray)
                {
                    if (object.ReferenceEquals(firstArray, secondArray))
                    {
                        return true;
                    }

                    // otherwise, if both arrays have same length, compare all elements
                    if (firstArray != null && secondArray != null &&
                        (firstArray.Length == secondArray.Length))
                    {
                        for (int i = 0; i < firstArray.Length; i++)
                        {
                            // if any mismatch, not equal
                            if (!Equals(firstArray[i], secondArray[i]))
                            {
                                return false;
                            }
                        }

                        // if no mismatches, equal
                        return true;
                    }

                    // if we get here, they are not equal
                    return false;
                }

                public bool Equals(T[] firstArray, T[] secondArray)
                {
                    // if same reference or both null, then equality is true
                    if (object.ReferenceEquals(firstArray, secondArray))
                    {
                        return true;
                    }

                    // otherwise, if both arrays have same length, compare all elements
                    if (firstArray != null && secondArray != null &&
                        (firstArray.Length == secondArray.Length))
                    {
                        for (int i = 0; i < firstArray.Length; i++)
                        {
                            // if any mismatch, not equal
                            if (!object.Equals(firstArray[i], secondArray[i]))
                            {
                                return false;
                            }
                        }

                        // if no mismatches, equal
                        return true;
                    }

                    // if we get here, they are not equal
                    return false;
                }
            }

            public int NumDistinctIslands(int[][] grid)
            {
                var comparer = new MultiDimensionalComparer();
                var hs = new HashSet<int[][]>(comparer);

                int newMask = 2;
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            int leftI = i, leftJ = j, rightI = i, rightJ = j;
                            ScanGridRec(ref grid, i, j, newMask, ref leftI, ref leftJ, ref rightI, ref rightJ);

                            var newIsland = new int[rightI - leftI + 1][];
                            for (int k = leftI; k <= rightI; k++)
                            {
                                newIsland[k - leftI] = new int[rightJ - leftJ + 1];
                                for (int l = leftJ; l <= rightJ; l++)
                                {
                                    if (grid[k][l] == newMask)
                                    {
                                        newIsland[k - leftI][l - leftJ] = 1;
                                    }
                                }
                            }
                            hs.Add(newIsland);

                            newMask++;
                        }
                    }
                }

                return hs.Count;
            }

            private void ScanGridRec(ref int[][] grid, in int i, in int j, int newMask, ref int leftI, ref int leftJ, ref int rightI, ref int rightJ)
            {
                if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] != 1) return;
                grid[i][j] = newMask;

                leftI = Math.Min(leftI, i);
                leftJ = Math.Min(leftJ, j);
                rightI = Math.Max(rightI, i);
                rightJ = Math.Max(rightJ, j);

                ScanGridRec(ref grid, i, j - 1, newMask, ref leftI, ref leftJ, ref rightI, ref rightJ);
                ScanGridRec(ref grid, i, j + 1, newMask, ref leftI, ref leftJ, ref rightI, ref rightJ);
                ScanGridRec(ref grid, i - 1, j, newMask, ref leftI, ref leftJ, ref rightI, ref rightJ);
                ScanGridRec(ref grid, i + 1, j, newMask, ref leftI, ref leftJ, ref rightI, ref rightJ);
            }

            public string SimplifyPath(string path)
            {
                if (string.IsNullOrEmpty(path)) return "/";

                var moves = path.Split("/", StringSplitOptions.RemoveEmptyEntries);

                var stack = new Stack<string>();
                for (int i = 0; i < moves.Length; i++)
                {
                    switch (moves[i])
                    {
                        case ".":
                            break;
                        case "..":
                            stack.TryPop(out _);
                            break;
                        default:
                            stack.Push(moves[i]);
                            break;
                    }
                }

                if (stack.Count == 0) return "/";

                var sb = new StringBuilder();
                while (stack.Count > 0)
                {
                    sb.Insert(0, "/" + stack.Pop());
                }

                return sb.ToString();
            }

            public int MaxNumEdgesToRemove(int n, int[][] edges)
            {
                DSU alice = new DSU(n), bob = new DSU(n);

                edges = edges.OrderByDescending(e => e[0])
                    .ToArray();

                int edgesUsed = 0;
                for (int i = 0; i < edges.Length; i++)
                {
                    var edge = edges[i];

                    switch (edge[0])
                    {
                        case 3:
                            edgesUsed += alice.Union(edge[1] - 1, edge[2] - 1) | bob.Union(edge[1] - 1, edge[2] - 1) ? 1 : 0;
                            break;
                        case 1:
                            edgesUsed += alice.Union(edge[1] - 1, edge[2] - 1) ? 1 : 0;
                            break;
                        case 2:
                            edgesUsed += bob.Union(edge[1] - 1, edge[2] - 1) ? 1 : 0;
                            break;
                    }
                }

                return (alice._componentsCount == 1 && bob._componentsCount == 1) ? edges.Length - edgesUsed : -1;
            }

            public int MaxNumEdgesToRemove1(int n, int[][] edges)
            {
                int[] inDegrees1 = new int[n],
                    outDegrees1 = new int[n],
                    inDegrees2 = new int[n],
                    outDegrees2 = new int[n];

                for (int i = 0; i < edges.Length; i++)
                {
                    var edge = edges[i];
                    switch (edge[0])
                    {
                        case 1:
                            outDegrees1[edge[1] - 1]++;
                            inDegrees1[edge[2] - 1]++;
                            break;
                        case 2:
                            outDegrees2[edge[1] - 1]++;
                            inDegrees2[edge[2] - 1]++;
                            break;
                        case 3:
                            outDegrees1[edge[1] - 1]++;
                            inDegrees1[edge[2] - 1]++;
                            outDegrees2[edge[1] - 1]++;
                            inDegrees2[edge[2] - 1]++;
                            break;
                    }
                }

                if (!IsTraversable(ref inDegrees1, ref inDegrees2, ref outDegrees1, ref outDegrees2)) return -1;

                var max = 0;
                return MaxNumEdgesToRemoveRec(ref edges, ref inDegrees1, ref inDegrees2, ref outDegrees1, ref outDegrees2, 0, ref max);
                //return max;
            }

            private int MaxNumEdgesToRemoveRec(ref int[][] edges, ref int[] inDegrees1, ref int[] inDegrees2, ref int[] outDegrees1, ref int[] outDegrees2, int i, ref int max)
            {
                if (i == edges.Length) return 0;

                var edge = edges[i];

                switch (edge[0])
                {
                    case 1:
                        outDegrees1[edge[1] - 1]--;
                        inDegrees1[edge[2] - 1]--;
                        break;
                    case 2:
                        outDegrees2[edge[1] - 1]--;
                        inDegrees2[edge[2] - 1]--;
                        break;
                    case 3:
                        outDegrees1[edge[1] - 1]--;
                        inDegrees1[edge[2] - 1]--;
                        outDegrees2[edge[1] - 1]--;
                        inDegrees2[edge[2] - 1]--;
                        break;
                }

                var isTraversable = IsTraversable(ref inDegrees1, ref inDegrees2, ref outDegrees1, ref outDegrees2);

                int opt1 = 0, opt2 = 0;
                if (isTraversable)
                {
                    opt1 = 1 + MaxNumEdgesToRemoveRec(ref edges, ref inDegrees1, ref inDegrees2, ref outDegrees1, ref outDegrees2, i + 1, ref max);
                }

                switch (edge[0])
                {
                    case 1:
                        outDegrees1[edge[1] - 1]++;
                        inDegrees1[edge[2] - 1]++;
                        break;
                    case 2:
                        outDegrees2[edge[1] - 1]++;
                        inDegrees2[edge[2] - 1]++;
                        break;
                    case 3:
                        outDegrees1[edge[1] - 1]++;
                        inDegrees1[edge[2] - 1]++;
                        outDegrees2[edge[1] - 1]++;
                        inDegrees2[edge[2] - 1]++;
                        break;
                }

                opt2 = MaxNumEdgesToRemoveRec(ref edges, ref inDegrees1, ref inDegrees2, ref outDegrees1, ref outDegrees2, i + 1, ref max);

                var maxO = Math.Max(opt1, opt2);

                //max = Math.Max(max, maxO);

                return maxO;
            }

            private bool IsTraversable(ref int[] inDegrees1, ref int[] inDegrees2, ref int[] outDegrees1, ref int[] outDegrees2)
            {
                int count1 = 0, count2 = 0;
                for (int i = 0; i < inDegrees1.Length; i++)
                {
                    if (inDegrees1[i] < 1) count1++;
                    if (outDegrees1[i] < 1) count2++;
                    if (count1 > 1 || count2 > 1) return false;
                }

                count1 = 0; count2 = 0;
                for (int i = 0; i < inDegrees2.Length; i++)
                {
                    if (inDegrees2[i] < 1) count1++;
                    if (outDegrees2[i] < 1) count2++;
                    if (count1 > 1 || count2 > 1) return false;
                }

                return true;
            }

            public int MinCost(string s, int[] cost)
            {
                if (string.IsNullOrEmpty(s)) return 0;
                var count = 0;
                int left = 0;
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[left] == s[i])
                    {
                        if (cost[left] <= cost[i])
                        {
                            count += cost[left];
                            left = i;
                        }
                        else
                        {
                            count += cost[i];
                        }
                    }
                    else
                    {
                        left = i;
                    }
                }

                return count;
            }

            public int NumTriplets(int[] nums1, int[] nums2)
            {
                if (nums1.Length == 0 || nums2.Length == 0) return 0;
                Array.Sort(nums1);
                Array.Sort(nums2);
                int count = 0, left = 0, right = 0;
                for (int i = 0; i < nums1.Length; i++)
                {
                    for (int j = i; j < nums2.Length; j++)
                    {
                        for (int k = j; k < nums2.Length; k++)
                        {
                            left = nums1[i] * nums1[i];
                            right = nums2[j] * nums2[k];
                            if (left == right)
                            {
                                count++;
                            }
                            if (left < right) break;
                        }
                        if (left < right) break;
                    }
                }

                for (int i = 0; i < nums2.Length; i++)
                {
                    for (int j = i; j < nums1.Length; j++)
                    {
                        for (int k = j; k < nums1.Length; k++)
                        {
                            left = nums2[i] * nums2[i];
                            right = nums1[j] * nums1[k];
                            if (left == right)
                            {
                                count++;
                            }
                            if (left < right) break;
                        }
                        if (left < right) break;
                    }
                }

                return count;
            }

            public string ModifyString(string s)
            {
                if (string.IsNullOrEmpty(s)) return s;
                var rnd = new Random();
                var sb = new StringBuilder(s);
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '?')
                    {
                        int r;
                        do
                        {
                            r = rnd.Next(0, 26);
                        } while ((i < (sb.Length - 1) && r == (sb[i + 1] - 'a')) || (i > 0 && r == (sb[i - 1] - 'a')));

                        sb[i] = (char)(r + 'a');
                    }
                }
                return sb.ToString();
            }

            public int[] FindDiagonalOrder(int[][] matrix)
            {
                if (matrix.Length == 0) return new int[0];

                var isIncreasing = true;
                int i = 0, j = 0, height = matrix.Length, width = matrix[0].Length;
                var res = new int[width * height];
                var lastIndex = 0;
                while (lastIndex < res.Length)
                {
                    res[lastIndex++] = matrix[i][j];

                    if (isIncreasing)
                    {
                        i--;
                        j++;

                        if (j >= width)
                        {
                            j = width - 1;
                            i += 2;
                            isIncreasing = false;
                        }
                        if (i < 0)
                        {
                            i = 0;
                            isIncreasing = false;
                        }
                    }
                    else
                    {
                        i++;
                        j--;

                        if (i >= height)
                        {
                            i = height - 1;
                            j += 2;
                            isIncreasing = true;
                        }

                        if (j < 0)
                        {
                            j = 0;
                            isIncreasing = true;
                        }

                    }
                }

                return res;
            }

            public class Solution2
            {
                private readonly int[] _nums;
                private int[] inProgress;
                Random _rnd = new Random();

                public Solution2(int[] nums)
                {
                    _nums = nums;
                    inProgress = nums.ToArray();
                }

                /** Resets the array to its original configuration and return it. */
                public int[] Reset()
                {
                    inProgress = _nums.ToArray();
                    return _nums;
                }

                /** Returns a random shuffling of the array. */
                public int[] Shuffle()
                {
                    for (int j = 0; j < _nums.Length; j++)
                    {
                        var i = _rnd.Next(j, _nums.Length);
                        Swap(ref inProgress, i, j);
                    }
                    return inProgress;
                }

                private void Swap(ref int[] option, in int i, in int j)
                {
                    var temp = option[i];
                    option[i] = option[j];
                    option[j] = temp;
                }
            }

            public class Solution1
            {
                private readonly int[] _nums;
                List<int[]> perms;
                Random _rnd = new Random();

                public Solution1(int[] nums)
                {
                    _nums = nums;
                    perms = new List<int[]>(Fact(nums.Length));
                    GeneratePerms();
                }

                private int Fact(in int n)
                {
                    if (n <= 1) return 1;
                    return n * Fact(n - 1);
                }

                private void GeneratePerms()
                {
                    GeneratePermsRec(0, _nums.Length, new List<int>(_nums));
                }

                private void GeneratePermsRec(int i, in int n, List<int> option)
                {
                    if (i == n)
                    {
                        perms.Add(option.ToArray());
                        return;
                    }

                    for (int j = i; j < n; j++)
                    {
                        Swap(ref option, i, j);
                        GeneratePermsRec(j + 1, n, option);
                        Swap(ref option, i, j);
                    }
                }

                private void Swap(ref List<int> option, in int i, in int j)
                {
                    var temp = option[i];
                    option[i] = option[j];
                    option[j] = temp;
                }

                /** Resets the array to its original configuration and return it. */
                public int[] Reset()
                {
                    return _nums;
                }

                /** Returns a random shuffling of the array. */
                public int[] Shuffle()
                {
                    var i = _rnd.Next(0, _nums.Length);
                    return perms[i];
                }
            }

            public string ReverseWords(string s)
            {
                if (string.IsNullOrEmpty(s)) return string.Empty;
                var sb = new StringBuilder(s.Length);

                var foundWord = false;
                var wordsCount = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        if (foundWord)
                        {
                            wordsCount++;
                            sb.Append(s[i]);
                            foundWord = false;
                        }
                    }
                    else
                    {
                        sb.Append(s[i]);
                        foundWord = true;
                    }
                }

                if (sb.Length == 0) return string.Empty;
                if (sb[sb.Length - 1] == ' ')
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    wordsCount++;
                }

                var lst = new List<string>(wordsCount);
                var start = 0;
                for (int i = 1; i < sb.Length; i++)
                {
                    if (sb[i] == ' ')
                    {
                        lst.Add(sb.ToString(start, i - start));
                        start = i + 1;
                    }
                }
                lst.Add(sb.ToString(start, sb.Length - start));

                sb.Clear();
                for (int i = lst.Count - 1; i >= 0; i--)
                {
                    sb.Append(lst[i]);
                    if (i > 0) sb.Append(' ');
                }

                return sb.ToString();
            }

            public int MinCut(string s)
            {
                /* Better solution for this one BFS
                    cut = 0
                    leftSB = ""
                    rightSB = s
                    
                    MinCut(leftSB, rightSB, cut){
                        if(leftSB && rightSB are palindrome){
                            return cut;
                        }
                        cut++;
                        for(i=0;i<s.lengthi++)
                        {
                            leftSb += s[i];
                            MinCut(leftSB, rightSB, cut);
                            leftSb.remove(-1)
                        }
                    }  
                */
                int minCut = int.MaxValue;
                StringBuilder leftSb = new StringBuilder(), rightSb = new StringBuilder(s);
                var q = new Queue<(StringBuilder leftSb, StringBuilder rightSb, int cuts)>();
                q.Enqueue((leftSb, rightSb, 0));

                while (q.Count > 0)
                {
                    var pair = q.Dequeue();
                    if (IsPalindrome(pair.leftSb) && IsPalindrome(pair.rightSb))
                    {
                        return pair.cuts;
                    }

                    var cut = pair.cuts + 1;
                    for (int i = 0; i < s.Length; i++)
                    {
                        // Append a char to leftSb and remove it from right sb
                        // check if palindrome
                        if (IsPalindrome(leftSb) && IsPalindrome(rightSb))
                        {
                            return cut;
                        }

                    }
                }

                return minCut;
            }

            private bool MinCut(string s, int i, StringBuilder sb, int cuts, ref int minCut)
            {
                if (i == s.Length)
                {
                    if (sb.Length == 0)
                    {
                        minCut = Math.Min(minCut, cuts - 1);
                        return true;
                    }
                    return true;
                }

                sb.Append(s[i]);

                var shouldContinue = MinCut(s, i + 1, sb, cuts, ref minCut);

                if (!shouldContinue) return shouldContinue;

                if (IsPalindrome(sb))
                {
                    shouldContinue = MinCut(s, i + 1, new StringBuilder(), cuts + 1, ref minCut);
                    if (!shouldContinue) return shouldContinue;
                }
                else
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                return true;
            }

            public IList<IList<string>> Partition(string s)
            {
                var lst = new List<IList<string>>();

                PartitionRec(s, 0, new StringBuilder(), new List<string>(), ref lst);

                return lst;
            }

            private void PartitionRec(string s, int i, StringBuilder sb, List<string> option, ref List<IList<string>> lst)
            {
                if (i == s.Length)
                {
                    if (sb.Length == 0)
                        lst.Add(new List<string>(option));
                    return;
                }

                sb.Append(s[i]);

                if (IsPalindrome(sb))
                {
                    option.Add(sb.ToString());
                    PartitionRec(s, i + 1, new StringBuilder(), option, ref lst);
                    option.RemoveAt(option.Count - 1);
                }

                PartitionRec(s, i + 1, sb, option, ref lst);
            }

            public bool IsPalindrome(StringBuilder sb)
            {
                for (int i = 0; i < sb.Length / 2; i++)
                {
                    if (sb[i] != sb[sb.Length - i - 1]) return false;
                }
                return true;
            }

            public int[][] GenerateMatrix(int n)
            {
                if (n == 0) return new int[0][];
                var m = new int[n][];
                for (int k = 0; k < n; k++)
                {
                    m[k] = new int[n];
                }

                int i = 0, j = 0, num = 1, minI = 0, maxI = n, minJ = 0, maxJ = n;
                bool isIncreasing = true;

                while (i >= minI && i < maxI && j >= minJ && j < maxJ)
                {
                    m[i][j] = num++;
                    if (isIncreasing)
                    {
                        if (j + 1 < maxJ) j++;
                        else if (i + 1 < maxI) i++;
                        else
                        {
                            minI++;
                            maxJ--;
                            j--;
                            isIncreasing = !isIncreasing;
                        }
                    }
                    else
                    {
                        if (j > minJ) j--;
                        else if (i > minI) i--;
                        else
                        {
                            maxI--;
                            minJ++;
                            j++;
                            isIncreasing = !isIncreasing;
                        }
                    }
                }

                return m;
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
                q.Enqueue((-1, -1));

                var iMoves = new int[] { 0, 0, -1, 1 };
                var jMoves = new int[] { -1, 1, 0, 0 };

                int days = 0;
                while (q.Count > 0)
                {
                    var rotten = q.Dequeue();

                    if (rotten == (-1, -1))
                    {
                        days++;
                        if (q.Count > 0) q.Enqueue((-1, -1));
                        continue;
                    }

                    for (int i = 0; i < 4; i++)
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

                return days - 1;
            }

            public int FirstMissingPositive(int[] nums)
            {
                int i = 0;
                while (i < nums.Length)
                {
                    var num = nums[i] - 1;
                    if (num >= 0 && num < nums.Length && num != i && (num + 1 != nums[num]))
                    {
                        var temp = nums[i];
                        nums[i] = nums[nums[i] - 1];
                        if (temp - 1 >= 0) nums[temp - 1] = temp;
                    }
                    else i++;
                }

                int j = 0;
                for (; j < nums.Length; j++)
                {
                    if (nums[j] != j + 1) return j + 1;
                }

                return j + 1;
            }

            public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
            {
                var set = new SortedSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (Math.Abs(nums[j] - nums[i]) <= t && j - i <= k) return true;
                    }
                }
                return false;
            }

            public bool ContainsNearbyDuplicate(int[] nums, int k)
            {
                var dic = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!dic.ContainsKey(nums[i]))
                    {
                        dic.Add(nums[i], i);
                    }
                    else
                    {
                        if (i - dic[nums[i]] <= k) return true;
                        else dic[nums[i]] = i;
                    }
                }
                return false;
            }

            public bool ContainsDuplicate(int[] nums)
            {
                var hs = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!hs.Contains(nums[i]))
                    {
                        hs.Add(nums[i]);
                    }
                    else return true;
                }
                return false;
            }

            private int?[] missing;
            public int Missing(ref int[] nums, int idx)
            {
                missing[idx] ??= nums[idx] - nums[0] - idx;
                return missing[idx].Value;
            }

            public int MissingElement(int[] nums, int k)
            {
                missing = new int?[nums.Length];
                var n = nums.Length;
                if (Missing(ref nums, n - 1) < k)
                    return nums[n - 1] + k - Missing(ref nums, n - 1);

                int left = 0, right = n;
                while (left != right)
                {
                    var pivot = left + ((right - left) / 2);

                    if (Missing(ref nums, pivot) < k) left = pivot + 1;
                    else right = pivot;
                }

                return nums[left - 1] + k - Missing(ref nums, left - 1);
            }

            public int MissingElement1(int[] nums, int k)
            {
                if (nums.Length == 0) return 0;
                var left = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    var diff = nums[i] - left - 1;
                    if (diff > 0)
                    {
                        if (k > diff)
                        {
                            k -= diff;
                        }
                        else return left + k;
                    }
                    left = nums[i];
                }

                return left + k;
            }

            public int Change(int amount, int[] coins)
            {
                // Bottom-up approach
                //coins = coins.OrderByDescending(c => c).ToArray();
                //var dp = new int[amount + 1];
                //dp[0] = 1;
                //foreach (var coin in coins)
                //    for (int i = coin; i <= amount; i++)
                //    {
                //        dp[i] += dp[i - coin];
                //    }
                //return dp[amount];

                var dp = new int?[coins.Length, amount + 1];
                return ChangeRec(amount, ref coins, ref dp, 0);
            }

            private int ChangeRec(in int amount, ref int[] coins, ref int?[,] dp, int i)
            {
                if (amount == 0) return 1;
                if (amount < 0 || i == coins.Length) return 0;
                if (dp[i, amount].HasValue) return dp[i, amount].Value;

                var option1 = ChangeRec(amount, ref coins, ref dp, i + 1);
                var option2 = ChangeRec(amount - coins[i], ref coins, ref dp, i);

                dp[i, amount] = option2 + option1;
                return dp[i, amount].Value;
            }

            public int CoinChange(int[] coins, int amount)
            {
                coins = coins.OrderByDescending(c => c).ToArray();
                int?[] dp = new int?[amount + 1];
                dp[0] = 0;
                var min = CoinChangeRec(ref coins, amount, ref dp);

                return min == int.MaxValue ? -1 : min;
            }

            private int CoinChangeRec(ref int[] coins, in int amount, ref int?[] dp)
            {
                if (amount < 0) return -1;
                if (amount == 0)
                {
                    return 0;
                }
                if (dp[amount].HasValue) return dp[amount].Value;

                int min = int.MaxValue;
                for (int j = 0; j < coins.Length; j++)
                {
                    if (coins[j] <= amount)
                    {
                        int res = CoinChangeRec(ref coins, amount - coins[j], ref dp);
                        if (res >= 0 && res < min)
                        {
                            min = res + 1;
                        }
                    }
                }

                dp[amount] = min == int.MaxValue ? -1 : min;
                return dp[amount].Value;
            }

            public int[] TopKFrequent(int[] nums, int k)
            {
                PriorityQueue<KeyValuePair<int, int>> pq =
                    new PriorityQueue<KeyValuePair<int, int>>(
                        Comparer<KeyValuePair<int, int>>.Create(((kv1, kv2) => kv2.Value.CompareTo(kv1.Value))));

                var dic = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (dic.ContainsKey(nums[i]))
                    {
                        dic[nums[i]]++;
                    }
                    else dic.Add(nums[i], 1);
                }

                foreach (var kv in dic)
                {
                    pq.Add(kv);
                }

                var arr = new int[k];
                for (int i = 0; i < k; i++)
                {
                    arr[i] = pq.Poll().Key;
                }
                //return pq.Take(k).Select(kv => kv.Key).ToArray();
                return arr;
            }

            public bool ContainsPattern(int[] arr, int m, int k)
            {
                int i = 0, j = m, count = 0;

                for (; j < arr.Length; i++, j++)
                {
                    if (arr[i] != arr[j])
                    {
                        count = 0;
                    }
                    else
                    {
                        count++;
                        if (count >= (k - 1) * m) return true;
                    }
                }
                return false;
            }

            public int GetMaxLen(int[] nums)
            {
                int zeroPos = -1, negativePos = -1, negativeCount = 0, max = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < 0)
                    {
                        if (negativeCount == 0) negativePos = i;
                        negativeCount++;
                    }

                    if (nums[i] == 0)
                    {
                        negativeCount = 0;
                        negativePos = -1;
                        zeroPos = i;
                    }
                    else
                    {
                        if (negativeCount % 2 == 0)
                        {
                            max = Math.Max(max, i - zeroPos);
                        }
                        else
                        {
                            max = Math.Max(max, i - negativePos);
                        }
                    }
                }
                return max;
            }

            public int GetMaxLen1(int[] nums)
            {
                if (nums.Length <= 0) return nums.Length;
                if (nums.Length == 1) return nums[0] > 0 ? 1 : 0;

                decimal max = 0;
                int maxLength = 0;
                int?[,] dp = new int?[0, 0];
                GetMaxLenRec(ref nums, 0, 0, 1, ref dp, ref maxLength, ref max);

                return maxLength;
            }

            private decimal GetMaxLenRec(ref int[] nums, int i, int j, decimal product, ref int?[,] dp, ref int maxLength, ref decimal max)
            {
                //if (dp[i, j].HasValue) return dp[i, j].Value;

                if (product > 0 && product > max && (j - i) > maxLength)
                {
                    maxLength = j - i;
                    max = product;
                }

                if (j == nums.Length) return product;

                decimal p1 = 1, p2 = 1;
                if (nums[j] != 0)
                {
                    p1 = GetMaxLenRec(ref nums, i, j + 1, product * nums[j], ref dp, ref maxLength, ref max);
                }
                if ((j + 1) < nums.Length)
                    p2 = GetMaxLenRec(ref nums, j + 1, j + 1, 1, ref dp, ref maxLength, ref max);

                product = Math.Max(p1, p2);

                //dp[i, j] = product;

                return product;
            }

            //public int MissingElement(int[] nums, int k)
            //{

            //}

            public int[][] Insert(int[][] intervals, int[] newInterval)
            {
                var ls = new LinkedList<int[]>();

                var shouldCompare = true;
                for (int i = 0; i < intervals.Length; i++)
                {
                    var interval = intervals[i];

                    if (shouldCompare)
                    {
                        if ((interval[0] <= newInterval[0] && interval[1] >= newInterval[0])
                            || (newInterval[0] <= interval[0] && newInterval[1] >= interval[0]))
                        {
                            newInterval = new[]
                            {
                                Math.Min(interval[0], newInterval[0]),
                                Math.Max(interval[1], newInterval[1]),
                            };
                        }
                        else
                        {
                            if (interval[0] < newInterval[0])
                            {
                                ls.AddLast(interval);
                                //ls.AddLast(newInterval);
                            }
                            else
                            {
                                ls.AddLast(newInterval);
                                ls.AddLast(interval);
                                shouldCompare = false;
                            }
                        }
                    }
                    else
                    {
                        ls.AddLast(interval);
                    }
                }

                if (shouldCompare)
                {
                    ls.AddLast(newInterval);
                }
                //ls.AddLast(newInterval);

                return ls.ToArray();
            }

            public IList<string> GenerateAbbreviations(string word)
            {
                var res = new List<string>();

                GenerateAbbreviationsRec(word, 0, 0, new StringBuilder(), ref res);

                return res;
            }

            private void GenerateAbbreviationsRec(string word, int start, int count, StringBuilder sb, ref List<string> res)
            {
                if (start == word.Length)
                {
                    if (count > 0)
                        sb.Append(count);
                    res.Add(sb.ToString());
                }
                else
                {
                    GenerateAbbreviationsRec(word, start + 1, count + 1, new StringBuilder(sb.ToString()), ref res);

                    if (count > 0)
                    {
                        sb.Append(count);
                    }

                    sb.Append(word[start]);
                    GenerateAbbreviationsRec(word, start + 1, 0, new StringBuilder(sb.ToString()), ref res);
                }
            }

            public void NextPermutation(int[] nums)
            {
                if (nums.Length <= 1) return;
                var last = nums[nums.Length - 1];
                int i = nums.Length - 2;
                for (; i >= 0; i--)
                {
                    if (nums[i] < last) break;
                    last = nums[i];
                }

                int temp;
                int j;
                if (i >= 0)
                {
                    for (j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] <= nums[i]) break;
                    }

                    temp = nums[i];
                    nums[i] = nums[j - 1];
                    nums[j - 1] = temp;
                }

                j = nums.Length - 1;
                int k = i + 1;
                while (k < j)
                {
                    temp = nums[k];
                    nums[k] = nums[j];
                    nums[j] = temp;
                    k++;
                    j--;
                }
            }

            public IList<IList<int>> PermuteUnique(int[] nums)
            {
                var result = new List<IList<int>>();

                PermuteUniqueRec(ref nums, 0, new List<int>(), ref result);

                return result;
            }

            private void PermuteUniqueRec(ref int[] nums, int i, List<int> option, ref List<IList<int>> result)
            {
                if (i == nums.Length)
                {
                    result.Add(new List<int>(option));
                    return;
                }

                var shouldBreak = false;
                int optionCount = option.Count;
                for (int j = 0; j <= optionCount; j++)
                {
                    if (optionCount > j && nums[i] == option[j])
                        shouldBreak = true;
                    option.Insert(j, nums[i]);
                    PermuteUniqueRec(ref nums, i + 1, option, ref result);
                    option.RemoveAt(j);
                    if (shouldBreak) break;
                }
            }

            public IList<IList<int>> Permute2(int[] nums)
            {
                var result = new List<IList<int>>();

                FindPermutationsRec(0, ref nums, ref result);

                return result;
            }

            private static void FindPermutationsRec(int i, ref int[] nums, ref List<IList<int>> result)
            {
                if (i == nums.Length)
                {
                    result.Add(new List<int>(nums));
                    return;
                }

                for (int j = i; j < nums.Length; j++)
                {
                    //if (i != j && nums[i] == nums[j]) continue;
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;

                    FindPermutationsRec(i + 1, ref nums, ref result);

                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }

            public IList<IList<int>> SubsetsWithDup(int[] nums)
            {
                Array.Sort(nums);
                var lst = new List<IList<int>>();
                lst.Add(new List<int>());
                int start = 0, end = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i > 0 && nums[i] == nums[i - 1]) start = end + 1;
                    else start = 0;
                    end = lst.Count - 1;
                    for (int j = start; j <= end; j++)
                    {
                        var item = lst[j];
                        var newItem = new List<int>(item) { nums[i] };
                        lst.Add(newItem);
                    }
                }
                return lst;
            }

            public IList<IList<int>> SubsetsWithDup1(int[] nums)
            {
                var lst = new List<IList<int>>();
                Array.Sort(nums);
                for (int k = 0; k <= nums.Length; k++)
                {
                    SubsetsWithDupRec(k, 0, ref nums, new List<int>(), ref lst);
                }
                return lst;
            }

            private void SubsetsWithDupRec(in int k, int i, ref int[] nums, List<int> option, ref List<IList<int>> lst)
            {
                if (i == k)
                {
                    lst.Add(new List<int>(option));
                    return;
                }

                for (int j = i; j < nums.Length; j++)
                {
                    //if(j > 0 && nums[j] == nums[j-1]) continue;
                    option.Add(nums[j]);
                    SubsetsWithDupRec(k, j + 1, ref nums, option, ref lst);
                    option.RemoveAt(option.Count - 1);
                }
            }

            private bool BitMaskArray(in int subsetOption, in int arrayElementIndex)
            {
                var temp = 1 << arrayElementIndex;
                temp &= subsetOption;
                return temp != 0;
            }

            public IList<IList<int>> Subsets(int[] nums)
            {
                var lst = new List<IList<int>>();
                lst.Add(new List<int>());
                for (int i = 0; i < nums.Length; i++)
                {
                    var lstCount = lst.Count;
                    for (int j = 0; j < lstCount; j++)
                    {
                        var item = lst[j];
                        var newItem = new List<int>(item) { nums[i] };
                        lst.Add(newItem);
                    }
                }
                return lst;
            }

            public bool CheckSubarraySum(int[] nums, int k)
            {
                if (nums.Length == 0) return false;
                if (k == 0)
                {
                    int count = 0;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] == 0) count++;
                        else count = 0;
                    }
                    return count >= 2;
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    int sum = nums[i];
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        sum += nums[j];
                        if (sum % k == 0) return true;
                    }
                }

                return false;
            }

            public int LongestStrChain(string[] words)
            {
                words = words.OrderBy(s => s.Length)
                    .ThenBy(s => s)
                    .ToArray();
                int[,] dp = new int[words.Length + 1, words.Length + 1];
                dp[0, 0] = 1;
                int max = 0;
                for (int i = 1; i <= words.Length; i++)
                {
                    dp[i, i] = Math.Max(dp[i - 1, i], dp[i - 1, i - 1]);
                    for (int j = i + 1; j <= words.Length; j++)
                    {
                        if (IsPredecessor(words[i - 1], words[j - 1]))
                        {
                            dp[i, j] = dp[i, j - 1] + 1;
                            break;
                        }
                        else dp[i, j] = dp[i, j - 1];

                        max = Math.Max(max, dp[i, j]);
                    }
                }
                //return dp[words.Length, words.Length];
                return max;
            }

            public int LongestStrChain1(string[] words)
            {
                words = words.OrderBy(s => s.Length)
                    .ThenBy(s => s)
                    .ToArray();
                int[,] dp = new int[words.Length, words.Length + 1];
                return LongestStrChainRec(ref words, 0, -1, ref dp);
            }

            public int LongestStrChainRec(ref string[] words, int curr, int prev, ref int[,] dp)
            {
                if (curr == words.Length || (prev >= 0 && words[curr].Length - words[prev].Length > 1)) return 0;

                if (dp[curr, prev + 1] != 0) return dp[curr, prev + 1];

                int c1 = 0;
                if (prev == -1 || IsPredecessor(words[prev], words[curr]))
                {
                    c1 = 1 + LongestStrChainRec(ref words, curr + 1, curr, ref dp);
                }
                var c2 = LongestStrChainRec(ref words, curr + 1, prev, ref dp);

                dp[curr, prev + 1] = Math.Max(c1, c2);
                return dp[curr, prev + 1];
            }

            public bool IsPredecessor(in string prev, in string curr)
            {
                if (curr.Length == prev.Length || curr.Length - prev.Length > 1) return false;

                for (int i = 0, j = 0; i < prev.Length && j < curr.Length; i++, j++)
                {
                    if (prev[i] != curr[j])
                    {
                        if (i != j) return false;
                        i--;
                    }
                }
                return true;
            }

            public int MaxSubArray(int[] nums)
            {
                if (nums.Length == 0) return 0;

                var dp = new int[nums.Length];
                dp[0] = nums[0];
                int max = dp[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    dp[i] = Math.Max(nums[i], dp[i - 1] + nums[i]);
                    max = Math.Max(max, dp[i]);
                }
                return max;
            }

            public int FindMaxConsecutiveOnes(int[] nums)
            {
                int count = 0, max = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 1) count++;
                    else
                    {
                        max = Math.Max(max, count);
                        count = 0;
                    }
                }
                return Math.Max(max, count);
            }


            public int FindMaxConsecutiveOnes1(int[] nums)
            {
                int i = 0, j = 0, max = 0;
                while (i < nums.Length)
                {
                    while (i < nums.Length && nums[i] != 1)
                    {
                        i++;
                    }
                    if (i == nums.Length) break;

                    j = i + 1;
                    while (j < nums.Length && nums[j] != 0)
                    {
                        j++;
                    }
                    max = Math.Max(max, j - i);

                    i = j + 1;
                }

                return max;
            }

            public int MaxSubArrayLen(int[] nums, int k)
            {
                int max = 0, sum = 0;
                var sumsMap = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    if (sum == k) max = Math.Max(max, i + 1);
                    else if (sumsMap.ContainsKey(sum - k))
                    {
                        max = Math.Max(max, i - sumsMap[sum - k]);
                    }
                    if (!sumsMap.ContainsKey(sum)) sumsMap.Add(sum, i);
                }

                return max;
            }

            public int MaxSubArrayLen1(int[] nums, int k)
            {
                var max = 0;
                var sums = new int[nums.Length + 1];
                for (int i = 1; i <= nums.Length; i++)
                {
                    sums[i] += sums[i - 1] + nums[i - 1];
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j <= nums.Length; j++)
                    {
                        if (sums[j] - sums[i] == k)
                        {
                            max = Math.Max(max, j - i);
                        }
                    }
                }

                return max;
            }

            public int LengthOfLIS(int[] nums)
            {
                var dp = new int[nums.Length];

                int len = 0;
                foreach (var num in nums)
                {
                    var i = Array.BinarySearch(nums, 0, len, num);
                    if (i < 0) i = ~i;
                    dp[i] = num;
                    if (i == len) len++;
                }
                return len;
            }

            public int LengthOfLIS2(int[] nums)
            {
                int[] dp = new int[nums.Length];
                var max = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    var maxToI = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            maxToI = Math.Max(maxToI, dp[j]);
                        }
                    }
                    dp[i] = 1 + maxToI;
                    max = Math.Max(max, dp[i]);
                }
                return max;
            }

            public int LengthOfLIS1(int[] nums)
            {
                int?[,] dp = new int?[nums.Length, nums.Length + 1];
                return LengthOfLISRec(nums, 0, -1, ref dp);
            }

            public int LengthOfLISRec(int[] nums, int curr, int prev, ref int?[,] dp)
            {
                if (curr == nums.Length) return 0;

                if (dp[curr, prev + 1].HasValue) return dp[curr, prev + 1].Value;
                int withCurrent = 0;
                if (prev == -1 || nums[curr] > nums[prev])
                    withCurrent = 1 + LengthOfLISRec(nums, curr + 1, curr, ref dp);
                int withoutCurr = LengthOfLISRec(nums, curr + 1, prev, ref dp);
                dp[curr, prev + 1] = Math.Max(withCurrent, withoutCurr);
                return dp[curr, prev + 1].Value;
            }
        }

        public class MissingNumber
        {
            public int Missing(ref int[] nums, int idx)
            {
                return nums[idx] - idx - 1;
            }

            public int FindKthPositive(int[] nums, int k)
            {
                var n = nums.Length;
                if (Missing(ref nums, 0) < k)
                    return k;

                if (Missing(ref nums, n - 1) < k)
                    return nums[n - 1] + k - Missing(ref nums, n - 1);

                int left = 0, right = n;
                while (left != right)
                {
                    var pivot = left + ((right - left) / 2);

                    if (Missing(ref nums, pivot) < k) left = pivot + 1;
                    else right = pivot;
                }

                return left - 1 < 0 ? k : nums[left - 1] + k - Missing(ref nums, left - 1);
            }
        }

    }
}
