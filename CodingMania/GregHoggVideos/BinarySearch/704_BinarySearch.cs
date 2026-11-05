using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.BinarySearch
{
    /*
     704. Binary Search
Easy
Topics
premium lock icon
Companies
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [-1,0,3,5,9,12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4
Example 2:

Input: nums = [-1,0,3,5,9,12], target = 2
Output: -1
Explanation: 2 does not exist in nums so return -1
 

Constraints:

1 <= nums.length <= 104
-104 < nums[i], target < 104
All the integers in nums are unique.
nums is sorted in ascending order.
     
     */
    class _704_BinarySearch
    {
        /*
         The array is already Sorted in ascending Order
        instead of Checking Every Element from left to right, we look at the Middle Element,
        so we maitain 3 indesx left, Right and Mid
        left -the First Index in our Current Sarch AREA
        Right - the Last Index in our current search area
        mid - the Midddle Index

        We then compare nums[mid] with the target.

There are three possible outcomes:
1. If nums[mid] == target, we have found it. Return mid.
2. If nums[mid] < target, search the right half.
3. If nums[mid] > target, search the left half.
We continue until left becomes greater than right.
         */

        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                /*
                 * this is the range of int
                 -2,147,483,648 and 2,147,483,647

                if left = 2_000_000_000; right = 2_100_000_000;
                2,000,000,000 + 2,100,000,000
= 4,100,000,000
                this value exceeds the Limit of an int

                but if 
                mid = 2,000,000,000
    + (2,100,000,000 - 2,000,000,000) / 2;

mid = 2,000,000,000 + 50,000,000;

mid = 2,050,000,000; 
                 */
                int mid = left + (right - left) / 2;

                //  int mid2 = (left + right) / 2;  //this ilso works but it can Cuase Integer overFlow
                if (nums[mid]== target )
                {
                    return mid;
                }

                else if (nums[mid] <= target)
                {
                    //No need to start on the Mid itself shit it +1
                    left = mid + 1;
                }
                else
                {
                    //shift the Middle -1
                    right = mid - 1;
                }

            }
            return -1;
        }
    }
}
