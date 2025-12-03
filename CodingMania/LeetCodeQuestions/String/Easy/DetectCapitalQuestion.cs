using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     We define the usage of capitals in a word to be right when one of the following cases holds:

All letters in this word are capitals, like "USA".
All letters in this word are not capitals, like "leetcode".
Only the first letter in this word is capital, like "Google".
Given a string word, return true if the usage of capitals in it is right.

 

Example 1:

Input: word = "USA"
Output: true
Example 2:

Input: word = "FlaG"
Output: false
 

Constraints:

1 <= word.length <= 100
word consists of lowercase and uppercase English letters.
     */
    class DetectCapitalQuestion
    {
        //On Fiddle we  are getting Syntax Error
        //All does not Exist 
        public bool CorrectCapitalUsage(string word)
        {
            // Check if all letters are uppercase, all letters are lowercase, or
            // the first letter is uppercase and the rest are lowercase
            return word.All(char.IsUpper) || word.All(char.IsLower) ||
                   (char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower));


            // (char.IsUpper(word[0]) && word.Substring(1).All(char.IsLower) check if FirstWord IS uPPER AND THE REST IS lOWER

            //word.All(char.IsUpper) Check if all is Upper
            ////word.All(char.IsLower) check if all Is Lower
        }

        //All IS LINQ
        //So you need to Import LINQ Explicitly 


        //Another Solution
        public bool CorrectCapitalUsage2(string word)
        {
            bool allUpper = true, allLower = true, firstUpperRestLower = true;

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsUpper(word[i]))
                    allUpper = false;
                if (!char.IsLower(word[i]))
                    allLower = false;
                if (i == 0)
                {
                    if (!char.IsUpper(word[i]))
                        firstUpperRestLower = false;
                }
                else
                {
                    if (!char.IsLower(word[i]))
                        firstUpperRestLower = false;
                }
            }

            return allUpper || allLower || firstUpperRestLower;
        }
    }
}
