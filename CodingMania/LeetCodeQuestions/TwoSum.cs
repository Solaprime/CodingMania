using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    public class TwoSum
    {

        //mY SOLUTION fLOW
        //My Solution WOrked for these TestCase Scenario Here 
        public List<int> GetTwoSun(List<int> list, int sumedNumber)
        {
            List<int> result = new List<int>();
            int twoBackToBackNumber;
            for (int i = 0; i < list.Count;  i++)
            {
                twoBackToBackNumber  = list[i] + list[i+1];
                if (twoBackToBackNumber == sumedNumber)
                {
                    result.Add(i);
                    result.Add(i + 1);
                    break;
                }
            }
           if (result.Count != 0)
           {
               foreach (int i in result)
                {
                    Console.Write(i);
                    Console.Write(",");
                   
                }
                Console.WriteLine("eND");
            }

            return result;
            
        }


        //ChatGpt Solution
        public int[] TwoSumgpt(int[] nums, int target)
        {
            // Dictionary to store the difference and its index
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // Check if the complement exists in the dictionary
                if (map.ContainsKey(complement))
                {
                    // Return the indices of the two numbers
                    return new int[] { map[complement], i };
                }

                // Add the current number and its index to the dictionary
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }

            // If no solution is found (though the problem states there's always one)
            throw new ArgumentException("No two sum solution");
        }

    }
}

//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

 

//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3,2,4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3,3], target = 6
//Output: [0,1]
 

//Constraints:

//2 <= nums.length <= 104
//-109 <= nums[i] <= 109
//-109 <= target <= 109
//Only one valid answer exists.
 

//Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.

 

//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3,2,4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3,3], target = 6
//Output: [0,1]
 

//Constraints:

//2 <= nums.length <= 104
//-109 <= nums[i] <= 109
//-109 <= target <= 109
//Only one valid answer exists.
 

//Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
