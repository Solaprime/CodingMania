using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.Part6
{
    /*
     
    
    
    
    Given a string date representing
    a Gregorian calendar 
    date formatted as YYYY-MM-DD, 
    return the day number of the year.

 

Example 1:

Input: date = "2019-01-09"
Output: 9
Explanation: Given date is the 9th day of the year in 2019.
Example 2:

Input: date = "2019-02-10"
Output: 41
 

Constraints:

date.length == 10
date[4] == date[7] == '-', and all other date[i]'s are digits
date represents a calendar date between Jan 1st, 1900 and Dec 31st, 2019.
     
     */
    class DayOfTheYear
    {
        public int DayOfYearFlow(string date)
        {
            string[] parts = date.Split('-');
            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Check for leap year
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                daysInMonth[1] = 29;
            }

            int dayOfYear = 0;
            for (int i = 0; i < month - 1; i++)
            {
                dayOfYear += daysInMonth[i];
            }

            dayOfYear += day;
            return dayOfYear;
        }
    }
}
