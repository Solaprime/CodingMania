using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
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
The input is generated such that a majority element will exist in the array.
 

Follow-up: Could you solve the problem in linear time and in O(1) space?
     
     
     */
    class _169_MajarityElement
    {

        /*
         * The best solution for this question is Boyer–Moore Voting Algorithm
         It solves the problem in linear time, \(O(n)\), and constant extra space, \(O(1)\), satisfying the follow-up


          You are given an array of integers, and you need to return the number that appears more than half the time.

        nums = [3, 2, 3]
         array contains = 3 elements
          The majority element must appear more than 1 time. Since 3 appears twice, the answer is 3.

          nums = [2, 2, 1, 1, 1, 2, 2]
        There are 7 elements, so the majority element must appear more than 3 times.
            - 2 appears 4 times.
           - 1 appears 3 times.


        Note - The question Guarantees that a majority element alwasy exist
        you do not need to handle an array with no Majoruty Element
         
         */

        public int MajorityElement(int[] nums)
        {
            //So the annotaton is if you have 
            // 5 Element in an array, and one of the Element
            //Occurs 3 times that means  evenetualy the element will have 
            //count     1  Remaining 
            int candidate = 0;
            int count = 0;

            foreach (int num in nums)
            {

                //That means Assign the CurrenT Candidate to a new Num
                if (count ==0 )
                {
                    candidate = num;
                }

                if (num == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
            return candidate;
        }


        //Using Dictionary Solution Here
        //but the Dictionary  Requires Extra Space  Here

        public int MajorityElementUsingDictionary(int[] nums)
        {
            Dictionary<int, int> source = new Dictionary<int, int>();

            foreach (int num in nums)
            {

                if(!source.ContainsKey(num))
                {
                    source[num] = 0;
                }

                source[num]++;

                if (source[num] >  nums.Length/2)
                {
                    return source[num];
                }
            }

            return -1; //Unknown Error Flow here
        }
    }
}
