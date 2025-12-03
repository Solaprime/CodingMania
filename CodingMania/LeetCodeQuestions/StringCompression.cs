using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    internal class StringCompression
    {
        public int Compress(char[] chars)
        {
            int writeIndex = 0; // Index where we write in the array
            int readIndex = 0;  // Index for reading through the array

            while (readIndex < chars.Length)
            {
                char currentChar = chars[readIndex];
                int count = 0;

                // Count consecutive occurrences of the current character
                while (readIndex < chars.Length && chars[readIndex] == currentChar)
                {
                    count++;
                    readIndex++;
                }

                // Write the character to the array
                chars[writeIndex++] = currentChar;

                // If the count is greater than 1, write its digits to the array
                if (count > 1)
                {
                    foreach (char digit in count.ToString())
                    {
                        chars[writeIndex++] = digit;
                    }
                }
            }

            // Return the new length of the array
            return writeIndex;
        }
    }
}

//Given an array of characters chars, compress it using the following algorithm:

//Begin with an empty string s. For each group of consecutive repeating characters in chars:

//If the group's length is 1, append the character to s.
//Otherwise, append the character followed by the group's length.
//The compressed string s should not be returned separately, but instead, be stored in the input character array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.

//After you are done modifying the input array, return the new length of the array.

//You must write an algorithm that uses only constant extra space.

 

//Example 1:

//Input: chars = ["a","a","b","b","c","c","c"]
//Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
//Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
//Example 2:

//Input: chars = ["a"]
//Output: Return 1, and the first character of the input array should be: ["a"]
//Explanation: The only group is "a", which remains uncompressed since it's a single character.
//Example 3:

//Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
//Output: Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
//Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
 

//Constraints:

//1 <= chars.length <= 2000
//chars[i] is a lowercase English letter, uppercase English letter, digit, or symbol.


//Solve in C#Given an array of characters chars, compress it using the following algorithm:

//Begin with an empty string s. For each group of consecutive repeating characters in chars:

//If the group's length is 1, append the character to s.
//Otherwise, append the character followed by the group's length.
//The compressed string s should not be returned separately, but instead, be stored in the input character array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.

//After you are done modifying the input array, return the new length of the array.

//You must write an algorithm that uses only constant extra space.

 

//Example 1:

//Input: chars = ["a","a","b","b","c","c","c"]
//Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
//Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
//Example 2:

//Input: chars = ["a"]
//Output: Return 1, and the first character of the input array should be: ["a"]
//Explanation: The only group is "a", which remains uncompressed since it's a single character.
//Example 3:

//Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
//Output: Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
//Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
 

//Constraints:

//1 <= chars.length <= 2000
//chars[i] is a lowercase English letter, uppercase English letter, digit, or symbol.


//Solve in C#