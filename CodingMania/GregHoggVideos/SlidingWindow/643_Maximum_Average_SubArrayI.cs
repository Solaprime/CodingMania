using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.SlidingWindow
{
    /*
     * Slidjng Windows has two Format Fixed Length an Varying Length this is an Example of a fixed Length
     
    643. Maximum Average Subarray I
Easy
Topics
premium lock icon
Companies
You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

 

Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
Example 2:

Input: nums = [5], k = 1
Output: 5.00000
 

Constraints:

n == nums.length
1 <= k <= n <= 105
-104 <= nums[i] <= 104
     */
    public class _643_Maximum_Average_SubArrayI
    {

        public double FindMaximumAverageSubArray(int[] nums, int k)
        {
            //Decalre the 
            int windowSum = 0;

            //Build the first Full Window 0 to k -1 
            for (int i = 0; i < k; i++)
            {
                windowSum += nums[i];
            }
            //Assign the First full window as the maxSum
            //maxSum starts at the First Windows Sum, not 0. The Numbers can be 
            //negative.  
            //Take example you assign maSsUMro 0, but after Calculatinf a window, it Summed to something
            //negative like - 5, assigning this to 0 will wrongly assign the value 0 and not -5
            int maxSum = windowSum;

            //Slide the Window one step at a time

            for (int right = k; right < nums.Length; right++)
            {

                windowSum  += nums[right]; //Element Entering  add to it 

                windowSum -= nums[right -k];  //Eleement Leaving, Subract from it 
                maxSum = Math.Max(maxSum, windowSum);

            }
            //Recall the range with the Highest Average will have the Highest Sum, so only calculate the highest
            //average when you have gotten the highest Sum
            return (double)maxSum/k ;
        }
    }
}

/*
  What gave me issues is how i was going to Iterate the rext of the ARRAY AFTER the
 */