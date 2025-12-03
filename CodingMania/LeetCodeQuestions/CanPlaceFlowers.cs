using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    internal class CanPlaceFlowers
    {
        public bool CanPlaceFlowersMethod(int[] flowerbed, int n)
        {
            int count = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                // Check if the current plot is empty (0)
                if (flowerbed[i] == 0)
                {
                    // Check the previous and next plots (if they exist)
                    bool isPrevEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                    bool isNextEmpty = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    // If both are empty, we can plant a flower here
                    if (isPrevEmpty && isNextEmpty)
                    {
                        flowerbed[i] = 1; // Plant the flower
                        count++; // Increment the count of flowers planted

                        // If we have already planted enough flowers, return true
                        if (count >= n)
                        {
                            return true;
                        }
                    }
                }
            }

            // If we exit the loop and haven't planted enough flowers, return false
            return count >= n;
        }
    }
}


//You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

//Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

 

//Example 1:

//Input: flowerbed = [1, 0, 0, 0, 1], n = 1
//Output: true
//Example 2:

//Input: flowerbed = [1, 0, 0, 0, 1], n = 2
//Output: false



//Constraints:

//1 <= flowerbed.length <= 2 * 104
//flowerbed[i] is 0 or 1.
//There are no two adjacent flowers in flowerbed.
//0 <= n <= flowerbed.length
