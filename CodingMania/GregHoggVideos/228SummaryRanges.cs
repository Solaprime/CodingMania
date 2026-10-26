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

            if (nums == null || nums.Length == 0)
            {
                return result;
            }

            int start = nums[0];

            //"Finish the current range if either I've reached the end OR
            //the current number is not consecutive with the previous number."

            //Note Instead of Using Zero_Index you are Using 1 index
            //Hence the needs for Substractions

            //We also Using = Becuase we need  a way to tell the algoritym we have
            //Gotten to the End of the array,Now Close the Final Range 
            // Why do we Have i =1 and not i=0, in the  Code we have nums[i-1]
            //Why do we Use <= We need a nums.Length cuase it is Used 
            for (int i = 1; i <= nums.Length; i++)
            {
                //The CHECK IF THE ARRAY IS STILL IN iTERATION Or  CHECKS IF YOU HAVE NOT FOUND
                //YOU End  Range, caouse 3 = 2+1 , s0 it Flow 2-3;
                //But if 3 != 1+1 and The

                //So a Range will Only close when 
                //- We reached the End of the array that is thier IS No Number
                //-the Sequece is broken, the Current Number is Not Consecutive with the Previous Number. Close the Current Range

                /*
                 IF
    we reached the end
OR
    the consecutive sequence has broken
THEN
    finish the current range
              //Note nums.Lenth is Put First, so that if We Index out of range It will not Crash, If the First Condition
                //Is true the Block Will end
                 
                nums[1] != nums[0] + 1
              1 != 0 + 1
                1 != 1
                nums[1] != nums[0] + 1
                False.

So we don't close the range.

Current range is still:
                0 -> ?

               4 != 2 + 1

                So we have discovered:

0,1,2 is finished.

                //Note Two Numbers are Consecutve if Current = previous + 1;
                //Use this Flow
                 */
                
                if (i == nums.Length || nums[i] != nums[i - 1] + 1)
                {
                    //Find the End, Using the Condtion of the Iteration which is i
                    int end = nums[i - 1];

                    //if it is a single Digit Just add the Single Digit 
                    if (start == end)
                    {
                        result.Add(start.ToString());
                    }
                    //It is not single digit then it is  a range Just add the Range to the array
                    else
                    {
                        result.Add($"{start}->{end}");
                    }

                    //Validated and Shift the Start, if and Only if the array is not Out of Bounds
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
