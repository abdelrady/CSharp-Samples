using System;
using System.Collections;

namespace _33
{
    // C# linear time solution for 
    // stock span problem 
    class GFG
    {
        // a linear time solution for 
        // stock span problem A stack 
        // based efficient method to calculate 
        // stock span values 
        static void calculateSpan(int[] price, int n, int[] S)
        {
            // Create a stack and Push 
            // index of first element to it 
            Stack largestItemsIndexes = new Stack();
            largestItemsIndexes.Push(0);

            // Span value of first 
            // element is always 1 
            S[0] = 1;

            // Calculate span values 
            // for rest of the elements 
            for (int i = 1; i < n; i++)
            {

                // Pop elements from stack 
                // while stack is not empty 
                // and top of stack is smaller 
                // than price[i] 
                while (largestItemsIndexes.Count > 0 && price[(int)largestItemsIndexes.Peek()] <= price[i])
                    largestItemsIndexes.Pop();

                // If stack becomes empty, then price[i] is 
                // greater than all elements on left of it, i.e., 
                // price[0], price[1], ..price[i-1]. Else price[i] 
                // is greater than elements after top of stack 
                S[i] = (largestItemsIndexes.Count == 0) ? (i + 1) : (i - (int)largestItemsIndexes.Peek());

                // Push this element to stack 
                largestItemsIndexes.Push(i);
            }
        }

        // A utility function to print elements of array 
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        // Driver method 
        public static void Main(String[] args)
        {
            int[] price = { 10, 4, 5, 90, 120, 80 };
            int n = price.Length;
            int[] S = new int[n];

            // Fill the span values in array S[] 
            calculateSpan(price, n, S);

            // print the calculated span values 
            printArray(S);
        }
    }

    // This code is contributed by Arnab Kundu 

}
