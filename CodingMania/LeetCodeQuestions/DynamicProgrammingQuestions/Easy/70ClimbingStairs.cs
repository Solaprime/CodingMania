using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.DynamicProgrammingQuestions.Easy
{
    /*
     
    
    you are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

 

Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
 

Constraints:

1 <= n <= 45
     

     */
    public class _70ClimbingStairs
    {

        //this Variable is Used for Recursive With Memoization Approach
        private Dictionary<int, int> memo = new Dictionary<int, int>();

        //Iterative with Constant Space (Optimized Fibonacci).
        public int ClimbStairs(int n)
        {
            if (n == 1) return 1;  //Only 1 way for one Step
            if (n == 2) return 2;  //only 2 way for 2 step

            int first = 1; //Ways(1)
            int second = 2; //ways(2)


            for (int i = 3; i < n; i++)
            {
                int current = first + second; //ways(n-1) + ways(n-2)
                first = second;   //shift Forward
                second = current; //update to new Value
            }

            return second;
        }


        /*   Explaining


   n = 1 → only 1 way ([1]).

n = 2 → two ways ([1+1], [2]).

n = 3 → three ways ([1+1+1], [1+2], [2+1]).

n = 4 → five ways ([1+1+1+1], [1+1+2], [1+2+1], [2+1+1], [2+2]).

    This is Fibonacci:

ways(1) = 1

ways(2) = 2

ways(3) = 3

ways(4) = 5

ways(5) = 8


   Step 2: Recurrence Relation

To reach step n, you could have:

Come from n-1 (last move was +1 step).

Come from n-2 (last move was +2 steps).

So:

ways(n) = ways(n-1) + ways(n-2)


   Code Flow Explanation
   Handle base cases (n=1, n=2).

Use two variables (first and second) to keep track of last two results.

Loop from 3 to n:

Compute the current number of ways (ways(n-1) + ways(n-2)).

Shift values forward (first = second, second = current).

Return the last computed value.


   Step 3: Dynamic Programming Approach

There are 3 ways to solve:

1.)Recursive with Memoization (Top-Down).

2.)Iterative with DP Array (Bottom-Up).

3.)Iterative with Constant Space (Optimized Fibonacci).

We’ll do option 3 (Optimized) since n <= 45.
    */



        ///=====
        ///====
        ///
        //Recursive with Memoization (Top-Down)\
        public int ClimbStairs2(int n)
        {
            if (n == 1) return 1; //base case
            if (n == 2) return 2;   // base case

            if (memo.ContainsKey(n))
            {
                return memo[n]; // return cached result
            }
            // Recursive relation: ways(n) = ways(n-1) + ways(n-2)
            int result = ClimbStairs2(n - 1) + ClimbStairs2(n - 2);
            memo[n] = result; // store in cache

            return result;
        }

        //Iterative with DP Array (Bottom-Up)
        public int ClimbStairs3(int n)
        {
            if (n == 1) return 1;

            int[] dp = new int[n + 1];
            dp[1] = 1; // 1 way to climb 1 step
            dp[2] = 2; // 2 ways to climb 2 steps

            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

    }


}
