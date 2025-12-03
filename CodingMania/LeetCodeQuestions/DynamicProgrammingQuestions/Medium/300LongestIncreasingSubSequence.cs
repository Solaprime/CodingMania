using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.DynamicProgrammingQuestions.Medium
{


    /*
     
     Given an integer array nums, return the length of the longest strictly increasing subsequence.

 

Example 1:

Input: nums = [10,9,2,5,3,7,101,18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.
Example 2:

Input: nums = [0,1,0,3,2,3]
Output: 4
Example 3:

Input: nums = [7,7,7,7,7,7,7]
Output: 1
 

Constraints:

1 <= nums.length <= 2500
-104 <= nums[i] <= 104
 

    Follow up: Can you come up with an algorithm that runs in O(n log(n)) time complexity?
     */
    public class _300LongestIncreasingSubSequence
    {
        //Recursive approach With Memoization(Top Down Up)

        private int[,] dp;

        public int LengthOfLISRecursive(int[] nums)
        {
            int n = nums.Length;
            dp = new int[n, n + 1];  // +1 because prevIndex can be -1
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n + 1; j++)
                    dp[i, j] = -1;

            return Dfs(nums, 0, -1);
        }

        private int Dfs(int[] nums, int index, int prevIndex)
        {
            if (index == nums.Length)
                return 0;

            if (dp[index, prevIndex + 1] != -1)
                return dp[index, prevIndex + 1];

            // Option 1: Skip current number
            int notTake = Dfs(nums, index + 1, prevIndex);

            // Option 2: Take current number if it's valid
            int take = 0;
            if (prevIndex == -1 || nums[index] > nums[prevIndex])
            {
                take = 1 + Dfs(nums, index + 1, index);
            }

            return dp[index, prevIndex + 1] = Math.Max(take, notTake);
        }

        // 2) Iterative DP (Bottom-Up)
        public int LengthOfLISIterative(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            System.Array.Fill(dp, 1);

            int maxLen = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
                maxLen = Math.Max(maxLen, dp[i]);
            }

            return maxLen;
        }


        //Follow up: Can you come up with an algorithm that runs in O(n log(n)) time complexity?

        public int LengthOfLIS(int[] nums)
        {
            List<int> sub = new List<int>();

            foreach (int num in nums)
            {
                int idx = sub.BinarySearch(num);
                if (idx < 0) idx = ~idx; // if not found, BinarySearch returns bitwise complement of insert index

                if (idx == sub.Count)
                {
                    sub.Add(num);  // extend subsequence
                }
                else
                {
                    sub[idx] = num; // replace element to keep subsequence minimal
                }
            }

            return sub.Count;
        }
    }
}
