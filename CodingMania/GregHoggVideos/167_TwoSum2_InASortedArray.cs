using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{

    /*
     167. Two Sum II - Input Array Is Sorted
Medium
Topics
premium lock icon
Companies
You are given a 1-indexed array of integers numbers that is already sorted in non-decreasing order.

Find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

Return the indices of the two numbers index1 and index2 as an integer array [index1, index2] of length 2.

The tests are generated such that there is exactly one solution. You may not use the same element twice.

Your solution must use only constant extra space.

 

Example 1:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
Example 2:

Input: numbers = [2,3,4], target = 6
Output: [1,3]
Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].
Example 3:

Input: numbers = [-1,0], target = -1
Output: [1,2]
Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2. We return [1, 2].
     */
    class _167_TwoSum2_InASortedArray
    {

        public int[] TwoSumItIsRunTymSolution(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int sum = 0;
            int[] result = null;
            while (left < right)
            {
                sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    result = new int[2] { left + 1, right + 1 };
                    return result;
                }

                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }
    }
}
