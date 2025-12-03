using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.DynamicProgrammingQuestions.Easy
{

    /*
     You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

 

Example 1:

Input: nums = [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.
Example 2:

Input: nums = [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
Total amount you can rob = 2 + 9 + 1 = 12.
 

Constraints:

1 <= nums.length <= 100
0 <= nums[i] <= 400
     
     */
    public class _198HouseRobber
    {

        private Dictionary<int, int> memorecursive = new Dictionary<int, int>();
        private int[] numsrecursive;

        //My Solution

        /*
         That assumes the best strategy is to take all even-indexed houses, which is false. The optimal selection depends on values, not only indices

        Adjacent houses cannot both be robbed, but you must compare sums of non-adjacent choices, not fixed parity.
        nums = [2, 1, 1, 2]

Your function picks indices 0 and 2: 2 + 1 = 3.

Optimal solution is indices 0 and 3: 2 + 2 = 4.

So your output would be 3 while the correct answer is 4.
         */
        public int SolaHouseRobber(int[] nums)
        {
            int result = 0;
            result += nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += nums[i];
                }
            }

            return result;
        }


        //Correct Solution Iterative with Dp Array
        public int RobIterative(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int n = nums.Length;

            int[] dp = new int[n];
            dp[0] = nums[0];
            /*
              [0,1]

            option - 0, 1
            pick 0 and 1
             */
            dp[1] = Math.Max(nums[0], nums[1]);

            /*
                Let Us IMAGINE
            FOR 2 
            [0,1,2]
            // Option 1 or 0+2
            Dp[2] = math.Nax(dp[1], dp[0]+numx[2])
               //Why tou picks Nums[2] is that you haven computed it into the array
             */
            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            }
            //array for the Index of Sum,
            return dp[n - 1];
        }

        //optimIzed SPace
        public int RobOptimized(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            /*
             if [0]- 0
             if [0, 1]- 0 or 1
             */
            int prev2 = nums[0]; // dp[i-2]
            int prev1 = Math.Max(nums[0], nums[1]); // dp[i-1]

            /*
             [0,1,2]
            similar to the array but Use variable
            [0,1,2]
            option - 0+2, 1

            since prev2 was Zero set prev1 to prev2
            ans set current to prev1
             */
            for (int i = 2; i < nums.Length; i++)
            {

                int current = Math.Max(prev1, prev2 + nums[i]);
                prev2 = prev1;
                prev1 = current;
            }

            return prev1;
        }
        
        //Recursive Approach
        public int RobRecursive(int[] nums)
        {
            this.numsrecursive = nums;
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            return RobHelper(nums.Length - 1);
        }

        private int RobHelper(int i)
        {
            if (i == 0) return numsrecursive[0];
            if (i == 1) return Math.Max(numsrecursive[0], numsrecursive[1]);

            if (memorecursive.ContainsKey(i))
            {
                return memorecursive[i];
            }

            // Recurrence: max of skipping or robbing current house
            int result = Math.Max(RobHelper(i - 1), RobHelper(i - 2) + memorecursive[i]);
            memorecursive[i] = result; // store result in cache

            return result;
        }
    }
}
