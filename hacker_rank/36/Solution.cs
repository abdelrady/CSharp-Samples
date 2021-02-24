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
    // Complete the findShortest function below.

    /*
     * For the unweighted graph, <name>:
     *
     * 1. The number of nodes is <name>Nodes.
     * 2. The number of edges is <name>Edges.
     * 3. An edge exists between <name>From[i] to <name>To[i].
     *
     */
    static int findShortest(int graphNodes, int[] graphFrom, int[] graphTo, long[] colors, int val)
    {
        // solve here
        var gragh = new Gragh(graphNodes, false);
        for (int i = 0; i < graphFrom.Length; i++)
        {
            gragh.AddEdge(new Vertix(graphFrom[i], colors[graphFrom[i] - 1]), new Vertix(graphTo[i], colors[graphTo[i] - 1]));
        }

        var visited = new HashSet<Vertix>(new EqualityComparer());
        var q = new Queue<Tuple<int, Vertix>>();
        foreach (var vertixKV in gragh.VertixesWithEdges)
        {
            var parentVertix = vertixKV.Key;
            //if (!visited.Contains(parentVertix))
            {
                visited.Add(parentVertix);
                if (parentVertix.Color == val)
                {
                    var path = 0;
                    q.Enqueue(new Tuple<int, Vertix>(0, parentVertix));
                    while (q.Count > 0)
                    {
                        var qItem = q.Dequeue();
                        // BFS
                        foreach (var child in gragh.VertixesWithEdges[qItem.Item2])
                        {
                            if (!visited.Contains(child))
                            {
                                q.Enqueue(new Tuple<int, Vertix>(qItem.Item1 + 1, child));
                                if (child.Color == val)
                                    return qItem.Item1 + 1;
                            }
                        }
                    }
                }
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] graphNodesEdges = Console.ReadLine().Split(' ');
        int graphNodes = Convert.ToInt32(graphNodesEdges[0]);
        int graphEdges = Convert.ToInt32(graphNodesEdges[1]);

        int[] graphFrom = new int[graphEdges];
        int[] graphTo = new int[graphEdges];

        for (int i = 0; i < graphEdges; i++)
        {
            string[] graphFromTo = Console.ReadLine().Split(' ');
            graphFrom[i] = Convert.ToInt32(graphFromTo[0]);
            graphTo[i] = Convert.ToInt32(graphFromTo[1]);
        }

        long[] ids = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), idsTemp => Convert.ToInt64(idsTemp))
            ;
        int val = Convert.ToInt32(Console.ReadLine());

        int ans = findShortest(graphNodes, graphFrom, graphTo, ids, val);

        textWriter.WriteLine(ans);

        textWriter.Flush();
        textWriter.Close();
    }
}


class Gragh
{
    public int CitiesCount { get; set; }

    private bool directed;

    public Dictionary<Vertix, List<Vertix>> VertixesWithEdges;

    public Gragh(int citiesCount, bool directed)
    {
        this.CitiesCount = citiesCount;
        this.directed = directed;
        this.VertixesWithEdges = new Dictionary<Vertix, List<Vertix>>(new EqualityComparer());
    }

    public void AddEdge(Vertix vertixA, Vertix vertixB)
    {
        if (!VertixesWithEdges.ContainsKey(vertixA))
        {
            VertixesWithEdges.Add(vertixA, new List<Vertix>());
        }
        VertixesWithEdges[vertixA].Add(vertixB);
        if (!directed)
        {
            if (!VertixesWithEdges.ContainsKey(vertixB))
            {
                VertixesWithEdges.Add(vertixB, new List<Vertix>());
            }
            VertixesWithEdges[vertixB].Add(vertixA);
        }
    }

}

public class EqualityComparer : IEqualityComparer<Vertix>
{
    public bool Equals(Vertix x, Vertix y)
    {
        if (x == null)
            return false;
        if (y == null)
            return false;
        return x.Id == y.Id && x.Color == y.Color;
    }

    public int GetHashCode(Vertix obj)
    {
        unchecked // Overflow is fine, just wrap
        {
            int hash = 17;
            // Suitable nullity checks etc, of course :)
            hash = hash * 23 + obj.Id.GetHashCode();
            hash = hash * 23 + obj.Color.GetHashCode();
            return hash;
        }
    }
}
public class Vertix : IEqualityComparer
{
    public int Id { get; set; }
    public long Color { get; set; }

    public Vertix(int id, long color)
    {
        this.Id = id;
        this.Color = color;
    }

    public override string ToString()
    {
        return Id + "/" + Color;
    }

    public bool Equals(Vertix x, Vertix y)
    {
        if (x == null)
            return false;
        if (y == null)
            return false;
        return x.Id == y.Id && x.Color == y.Color;
    }

    public int GetHashCode(Vertix obj)
    {
        unchecked // Overflow is fine, just wrap
        {
            int hash = 17;
            // Suitable nullity checks etc, of course :)
            hash = hash * 23 + obj.Id.GetHashCode();
            hash = hash * 23 + obj.Color.GetHashCode();
            return hash;
        }
    }

    public bool Equals(object x, object y)
    {
        return Equals(x as Vertix, y as Vertix);
    }

    public int GetHashCode(object obj)
    {
        return GetHashCode(obj as Vertix);
    }
}
