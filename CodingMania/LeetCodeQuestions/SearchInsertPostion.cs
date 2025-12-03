using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace CodingMania.LeetCodeQuestions
{
//    Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.

//You must write an algorithm with O(log n) runtime complexity.



//Example 1:

//Input: nums = [1, 3, 5, 6], target = 5
//Output: 2
//Example 2:

//Input: nums = [1, 3, 5, 6], target = 2
//Output: 1
//Example 3:

//Input: nums = [1, 3, 5, 6], target = 7
//Output: 4



//Constraints:

//1 <= nums.length <= 104
//-104 <= nums[i] <= 104
//nums contains distinct values sorted in ascending order.
//-104 <= target <= 104
    internal class SearchInsertPostion
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid; // Target found
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1; // Move right
                }
                else
                {
                    right = mid - 1; // Move left
                }
            }

            return left; // Return the insertion index
        }
    }
}

//Here is the C# implementation of the solution for the problem using Binary Search to achieve 
//int[] nums = { 1, 3, 5, 6 };
//int target = 5;

//Solution solution = new Solution();
//int result = solution.SearchInsert(nums, target);

//// Output: 2
//Console.WriteLine(result);
