using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodingMania.LeetCodeQuestions.Array.Easy
{
    internal class PlusOne
    {
        public int[] PlusOneFlow(int[] digits)
        {
            int n = digits.Length;

            // Traverse the array from the last digit to the first
            for (int i = n - 1; i >= 0; i--)
            {
                // If the current digit is less than 9, increment it and return the array
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                // Otherwise, set the current digit to 0 and continue to the next digit
                digits[i] = 0;
            }

            // If we exit the loop, it means all the digits were 9 (e.g., 999 -> 1000)
            int[] result = new int[n + 1];
            result[0] = 1; // The first digit is 1, all others are 0 by default
            return result;
        }
    }

    //Plus One Floe

//    You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

//Increment the large integer by one and return the resulting array of digits.
//    Example 1:

//Input: digits = [1, 2, 3]
//Output: [1, 2, 4]
//    Explanation: The array represents the integer 123.
//Incrementing by one gives 123 + 1 = 124.
//Thus, the result should be [1, 2, 4].
//Example 2:

//Input: digits = [4, 3, 2, 1]
//Output: [4, 3, 2, 2]
//Explanation: The array represents the integer 4321.
//Incrementing by one gives 4321 + 1 = 4322.
//Thus, the result should be [4, 3, 2, 2].
//Example 3:

//Input: digits = [9]
//Output: [1, 0]
//Explanation: The array represents the integer 9.
//Incrementing by one gives 9 + 1 = 10.
//Thus, the result should be [1, 0].



//Constraints:

//1 <= digits.length <= 100
//0 <= digits[i] <= 9
//digits does not contain any leading 0's.
}
