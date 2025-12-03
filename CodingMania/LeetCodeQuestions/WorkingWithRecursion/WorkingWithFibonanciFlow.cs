using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithRecursion
{
    /*
     A recursion is a method that Calls itself,
    but be careful when using recursion Be careful so you dont enter a recurison for forever
    You need to add a breaK Condition
     */
    class WorkingWithFibonanciFlow
    {

        public int FibonacciMethod(int sequence)
        {
            if (sequence <= 1)
            {
                return sequence;
            }

            else
            {
                return FibonacciMethod(sequence - 1) + FibonacciMethod(sequence -2);
            }
        }
        //You can Use For Loop as While
        //Differnece between uSING ForLoop and Fibonanci
    }
}
