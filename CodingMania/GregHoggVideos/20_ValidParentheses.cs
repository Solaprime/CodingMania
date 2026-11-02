using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
         /*
         Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"

Output: true

Example 2:

Input: s = "()[]{}"

Output: true

Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true

 

Constraints:

1 <= s.length <= 104
s consist
     
     */
    public class _20_ValidParentheses
    {

        //This is a stack QUestion the Idea is that
        //the Last Opening Bracket  Must be the First one to close
        //this follows LastIn_ First Out (LIFO)
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                //iF It is an Opening BRacket, Push it 
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    //No opening bracket available to match it,
                    //Look at it that Means the If block did not Execute that mean the elese block
                    //Will execute but at the Same time, the Stack Is Empty that Means the If block
                    //did not Execute at all 
                    if (stack.Count == 0)
                        return false;

                    char lastOpening = stack.Pop();

                    //Check Whether the brackets match
                     if ((c == ')' && lastOpening != '(') ||
                        (c == '}' && lastOpening != '{') ||
                        (c == ']' && lastOpening != '['))
                    {
                        return false;
                    }
                }
            }

            //Return, All opening Brackets Must have neem Closed

            return stack.Count == 0;
        }
    }
}


/*
 * 
 * s = "([])"
 
 We encounter the characters one after another.
- ( — opening bracket.
- [ — another opening bracket.
- ] — closes [.
- ) — closes (.
Notice that the most recently opened bracket ([) is the first one that must close.

A Stack handles this naturally.

We use
 
 
 */
