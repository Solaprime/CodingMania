using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.GraphQuestions.Easy
{
    /*
     
     There is a bi-directional graph with n vertices, where each vertex is labeled from 0 to n - 1 (inclusive). The edges in the graph are represented as a 2D integer array edges, where each edges[i] = [ui, vi] denotes a bi-directional edge between vertex ui and vertex vi. Every vertex pair is connected by at most one edge, and no vertex has an edge to itself.

You want to determine if there is a valid path that exists from vertex source to vertex destination.

Given edges and the integers n, source, and destination, return true if there is a valid path from source to destination, or false otherwise.

 

Example 1:

     0 -  1
     \    /
        2

Input: n = 3, edges = [[0,1],[1,2],[2,0]], source = 0, destination = 2
Output: true
Explanation: There are two paths from vertex 0 to vertex 2:
- 0 → 1 → 2
- 0 → 2
Example 2:

        1                3
                           \
      /                  |   5
    0                     /
      \                  4
        2

Input: n = 6, edges = [[0,1],[0,2],[3,5],[5,4],[4,3]], source = 0, destination = 5
Output: false
Explanation: There is no path from vertex 0 to vertex 5.
 

Constraints:

1 <= n <= 2 * 105
0 <= edges.length <= 2 * 105
edges[i].length == 2
0 <= ui, vi <= n - 1
ui != vi
0 <= source, destination <= n - 1
There are no duplicate edges.
There are no self edges.
     */

    /*
       Problem Explanation

    
       We have an Undirected graph with n vertices (0 to n-1)
       Edges are given as pairs [u, v].
       We need to check if there is any path from source to destination.
       // we hvae 
     */
    public class _1971FindIfPathExistInGraph
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            //Build Adjacency List
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];
                graph[u].Add(v);
                graph[v].Add(u);
            }

            //Bfs Traversal
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[n];


            queue.Enqueue(source);
            visited[source] = true;

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                if (node == destination)
                    return true;

                foreach (int neighbor in graph[node])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return false;
        }



        //Resracg DFS sOLUTION
    }
}


/*
 * test Solut
  var sol = new Solution();

        int[][] edges1 = { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 0 } };
        Console.WriteLine(sol.ValidPath(3, edges1, 0, 2)); // true

        int[][] edges2 = { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 3, 5 }, new int[] { 5, 4 }, new int[] { 4, 3 } };
        Console.WriteLine(sol.ValidPath(6, edges2, 0, 5)); // false
 */