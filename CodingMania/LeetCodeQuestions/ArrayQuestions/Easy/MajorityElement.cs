using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.Array.Easy
{

    /*
      MAJORITY ELEMENT

     Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109
     */
    internal class MajorityElement
    {
        public int MajorityElementFlow(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            // Boyer-Moore Voting Algorithm
            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}


/*
 Explanation
Boyer-Moore Voting Algorithm:

The algorithm is based on the idea of maintaining a single candidate and a counter.
If the counter is zero, we select the current number as the new candidate.
If the current number matches the candidate, increment the counter; otherwise, decrement it.
By the end of the iteration, the candidate is guaranteed to be the majority element (since it appears more than 
⌊
𝑛
/
2
⌋
⌊n/2⌋ times).
 
 */
