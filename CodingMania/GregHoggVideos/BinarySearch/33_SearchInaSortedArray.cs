using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.BinarySearch
{
    /*
     33. Search in Rotated Sorted Array
Medium
Topics
premium lock icon
Companies
There is an integer array nums sorted in ascending order (with distinct values).

Prior to being passed to your function, nums is possibly left rotated at an unknown index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be left rotated by 3 indices and become [4,5,6,7,0,1,2].

Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Example 2:

Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1
Example 3:

Input: nums = [1], target = 0
Output: -1
 

Constraints:

1 <= nums.length <= 5000
-104 <= nums[i] <= 104
All values of nums are unique.
nums is an ascending array that is possibly rotated.
-104 <= target <= 1
     
     */
    class _33_SearchInaSortedArray
    {
        /*
         So you will have at least one Sorted half
         [4, 5, 6, 7, 0, 1, 2]
        //You have two Sorted half [4,5,6,7] [0, 1, 2]
         
         */
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                //cHECK IF THE lEFT HALF IS SORTED
                //Two Possibilites Case 1 - Left half is Sorted
                /*
                   [4, 5, 6, 7, 0, 1, 2]
                   ↑        ↑           ↑
                  left     mid        right

                [4,5,6,7] - First Sorted Section
                [0,1,2]- Second Sorted Sections
                 
                 
                 */
                if (nums[left] <= nums[mid])
                {
                    //So we check if the target is Inside this Sorted Secction
                    //Check if target belongs to the Left
                    //Hence the reason for this And 

                    //Why is target < nums and Not target <= nums[mid] if targer == nums[mid] the First if Should should have Carried it 
                    if (target >= nums[left] && target < nums[mid])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                  
                //Left-Mid is not Sortd that means we 
                else
                {
                    //The Righg half is Sorteed
                    //Check if target belongs to the right half
                    if (target <= nums[right] && target > nums[mid])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }

                }
            }
            return -1;
        }
    }
}
/*
  Greg Hogg Concept will Will Partition the sORTED ARRAY INTO TWO, IND THE bOUNDARY POINT AND do an Indpenednt Search on the two
Half
 */
