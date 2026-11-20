using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.SlidingWindow
{
    /*
      this is the Variable- Window template Sliding Window
     */
    /*
     
     
Code
Testcase
Test Result
Test Result
3. Longest Substring Without Repeating Characters
Medium
Topics
premium lock icon
Companies
Hint
Given a string s, find the length of the longest substring without duplicate characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 105
s consists of English letters, digits, symbols and spaces
     */
    class _3_LongestSubstringWithoutRepeating_Characters
    {
        //Given abcabcbb - "abc" has lenght 3. Any longer stretch would repeat a letter
        //bbbb - Every Strech longer than 1 repeats "b", so the answer is 1
        //pwwkew - "wke" has length 3 
        // Note Pwke does not Count - A substring must be contigous with no Skipping, in Pwkw skips the Second w, whick makes it a subsequecne

        //key Insight keep a window[left, Right] that always Contain unique Characters
        //Expand: Move right forweard to add the nect Character
        //If that Characteer is already in the window- the Window is Invalid. Shrink from the left, Removing characters until the duplicate is gone
        //after each step the Window i valid again, So its Length (right - left +1) is a candidate answer
        //Use HashSet hold the characterr currrently in the Window

        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> window = new HashSet<char>();
            int left = 0;
            int longest = 0;

            for (int right = 1;  right < s.Length;  right++)
            {
                // "abcd" then you see b  , the current window becomes abcdb
                //b is Repeated, in abcd - length is 4
                //abcdb becomes Inavliad 
                // remove a, remove b, so the new Window becomes
                //cdb, who knows you can see e f in thr Front and it becomes
                //cbdef = 5

                //Shrink Until s[right] is not longer a 
                while (window.Contains(s[right]))
                {
                    window.Remove(s[left]);
                    //Push the left Indesx to this Point of Validity 
                    left++;
                }

                window.Add(s[right]);  //Expand
                //right-left +1 is the windows length both ends are inclusive
                longest = Math.Max(longest, right - left + 1); //reecord
            }
            return longest;
        }


        /*
          The Shrinking part is a bit Confusing , you are checking if right is in the Window, then you will Remove s[left], then increase left++;
         */
    }
}
