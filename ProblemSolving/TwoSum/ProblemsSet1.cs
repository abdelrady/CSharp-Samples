using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Helpers;

namespace TwoSum
{
    class ProblemsSet1
    {
        public class Solution
        {
            public int findMPPCuts(String st)
            {
                return this.findMPPCutsRecursive(st, 0, st.Length - 1);
            }

            private int findMPPCutsRecursive(String st, int startIndex, int endIndex)
            {
                // we don't need to cut the string if it is a palindrome
                if (startIndex >= endIndex || isPalindrome(st, startIndex, endIndex))
                    return 0;

                // at max, we need to cut the string into its 'length-1' pieces
                int minimumCuts = endIndex - startIndex;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (isPalindrome(st, startIndex, i))
                    {
                        // we can cut here as we have a palindrome from 'startIndex' to 'i'
                        minimumCuts = Math.Min(minimumCuts, 1 + findMPPCutsRecursive(st, i + 1, endIndex));
                    }
                }
                return minimumCuts;
            }

            private bool isPalindrome(String st, int x, int y)
            {
                while (x < y)
                {
                    if (st[x++] != st[y--])
                        return false;
                }
                return true;
            }


            public string ShortestPalindrome(string s)
            {
                if (string.IsNullOrEmpty(s)) return s;
                var end = ShortestPalindromeHelper(s);
                var sb = new StringBuilder(s);
                sb.Insert(0, new string(s.Substring(end + 1).Reverse().ToArray()));
                return sb.ToString();
            }

            public int ShortestPalindromeHelper(string s)
            {
                if (string.IsNullOrEmpty(s)) return 0;

                var dp = new bool[s.Length, s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    dp[i, i] = true;
                }

                int minStart = s.Length - 1, maxEnd = s.Length - 1;
                int start = 0;
                for (int end = start + 1; end < s.Length; end++)
                {
                    if (s[start] == s[end])
                    {
                        dp[start, end] = end - start == 1 || dp[start + 1, end - 1];
                        if (dp[start, end])
                        {
                            (minStart, maxEnd) = (maxEnd - minStart) < (end - start)
                                ? (start, end)
                                : (minStart, maxEnd);
                        }
                    }
                }
                return maxEnd - minStart;
            }

            public string ShortestPalindromeOld(string s)
            {
                int start = 0, end = s.Length - 1, newPos = s.Length - 1;

                while (start <= end)
                {
                    if (s[start] == s[end])
                    {
                        start++;
                        end--;
                    }
                    else
                    {
                        end = newPos - 1;
                        if (start > 0) start = 0;
                        newPos = end;
                    }
                }

                var sb = new StringBuilder(s);
                sb.Insert(0, new string(s.Substring(newPos + 1).Reverse().ToArray()));
                //for (int i = newPos + 1; i < s.Length; i++)
                //{
                //    sb.Insert(0, s[i]);
                //}
                return sb.ToString();
            }

            public int LongestPalindromeSubstring(string s)
            {
                var dp = new int[s.Length, s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    dp[i, i] = 1;
                }

                int max = 1;
                for (int start = s.Length - 1; start >= 0; start--)
                {
                    for (int end = start + 1; end < s.Length; end++)
                    {
                        if (s[start] == s[end])
                        {
                            dp[start, end] = 2 + dp[start + 1, end - 1];
                        }
                        else
                        {
                            dp[start, end] = Math.Max(dp[start + 1, end], dp[start, end - 1]);
                        }
                        max = Math.Max(max, dp[start, end]);
                    }
                }
                return max;
            }

            public bool CanPermutePalindrome(string s)
            {
                if (string.IsNullOrEmpty(s)) return false;
                int c = s[0] - 'a';

                for (int i = 1; i < s.Length; i++)
                {
                    c = c ^ (s[i] - 'a');
                }

                return c == 0 || s.IndexOf((char)(c + 'a')) >= 0;
            }

            public int LongestPalindromeSubseq(string s)
            {
                var dp = new int[s.Length, s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    dp[i, i] = 1;
                }

                int max = 1;
                for (int start = s.Length - 1; start >= 0; start--)
                {
                    for (int end = start + 1; end < s.Length; end++)
                    {
                        if (s[start] == s[end])
                        {
                            dp[start, end] = 2 + dp[start + 1, end - 1];
                        }
                        else
                        {
                            dp[start, end] = Math.Max(dp[start + 1, end], dp[start, end - 1]);
                        }
                        max = Math.Max(max, dp[start, end]);
                    }
                }
                return max;
            }

            public int LongestPalindromeSubseqRec(string s)
            {
                var dp = new int[s.Length, s.Length];
                return LongestPalindromeSubseqR(s, ref dp, 0, s.Length - 1);
            }

            private int LongestPalindromeSubseqR(string s, ref int[,] dp, int start, int end)
            {
                if (start > end) return 0;
                if (start == end) return 1;

                if (dp[start, end] == 0)
                {

                    if (s[start] == s[end])
                    {
                        dp[start, end] = 2 + LongestPalindromeSubseqR(s, ref dp, start + 1, end - 1);
                        return dp[start, end];
                    }

                    var opt1 = LongestPalindromeSubseqR(s, ref dp, start + 1, end);
                    var opt2 = LongestPalindromeSubseqR(s, ref dp, start, end - 1);

                    dp[start, end] = Math.Max(opt1, opt2);
                }

                return dp[start, end];
            }

            public int CountSubstrings(string s)
            {
                var dp = new bool[s.Length, s.Length];

                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    dp[i, i] = true;
                    count++;
                }

                for (int start = s.Length - 1; start >= 0; start--)
                {
                    for (int end = start + 1; end < s.Length; end++)
                    {
                        if (s[start] == s[end])
                        {
                            dp[start, end] = end - start == 1 || dp[start + 1, end - 1];
                            if (dp[start, end]) count++;
                        }
                    }
                }

                return count;
            }

            public string LongestPalindromeI2(string s)
            {
                if (string.IsNullOrEmpty(s)) return s;

                var dp = new bool[s.Length, s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    dp[i, i] = true;
                }

                int minStart = s.Length - 1, maxEnd = s.Length - 1;
                for (int start = s.Length - 1; start >= 0; start--)
                {
                    for (int end = start + 1; end < s.Length; end++)
                    {
                        if (s[start] == s[end])
                        {
                            dp[start, end] = end - start == 1 || dp[start + 1, end - 1];
                            if (dp[start, end])
                            {
                                (minStart, maxEnd) = (maxEnd - minStart) < (end - start)
                                    ? (start, end)
                                    : (minStart, maxEnd);
                            }
                        }
                    }
                }
                return s.Substring(minStart, maxEnd - minStart + 1);
            }

            public string LongestPalindromeI(string s)
            {
                if (string.IsNullOrEmpty(s)) return s;

                var dp = new bool[s.Length, s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    dp[i, i] = true;
                }

                string maxPal = s[0].ToString();
                for (int start = s.Length - 1; start >= 0; start--)
                {
                    for (int end = start + 1; end < s.Length; end++)
                    {
                        if (s[start] == s[end])
                        {
                            dp[start, end] = end - start == 1 || dp[start + 1, end - 1];
                            if (dp[start, end])
                                maxPal = maxPal.Length < end - start + 1 ? s.Substring(start, end - start + 1) : maxPal;
                        }
                    }
                }
                return maxPal;
            }

            public string LongestPalindrome(string s)
            {
                string[,] dp = new string[s.Length, s.Length];
                var res = LongestPalindromeR(s, ref dp, 0, s.Length - 1);
                return res;
            }

            private string LongestPalindromeR(string s, ref string[,] dp, int start, int end)
            {
                if (start > end) return string.Empty;
                if (start == end) return s[start].ToString();
                if (string.IsNullOrEmpty(dp[start, end]))
                {
                    if (s[start] == s[end])
                    {
                        var rem = LongestPalindromeR(s, ref dp, start + 1, end - 1);
                        if (rem.Length == (end - start - 1))
                        {
                            dp[start, end] = s[start] + rem + s[end];
                            return dp[start, end];
                        }
                    }

                    var res1 = LongestPalindromeR(s, ref dp, start + 1, end);
                    var res2 = LongestPalindromeR(s, ref dp, start, end - 1);

                    dp[start, end] = res1.Length > res2.Length ? res1 : res2;
                }

                return dp[start, end];
            }

            public int ClimbStairs(int n)
            {
                var dp = new int[n + 1];
                ClimbStairsR(n, ref dp);
                return dp[n];
            }

            private int ClimbStairsR(in int n, ref int[] dp)
            {
                if (n < 0) return 0;
                if (0 == n)
                {
                    return 1;
                }

                if (dp[n] == 0)
                {
                    int r1 = ClimbStairsR(n - 1, ref dp);
                    int r2 = ClimbStairsR(n - 2, ref dp);
                    dp[n] = r1 + r2;
                }

                return dp[n];
            }

            public int FindMaxSteal(int[] wealth)
            {
                int[] dp = new int[wealth.Length];
                return FindMaxStealR(wealth, ref dp, 0);
            }

            private int FindMaxStealR(int[] wealth, ref int[] dp, int i)
            {
                if (i > wealth.Length - 1) return 0;

                if (dp[i] == 0)
                {
                    var option1 = wealth[i] + FindMaxStealR(wealth, ref dp, i + 2);
                    var option2 = FindMaxStealR(wealth, ref dp, i + 1);
                    dp[i] = Math.Max(option1, option2);
                }

                return dp[i];
            }

            public int findMinFee(int[] fee)
            {
                int[] dp = new int[fee.Length + 1]; // +1 to handle the 0th step
                dp[0] = 0; // if there are no steps, we dont have to pay any fee
                dp[1] = fee[0]; // only one step, so we have to pay its fee
                // for 2 or 3 steps staircase, since we start from the first step so we have to pay its fee
                // and from the first step we can reach the top by taking two or three steps, so we don't
                // have to pay any other fee.
                dp[2] = dp[3] = fee[0];

                for (int i = 3; i < fee.Length; i++)
                    dp[i + 1] = Math.Min(fee[i] + dp[i], Math.Min(fee[i - 1] + dp[i - 1], fee[i - 2] + dp[i - 2]));

                return dp[fee.Length];
            }

            public int FindMinFee(int[] fees)
            {
                int[] dp = new int[fees.Length];
                int minFee = FindMinFeeR(fees, ref dp, 0);
                return minFee;
            }

            public int FindMinFeeR(int[] fees, ref int[] dp, int index)
            {
                if (index > fees.Length - 1) return 0;

                if (dp[index] == 0)
                {
                    var min1 = FindMinFeeR(fees, ref dp, index + 1);
                    var min2 = FindMinFeeR(fees, ref dp, index + 2);
                    var min3 = FindMinFeeR(fees, ref dp, index + 3);

                    dp[index] = fees[index] + Math.Min(min1, Math.Min(min2, min3));

                }
                return dp[index];
            }

            public string NumberToWords(int num)
            {
                var dic = new Dictionary<int, string>
                {
                    {1000000, "Million"},
                    {1000, "Thousand"},
                    {100, "Hundred"},

                    {90, "Ninety"},
                    {80, "Eighty"},
                    {70, "Seventy"},
                    {60, "Sixty"},
                    {50, "Fifty"},
                    {40, "Forty"},
                    {30, "Thirty"},
                    {20, "Twenty"},

                    {19, "Nineteen"},
                    {18, "Eighteen"},
                    {17, "Seventeen"},
                    {16, "Sixteen"},
                    {15, "Fifteen"},
                    {14, "Fourteen"},
                    {13, "Thirteen"},
                    {12, "Twelve"},
                    {11, "Eleven"},

                    {10, "Ten"},

                    {9, "Nine"},
                    {8, "Eight"},
                    {7, "Seven"},
                    {6, "Six"},
                    {5, "Five"},
                    {4, "Four"},
                    {3, "Three"},
                    {2, "Two"},
                    {1, "One"}
                };

                var sb = new StringBuilder();
                var st = new Stack<(int n, bool divide)>();
                st.Push((num, true));
                while (st.Count > 0)
                {
                    var (n, divide) = st.Pop();
                    foreach (var kv in dic.OrderByDescending(kv => kv.Key))
                    {
                        int div = n / kv.Key, mod = n % kv.Key;
                        if (div > 0)
                        {
                            if (dic.ContainsKey(div)) // && 100 != div
                            {
                                if (divide) sb.Append(dic[div] + " ");
                                sb.Append(kv.Value + " ");
                                st.Push((mod, true));
                            }
                            else
                            {
                                st.Push((mod, true));
                                st.Push((kv.Key, false));
                                st.Push((div, true));
                            }
                            break;
                        }
                    }
                }
                return sb.ToString();
            }

            public ListNode MergeKLists(ListNode[] lists)
            {
                var h = new Heap<int>(lists.Length, true,
                    Comparer<int>.Create((n1, n2) => n1.CompareTo(n2)));

                ListNode newNode = null, rootNode = null;
                for (int i = 0; i < lists.Length; i++)
                {
                    var node = lists[i];
                    while (node != null)
                    {
                        h.Add(node.val);
                        node = node.next;
                    }
                }

                while (h.Count > 0)
                {
                    var node = new ListNode(h.Pop());
                    if (rootNode == null)
                    {
                        rootNode = newNode = node;
                    }
                    else
                    {
                        newNode.next = node;
                        newNode = newNode.next;
                    }
                }

                return rootNode;
            }

            public double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
                int mid1 = (nums1.Length + nums2.Length) / 2, mid2 = -1;
                if ((nums1.Length + nums2.Length) % 2 == 0)
                {
                    mid1--;
                    mid2 = mid1 + 1;
                }

                int min1Val = 0, min2Val = 0;
                if (nums2.Length > 0 && (nums1.Length == 0 || nums2[0] > nums1[nums1.Length - 1]))
                {
                    if (mid1 < nums1.Length)
                    {
                        min1Val = nums1[mid1];
                    }
                    else
                    {
                        min1Val = nums2[mid1 - nums1.Length];
                    }

                    if (mid2 != -1)
                    {
                        if (mid2 < nums1.Length)
                        {
                            min2Val = nums1[mid2];
                        }
                        else
                        {
                            min2Val = nums2[mid2 - nums1.Length];
                        }
                    }
                }
                else if (nums1.Length > 0 && (nums2.Length == 0 || nums1[0] > nums2[nums2.Length - 1]))
                {
                    if (mid1 < nums2.Length)
                    {
                        min1Val = nums2[mid1];
                    }
                    else
                    {
                        min1Val = nums1[mid1 - nums2.Length];
                    }

                    if (mid2 != -1)
                    {
                        if (mid2 < nums2.Length)
                        {
                            min2Val = nums2[mid2];
                        }
                        else
                        {
                            min2Val = nums1[mid2 - nums2.Length];
                        }
                    }
                }
                else
                {
                    int i = 0, j = 0, count = 0;

                    while (count <= Math.Max(mid1, mid2))
                    {
                        min1Val = min2Val;
                        if (i < nums1.Length && (j >= nums2.Length || nums1[i] < nums2[j]))
                        {
                            min2Val = nums1[i];
                            i++;
                        }
                        else
                        {
                            min2Val = nums2[j];
                            j++;
                        }
                        count++;
                    }

                    if (mid2 == -1)
                    {
                        min1Val = min2Val;
                    }
                }

                if (mid2 != -1)
                {
                    return (double)(min1Val + min2Val) / 2;
                }

                return min1Val;
            }

            public int Trap(int[] height)
            {
                var st = new Stack<int>();
                var sum = 0;
                for (int i = 0; i < height.Length; i++)
                {
                    while (st.Count > 0 && height[i] > height[st.Peek()])
                    {
                        int top = st.Peek();
                        st.Pop();
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

            public int[] MaxSlidingWindow(int[] nums, int k)
            {
                Heap<int> h = new Heap<int>(k, isMin: false);

                for (int i = 0; i < k; i++)
                {
                    h.Add(nums[i]);
                }

                var result = new List<int> { h.Peek() };
                for (int i = k; i < nums.Length; i++)
                {
                    h.Delete(nums[i - k]);
                    h.Add(nums[i]);
                    result.Add(h.Peek());
                }

                return result.ToArray();
            }

            public int[] MaxSlidingWindowOld(int[] nums, int k)
            {
                if (nums.Length == 0 || k == 0) return new int[0];
                int max = int.MinValue, prevMax = int.MaxValue;
                for (int i = 0; i < k; i++)
                {
                    if (max <= nums[i])
                    {
                        prevMax = max;
                        max = nums[i];
                    }
                    else prevMax = Math.Max(prevMax, nums[i]);
                }

                var result = new List<int> { max };
                for (int i = k; i < nums.Length; i++)
                {
                    if (max == nums[i - k])
                    {
                        max = prevMax;
                    }

                    if (max < nums[i])
                    {
                        max = nums[i];
                        prevMax = max;
                    }
                    else
                    {
                        prevMax = Math.Max(prevMax, nums[i]);
                    }
                    result.Add(max);
                }

                return result.ToArray();
            }

            public int LongestConsecutive(int[] nums)
            {
                if (nums == null || nums.Length == 0) return 0;

                Array.Sort(nums);

                int[] cons = new int[nums.Length];
                cons[nums.Length - 1] = 1;
                int max = 1, dup = 0, seqStart = nums.Length - 1;
                for (int i = nums.Length - 2; i >= 0; i--)
                {
                    var diff = nums[i + 1] - nums[i];
                    if (diff == 1 || diff == 0)
                    {
                        cons[i] = cons[i + 1] + diff;
                        //if (diff == 0) dup++;
                        //if (diff == 1 && dup > 0)
                        //{
                        //    if (nums[seqStart] != nums[i + 1])
                        //        cons[i] += dup;
                        //    dup = 0;
                        //    seqStart = i;
                        //}
                    }
                    else
                    {
                        seqStart = i;
                        cons[i] = 1;
                    }
                    max = Math.Max(max, cons[i]);
                }

                return max;
            }

            public int MaxPathSum(TreeNode root)
            {
                int max = int.MinValue;
                TraverseAndSum(root, ref max);
                return max;
            }

            private int TraverseAndSum(TreeNode node, ref int max)
            {
                if (node == null) return 0;
                var path1 = TraverseAndSum(node.left, ref max);
                var path2 = TraverseAndSum(node.right, ref max);
                var res = Math.Max(Math.Max(node.val, path1 + node.val), path2 + node.val);
                max = Math.Max(max, Math.Max(res, path1 + path2 + node.val));
                return res;
            }

            protected HashSet<string> wordSet;
            protected Dictionary<string, List<List<string>>> memo;

            public IList<string> WordBreak(string s, IList<string> wordDict)
            {
                wordSet = wordDict.ToHashSet();

                memo = new Dictionary<string, List<List<string>>>();

                _wordBreak_topdown(s);

                // chain up words together
                var ret = new List<string>();
                foreach (List<string> words in memo[s])
                {
                    var sentence = new StringBuilder();
                    for (int i = 0; i < words.Count; i++)
                    {
                        var word = words[i];
                        sentence.Insert(0, word);
                        sentence.Insert(0, " ");
                    }
                    ret.Add(sentence.ToString().Trim());
                }

                return ret;
            }

            protected List<List<string>> _wordBreak_topdown(string s)
            {
                if (s.Equals(""))
                {
                    var solutions = new List<List<string>>();
                    solutions.Add(new List<string>());
                    return solutions;
                }

                if (memo.ContainsKey(s))
                {
                    return memo[s];
                }
                else
                {
                    var solutions = new List<List<string>>();
                    memo.Add(s, solutions);
                }

                for (int endIndex = 1; endIndex <= s.Length; ++endIndex)
                {
                    string word = s.Substring(0, endIndex);
                    if (wordSet.Contains(word))
                    {
                        var subsentences = _wordBreak_topdown(s.Substring(endIndex));
                        foreach (var subsentence in subsentences)
                        {
                            var newSentence = new List<string>(subsentence);
                            newSentence.Add(word);
                            memo[s].Add(newSentence);
                        }
                    }
                }
                return memo[s];
            }

            public IList<string> WordBreakOld(string s, IList<string> wordDict)
            {
                var lst = new List<string>();
                var dic = wordDict.ToHashSet();
                WordBreakR(s, dic, lst, new List<string>(), 0);
                return lst;
            }

            private void WordBreakR(string s, HashSet<string> wordDict, List<string> lst, List<string> words, int i)
            {
                if (i == s.Length)
                {
                    lst.Add(string.Join(" ", words));
                    return;
                }

                var rem = s.Substring(i);
                foreach (var dicWord in wordDict)
                {
                    if (rem.StartsWith(dicWord))
                    {
                        words.Add(dicWord);
                        WordBreakR(s, wordDict, lst, words, i + dicWord.Length);
                        words.RemoveAt(words.Count - 1);
                    }
                }
            }

            private void WordBreakR_Old(string s, HashSet<string> wordDict, List<string> lst, List<string> words, int i)
            {
                if (i == s.Length)
                {
                    lst.Add(string.Join(" ", words));
                    return;
                }
                var word = "";
                for (int j = i; j < s.Length; j++)
                {
                    word += s[j];
                    if (wordDict.Contains(word))
                    {
                        words.Add(word);
                        WordBreakR(s, wordDict, lst, words, j + 1);
                        words.RemoveAt(words.Count - 1);
                    }
                }
            }

            public IList<IList<string>> FindDuplicate(string[] paths)
            {
                var dic = new Dictionary<string, List<string>>();
                var lst = new List<IList<string>>();
                foreach (var path in paths)
                {
                    var dirFilesSplit = path.Split(' ', 2);
                    var files = Regex.Split(dirFilesSplit[1], "[()]");
                    for (int i = 0; i < files.Length - 1; i += 2)
                    {
                        var filePath = dirFilesSplit[0] + "/" + files[i].TrimStart();
                        if (dic.ContainsKey(files[i + 1]))
                        {
                            dic[files[i + 1]].Add(filePath);
                        }
                        else
                        {
                            dic.Add(files[i + 1], new List<string> { filePath });
                        }
                    }
                }

                foreach (var kv in dic)
                {
                    if (kv.Value.Count > 1) lst.Add(kv.Value);
                }

                return lst;
            }

            public void GameOfLife(int[][] board)
            {
                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        var neighborsCount = CountNeighbors(board, i, j);
                        if (board[i][j] == 0)
                        {
                            if (neighborsCount == 3) board[i][j] = 1;
                        }
                        else
                        {
                            if (neighborsCount < 2) board[i][j] = 10;
                            else if (neighborsCount == 2 || neighborsCount == 3) board[i][j] = 11;
                            else board[i][j] = 10;
                        }
                    }
                }

                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        board[i][j] = board[i][j] % 10;
                    }
                }
            }

            private int CountNeighbors(int[][] board, in int i, in int j)
            {
                return GetValue(board, i - 1, j - 1, true) +
                       GetValue(board, i - 1, j, true) +
                       GetValue(board, i - 1, j + 1, true) +
                       GetValue(board, i, j - 1, true) +
                       GetValue(board, i, j + 1, false) +
                       GetValue(board, i + 1, j - 1, false) +
                       GetValue(board, i + 1, j, false) +
                       GetValue(board, i + 1, j + 1, false);
            }

            private int GetValue(int[][] board, in int i, in int j, bool calcPrev)
            {
                if (i >= 0 && i < board.Length && j >= 0 && j < board[i].Length)
                {
                    if (calcPrev)
                    {
                        return board[i][j] / 10;
                    }
                    return board[i][j];
                }
                return 0;
            }

            public int MaximalSquare(char[][] matrix)
            {
                if (matrix == null || matrix.Length == 0) return matrix.Length;

                var dp = new int[matrix[0].Length];
                int maxSquare = 0, left = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == '0') continue;

                        left = j == 0 ? 0 : dp[j - 1];
                        int top = j > 0 ? dp[j] : 0,
                            topLeft = j > 0 ? dp[j - 1] : 0;
                        dp[j] = Math.Min(Math.Min(top, left), topLeft) + 1;
                        maxSquare = Math.Max(maxSquare, dp[j]);
                    }
                }
                return maxSquare * maxSquare;
            }

            public int MaximalSquare_SpaceOn2(char[][] matrix)
            {
                if (matrix == null || matrix.Length == 0) return matrix.Length;

                var dp = new int[matrix.Length, matrix[0].Length];
                int maxSquare = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == '0') continue;

                        int top = i > 0 ? dp[i - 1, j] : 0,
                            left = j > 0 ? dp[i, j - 1] : 0,
                            topLeft = i > 0 && j > 0 ? dp[i - 1, j - 1] : 0;
                        dp[i, j] = Math.Min(Math.Min(top, left), topLeft) + 1;
                        maxSquare = Math.Max(maxSquare, dp[i, j]);
                    }
                }
                return maxSquare * maxSquare;
            }

            public int MinKnightMoves(int x, int y)
            {
                var q = new Queue<(int i, int j, int moves)>();
                int x1 = Math.Abs(x), y1 = Math.Abs(y);
                var visited = new bool[x1 + 5, y1 + 5];
                q.Enqueue((0, 0, 0));
                visited[0, 0] = true;

                int totalMoves = 0;
                while (q.Count > 0)
                {
                    var (i, j, pMoves) = q.Dequeue();
                    if (i == x && j == y)
                    {
                        totalMoves = pMoves;
                        break;
                    }

                    List<(int i, int j, int moves)> moves = new List<(int i, int j, int moves)>
                    {
                        (i - 1, j - 2, pMoves + 1),
                        (i - 2, j - 1, pMoves + 1),
                        (i - 2, j + 1, pMoves + 1),
                        (i - 1, j + 2, pMoves + 1),
                        (i + 1, j + 2, pMoves + 1),
                        (i + 2, j + 1, pMoves + 1),
                        (i + 2, j - 1, pMoves + 1),
                        (i + 1, j - 2, pMoves + 1)
                    };

                    foreach (var move in moves)
                    {
                        if (!visited[move.i + x + 4, move.j + y + 4])
                        {
                            visited[move.i + x + 4, move.j + y + 4] = true;
                            q.Enqueue(move);
                        }
                    }
                }
                return totalMoves;
            }

            public int MinSubArrayLen(int s, int[] nums)
            {
                int sum = 0, left = 0, min = int.MaxValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    while (sum >= s)
                    {
                        min = Math.Min(min, i - left + 1);
                        sum -= nums[left];
                        left++;
                    }
                }
                return min == int.MaxValue ? 0 : min;
            }

            public int MinSubArrayLen_ON2(int s, int[] nums)
            {
                int[] sums = new int[nums.Length + 1];
                for (int i = 0; i < nums.Length; i++)
                {
                    sums[i + 1] = sums[i] + nums[i];
                    if (nums[i] >= s) return 1;
                }

                for (int k = 2; k <= nums.Length; k++)
                {
                    for (int i = 0; i <= nums.Length - k; i++)
                    {
                        if (sums[k + i] - sums[i] >= s) return k;
                    }
                }
                return 0;
            }

            public int MinPathSum_O1Space(int[][] grid)
            {
                if (grid != null && grid.Length == 0) return 0;

                int width = grid[0].Length, height = grid.Length;
                for (int i = height - 1; i >= 0; i--)
                {
                    for (int j = width - 1; j >= 0; j--)
                    {
                        int right = j < width - 1 ? grid[i][j + 1] : int.MaxValue;
                        int down = i < height - 1 ? grid[i + 1][j] : int.MaxValue;
                        var min = Math.Min(right, down);
                        grid[i][j] = grid[i][j] + (min == int.MaxValue ? 0 : min);
                    }
                }

                return grid[0][0];
            }

            public int MinPathSum_ONSpace(int[][] grid)
            {
                if (grid != null && grid.Length == 0) return 0;
                int width = grid[0].Length, height = grid.Length;
                var dp = new int[width];

                for (int i = height - 1; i >= 0; i--)
                {
                    for (int j = width - 1; j >= 0; j--)
                    {
                        int right = j < width - 1 ? dp[j + 1] : dp[j];
                        int current = i == height - 1 && j < width - 1 ? dp[j + 1] : dp[j];
                        dp[j] = grid[i][j] + Math.Min(right, current);
                    }
                }

                return dp[0];
            }

            public int MinPathSum_ON2Space(int[][] grid)
            {
                if (grid != null && grid.Length == 0) return 0;
                var dp = new int[grid.Length, grid[0].Length];

                int width = grid[0].Length, height = grid.Length;
                for (int i = height - 1; i >= 0; i--)
                {
                    for (int j = width - 1; j >= 0; j--)
                    {
                        int right = j < width - 1 ? dp[i, j + 1] : int.MaxValue;
                        int down = i < height - 1 ? dp[i + 1, j] : int.MaxValue;
                        var min = Math.Min(right, down);
                        dp[i, j] = grid[i][j] + (min == int.MaxValue ? 0 : min);
                    }
                }

                return dp[0, 0];
            }

            public int MinPathSumDFS(int[][] grid)
            {
                if (grid != null && grid.Length == 0) return 0;
                var minSum = int.MaxValue;
                var st = new Stack<(int i, int j, int sum)>();
                st.Push((0, 0, grid[0][0]));

                while (st.Count > 0)
                {
                    var item = st.Pop();
                    if (item.i == grid.Length - 1 && item.j == grid[0].Length - 1)
                    {
                        minSum = Math.Min(minSum, item.sum);
                        continue;
                    }

                    if (item.j + 1 < grid[0].Length) st.Push((item.i, item.j + 1, item.sum + grid[item.i][item.j + 1]));
                    if (item.i + 1 < grid.Length) st.Push((item.i + 1, item.j, item.sum + grid[item.i + 1][item.j]));
                }

                return minSum;
            }

            public string IntToRoman(int num)
            {
                var dic = new Dictionary<int, string>
                {
                    {1000, "M"},
                    {900, "CM"},
                    {500, "D"},
                    {400, "CD"},
                    {100, "C"},
                    {90, "XC"},
                    {50, "L"},
                    {40, "XL"},
                    {10, "X"},
                    {9, "IX"},
                    {5, "V"},
                    {4, "IV"},
                    {1, "I"},
                };

                var sb = new StringBuilder();
                foreach (var kv in dic)
                {
                    int rem = num % kv.Key, div = num / kv.Key;
                    if (div > 0) sb.Append(string.Join("", Enumerable.Repeat(kv.Value, div)));
                    num = rem;
                    if (num == 0) break;
                }
                return sb.ToString();
            }

            public IList<string> FindItinerary(IList<IList<string>> tickets)
            {
                var dic = new Dictionary<string, SortedSet<string>>();
                foreach (var ticket in tickets)
                {
                    if (dic.ContainsKey(ticket[0]))
                    {
                        dic[ticket[0]].Add(ticket[1]);
                    }
                    else dic.Add(ticket[0], new SortedSet<string> { ticket[1] });
                }

                var key = "JFK";
                var result = new List<string> { key };
                while (key != null && dic.ContainsKey(key))
                {
                    var dest = dic[key].Min();
                    if (!string.IsNullOrEmpty(dest))
                    {
                        dic[key].Remove(dest);
                        result.Add(dest);
                    }
                    key = dest;
                }

                return result;
            }

            public int[] AsteroidCollision(int[] asteroids)
            {
                var st = new Stack<int>();
                int lastIndex = 0;
                do
                {
                    var ast = asteroids[lastIndex++];
                    if (st.Count == 0)
                    {
                        st.Push(ast);
                    }
                    else
                    {
                        var prev = st.Pop();
                        if (NoCollision(prev, ast))
                        {
                            st.Push(prev);
                            st.Push(ast);
                        }
                        else if (Math.Abs(ast) != Math.Abs(prev))
                        {
                            var winner = Math.Abs(ast) > Math.Abs(prev) ? ast : prev;
                            while (st.Count > 0)
                            {
                                prev = st.Pop();
                                if (NoCollision(prev, winner))
                                {
                                    st.Push(prev);
                                    break;
                                }
                                else if (Math.Abs(ast) != Math.Abs(prev))
                                {
                                    winner = Math.Abs(winner) > Math.Abs(prev) ? winner : prev;
                                }
                                else
                                {
                                    winner = 0;
                                    break;
                                }
                            }
                            if (winner != 0) st.Push(winner);
                        }
                    }
                } while (lastIndex < asteroids.Length);

                return st.Reverse().ToArray();
            }

            private bool NoCollision(int prev, int ast)
            {
                return (prev > 0 && ast > 0) || (prev < 0 && ast < 0) || (prev < 0 && ast > 0);
            }

            public int[] SearchRange(int[] nums, int target)
            {
                int minIndex = int.MaxValue, maxIndex = int.MinValue;
                var mid = FindBoundaries(nums, target, 0, nums.Length, ref minIndex, ref maxIndex);
                return new[] { minIndex == int.MaxValue ? -1 : minIndex, maxIndex == Int32.MinValue ? -1 : maxIndex };
            }

            private int FindBoundaries(int[] nums, in int target, int low, in int high, ref int minIndex, ref int maxIndex)
            {
                if (low >= high) return -1;

                var mid = (low + high) / 2;

                if (nums[mid] > target)
                    return FindBoundaries(nums, target, low, mid, ref minIndex, ref maxIndex);
                else if (nums[mid] < target)
                    return FindBoundaries(nums, target, mid + 1, high, ref minIndex, ref maxIndex);
                else
                {
                    minIndex = Math.Min(minIndex, mid);
                    maxIndex = Math.Max(maxIndex, mid);
                    FindBoundaries(nums, target, low, mid, ref minIndex, ref maxIndex);
                    FindBoundaries(nums, target, mid + 1, high, ref minIndex, ref maxIndex);
                }

                return -1;
            }

            public string LongestCommonPrefix(string[] strs)
            {
                if (strs.Length == 0) return string.Empty;
                if (strs.Length == 1) return strs[0];

                bool shouldEnd = false;
                int i;
                for (i = 0; i < strs[0].Length; i++)
                {
                    for (int j = 1; j < strs.Length; j++)
                    {
                        if (i >= strs[j].Length || strs[0][i] != strs[j][i])
                        {
                            shouldEnd = true;
                            break;
                        }
                    }
                    if (shouldEnd) break;
                }

                return strs[0].Substring(0, i);
            }

            public int SingleNumber(int[] nums)
            {
                var unique = 0;
                foreach (var num in nums)
                {
                    unique = unique ^ num;
                }
                return unique;
            }

            public int SingleNumberOld(int[] nums)
            {
                var dic = new Dictionary<int, int>();
                foreach (var num in nums)
                {
                    if (dic.ContainsKey(num)) dic[num]++;
                    else dic.Add(num, 1);
                }

                foreach (var kv in dic)
                {
                    if (kv.Value == 1) return kv.Key;
                }
                return -1;
            }

            public bool IsPalindrome(string s)
            {
                if (string.IsNullOrEmpty(s)) return true;
                s = s.ToLower();
                int i = 0, j = s.Length - 1;
                while (i < j)
                {
                    char ch1 = s[i], ch2 = s[j];
                    var isCh1Valid = Char.IsLetterOrDigit(ch1);
                    var isCh2Valid = Char.IsLetterOrDigit(ch2);
                    if (!isCh1Valid || !isCh2Valid)
                    {
                        if (!isCh1Valid) i++;
                        if (!isCh2Valid) j--;
                        continue;
                    }
                    if (ch1 != ch2) return false;
                    i++;
                    j--;
                }
                return true;
            }

            public int FirstUniqChar(string s)
            {
                int[] occ = new int[26];
                foreach (var ch in s)
                {
                    occ[ch - 'a']++;
                }

                for (int i = 0; i < s.Length; i++)
                {
                    if (occ[s[i] - 'a'] == 1) return i;
                }
                return -1;
            }

            public string MostCommonWord(string paragraph, string[] banned)
            {
                var hs = banned.ToHashSet();
                var words = Regex.Split(paragraph, @"[\s.?!,;,']")
                    .Where(w => !string.IsNullOrEmpty(w)).Select(w => w.ToLower()).ToList();
                var dic = new Dictionary<string, int>();
                foreach (var word in words)
                {
                    if (hs.Contains(word)) continue;
                    if (dic.ContainsKey(word))
                    {
                        dic[word]++;
                    }
                    else dic.Add(word, 1);
                }

                return dic.OrderByDescending(kv => kv.Value).First().Key;
            }

            public int MyAtoi(string str)
            {
                str = str.Trim();
                if (string.IsNullOrEmpty(str)) return 0;
                if (str[0] != '-' && str[0] != '+' && !(str[0] >= '0' && str[0] <= '9')) return 0;
                int sign = 1, startIndex = 0;
                if (str[0] == '-')
                {
                    startIndex = 1;
                    sign = -1;
                }
                else if (str[0] == '+')
                {
                    startIndex = 1;
                    sign = 1;
                }

                long sum = 0;
                for (int i = startIndex, j = 0; i < str.Length; i++)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                    {
                        sum = sum * 10 + (str[i] - '0');
                        if (sum > int.MaxValue) return sign == -1 ? int.MinValue : int.MaxValue;
                    }
                    else return sign * (int)sum;
                }

                return (int)sum * sign;
            }

            public IList<IList<int>> CombinationSum(int[] candidates, int target)
            {
                Array.Sort(candidates);
                var hs = candidates.ToHashSet();

                var results = new List<IList<int>>();
                for (int i = 0; i < candidates.Length; i++)
                {
                    if (candidates[i] > target) break;

                    var combination = new List<int>();
                    if (candidates[i] % target == 0)
                    {
                        combination.AddRange(Enumerable.Repeat(candidates[i], target / candidates[i]));
                        results.Add(combination.GetRange(0, combination.Count));
                    }

                    int rem = target;
                    do
                    {
                        rem = rem - candidates[i];
                        combination.Add(candidates[i]);
                        if (hs.Contains(rem))
                        {
                            combination.Add(rem);
                            if (!Contains(results, combination))
                                results.Add(combination.GetRange(0, combination.Count));
                            combination.RemoveAt(combination.Count - 1);
                        }
                    } while (rem > 0);
                }
                return results;
            }

            private bool Contains(List<IList<int>> results, List<int> combination)
            {
                var c = combination.ToArray();
                Array.Sort(c);
                for (int i = 0; i < results.Count; i++)
                {
                    var l = results[i].ToArray();
                    if (l.Length == combination.Count)
                    {
                        Array.Sort(l);
                        int j = 0;
                        for (; j < l.Length; j++)
                        {
                            if (l[i] != c[i]) break;
                        }
                        if (j == l.Length) return true;
                    }
                }

                return false;
            }

            public IList<int> FindDuplicates(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    var item = nums[i];
                    if (nums[i] > 0) nums[i] = 0;
                    while (item > 0)
                    {
                        var temp = nums[item - 1];
                        nums[item - 1] = nums[item - 1] >= 0 ? -1 : (nums[item - 1] - 1);
                        item = temp;
                    }
                }

                var lst = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == -2) lst.Add(i + 1);
                }

                return lst;
            }

            public IList<int> FindAnagrams(string s, string p)
            {
                var res = new List<int>();
                if (string.IsNullOrEmpty(p) || string.IsNullOrEmpty(s) || p.Length > s.Length) return res;

                int[] ssArr = new int[26];
                int pArr = 0, sArr = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    ssArr[s[i] - 'a']++;
                    pArr = pArr | (int)Math.Pow(2, p[i] - 'a');
                    sArr = sArr | (int)Math.Pow(2, s[i] - 'a');
                }

                if (pArr == sArr)
                {
                    res.Add(0);
                }

                for (int j = p.Length; j < s.Length; j++)
                {
                    int removedChar = s[j - p.Length] - 'a', addedChar = s[j] - 'a';
                    ssArr[removedChar]--;
                    ssArr[addedChar]++;
                    if (ssArr[removedChar] == 0) sArr = sArr ^ (int)Math.Pow(2, removedChar);
                    sArr = sArr | (int)Math.Pow(2, addedChar);
                    if (pArr == sArr)
                    {
                        res.Add(j - p.Length + 1);
                    }
                }
                return res;
            }

            public IList<int> FindAnagramsOld(string s, string p)
            {
                var res = new List<int>();
                if (string.IsNullOrEmpty(p) || string.IsNullOrEmpty(s) || p.Length > s.Length) return res;

                int[] pArr = new int[26], sArr = new int[26];
                for (int i = 0; i < p.Length; i++)
                {
                    pArr[p[i] - 'a']++;
                    sArr[s[i] - 'a']++;
                }

                if (AreEqual(pArr, sArr))
                {
                    res.Add(0);
                }

                for (int j = p.Length; j < s.Length; j++)
                {
                    sArr[s[j - p.Length] - 'a']--;
                    sArr[s[j] - 'a']++;
                    if (AreEqual(pArr, sArr))
                    {
                        res.Add(j - p.Length + 1);
                    }
                }
                return res;
            }

            private bool AreEqual(int[] pArr, int[] sArr)
            {
                for (int i = 0; i < pArr.Length; i++)
                {
                    if (pArr[i] != sArr[i]) return false;
                }
                return true;
            }

            public IList<IList<int>> VerticalTraversal(TreeNode root)
            {
                if (root == null) return new List<IList<int>>();
                var dic = new Dictionary<int, List<(int level, int rank)>>();
                LevelOrderTraversal(root, ref dic);
                var result = new List<IList<int>>();
                foreach (var kv in dic.OrderBy(kv => kv.Key))
                {
                    result.Add(kv.Value.OrderBy(kv2 => kv2.level).ThenByDescending(kv2 => kv2.rank).Select(kv2 => kv2.rank).ToList());
                }
                return result;
            }

            public void LevelOrderTraversal(TreeNode root, ref Dictionary<int, List<(int level, int rank)>> dic)
            {
                var q = new Queue<(TreeNode node, int column)>();
                q.Enqueue((root, 0));

                var level = 0;
                while (q.TryDequeue(out var pair))
                {
                    if (dic.ContainsKey(pair.column))
                    {
                        dic[pair.column].Add((level, pair.node.val));
                    }
                    else dic.Add(pair.column, new List<(int level, int rank)> { (level, pair.node.val) });
                    if (pair.node.left != null) q.Enqueue((pair.node.left, pair.column - 1));
                    if (pair.node.right != null) q.Enqueue((pair.node.right, pair.column + 1));
                }
            }

            public IList<IList<int>> VerticalOrder(TreeNode root)
            {
                if (root == null) return new List<IList<int>>();
                var dic = new Dictionary<int, List<int>>();
                InOrderTraversal(root, 0, ref dic);
                //LevelOrderTraversal(root, ref dic);
                var result = new List<IList<int>>();
                foreach (var kv in dic.OrderBy(kv => kv.Key))
                {
                    result.Add(kv.Value);
                }
                return result;
            }

            public void LevelOrderTraversal(TreeNode root, ref Dictionary<int, List<int>> dic)
            {
                var q = new Queue<(TreeNode node, int column)>();
                q.Enqueue((root, 0));

                while (q.TryDequeue(out var pair))
                {
                    if (dic.ContainsKey(pair.column))
                    {
                        dic[pair.column].Add(pair.node.val);
                    }
                    else dic.Add(pair.column, new List<int> { pair.node.val });
                    if (pair.node.left != null) q.Enqueue((pair.node.left, pair.column - 1));
                    if (pair.node.right != null) q.Enqueue((pair.node.right, pair.column + 1));
                }
            }

            private void InOrderTraversal(TreeNode node, int i, ref Dictionary<int, List<int>> dic)
            {
                if (node == null) return;
                if (dic.ContainsKey(i))
                {
                    dic[i].Add(node.val);
                }
                else dic.Add(i, new List<int> { node.val });
                InOrderTraversal(node.left, i - 1, ref dic);
                InOrderTraversal(node.right, i + 1, ref dic);
            }

            public class BSTIterator
            {
                Stack<TreeNode> st = new Stack<TreeNode>();

                public BSTIterator(TreeNode root)
                {
                    while (root != null)
                    {
                        st.Push(root);
                        root = root.left;
                    }
                    //InOrderTraversal(root);
                }

                /** @return the next smallest number */
                public int Next()
                {
                    var item = st.Pop();
                    if (st.Count > 0)
                    {
                        st.Peek().left = null;
                    }

                    if (item.right != null)
                    {
                        var node = item.right;
                        while (node != null)
                        {
                            st.Push(node);
                            node = node.left;
                        }
                    }
                    return item.val;
                }

                /** @return whether we have a next smallest number */
                public bool HasNext()
                {
                    return st.Count > 0;
                }
            }

            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                l1 = ReverseLinkedList(l1);
                l2 = ReverseLinkedList(l2);

                ListNode l3 = null;
                int carry = 0;
                while (l1 != null || l2 != null)
                {
                    ListNode node = new ListNode();
                    var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                    node.val = sum % 10;
                    carry = sum / 10;

                    if (l3 == null)
                    {
                        l3 = node;
                    }
                    else
                    {
                        node.next = l3;
                        l3 = node;
                    }
                    l1 = l1?.next;
                    l2 = l2?.next;
                }

                if (carry > 0)
                {
                    ListNode node = new ListNode(carry);
                    node.next = l3;
                    l3 = node;
                }
                return l3;
            }

            private ListNode ReverseLinkedList(ListNode l1)
            {
                if (l1?.next == null) return l1;
                ListNode node = l1.next, prev = l1;
                prev.next = null;
                while (node != null)
                {
                    var temp = node.next;
                    node.next = prev;
                    prev = node;
                    node = temp;
                }
                return prev;
            }

            /*
                P     I    N
                A   L S  I G
                Y A   H R
                P     I
             */
            public string Convert(string s, int numRows)
            {
                if (numRows == 1) return s;
                var currRow = 0;
                var sbList = new List<StringBuilder>();
                for (int i = 0; i < numRows; i++)
                {
                    sbList.Add(new StringBuilder());
                }
                var goingDown = false;
                for (int i = 0; i < s.Length; i++)
                {
                    sbList[currRow].Append(s[i]);
                    if (currRow == 0 || currRow == numRows - 1)
                        goingDown = !goingDown;
                    currRow += goingDown ? 1 : -1;
                }

                return string.Join("", sbList);
            }

            /// <summary>
            /// Comparer for comparing two keys, handling equality as beeing greater
            /// Use this Comparer e.g. with SortedLists or SortedDictionaries, that don't allow duplicate keys
            /// </summary>
            /// <typeparam name="TKey"></typeparam>
            public class DuplicateKeyComparer<TKey>
                :
                    IComparer<TKey> where TKey : IComparable
            {
                #region IComparer<TKey> Members

                public int Compare(TKey x, TKey y)
                {
                    int result = x.CompareTo(y);

                    if (result == 0)
                        return 1;   // Handle equality as beeing greater
                    else
                        return result;
                }

                #endregion
            }

            public class MinStack
            {
                private (int, int)[] _arr;

                private int initialSize = 1024;
                private int _lastIndex = 0;
                /** initialize your data structure here. */
                public MinStack()
                {
                    _arr = new (int, int)[initialSize];
                }

                public void Push(int x)
                {
                    if (_lastIndex >= _arr.Length)
                    {
                        var temp = new (int, int)[_arr.Length * 2 + 1];
                        Array.Copy(_arr, temp, _arr.Length);
                        _arr = temp;
                    }

                    if (_lastIndex == 0)
                    {
                        _arr[_lastIndex++] = (x, x);
                    }
                    else
                    {
                        _arr[_lastIndex] = (x, Math.Min(x, _arr[_lastIndex - 1].Item2));
                        _lastIndex++;
                    }
                }

                public void Pop()
                {
                    --_lastIndex;
                }

                public int Top()
                {
                    return _arr[_lastIndex - 1].Item1;
                }

                public int GetMin()
                {
                    return _arr[_lastIndex - 1].Item2;
                }
            }

            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {
                TreeNode node = root;
                var qq = new Stack<TreeNode>();
                qq.Push(node);
                List<TreeNode> pParent = new List<TreeNode>(), qParent = new List<TreeNode>();

                FindPath(root, p, ref pParent);
                FindPath(root, q, ref qParent);

                //while (qq.Count > 0 && !pParentFound)
                //{
                //    node = qq.Pop();
                //    pParent.Add(node);
                //    if (node.val == p.val)
                //    {
                //        pParentFound = true;
                //    }
                //    else
                //    {
                //        if (node.left == null && node.right == null)
                //        {
                //            pParent.RemoveAt(pParent.Count - 1);
                //        }
                //    }
                //    if (node.left != null) qq.Push(node.left);
                //    if (node.right != null) qq.Push(node.right);
                //}

                //while (qq.Count > 0 && !qParentFound)
                //{
                //    node = qq.Pop();
                //    qParent.Add(node);
                //    if (node.val == q.val)
                //    {
                //        qParentFound = true;
                //    }
                //    else
                //    {
                //        if (node.left == null && node.right == null)
                //        {
                //            qParent.RemoveAt(qParent.Count - 1);
                //        }
                //    }
                //    if (node.left != null) qq.Push(node.left);
                //    if (node.right != null) qq.Push(node.right);
                //}

                var minLength = Math.Min(pParent.Count, qParent.Count);
                TreeNode parent = null;
                for (int i = 0; i < minLength; i++)
                {
                    if (pParent[i] != qParent[i]) break;
                    parent = pParent[i];
                }
                return parent;
            }

            private bool FindPath(TreeNode root, TreeNode node, ref List<TreeNode> parents)
            {
                parents.Add(root);
                if (root == node) return true;

                if (root.left != null)
                {
                    var isFound = FindPath(root.left, node, ref parents);
                    if (isFound) return true;
                }

                if (root.right != null)
                {
                    var isFound = FindPath(root.right, node, ref parents);
                    if (isFound) return true;
                }

                parents.Remove(root);
                return false;
            }

            /*
             Symbol       Value
                I             1
                V             5
                X             10
                L             50
                C             100
                D             500
                M             1000
             */
            public int RomanToInt(string s)
            {
                if (string.IsNullOrEmpty(s)) return 0;

                var dic = new Dictionary<char, int>
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000},
                };

                var prev = s[0];
                int sum = dic[prev], prevValue = dic[prev];
                for (int i = 1; i < s.Length; i++)
                {

                    var curr = dic[s[i]];
                    sum += curr;
                    if (prevValue < curr)
                    {
                        sum -= 2 * prevValue;
                    }
                    prevValue = curr;
                }
                return sum;
            }

            public int GetNext(int n, ref Dictionary<int, int> results)
            {
                if (results.ContainsKey(n)) return results[n];

                var sum = 0;
                while (n != 0)
                {
                    var rem = n % 10;
                    n = n / 10;
                    sum += rem * rem;
                }
                results[n] = sum;
                return sum;
            }

            public bool IsHappy(int n)
            {
                Dictionary<int, int> results = new Dictionary<int, int>();

                int slow = n, fast = GetNext(n, ref results);
                while (slow != fast && fast != 1)
                {
                    slow = GetNext(slow, ref results);
                    fast = GetNext(GetNext(fast, ref results), ref results);
                }
                return fast == 1;
            }

            public bool IsHappyHashSet(int n)
            {
                int n1 = n;
                var loop = new HashSet<int>();
                while (n1 != 1)
                {
                    var nums = n1.ToString().ToCharArray().Select(c => c - '0').ToList();
                    n1 = 0;
                    foreach (var num in nums)
                    {
                        n1 += num * num;
                    }

                    if (loop.Contains(n1)) break;
                    loop.Add(n1);
                }

                return n1 == 1;
            }

            public int[][] IntervalIntersection(int[][] A, int[][] B)
            {
                var lst = new List<int[]>();
                for (int i = 0; i < A.Length; i++)
                {
                    var (x1, y1) = (A[i][0], A[i][1]);
                    for (int j = 0; j < B.Length; j++)
                    {
                        var (x2, y2) = (B[j][0], B[j][1]);
                        var (x, y) = (Math.Max(x1, x2), Math.Min(y1, y2));
                        if (x <= y) lst.Add(new int[] { x, y });
                        else if ((x, y) == (x1, y2)) continue;
                        else break;
                    }
                }
                return lst.ToArray();
            }

            public IList<string> SubdomainVisits(string[] cpdomains)
            {
                var dic = new Dictionary<string, int>();
                foreach (var cpdomain in cpdomains)
                {
                    var spaceIndex = cpdomain.IndexOf(' ');
                    var visitsCount = int.Parse(cpdomain.Substring(0, spaceIndex));
                    var dotIndex = spaceIndex;
                    while (dotIndex != -1)
                    {
                        var domain = cpdomain.Substring(dotIndex + 1, cpdomain.Length - dotIndex - 1);
                        if (dic.ContainsKey(domain))
                        {
                            dic[domain] += visitsCount;
                        }
                        else dic.Add(domain, visitsCount);
                        dotIndex = cpdomain.IndexOf('.', dotIndex + 1);
                    }
                }

                return dic.Select(kv => $"{kv.Value} {kv.Key}").ToList();
            }

            public class TicTacToe
            {
                private readonly int _n;
                private int[,] arr;
                private int? playerWin = null;
                /** Initialize your data structure here. */
                public TicTacToe(int n)
                {
                    _n = n;
                    arr = new int[n, n];
                }

                /** Player {player} makes a move at ({row}, {col}).
                    @param row The row of the board.
                    @param col The column of the board.
                    @param player The player, can be either 1 or 2.
                    @return The current winning condition, can be either:
                            0: No one wins.
                            1: Player 1 wins.
                            2: Player 2 wins. */
                public int Move(int row, int col, int player)
                {
                    if (playerWin != null) return 0;

                    arr[row, col] = player;

                    bool isAWin = true;
                    for (int j = 0; j < _n; j++)
                    {
                        if (arr[row, j] != player)
                        {
                            isAWin = false;
                            break;
                        }
                    }
                    if (isAWin) return player;

                    isAWin = true;
                    for (int i = 0; i < _n; i++)
                    {
                        if (arr[i, col] != player)
                        {
                            isAWin = false;
                            break;
                        }
                    }
                    if (isAWin) return player;

                    var shouldCheckDiagonal = row == col || (row + col == _n - 1);
                    if (shouldCheckDiagonal)
                    {
                        bool isDiagonalA = true, isDiagonalB = true;
                        for (int k = 0; k < _n; k++)
                        {
                            isDiagonalA = isDiagonalA && arr[k, k] == player;
                            isDiagonalB = isDiagonalB && arr[k, _n - k - 1] == player;
                            if (!isDiagonalA && !isDiagonalB) break;
                        }
                        isAWin = isDiagonalB || isDiagonalA;
                    }
                    if (isAWin) return player;
                    return 0;
                }
            }

            public class MyHashMap
            {
                private int[] arr;

                /** Initialize your data structure here. */
                public MyHashMap()
                {
                    arr = new int[1000001];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = int.MinValue;
                    }
                }

                /** value will always be non-negative. */
                public void Put(int key, int value)
                {
                    arr[key] = value;
                }

                /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
                public int Get(int key)
                {
                    return arr[key] != Int32.MinValue ? arr[key] : -1;
                }

                /** Removes the mapping of the specified value key if this map contains a mapping for the key */
                public void Remove(int key)
                {
                    arr[key] = Int32.MinValue;
                }
            }

            public IList<string> FizzBuzz(int n)
            {
                var lst = new List<string>();
                for (int i = 1; i <= n; i++)
                {
                    if (i % 15 == 0) lst.Add("FizzBuzz");
                    else if (i % 3 == 0) lst.Add("Fizz");
                    else if (i % 5 == 0) lst.Add("Buzz");
                    else lst.Add(i.ToString());
                }
                return lst;
            }

            public class HitCounter
            {
                Heap<int> h;

                /** Initialize your data structure here. */
                public HitCounter()
                {
                    h = new Heap<int>(1000);
                }

                /** Record a hit.
                    @param timestamp - The current timestamp (in seconds granularity). */
                public void Hit(int timestamp)
                {
                    h.Add(timestamp);
                }

                /** Return the number of hits in the past 5 minutes.
                    @param timestamp - The current timestamp (in seconds granularity). */
                public int GetHits(int timestamp)
                {
                    while (h.Count > 0 && timestamp - h.Peek() >= 300)
                    {
                        h.Pop();
                    }
                    return h.Count;
                }
            }

            public int Calculate(string s)
            {
                s = s.Replace(" ", "");
                var components = Regex.Split(s, @"([*()\^\/]|(?<!E)[\+\-])");
                List<string> st1 = new List<string>(components.Length);

                for (int j = 0; j < components.Length; j++)
                {
                    if (components[j].IndexOfAny(new[] { '*', '/' }) == 0)
                    {
                        if (components[j] == "*")
                        {
                            st1[st1.Count - 1] = ((int.Parse(st1[st1.Count - 1]) * int.Parse(components[j + 1])).ToString());
                        }
                        else
                        {
                            st1[st1.Count - 1] = ((int.Parse(st1[st1.Count - 1]) / int.Parse(components[j + 1])).ToString());
                        }
                        j++;
                    }
                    else
                    {
                        st1.Add(components[j]);
                    }
                }

                var sum = 0;
                bool shouldSum = true;
                for (int i = 0; i < st1.Count; i++)
                {
                    var item = st1.ElementAt(i);
                    if (item == "+")
                    {
                        shouldSum = true;
                    }
                    else if (item == "-")
                    {
                        shouldSum = false;
                    }
                    else
                    {
                        if (shouldSum)
                        {
                            sum += int.Parse(item);
                        }
                        else
                        {
                            sum -= int.Parse(item);
                        }
                    }
                }

                return sum;
            }

            public bool Exist(char[][] board, string word)
            {
                int i = 0, j = -1;
                bool found;
                do
                {
                    (i, j) = FindCharInGrid(board, word[0], i, j);
                    found = FindWordInGrid(board, word.Substring(1), i, j);
                } while (i > -1 && !found);
                return found;
            }

            private bool FindWordInGrid(char[][] board, string s, in int i1, in int j1)
            {
                if (i1 == -1) return false;
                var st = new Stack<(int i, int j, int stringIndex)>();
                int height = board.Length, width = board[0].Length;
                bool[][] visited = new bool[board.Length][];
                for (int i = 0; i < board.Length; i++)
                {
                    visited[i] = new bool[board[0].Length];
                }
                visited[i1][j1] = true;

                st.Push((i1, j1, 0));
                while (st.Count > 0)
                {
                    var foundChild = false;
                    var (i, j, stringIndex) = st.Pop();
                    if (stringIndex == s.Length) return true;
                    if (i + 1 < height && !visited[i + 1][j] && board[i + 1][j] == s[stringIndex])
                    {
                        st.Push((i + 1, j, stringIndex + 1));
                        visited[i + 1][j] = true;
                        foundChild = true;
                    }
                    if (i - 1 >= 0 && !visited[i - 1][j] && board[i - 1][j] == s[stringIndex])
                    {
                        st.Push((i - 1, j, stringIndex + 1));
                        visited[i - 1][j] = true;
                        foundChild = true;
                    }
                    if (j + 1 < width && !visited[i][j + 1] && board[i][j + 1] == s[stringIndex])
                    {
                        st.Push((i, j + 1, stringIndex + 1));
                        visited[i][j + 1] = true;
                        foundChild = true;
                    }
                    if (j - 1 >= 0 && !visited[i][j - 1] && board[i][j - 1] == s[stringIndex])
                    {
                        st.Push((i, j - 1, stringIndex + 1));
                        visited[i][j - 1] = true;
                        foundChild = true;
                    }
                    if (!foundChild) visited[i][j] = false;
                }
                return false;
            }

            private (int i, int j) FindCharInGrid(char[][] board, char c, int i, int j)
            {
                int height = board.Length, width = board[0].Length;

                for (int i1 = i; i1 < height; i1++)
                {
                    if (j < width) j += 1;
                    else j = 0;
                    for (int j1 = j; j1 < width; j1++)
                    {
                        if (board[i1][j1] == c) return (i1, j1);
                    }
                    j = width;
                }

                return (-1, -1);
            }

            public string DecodeString(string s)
            {
                var result = new StringBuilder();
                IEnumerable<string> operations;
                while ((operations = DecodeOperations(s).ToList()).Any())
                {
                    result.Clear();
                    foreach (var operation in operations)
                    {
                        //result.Append(ExecuteDecodeOperation(operation));
                        ExecuteOp(operation, ref result);
                    }

                    if (operations.Count() == 1 && operations.First().IndexOf('[') < 0) break;
                    s = result.ToString();
                }
                return result.ToString();
            }

            //private string ExecuteDecodeOperation(string operation)
            //{
            //    var operations = DecodeOperations(operation).ToList();
            //    if (operations.Count() > 1)
            //    {

            //    }
            //    else
            //    {
            //        var op = operations.FirstOrDefault();
            //        return ExecuteOp(op);
            //    }
            //}

            private static void ExecuteOp(string op, ref StringBuilder sb)
            {
                if (!string.IsNullOrEmpty(op))
                {
                    var numIndex = op.IndexOfAny(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                    if (numIndex >= 0)
                    {
                        var k = int.Parse(op.Substring(numIndex, op.IndexOf('[') - numIndex));
                        var repeatedStr = op.Substring(op.IndexOf('[') + 1, op.LastIndexOf(']') - op.IndexOf('[') - 1);
                        if (numIndex > 0) sb.Append(op.Substring(0, numIndex));
                        sb.AppendJoin("", Enumerable.Repeat(repeatedStr, k));
                    }
                    else
                    {
                        sb.Append(op);
                    }
                }
            }

            private IEnumerable<string> DecodeOperations(string s)
            {
                int i = 0, lastOpIndex = 0, openIndicesCount = 0;
                var isOpOpen = false;
                while (i < s.Length)
                {
                    if (!isOpOpen && (s[i] > '0' && s[i] <= '9'))
                    {
                        isOpOpen = true;
                        if (lastOpIndex < i)
                        {
                            yield return s.Substring(lastOpIndex, i - lastOpIndex);
                            lastOpIndex = i;
                        }
                    }
                    if (s[i] == '[') openIndicesCount++;
                    else if (s[i] == ']') openIndicesCount--;
                    else
                    {
                        i++;
                        continue;
                    }

                    if (openIndicesCount == 0)
                    {
                        yield return s.Substring(lastOpIndex, i - lastOpIndex + 1);
                        isOpOpen = false;
                        lastOpIndex = i + 1;
                    }
                    i++;
                }
                if (lastOpIndex < s.Length)
                    yield return s.Substring(lastOpIndex, i - lastOpIndex);
            }

            public class Node
            {
                public int val;
                public Node next;
                public Node random;

                public Node(int _val)
                {
                    val = _val;
                    next = null;
                    random = null;
                }
            }
            public Node CopyRandomList(Node head)
            {
                var dic = new Dictionary<Node, Node>();

                Node newHead = null, pointerNode = null, node = head;

                while (node != null)
                {
                    Node newNode;
                    if (dic.ContainsKey(node))
                    {
                        newNode = dic[node];
                    }
                    else
                    {
                        newNode = new Node(node.val);
                        dic.Add(node, newNode);
                    }

                    if (node.random != null)
                    {
                        if (dic.ContainsKey(node.random))
                        {
                            newNode.random = dic[node.random];
                        }
                        else
                        {
                            newNode.random = new Node(node.random.val);
                            dic.Add(node.random, newNode.random);
                        }
                    }

                    if (newHead == null) newHead = pointerNode = newNode;
                    else
                    {
                        pointerNode.next = newNode;
                        pointerNode = newNode;
                    }
                    node = node.next;
                }

                return newHead;
            }

            public Node CopyRandomListOld(Node head)
            {
                var dic = new Dictionary<Node, Node>();

                Node newHead = null, pointerNode = null, node = head;

                while (node != null)
                {
                    var newNode = new Node(node.val);
                    newNode.random = node.random;
                    if (newHead == null) newHead = pointerNode = newNode;
                    else
                    {
                        pointerNode.next = newNode;
                        pointerNode = newNode;
                    }
                    dic.Add(node, newNode);
                    node = node.next;
                }

                node = newHead;
                while (node != null)
                {
                    if (node.random != null)
                    {
                        node.random = dic[node.random];
                    }
                    node = node.next;
                }

                return newHead;
            }

            //public int NumDecodings(string s)
            //{
            //    if (string.IsNullOrEmpty(s)) return 0;
            //    var possibilities = 0;

            //    NumDecodings(s, 0, ref possibilities);

            //    return possibilities;
            //}

            //private void NumDecodings(string s, int i, ref int possibilities)
            //{
            //    if (s.IndexOf('0', i+1) < 0) possibilities++;

            //}

            public int NumDecodingsOld(string s)
            {
                if (string.IsNullOrEmpty(s) || s.All(ch => ch == '0')) return 0;
                if (s.Length < 3) return s.Length;

                int _2Factorial = 2,
                    lengthFactorial = Factorial(s.Length),
                    diffFactorial = Factorial(s.Length - _2Factorial);

                return ((lengthFactorial) / (diffFactorial * _2Factorial));
            }

            private int Factorial(int num)
            {
                int fact = 1;
                for (int i = 2; i <= num; i++)
                {
                    fact *= i;
                }
                return fact;
            }

            public int FindKthLargest(int[] nums, int k)
            {
                //Array.Sort(nums);
                //return nums[nums.Length - k];

                Heap<int> pq = new Heap<int>(k);
                for (int i = 0; i < nums.Length; i++)
                {
                    if (pq.Count < k) pq.Add(nums[i]);
                    else
                    {
                        pq.Add(nums[i]);
                        pq.Pop();
                    }
                }

                return pq.Pop();
            }

            public class TimeMap
            {
                private Dictionary<string, SortedSet<(int timestamp, string value)>> dic;
                /** Initialize your data structure here. */
                public TimeMap()
                {
                    dic = new Dictionary<string, SortedSet<(int timestamp, string value)>>();
                }

                public void Set(string key, string value, int timestamp)
                {
                    if (dic.ContainsKey(key))
                    {
                        dic[key].Add((timestamp, value));
                    }
                    else
                    {
                        var v = new SortedSet<(int timestamp, string value)>(
                            Comparer<(int timestamp, string value)>.Create((t1, t2) =>
                                t2.timestamp.CompareTo(t1.timestamp))) { (timestamp, value) };
                        dic.Add(key, v);
                    }
                }

                public string Get(string key, int timestamp)
                {
                    if (dic.ContainsKey(key))
                    {
                        var v = dic[key];
                        var lessTimestamps = v.FirstOrDefault(kv => kv.timestamp <= timestamp).value;
                        if (lessTimestamps != null) return lessTimestamps;
                        return string.Empty;
                    }

                    return string.Empty;
                }
            }

            public int BinarySearch(int[] nums, int target)
            {
                int low = 0, high = nums.Length, mid = 0;

                while (low < high)
                {
                    mid = (low + high) / 2;
                    Console.WriteLine(mid);
                    if (target == nums[mid]) return mid;
                    else if (nums[mid] < target) low = mid + 1;
                    else high = mid;
                }

                return -1;
            }

            public int Search(int[] nums, int target)
            {
                int low = 0, high = nums.Length - 1, mid = 0;

                while (low <= high)
                {
                    mid = low + (high - low) / 2;

                    if (target == nums[mid]) return mid;
                    if (nums[mid] >= nums[low])
                    {
                        if (target >= nums[low] && target < nums[mid]) high = mid - 1;
                        else low = mid + 1;
                    }
                    else
                    {
                        if (target < nums[high] && target > nums[mid]) low = mid + 1;
                        else high = mid - 1;
                    }
                }

                return -1;
            }

            public int SearchNotWorking(int[] nums, int target)
            {
                int minIndex = 0, maxLength = nums.Length + 1;
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < nums[minIndex]) minIndex = i;
                }

                int low = minIndex, high = (nums.Length + minIndex) % maxLength, mid = 0;

                while (Math.Abs(low - minIndex) < Math.Abs(high - minIndex))
                {
                    mid = ((high - low) / 2 + minIndex);
                    //mid = (((Math.Abs((low + minIndex) % nums.Length) + ((high + minIndex) % nums.Length)) / 2) + minIndex) % nums.Length;
                    if (target == nums[mid]) return mid;
                    else if (nums[mid] < target) low = (mid + 1) % nums.Length;
                    else high = mid;
                }

                return -1;
            }

            public System.Collections.Generic.IList<int> RightSideView(TreeNode root)
            {
                var results = new List<int>();
                if (root == null) return results;
                var q = new Queue<(int level, TreeNode node)>();
                q.Enqueue((1, root));

                int level = 1;
                while (q.TryDequeue(out var pair))
                {
                    if (results.Count < pair.level)
                        results.Add(pair.node.val);
                    if (pair.node.right != null) q.Enqueue((pair.level + 1, pair.node.right));
                    if (pair.node.left != null) q.Enqueue((pair.level + 1, pair.node.left));
                }

                return results;
            }

            public IList<int> LevelOrderView(TreeNode root)
            {
                var results = new List<int>();
                if (root == null) return results;
                var q = new Queue<TreeNode>();
                q.Enqueue(root);

                while (q.TryDequeue(out var node))
                {
                    results.Add(node.val);
                    if (node.right != null) q.Enqueue(node.right);
                    if (node.left != null) q.Enqueue(node.left);
                }

                return results;
            }

            private Dictionary<char, List<char>> digitsToCharDic = new Dictionary<char, List<char>>
            {
                {'2', new List<char> {'a', 'b', 'c'}},
                {'3', new List<char> {'d', 'e', 'f'}},
                {'4', new List<char> {'g', 'h', 'i'}},
                {'5', new List<char> {'j', 'k', 'l'}},
                {'6', new List<char> {'m', 'n', 'o'}},
                {'7', new List<char> {'p', 'q', 'r', 's'}},
                {'8', new List<char> {'t', 'u', 'v'}},
                {'9', new List<char> {'w', 'x', 'y', 'z'}}
            };

            public System.Collections.Generic.IList<string> LetterCombinations(string digits)
            {
                var results = new List<string>();
                if (string.IsNullOrEmpty(digits)) return results;
                PrintCombination(digits, "", 0, ref results);
                return results;
            }

            private void PrintCombination(string digits, string empty, int i, ref List<string> results)
            {
                if (i == digits.Length)
                {
                    results.Add(empty);
                    return;
                }

                var letters = digitsToCharDic[digits[i]];
                foreach (var letter in letters)
                {
                    PrintCombination(digits, empty + letter, i + 1, ref results);
                }
            }

            public List<int> PartitionLabels(string S)
            {
                int[] last = new int[26];
                for (int i = 0; i < S.Length; ++i)
                    last[S[i] - 'a'] = i;

                int j = 0, anchor = 0;
                List<int> ans = new List<int>();
                for (int i = 0; i < S.Length; ++i)
                {
                    j = Math.Max(j, last[S[i] - 'a']);
                    if (i == j)
                    {
                        ans.Add(i - anchor + 1);
                        anchor = i + 1;
                    }
                }
                return ans;
            }

            public System.Collections.Generic.IList<int> PartitionLabelsOld(string S)
            {
                var rev = new string(S.Reverse().ToArray());
                int[] arr1 = new int[26], arr2 = new int[26];
                var result = new List<int>();

                for (int i = 0; i < 26; i++)
                {
                    arr1[i] = S.Length;
                    arr2[i] = S.Length;
                }

                for (int i = 0; i < S.Length; i++)
                {
                    arr1[S[i] - 'a'] = Math.Min(arr1[S[i] - 'a'], i);
                    arr2[S[i] - 'a'] = LastIndexOf(rev, S[i]);
                }

                //for (int i = 0; i < arr1.Length; i++)
                //{
                //    Console.WriteLine($"{(char)('a' + i)}: {arr1[i]} - {arr2[i]}");
                //}

                int min = -1, max = -1, regionsCount = 0;
                for (int i = 0; i < S.Length; i++)
                {
                    if (arr1[S[i] - 'a'] <= max)
                    {
                        (min, max) = (Math.Min(min, arr1[S[i] - 'a']), Math.Max(max, arr2[S[i] - 'a']));
                    }
                    else
                    {
                        if (regionsCount > 0) result.Add(max - min + 1);
                        regionsCount++;
                        (min, max) = (arr1[S[i] - 'a'], arr2[S[i] - 'a']);
                    }
                }
                result.Add(max - min + 1);

                //Console.WriteLine(regionsCount);

                return result;
            }

            public int LastIndexOf(string reversedStr, char ch)
            {
                return reversedStr.Length - reversedStr.IndexOf(ch) - 1;
            }

            public int CoinChange(int[] coins, int amount)
            {
                int max = amount + 1;
                int[] dp = new int[amount + 1];
                for (int i = 0; i < dp.Length; i++)
                {
                    dp[i] = max;
                }
                dp[0] = 0;
                Array.Sort(coins);
                for (int i = 1; i <= amount; i++)
                {
                    for (int j = 0; j < coins.Length; j++)
                    {
                        if (coins[j] <= i)
                        {
                            dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                        }
                        else break;
                    }
                }
                return dp[amount] > amount ? -1 : dp[amount];
            }

            public int CoinChangeOld(int[] coins, int amount)
            {
                if (amount == 0) return 0;
                Array.Sort(coins, new Comparison<int>((i, j) => j.CompareTo(i)));

                int min = int.MaxValue, index = 0;
                int res;
                do
                {
                    res = FindCoin(coins, amount, index++, ref min);

                } while (res == -1 && index < coins.Length);

                return res;
            }

            private int FindCoin(int[] coins, in int amount, int index, ref int min)
            {
                if (index >= coins.Length) return -1;

                if (coins[index] > amount)
                {
                    return FindCoin(coins, amount, ++index, ref min);
                }
                var reminder = amount % coins[index];
                var div = amount / coins[index];
                if (reminder == 0) return div;

                var pos1 = FindCoin(coins, reminder, ++index, ref min);
                var pos2 = FindCoin(coins, amount - coins[index - 1], index, ref min);
                if (pos1 != -1 && pos2 != -1) return div + Math.Min(pos1, pos2);
                else if (pos1 != -1) return div + pos1;
                else if (pos2 != -1) return div + pos2;
                else return -1;
            }

            public System.Collections.Generic.IList<System.Collections.Generic.IList<string>> GroupAnagrams(string[] strs)
            {
                var dic = new Dictionary<string, List<string>>();
                for (int i = 0; i < strs.Length; i++)
                {
                    var key = string.Concat(strs[i].OrderBy(c => c));
                    if (dic.ContainsKey(key))
                    {
                        dic[key].Add(strs[i]);
                    }
                    else dic.Add(key, new List<string> { strs[i] });
                }

                var result = new List<System.Collections.Generic.IList<string>>();
                foreach (var kv in dic)
                {
                    result.Add(kv.Value);
                }

                return result;
            }

            public string AddBinary(string a, string b)
            {
                int a1 = System.Convert.ToInt32(a, 2), b1 = System.Convert.ToInt32(b, 2);
                var result = SumBitwise(a1, b1);
                return System.Convert.ToString(result, 2);
            }

            public string AddBinaryOld(string a, string b)
            {
                int i = a.Length - 1, j = b.Length - 1;
                int sum = 0, carry = 0;
                StringBuilder result = new StringBuilder(Math.Max(b.Length, a.Length) + 1);
                while (i >= 0 || j >= 0)
                {
                    sum = ((i >= 0 ? (a[i--] - '0') : 0) + (j >= 0 ? (b[j--] - '0') : 0) + carry);
                    carry = sum / 2;
                    sum = sum % 2;
                    result.Append(sum);
                }

                if (carry > 0) result.Append(carry);
                return new string(result.ToString().Reverse().ToArray());
            }

            public void MoveZeroes(int[] nums)
            {
                int lastZeroIndex = 0, temp;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        if (i == lastZeroIndex)
                        {
                            lastZeroIndex++;
                        }
                        else
                        {
                            temp = nums[lastZeroIndex];
                            nums[lastZeroIndex++] = nums[i];
                            nums[i] = temp;
                        }
                    }
                }
            }

            int maxDiameter = 1;
            public int DiameterOfBinaryTree(TreeNode root)
            {
                BranchHeight(root);
                return maxDiameter;
            }

            private int BranchHeight(TreeNode node)
            {
                if (node == null) return 0;
                var leftHeight = BranchHeight(node.left);
                var rightHeight = BranchHeight(node.right);
                node.val = Math.Max(leftHeight, rightHeight) + 1;
                maxDiameter = Math.Max(maxDiameter, leftHeight + rightHeight);
                return node.val;
            }

            public int DiameterOfBinaryTreeOld(TreeNode root)
            {
                BranchHeight(root);
                var max = 0;
                var node = root;
                while (node != null)
                {
                    max = Math.Max(max, (node.left?.val ?? 0) + (node.right?.val ?? 0));
                    if (node.left != null)
                    {
                        if (node.right != null && node.right.val > node.left.val) node = node.right;
                        else node = node.left;
                    }
                    else if (node.right != null)
                    {
                        if (node.left != null && node.left.val > node.right.val) node = node.left;
                        else node = node.right;
                    }
                    else node = null;
                }

                return max;
            }

            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                int i = m - 1, j = n - 1, k = m + n - 1;
                while (j >= 0 || i >= 0)
                {
                    if ((i < 0 ? int.MinValue : nums1[i]) > (j < 0 ? int.MinValue : nums2[j]))
                        nums1[k--] = nums1[i--];
                    else nums1[k--] = nums2[j--];
                }
            }

            public void MergeOld(int[] nums1, int m, int[] nums2, int n)
            {
                int[] result = new int[m + n];
                int i = 0, j = 0, k = 0;
                while (j < n || i < m)
                {
                    if ((i >= m ? int.MaxValue : nums1[i]) < (j >= n ? int.MaxValue : nums2[j]))
                        result[k++] = nums1[i++];
                    else result[k++] = nums2[j++];
                }

                for (int l = 0; l < m + n; l++)
                {
                    nums1[l] = result[l];
                }
            }

            public int ThreeSumClosest(int[] nums, int target)
            {
                if (nums.Length <= 2) return 0;
                Array.Sort(nums);

                int result = int.MaxValue / 10;
                int i = 0, low = 0, high = nums.Length - 1;
                while (i < nums.Length)
                {
                    low = i + 1;
                    high = nums.Length - 1;
                    while (low < high)
                    {
                        var sum = (nums[low] + nums[high] + nums[i]);
                        int margin = target - sum;
                        if (margin == 0) return sum;

                        result = Math.Abs(result) < Math.Abs(sum) ? result : sum;
                        if (margin > 0) low++;
                        else high--;
                    }
                    i++;
                }

                return result;
            }

            public IList<IList<int>> ThreeSum(int[] nums)
            {
                if (nums.Length <= 2) return new List<IList<int>>();
                Array.Sort(nums);

                var result = new List<IList<int>>();
                int i = 0, low = 0, high = nums.Length - 1;
                while (i < nums.Length)
                {
                    if (i > 0 && nums[i] == nums[i - 1])
                    {
                        i++;
                        continue;
                    }

                    low = i + 1;
                    high = nums.Length - 1;
                    while (low < high)
                    {
                        if (low - 1 > i && nums[low] == nums[low - 1])
                        {
                            low++;
                            continue;
                        }

                        if (high < nums.Length - 1 && nums[high] == nums[high + 1])
                        {
                            high--;
                            continue;
                        }
                        int sum = (nums[low] + nums[high]), target = -1 * nums[i];
                        if (sum == target)
                        {
                            result.Add(new List<int> { nums[i], nums[low], nums[high] });
                            low++;
                            high--;
                        }
                        else
                        {
                            if (sum < target) low++;
                            else high--;
                        }
                    }

                    i++;
                }

                return result;
            }

            public int[] TwoSum(int[] numbers, int target)
            {
                int low = 0, high = numbers.Length - 1;
                var mid = (low + high) / 2;
                while (low < high)
                {
                    mid = (low + high) / 2;
                    if (numbers[mid] <= target && (mid + 1 >= numbers.Length || numbers[mid + 1] > target)) break;
                    if (numbers[mid] < target)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid;
                    }
                }

                var dic = new Dictionary<int, int>();
                for (int i = 0; i <= mid + 1 && i < numbers.Length; i++)
                {
                    if (dic.ContainsKey(target - numbers[i]))
                        return new[] { dic[target - numbers[i]] + 1, i + 1 };
                    if (!dic.ContainsKey(numbers[i])) dic.Add(numbers[i], i);
                }

                return new int[0];
            }

            public System.Collections.Generic.IList<System.Collections.Generic.IList<int>> ThreeSumOld(int[] nums)
            {
                if (nums.Length <= 2) return new List<System.Collections.Generic.IList<int>>();

                int minNumber = nums.Min(), maxNumber = nums.Max();
                Array.Sort(nums);
                var existence = new int[maxNumber - minNumber + 1];

                foreach (var i in nums)
                    existence[i - minNumber]++;

                var result = new HashSet<(int i, int j, int k)>();
                for (var i1 = 0; i1 < nums.Length; i1++)
                {
                    int i = nums[i1];
                    for (var j1 = nums.Length - 1; j1 > i1; j1--)
                    {
                        int j = nums[j1];
                        var missingValue = 0 - (i + j);
                        existence[i - minNumber]--;
                        existence[j - minNumber]--;
                        (int low, int mid, int high) = (i < missingValue ? i : missingValue,
                            i < missingValue ? (missingValue < j ? missingValue : j) : i,
                            j < missingValue ? missingValue : j);
                        if (missingValue >= minNumber && missingValue <= maxNumber && existence[missingValue - minNumber] > 0
                        && !result.Contains((low, mid, high)))
                        {
                            result.Add((low, mid, high));
                        }
                        existence[i - minNumber]++;
                        existence[j - minNumber]++;
                    }
                }

                var res = new List<System.Collections.Generic.IList<int>>();
                foreach (var kv in result)
                {
                    res.Add(new List<int> { kv.i, kv.j, kv.k });
                }
                return res;
            }

            public bool WordBreak2(string s, System.Collections.Generic.IList<string> wordDict)
            {
                var dic = new Dictionary<int, int>();
                var st = new Stack<int>();
                foreach (var word in wordDict)
                {
                    int index = -1;
                    while ((index = s.IndexOf(word, index + 1)) >= 0)
                    {
                        if (dic.ContainsKey(index))
                        {
                            dic[index] = Math.Max(dic[index], word.Length + index);
                        }
                        else dic.Add(index, word.Length + index);
                        if (index == 0) st.Push(word.Length + index);
                    }
                }

                // (0,3), (0,7)
                // (3,5), (3,8)
                while (st.Count > 0)
                {
                    var occurrence = st.Pop();
                    if (occurrence == s.Length) return true;
                    if (dic.ContainsKey(occurrence))
                    {
                        st.Push(dic[occurrence]);
                    }
                }

                return false;
            }

            public int MaxArea(int[] height)
            {
                int max = 0;
                for (int i = 0, j = height.Length - 1; i < height.Length - 1 && j > 0 && i < j;)
                {
                    var min = Math.Min(height[i], height[j]);
                    max = Math.Max(max, min * (j - i));

                    if (height[i] < height[j]) i++;
                    else j--;
                }
                //for (int i = 0; i < height.Length; i++)
                //{
                //    for (int j = i + 1; j < height.Length; j++)
                //    {
                //        var min = Math.Min(height[i], height[j]);
                //        max = Math.Max(max, min * (j - i));
                //    }
                //}
                return max;
            }

            public int Reverse(int x)
            {
                var result = 0;
                while (x != 0)
                {
                    var mod = x % 10;
                    x = x / 10;
                    if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && mod > 7)) return 0;
                    if (result < Int32.MinValue / 10 || (result == Int32.MinValue / 10 && mod > 7)) return 0;
                    result = result * 10 + mod;
                }
                return result;
            }

            public int ReverseOld(int x)
            {
                var sign = x < 0 ? -1 : 1;
                try
                {
                    return int.Parse((x * sign).ToString().Reverse().ToArray()) * sign;
                }
                catch (Exception e)
                {
                    return 0;
                }
            }

            // (a(v))(
            public string MinRemoveToMakeValid(string s)
            {
                var sb = MinRemoveToMakeValidCheck(s, '(', ')');
                sb = MinRemoveToMakeValidCheck(new string(sb.ToString().Reverse().ToArray()), ')', '(');
                return new string(sb.ToString().Reverse().ToArray());
            }

            public StringBuilder MinRemoveToMakeValidCheck(string s, char open, char close)
            {
                var openCount = 0;
                var sb = new StringBuilder(s.Length);
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == open)
                    {
                        openCount++;
                    }
                    else if (s[i] == close)
                    {
                        if (openCount == 0) continue;
                        openCount--;
                    }
                    sb.Append(s[i]);
                }

                return sb;
            }

            public string MinRemoveToMakeValidBetter(string s)
            {
                var sb = new StringBuilder(s.Length);
                var st = new Stack<int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        sb.Append(s[i]);
                        st.Push(sb.Length - 1);
                    }
                    else if (s[i] == ')')
                    {
                        if (st.Count > 0)
                        {
                            st.Pop();
                            sb.Append(s[i]);
                        }
                    }
                    else sb.Append(s[i]);
                }

                while (st.Count > 0)
                {
                    sb.Remove(st.Pop(), 1);
                }
                return sb.ToString();
            }

            private void InsertOrAppend(StringBuilder sb, char ch, in int index)
            {
                if (index <= sb.Length) sb.Append(ch);
                else sb.Insert(ch, index);
            }

            public int SubarraySum3(int[] nums, int k)
            {
                if (nums.Length < 1) return nums.Length;
                else if (nums.Length == 1) return nums[0] == k ? 1 : 0;
                int count = 0, sum = 0;
                int[] sums = new int[nums.Length + 1];
                for (int i = 1; i < sums.Length; i++)
                {
                    sum += nums[i - 1];
                    sums[i] += sum;
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < sums.Length; j++)
                    {
                        if (sums[j] - sums[i] == k) count++;
                    }
                }
                return count;
            }

            public int SubarraySum2(int[] nums, int k)
            {
                if (nums.Length < 1) return nums.Length;
                else if (nums.Length == 1) return nums[0] == k ? 1 : 0;
                int sum = 0, count = 0, i;
                int[] sums = new int[nums.Length];
                for (i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    sums[i] += sum;
                    if (nums[i] == k) count++;
                    if (i > 0 && sums[i] == k) count++;
                }

                int subArraySize = 2;
                while (subArraySize < nums.Length)
                {
                    var subArraySum = sums[subArraySize - 1];
                    for (int j = 1; j <= nums.Length - subArraySize; j++)
                    {
                        subArraySum = subArraySum + nums[subArraySize + j - 1] - nums[j - 1];
                        if (subArraySum == k) count++;
                    }
                    subArraySize++;
                }

                return count;
            }

            public int SubarraySum(int[] nums, int k)
            {
                int sum = 0, count = 0;

                GetSubArrays(nums, 0, nums.Length, ref k, ref sum, ref count);

                return count;
            }

            private void GetSubArrays(int[] nums, int i, int j, ref int k, ref int sum, ref int count)
            {
                if (i == j) return;
                sum += nums[i];
                if (sum == k) count++;
                GetSubArrays(nums, i + 1, j, ref k, ref sum, ref count);
            }

            public int SubarraySumIterative(int[] nums, int k)
            {
                int sum = 0, count = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    for (int i = 1; i <= nums.Length - k; i++)
                    {
                        sum += nums[k + i];
                        sum -= nums[i - 1];
                        if (sum == k) count++;
                    }
                }

                return count;
            }

            public int SumBitwise(int x, int y)
            {
                int carry, xor;
                do
                {
                    xor = x ^ y;
                    carry = (x & y) << 1;
                    x = xor;
                    y = carry;
                } while (carry != 0);

                return xor;
            }

            public System.Collections.Generic.IList<string> TopKFrequent(string[] words, int k)
            {
                return TopKFrequentIterator(words, k).ToList();
            }
            public IEnumerable<string> TopKFrequentIterator(string[] words, int k)
            {

                var dic = new Dictionary<string, int>();
                foreach (var word in words)
                {
                    if (!dic.ContainsKey(word)) dic.Add(word, 1);
                    else
                    {
                        dic[word]++;
                    }
                }

                return dic.OrderByDescending(kv => kv, Comparer<System.Collections.Generic.KeyValuePair<string, int>>.Create(
                        (kv1, kv2) =>
                        {
                            if (kv1.Value == kv2.Value)
                                return kv1.Key.CompareTo(kv2.Key) * -1;
                            return kv1.Value.CompareTo(kv2.Value);
                        }))
                    .Take(k)
                    .Select(kv => kv.Key)
                    .ToList();

                //var ss = new SortedSet<(string, int)>(Comparer<(string s, int count)>.Create(
                //    (kv1, kv2) =>
                //    {
                //        if (kv1.count == kv2.count)
                //            return kv1.s.CompareTo(kv2.s) * -1;
                //        else return kv1.count.CompareTo(kv2.count) * -1;
                //    }));

                //foreach (var kv in dic)
                //{
                //    ss.Add((kv.Key, kv.Value));
                //}

                //while (k > 0)
                //{
                //    var max = ss.Min();
                //    yield return max.Item1;
                //    ss.Remove(max);
                //    k--;
                //}
            }

            public int[][] KClosest(int[][] points, int K)
            {
                return points.OrderBy(kv => kv,
                    Comparer<int[]>.Create(new Comparison<int[]>((kv1, kv2) =>
                        GetEuclideanDistanc(kv1).CompareTo(GetEuclideanDistanc(kv2)))))
                    .Take(K).ToArray();
            }

            private double GetEuclideanDistanc(int[] kv1)
            {
                return Math.Sqrt((kv1[0] * kv1[0]) + (kv1[1] * kv1[1]));
            }

            public bool CheckInclusion(string s1, string s2)
            {
                if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return false;
                if (s1.Length > s2.Length) return false;
                byte[] hashS1 = new byte[26], hashS2 = new byte[26];

                // Find hash for s1 & s2[s1 length]
                for (int i = 0; i < s1.Length; i++)
                {
                    hashS1[s1[i] - 'a']++;
                    hashS2[s2[i] - 'a']++;
                }

                for (int i = 0; i < s2.Length - s1.Length; i++)
                {
                    if (IsEqual(hashS1, hashS2))
                    {
                        return true;
                    }

                    hashS2[s2[i] - 'a']--;
                    hashS2[s2[s1.Length + i] - 'a']++;
                }

                return IsEqual(hashS1, hashS2);
            }

            private bool IsEqual(byte[] hashS1, byte[] hashS2)
            {
                for (int i = 0; i < hashS1.Length; i++)
                {
                    if (hashS1[i] != hashS2[i]) return false;
                }
                return true;
            }

            public bool CheckInclusionSlow(string s1, string s2)
            {
                var perms = FindPermutations(s1);
                foreach (var perm in perms)
                {
                    if (s2.Contains(perm)) return true;
                }

                return false;
            }

            public List<string> FindPermutations(string s)
            {
                var lst = new List<string>();
                FindPerms(s.ToCharArray(), lst, 0, s.Length - 1);
                return lst;
            }

            private void FindPerms(char[] s, List<string> lst, int l, int r)
            {
                var str = new string(s);
                if (l >= r)
                {
                    lst.Add(new string(s));
                    return;
                }

                for (int i = l; i <= r; i++)
                {
                    Swap(ref s, i, l);
                    str = new string(s);
                    FindPerms(s, lst, l + 1, r);
                    Swap(ref s, i, l);
                    str = new string(s);
                }
            }

            private void Swap(ref char[] s, in int i, in int j)
            {
                var temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }

        public class RandomizedSet
        {
            private readonly System.Collections.Generic.HashSet<int> _hs;
            private readonly Random _rnd;

            /** Initialize your data structure here. */
            public RandomizedSet()
            {
                _rnd = new Random();
                _hs = new System.Collections.Generic.HashSet<int>();
            }

            /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
            public bool Insert(int val)
            {
                if (_hs.Contains(val)) return false;
                return _hs.Add(val);
            }

            /** Removes a value from the set. Returns true if the set contained the specified element. */
            public bool Remove(int val)
            {
                return _hs.Remove(val);
            }

            /** Get a random element from the set. */
            public int GetRandom()
            {
                int index = _rnd.Next(0, _hs.Count);
                return _hs.ElementAt(index);
            }
        }

        public static bool ValidPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int i = 0, j = s.Length - 1;
            return ValidPalindrome(s, i, j, true);
        }

        public static bool ValidPalindrome(string s, int i, int j, bool canRemove)
        {
            if (i >= j) return true;
            if (s[i] == s[j])
            {
                i++;
                j--;
                return ValidPalindrome(s, i, j, canRemove);
            }
            else if (canRemove)
            {
                bool result = false;
                if (i + 1 <= j)
                    result = ValidPalindrome(s, i + 1, j, false);
                if (j - 1 >= i)
                    result = result || ValidPalindrome(s, i, j - 1, false);
                return result;
            }
            return false;
        }

        public static bool ValidPalindromeIterative(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int i = 0, j = s.Length - 1;
            bool removedChar = false;
            while (i < j)
            {
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else if (!removedChar)
                {
                    removedChar = true;
                    if (s[i + 1] == s[j])
                    {
                        i++;
                        continue;
                    }
                    else if (s[i] == s[j - 1])
                    {
                        j--;
                        continue;
                    }
                    else return false;
                }
                else return false;
            }

            return true;
        }

        public static string AddStringsBetter(string num1, string num2)
        {
            var sb = new StringBuilder();
            int carry = 0;
            for (int i = num1.Length - 1, j = num2.Length - 1; i >= 0 || j >= 0; i--, j--)
            {
                var sum = (i >= 0 ? (byte)num1[i] - 48 : 0) + (j >= 0 ? (byte)num2[j] - 48 : 0) + carry;
                carry = sum / 10;
                sb.Append(sum % 10);
            }

            if (carry > 0) sb.Append(carry);
            return string.Join("", sb.ToString().Reverse());
        }

        public static string AddStrings(string num1, string num2)
        {
            var sb = new StringBuilder();
            num2 = string.Join("", num2.Reverse());
            num1 = string.Join("", num1.Reverse());
            int carry = 0;
            var maxLength = Math.Max(num1.Length, num2.Length);
            for (int i = 0; i < maxLength; i++)
            {
                var sum = (i < num1.Length ? (byte)num1[i] - 48 : 0) + (i < num2.Length ? (byte)num2[i] - 48 : 0) + carry;
                carry = sum / 10;
                sb.Append(sum % 10);
            }

            if (carry > 0) sb.Append(carry);
            return string.Join("", sb.ToString().Reverse());
        }

        public static System.Collections.Generic.IList<string> GenerateParenthesis(int n)
        {
            var lst = new List<string>();
            //GenerateParenthes("", n, n*2, 0, ref lst);
            GenerateParenthesElegant("", n, 0, 0, ref lst);
            return lst;
        }

        public static void GenerateParenthesElegant(string s, int n, int open, int close, ref List<string> results)
        {
            if (s.Length == 2 * n)
            {
                results.Add(s);
                return;
            }

            if (open < n)
            {
                GenerateParenthesElegant(s + '(', n, open + 1, close, ref results);
            }

            if (close < open)
            {
                GenerateParenthesElegant(s + ')', n, open, close + 1, ref results);
            }
        }

        public static void GenerateParenthes(string s, int n, int maxLength, int allowedCloseCount, ref List<string> results)
        {
            if (n == 0)
            {
                for (int i = s.Length; i < maxLength; i++)
                {
                    s += ')';
                }
                results.Add(s);
                return;
            }
            if (s.Length != 0 && allowedCloseCount > 0)
            {
                GenerateParenthes(s + ')', n, maxLength, allowedCloseCount - 1, ref results);
            }

            GenerateParenthes(s + '(', n - 1, maxLength, allowedCloseCount + 1, ref results);
        }

        public static int[][] MergeON(int[][] intervals)
        {
            var ls = new System.Collections.Generic.LinkedList<(int i, int j)>();
            Array.Sort(intervals,
                Comparer<int[]>.Create(new Comparison<int[]>((arr1, arr2) => arr1[0].CompareTo(arr2[0]))));

            foreach (var interval in intervals)
            {
                var lastItem = ls.Last;
                if (lastItem == null || lastItem.Value.j < interval[0]) ls.AddLast((interval[0], interval[1]));
                else lastItem.Value = (lastItem.Value.i, Math.Max(lastItem.Value.j, interval[1]));
            }

            return ls.Select(node => new int[] { node.i, node.j }).ToArray();
        }

        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0) return new int[0][];

            Array.Sort(intervals,
                Comparer<int[]>.Create(new Comparison<int[]>((arr1, arr2) => arr1[0].CompareTo(arr2[0]))));
            var result = new System.Collections.Generic.HashSet<(int i, int j)>();
            var hs = new List<(int i, int j)>();
            foreach (var interval in intervals)
            {
                hs.Add((interval[0], interval[1]));
            }

            while (hs.Count > 0)
            {
                var elem = hs.ElementAt(0);
                hs.Remove(elem);
                for (int i = 0; i < hs.Count; i++)
                {
                    var pair = hs.ElementAt(i);
                    if (elem.j >= pair.i && elem.i <= pair.j)
                    {
                        elem.i = Math.Min(pair.i, elem.i);
                        elem.j = Math.Max(pair.j, elem.j);
                        hs.Remove(pair);
                        i--;
                    }
                }

                //if(hs.Count > 0) hs.Add((elem.i, elem.j));
                if (!result.Contains((elem.i, elem.j)))
                {
                    result.Add((elem.i, elem.j));
                }
            }

            return result.Select(kv => new int[] { kv.i, kv.j }).ToArray();
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] l = new int[nums.Length], r = new int[nums.Length];
            int[] result = new int[nums.Length];

            l[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                l[i] = nums[i - 1] * l[i - 1];
            }

            r[nums.Length - 1] = 1;
            for (int j = nums.Length - 2; j >= 0; j--)
            {
                r[j] = r[j + 1] * nums[j + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = l[i] * r[i];
            }

            return result;
        }

        public static int OrangesRotting(int[][] grid)
        {
            var maxDays = 0;
            var q = new Queue<(int i, int j, int depth)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        q.Enqueue((i, j, 0));
                    }
                }
            }

            TraverseBFS(grid, ref maxDays, q);

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1) return -1;
                }
            }

            return maxDays;
        }

        private static void TraverseBFS(int[][] grid, ref int maxDays, Queue<(int i, int j, int depth)> q)
        {
            int height = grid.Length, width = grid[0].Length, lastDepth = 0;
            while (q.Count > 0)
            {
                (int i1, int j1, int depth) = q.Dequeue();
                grid[i1][j1] = 3;
                if (i1 + 1 < height && grid[i1 + 1][j1] == 1)
                {
                    q.Enqueue((i1 + 1, j1, depth + 1));
                    grid[i1 + 1][j1] = 2;
                }

                if (i1 - 1 >= 0 && grid[i1 - 1][j1] == 1)
                {
                    q.Enqueue((i1 - 1, j1, depth + 1));
                    grid[i1 - 1][j1] = 2;
                }

                if (j1 + 1 < width && grid[i1][j1 + 1] == 1)
                {
                    q.Enqueue((i1, j1 + 1, depth + 1));
                    grid[i1][j1 + 1] = 2;
                }

                if (j1 - 1 >= 0 && grid[i1][j1 - 1] == 1)
                {
                    q.Enqueue((i1, j1 - 1, depth + 1));
                    grid[i1][j1 - 1] = 2;
                }
                lastDepth = depth;
            }

            maxDays = Math.Max(maxDays, lastDepth);
        }


        public static int LengthOfLongestSubstringON(string s)
        {
            int n = s.Length, ans = 0;
            var map = new Dictionary<char, int>(); // current index of character
            // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                if (map.ContainsKey(s[j]))
                {
                    i = Math.Max(map[s[j]], i);
                }
                ans = Math.Max(ans, j - i + 1);
                if (map.ContainsKey(s[j]))
                    map[s[j]] = j + 1;
                else map.Add(s[j], j + 1);
            }
            return ans;
        }

        public static int LengthOfLongestSubstringO2N(string s)
        {
            int n = s.Length;
            var set = new System.Collections.Generic.HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            if (s.Length == 1) return 1;

            int count = 0, max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    var hs = new System.Collections.Generic.HashSet<char>();
                    for (int k = i; k <= j; k++)
                    {
                        if (!hs.Contains(s[k]))
                        {
                            count++;
                            hs.Add(s[k]);
                        }
                        else break;
                    }
                    max = Math.Max(max, count);
                    count = 0;
                }
            }

            return max;
        }

        public static string LongestPalindromeOld(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            var lst = new List<(int i, int j)>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (ISPalindrome(s, i, j))
                    {
                        lst.Add((i, j));
                    }
                }
            }

            var longestKV = lst.OrderByDescending(kv => kv.j - kv.i).FirstOrDefault();
            return lst.Any() ? s.Substring(longestKV.i, longestKV.j - longestKV.i + 1) : s[0].ToString();
        }

        private static bool ISPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i++] != s[j--]) return false;
            }

            return true;
        }

        public class LRUCache
        {
            private readonly int _capacity;
            private Dictionary<int, int> dic;
            private Dictionary<int, int> priorityDic;
            private int lastPriority = 1;
            public LRUCache(int capacity)
            {
                _capacity = capacity;
                dic = new Dictionary<int, int>();
                priorityDic = new Dictionary<int, int>();
            }

            public int Get(int key)
            {
                if (dic.ContainsKey(key))
                {
                    priorityDic[key] = lastPriority++;
                    return dic[key];
                }
                return -1;
            }

            public void Put(int key, int value)
            {
                if (!dic.ContainsKey(key))
                {
                    if (dic.Count == _capacity)
                    {
                        var deletedKey = priorityDic.OrderBy(kv => kv.Value).First().Key;
                        dic.Remove(deletedKey);
                        priorityDic.Remove(deletedKey);
                    }
                    dic.Add(key, value);
                }
                else dic[key] = value;
                priorityDic[key] = lastPriority++;
            }
        }

        /**
         * Your LRUCache object will be instantiated and called as such:
         * LRUCache obj = new LRUCache(capacity);
         * int param_1 = obj.Get(key);
         * obj.Put(key,value);
         */

        public static bool IsAlienSorted(string[] words, string order)
        {
            var comparer = Comparer<string>.Create(new Comparison<string>((s1, s2) => { return 0; }));

            var orderLookup = order.Select((c, i) => new Tuple<char, int>(c, i))
                .ToDictionary((c) => c.Item1, (c) => c.Item2);
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (!IsSorted(words[i], words[i + 1], orderLookup)) return false;
            }

            return true;
        }

        private static bool IsSorted(string word1, string word2, Dictionary<char, int> orderLookup)
        {
            var minLength = Math.Min(word1.Length, word2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (orderLookup[word1[i]] < orderLookup[word2[i]]) return true;
                else if (orderLookup[word1[i]] > orderLookup[word2[i]]) return false;
            }
            return word1.Length <= word2.Length;
        }

        public ListNode ReverseList(ListNode head)
        {
            //Input: 1->2->3->4->5->NULL
            //Output: 5->4->3->2->1->NULL

            ListNode node = head, parent = null;
            while (node != null)
            {
                var temp = node.next;
                node.next = parent;
                parent = node;
                node = temp;
            }

            return parent;
        }

        public static int MaxProfitON(int[] prices)
        {
            // min = 2, maxP = 0
            // min = 2, maxP = 3
            // min = 2, maxP = 1
            // min = 2, maxP = 4
            // min = 1, maxP = 0
            // min = 1, maxP = 3
            var lst = new List<int>();
            var min = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > min) lst.Add(prices[i] - min);
                else min = prices[i];
            }

            return lst.DefaultIfEmpty().Max();
        }

        public static int MaxProfit(int[] prices)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] > prices[i])
                    {
                        dic[prices[i]] = dic.ContainsKey(prices[i]) ? Math.Max(dic[prices[i]], prices[j]) : prices[j];
                    }
                }
            }

            return dic.Select(kv => kv.Value - kv.Key).DefaultIfEmpty().Max();
        }


        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode newLinkedList = null, lastNode = null;

            while (l1 != null && l2 != null)
            {
                int newNodeVal;
                if (l1.val <= l2.val)
                {
                    newNodeVal = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    newNodeVal = l2.val;
                    l2 = l2.next;
                }

                AddNodeToNewLinkedList(ref newLinkedList, ref lastNode, newNodeVal);
            }

            while (l1 != null)
            {
                AddNodeToNewLinkedList(ref newLinkedList, ref lastNode, l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                AddNodeToNewLinkedList(ref newLinkedList, ref lastNode, l2.val);
                l2 = l2.next;
            }

            return newLinkedList;
        }

        private void AddNodeToNewLinkedList(ref ListNode newLinkedList, ref ListNode lastNode, int newNodeVal)
        {
            var newNode = new ListNode(newNodeVal);
            if (newLinkedList == null) newLinkedList = lastNode = newNode;
            else
            {
                lastNode.next = newNode;
                lastNode = newNode;
            }
        }

        public static bool IsValid(string s)
        {
            var dic = new Dictionary<char, char>
            {
                {'{', '}'},
                {'[', ']'},
                {'(', ')'},
            };

            var st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.Keys.Contains(s[i]))
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

        public static int MaxSubArrayON(int[] nums)
        {
            int n = nums.Length;
            int currSum = nums[0], maxSum = nums[0];

            for (int i = 1; i < n; ++i)
            {
                currSum = Math.Max(nums[i], currSum + nums[i]);
                maxSum = Math.Max(maxSum, currSum);
            }
            return maxSum;
        }

        public static int MaxSubArray(int[] nums)
        {
            var max = int.MinValue;
            var sums = new int[nums.Length];

            sums[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sums[i] = sums[i - 1] + nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    max = Math.Max(max, sums[j] - (i == j ? 0 : sums[i]));
                }
            }

            //foreach (var (i, j) in Perm(nums))
            //{
            //    var sum = 0;
            //    for (int k = i; k <= j; k++)
            //    {
            //        sum += nums[k];
            //    }

            //    max = Math.Max(max, sum);
            //}

            return max;
        }

        private static IEnumerable<(int i, int j)> Perm(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    yield return (i, j);
                }
            }
        }

        public static string[] ReorderLogFiles(string[] logs)
        {
            //var lst = new List<string>();

            //var letterLogs = logs.Where(l => !IsDigitLogs(l)).ToList();
            //Array.Sort(letterLogs.Select(StripIdentifier).ToArray());

            //foreach (var digitLogs in logs.Where(IsDigitLogs))
            //{
            //    lst.Add(digitLogs);
            //}

            //return lst.ToArray();
            IComparer<string> comparer = Comparer<string>.Create(new Comparison<string>((s1, s2) =>
            {
                var log1Parts = s1.Split(" ", 2);
                var log2Parts = s2.Split(" ", 2);
                var isDigit1 = log1Parts[1][0] >= '0' && log1Parts[1][0] <= '9';
                var isDigit2 = log2Parts[1][0] >= '0' && log2Parts[1][0] <= '9';
                if (!isDigit1 && !isDigit2)
                {
                    var comparer = log1Parts[1].CompareTo(log2Parts[1]);
                    return comparer == 0 ? log1Parts[0].CompareTo(log2Parts[0]) : comparer;
                }
                else
                {
                    if (isDigit1 && isDigit2)
                        return 0;
                    else if (isDigit1) return 1;
                    else return -1;
                }
            }));

            return logs.OrderBy(s => s, comparer).ToArray();
        }

        private static string StripIdentifier(string log)
        {
            return log.Substring(log.IndexOf(' ') + 1);
        }

        public static bool IsDigitLogs(string s)
        {
            var i = 0;
            while (s[i] != ' ' && i < s.Length)
            {
                i++;
            }

            return s[++i] >= '0' && s[i] <= '9';
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0, sum = 0;
            ListNode newLinkedList = null, lastNode = null;

            while (l1 != null || l2 != null)
            {
                sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                var val = sum % 10;
                carry = sum / 10;
                var newNode = new ListNode(val);

                if (newLinkedList == null)
                {
                    newLinkedList = lastNode = newNode;
                }
                else
                {
                    lastNode.next = newNode;
                    lastNode = lastNode.next;
                }

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry > 0)
            {
                var newNode = new ListNode(carry);
                lastNode.next = newNode;
            }
            return newLinkedList;
        }

        public static int NumIslands(char[][] grid)
        {
            var count = 0;
            var q = new Queue<(int, int)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    //if (grid[i][j] == "1" && (i <= 0 || grid[i-1][j] == "0") && (j <= 0 || grid[i][j - 1] == "0"))
                    //{
                    //    count++;
                    //}

                    if (grid[i][j] == '1')
                    {
                        if (q.Count == 0) count++;
                        q.Enqueue((i, j));
                        Traverse(grid, q);
                    }

                    grid[i][j] = '0';
                }
            }

            return count;
        }

        private static void Traverse(char[][] grid, Queue<(int i, int j)> queue)
        {
            while (queue.Count > 0)
            {
                var (i, j) = queue.Dequeue();
                if (i + 1 < grid.Length && grid[i + 1][j] == '1')
                {
                    queue.Enqueue((i + 1, j));
                    grid[i + 1][j] = '0';
                }
                if (i - 1 >= 0 && grid[i - 1][j] == '1')
                {
                    queue.Enqueue((i - 1, j));
                    grid[i - 1][j] = '0';
                }
                if (j + 1 < grid[i].Length && grid[i][j + 1] == '1')
                {
                    queue.Enqueue((i, j + 1));
                    grid[i][j + 1] = '0';
                }
                if (j - 1 >= 0 && grid[i][j - 1] == '1')
                {
                    queue.Enqueue((i, j - 1));
                    grid[i][j - 1] = '0';
                }
            }
        }

        public static int[] TwoSum2(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dic.ContainsKey(complement) && dic[complement] != i)
                {
                    return new[] { i, dic[complement] };
                }

                dic[nums[i]] = i;
            }

            return new int[] { };
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            //Array.Sort(nums);
            // 0, 1, 3, 7, 9, 33, 99
            int low = 0, high = nums.Length;
            //while (low < high)
            //{
            //    var mid = (high + low) / 2;
            //    if (nums[mid] < target)
            //    {
            //        low = mid;
            //    }
            //    else if (nums[mid] > target)
            //    {
            //        high = mid - 1;
            //    }
            //    else break;
            //}

            for (int i = 0; i < high; i++)
            {
                for (int j = i + 1; j < high; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
                }
            }

            return new int[] { };
        }
    }

}
