using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Solution().solution1(new[]{-1000, 1000}));
            //Console.WriteLine(new Solution().solution("{[()()]}"));
            //Console.WriteLine(new Solution().solution2(new[] {4, 1, 3, 2}));
            //Console.WriteLine(new Solution().GetPrimesCount(1000000000));
            Console.WriteLine(new Solution().GetMinPerimeter(101));

        }
    }


    class Solution
    {
        public int GetMinPerimeter(int N)
        {
            if (N <= 0) return 0;

            long min = Int64.MaxValue, preimeter;
            for (int i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    preimeter = (2 * (i + N / i));
                    if (min > preimeter)
                        min = preimeter;
                    if (i != N / i)
                    {
                        preimeter = (2 * (i + N / i));
                        if (min > preimeter)
                            min = preimeter;
                    }
                }
            }

            return (int)min;
        }

        public int GetPrimesCount(int N)
        {
            if (N == 1) return 1;

            var factors = 2;
            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    factors += 1;
                    if (i != N / i)
                        factors += 1;
                }
            }

            return factors;
        }

        public int solution3(int N)
        {
            if (N == 1) return 1;

            var factors = 2;
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                    factors += 1;
            }

            return factors;
        }

        public int solution2(int[] A)
        {
            if (A.Length == 0) return 0;
            //var expectedSum = Enumerable.Range(1, A.Length).Sum();
            //return A.Sum() == expectedSum ? 1 : 0;
            var dic = Enumerable.Range(1, A.Length).ToDictionary(i => i, i => false);
            for (int i = 0; i < A.Length; i++)
            {
                if (!dic.ContainsKey(A[i]))
                    return 0;
                if (dic[A[i]] == true)
                    return 0;
                dic[A[i]] = true;
            }

            return dic.Select(x => x.Value).Any(x => !x) ? 0 : 1;
        }

        public int solution(string S)
        {
            var st = new Stack<char>();
            var dic = new Dictionary<char, char> { { '{', '}' }, { '[', ']' }, { '(', ')' } };

            if (string.IsNullOrEmpty(S))
                return 1;

            if (S.Length % 2 == 1)
                return 0;

            for (int i = 0; i < S.Length; i++)
            {
                try
                {
                    switch (S[i])
                    {
                        case '{':
                        case '[':
                        case '(':
                            st.Push(S[i]);
                            break;
                        default:
                            if (S[i] != dic[st.Pop()])
                                return 0;
                            break;
                    }
                }
                catch (Exception e)
                {
                    return 0;
                }
            }

            if (st.Count != 0)
                return 0;

            return 1;
        }

        public int solution1(int[] A)
        {
            var sum = A.Sum();
            long suma = 0, sumb = sum;
            var minDiff = int.MaxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                suma += A[i];
                sumb -= A[i];
                var diff = (int)Math.Abs(suma - sumb);
                if (minDiff > diff)
                {
                    minDiff = diff;
                }
            }

            return minDiff;
        }
    }
}
