using System;
using System.Collections.Generic;

namespace _40
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[3][];
            arr[0] = new char[] { '1', '1', '1' };
            arr[1] = new char[] { '0', '1', '0' };
            arr[2] = new char[] { '1', '1', '1' };

            Console.WriteLine(new Program().NumIslands(arr));
        }

        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;
            var islandsCount = 0;
            for (int i1 = 0; i1 < grid.Length; i1++)
            {
                for (int j1 = 0; j1 < grid[i1].Length; j1++)
                {
                    if (grid[i1][j1] == '1')
                    {
                        islandsCount++;
                        DFS(grid, i1, j1);
                    }
                }
            }

            return islandsCount;
        }

        private void DFS(char[][] grid, int i1, int j1)
        {
            if(i1 < 0 || i1 >= grid.Length || j1 < 0 || j1 >= grid[0].Length || grid[i1][j1] != '1')
                return;
            grid[i1][j1] = '#';
            DFS(grid, i1, j1 - 1);
            DFS(grid, i1, j1 + 1);
            DFS(grid, i1 + 1, j1);
            DFS(grid, i1 - 1, j1);
        }

        public int NumIslands3(char[][] grid)
        {
            var visited = new HashSet<Tuple<int, int>>();
            var islandsCount = 0;
            var st = new Stack<Tuple<int, int>>();
            for (int i1 = 0; i1 < grid.Length; i1++)
            {
                for (int j1 = 0; j1 < grid[i1].Length; j1++)
                {
                    if (!visited.Contains(new Tuple<int, int>(i1, j1)) && grid[i1][j1] == '1')
                    {
                        islandsCount++;
                        st.Push(new Tuple<int, int>(i1, j1));
                        // DFS traverse
                        while (st.Count > 0)
                        {
                            var item = st.Pop();
                            var j = item.Item2;
                            var i = item.Item1;
                            visited.Add(item);
                            if (j - 1 >= 0 && grid[i][j - 1] == '1' && !visited.Contains(new Tuple<int, int>(i, j - 1)))
                                st.Push(new Tuple<int, int>(i, j - 1));
                            if (j + 1 < grid[i].Length && grid[i][j + 1] == '1' && !visited.Contains(new Tuple<int, int>(i, j + 1)))
                                st.Push(new Tuple<int, int>(i, j + 1));
                            if (i - 1 >= 0 && grid[i - 1][j] == '1' && !visited.Contains(new Tuple<int, int>(i - 1, j)))
                                st.Push(new Tuple<int, int>(i - 1, j));
                            if (i + 1 < grid.Length && grid[i + 1][j] == '1' && !visited.Contains(new Tuple<int, int>(i + 1, j)))
                                st.Push(new Tuple<int, int>(i + 1, j));
                        }
                    }
                }
            }

            return islandsCount;
        }

        public int NumIslands2(int[][] grid)
        {
            if (grid == null || grid.Length == '0' || grid['0'].Length == '0')
                return '0';
            var islandsCount = '0';

            for (var i = '0'; i < grid.Length; i++)
            {
                for (var j = '0'; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1' && (j == '0' || grid[i][j - '1'] == '0') && (i == '0' || grid[i - '1'][j] == '0'))
                        islandsCount++;
                }
            }
            return islandsCount;
        }
    }
}
