using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithRecursion
{
    class WorkingWithFactorialFlow
    {

        /// <summary>
        /// Using Recursinve Flow here
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
       public int Factorial(int n)
        {
            Console.WriteLine($"Value of N -- {n}");
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int result = n * Factorial(n - 1);
                Console.WriteLine(result);
                return result;
            }
        }

        public int FactorialTWo(int n)
        {
            if (n >= 1)
            {
                return n * FactorialTWo(n - 1);
            }

            else
            {
                return 1;
            }
        }
        
        /// <summary>
        /// Iterative Approcah with 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double IterativeApproachFlow(int number)
        {
          if (number == 0)
            {
                return 1;
            }

            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
