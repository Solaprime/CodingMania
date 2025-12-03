using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part4
{
    /*
     
      Write a program to count the number of days between two dates.

The two dates are given as strings, their format is YYYY-MM-DD as shown in the examples.

 

Example 1:

Input: date1 = "2019-06-29", date2 = "2019-06-30"
Output: 1
Example 2:

Input: date1 = "2020-01-15", date2 = "2019-12-31"
Output: 15
 

Constraints:

The given dates are valid dates between the years 1971 and 2100.
     
      
     */
    class NumberOfDaysBetweenTwoDates
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            // Parse the string inputs into DateTime objects
            DateTime d1 = DateTime.Parse(date1);
            DateTime d2 = DateTime.Parse(date2);

            // Calculate the absolute difference in days
            return Math.Abs((d1 - d2).Days);
        }
    }
}
