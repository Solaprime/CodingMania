using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.DynamicProgrammingQuestions.Medium
{
    /*
     Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.

You have the following three operations permitted on a word:

Insert a character
Delete a character
Replace a character
 

Example 1:

Input: word1 = "horse", word2 = "ros"
Output: 3
Explanation: 
horse -> rorse (replace 'h' with 'r')
rorse -> rose (remove 'r')
rose -> ros (remove 'e')
Example 2:

Input: word1 = "intention", word2 = "execution"
Output: 5
Explanation: 
intention -> inention (remove 't')
inention -> enention (replace 'i' with 'e')
enention -> exention (replace 'n' with 'x')
exention -> exection (replace 'n' with 'c')
exection -> execution (insert 'u')
 

Constraints:

0 <= word1.length, word2.length <= 500
word1 and word2 consist of lowercase English letters.
     */
    public class _72EditDistance
    {
        private int[,] memo;
        private string w1, w2;
        //DP Approach (Bottom-Up)
        public int MinDistanceBottomUp(string word1, string word2)
        {
            int m = word1.Length, n = word2.Length;
            int[,] dp = new int[m + 1, n + 1];

            // Base cases
            for (int i = 0; i <= m; i++) dp[i, 0] = i; // delete all
            for (int j = 0; j <= n; j++) dp[0, j] = j; // insert all

            // Fill DP table
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1]; // no change
                    }
                    else
                    {
                        dp[i, j] = 1 + Math.Min(
                            dp[i - 1, j],   // delete
                            Math.Min(dp[i, j - 1], dp[i - 1, j - 1]) // insert or replace
                        );
                    }
                }
            }

            return dp[m, n];
        }


        //C# Code (Top-Down with Memoization) Flow
        public int MinDistance(string word1, string word2)
        {
            w1 = word1;
            w2 = word2;
            int m = w1.Length, n = w2.Length;
            memo = new int[m + 1, n + 1];

            // Initialize memo with -1 (meaning not calculated yet)
            for (int i = 0; i <= m; i++)
                for (int j = 0; j <= n; j++)
                    memo[i, j] = -1;

            return Dfs(0, 0);
        }

        private int Dfs(int i, int j)
        {
            // Base cases
            if (i == w1.Length) return w2.Length - j; // insert rest of w2
            if (j == w2.Length) return w1.Length - i; // delete rest of w1

            if (memo[i, j] != -1) return memo[i, j];

            if (w1[i] == w2[j])
            {
                memo[i, j] = Dfs(i + 1, j + 1);
            }
            else
            {
                int insert = Dfs(i, j + 1);
                int delete = Dfs(i + 1, j);
                int replace = Dfs(i + 1, j + 1);

                memo[i, j] = 1 + Math.Min(delete, Math.Min(insert, replace));
            }

            return memo[i, j];
        }
    }
}
