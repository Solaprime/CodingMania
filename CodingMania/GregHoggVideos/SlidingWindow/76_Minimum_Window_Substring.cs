using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.SlidingWindow
{
    /*
     76. Minimum Window Substring
Hard
Topics
premium lock icon
Companies
Hint
Given two strings s and t of lengths m and n respectively, return the minimum window substring of s such that every character in t (including duplicates) is included in the window. If there is no such substring, return the empty string "".

The testcases will be generated such that the answer is unique.

 

Example 1:

Input: s = "ADOBECODEBANC", t = "ABC"
Output: "BANC"
Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
Example 2:

Input: s = "a", t = "a"
Output: "a"
Explanation: The entire string s is the minimum window.
Example 3:

Input: s = "a", t = "aa"
Output: ""
Explanation: Both 'a's from t must be included in the window.
Since the largest window of s only has one 'a', return empty string.
 

Constraints:

m == s.length
n == t.length
1 <= m, n <= 105
s and t consist of uppercase and lowercase English letters.
 
     
     */
    /*
     
       So you need  the Unique Element  you are Loking for 
    and also the Count since Duplicate is allowed
     */
    public class _76_Minimum_Window_Substring
    {

<<<<<<< HEAD
        public string MinWindow(string s, string t)
        {
            //Check  if t is longer tan s, no window of s can posibbly contain all of t
            //The main Loop would also return "" here
            if (t.Length > s.Length)
            {
                return "";
            }
            //Why is this new int[128] flow

            //What  t needs since you are looking for t in S
            //This Count t's characters It uses 128 Slots, not 36, because the strings can mix Uppercaose and Lowecase letters
            int[] need = new int[128];
            foreach (char c in t)
            {
                need[c]++;

            }


            //Get distinct characters needed 
            //For t="AABC" required is 3 (A,B,C), even though t has 4 letters 
            int required = 0;
            foreach (int n  in need)
            {
                if(n >0)
                {
                    required++;
                }
            }

            //What the Window has
            int[] window = new int[128];
            int formed = 0;   //Distinct characters currently satisified

            int left = 0;
            int bestLen = int.MaxValue;
            int bestStart = 0;

            for (int right = 0; right < s.Length; right++)
            {
                //1.) Expand: add s[right]
                char c = s[right];

                window[c]++;

                //Check  if it is the need and you need it 
                if (need[c] > 0 && window[c] == need[c])
                {
                    formed++;
                }


                //While valiD: Record, then try Shrinking
                while (formed == required)
                {
                    //if rigth -left+1; 
                    if(right -left +1 < bestLen)
                    {
                        //assign the bestLen to the Value
                        bestLen = right - left + 1;
                        //ASSIGN left to bestStart
                        bestStart = left;
                    }

                    char outChar = s[left];
                    window[outChar]--;
                    if (need[outChar] > 0 && window[outChar] < need[outChar])
                    {
                        formed--;
                    }

                    left++;

                }
            }

            return bestLen == int.MaxValue ? "" : s.Substring(bestStart, bestLen);


         }  
=======
        //public string MinWindow(string s, string t)
        //{
        //    //Check 
        //    if (t.Length > s.Length)
        //    {
        //        return "";
        //    }

        //    //What  t needs since you are looking for t in S
        //    int[] need = new int[28];
        //    foreach (char c in t)
        //    {
        //        need[c]++;

        //    }
        // }
>>>>>>> 7fe89ec514cc0fff69e99df629b953bfcb67d9a3
    }
}
