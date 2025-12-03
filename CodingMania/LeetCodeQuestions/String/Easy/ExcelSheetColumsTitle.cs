using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     
     Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 

Example 1:

Input: columnNumber = 1
Output: "A"
Example 2:

Input: columnNumber = 28
Output: "AB"
Example 3:

Input: columnNumber = 701
Output: "ZY"
 

Constraints:

1 <= columnNumber <= 231 - 1
     
     
   
     */
    class ExcelSheetColumsTitle
    {
        public string ConvertToTitle(int columnNumber)
        {

            string result = "";

            while (columnNumber > 0)
            {
                /*
                 * 
               //0 to 26 will have 27 Items in it if you count zERO iNDEX
                      // 1-26 WILL hAVE 26 ITEMS
                      // 0 -25 wILL HAVE 26 iTEMS
                 
                 Because Excel column counts start from 1, not 0, but programming numbers usually start from 0.
                 This ensures 'A' corresponds to 0, 'B' to 1, ..., 'Z' to 25.
                 */
                columnNumber--; // Adjust because Excel is 1-indexed

                // Find the remainder after dividing by 26:
                //Remainder represents which letter to pick (0 for 'A', 25 for 'Z')

                // 2 % 26 will Return 2 Since 2 can not Divide 26
                //52 % 26 will return 0 Cause 52 / 26 is  2 remainder 0
                int remainder = columnNumber % 26;
                char currentChar = (char)(remainder + 'A');

                result = currentChar + result;
                columnNumber /= 26;
            }

            return result;
        }
    }
}


/*
 
  columnNumber /= 26;
 
 We're converting a number into an Excel column title, which is like converting a number to base-26, but with a twist:

Excel uses letters A–Z instead of digits 0–25.

It's 1-indexed, not 0-indexed.

if coulumnNumber = 701
columnNumber--;          // 701 becomes 700
remainder = 700 % 26;    // 700 % 26 = 24
currentChar = (char)(24 + 'A'); // 24 + 65 = 89 → 'Y'
So the last letter is 'Y'.
2. Prepare for the next letter:
columnNumber /= 26;      // 700 / 26 = 26

This step moves to the next digit (just like shifting left in base-10 or base-2), preparing to find the next letter to the left.
You keep doing this until columnNumber is zero.


In C#, when you divide two integers, the result is also an integer — not a floating-point number — even if the result is mathematically a fraction.
22/26 gives 0 

 */




/*
 
 char currentChar = (char)(remainder + 'A');


In C#, characters are backed by their ASCII (or Unicode) values.

'A' has an ASCII value of 65

'B' is 66
'C' is 67
'Z' is 90

int result = remainder + 65; // if remainder is 0, result = 65 → 'A'
 */