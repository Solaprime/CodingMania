using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.Array.Easy
{

    /*Missing Flow
     
     Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

 

Example 1:

Input: nums = [3,0,1]

Output: 2

Explanation:

n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.

Example 2:

Input: nums = [0,1]

Output: 2

Explanation:

n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.

Example 3:

Input: nums = [9,6,4,2,3,5,7,0,1]

Output: 8

Explanation:

n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.

 
 

 

 

Constraints:

n == nums.length
1 <= n <= 104
0 <= nums[i] <= n
All the numbers of nums are unique.
 
     */

    internal class MissingNumberFlow
    {

        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int totalSum = n * (n + 1) / 2; // Sum of numbers from 0 to n
            int arraySum = 0;

            foreach (int num in nums)
            {
                arraySum += num; // Sum of elements in the array
            }

            return totalSum - arraySum; // The difference is the missing number
        }


        //Missing Number 2
        //public int MissingNumber2(int[] nums)
        //{
        //    int result = 0;
            
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if(!nums.Contains(i))
        //        {
        //            result =  nums[i];
        //        }
        //    }

        //    return  result;
        //}


        public int MissingNumber2(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i <= n; i++) // include n
            {
                if (!nums.Contains(i))
                {
                    return i;
                }
            }
            return -1; // Just in case nothing is missing
        }
    }
}
