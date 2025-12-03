using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     
Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

 

Example 1:

Input: s = "leetcode"

Output: 0

Explanation:

The character 'l' at index 0 is the first character that does not occur at any other index.

Example 2:

Input: s = "loveleetcode"

Output: 2

Example 3:

Input: s = "aabb"

Output: -1

 

Constraints:

1 <= s.length <= 105
s consists of only lowercase English letters.
     */
    class FirstUniqueCharacterOfaString
    {
        public int FirstUniqChar(string s)
        {
            //You're creating an array of 26 integers to count how many times each letter (a to z) appears.
            //Recall we have 26 Letters in English
            //Frequency[0] represent 'a',
            //Frequency[1] represnet 'b'
            //Frequency[25] represnet 'z'
            int[] frequency = new int[26]; // To store count of each character

            // First pass: count the frequency of each character
            foreach (char c in s)
            {
                /* For every character c in the string s, we increment
                 its count in the freuency array
                   
                c - 'a' = 2  // because ASCII('c') - ASCII('a') = 99 - 97 = 2


                So you're updating frequency[2]++.
                 */
                frequency[c - 'a']++;
            }

            // Second pass: find the first character with frequency 1
            /*
             
             p, we check every character in the original string again — in the original order — to see which character appears exactly once.
            
             If the character at index i in the string appears exactly once in the whole string, then that is the first unique character — so return its index.



            | Character | Frequency |
| --------- | --------- |
| l         | 2         |
| o         | 2         |
| v         | 1 ✅       |
| e         | 4         |
| t         | 1         |
| c         | 1         |
| d         | 1         |

             */
            for (int i = 0; i < s.Length; i++)
            {
                if (frequency[s[i] - 'a'] == 1)
                    return i;
            }

            return -1;
        }
    }
}

/*
 Input: "leetcode"
         |
         l = 1 (only one occurrence, and it's the first unique)

Output: 0

Input: "loveleetcode"
               ^
               v
         l=2, o=2, v=1 ← first unique at index 2

Output: 2


 
 
 */