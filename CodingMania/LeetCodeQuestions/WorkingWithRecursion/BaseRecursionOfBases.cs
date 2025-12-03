using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithRecursion
{
    class BaseRecursionOfBases
    {
        //Iterate FivE tIME

        public void DoSomethingIterativeAppraoch(int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                Console.WriteLine("Do Something FUN");
            }
        }

        //Recursion Five Times
        //Advantage
        //Easier to Read and Write
        //Easier to debug

        //Disdvantage
        ///Sometimers More Slower
        /////Uses Moe memeorty
        ///
        public void DoSomethingRecursiveAppraoch(int numberOfTimes)
        {
            if (numberOfTimes < 1)
            {
                return;
            }
            Console.WriteLine("Do Something FUN");
            DoSomethingRecursiveAppraoch(numberOfTimes - 1);
        }

    }
}
