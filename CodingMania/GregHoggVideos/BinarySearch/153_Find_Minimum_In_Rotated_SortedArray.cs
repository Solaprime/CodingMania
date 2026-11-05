using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodingMania.GregHoggVideos.BinarySearch
{
    /*
        153. Find Minimum in Rotated Sorted Array
Medium
Topics
premium lock icon
Companies
Hint
Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:

[4,5,6,7,0,1,2] if it was rotated 4 times.
[0,1,2,4,5,6,7] if it was rotated 7 times.
Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].

Given the sorted rotated array nums of unique elements, return the minimum element of this array.

You must write an algorithm that runs in O(log n) time.

 

Example 1:

Input: nums = [3,4,5,1,2]
Output: 1
Explanation: The original array was [1,2,3,4,5] rotated 3 times.
Example 2:

Input: nums = [4,5,6,7,0,1,2]
Output: 0
Explanation: The original array was [0,1,2,4,5,6,7] and it was rotated 4 times.
Example 3:

Input: nums = [11,13,15,17]
Output: 11
Explanation: The original array was [11,13,15,17] and it was rotated 4 times. 
 

Constraints:

n == nums.length
1 <= n <= 5000
-5000 <= nums[i] <= 5000
All the integers of nums are unique.
nums is sorted and rotated between 1 and n times.
     */
    class _153_Find_Minimum_In_Rotated_SortedArray
    {
        //Forget about the Rotated Part and Pretend We can do a binary Search
        //Not it is going to be Tricky Cause it has been Rotated
        //If you see Log N , most times na Binary Search Flow
        //This Varation needs the Lowest, So no need to do an Equal

        //We have a new Challenge, the array is Sorted but it has been rotated
        // [4, 5, 6, 7, 0, 1, 2]
        // So the array is nt Completely sorted anymore but it contains two individually
        //sorted Sections [4,5,6,7] and [0, 1, 2]

        //We can use Binary Search because of an Important property.
        //The minimum element is in the unsorted section, unless the current search range is already sorted.
        // We will compare the middle element with the rightmost element.
        // Why the rightmost elemen
        /*

        [4, 5, 6, 7, 0, 1, 2]
                ↑           ↑
               mid         right
                6           2

        6 > 2 so the Rotatation Point and THerFore the Minimust must be to the right ofMid
         */
        public int FindMin(int[]  nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            //We check if left < right ,not eqUALS tO
            /*
              we ae not Searching for a target that may be absent , We are narrowing th 
            Search range until only one element remains 
             when left ==right both Pointers identify the minimumu Element
            if left ==Roght the Loop terminate that Means both The right pointer and Left pointer have gotten the Same ELEMENT
            d
             */
            while (left < right)
            {
                int mid = left + (right - left) / 2;

                //
                if (nums[mid] > nums[right])
                {
                    left = mid + 1;
                }
                //why are we not Using   mid and Not Mid-1
                //Here we use Right = mid because the Middle element might actually be the Minimum, if we exclude we accidnetaully eliminate the answer
                else
                {
                    right = mid;
                }
            }
            //IF LEFT ==rIGHT The Loop terminates soleft and right are the Same Valye
            return nums[left];

        }
    }
    /*
     
     
     */
}
