using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the roadsAndLibraries function below.
    static long roadsAndLibraries(int n, int c_lib, int c_road, int[][] cities)
    {
        if (c_road > c_lib)
            return n * c_lib;

        var gragh = new Gragh(n, false);
        for (int i = 0; i < cities.Length; i++)
        {
            gragh.AddEdge(cities[i][0], cities[i][1]);
        }

        return DFS(gragh, c_lib, c_road);
    }

    private static long DFS(Gragh gragh, int c_lib, int c_road)
    {
        var visited = new bool[gragh.CitiesCount + 1];
        long cost = 0;
        for (int i = 1; i <= gragh.CitiesCount; i++)
        {
            if (!visited[i])
            {
                var routesCount = DFSUtil(gragh, visited, i);
                cost += (routesCount - 1) * c_road + c_lib;
            }
        }

        return cost;
    }

    private static int DFSUtil(Gragh gragh, bool[] visited, int vertix)
    {
        int routesCount = 1;
        visited[vertix] = true;
        if (gragh.VertixesWithEdges.ContainsKey(vertix))
            foreach (var edge in gragh.VertixesWithEdges[vertix])
            {
                if (!visited[edge])
                    routesCount += DFSUtil(gragh, visited, edge);
            }

        return routesCount;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] nmC_libC_road = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nmC_libC_road[0]);

            int m = Convert.ToInt32(nmC_libC_road[1]);

            int c_lib = Convert.ToInt32(nmC_libC_road[2]);

            int c_road = Convert.ToInt32(nmC_libC_road[3]);

            int[][] cities = new int[m][];

            for (int i = 0; i < m; i++)
            {
                cities[i] = Array.ConvertAll(Console.ReadLine().Split(' '), citiesTemp => Convert.ToInt32(citiesTemp));
            }

            long result = roadsAndLibraries(n, c_lib, c_road, cities);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

class Gragh
{
    public int CitiesCount { get; set; }

    private bool directed;

    public Dictionary<int, List<int>> VertixesWithEdges;

    public Gragh(int citiesCount, bool directed)
    {
        this.CitiesCount = citiesCount;
        this.directed = directed;
        this.VertixesWithEdges = new Dictionary<int, List<int>>();
    }

    public void AddEdge(int vertixA, int vertixB)
    {
        if (!VertixesWithEdges.ContainsKey(vertixA))
        {
            VertixesWithEdges.Add(vertixA, new List<int>());
        }
        VertixesWithEdges[vertixA].Add(vertixB);
        if (!directed)
        {
            if (!VertixesWithEdges.ContainsKey(vertixB))
            {
                VertixesWithEdges.Add(vertixB, new List<int>());
            }
            VertixesWithEdges[vertixB].Add(vertixA);
        }
    }

}
