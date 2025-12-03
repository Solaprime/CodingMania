using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CodingMania.LeetCodeQuestions
{
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
    internal class PlusOne
    {

        public int[] PlusOneFlow(int[] digits)
        {
            // Start from the last digit of the array
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                // If the current digit is less than 9, simply increment it and return
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                // If the digit is 9, set it to 0 (carry over to the next digit)
                digits[i] = 0;
            }

            // If all digits were 9, we need to add an extra digit at the beginning
            // Example: [9, 9, 9] becomes [1, 0, 0, 0]
            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }
    }
}


/*
 int[] digits = {1, 2, 3};
Solution solution = new Solution();
int[] result = solution.PlusOne(digits);

// Output: [1, 2, 4]
Console.WriteLine(string.Join(",", result));

 */