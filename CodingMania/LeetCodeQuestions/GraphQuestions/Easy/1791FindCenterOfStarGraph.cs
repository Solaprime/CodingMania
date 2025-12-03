using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.GraphQuestions.Easy
{
    /*
     
     There is an undirected star graph consisting of n nodes labeled from 1 to n. A star graph is a graph where there is one center node and exactly n - 1 edges that connect the center node with every other node.

You are given a 2D integer array edges where each edges[i] = [ui, vi] indicates that there is an edge between the nodes ui and vi. Return the center of the given star graph.

 

Example 1:

              4
              |
              2
           /      \
         1         3
Input: edges = [[1,2],[2,3],[4,2]]
Output: 2
Explanation: As shown in the figure above, node 2 is connected to every other node, so 2 is the center.
Example 2:

Input: edges = [[1,2],[5,1],[1,3],[1,4]]
Output: 1
 

Constraints:

3 <= n <= 105
edges.length == n - 1
edges[i].length == 2
1 <= ui, vi <= n
ui != vi
The given edges represent a valid star graph.
    
     */

    /*Problem Explanation
        A center node is a node that Connect directly to all other n-1 nodes

    edges = [[1,2],[2,3],[4,2]]
    Node 1 connects to 2 → degree(1) = 1

Node 2 connects to 1, 3, 4 → degree(2) = 3

Node 3 connects to 2 → degree(3) = 1

Node 4 connects to 2 → degree(4) = 1

    → Node 2 has degree n - 1 = 3.


    Example 2
    edges = [[1,2],[5,1],[1,3],[1,4]]

    Node 1 connects to 2, 3, 4, 5 → degree(1) = 4

All others (2,3,4,5) have degree = 1

→ Node 1 is the center.
Answer = 1
    */
    public class _1791FindCenterOfStarGraph
    {
        public int FindCenter(int[][] edges)
        {
            //Count Degree of Each Node
            Dictionary<int, int> degree = new Dictionary<int, int>();
            foreach (var edge in edges) 
            {
                int u = edge[0];
                int v = edge[1];

                if (!degree.ContainsKey(u))
                {
                    degree[u] = 0;
                }

                if (!degree.ContainsKey(v))
                {
                    degree[v] = 0;
                }

                degree[u]++;
                degree[v]++;

            }

            int n = degree.Count; //total nodes

            //The Center must have  degree n-1
            foreach (var kv in degree)
            {
                if (kv.Value == n-1)
                {
                    return kv.Key;
                }
            }

            return -1; //Should never happend For valid star graph
        }
    }
}
