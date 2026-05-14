using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*You are given a sorted unique integer array nums.

A range [a,b] is the set of all integers from a to b (inclusive).

Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

Each range [a,b] in the list should be output as:

"a->b" if a != b
"a" if a == b
 

Example 1:

Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"
Example 2:

Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"
 

Constraints:

0 <= nums.length <= 20
-231 <= nums[i] <= 231 - 1
All the values of nums are unique.
nums is sorted in ascending order.
 
*/
    class _228SummaryRanges
    {

        //Chat Gpt Solution not clear enough
        public List<string> SummaryRanges(int[] nums)
        {
            List<string> result = new List<string>();
            if (nums== null || nums.Length ==0)
            {
                return result;
            }
            int start = nums[0];
            //Use = so as to Index and Find the Last Range
            for (int i = 0; i <= nums.Length; i++)
            {
                //Only enter the IF blocks in 2 condition
                //If nums[i]!=nums[i-1] + 1
                //if i have gotten to the end of the Array
                if (i==nums.Length || nums[i] != nums[i-1] +1)
                {
                    int end = nums[i - 1];

                    if (start == end )
                    {
                        
                        result.Add(start.ToString());
                    }

                    else
                    {
                        result.Add($"{start}-{end}");
                    }
                    //Ensure you Don go Out of Bounds

                    if (i < nums.Length)
                    {
                        start = nums[i];
                    }
                }

            }

            return result;
        }
    }
}
