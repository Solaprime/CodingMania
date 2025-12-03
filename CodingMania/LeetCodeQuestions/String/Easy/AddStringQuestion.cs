using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.

You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.

 

Example 1:

Input: num1 = "11", num2 = "123"
Output: "134"
Example 2:

Input: num1 = "456", num2 = "77"
Output: "533"
Example 3:

Input: num1 = "0", num2 = "0"
Output: "0"
 

Constraints:

1 <= num1.length, num2.length <= 104
num1 and num2 consist of only digits.
num1 and num2 don't have any leading zeros except for the zero itself.
     */
    class AddStringQuestion
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder result = new StringBuilder();

            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int carry = 0;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                // Get the current digits from both strings
                int digit1 = i >= 0 ? num1[i] - '0' : 0;
                int digit2 = j >= 0 ? num2[j] - '0' : 0;

                // Calculate the sum of the current digits and the carry
                int sum = digit1 + digit2 + carry;

                // Add the current digit to the result (sum % 10 gives the digit)
                result.Insert(0, (sum % 10).ToString());

                // Update the carry for the next iteration (sum / 10 gives the carry)
                carry = sum / 10;

                // Move to the next digit in each string
                i--;
                j--;
            }

            return result.ToString();
        }
    }
}
