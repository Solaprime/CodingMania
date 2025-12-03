using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.InterviewQuestions
{
    public static class RomanToInt
    {
        //nIGERAIL SLACK gUY 2.6 mILLONS
        public static int RomanToIntFlow(string s)
        {
            //Intialize a Dictionary and save it in a Key VALUE pair
            //XiX
            Dictionary<char, int> romanValues = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int total = 0;
            int previousValue = 0;

            foreach (char c in s)
            {
                int currentValue = romanValues[c];
                if (currentValue > previousValue)
                {
                    //THESE sholbe b e wrong it is  meant  to be subtraqct 
                    total += currentValue - 2 * previousValue;
                }

                else
                {
                    total += currentValue;
                }
                previousValue = currentValue;
            }
            return total;
        }
    }
}

    ////My own Redo Flow Here
    //public static void GetIntegerFromRomanNumeral(string s)
    //    {
    //        Dictionary<char, int> romanConstant = new Dictionary<char, int>()
    //    {
    //        {'I', 1},
    //        {'V', 5},
    //        {'X', 10},
    //        {'L', 50},
    //        {'C', 100},
    //        {'D', 500},
    //        {'M', 1000},
    //    };
    //        int totalValue = 0;
    //        int currentValue = 0;
    //        int previousValue = 0;

    //        foreach (char c in s)
    //        {
    //            //Normal Flow
    //            currentValue = romanConstant[c];

    //            totalValue += currentValue;
    //            //Abnormal; Floe

    //            if (currentValue > previousValue)
    //            {
    //                totalValue -= 2 * previousValue;
    //            }
    //            previousValue = currentValue;
    //        }

    //        Console.WriteLine(totalValue);
    //    }
    //}
//Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

//Symbol       Value
//I             1
//V             5
//X             10
//L             50
//C             100
//D             500
//M             1000
//For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

//Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

//I can be placed before V (5) and X (10) to make 4 and 9.
//X can be placed before L (50) and C (100) to make 40 and 90.
//C can be placed before D (500) and M (1000) to make 400 and 900.
//Given a roman numeral, convert it to an integer.


//Example 1:

//Input: s = "III"
//Output: 3
//Explanation: III = 3.
//Example 2:

//Input: s = "LVIII"
//Output: 58
//Explanation: L = 50, V = 5, III = 3.
//Example 3:

//Input: s = "MCMXCIV"
//Output: 1994
//Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.


//give me the Solution to  these in C#