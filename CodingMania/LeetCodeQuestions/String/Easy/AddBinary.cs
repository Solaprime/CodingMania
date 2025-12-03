using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    class AddBinary
    {
        /*
         // expression ? true : false
        bool correct = true;
		 int Number = 292;
		//int pointsEarned = correct ? 10 : 0;
		int pointsEarned = Number >= 1000 ? 10 : 0;


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
        public string AddBinarySolution(string a, string b)
        {
            //We use a stringBuilder Cause Inserting Character is easier
            StringBuilder result = new StringBuilder();

            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;

            //Continue Looping While there are Characters in either a or b 
            //or there is a leftover Carry
            while (i >= 0 || j >= 0 || carry > 0)
            {
                int bitA = i >= 0 ? a[i] - '0' : 0;
                int bitB = j >= 0 ? b[j] - '0' : 0;

                int sum = bitA + bitB + carry;
                result.Insert(0, (sum % 2).ToString());
                carry = sum / 2;

                i--;
                j--;
            }

            return result.ToString();
        }
    }
}


//Great question — you're absolutely right to dig into this, and it's a common point of confusion!

//Let’s break down this part clearly:

//💡 a[i] - '0': Why does it return an int?
//In C#, characters are internally represented by their Unicode (ASCII) values, which are actually just integers.

//'0' = ASCII code 48

//'1' = ASCII code 49

//'2' = ASCII code 50
//So if a[i] = '1', then:So if a[i] = '1', then:
//So if a[i] = '1', then:
//It’s a clever and efficient trick to convert a char digit (like '1') to an int (like 1):


/*
 uSING tRYpARSE

ublic string AddBinarySolution(string a, string b)
{
    StringBuilder result = new StringBuilder();

    int i = a.Length - 1;
    int j = b.Length - 1;
    int carry = 0;

    while (i >= 0 || j >= 0 || carry > 0)
    {
        int bitA = 0, bitB = 0;

        // Convert a[i] to int using TryParse
        if (i >= 0 && !int.TryParse(a[i].ToString(), out bitA))
        {
            throw new FormatException($"Invalid character '{a[i]}' in string a.");
        }

        // Convert b[j] to int using TryParse
        if (j >= 0 && !int.TryParse(b[j].ToString(), out bitB))
        {
            throw new FormatException($"Invalid character '{b[j]}' in string b.");
        }

        int sum = bitA + bitB + carry;
        result.Insert(0, (sum % 2).ToString());
        carry = sum / 2;

        i--;
        j--;
    }

    return result.ToString();
}
 
 */