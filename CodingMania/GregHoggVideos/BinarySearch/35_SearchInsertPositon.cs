using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.BinarySearch
{
    /*
      35. Search Insert Position
Easy
Topics
premium lock icon
Companies
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104
     
     */
    class _35_SearchInsertPositon
    {

        //The Code is Super Identical to Leetcode to 704
        //the Only difference is the LAST line here youa re
        //returning left 
        public int SearchInsertPositon(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right -left)/2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            /*
             3. Why do we return left?
Remember how Binary Search works:
- If the middle element is smaller than the target, we move left forward.
- If the middle element is greater than the target, we move right backward.
- If they are equal, we return the middle index.
Now, imagine the target doesn't exist.

Eventually, the search boundaries will cross:
             */

            return left;
        }
    }
}
