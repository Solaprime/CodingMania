using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    internal class GreatestCommonDivisorOfStrings
    {
        public string GreatestCommonDivisor(string word1, string word2)
        {
            if (word1.Length == word2.Length) {
                return "Exact Number";
            }

            //Check from the First Index 
            if (word1.Contains(word2))
            {
                return word2;
            };

            return word1;
        }


        //ChatGpt Solution
        public string GcdOfStrings(string str1, string str2)
        {
            // Check if concatenating str1 + str2 equals str2 + str1
            // If they don't match, there is no common divisor
            if ((str1 + str2) != (str2 + str1))
            {
                return "";
            }

            // Get the GCD of the lengths of str1 and str2
            int gcdLength = GCD(str1.Length, str2.Length);

            // Return the substring of str1 from 0 to gcdLength, as it will be the largest common divisor
            return str1.Substring(0, gcdLength);
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
