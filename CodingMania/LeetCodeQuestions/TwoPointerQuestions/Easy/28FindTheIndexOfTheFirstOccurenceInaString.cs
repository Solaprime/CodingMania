using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.TwoPointerQuestions.Easy
{
    /*
     Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

Constraints:

1 <= haystack.length, needle.length <= 104
haystack and needle consist of only lowercase English characters.
     */
    public class _28FindTheIndexOfTheFirstOccurenceInaString
    {

        /// <summary>
        /// Using Standard 2 pointer Solution
        /// </summary>
        /// <param name="hayStack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string hayStack, string needle)
        {
            //Haystack-- the large string
            //needle - the Substring you are searching for

            //Return the Index  of the First occurence of needle
            //or -1 if  not Found

            //Two Pointer cause you use pointer i- moves through HayStack
            //pointer j moves through needle

            //We try to Match characters one by one
            //If characters match advance both Pointers
            //If characters mismatch reset j=0 and move i to the next starting position
            // this is the classis naive 2-pointer Substring SeaRCH
            int lengthHayStack = hayStack.Length;
            int lengthNeedle = needle.Length;



            for (int i = 0; i < lengthHayStack- lengthNeedle; i++)
            {
                int j = 0;


                //try to match needle starting at position i
                //haystack[] == needle[j]
                //haystack[i+j]
                //if outer llp is i, then add the Current posion of J to it
                //i=0 and J==0 = 0+0
                //i=0 and J==1 = 0+1
                //i=0 and J==2 = 0+2

                //i=1 and J==0 = 1+0
                //i=1 and J==1 = 1+1
                //i=1 and J==2 = 1L+2
                //j <M
                //Note J is Zero Indexed
                while (j < lengthNeedle && hayStack[i + j] == needle[j])
                {
                    j++;
                }

                //When you comeout of the Loop above
                // andif j reached needle -> Full match
                if (j == lengthNeedle)
                {
                    return i;
                }

            }

            return -1;



        }


        //Using KMP
        //Knutth-Morris-Pratt Pattern
        /// <summary>
        /// Downside of Traditonal Pointers restart from scrath when a mismatch  happens
        /// KMP does not restart Completely, Instead it remembers how much of the pattern(needle) has already matched using a table called
        /// LPS(longest prefix Suffix) array
        /// If a mismatch happens at needle[j], where should I jump next, KMP answers that Question
        /// This avoid rechecking Characters
        /// </summary>
        /// <param name="hayStack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrUsingKMp(string hayStack, string needle)
        {

        }

    }
}
