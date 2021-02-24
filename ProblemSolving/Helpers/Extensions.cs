using System;
using System.Collections.Generic;
using System.IO;

namespace Helpers
{
    public static class Extensions
    {

        public static string ReadInputFile(this string fileName)
        {
            return File.ReadAllText(Path.GetFullPath(@"..\..\..\Data\Inputs\" + fileName));
        }

        public static T[][] ToJaggedArray<T>(this T[,] twoDimensionalArray)
        {
            int rowsFirstIndex = twoDimensionalArray.GetLowerBound(0);
            int rowsLastIndex = twoDimensionalArray.GetUpperBound(0);
            int numberOfRows = rowsLastIndex + 1;

            int columnsFirstIndex = twoDimensionalArray.GetLowerBound(1);
            int columnsLastIndex = twoDimensionalArray.GetUpperBound(1);
            int numberOfColumns = columnsLastIndex + 1;

            T[][] jaggedArray = new T[numberOfRows][];
            for (int i = rowsFirstIndex; i <= rowsLastIndex; i++)
            {
                jaggedArray[i] = new T[numberOfColumns];

                for (int j = columnsFirstIndex; j <= columnsLastIndex; j++)
                {
                    jaggedArray[i][j] = twoDimensionalArray[i, j];
                }
            }
            return jaggedArray;
        }

        public static void Print(this object obj)
        {
            Console.WriteLine(obj);
        }

        public static void Print(this ListNode head)
        {
            var node = head;
            while (node != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }

        public static void Print<T>(this T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void Print<T>(this T[][] arr)
        {
            foreach (var item in arr)
            {
                item.Print();
            }
        }

        public static void Print(this int?[][] arr)
        {
            foreach (var item in arr)
            {
                item.Print();
            }
        }

        public static void Print<T>(this IList<T> arr)
        {
            foreach (var item in arr)
            {
                Console.Write((item == null ? "?" : item.ToString()) + " ");
                //Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void Print<T>(this IList<IList<T>> arr)
        {
            foreach (IList<T> item in arr)
            {
                item.Print();
            }
        }
    }
}
