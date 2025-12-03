using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    /*
        Given two binary strings a and b, return their sum as a binary string.



 Example 1:

 Input: a = "11", b = "1"
 Output: "100"
 Example 2:

 Input: a = "1010", b = "1011"
 Output: "10101"


 Constraints:

 1 <= a.length, b.length <= 104
 a and b consist only of '0' or '1' characters.
 Each string does not contain leading zeros except for the zero itself.
     */
    internal class AddTwoBinaryNumbersandReturnTheSumasBinary
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();

            int i = a.Length - 1; // Pointer for string a
            int j = b.Length - 1; // Pointer for string b
            int carry = 0;        // Variable to hold the carry value

            // Loop through the strings from the end to the beginning
            while (i >= 0 || j >= 0 || carry > 0)
            {
                int sum = carry; // Start with the carry from the previous operation

                // Add the corresponding digit from string a, if available
                if (i >= 0)
                {
                    sum += a[i] - '0'; // Convert the character to integer
                    i--;
                }

                // Add the corresponding digit from string b, if available
                if (j >= 0)
                {
                    sum += b[j] - '0'; // Convert the character to integer
                    j--;
                }

                // Append the current binary digit to the result (sum % 2)
                result.Append(sum % 2);

                // Calculate the carry for the next digit (sum / 2)
                carry = sum / 2;
            }

            // Reverse the result to get the correct binary sum
            return new string(result.ToString().Reverse().ToArray());
        }
    }
}
/*
 string a = "11";
string b = "1";

Solution solution = new Solution();
string result = solution.AddBinary(a, b);

// Output: "100"
Console.WriteLine(result);
 */