using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.BinarySearch
{
    /*
       
Code
Testcase
Test Result
Test Result
875. Koko Eating Bananas
Medium
Topics
premium lock icon
Companies
Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas. The guards have gone and will come back in h hours.

Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile of bananas and eats k bananas from that pile. If the pile has less than k bananas, she eats all of them instead and will not eat any more bananas during this hour.

Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.

Return the minimum integer k such that she can eat all the bananas within h hours.

 

Example 1:

Input: piles = [3,6,7,11], h = 8
Output: 4
Example 2:

Input: piles = [30,11,23,4,20], h = 5
Output: 30
Example 3:

Input: piles = [30,11,23,4,20], h = 6
Output: 23
 

Constraints:

1 <= piles.length <= 104
piles.length <= h <= 109
1 <= piles[i] <= 109

     */
    public class _875_KokoEatingBananas
    {
        // So this Binary search we are not Searching throuhg a list of array, We are Searching to a list
        //of Possible answer-- This Questions are called Binary Search on the Answer
        //Some binary Search we are Searching for a number inside an array

        /*
         
         Input: piles = [3,6,7,11], h = 8
          Output: 4

        You  have 8 hours to finish all the bananas, SSo you need to Chose an Eating Speed K that willl represnet how
        many bananas She can eat per Hour
        //Look at the lIST YOU CAN EAT 11 bANANAES PER hOURS, 10, 9,8,7,6,5,4 
           3 BANANAS USING 4 - 1HRS
           6 BANANAS USING 4 - 2HRS
           7 BANANAS USING 4 - 2HRS
           11 BANANAS USING 4 - 3HRS
         3+6+7+11=27 
        lOOK AT THE first pile the 3 Even though 4 us greater than 3, after eating all the 3 Banana for 3 Hrs the remaining
        1hr is gone

        The question we are tasked to find the Minimum posissble sped

        intuitevely the Minimum Speed is --1
        and the Maximum speedd is 11 --the maximum element in the araay

        total is 27 = 3+6+7+11
        if you do K =1 = >>>> 27hrs
        if you do K =2 = >>>> 15hrs
        if you do K = 4 = >>>> 8rs
        if you do K = 5 = >>>> 8rs
        if you do K = = 8 >>>> 5rs
        if you do K = = 11 >>>> 4rs

        Speed:       1  2  3  4  5  6  7  8  9  10  11
Can finish:          N  N  N  Y  Y  Y  Y  Y  Y   Y   Y
         */


        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1;
            int right = piles.Max();

            while (left < right)
            {
                int mid = left +(right - left)/2;

                long hours = 0;

                foreach (int pile in piles)
                {
                    //We have chosen Mid iterate thoruhg the Piles and see the Hours 
                    //You can alsoe Use
                    //hours += (long)Math.Ceiling((double)pile / mid);

                    /*
                        [a/b] = (a+b-1)/b
                     
                     */
                    hours += (pile + (long)mid - 1) / mid;
                }

                // Suppose Koko can finish in 7 hours, but she has 8 hours available.
                /*
                 That means her current speed is sufficient.
However, she wants to eat as slowly as possible, so we should investigate whether a smaller
speed can also work. We use:
                 
                 */
                if (hours <= h)
                {
                    //Speed a sufficent try a slower speed
                    //Mid might already be the Minimum valid Speed 
                    //So we use right = mid . Becuase mid might alrady be the minimum valid speed   
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }


            return left;
        }
    }
}
