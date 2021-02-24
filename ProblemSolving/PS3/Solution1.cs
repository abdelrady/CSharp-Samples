using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Helpers;

namespace PS3
{
    public class Solution1
    {
        public int SumSubarrayMins(int[] A)
        {
            if (A == null || A.Length == 0) return 0;
            var sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = i; j < A.Length; j++)
                {
                    if (i == j)
                    {
                        min = A[i];
                    }
                    else
                    {
                        min = Math.Min(min, A[j]);

                    }
                    sum += min;
                    sum %= 1_000_000_007;
                }
            }

            return sum;
        }

        public int NumDistinctIslands(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;
            var hs = new HashSet<string>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        var path = new StringBuilder();
                        GenerateIslandPath(grid, i, j, 0, ref path);
                        hs.Add(path.ToString());
                    }
                }
            }
            return hs.Count;
        }

        private void GenerateIslandPath(int[][] grid, in int i, in int j, int stamp, ref StringBuilder sb)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == 0) return;

            grid[i][j] = 0;

            sb.Append(stamp);
            GenerateIslandPath(grid, i, j + 1, 1, ref sb);
            GenerateIslandPath(grid, i + 1, j, 2, ref sb);
            GenerateIslandPath(grid, i, j - 1, 3, ref sb);
            GenerateIslandPath(grid, i - 1, j, 4, ref sb);
            sb.Append(stamp);
        }

        public class NumArray
        {
            private int[] prefixSum;

            public NumArray(int[] nums)
            {
                prefixSum = new int[(nums?.Length ?? 0) + 1];
                if (nums == null || nums.Length == 0) return;
                for (int i = 0; i < nums.Length; i++)
                {
                    prefixSum[i + 1] = prefixSum[i] + nums[i];
                }
            }

            public int SumRange(int i, int j)
            {
                if (i > j || prefixSum.Length == 1) return 0;
                return prefixSum[j + 1] - prefixSum[i];
            }
        }

        public class NumArrayImmutable
        {
            private int[] segTreeArr;
            
            public NumArrayImmutable(int[] nums)
            {
                int newSize = 2 * nums?.Length ?? 0, start = 0;
                segTreeArr = new int[newSize];
                if (nums == null || nums.Length == 0) return;
                for (int i = nums.Length; i < newSize; i++)
                {
                    segTreeArr[i] = nums[start++];
                }

                for (int i = start - 1; i > 0; i--)
                {
                    segTreeArr[i] = segTreeArr[2 * i] + segTreeArr[2 * i + 1];
                }
            }

            public int SumRange(int i, int j)
            {
                if (i > j || segTreeArr.Length == 0) return 0;

                int n = segTreeArr.Length / 2;
                i += n;
                j += n;

                int sum = 0;
                while (i <= j)
                {
                    if (i % 2 == 1)
                    {
                        sum += segTreeArr[i];
                        i++;
                    }

                    if (j % 2 == 0)
                    {
                        sum += segTreeArr[j];
                        j--;
                    }

                    i /= 2;
                    j /= 2;
                }

                return sum;
            }

            public int SumRangeRecToFix(int i, int j)
            {
                if (i > j || segTreeArr.Length == 0) return 0;
                return SumRangeRec(1, 0, segTreeArr.Length / 2 - 1, i, j);
            }

            private int SumRangeRec(int treeIdx, int low, int high, in int i, in int j)
            {
                if (low > high) return 0;
                if (low == high) return segTreeArr[treeIdx];

                var mid = low + (high - low) / 2;

                if (i > mid)
                {
                    return SumRangeRec(treeIdx * 2 + 1, mid + 1, high, i, j);
                }
                else if (j <= mid)
                {
                    return SumRangeRec(treeIdx * 2, low, mid, i, j);
                }

                var leftSum = SumRangeRec(treeIdx * 2, low, mid, i, j);
                var rightSum = SumRangeRec(treeIdx * 2 + 1, mid + 1, high, i, j);

                return leftSum + rightSum;
            }
        }

        public class NumArrayMutable
        {
            private int[] segTreeArray;

            public NumArrayMutable(int[] nums)
            {
                segTreeArray = new int[4 * nums?.Length ?? 0];
                if (nums == null || nums.Length == 0) return;
                BuildSegTree(nums, 0, 0, nums.Length - 1);
            }

            private void BuildSegTree(int[] nums, int treeIndex, int low, int high)
            {
                if (low == high)
                {
                    segTreeArray[treeIndex] = nums[low];
                    return;
                }

                var mid = low + (high - low) / 2;
                BuildSegTree(nums, treeIndex * 2 + 1, low, mid);
                BuildSegTree(nums, treeIndex * 2 + 2, mid + 1, high);

                segTreeArray[treeIndex] = this.Merge(segTreeArray[treeIndex * 2 + 1], segTreeArray[treeIndex * 2 + 2]);
            }

            private int Merge(int leftval, int rightVal)
            {
                return leftval + rightVal;
            }

            public void Update(int i, int val)
            {
                if (segTreeArray.Length == 0) return;
                this.Update(0, 0, segTreeArray.Length / 4 - 1, i, val);
            }

            public void Update(int treeIndex, int low, int high, int arrIdx, int val)
            {
                if (low == high)
                {
                    segTreeArray[treeIndex] = val;
                    return;
                }

                int mid = low + (high - low) / 2;
                if (arrIdx <= mid)
                {
                    this.Update(treeIndex * 2 + 1, low, mid, arrIdx, val);
                }
                else
                {
                    this.Update(treeIndex * 2 + 2, mid + 1, high, arrIdx, val);
                }

                segTreeArray[treeIndex] = Merge(segTreeArray[2 * treeIndex + 1], segTreeArray[2 * treeIndex + 2]);
            }

            public int SumRange(int i, int j)
            {
                if (segTreeArray.Length == 0) return 0;
                return this.Query(0, 0, segTreeArray.Length / 4 - 1, i, j);
            }

            private int Query(int treeIdx, int low, int high, in int i, in int j)
            {
                if (low > high) return 0;
                if (low == high)
                {
                    return segTreeArray[treeIdx];
                }

                if (i <= low && j >= high) return segTreeArray[treeIdx];

                var mid = low + (high - low) / 2;
                if (j <= mid)
                {
                    return this.Query(2 * treeIdx + 1, low, mid, i, j);
                }
                else if (i > mid)
                {
                    return this.Query(2 * treeIdx + 2, mid + 1, high, i, j);
                }

                var leftSum = this.Query(2 * treeIdx + 1, low, mid, i, j);
                var rightSum = this.Query(2 * treeIdx + 2, mid + 1, high, i, j);
                return Merge(leftSum, rightSum);
            }
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;
            int interval = 1, n = lists.Length;
            while (interval < n)
            {
                for (int i = 0; i < n - interval; i += (2 * interval))
                {
                    lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
                }
                interval *= 2;
            }

            return lists[0];
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode l3 = new ListNode(), prev = l3;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }

            prev.next = l1 ?? l2;

            return l3.next;
        }

        public int FindKthLargest(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k > nums.Length || k < 1) return -1;
            return QuickSelect(nums, 0, nums.Length - 1, nums.Length - k);
        }

        private int QuickSelect(int[] nums, int left, in int right, in int k)
        {
            int pivot = nums[right], writeIndex = left, temp;
            for (int i = left; i < right; i++)
            {
                if (nums[i] <= pivot)
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
            if (orderSize == k) return nums[writeIndex];
            else if (orderSize > k)
            {
                return QuickSelect(nums, left, writeIndex - 1, k);
            }
            else
            {
                return QuickSelect(nums, writeIndex + 1, right, k - orderSize - 1);
            }
        }


        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            var lst = new List<string>();
            if (nums == null || nums.Length == 0)
            {
                lst.Add(lower == upper ? lower.ToString() : $"{lower}->{upper}");
                return lst;
            }

            int left = lower, right = nums[0] - 1;
            if (nums[0] > lower)
            {
                lst.Add(left == right ? left.ToString() : $"{left}->{right}");
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] > 1)
                {
                    left = nums[i - 1] + 1;
                    right = nums[i] - 1;
                    lst.Add(left == right ? left.ToString() : $"{left}->{right}");
                }
            }

            left = nums[nums.Length - 1] + 1;
            right = upper;
            if (nums[nums.Length - 1] < upper)
            {
                lst.Add(left == right ? left.ToString() : $"{left}->{right}");
            }

            return lst;
        }

        public int LengthOfLongestSubstringTwoDistinct(string s)
        {
            var dic = new Dictionary<char, int>();
            int left = 0, right = 0, max = 0;
            while (right < s.Length)
            {
                if (!dic.ContainsKey(s[right]))
                {
                    dic.Add(s[right], 1);
                }
                else
                {
                    dic[s[right]]++;
                }

                while (dic.Keys.Count > 2)
                {
                    dic[s[left]]--;
                    if (dic[s[left]] == 0)
                        dic.Remove(s[left]);
                    left++;
                }
                if (dic.Keys.Count <= 2) max = Math.Max(max, right - left + 1);
                right++;
            }

            return max;
        }

        public class Reader4
        {
            protected int Read4(char[] buf4)
            {
                return 0;
            }
        }

        public class Solution2 : Reader4
        {
            private char[] buf4 = new char[4];
            private int lastIdx = 4;
            private int lastRead = -1;
            /**
             * @param buf Destination buffer
             * @param n   Number of characters to read
             * @return    The number of actual characters read
             */
            public int Read(char[] buf, int n)
            {
                if (lastRead == 0) return 0;
                int idx = 0;
                while (n > 0)
                {
                    if (lastIdx == 4)
                    {
                        lastRead = Read4(buf4);
                        lastIdx = 0;
                    }

                    while (lastIdx < lastRead && n > 0)
                    {
                        buf[idx++] = buf4[lastIdx++];
                        n--;
                    }

                    if (lastRead < 4) break;
                }

                return idx;
            }
        }

        public int MinOperations(int[] nums, long x)
        {
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            int left = 0, right = 0, n = nums.Length, minOperations = int.MaxValue;

            for (right = 0; right < n; right++)
            {
                sum -= nums[right];
                while (sum < x && left <= right)
                {
                    sum += nums[left++];
                }

                if (sum == x)
                {
                    minOperations = Math.Min(minOperations, (n - right - 1) + left);
                }
            }

            return minOperations == int.MaxValue ? -1 : minOperations;
        }

        public int MinOperations2(int[] nums, long x)
        {
            int n = nums.Length;
            long[] leftSum = new long[n], rightSum = new long[n];

            int sumSoFar = 0;
            for (int i = 0; i < n; i++)
            {
                sumSoFar += nums[i];
                leftSum[i] = sumSoFar;
            }

            sumSoFar = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                sumSoFar += nums[i];
                rightSum[i] = sumSoFar;
            }

            var dic = new Dictionary<long, int>();
            dic.Add(x, -1);
            int minOperations = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (leftSum[i] > x) break;
                if (leftSum[i] == x) minOperations = i + 1;
                dic.Add(x - leftSum[i], i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (dic.ContainsKey(rightSum[i]) && dic[rightSum[i]] < i)
                {
                    minOperations = Math.Min(minOperations, dic[rightSum[i]] + (n - i) + 1);
                }
            }

            return minOperations == int.MaxValue ? -1 : minOperations;
        }
        public int MinOperations1(int[] nums, long x)
        {
            if (nums.Length == 0) return -1;
            if (x == 0) return 0;
            var min = int.MaxValue;
            int?[] dp = new int?[3 * nums.Length];
            MinOperationsRec(nums, 0, nums.Length - 1, x, ref min, ref dp);

            return min == int.MaxValue ? -1 : min;
        }

        private int MinOperationsRec(int[] nums, int left, int right, in long x, ref int min, ref int?[] dp)
        {
            if (x < 0) return int.MaxValue;
            if (x == 0)
            {
                var val = nums.Length - (right - left + 1);
                min = Math.Min(min, val);
                return val;
            }

            if (left > right) return int.MaxValue;
            if (dp[left + nums.Length + right].HasValue) return dp[left + nums.Length + right].Value;

            var option1 = MinOperationsRec(nums, left + 1, right, x - nums[left], ref min, ref dp);
            var option2 = MinOperationsRec(nums, left, right - 1, x - nums[right], ref min, ref dp);
            dp[left + nums.Length + right] = Math.Min(option1, option2);
            return dp[left + nums.Length + right].Value;
        }

        public bool CloseStrings(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) && string.IsNullOrEmpty(word2)) return true;
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2) || word1.Length != word2.Length) return false;

            int[] occ1 = new int[26], occ2 = new int[26];
            for (int i = 0; i < word1.Length; i++)
            {
                occ1[word1[i] - 'a']++;
                occ2[word2[i] - 'a']++;
            }

            var dic = new Dictionary<int, int>();
            for (int i = 0; i < 26; i++)
            {
                if ((occ1[i] == 0 && occ2[i] != 0) || (occ1[i] != 0 && occ2[i] == 0)) return false;
                if (occ1[i] > 0)
                {
                    if (dic.ContainsKey(occ1[i]))
                    {
                        dic[occ1[i]]++;
                    }
                    else dic.Add(occ1[i], 1);
                }
                if (occ2[i] > 0)
                {
                    if (dic.ContainsKey(occ2[i]))
                    {
                        dic[occ2[i]]++;
                    }
                    else dic.Add(occ2[i], 1);
                }
            }

            foreach (var kv in dic)
            {
                if (kv.Value % 2 != 0) return false;
            }

            return true;
        }

        public class OrderedStream
        {
            private string[] arr;
            private int idx = 0;

            public OrderedStream(int n)
            {
                arr = new string[n];
            }

            public IList<string> Insert(int id, string value)
            {
                arr[id - 1] = value;
                var lst = new List<string>();
                while (idx < arr.Length)
                {
                    if (!string.IsNullOrWhiteSpace(arr[idx]))
                    {
                        lst.Add(arr[idx]);
                        idx++;
                    }
                    else break;
                }
                return lst;
            }
        }


        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var dic = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    if (dic[s[i]] != t[i])
                        return false;
                }
                else
                {
                    if (!dic.ContainsKey(t[i]))
                    {
                        dic.Add(s[i], t[i]);
                    }
                    else return false;
                }
            }
            return true;
        }

        public bool IsStrobogrammatic(string num)
        {
            if (string.IsNullOrEmpty(num)) return true;
            var dic = new Dictionary<char, char>
            {
                {'0', '0'},
                {'1', '1'},
                {'6', '9'},
                {'9', '6'},
                {'8', '8'},
            };

            var singles = new HashSet<char> { '0', '1', '8' };

            for (int i = 0; i <= num.Length / 2; i++)
            {
                var j = num.Length - i - 1;
                if (i == j && !singles.Contains(num[j])) return false;
                if (!dic.ContainsKey(num[i]) || !dic.ContainsKey(num[j]) || num[i] != dic[num[j]]) return false;
            }

            return true;
        }

        public class BSTIterator
        {
            Stack<TreeNode> forwardSt = new Stack<TreeNode>();
            Stack<TreeNode> backwardSt = new Stack<TreeNode>();
            public BSTIterator(TreeNode root)
            {
                while (root != null)
                {
                    forwardSt.Push(root);
                    root = root.left;
                }
            }

            /** @return the next smallest number */
            public int Next()
            {
                var lowest = forwardSt.Pop();
                if (forwardSt.Count > 0)
                {
                    forwardSt.Peek().left = null;
                }

                var rightNode = lowest.right;
                while (rightNode != null)
                {
                    forwardSt.Push(rightNode);
                    rightNode = rightNode.left;
                }

                lowest.right = null;
                backwardSt.Push(lowest);
                return lowest.val;
            }

            /** @return whether we have a next smallest number */
            public bool HasNext()
            {
                return forwardSt.Count > 0;
            }

            public bool HasPrev()
            {
                return backwardSt.Count > 0;
            }

            public int Prev()
            {
                forwardSt.Push(backwardSt.Pop());
                return backwardSt.Peek().val;
            }
        }

        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            var dsu = new DSU(10001);
            var emailToId = new Dictionary<string, int>();
            var emailToName = new Dictionary<string, string>();
            int idx = 0;
            foreach (var account in accounts)
            {
                var name = "";
                foreach (var email in account)
                {
                    if (name == "")
                    {
                        name = email;
                        continue;
                    }

                    if (!emailToName.ContainsKey(email)) emailToName.Add(email, name);
                    if (!emailToId.ContainsKey(email)) emailToId.Add(email, idx++);

                    dsu.Union(emailToId[email], emailToId[account[1]]);
                }
            }

            var resultsDic = new Dictionary<int, List<string>>();
            foreach (var kv in emailToId)
            {
                var parent = dsu.GetParent(kv.Value);

                if (resultsDic.ContainsKey(parent))
                {
                    resultsDic[parent].Add(kv.Key);
                }
                else resultsDic.Add(parent, new List<string> { kv.Key });
            }

            var lst = new List<IList<string>>();
            foreach (var emails in resultsDic.Values)
            {
                var record = emails
                    .OrderBy(x => x, Comparer<string>.Create(string.CompareOrdinal))
                    .ToList();
                record.Insert(0, emailToName[record[0]]);
                lst.Add(record);

            }
            return lst;
        }

        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int min = prices[0], max = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > min)
                {
                    max = Math.Max(max, prices[i] - min);
                }

                if (prices[i] < min)
                {
                    min = prices[i];
                }
            }

            return max;
        }

        public int MaxProduct(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;

            int maxSoFar = nums[0], minSoFar = nums[0], max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = Math.Max(nums[i], Math.Max(maxSoFar * nums[i], minSoFar * nums[i]));
                minSoFar = Math.Min(nums[i], Math.Min(maxSoFar * nums[i], minSoFar * nums[i]));
                maxSoFar = temp;
                max = Math.Max(max, maxSoFar);
            }

            return max;
        }

        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0) return intervals;

            int i = 1, n = intervals.Length;
            var ls = new LinkedList<int[]>();
            intervals = intervals.OrderBy(arr => arr[0]).ToArray();
            ls.AddLast(intervals[0]);

            while (i < n)
            {
                if (ls.Last.Value[1] < intervals[i][0])
                {
                    ls.AddLast(intervals[i]);
                }
                else
                {
                    ls.Last.Value[1] = Math.Max(ls.Last.Value[1], intervals[i][1]);
                }
                i++;
            }

            return ls.ToArray();
        }

        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            if (intervals == null || intervals.Length == 0) return new[] { newInterval };
            if (newInterval == null || newInterval.Length == 0) return intervals;

            int idx = 0, n = intervals.Length;
            var ls = new LinkedList<int[]>();

            // No overlap
            while (idx < n && intervals[idx][0] < newInterval[0])
            {
                ls.AddLast(intervals[idx++]);
            }

            // merge new interval
            if (ls.Count == 0 || ls.Last.Value[1] < newInterval[0])
            {
                ls.AddLast(newInterval);
            }
            else
            {
                var interval = ls.Last.Value;
                ls.RemoveLast();
                ls.AddLast(new[] { interval[0], Math.Max(interval[1], newInterval[1]) });
            }

            while (idx < n)
            {
                newInterval = intervals[idx++];
                if (ls.Last.Value[1] < newInterval[0])
                {
                    ls.AddLast(newInterval);
                }
                else
                {
                    var interval = ls.Last.Value;
                    ls.RemoveLast();
                    ls.AddLast(new[] { interval[0], Math.Max(interval[1], newInterval[1]) });
                }
            }

            return ls.ToArray();
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            int max = 0;
            DiameterOfBinaryTreeRec(root, ref max);
            return max;
        }

        private int DiameterOfBinaryTreeRec(TreeNode node, ref int max)
        {
            if (node == null) return -1;

            var left = DiameterOfBinaryTreeRec(node.left, ref max);
            var right = DiameterOfBinaryTreeRec(node.right, ref max);

            max = Math.Max(max, left + right + 2);
            var curr = 1 + Math.Max(left, right);

            return curr;
        }

        public int CountNodes(TreeNode root)
        {
            if (root == null) return 0;

            var height = -1;
            var node = root;
            while (node != null)
            {
                node = node.left;
                height++;
            }

            if (height == 0) return 1;

            int left = 1, right = (int)Math.Pow(2, height) - 1, mid;
            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (IsNodeExist(root, height, mid))
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return (int)Math.Pow(2, height) + left - 1;
        }

        private bool IsNodeExist(TreeNode node, int height, in int pivot)
        {
            int left = 0, right = (int)Math.Pow(2, height) - 1, mid;
            for (int i = 0; i < height; i++)
            {
                mid = left + (right - left) / 2;
                if (pivot <= mid)
                {
                    node = node.left;
                    right = mid;
                }
                else
                {
                    node = node.right;
                    left = mid + 1;
                }
            }

            return node != null;
        }

        public string DecodeString(string s)
        {
            int i = 0;
            return DecodeStringRec(s, ref i);
        }

        private string DecodeStringRec(string s, ref int i)
        {
            var sb = new StringBuilder(s.Length - i);

            while (i < s.Length && s[i] != ']')
            {
                if (!char.IsDigit(s[i]))
                {
                    sb.Append(s[i]);
                    i++;
                }
                else
                {
                    int repeatCount = 0;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        repeatCount = repeatCount * 10 + (s[i] - '0');
                        i++;
                    }

                    // Skip [
                    i++;

                    var str = DecodeStringRec(s, ref i);
                    while (repeatCount > 0)
                    {
                        sb.Append(str);
                        repeatCount--;
                    }

                    // Skip ]
                    i++;
                }
            }

            return sb.ToString();
        }

        public int LongestIncreasingPath(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) return 0;
            int[,] pathLength = new int[matrix.Length, matrix[0].Length];

            int max = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (pathLength[i, j] == 0)
                    {
                        pathLength[i, j] = LongestIncreasingPathRec(matrix, i, j, int.MinValue, ref pathLength);
                        max = Math.Max(pathLength[i, j], max);
                    }
                }
            }

            return max;
        }

        private int LongestIncreasingPathRec(int[][] matrix, in int i, in int j, int prev, ref int[,] pathLength)
        {
            if (i < 0 || i >= matrix.Length || j < 0 || j >= matrix[i].Length || matrix[i][j] <= prev) return 0;

            if (pathLength[i, j] > 0) return pathLength[i, j];

            var option1 = LongestIncreasingPathRec(matrix, i, j - 1, matrix[i][j], ref pathLength);
            var option2 = LongestIncreasingPathRec(matrix, i, j + 1, matrix[i][j], ref pathLength);
            var option3 = LongestIncreasingPathRec(matrix, i + 1, j, matrix[i][j], ref pathLength);
            var option4 = LongestIncreasingPathRec(matrix, i - 1, j, matrix[i][j], ref pathLength);

            pathLength[i, j] = 1 + Math.Max(option1, Math.Max(option2, Math.Max(option3, option4)));
            return pathLength[i, j];
        }

        public int MinDeletions(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            var freq = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i] - 'a']++;
            }

            var dic = new Dictionary<int, int>();
            for (int i = 0; i < freq.Length; i++)
            {
                if (dic.ContainsKey(freq[i]))
                {
                    dic[freq[i]]++;
                }
                else dic.Add(freq[i], 1);
            }

            int count = 0;
            for (int ki = 0; ki < dic.Keys.Count; ki++)
            {
                var key = dic.Keys.ElementAt(ki);
                if (key == 0 || dic[key] <= 1) continue;
                var i = -1;
                while (dic[key] > 1)
                {
                    i = key;
                    //i = i == -1 ? key : (i - 1);
                    while (i > 0 && dic.ContainsKey(i))
                    {
                        i--;
                        count++;
                    }
                    if (i > 0) dic.Add(i, 1);
                    dic[key]--;
                }
            }

            return count;
        }

        /*
         nums[0] = 0
        nums[1] = 1
        nums[2 * i] = nums[i] when 2 <= 2 * i <= n
        nums[2 * i + 1] = nums[i] + nums[i + 1] when 2 <= 2 * i + 1 <= n
         
         */
        public int GetMaximumGenerated(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            int[] dp = new int[n + 2];
            dp[0] = 0;
            dp[1] = 1;

            int max = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                dp[2 * i] = dp[i];
                max = Math.Max(max, dp[2 * i]);

                if (2 * i + 1 <= n)
                {
                    dp[2 * i + 1] = dp[i] + dp[i + 1];
                    max = Math.Max(max, dp[2 * i + 1]);
                }
            }

            return max;
        }

        public int ScheduleCourse(int[][] courses)
        {
            courses = courses.OrderBy(course => course[1]).ToArray();
            var dp = new int?[courses.Length, courses[courses.Length - 1][1] + 1];
            int max = ScheduleCourseRec(courses, 0, 0, ref dp);
            return max;
        }

        private int ScheduleCourseRec(int[][] courses, int i, int currentTime, ref int?[,] dp)
        {
            if (i == courses.Length)
            {
                return 0;
            }

            if (dp[i, currentTime].HasValue) return dp[i, currentTime].Value;

            var (duration, expireAt) = (courses[i][0], courses[i][1]);
            int taken = 0;
            if (currentTime + duration <= expireAt)
            {
                taken = 1 + ScheduleCourseRec(courses, i + 1, currentTime + duration, ref dp);
            }
            var nonTaken = ScheduleCourseRec(courses, i + 1, currentTime, ref dp);

            dp[i, currentTime] = Math.Max(taken, nonTaken);
            return dp[i, currentTime].Value;
        }

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            if (numCourses == 0) return new int[0];
            if (prerequisites == null || prerequisites.Length == 0)
            {
                return Enumerable.Range(0, numCourses).ToArray();
            }

            var inDegrees = new int[numCourses];
            var outDegrees = new Dictionary<int, List<int>>();

            foreach (var prerequisite in prerequisites)
            {
                inDegrees[prerequisite[0]]++;
                if (outDegrees.ContainsKey(prerequisite[1]))
                {
                    outDegrees[prerequisite[1]].Add(prerequisite[0]);
                }
                else
                {
                    outDegrees.Add(prerequisite[1], new List<int> { prerequisite[0] });
                }
            }

            var q = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (inDegrees[i] == 0)
                {
                    q.Enqueue(i);
                }
            }

            var orderList = new List<int>();
            while (q.Count > 0)
            {
                var prerequisite = q.Dequeue();
                orderList.Add(prerequisite);
                if (outDegrees.ContainsKey(prerequisite))
                {
                    foreach (var course in outDegrees[prerequisite])
                    {
                        inDegrees[course]--;
                        if (inDegrees[course] == 0)
                        {
                            q.Enqueue(course);
                        }
                    }
                }
            }

            return orderList.Count == numCourses ? orderList.ToArray() : new int[0];
        }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord)) return 0;
            if (!wordList.Contains(beginWord)) wordList.Add(beginWord);

            if (CanMoveTo(beginWord, endWord))
            {
                return 2;
            }

            var graph = new Dictionary<string, HashSet<string>>();
            graph.Add(beginWord, new HashSet<string>());

            var visited = new Dictionary<string, bool>();
            for (int i = 0; i < wordList.Count; i++)
            {
                var word = wordList[i];
                visited.Add(word, false);
                if (!graph.ContainsKey(word)) graph.Add(word, new HashSet<string>());
                if (beginWord != word && CanMoveTo(beginWord, word))
                {
                    graph[beginWord].Add(word);
                }
            }
            visited[beginWord] = true;

            for (int i = 0; i < wordList.Count; i++)
            {
                for (int j = 0; j < wordList.Count; j++)
                {
                    if (i == j) continue;
                    if (CanMoveTo(wordList[i], wordList[j]))
                    {
                        graph[wordList[i]].Add(wordList[j]);
                        graph[wordList[j]].Add(wordList[i]);
                    }
                }
            }

            var q = new Queue<string>();
            q.Enqueue(beginWord);
            q.Enqueue(null);
            int movesCount = 0, minMovesCount = int.MaxValue;
            while (q.Count > 0)
            {
                string item = q.Dequeue();
                if (item == null)
                {
                    movesCount++;
                    if (q.Count > 0) q.Enqueue(null);
                    continue;
                }
                if (item == endWord)
                {
                    movesCount++;
                    minMovesCount = Math.Min(movesCount, minMovesCount);
                    continue;
                }

                var moves = graph[item];
                foreach (var move in moves)
                {
                    if (!visited[move])
                    {
                        q.Enqueue(move);
                        visited[move] = true;
                    }
                }
            }

            return minMovesCount == int.MaxValue ? 0 : minMovesCount;
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

        public ListNode MergeTwoLists1(ListNode l1, ListNode l2)
        {
            ListNode newRoot = new ListNode(-1);
            var node = newRoot;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    node.next = l1;
                    l1 = l1.next;
                    node.next.next = null;
                }
                else
                {
                    node.next = l2;
                    l2 = l2.next;
                    node.next.next = null;
                }
                node = node.next;
            }

            if (l1 != null)
            {
                node.next = l1;
            }

            if (l2 != null)
            {
                node.next = l2;
            }

            return newRoot.next;
        }
        public string Multiply(string num1, string num2)
        {
            if (num1 == null && num2 == null) return string.Empty;
            if (string.IsNullOrEmpty(num1))
            {
                return num2;
            }
            if (string.IsNullOrEmpty(num2))
            {
                return num1;
            }

            if (num1 == "0" || num2 == "0") return "0";

            var sb = new StringBuilder();
            int product = 0, sbIdx = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int carry = 0;
                sbIdx = i == num1.Length - 1 ? int.MaxValue : num1.Length - i - 1;
                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    product = (num1[i] - '0') * (num2[j] - '0') + carry + (sbIdx < sb.Length ? (sb[sbIdx] - '0') : 0);
                    carry = product / 10;
                    if (sb.Length <= sbIdx) sb.Append(product % 10);
                    else sb[sbIdx] = (char)(product % 10 + 48);
                    sbIdx = sbIdx == int.MaxValue ? int.MaxValue : sbIdx + 1;
                }
                if (carry > 0)
                {
                    if (sb.Length <= sbIdx) sb.Append(carry);
                    else sb[sbIdx] = (char)((sb[sbIdx] - '0') + (carry) + '0');
                }
            }
            return new String(sb.ToString().Reverse().ToArray());
        }

        public int NumTeams(int[] rating)
        {
            int minI = rating[0], maxI = rating[0], count = 0;
            for (int i = 0; i < rating.Length; i++)
            {
                minI = maxI = rating[i];
                for (int j = 1; j < rating.Length; j++)
                {
                    for (int k = j + 1; k < rating.Length; k++)
                    {
                        if (minI < rating[j] && rating[j] < rating[k]) count++;
                        if (maxI > rating[j] && rating[j] > rating[k]) count++;
                    }

                    //minI = Math.Min(minI, rating[j]);
                    //maxI = Math.Max(maxI, rating[j]);
                }
            }

            return count;
        }

        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            Array.Sort(pieces, Comparer<int[]>.Create((a, b) =>
            {
                int n = Math.Min(a.Length, b.Length);
                for (int i = 0; i < n; i++)
                {
                    if (a[i] == b[i]) continue;
                    else return a[i] - b[i];
                }

                return a.Length - b.Length;
            }));

            for (int i = 0; i < arr.Length; i++)
            {
                int low = 0, high = pieces.Length - 1, target = arr[i], mid = 0;
                while (low <= high)
                {
                    mid = low + (high - low) / 2;
                    if (pieces[mid][0] == target) break;
                    else if (pieces[mid][0] < target) low = mid + 1;
                    else high = mid - 1;
                }

                for (int j = 0; j < pieces[mid].Length; j++)
                {
                    if (arr[i++] != pieces[mid][j]) return false;
                }

                i--;
            }

            return true;
        }

        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            int?[] dp = new int?[heights.Length];
            return FurthestBuildingRec(heights, bricks, ladders, 0, ref dp);
        }

        private int FurthestBuildingRec(int[] heights, in int bricks, in int ladders, int idx, ref int?[] dp)
        {
            if (ladders < 0 || bricks < 0) return idx - 1;
            if (idx == heights.Length - 1) return idx;

            if (dp[idx].HasValue) return dp[idx].Value;

            if (heights[idx + 1] <= heights[idx])
            {
                dp[idx] = FurthestBuildingRec(heights, bricks, ladders, idx + 1, ref dp);
            }
            else
            {
                var option1 = FurthestBuildingRec(heights, bricks - (heights[idx + 1] - heights[idx]), ladders, idx + 1, ref dp);
                var option2 = FurthestBuildingRec(heights, bricks, ladders - 1, idx + 1, ref dp);
                dp[idx] = Math.Max(option1, option2);
            }

            return dp[idx].Value;
        }

        public int CountVowelStrings(int n)
        {
            int[] fact = new int[n];
            fact[0] = 1;
            for (int i = 1; i < n; i++)
            {
                fact[i] = i * fact[i - 1];
            }

            return fact[n] / (fact[n - 5] * fact[5]) + n;
        }

        public bool RepeatedSubstringPattern(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;

            int right = -1;
            for (int i = 1; i <= s.Length / 2; i++)
            {
                if (s[i] == s[0])
                {
                    right = i;
                    break;
                }
            }

            if (right == -1) return false;

            int rightStart = right, left = 0;
            do
            {
                left = 0;
                while (right < s.Length && s[right] == s[left])
                {
                    left = (left + 1) % rightStart;
                    right++;
                }

                if (right == s.Length) return right % rightStart == 0;
                if (rightStart < s.Length / 2)
                    right = ++rightStart;
                else return false;
            } while (right < s.Length);

            return false;
        }

        public int MaxProfit(int k, int[] prices)
        {
            if (k >= prices.Length / 2)
            {
                return MaxProfit_UnLimitedTransactions(prices);
            }

            int[] Ti0 = new int[k + 1], Ti1 = new int[k + 1];
            for (int i = 0; i <= k; i++)
                Ti1[i] = int.MinValue;
            for (int j = 0; j < prices.Length; j++)
            {
                var price = prices[j];
                for (int i = k; i > 0; i--)
                {
                    Ti0[i] = Math.Max(Ti0[i], Ti1[i] + price);
                    Ti1[i] = Math.Max(Ti1[i], Ti0[i - 1] - price);
                }
            }

            return Ti0[k];
        }

        public int MaxProfit_2TransactionsOnly(int[] prices)
        {
            int Ti10 = 0, Ti11 = int.MinValue, Ti20 = 0, Ti21 = int.MinValue;
            for (int i = 0; i < prices.Length; i++)
            {
                Ti20 = Math.Max(Ti20, Ti21 + prices[i]);
                Ti21 = Math.Max(Ti21, Ti10 - prices[i]);
                Ti10 = Math.Max(Ti10, Ti11 + prices[i]);
                Ti11 = Math.Max(Ti11, -1 * prices[i]);
            }
            return Ti20;
        }

        public int MaxProfit_CoolDown(int[] prices)
        {
            //T[i][k][0] = max(T[i - 1][k][0], T[i - 1][k][1] + prices[i])
            //T[i][k][1] = max(T[i - 1][k][1], T[i - 1][k][0] - prices[i])
            int Tik0 = 0, Tik1 = int.MinValue, TiMinus1k0, TiMinus2k0 = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                TiMinus1k0 = Tik0;
                Tik0 = Math.Max(Tik0, Tik1 + prices[i]);
                Tik1 = Math.Max(Tik1, TiMinus2k0 - prices[i]);
                TiMinus2k0 = TiMinus1k0;
            }
            return Tik0;
        }

        public int MaxProfit_UnLimitedTransactions(int[] prices)
        {
            //T[i][k][0] = max(T[i - 1][k][0], T[i - 1][k][1] + prices[i])
            //T[i][k][1] = max(T[i - 1][k][1], T[i - 1][k][0] - prices[i])
            int Tik0 = 0, Tik1 = int.MinValue, TiMinus1k0;

            for (int i = 0; i < prices.Length; i++)
            {
                TiMinus1k0 = Tik0;
                Tik0 = Math.Max(Tik0, Tik1 + prices[i]);
                Tik1 = Math.Max(Tik1, TiMinus1k0 - prices[i]);
            }
            return Tik0;
        }

        public int MaxProfit_1Transaction(int[] prices)
        {
            int Tik0 = 0, Tik1 = int.MinValue;
            for (int i = 0; i < prices.Length; i++)
            {
                Tik0 = Math.Max(Tik0, Tik1 + prices[i]);
                Tik1 = Math.Max(Tik1, -1 * prices[i]);
            }
            return Tik0;
        }

        public int MaxProfit_Easy(int[] prices)
        {
            int min = int.MaxValue, maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > min)
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - min);
                }

                min = Math.Min(min, prices[i]);
            }

            return maxProfit;
        }

        public int MaxProfit5(int[] prices)
        {
            var dp = new int[prices.Length + 2];

            for (int i = prices.Length - 1; i >= 0; i--)
            {
                int option1 = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] > prices[i])
                        option1 = Math.Max(option1, prices[j] - prices[i] + dp[j + 2]);
                }

                var option2 = dp[i + 1];

                dp[i] = Math.Max(option1, option2);
            }

            return dp[0];
        }

        public int MaxProfit_BottomUp(int[] prices)
        {
            var dp = new int?[prices.Length, prices.Length];
            var result = MaxProfitRec(prices, 0, 1, ref dp);
            return result;
        }

        private int MaxProfitRec(int[] prices, int buyAt, int currentAt, ref int?[,] dp)
        {
            if (currentAt >= prices.Length) return 0;

            if (dp[buyAt, currentAt].HasValue) return dp[buyAt, currentAt].Value;

            int option1 = 0, option2 = 0, option3 = 0;

            if (prices[currentAt] >= prices[buyAt])
            {
                option1 = (prices[currentAt] - prices[buyAt]) + MaxProfitRec(prices, currentAt + 2, currentAt + 3, ref dp);
            }

            option2 = MaxProfitRec(prices, buyAt, currentAt + 1, ref dp);

            option3 = MaxProfitRec(prices, currentAt, currentAt + 1, ref dp);

            dp[buyAt, currentAt] = Math.Max(option1, Math.Max(option2, option3));

            return dp[buyAt, currentAt].Value;
        }

        public class UndergroundSystem
        {
            private Dictionary<int, (string stationName, int t)> persons;
            private Dictionary<(string, string), (int totalTimes, int count)> avg;

            public UndergroundSystem()
            {
                persons = new Dictionary<int, (string stationName, int t)>();
                avg = new Dictionary<(string, string), (int totalTimes, int count)>();
            }

            public void CheckIn(int id, string stationName, int t)
            {
                persons.Add(id, (stationName, t));
            }

            public void CheckOut(int id, string stationName, int t)
            {
                var (src, startTime) = persons[id];

                var key = (src, stationName);
                if (avg.ContainsKey(key))
                {
                    avg[key] = (avg[key].totalTimes + (t - startTime), avg[key].count + 1);

                }
                else avg.Add(key, (t - startTime, 1));

                persons.Remove(id);
            }

            public double GetAverageTime(string startStation, string endStation)
            {
                var item = avg[(startStation, endStation)];
                return item.totalTimes / item.count;
            }
        }

        public int StrongPasswordChecker(string s)
        {
            var missing = 3 - FindLowerUpperAndDigit(s);

            if (s.Length < 6) return Math.Max(6 - s.Length, missing);

            var repeatingToFix = FindRepeatingChars(s);
            if (s.Length > 20)
            {
                var delete = s.Length - 20;

                repeatingToFix.replace -= Math.Min(delete, repeatingToFix.ones);

                repeatingToFix.replace -= Math.Min(Math.Max(delete - repeatingToFix.ones, 0), repeatingToFix.twos) / 2;

                repeatingToFix.replace -= Math.Max(delete - repeatingToFix.ones - repeatingToFix.twos, 0) / 3;

                return delete + Math.Max(missing, repeatingToFix.replace);
            }
            else
            {
                return Math.Max(repeatingToFix.replace, missing);
            }
        }

        private (int replace, int ones, int twos) FindRepeatingChars(string s)
        {
            // only need replacement and deletion now when s.Length >= 6
            int replace = 0; // total replacements for repeated chars. e.g. "aaa" needs 1 replacement to fix
            int oned = 0; // total deletions for 3n repeated chars. e.g. "aaa" needs 1 deletion to fix
            int twod = 0; // total deletions for 3n+1 repeated chars. e.g. "aaaa" needs 2 deletions to fix.

            for (int i = 0; i < s.Length;)
            {
                int len = 1; // repeated len
                while (i + len < s.Length && s[i + len] == s[i + len - 1]) len++;
                if (len >= 3)
                {
                    replace += len / 3;
                    if (len % 3 == 0) oned += 1;
                    if (len % 3 == 1) twod += 2;
                }
                i += len;
            }

            return (replace, oned, twod);
        }

        private int FindLowerUpperAndDigit(string s)
        {
            int lower = 0, upper = 0, digit = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z') lower = 1;
                if (s[i] >= 'A' && s[i] <= 'Z') upper = 1;
                if (s[i] >= '0' && s[i] <= '9') digit = 1;

                if (lower == 1 && upper == 1 && digit == 1) break;
            }

            return lower + upper + digit;
        }

        public class MaxStack
        {
            Stack<int> mainSt = new Stack<int>(4);
            Stack<int> monotonicIncreasingSt = new Stack<int>(4);

            /** initialize your data structure here. */
            public MaxStack()
            {

            }

            public void Push(int x)
            {
                var max = monotonicIncreasingSt.Count == 0 ? x : monotonicIncreasingSt.Peek();
                monotonicIncreasingSt.Push(Math.Max(x, max));
                mainSt.Push(x);
            }

            public int Pop()
            {
                monotonicIncreasingSt.Pop();
                return mainSt.Pop();
            }

            public int Top()
            {
                return mainSt.Peek();
            }

            public int PeekMax()
            {
                return monotonicIncreasingSt.Peek();
            }

            public int PopMax()
            {
                var max = monotonicIncreasingSt.Peek();

                var tempSt = new Stack<int>();
                while (mainSt.Peek() != max)
                {
                    tempSt.Push(this.Pop());
                }

                this.Pop();

                while (tempSt.Count > 0)
                {
                    this.Push(tempSt.Pop());
                }

                return max;
            }
        }

        public int MaxProfit1(int[] prices)
        {
            var st = new Stack<int>();
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (st.Count > 0 && prices[i] < st.Peek())
                {
                    int sellOn = st.Pop(), buyOn = -1;
                    while (st.Count > 0 && sellOn >= st.Peek())
                    {
                        buyOn = st.Pop();
                    }
                    if (buyOn > -1) maxProfit += (sellOn - buyOn);
                }

                st.Push(prices[i]);
            }

            if (st.Count > 0)
            {
                int sellOn = st.Pop(), buyOn = -1;
                while (st.Count > 0 && sellOn >= st.Peek())
                {
                    buyOn = st.Pop();
                }
                if (buyOn > -1) maxProfit += (sellOn - buyOn);
            }

            return maxProfit;
        }

        public bool ReachingPoints(int sx, int sy, int tx, int ty)
        {
            while (tx >= sx && ty >= sy)
            {
                if (sx == tx && sy == ty) return true;
                if (tx > ty)
                {
                    if (ty > sy) tx = tx % ty;
                    else return (tx - sx) % sy == 0;
                }
                else
                {
                    if (tx > sx) ty %= tx;
                    else return (ty - sy) % tx == 0;
                }
            }

            return false;
        }

        public bool CheckPossibility(int[] nums)
        {
            int violationsCount = 0;
            for (int i = 1; i < nums.Length && violationsCount < 2; i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    violationsCount++;
                    if (i - 2 < 0 || nums[i - 2] <= nums[i]) nums[i - 1] = nums[i];
                    else nums[i] = nums[i - 1];
                }
            }

            return violationsCount < 2;
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                max = Math.Max(max, candies[i]);
            }

            var lst = new List<bool>(candies.Length);
            for (int i = 0; i < candies.Length; i++)
            {
                lst.Add(candies[i] + extraCandies >= max);
            }

            return lst;
        }

        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null) return t == null;
            if (t == null) return true;

            var q = new Queue<TreeNode>();
            q.Enqueue(s);

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                if (node.val == t.val)
                {
                    if (IsTreeEqual(node, t)) return true;
                }
                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            return false;
        }

        private bool IsTreeEqual(TreeNode a, TreeNode b)
        {
            if (a == null || b == null) return a == null && b == null;
            return a.left?.val == b.left?.val &&
                   a.right?.val == b.right?.val &&
                   IsTreeEqual(a.left, b.left) &&
                   IsTreeEqual(a.right, b.right);
        }

        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;
            if (t1 == null) return t2;
            else if (t2 == null) return t1;

            TreeNode newRoot = new TreeNode(t1.val + t2.val);
            MergeTreesRec(t1, t2, newRoot);

            return newRoot;
        }

        private void MergeTreesRec(TreeNode t1, TreeNode t2, TreeNode newRoot)
        {
            if (t2.left == null)
            {
                newRoot.left = t1.left;
            }
            else if (t1.left == null)
            {
                newRoot.left = t2.left;
            }
            else
            {
                newRoot.left = new TreeNode(t1.left.val + t2.left.val);
                MergeTreesRec(t1.left, t2.left, newRoot.left);
            }

            if (t2.right == null)
            {
                newRoot.right = t1.right;
            }
            else if (t1.right == null)
            {
                newRoot.right = t2.right;
            }
            else
            {
                newRoot.right = new TreeNode(t1.right.val + t2.right.val);
                MergeTreesRec(t1.right, t2.right, newRoot.right);
            }
        }

        public int[] Shuffle(int[] nums, int n)
        {
            for (int i = 2 * n - 1; i > 0; i--)
            {
                int k = i;
                do
                {
                    if (k % 2 == 1)
                        k = k / 2 + n;
                    else
                        k = k / 2;
                } while (k > i);

                var temp = nums[i];
                nums[i] = nums[k];
                nums[k] = temp;
            }
            return nums;
        }

        public int[] Shuffle1(int[] nums, int n)
        {
            int i = 1, j = n, k = 1;

            var res = new int[nums.Length];
            res[0] = nums[0];
            res[n * 2 - 1] = nums[n * 2 - 1];
            while (k < n * 2 - 1)
            {
                res[k++] = nums[j++];
                res[k++] = nums[i++];
            }

            return res;
        }

        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var res = new List<IList<int>>();
            if (root == null) return res;

            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(null);
            var lst = new List<int>();
            while (q.Count > 0)
            {
                var node = q.Dequeue();
                if (node == null)
                {
                    if (q.Count > 0) q.Enqueue(null);
                    res.Add(new List<int>(lst));
                    lst.Clear();
                }
                else
                {
                    lst.Add(node.val);
                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
            }

            for (int i = 0; i < res.Count / 2; i++)
            {
                var temp = res[i];
                res[i] = res[res.Count - i - 1];
                res[res.Count - i - 1] = temp;
            }

            return res;
        }

        public bool DivisorGame(int N)
        {
            var dp = new bool[N + 1];
            dp[0] = true;
            dp[1] = false;

            for (int i = 2; i < N; i++)
            {
                for (int j = 1; j * j <= i; j++)
                {
                    if ((i & j) == 0)
                    {
                        if (!dp[i - j] || !dp[i - (i / j)])
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                }
            }

            return dp[N];
        }

        public List<int> GetDivisors(int n)
        {
            var lst = new List<int>();
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {

                    if (n / i == i) lst.Add(i);
                    else
                    {
                        lst.Add(i);
                        lst.Add(n / i);
                    }
                }
            }

            return lst;
        }

        public string LongestWord(string[] words)
        {
            var trie = new TrieNear.WordDictionary();

            foreach (var word in words)
            {
                trie.AddWord(word);
            }

            var ans = "";
            var st = new Stack<TrieNear.WordDictionary.TrieNode1>();
            foreach (var node1 in trie.roots)
            {
                st.Push(node1);
                while (st.Count > 0)
                {
                    var item = st.Pop();
                    if (item.word != null)
                    {
                        if (item.word.Length > ans.Length) ans = item.word;
                        else if (item.word.Length == ans.Length)
                        {
                            ans = item.word.CompareTo(ans) <= 0 ? item.word : ans;
                        }
                        foreach (var itemChild in item.children)
                        {
                            st.Push(itemChild);
                        }
                    }
                }
            }

            return ans;
        }

        public string LongestWord1(string[] words)
        {
            var hs = new HashSet<string>();
            foreach (var word in words)
            {
                hs.Add(word);
            }

            var ans = "";
            foreach (var word in words)
            {
                var isFound = true;
                for (int i = 1; i <= word.Length; i++)
                {
                    if (!hs.Contains(word.Substring(0, i)))
                    {
                        isFound = false;
                        break;
                    }
                }

                if (isFound)
                {
                    if (word.Length > ans.Length) ans = word;
                    else if (word.Length == ans.Length)
                    {
                        ans = word.CompareTo(ans) <= 0 ? word : ans;
                    }
                }
            }

            return ans;
        }

        public string MinWindow(string S, string T)
        {
            var tOcc = new int[26];
            var wOcc = new int[26];

            for (int i = 0; i < T.Length; i++)
            {
                tOcc[T[i] - 'a']++;
            }

            int l = 0, ansL = 0, ansR = 0, min = int.MaxValue;
            for (int r = 0; r < S.Length; r++)
            {
                wOcc[S[r] - 'a']++;

                while (r >= T.Length && IsSubsequence(tOcc, wOcc))
                {
                    var currentLength = r - l + 1;
                    if (min > currentLength)
                    {
                        min = currentLength;
                        ansL = l;
                        ansR = r;
                    }
                    wOcc[S[l] - 'a']--;
                    l++;
                }
            }

            return S.Substring(ansL, ansR - ansL + 1);
        }

        private bool IsSubsequence(int[] tOcc, int[] wOcc)
        {
            for (int i = 0; i < 26; i++)
            {
                if (tOcc[i] > wOcc[i]) return false;
            }
            return true;
        }

        public int SubarraysWithKDistinct(int[] A, int K)
        {
            var dic = new Dictionary<int, int>();
            int l = 0, count = 0;
            for (int r = 0; r < A.Length; r++)
            {
                if (!dic.ContainsKey(A[r]))
                {
                    K--;
                    dic.Add(A[r], 0);
                }

                dic[A[r]]++;
                while (K < 0)
                {
                    count++;
                    dic[A[l]]--;
                    if (dic[A[l]] == 0)
                    {
                        K++;
                        dic.Remove(A[l]);
                    }
                    l++;
                }
            }

            return count;
        }

        public int LongestOnes(int[] A, int K)
        {
            int l = 0, r = 0;
            for (; r < A.Length; r++)
            {
                if (A[r] == 0) K--;

                if (K < 0)
                {
                    if (A[l] == 0) K++;
                    l++;
                }
            }

            return r - l;
        }

        public int LongestOnes1(int[] A, int K)
        {
            int l = 0, r = 0, max = 0;

            if (A.All(x => x == 0)) return Math.Min(A.Length, K);

            do
            {
                int tempK = K;
                while (l < A.Length)
                {
                    if (A[l] == 0)
                    {
                        l++;
                    }
                    else break;
                }

                r = l;
                while (r < A.Length)
                {
                    if (r == 0 || A[r] == 1)
                    {
                        r++;
                    }
                    else break;
                }

                //if (r == A.Length) break;
                int currL = l, currR = r;
                max = Math.Max(max, currR - currL);

                while (currR < A.Length && (tempK > 0 || A[currR] == 1))
                {
                    if (A[currR] == 0) tempK--;
                    currR++;
                    max = Math.Max(max, currR - currL);
                }

                currL--;
                while (currL >= 0 && (tempK > 0 || A[currL] == 1))
                {
                    if (A[currL] == 0) tempK--;
                    max = Math.Max(max, currR - currL);
                    currL--;
                }

                l = r;
            } while (r < A.Length);

            //if (l == -1) return Math.Min(A.Length, K);
            return max;
        }

        public int ShortestSubarray(int[] A, int K)
        {
            int min = int.MaxValue;

            int l = 0, r = 0, sum = 0;

            while (r < A.Length)
            {
                sum += A[r];
                if (sum >= K)
                {
                    min = Math.Min(min, r - l + 1);
                    if (min == 1) break;
                    while (l < A.Length && (sum >= K || A[l] < 0))
                    {
                        sum -= A[l++];
                        if (sum >= K)
                            min = Math.Min(min, r - l + 1);
                    }
                }
                r++;
            }

            return min == int.MaxValue ? -1 : min;
        }

        public int LongestSubarray1(int[] nums, int limit)
        {
            int min = int.MaxValue, max = int.MinValue;
            int res = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                min = int.MaxValue;
                max = int.MinValue;
                for (int j = i; j < nums.Length; j++)
                {
                    min = Math.Min(min, nums[j]);
                    max = Math.Max(max, nums[j]);

                    if (max - min <= limit)
                    {
                        res = Math.Max(res, j - i + 1);
                    }
                    else break;
                }
            }

            return res;
        }

        public string LargestNumber(int[] nums)
        {
            var sb = new StringBuilder();
            var arr = nums
                .Select(x => x.ToString())
                .OrderByDescending(x => x, Comparer<string>.Create((a, b) =>
                {
                    return String.Compare((a + b), b + a, StringComparison.Ordinal);
                    //var minLength = Math.Min(a.Length, b.Length);
                    //for (int i = 0; i < minLength; i++)
                    //{
                    //    if (a[i] < b[i]) return -1;
                    //    else if (a[i] > b[i]) return 1;
                    //}

                    //var remainingLength = Math.Abs(b.Length - a.Length);

                    //if (a.Length < b.Length)
                    //{
                    //    for (int i = 0; i < remainingLength; i++)
                    //    {
                    //        if (a[i % a.Length] < b[i + a.Length]) return -1;
                    //        else if (a[i % a.Length] > b[i + a.Length]) return 1;
                    //    }
                    //}
                    //else
                    //{
                    //    for (int i = 0; i < remainingLength; i++)
                    //    {
                    //        if (a[i + b.Length] < b[i % b.Length]) return -1;
                    //        else if (a[i + b.Length] > b[i % b.Length]) return 1;
                    //    }
                    //}

                    //if (a.Length < b.Length) return -1;
                    //else if (a.Length > b.Length) return 1;
                    //return 0;
                }));

            foreach (var i in arr)
            {
                sb.Append(i);
            }

            return sb.ToString();
        }

        public int Calculate(string s)
        {
            var expression = GetPostFixExpression(s);

            var st = new Stack<int>();
            while (expression.Count > 0)
            {
                var item = expression.Dequeue();
                if (IsOperand(item[0]))
                {
                    st.Push(int.Parse(item));
                }
                else
                {
                    int right = st.Pop(), left = st.Pop();

                    switch (item)
                    {
                        case "+":
                            st.Push(left + right);
                            break;
                        case "-":
                            st.Push(left - right);
                            break;
                        case "/":
                            st.Push(left / right);
                            break;
                        case "*":
                            st.Push(left * right);
                            break;
                    }
                }
            }

            return st.Pop();
        }

        private bool IsOperand(in char item)
        {
            return item >= '0' && item <= '9';
        }

        private Queue<string> GetPostFixExpression(string s)
        {
            var precedenceDic = new Dictionary<string, int>
            {
                {"+", 0},
                {"-", 0},
                {"/", 1},
                {"*", 1},
                {"(", -1}
            };

            var operatorsSt = new Stack<string>();
            var operandsSt = new Queue<string>();
            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i].ToString();
                switch (ch)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        while (operatorsSt.Count > 0 && (IsOperand(operatorsSt.Peek()[0]) || precedenceDic[operatorsSt.Peek()] >= precedenceDic[ch]))
                            operandsSt.Enqueue(operatorsSt.Pop());
                        operatorsSt.Push(ch);
                        break;
                    case "(":
                        operatorsSt.Push(ch);
                        break;
                    case ")":
                        while (operatorsSt.Count > 0 && operatorsSt.Peek() != "(")
                            operandsSt.Enqueue(operatorsSt.Pop());
                        operatorsSt.Pop();
                        break;
                    case " ":
                        continue;
                    default:
                        if (i > 0 && IsOperand(s[i - 1]))
                        {
                            operatorsSt.Push(operatorsSt.Pop() + ch);
                        }
                        else operatorsSt.Push(ch);
                        break;
                }
            }

            while (operatorsSt.Count > 0)
            {
                operandsSt.Enqueue(operatorsSt.Pop());
            }

            return operandsSt;
        }

        public int MctFromLeafValues(int[] arr)
        {
            var st = new Stack<int>();
            int res = 0;
            st.Push(int.MaxValue);
            for (int i = 0; i < arr.Length; i++)
            {
                while (st.Count > 2 && st.Peek() < arr[i])
                {
                    int mid = st.Pop();
                    res += mid * Math.Min(st.Peek(), arr[i]);
                }
                st.Push(arr[i]);
            }

            while (st.Count > 0)
            {
                res += st.Pop() * st.Peek();
            }

            return res;
        }

        public int MctFromLeafValues_ON2(int[] arr)
        {
            var lst = new List<int>(arr);

            int res = 0;
            while (lst.Count > 1)
            {
                var min = lst.Min();
                var minIdx = lst.IndexOf(min);
                if (minIdx == 0 || minIdx == lst.Count - 1)
                {
                    res += min * (minIdx == 0 ? lst[1] : lst[lst.Count - 2]);
                }
                else
                {
                    res += min * Math.Min(lst[minIdx + 1], lst[minIdx - 1]);
                }
                lst.RemoveAt(minIdx);
            }

            return res;
        }

        public int MctFromLeafValues_ON3(int[] arr)
        {
            var dp = new int[arr.Length, arr.Length];
            MctFromLeafValuesRec(arr, 0, arr.Length - 1, dp);
            return dp[0, arr.Length - 1];
        }

        private int MctFromLeafValuesRec(int[] arr, int i, int j, int[,] dp)
        {
            if (i >= j) return 0;
            if (dp[i, j] != 0) return dp[i, j];

            int res = int.MaxValue, maxLeft = int.MinValue;
            for (int k = i; k < j; k++)
            {
                maxLeft = Math.Max(maxLeft, arr[k]);
                int maxRight = int.MinValue;
                for (int l = k + 1; l <= j; l++)
                {
                    maxRight = Math.Max(maxRight, arr[l]);
                }
                var root = maxLeft * maxRight;

                res = Math.Min(res,
                    root + MctFromLeafValuesRec(arr, i, k, dp) + MctFromLeafValuesRec(arr, k + 1, j, dp));
            }

            dp[i, j] = res;

            return res;
        }

        public int[] NextLargerNodes(ListNode head)
        {
            var res = new List<int>(5);
            var node = head;
            var st = new Stack<(int val, int idx)>();
            int i = 0;
            while (node != null)
            {
                res.Add(0);
                while (st.Count > 0 && node.val > st.Peek().val)
                {
                    res[st.Pop().idx] = node.val;
                }

                st.Push((node.val, i));
                node = node.next;
                i++;
            }

            return res.ToArray();
        }

        public class CustomStack
        {
            private int[] arr;
            private int lastIndex = 0;
            public CustomStack(int maxSize)
            {
                arr = new int[maxSize];
            }

            public void Push(int x)
            {
                if (lastIndex < arr.Length)
                {
                    arr[lastIndex++] = x;
                }
            }

            public int Pop()
            {
                if (lastIndex > 0)
                {
                    lastIndex--;
                    return arr[lastIndex];
                }
                return -1;
            }

            public void Increment(int k, int val)
            {
                for (int i = 0; i < Math.Min(lastIndex, k); i++)
                {
                    arr[i] += val;
                }
            }
        }

        public int EvalRPN(string[] tokens)
        {
            if (tokens == null || tokens.Length == 0) return 0;
            var st = new Stack<int>();
            int result = 0, left, right;
            for (int i = 0; i < tokens.Length; i++)
            {
                switch (tokens[i])
                {
                    case "+":
                        result = st.Pop() + st.Pop();
                        break;
                    case "-":
                        right = st.Pop();
                        left = st.Pop();
                        result = left - right;
                        break;
                    case "*":
                        result = st.Pop() * st.Pop();
                        break;
                    case "/":
                        right = st.Pop();
                        left = st.Pop();
                        result = left / right;
                        break;
                    default:
                        result = int.Parse(tokens[i]);
                        break;
                }
                st.Push(result);
            }

            return st.Pop();
        }

        public int CalPoints(string[] ops)
        {
            var lst = new List<int>(4);
            for (int i = 0; i < ops.Length; i++)
            {
                switch (ops[i])
                {
                    case "+":
                        lst.Add(lst[lst.Count - 1] + lst[lst.Count - 2]);
                        break;
                    case "D":
                        lst.Add(2 * lst[lst.Count - 1]);
                        break;
                    case "C":
                        lst.RemoveAt(lst.Count - 1);
                        break;
                    default:
                        lst.Add(int.Parse(ops[i]));
                        break;
                }
            }

            return lst.Sum();
        }

        public int[] NextGreaterElements(int[] nums)
        {
            var st = new Stack<int>();
            var res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = -1;
                while (st.Count > 0 && nums[st.Peek()] < nums[i])
                {
                    res[st.Pop()] = nums[i];
                }
                st.Push(i);
            }

            if (st.Count > 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    while (st.Count > 0 && nums[st.Peek()] < nums[i])
                    {
                        res[st.Pop()] = nums[i];
                    }
                    if (st.Count == 0) break;
                }
            }

            return res;
        }

        public bool Find132pattern(int[] nums)
        {
            if (nums == null || nums.Length < 3) return false;
            Stack<int> st = new Stack<int>();

            var minSoFar = new int[nums.Length];
            minSoFar[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                minSoFar[i] = Math.Min(minSoFar[i - 1], nums[i]);
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                while (st.Count > 0 && st.Peek() <= minSoFar[i])
                {
                    st.Pop();
                }

                if (st.Count > 0 && st.Peek() < nums[i]) return true;

                st.Push(nums[i]);
            }

            return false;
        }

        public bool Find132pattern_ON2(int[] nums)
        {
            if (nums == null || nums.Length < 3) return false;
            int minI = nums[0];
            for (int j = 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (minI < nums[k] && nums[k] < nums[j]) return true;
                }
                minI = Math.Min(minI, nums[j]);
            }
            return false;
        }

        public int SumSubarrayMins1(int[] A)
        {
            int mod = 1_000_000_007, ans = 0;
            Stack<int> nextSt = new Stack<int>(), prevSt = new Stack<int>();
            int[] prev = new int[A.Length], next = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                // Calc next less elem
                while (nextSt.Count > 0 && A[i] < A[nextSt.Peek()])
                {
                    next[nextSt.Peek()] = i - nextSt.Pop();
                }
                nextSt.Push(i);

                // Calc prev less elem
                while (prevSt.Count > 0 && A[prevSt.Peek()] > A[i])
                {
                    prevSt.Pop();
                }
                prev[i] = prevSt.Count == 0 ? 0 : i - prevSt.Peek();

                ans += A[i] * prev[i] * next[i];
                ans = ans % mod;
            }

            return ans;
        }

        public void MonotonicStack()
        {
            var A = new int[] { 15, 13, 12, 11, 10, 1 };
            var in_stk = new Stack<int>();
            for (int i = 0; i < A.Length; i++)
            {
                while (in_stk.Count > 0 && in_stk.Peek() > A[i])
                {
                    in_stk.Pop();
                }
                in_stk.Push(A[i]);
            }

            while (in_stk.Count > 0)
            {
                Console.Write(in_stk.Pop() + " ");
            }

            Console.WriteLine();
        }

        public int[] DailyTemperatures(int[] T)
        {
            var res = new int[T.Length];
            var increasingNumbersSt = new Stack<int>();
            for (int i = T.Length - 1; i >= 0; i--)
            {
                while (increasingNumbersSt.Count > 0 && T[increasingNumbersSt.Peek()] <= T[i])
                    increasingNumbersSt.Pop();
                res[i] = increasingNumbersSt.Count == 0 ? 0 : increasingNumbersSt.Peek() - i;
                increasingNumbersSt.Push(i);
            }
            return res;
        }

        public class StockSpanner
        {
            Stack<int> prevGreaterSt = new Stack<int>();
            Stack<int> weightSt = new Stack<int>();

            public StockSpanner()
            {
            }

            public int Next(int price)
            {
                int count = 1;
                while (prevGreaterSt.Count > 0 && prevGreaterSt.Peek() <= price)
                {
                    prevGreaterSt.Pop();
                    count += weightSt.Pop();
                }

                prevGreaterSt.Push(price);
                weightSt.Push(count);

                return count;
            }
        }

        public string RemoveKdigits(string num, int k)
        {
            var st = new Stack<char>();
            for (int i = 0; i < num.Length; i++)
            {
                while (k > 0 && st.Count > 0 && st.Peek() > num[i])
                {
                    st.Pop();
                    k--;
                }
                st.Push(num[i]);
            }

            // K is always less than num.length
            for (int i = 0; i < k; i++)
            {
                st.Pop();
            }

            if (st.Count == 0) return "0";

            var sb = new StringBuilder(st.Count);
            while (st.Count > 0)
            {
                sb.Insert(0, st.Pop());
            }

            num = sb.ToString().TrimStart('0');
            return num == string.Empty ? "0" : num;
        }

        public string RemoveKdigits_O2PowN(string num, int k)
        {
            string min = string.Empty;
            RemoveKdigitsRec(num, 0, k, ref min);
            return min == "" || int.Parse(min) == 0 ? "0" : min.TrimStart('0');
        }

        private void RemoveKdigitsRec(string num, int i, in int k, ref string min)
        {
            if (i == num.Length || k == 0)
            {
                if (min == string.Empty || num.CompareTo(min) < 0) min = num;
                return;
            }

            RemoveKdigitsRec(num, i + 1, k, ref min);
            RemoveKdigitsRec(num.Substring(0, i) + num.Substring(i + 1), i, k - 1, ref min);
        }

        public string FindLexSmallestString(string s, int a, int b)
        {
            var hs = new HashSet<string>();
            string smallest = string.Empty;
            var sb = new StringBuilder(s);
            FindLexSmallestStringRec(sb, a, b, ref hs, ref smallest);
            return smallest;
        }

        private void FindLexSmallestStringRec(StringBuilder sb, in int add, in int rotate, ref HashSet<string> hs, ref string smallest)
        {
            var s = sb.ToString();
            if (hs.Contains(s)) return;

            hs.Add(s);
            if (smallest == string.Empty || s.CompareTo(smallest) < 0)
            {
                smallest = s;
            }

            FindLexSmallestStringRec(Add(sb, add), add, rotate, ref hs, ref smallest);
            FindLexSmallestStringRec(Rotate(s, rotate), add, rotate, ref hs, ref smallest);
        }

        public StringBuilder Rotate(string s, in int rotate)
        {
            return new StringBuilder(s.Substring(s.Length - rotate) + s.Substring(0, s.Length - rotate));
        }

        private StringBuilder Add(StringBuilder sb, in int add)
        {
            int mod;
            for (int i = 1; i < sb.Length; i += 2)
            {
                mod = (add + (sb[i] - '0')) % 10;
                sb[i] = (char)(mod + 48);
            }
            return sb;
        }

        public IList<bool> AreConnected(int n, int threshold, int[][] queries)
        {
            var dsu = new DSU(n + 1);
            for (int i = threshold + 1; i < n; i++)
            {
                for (int j = 2; i * j <= n; j++)
                {
                    dsu.Union(i, i * j);
                }
            }

            var lst = new List<bool>(n);
            foreach (var query in queries)
            {
                var p1 = dsu.GetParent(query[0]);
                var p2 = dsu.GetParent(query[1]);
                lst.Add(p1 == p2);
            }

            return lst;
        }


        public class Player
        {
            public int Score { get; set; }
            public int Age { get; set; }
        }

        public int BestTeamScore_BottomUp(int[] scores, int[] ages)
        {
            if (scores == null || scores.Length == 0) return 0;
            var players = new List<Player>();
            for (int i = 0; i < scores.Length; i++)
            {
                players.Add(new Player { Age = ages[i], Score = scores[i] });
            }

            players = players
                .OrderBy(x => x.Score)
                .ThenBy(x => x.Age)
                .ToList();
            var dp = new int[scores.Length, 1001];
            var max = 0;
            return BestTeamScore_BottomUpRec(players, 0, ref dp, 0);
        }

        private int BestTeamScore_BottomUpRec(List<Player> players, int i, ref int[,] dp, int prevMaxAge)
        {
            if (i == players.Count) return 0;
            if (dp[i, prevMaxAge] > 0) return dp[i, prevMaxAge];

            int max = 0;
            if (players[i].Age >= prevMaxAge)
            {
                max = players[i].Score + BestTeamScore_BottomUpRec(players, i + 1, ref dp, players[i].Age);
            }

            max = Math.Max(max, BestTeamScore_BottomUpRec(players, i + 1, ref dp, prevMaxAge));

            dp[i, prevMaxAge] = max;

            return max;
        }

        public int BestTeamScore_Topdown(int[] scores, int[] ages)
        {
            if (scores == null || scores.Length == 0) return 0;
            var players = new List<Player>();
            for (int i = 0; i < scores.Length; i++)
            {
                players.Add(new Player { Age = ages[i], Score = scores[i] });
            }

            players = players
                .OrderByDescending(x => x.Age)
                .ThenByDescending(x => x.Score)
                .ToList();
            var dp = new int[scores.Length];
            var max = 0;

            // Top down approach
            for (int i = 0; i < players.Count; i++)
            {
                dp[i] = players[i].Score;
                for (int j = 0; j < i; j++)
                {
                    if (players[i].Score <= players[j].Score)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + players[i].Score);
                    }
                }
                max = Math.Max(max, dp[i]);
            }
            return max;
        }

        //private int BestTeamScoreRec(List<Player> players, int i, ref int[] dp)
        //{
        //    if (i == players.Count) return 0;

        //    var option1 = 0;
        //    if (maxAgePlayer == null || (players[i].Age >= maxAgePlayer.Age || players[i].Score <= maxAgePlayer.Score))
        //    {
        //        option1 = players[i].Score + BestTeamScoreRec(players, i + 1,
        //            (maxAgePlayer?.Age ?? -1) < players[i].Age ? players[i] : maxAgePlayer);
        //    }
        //    var option2 = BestTeamScoreRec(players, i + 1, maxAgePlayer);

        //    return Math.Max(option1, option2);
        //}

        public IList<bool> AreConnected1(int n, int threshold, int[][] queries)
        {
            if (n < 2) return new List<bool>(Enumerable.Repeat(false, queries.Length));
            if (threshold == 0) return new List<bool>(Enumerable.Repeat(true, queries.Length));

            var lst = new List<bool>(queries.Length);
            foreach (var query in queries)
            {
                int gc = GCD(query[0], query[1]);
                lst.Add(gc > threshold);
            }

            return lst;
        }

        int GCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;
                else
                    num2 = num2 - num1;
            }
            return num2;
        }

        //public string FindLexSmallestString(string s, int a, int b)
        //{
        //    //01234 -> 23401
        //}

        public int MaxLengthBetweenEqualCharacters(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 2) return -1;
            var min = new int[26];
            var max = new int[26];
            for (int i = 0; i < 26; i++)
            {
                min[i] = max[i] = -1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (min[s[i] - 'a'] == -1) min[s[i] - 'a'] = i;
                max[s[i] - 'a'] = i;
            }

            int maxGap = -1;
            for (int i = 0; i < 26; i++)
            {
                if (min[i] >= 0 && max[i] >= 0)
                {
                    maxGap = Math.Max(maxGap, max[i] - min[i] - 1);
                }
            }

            return maxGap;
        }

        public string RemoveDuplicates(string s, int k)
        {
            if (string.IsNullOrEmpty(s)) return s;
            var sb = new StringBuilder(4);
            var st = new Stack<int>();

            int PrevOccurrences = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (sb.Length > 0 && sb[sb.Length - 1] == s[i])
                {
                    PrevOccurrences++;
                    if (PrevOccurrences == k)
                    {
                        sb.Length -= k - 1;
                        PrevOccurrences = st.Count > 0 ? st.Pop() : 0;
                    }
                    else
                    {
                        sb.Append(s[i]);
                    }
                }
                else
                {
                    st.Push(PrevOccurrences);
                    PrevOccurrences = 1;
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }

        public string RemoveDuplicates(string S)
        {
            if (string.IsNullOrEmpty(S)) return S;

            var sb = new StringBuilder(4);
            for (int i = 0; i < S.Length; i++)
            {
                if (sb.Length > 0 && sb[sb.Length - 1] == S[i])
                {
                    sb.Length--;
                }
                else
                {
                    sb.Append(S[i]);
                }
            }

            return sb.ToString();
        }

        public string RemoveDuplicates1(string s, int k)
        {
            var sb = new StringBuilder();
            var st = new Stack<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && sb.Length > 0 && s[i] != sb[sb.Length - 1])
                {
                    if (sb.Length % k != 0)
                        st.Push(new string(sb[0], sb.Length % k));
                    sb.Clear();
                }
                sb.Append(s[i]);
            }

            if (sb.Length > 0) st.Push(sb.ToString());

            if (st.Count > 0)
            {
                var prev = st.Pop();
                while (st.Count > 0)
                {
                    var current = st.Pop();
                    if (current[0] == prev[0])
                    {
                        var remaining = (current.Length + prev.Length) % k;
                        if (remaining != 0)
                        {
                            prev = new string(current[0], remaining);
                        }
                        else
                        {
                            if (st.Count > 0) prev = st.Pop();
                            else
                            {
                                prev = null;
                                break;
                            }
                        }
                    }
                    else
                    {
                        sb.Insert(0, prev);
                        prev = current;
                    }
                }

                if (prev != null)
                {
                    sb.Insert(0, new string(prev[0], prev.Length % k));
                }
            }

            return sb.ToString();
        }

        public enum TaskAction
        {
            Start,
            End
        }

        public class TaskExecution
        {
            public int Id { get; set; }
            public TaskAction Action { get; set; }
            public int TimeStamp { get; set; }
        }

        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            var stTasks = new Stack<TaskExecution>();

            var taskParts = logs[0].Split(':');
            var task = new TaskExecution
            {
                Action = taskParts[1] == "start" ? TaskAction.Start : TaskAction.End,
                Id = int.Parse(taskParts[0]),
                TimeStamp = int.Parse(taskParts[2])
            };
            stTasks.Push(task);
            int prevEndTime = task.TimeStamp;

            var res = new int[n];
            for (int i = 1; i < logs.Count; i++)
            {
                taskParts = logs[i].Split(':');
                task = new TaskExecution
                {
                    Action = taskParts[1] == "start" ? TaskAction.Start : TaskAction.End,
                    Id = int.Parse(taskParts[0]),
                    TimeStamp = int.Parse(taskParts[2])
                };

                if (stTasks.Count > 0 && prevEndTime < task.TimeStamp)
                {
                    res[stTasks.Peek().Id] += task.TimeStamp - prevEndTime;
                    prevEndTime += task.TimeStamp - prevEndTime;
                }

                if (task.Action == TaskAction.Start)
                {
                    stTasks.Push(task);
                }
                else
                {
                    var start = stTasks.Pop();
                    res[start.Id] += 1;
                    prevEndTime++;
                }
            }

            return res;
        }

        public int[] ExclusiveTime2(int n, IList<string> logs)
        {
            var stTasks = new Stack<TaskExecution>();
            var stInnerExecutions = new Stack<int>();

            var res = new int[n];
            for (int i = 0; i < logs.Count; i++)
            {
                var taskParts = logs[i].Split(':');
                var task = new TaskExecution
                {
                    Action = taskParts[1] == "start" ? TaskAction.Start : TaskAction.End,
                    Id = int.Parse(taskParts[0]),
                    TimeStamp = int.Parse(taskParts[2])
                };

                if (task.Action == TaskAction.Start)
                {
                    stTasks.Push(task);
                }
                else
                {
                    var start = stTasks.Pop();
                    var taskDuration = task.TimeStamp - start.TimeStamp + 1;
                    var gap = (stInnerExecutions.Count > 0 ? stInnerExecutions.Pop() : 0);
                    res[task.Id] += taskDuration - gap;
                    if (stTasks.Count > 0)
                    {
                        stInnerExecutions.Push(taskDuration);
                    }
                }
            }

            return res;
        }

        public int[] ExclusiveTime1(int n, IList<string> logs)
        {
            var st = new Stack<TaskExecution>();

            int prevTaskEndTime = -1, gap = 0;
            var res = new int[n];
            for (int i = 0; i < logs.Count; i++)
            {
                var taskParts = logs[i].Split(':');
                var task = new TaskExecution
                {
                    Action = taskParts[1] == "start" ? TaskAction.Start : TaskAction.End,
                    Id = int.Parse(taskParts[0]),
                    TimeStamp = int.Parse(taskParts[2])
                };

                if (task.Action == TaskAction.Start)
                {
                    if (st.Count > 0)
                    {
                        var prevTask = st.Pop();
                        res[prevTask.Id] += task.TimeStamp - prevTask.TimeStamp;
                        prevTaskEndTime = task.TimeStamp - 1;
                    }
                    st.Push(task);
                    if (task.TimeStamp > (prevTaskEndTime + 1))
                    {
                        gap += task.TimeStamp - prevTaskEndTime - 1;
                    }
                }
                else
                {
                    if (st.Count > 0 && st.Peek().Id == task.Id)
                    {
                        var start = st.Pop();
                        res[task.Id] += task.TimeStamp - start.TimeStamp + 1;
                    }
                    else
                    {
                        res[task.Id] += task.TimeStamp - prevTaskEndTime + gap;
                        gap = 0;
                    }
                    prevTaskEndTime = task.TimeStamp;
                }
            }

            return res;
        }

        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var nextMap = new Dictionary<int, int>();
            var st = new Stack<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                while (st.Count > 0 && nums2[i] > st.Peek())
                {
                    nextMap.Add(st.Pop(), nums2[i]);
                }
                st.Push(nums2[i]);
            }

            while (st.Count > 0)
            {
                nextMap.Add(st.Pop(), -1);
            }

            var res = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                res[i] = nextMap[nums1[i]];
            }

            return res;
        }

        public int[] NextGreaterElement1(int[] nums1, int[] nums2)
        {
            var res = new int[nums1.Length];
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                dic.Add(nums2[i], i);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                var start = dic[nums1[i]];
                res[i] = -1;
                for (int j = start + 1; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums2[start])
                    {
                        res[i] = nums2[j];
                        break;
                    }
                }
            }
            return res;
        }

        //public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
        //{
        //    var dimensions = binaryMatrix.Dimensions();
        //    int width = dimensions[0], height = dimensions[0] - 1;

        //    int i = 0, j = width - 1;

        //    while (i <= height && j >= 0)
        //    {
        //        if (binaryMatrix.Get(i, j) == 1)
        //            j--;
        //        else i++;
        //    }

        //    return j == (width - 1) ? -1 : (j + 1);
        //}

        public int LargestRectangleArea(int[] heights)
        {
            var st = new Stack<int>();
            st.Push(-1);

            int maxArea = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                while (st.Peek() != -1 && heights[st.Peek()] > heights[i])
                {
                    maxArea = Math.Max(maxArea, heights[st.Pop()] * (i - st.Peek() - 1));
                }
                st.Push(i);
            }

            while (st.Peek() != -1)
            {
                maxArea = Math.Max(maxArea, heights[st.Pop()] * (heights.Length - st.Peek() - 1));
            }

            return maxArea;
        }

        public int LargestRectangleArea_ONLogN(int[] heights)
        {
            return LargestRectangleAreaRec(heights, 0, heights.Length - 1);
        }

        private int LargestRectangleAreaRec(int[] heights, int left, in int right)
        {
            if (left > right) return 0;

            var minIndex = left;
            for (int i = left + 1; i <= right; i++)
            {
                if (heights[i] < heights[minIndex])
                    minIndex = i;
            }

            var rectArea = heights[minIndex] * (right - left + 1);

            return Math.Max(rectArea,
                Math.Max(LargestRectangleAreaRec(heights, left, minIndex - 1),
                    LargestRectangleAreaRec(heights, minIndex + 1, right)));
        }

        public int LargestRectangleArea1(int[] heights)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);
            int maxarea = 0;
            for (int i = 0; i < heights.Length; ++i)
            {
                var stPeek = stack.Peek();
                while (stPeek != -1 && heights[stPeek] >= heights[i])
                {
                    var stPop = stack.Pop();
                    stPeek = stack.Peek();
                    maxarea = Math.Max(maxarea, heights[stPop] * (i - stPeek - 1));
                }
                stack.Push(i);
            }
            while (stack.Peek() != -1)
                maxarea = Math.Max(maxarea, heights[stack.Pop()] * (heights.Length - stack.Peek() - 1));
            return maxarea;
        }

        public int Trap(int[] height)
        {
            var st = new Stack<int>();
            var sum = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int heightI = height[i], heightStPeek = st.Count > 0 ? height[st.Peek()] : 0;
                while (st.Count > 0 && heightI > heightStPeek)
                {
                    int top = st.Pop();
                    if (st.Count == 0)
                        break;
                    int distance = i - st.Peek() - 1;
                    int bounded_height = Math.Min(height[i], height[st.Peek()]) - height[top];
                    sum += distance * bounded_height;
                }
                st.Push(i);
            }
            return sum;
        }

    }
}