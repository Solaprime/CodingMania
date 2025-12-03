using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
    /*
     Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.

 

Example 1:

Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]
Example 2:

Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]
 

Constraints:

1 <= s.length <= 105
s[i] is a printable ascii character.





  
     */
    class ReverseString
    {
        public void ReverseStringMethod(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // Swap characters
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;

                left++;
                right--;
            }
        }
    }
}
/*
 
 
   Your task is to reverse the array in-place, which means:

You cannot use extra memory (no new arrays).

You must modify the original array s directly.

Use only O(1) extra space (constant memory).

    We use the two-pointer technique:


One pointer starts at the beginning (left)

The other pointer starts at the end (right)

Swap characters at left and right

Move left forward, right backward

Continue until left >= right



//My Personal Solution wrong Though.. Very Wrong\]

public void ReverseString(char[] input)
{
    int left = 0;
    int right = input.Length - 1;

    while (left < right)
    {
        input[left] = input[right];
        left++;
        right--;
    }
}
You're not swapping the characters — you're only copying the right character to the left.

So after one iteration, the original character at left is lost.


Input: ['h', 'e', 'l', 'l', 'o']

Let's walk through one iteration:

left = 0, right = 4

input[left] = input[right] → input[0] = 'o'

Now array becomes: ['o', 'e', 'l', 'l', 'o']

Notice: original 'h' is overwritten, and now we have two 'o's.

And there's no line that assigns 'h' back into the right position.

 Why Use a Temp Variable?
Because you want to swap values, not overwrite one.
 */