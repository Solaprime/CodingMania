using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     128. Longest Consecutive Sequence
Medium
Topics
premium lock icon
Companies
Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

You must write an algorithm that runs in O(n) time.

 

Example 1:

Input: nums = [100,4,200,1,3,2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:

Input: nums = [0,3,7,2,5,8,4,6,0,1]
Output: 9
Example 3:

Input: nums = [1,0,1,2]
Output: 3
 

Constraints:

0 <= nums.length <= 105
-109 <= nums[i] <= 109
     
     */
    internal class _128_LongestConsecutiveSequence
    {
       //The Question we want o(n) look Up so you can not sort
       //sort is o(n log n) so you can not Sort and LookUp, it is against
       //the Solution
        public int LongestConsecutive(int[] nums)
        {
            //HashSet is O(1) LOOK up
            HashSet<int> set = new HashSet<int>(nums);

            int longest = 0;

            //Iterate on the Set 
            foreach (int num in set)
            {
                //Only Start if this is the Begining of a sequence
                //How do we know tbis is the begining of a set
                // 5,6,7
                //From above 6-1=5, so 6 is not the beginning of the Set, since 
                //5 exist in the set, Likewise 7 id not the beginning of the set 
                //since 6 is in the Set
                if (!set.Contains(num -1))
                {
                    int current = num;
                    int length = 1;


                    //To Prevent and Infinite Loop of 
                    //Contious check of 2+1 =3 
                    //and 3 is in the Lop the Lop becomes Infinite
                    while (set.Contains(current + 1))
                    {
                        //So increment Length and The Currebt Item 
                        current++;
                        length++;
                    }
                    //assign the Longest between longest and Length
                    longest= Math.Max(longest, length);
                }
            }

            return longest;
        }
    }
}
