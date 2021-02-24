using System;
using System.Collections.Generic;
using System.Drawing;
using Int64 = System.Int64;

namespace FillImage
{
    public class Solution
    {
        static void Main(string[] args)
        {
            var image = new int[2][];
            image[0] = new int[3] {0, 0, 0};
            image[1] = new int[] {0, 1, 1};
            FloodFill(image, 1, 1, 1);

            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < image[i].Length; j++)
                {
                    Console.Write(image[i][j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            var maxX = image.Length;
            var maxY = image[0].Length;
            if (sr >= maxY || sc >= maxY || sr < 0 || sc < 0) return image;

            var orgColor = image[sr][sc];
            var visited = new HashSet<Point>();
            var st = new Stack<Point>();
            st.Push(new Point(sr, sc));

            while (st.Count > 0)
            {
                var p = st.Pop();
                visited.Add(p);
                image[p.X][p.Y] = newColor;
                if(!visited.Contains(new Point(p.X, p.Y - 1)) && p.Y - 1 >= 0 && image[p.X][p.Y - 1] == orgColor)
                    st.Push(new Point(p.X, p.Y-1));
                if(!visited.Contains(new Point(p.X, p.Y + 1)) && p.Y + 1 < maxY && image[p.X][p.Y + 1] == orgColor)
                    st.Push(new Point(p.X, p.Y + 1));
                if (!visited.Contains(new Point(p.X - 1, p.Y)) && p.X - 1 >= 0 && image[p.X-1][p.Y] == orgColor)
                    st.Push(new Point(p.X-1, p.Y));
                if (!visited.Contains(new Point(p.X + 1, p.Y)) && p.X + 1 < maxX && image[p.X+1][p.Y] == orgColor)
                    st.Push(new Point(p.X + 1, p.Y));
            }

            return image;
        }
    }
}
