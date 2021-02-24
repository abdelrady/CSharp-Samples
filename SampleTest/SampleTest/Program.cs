using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SampleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Solution().solution1(new[] { 1, 3, 6, 4, 1, 2 }));

            //Console.WriteLine(new Solution().solution2(9));
            //Console.WriteLine(new Solution().solution2(529));
            //Console.WriteLine(new Solution().solution2(20));
            //Console.WriteLine(new Solution().solution2(15));
            //Console.WriteLine(new Solution().solution2(32));

            //var result = new Solution().solution3(new[] { 3, 8, 9, 7, 6 }, 3);
            //var result = new Solution().solution3(new int[0], 3);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(new Solution().solution4(new[] { 9, 3, 9, 3, 9, 7, 9 }));

            //Console.WriteLine(new Solution().solution5(new[] { 2,3,1,5 }));

            //Console.WriteLine(new Solution().solution(10, 85, 30));

            //var t = new[] { "codility1", "codility3", "codility2", "codility4b", "codility4a" };
            //var r = new[] {"a", "OK", "OK", "ee", "OK"};

            //Console.WriteLine(new Solution().solution7(t, r));

            //Console.WriteLine(new Solution().solution("ACCAABBC"));
            //Console.WriteLine(new Solution().solution("ABCBBCBA"));
            //Console.WriteLine(new Solution().solution("BABABA"));

            //var rnd = new Random();

            //var s = new StringBuilder(50000);

            //for (int i = 0; i < 50000; i++)
            //{
            //    s.Append((char) (rnd.Next(1, 4) + 64));
            //    Thread.Sleep(0);
            //}

            //var str = s.ToString();
            ////Console.WriteLine(str);
            //Console.WriteLine(new Solution().solution(str).Length);

            //Console.WriteLine(Int32.MaxValue);

            Console.WriteLine(new Solution().solution(-11));

        }
    }

    class Solution
    {
        public string solution(int N)
        {
            if (N < Int32.MinValue || N > Int32.MaxValue)
                return "impossible";
            int L = 0, R = 1;
            var possibleAnswers = new HashSet<string>();
            TryOptions(N, L, R, 'L', "", ref possibleAnswers);
            TryOptions(N, L, R, 'R', "", ref possibleAnswers);
            var minMovesCount = possibleAnswers.Min(x => x.Length);
            return possibleAnswers.FirstOrDefault(x=>x.Length == minMovesCount) ?? "impossible";
        }

        private void TryOptions(int N, int L, int R, char op, string moves, ref HashSet<string> possibleAnswers)
        {
            var minAnswerLength = possibleAnswers.Count > 0 ? possibleAnswers.Min(a => a.Length) : 0;
            if (R < Int32.MinValue || 
                R > Int32.MaxValue || 
                L < Int32.MinValue || 
                L > Int32.MaxValue || 
                moves.Length > 10)
            {
                return;
            }

            if (L != N && R != N)
            {
                moves += op.ToString();
                if (op == 'L')
                {
                    L = 2 * L - R;
                }
                else
                {
                    R = 2 * R - L;
                }

                TryOptions(N, L, R, 'L', moves, ref possibleAnswers);
                TryOptions(N, L, R, 'R', moves, ref possibleAnswers);
            }
            else
            {
                possibleAnswers.Add(moves);
            }
        }

        public string solution8(string S)
        {
            var sb = new StringBuilder(S);
            int oldLength;

            do
            {
                oldLength = sb.Length;
                sb.Replace("AA", "").Replace("BB", "").Replace("CC", "");
            } while (sb.Length < oldLength);

            return sb.ToString();
        }

        public int solution7(string[] T, string[] R)
        {
            if (T.Length == 0 || R.Length == 0) return 0;

            var questionsAnswersDic = new Dictionary<int, bool>();
            var tNumbers = T.Select(x => string.Join("", x.Where(y => y >= '0' && y <= '9')))
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < T.Length; i++)
            {
                if (!questionsAnswersDic.ContainsKey(tNumbers[i]))
                {
                    questionsAnswersDic.Add(tNumbers[i], true);
                }
                questionsAnswersDic[tNumbers[i]] = questionsAnswersDic[tNumbers[i]] && (R[i] == "OK");
            }

            int result = questionsAnswersDic.Count(pair => pair.Value) * 100 / questionsAnswersDic.Count;
            return result;
        }

        public int solution6(int X, int Y, int D)
        {
            var diff = Y - X;
            if (diff == 0 || D == 0) return 0;

            var result = (int)Math.Ceiling((decimal)diff / D);

            return result;
        }

        public int solution5(int[] A)
        {
            int missing = 0, i;
            for (i = 1; i <= A.Length; i++)
            {
                missing += i;
                missing -= A[i - 1];
            }
            missing += i;
            return missing;
        }

        public int solution4(int[] A)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (dic.ContainsKey(A[i]))
                {
                    dic[A[i]]++;
                }
                else dic.Add(A[i], 1);
            }

            var unpairedItem = 0;
            foreach (var item in dic)
            {
                if (item.Value % 2 == 1)
                {
                    unpairedItem = item.Key;
                }
            }

            return unpairedItem;
        }

        public int[] solution3(int[] A, int K)
        {
            if (A.Length == K || K == 0 || A.Length == 0) return A;
            for (int i = 0; i < K; i++)
            {
                var temp = A[A.Length - 1];
                for (int j = A.Length - 1; j > 0; j--)
                {
                    A[j] = A[j - 1];
                }
                A[0] = temp;
            }

            return A;
        }

        public int solution2(int N)
        {
            var gaps = new List<int>();
            while (N != 0)
            {
                var i = N % 2;
                if (i == 1)
                {
                    gaps.Add(0);
                }
                else if (gaps.Count > 0)
                {
                    gaps[gaps.Count - 1]++;
                }
                N /= 2;
            }

            if (gaps.Count > 1)
            {
                var maxGap = 0;
                for (int i = 0; i < gaps.Count - 1; i++)
                {
                    if (maxGap < gaps[i]) maxGap = gaps[i];
                }

                return maxGap;
            }
            else return 0;
        }

        public int solution1(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var minPositive = 1;
            var found = true;
            do
            {
                found = A.Contains(minPositive);
                if (found) minPositive++;
            } while (found);

            return minPositive;
        }
    }
}
