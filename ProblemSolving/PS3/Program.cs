using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Helpers;

namespace PS3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sln = new Solution();

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

            //sln.Tictactoe(new[]
            //{
            //    new []{0,2},
            //    new []{0,1},
            //    new []{2,1},
            //}).Print();

            //sln.CountBalls(1, 10).Print();

            sln.CheckPartitioning("abccbdd").Print();
        }
    }

    public class Solution
    {
        private int modulo = 1_000_000_007;

        public int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;

            return SumOfLeftLeavesRec(root.left, true) + SumOfLeftLeavesRec(root.right, false);
        }

        private int SumOfLeftLeavesRec(TreeNode node, bool isLeft)
        {
            if (node == null) return 0;
            if (node.left == null && node.right == null)
                return isLeft ? node.val : 0;
            return SumOfLeftLeavesRec(node.left, true) + SumOfLeftLeavesRec(node.right, false);
        }

        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'L':
                        y--;
                        break;
                    case 'R':
                        y++;
                        break;
                    case 'U':
                        x--;
                        break;
                    case 'D':
                        x++;
                        break;
                }
            }

            return x == 0 && y == 0;
        }

        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            int minDif = int.MaxValue;
            var lst = new List<IList<int>>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var diff = arr[i + 1] - arr[i];
                if (minDif > diff)
                {
                    lst.Clear();
                    lst.Add(new List<int> { arr[i], arr[i + 1] });
                    minDif = diff;
                }
                else if (minDif == diff)
                {
                    lst.Add(new List<int> { arr[i], arr[i + 1] });
                }
            }
            return lst;
        }

        public bool CheckPartitioning(string s)
        {
            var dp = new bool[s.Length, s.Length];
            for (int i = 0; i < s.Length; i++)
                dp[i, i] = true;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        if (j - i == 1 || dp[i + 1, j - 1])
                        {
                            dp[i, j] = true;
                        }
                    }
                }
            }

            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        Console.Write(dp[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}

            return PartitionRec(0, 0, 0, ref dp);
        }

        private bool PartitionRec(int start, int end, int count, ref bool[,] dp)
        {
            var sLength = dp.GetLength(0);
            if (end == sLength)
            {
                if (count == 3)
                    return true;
                return false;
            }

            if(dp[start, end] && count < 3 && sLength - end >= (3 - count))
            {
                if (PartitionRec(end + 1, end + 1, count + 1, ref dp))
                    return true;
            }

            if(end < sLength - 1 && count <= 3 && sLength - end >= (3 - count) && PartitionRec(start, end + 1, count, ref dp))
                return true;
            return false;
        }

        public bool[] CanEat(int[] candiesCount, int[][] queries)
        {
            var prefixSum = new long[candiesCount.Length];
            long sum = 0;
            for (int i = 0; i < candiesCount.Length; i++)
            {
                sum += candiesCount[i];
                prefixSum[i] = sum;
            }

            var answer = new bool[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                var query = queries[i];
                int favoriteTypei = query[0], favoriteDayi = query[1], dailyCapi = query[2];
                
                var maxCanEat = dailyCapi * (favoriteDayi + 1);
                var needToEat = favoriteTypei > 0 ? prefixSum[favoriteTypei - 1] : 0;
                if (maxCanEat > needToEat && prefixSum[favoriteTypei] >= favoriteDayi + 1)
                    answer[i] = true;
            }

            return answer;
        }

        public int[] RestoreArray(int[][] adjacentPairs)
        {
            var indegrees = new Dictionary<int, int>();
            var outDegrees = new Dictionary<int, List<int>>();

            foreach (var adjacentPair in adjacentPairs)
            {
                int src = adjacentPair[0], dst = adjacentPair[1];
                if(!indegrees.ContainsKey(src))
                    indegrees.Add(src, 0);
                indegrees[src]++;
                if (!indegrees.ContainsKey(dst))
                    indegrees.Add(dst, 0);
                indegrees[dst]++;

                if (!outDegrees.ContainsKey(src))
                    outDegrees.Add(src, new List<int>());
                outDegrees[src].Add(dst);

                if (!outDegrees.ContainsKey(dst))
                    outDegrees.Add(dst, new List<int>());
                outDegrees[dst].Add(src);
            }

            var root = 0;
            foreach (var kv in indegrees)
            {
                if (kv.Value == 1) root = kv.Key;
            }

            var q = new Queue<int>();
            q.Enqueue(root);
            var visited = new HashSet<int>();
            visited.Add(root);

            var lst = new List<int>();
            while (q.Count > 0)
            {
                var src = q.Dequeue();
                lst.Add(src);

                foreach (var dst in outDegrees[src])
                {
                    if (!visited.Contains(dst))
                    {
                        visited.Add(dst);
                        q.Enqueue(dst);
                    }
                }
            }

            return lst.ToArray();
        }

        public int CountBalls(int lowLimit, int highLimit)
        {
            var dic = new Dictionary<int, int>();
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int sum = 0, num = i;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if(!dic.ContainsKey(sum))
                    dic.Add(sum, 0);
                dic[sum]++;
            }

            int max = 0;
            foreach (var kv in dic)
            {
                max = Math.Max(max, kv.Value);
            }

            return max;
        }

        public string Tictactoe(int[][] moves)
        {
            string pending = "Pending", draw = "Draw";
            var matrix = new int[3, 3];
            int i = 0;
            foreach (var move in moves)
            {
                matrix[move[0], move[1]] = (i % 2 == 0) ? 1 : 2;
                i++;
            }

            bool foundEmptyCell = false;
            // Check rows
            for (i = 0; i < 3; i++)
            {
                var winner = matrix[i, 0];
                var isWin = true;
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        foundEmptyCell = true;
                        isWin = false;
                    }
                    else if (matrix[i, j] != winner)
                    {
                        isWin = false;
                        break;
                    }
                }
                if (isWin)
                    return winner == 1 ? "A" : "B";
            }

            for (i = 0; i < 3; i++)
            {
                var winner = matrix[0, i];
                var isWin = true;
                for (int j = 0; j < 3; j++)
                {
                    if (matrix[j, i] == 0)
                    {
                        foundEmptyCell = true;
                        isWin = false;
                    }
                    else if (matrix[j, i] != winner)
                    {
                        isWin = false;
                        break;
                    }
                }
                if (isWin)
                    return winner == 1 ? "A" : "B";
            }

            var diagonal1 = matrix[1, 1] != 0 && matrix[0, 0] == matrix[1, 1] && matrix[2, 2] == matrix[1, 1];
            if (diagonal1)
                return matrix[0, 0] == 1 ? "A" : "B";
            var diagonal2 = matrix[1, 1] != 0 && matrix[0, 2] == matrix[1, 1] && matrix[2, 0] == matrix[1, 1];
            if (diagonal2)
                return matrix[0, 2] == 1 ? "A" : "B";
            return foundEmptyCell ? pending : draw;
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (string.IsNullOrEmpty(magazine))
                return string.IsNullOrEmpty(ransomNote);
            int[] aOcc = new int[26];
            foreach (var ch in magazine)
                aOcc[ch - 'a']++;

            foreach (var ch in ransomNote)
            {
                aOcc[ch - 'a']--;
                if (aOcc[ch - 'a'] < 0)
                    return false;
            }

            return true;
        }

        public int GetDecimalValue(ListNode head)
        {
            int length = 0;
            var node = head;
            while (node != null)
            {
                length++;
                node = node.next;
            }

            int sum = 0, @base = (int)Math.Pow(2, length - 1);
            node = head;
            while (node != null)
            {
                sum += @base * node.val;
                node = node.next;
                @base /= 2;
            }

            return sum;
        }

        public string ReformatDate(string date)
        {
            if (string.IsNullOrEmpty(date)) return string.Empty;
            var parts = date.Split(" ");
            var months = new List<string> { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            var day = parts[0][0] - '0';
            if (char.IsDigit(parts[0][1]))
                day = day * 10 + (parts[0][1] - '0');

            return $"{parts[2]}-{(months.IndexOf(parts[1]) + 1):D2}-{day:D2}";
        }

        public int MinCostClimbingStairs(int[] cost)
        {
            var dp = new int[cost.Length + 2];
            for (int i = cost.Length - 1; i >= 0; i--)
            {
                dp[i] = cost[i] + Math.Min(dp[i + 1], dp[i + 2]);
            }

            return Math.Min(dp[0], dp[1]);
        }

        public int MinCostClimbingStairs_TopDown(int[] cost)
        {
            var dp = new int?[cost.Length];
            return Math.Min(MinCostClimbingStairsRec(cost, 0, ref dp), MinCostClimbingStairsRec(cost, 1, ref dp));
        }

        private int MinCostClimbingStairsRec(int[] cost, int i, ref int?[] dp)
        {
            if (i >= cost.Length) return 0;

            if (!dp[i].HasValue)
            {
                dp[i] = cost[i] + Math.Min(MinCostClimbingStairsRec(cost, i + 1, ref dp),
                    MinCostClimbingStairsRec(cost, i + 2, ref dp));
            }
            return dp[i].Value;
        }
    }
}
