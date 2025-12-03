using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.DynamicProgrammingQuestions.Medium
{
    /*
     Given two strings text1 and text2, return the length of their longest common subsequence. If there is no common subsequence, return 0.

A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

For example, "ace" is a subsequence of "abcde".
A common subsequence of two strings is a subsequence that is common to both strings.

 

Example 1:

Input: text1 = "abcde", text2 = "ace" 
Output: 3  
Explanation: The longest common subsequence is "ace" and its length is 3.
Example 2:

Input: text1 = "abc", text2 = "abc"
Output: 3
Explanation: The longest common subsequence is "abc" and its length is 3.
Example 3:

Input: text1 = "abc", text2 = "def"
Output: 0
Explanation: There is no such common subsequence, so the result is 0.
 

Constraints:

1 <= text1.length, text2.length <= 1000
text1 and text2 consist of only lowercase English characters.
     
     */
    public class _1143LongestCommonSubsequence
    {
        private int[,] memo;
        private string t1, t2;
        // DP Approach (Bottom-Up)
        public int LongestCommonSubsequenceBottomUp(string text1, string text2)
        {
            int m = text1.Length, n = text2.Length;
            int[,] dp = new int[m + 1, n + 1];

            // Build dp table
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (text1[i - 1] == text2[j - 1])
                    {
                        dp[i, j] = 1 + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[m, n];
        }

        //Recurssice with Memoization
        public int LongestCommonSubsequence(string text1, string text2)
        {
            t1 = text1;
            t2 = text2;
            int m = t1.Length, n = t2.Length;
            memo = new int[m, n];

            // Initialize memo with -1 (meaning not computed yet)
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    memo[i, j] = -1;

            return Dfs(0, 0);
        }

        private int Dfs(int i, int j)
        {
            // Base case
            if (i == t1.Length || j == t2.Length) return 0;

            if (memo[i, j] != -1) return memo[i, j];

            if (t1[i] == t2[j])
            {
                memo[i, j] = 1 + Dfs(i + 1, j + 1);
            }
            else
            {
                memo[i, j] = Math.Max(Dfs(i + 1, j), Dfs(i, j + 1));
            }

            return memo[i, j];
        }
    }
}
