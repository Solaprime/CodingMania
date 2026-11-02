using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy
{
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
s consists of parentheses only '()[]{}'.
     */
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                //Validate any of this 3 are opening  Brackets, then add to the Stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                //If any of this Three is not found in the Opening that Menas we are dealing with a closing Stack here 
                else
                {
                    //Validate the Count of the Stack, Why is this Here
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    //Validate the Matching betweem The Opening and the Closing flow 
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
