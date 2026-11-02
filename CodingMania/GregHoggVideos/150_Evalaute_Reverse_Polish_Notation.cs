using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{

    /*
       150. Evaluate Reverse Polish Notation
Medium
Topics
premium lock icon
Companies
You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.

Evaluate the expression. Return an integer that represents the value of the expression.

Note that:

The valid operators are '+', '-', '*', and '/'.
Each operand may be an integer or another expression.
The division between two integers always truncates toward zero.
There will not be any division by zero.
The input represents a valid arithmetic expression in a reverse polish notation.
The answer and all the intermediate calculations can be represented in a 32-bit integer.
 

Example 1:

Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
Output: 22
Explanation: ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
= ((10 * (6 / (12 * -11))) + 17) + 5
= ((10 * (6 / -132)) + 17) + 5
= ((10 * 0) + 17) + 5
= (0 + 17) + 5
= 17 + 5
= 22
 

Constraints:

1 <= tokens.length <= 104
tokens[i] is either an operator: "+", "-", "*", or "/", or an integer in the range [-200, 200].
     
     */
    public class _150_Evalaute_Reverse_Polish_Notation
    {
        //charGpt Solutoon DFlow here hERE hEER

        //this solution review it oh
        public  int EvaluateReversePolishNotation(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (string token in tokens)
            {
                if(token == "+" || token == "-" || token=="*" || token == "/")
                {
                    int right = stack.Pop();
                    int left = stack.Pop();

                    int result = 0;

                    switch (token)
                    {
                        case "+":
                            result = left + right;
                            break;

                            case "-":
                            result = left - right;
                             break ;

                            case "*":
                            result = left * right;
                            break;

                            //This Constrain on Division i feel like
                            //it iS not Correct 

                            case "/":
                            result = left / right;
                            break;
                    }
                    stack.Push(result); 
                }

                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop();
           
        }


        //My solution flow here here here



        public int EvaluateReversePolishNotationMySoluton(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (var data in tokens)
            {
                if (data == "+")
                {

                    var firsNumber = stack.Pop();
                    var secondNumber = stack.Pop();
                    stack.Push(firsNumber + secondNumber);
                }

                else if (data == "-")
                {
                    var firsNumber = stack.Pop();
                    var secondNumber = stack.Pop();
                    stack.Push(secondNumber - firsNumber);
                }


                else if (data == "*")
                {
                    var firsNumber = stack.Pop();
                    var secondNumber = stack.Pop();
                    stack.Push(firsNumber * secondNumber);
                }

                else if (data == "/")
                {
                    var firsNumber = stack.Pop();
                    var secondNumber = stack.Pop();
                    int result = 0;
                    if (firsNumber > secondNumber)
                    {
                        result = firsNumber / secondNumber;
                    }
                    else
                    {
                        result = secondNumber / firsNumber;
                    }
                    stack.Push(result);
                }

                else
                {
                    int digit = int.Parse(data);
                    stack.Push(digit);
                }
            }

            return stack.Pop();
        }
    }
}
