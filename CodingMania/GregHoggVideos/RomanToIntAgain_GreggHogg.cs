using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    public   class RomanToIntAgain_GreggHogg
    {

        /// <summary>
        /// My Solution 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //public int RomanToInt(string s)
        //{
        //    Dictionary<char, int> Storage = new Dictionary<char, int>()
        //    {
        //        {'I',1 },
        //        {'V',5 },
        //        {'X',10 },
        //        {'L',50},
        //        {'C',100 },
        //        {'D',500 },
        //        {'M',1000 },
        //    };
        //    int total = 0;
        //    int previousValue = 0;
        //    int currentValue = 0;

        //    foreach (var c in s)
        //    {
        //        //get value
        //        //
        //        currentValue = Storage[c];
        //        if (currentValue > previousValue)
        //        {
        //            var value = currentValue - previousValue;
        //            total += value;
        //        }

        //        else
        //        {
        //            total += currentValue;
        //        }
        //        previousValue = currentValue;
        //    }

        //    return total;
        //}

        
        
        /// <summary>
        /// Former Solution Flow here, Copied from another place in the application
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToIntFlow(string s)
        {
            //Intialize a Dictionary and save it in a Key VALUE pair
            //XiX
            Dictionary<char, int> romanValues = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int total = 0;
            int previousValue = 0;

            foreach (char c in s)
            {
                int currentValue = romanValues[c];
                if (currentValue > previousValue)
                {
                    total += currentValue - 2 * previousValue;
                }

                //Current Value was already added to Total
                // Take "IV" = 4
                /*
                 +I
                   +(V - I)


                +1 + (5 - 1)= 5
                you already Adde one as total 
                
                for Iv - First iteration
                prevous Values = 0, total = 1
                then next iteration total becomes = 5-1 =4 which is 4 but the 1 Has been added
                to the First total
                 */

                else
                {
                    total += currentValue;
                }
                previousValue = currentValue;
            }
            return total;
        }
    }
}

