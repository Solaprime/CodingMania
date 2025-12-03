using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.GraphQuestions.Easy
{
    /*
     
     In a town, there are n people labeled from 1 to n. There is a rumor that one of these people is secretly the town judge.

If the town judge exists, then:

The town judge trusts nobody.
Everybody (except for the town judge) trusts the town judge.
There is exactly one person that satisfies properties 1 and 2.
You are given an array trust where trust[i] = [ai, bi] representing that the person labeled ai trusts the person labeled bi. If a trust relationship does not exist in trust array, then such a trust relationship does not exist.

Return the label of the town judge if the town judge exists and can be identified, or return -1 otherwise.

 

Example 1:

Input: n = 2, trust = [[1,2]]
Output: 2
Example 2:

Input: n = 3, trust = [[1,3],[2,3]]
Output: 3
Example 3:

Input: n = 3, trust = [[1,3],[2,3],[3,1]]
Output: -1
 

Constraints:

1 <= n <= 1000
0 <= trust.length <= 104
trust[i].length == 2
All the pairs of trust are unique.
ai != bi
1 <= ai, bi <= n
     */






    /*More Explantation
     
     We have n people, each labeled from 1 to n.
We’re given a list of trust relationships (trust[i] = [a, b] means a trusts b).

We need to find the judge, defined by:

The judge trusts nobody.
→ Outdegree of judge = 0

Everybody else trusts the judge.
→ Indegree of judge = n - 1

Exactly one person satisfies these conditions.

If no such person exists, return -1.

    Graph Interpreatation
    -
    This is basically a directed graph problem:

Each person = node

a -> b if a trusts b

We are looking for a node:

With indegree = n - 1 (trusted by everyone else)

With outdegree = 0 (trusts nobody)


    n = 2, trust = [[1,2]]
Person 1 → 2 (so 1 trusts 2)

Indegree(2) = 1, Outdegree(2) = 0

Person 2 is trusted by everyone else and trusts nobody.
Answer = 2


    Example 2:
n = 3, trust = [[1,3],[2,3]]


Person 1 → 3

Person 2 → 3

Indegree(3) = 2, Outdegree(3) = 0

Person 3 satisfies conditions.
Answer = 3


    Example 3:
n = 3, trust = [[1,3],[2,3],[3,1]]


Person 1 → 3

Person 2 → 3

Person 3 → 1

Indegree(3) = 2, but Outdegree(3) = 1 (he trusts 1) ❌
So no judge exists.
Answer = -1


    //First Solution Without Using Graph
    🖥️ C# Solution (Efficient O(n + trust.Length))

We’ll use an array to track "trust score":

If a trusts b, then:

a loses 1 point (since they trust someone)

b gains 1 point (since they are trusted)

Judge will end up with trustScore = n - 1


    //Second Solution with GrapH Flow
     */
    public class _997FindTheTownJudge
    {

       public int FindJudge(int n, int[][] trust)
       {
            /*
               recall 
            int[] a = new int[4];
              a[0], a[1], a[2], a[3]
            so int 
            int[] b = new int[4 +1]; // 1 - Indexed

               a[0], a[1], a[2], a[3], a[4]
             
             */
            int[] trustScore = new int[n + 1];  // 1-Indexed

            //you want to iterate a Sqire array
            foreach (var relation in trust)
            {
                int a = relation[0];
                int b = relation[1];

                trustScore[a]--; // a trust someone, so lose apoint
                trustScore[b]++; // b is trusted, so gain a  point
            }

            for (int i = 0; i < n; i++)
            {
                if (trustScore[i] == n-1)
                {
                    return i; //found Jusge
                }

            }

            return -1;
       }


        //Using Graph Flows
        //build a directed grapgh Using an Adjacency List
        /*
         
         Graph-Based Solution Idea

Build an adjacency list (dictionary or List<List<int>>) from the trust array.

If a trusts b → directed edge a → b.

Compute:

Outdegree = number of people each person trusts.

Indegree = number of people who trust each person.

Find the person j such that:

outdegree[j] == 0 (trusts nobody).

indegree[j] == n - 1 (everyone else trusts them).

If exactly one such person exists → that’s the judge, otherwise return -1.
         */
        public int FindJudgeUsingGrapgh(int n, int[][] trust)
        {
            //Concept of Dictionary and List
            /*
               Something Like
             [1, [2,3,4,5,5]]
             [2, [3,4,5,5]]
             */
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

            //Initailze adjency List
            
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            //Indegree array (how many trust this Person)
            int[] indegree = new int[n + 1];
            int[] outdegree = new int[n + 1];
            foreach (var relation in trust)
            {
                int a = relation[0];
                int b = relation[1];

                graph[a].Add(b);
                outdegree[a]++;
                indegree[b]++;
                    
            }

            //Jusge must have indegree = n-1 and Outdegree = 0


            for (int i = 0; i < n; i++)
            {
                if (indegree[i] == n - 1 && outdegree[i] == 0)
                    return i;
            }

            return -1;
        }
    }
}
