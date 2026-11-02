using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
        42. Trapping Rain Water
Hard
Topics
premium lock icon
Companies
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

 

Example 1:


Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
Example 2:

Input: height = [4,2,0,3,2,5]
Output: 9
 

Constraints:

n == height.length
1 <= n <= 2 * 104
0 <= height[i] <= 105
     
     */
    public class _42_TrappingRainWater
    {
        /*
           The amount of water a position can hold depends on 
        the tallest bar to its left and the tallest bar to its right.


        Instead of calculating the tallest bar on the left and right for every position separately,
        we can solve the problem efficiently using two pointers.


        How does it work?
1. Start left at index 0.
2. Start right at the last index.
3. Track the tallest bars encountered from both directions.
4. Compare leftMax and rightMax.
5. Process the side with the smaller maximum because that side determines the water level.



        Why process the smaller side?

Suppose:
- leftMax = 3
- rightMax = 5
The water level at the left position cannot exceed 3, because the left side is the limiting boundary.

Therefore, if the current left bar is below leftMax, we can safely calculate its trapped water:
water = leftMax - height[left]

         
         */

        public int Trap(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;


            //  tallest bar to the left, including the current position.
            int leftMax = 0;

            //  rightMax = tallest bar to the right, including the current position.
            int rightMax = 0;

            // Total trapped water
            int water = 0;

            //It is not Compulsory you use for Loop, with this 2 pointer appraoch you will touch every Element
            //in the Array
            // height[i] = height of the current bar.
            while (left < right)
            {
                //THIS dETERMIne WHERE TO slide to Pointer,


                if (height[left] < height[right])
                {
                    //Change the Max , if heightLeft is greater than the Uurrent that Means we have a new
                    //Max 
                    if (height[left] >= leftMax)
                    {
                        leftMax = height[left];
                    }

                    //if Else, Do the Subtraction
                    else
                    {
                        //Add the Water  to the new SubTracted Flow
                        water += leftMax - height[left];
                    }
                    

                        left++;
                }

                else
                {
                    //Why does this have equals t0,
                    //If it is  Equals that means the Left and Right pOinter will not Increase again
                    //
                    if (height[right] >= rightMax)
                    { 
                      rightMax = height[right];
                    }

                    else
                    {
                        water += rightMax - height[right];
                    }
                        right--;
                }


            }

            return water;

        }
    }
}
