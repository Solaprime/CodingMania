using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.InterviewQuestions
{
    //Nigeria LinkDIN bABE MESSAGED ME
    //Determing whether a number is Prime Number
    public  class PrimeNumber
    {
        private bool IsPrime(int num)
        {
            //0 and 1 are not Prime Number
            if (num <= 1)
                return false;

            //2 is the only even and P;rime number
            if (num == 2)
                return true;

            //if a number is divisble by 2 then
            //it is not a PrimeeNumber, it is a even Number
            //Divisible by 2 Very Easy 
            if (num % 2 == 0)
                return false;

            //the Iteration
            //so we Loop through Odd Numbers 
            //sINCE ODD nUMBERS ARE NOT dIVISIBLE BY 2
            //since even Numbers are Filtered 
            // 5*5 = 25 . So any number divisible by 25 less than 5 is Possible
            for (int i = 3; i * i <= num; i += 2)
            {
                //If for whatevetr reason an i is obtained we return False, that means we are Done
                if (num % i == 0)
                    return false;
            }
            //Return true, if the above Condition does not enter the If block  
            return true;
        }

        public List<int> GetListFromNumber(int start, int end)
        {
            List<int> primeNum = new List<int>();
            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    primeNum.Add(num);
                }
            }
            return primeNum;
        }
    }
    
}
