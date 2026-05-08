using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.TwoPointerQuestions.Easy
{
    /*
     
Code
Testcase
Test Result
Test Result
977. Squares of a Sorted Array
Easy
Topics
premium lock icon
Companies
     
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

 

Example 1:

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].
Example 2:

Input: nums = [-7,-3,2,3,11]
Output: [4,9,9,49,121]
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in non-decreasing order.
     */
    public class _977SquaresOfASortedArray
    {
        /*
         Negative numbers become positive when squared
Large negative numbers (like -10) become large positive numbers (100)

So:

👉 The largest squares will come from:

either the left end (big negative numbers)
or the right end (big positive numbers)
         */


        //ChatGPT Solution
        public int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            int left = 0;
            int right = n - 1;
            int k = n - 1;

            while (left < right)
            {
                int leftSquare = nums[left] * nums[left];
                int rightSquare = nums[right] * nums[right];

                if (leftSquare > rightSquare)
                {
                    result[k] = leftSquare;
                    left++;
                }
                else
                {
                    result[k] = rightSquare;
                    right--;
                }
                k--;
            }
            return result;
        }

        //Confirm from ChatGpt, I converted Python to C# Based on my Undertainding
        public int[] SortedSquraesGregHoggSolution(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];

            int left = 0;
            int right = n - 1;
            int k = n - 1;

            while (left < right)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    result[k] = nums[left] ^ 2;
                    left++;
                }

                else
                {
                    result[k] = nums[right] ^ 2;
                    right--;
                }

                k--;
            }
            return result;
            
        }
    }
}
