using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

class Solution
{
    class PositionWithDistance
    {
        public PositionWithDistance(int x, int y, int dist)
        {
            this.X = x;
            this.Y = y;
            this.Distance = dist;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Distance { get; set; }

        public override bool Equals(object obj)
        {
            var that = obj as PositionWithDistance;
            if (that == null) return false;

            return this.X == that.X && this.Y == that.Y;
        }
        public override int GetHashCode()
        {
            return 31 * X + 17 * Y; // Or something like that
        }
    }

    // Complete the minimumMoves function below.
    static int minimumMoves(string[] grid, int startX, int startY, int goalX, int goalY)
    {
        var maxY = grid.Length;
        var maxX = grid[0].Length;

        var start = new PositionWithDistance(startX, startY, 0);
        var end = new PositionWithDistance(goalX, goalY, 0);
        if (start.Equals(end))
            return 0;
        var q = new Queue<PositionWithDistance>();
        var visitedDic = new HashSet<PositionWithDistance>();
        var minMovesList = new List<int>();
        q.Enqueue(start);
        while (q.Count > 0)
        {
            var pos = q.Dequeue();
            visitedDic.Add(pos);
            //PrintGrid(grid, visitedDic);
            // Get possible moves
            for (int i = pos.X + 1; i < maxX; i++)
            {
                var move = new PositionWithDistance(i, pos.Y, pos.Distance + 1);
                if (visitedDic.Contains(move))
                    break;
                if (grid[i][pos.Y] == 'X')
                    break;
                if (move.Equals(end))
                    minMovesList.Add(move.Distance);
                //return move.Distance;
                visitedDic.Add(move);
                q.Enqueue(move);
            }

            for (int i = pos.X - 1; i >= 0; i--)
            {
                // TODO refactor
                var move = new PositionWithDistance(i, pos.Y, pos.Distance + 1);
                if (visitedDic.Contains(move))
                    break;
                if (grid[i][pos.Y] == 'X')
                    break;
                if (move.Equals(end))
                    minMovesList.Add(move.Distance);
                //return move.Distance;
                visitedDic.Add(move);
                q.Enqueue(move);
            }

            for (int j = pos.Y - 1; j >= 0; j--)
            {
                // TODO refactor
                var move = new PositionWithDistance(pos.X, j, pos.Distance + 1);
                if (visitedDic.Contains(move))
                    break;
                if (grid[pos.X][j] == 'X')
                    break;
                if (move.Equals(end))
                    minMovesList.Add(move.Distance);
                //return move.Distance;
                visitedDic.Add(move);
                q.Enqueue(move);
            }
            for (int j = pos.Y + 1; j < maxY; j++)
            {
                // TODO refactor
                var move = new PositionWithDistance(pos.X, j, pos.Distance + 1);
                if (visitedDic.Contains(move))
                    break;
                if (grid[pos.X][j] == 'X')
                    break;
                if (move.Equals(end))
                    minMovesList.Add(move.Distance);
                //return move.Distance;
                visitedDic.Add(move);
                q.Enqueue(move);
            }

            //Console.ReadLine();
        }

        return minMovesList.Any() ? minMovesList.Min() : -1;
    }

    private static void PrintGrid(string[] grid, HashSet<PositionWithDistance> visitedDic)
    {
        var orgColor = Console.ForegroundColor;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (visitedDic.Contains(new PositionWithDistance(i, j, 0)))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = orgColor;
                }
                Console.Write(grid[i][j]);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        var lines = File.ReadAllLines("d:\\input02.txt");

        int n = Convert.ToInt32(lines[0]);

        string[] grid = new string[n];

        for (int i = 0; i < n; i++)
        {
            string gridItem = lines[i + 1];
            grid[i] = gridItem;
        }

        string[] startXStartY = lines[lines.Length - 1].Split(' ');

        int startX = Convert.ToInt32(startXStartY[0]);

        int startY = Convert.ToInt32(startXStartY[1]);

        int goalX = Convert.ToInt32(startXStartY[2]);

        int goalY = Convert.ToInt32(startXStartY[3]);

        int result = minimumMoves(grid, startX, startY, goalX, goalY);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}