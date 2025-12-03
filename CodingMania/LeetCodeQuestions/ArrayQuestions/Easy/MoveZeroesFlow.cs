using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.Array.Easy
{
    /*
       MOVE ZEREOS

    Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
 
     */
    internal class MoveZeroesFlow
    {
        public void MoveZeroes(int[] nums)
        {
            int nonZeroIndex = 0;

            // Move all non-zero elements to the front of the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    nonZeroIndex++;
                }
            }

            // Fill the rest of the array with zeroes
            for (int i = nonZeroIndex; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
