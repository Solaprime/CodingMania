using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.ArrayQuestions.Easy
{
    /*
     Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
     */
    public class _1TwoSum
    {
        //Optimized approach with HashMap

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                
                if (!map.ContainsKey(nums[i]))
                {
                    //sAVE THAT NUMBER and it Index in the Dictionary
                    map[nums[i]] = i;
                }

            }
            return null;
        }

        //✅ Brute Force(O(n²)):
        public int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int J = i+1; J < nums.Length; J++)
                {
                    if (nums[i] + nums[J] == target)
                    {
                        return new int[] { i, J };
                    }
                }
            }
            return null;
        }

        //My Solution 
        //It is Wrong,  my solution only assumes the Two Numbers are Side by Side
        //i + (i+1), ehat if the Two Numbers are i are i +2
        public  int[] TwoSumSolaSolution(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {

                if (target == nums[i] + nums[i + 1])
                {
                    int[] result = new int[] { i, i + 1 };
                    return result;
                }

            }
            return null;
        }
    }
}
