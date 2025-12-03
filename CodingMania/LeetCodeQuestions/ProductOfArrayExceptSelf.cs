using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    internal class ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            // Step 1: Calculate the prefix product
            answer[0] = 1; // No elements before the first one
            for (int i = 1; i < n; i++)
            {
                answer[i] = answer[i - 1] * nums[i - 1];
            }

            // Step 2: Calculate the suffix product and update the result
            int suffix = 1; // No elements after the last one
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= suffix;
                suffix *= nums[i];
            }

            return answer;
        }      
    }
}

//Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

//You must write an algorithm that runs in O(n) time and without using the division operation.

 

//Example 1:

//Input: nums = [1,2,3,4]
//Output: [24,12,8,6]
//Example 2:

//Input: nums = [-1,1,0,-3,3]
//Output: [0,0,9,0,0]
 

//Constraints:

//2 <= nums.length <= 105
//-30 <= nums[i] <= 30
//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

//You must write an algorithm that runs in O(n) time and without using the division operation.

 

//Example 1:

//Input: nums = [1,2,3,4]
//Output: [24,12,8,6]
//Example 2:

//Input: nums = [-1,1,0,-3,3]
//Output: [0,0,9,0,0]
 

//Constraints:

//2 <= nums.length <= 105
//-30 <= nums[i] <= 30
//The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
