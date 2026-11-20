using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.SlidingWindow
{
    /*
     
     209. Minimum Size Subarray Sum
Medium
Topics
premium lock icon
Companies
Given an array of positive integers nums and a positive integer target, return the minimal length of a subarray whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.

 

Example 1:

Input: target = 7, nums = [2,3,1,2,4,3]
Output: 2
Explanation: The subarray [4,3] has the minimal length under the problem constraint.
Example 2:

Input: target = 4, nums = [1,4,4]
Output: 1
Example 3:

Input: target = 11, nums = [1,1,1,1,1,1,1,1]
Output: 0
 

Constraints:

1 <= target <= 109
1 <= nums.length <= 105
1 <= nums[i] <= 104
     */
    class _209_Minimum_Size_SubArray_Sum
    {

        public int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int sum = 0;
            //this start at the biggest Possible value so that any real Window will be Smaller, You ca n start at 0, because Nath.Min would always keep the 0
            int shortest = int.MaxValue;

            //Iterate through the List 
            for (int right = 0; right < nums.Length; right++)
            {
                //populate the Sum
                sum += nums[right];

                //If for whatever the reason the Current sum is greater than target. you target is 7 but the Current sum is showing 11, 1+2+3+5 with index 0, 1,2,3 - Respectively

                  
                //Iterate while the Current Sum is still greater than
                //the target
                while (sum >= target)
                {
                    //Get the Shortest First before modifying, Compare this 
                    shortest = Math.Min(shortest, right - left + 1);
                    //Subtract the Left, by narrowing the Window
                    sum -= nums[left];
                    //After Removing the Left Push the left forward Narrowing the Window
                    left++;
                }
            }
           // If shortest equlas int.MaxValue, Swap the 
            return shortest == int.MaxValue ? 0 : shortest;
        }
    }
}
