using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    public static class PalindromeNumber
    {
        //  firstSolution1
      public static bool  CheckForPalindromeNumber(int firstNumber)
        {
            var revrseNumber = firstNumber.ToString().Reverse();
            var number = int.Parse(revrseNumber.ToString());
            if (firstNumber == number)
            { 
              return true;
            }
           return false;
        }
        //My Solution2
        public static bool CheckForPalindromeNumber2(int firstNumber)
        {
            // Convert the number to a string
            var originalNumberString = firstNumber.ToString();

            // Reverse the string using LINQ and create a new string
            var reversedNumberString = new string(originalNumberString.Reverse().ToArray());

            // Compare the original string and reversed string
            return originalNumberString == reversedNumberString;
        }

        //ChatGptSolution
        public static bool IsPalindrome(int x)
        {
            // Negative numbers and numbers ending in 0 (except 0 itself) are not palindromes
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int reversed = 0;
            int original = x;

            // Reverse the number
            while (x > 0)
            {
                int digit = x % 10; // Extract the last digit
                reversed = reversed * 10 + digit; // Append the digit to the reversed number
                x /= 10; // Remove the last digit
            }

            // A number is a palindrome if it is equal to its reversed form
            return original == reversed;
        }

    }
}
