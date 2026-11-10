using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.BinarySearch
{
    /*
     367. Valid Perfect Square
Easy
Topics
premium lock icon
Companies
Given a positive integer num, return true if num is a perfect square or false otherwise.

A perfect square is an integer that is the square of an integer. In other words, it is the product of some integer with itself.

You must not use any built-in library function, such as sqrt.

 

Example 1:

Input: num = 16
Output: true
Explanation: We return true because 4 * 4 = 16 and 4 is an integer.
Example 2:

Input: num = 14
Output: false
Explanation: We return false because 3.742 * 3.742 = 14 and 3.742 is not an integer.
 

Constraints:

1 <= num <= 231 - 1
     
     */
    public class _367_ValidPerfectSquare
    {
        // We are using Long instead of int to prevent integer overflow duirng multiplication int -- -2,147,483,648 and 2,147,483,647
        // 50,000 × 50,000 = 2,500,000,000
        //Long 9.22 Qunitllionse
        public bool IsPerfectSquare(int num)
        {
            //you mgiht haave the Expiration to cut right into 2 but do not do it   
            long left = 1;
            long right = num;

            while (left <= right)
            {
                long  mid= left +(right - left)/2;
                long sqaure = mid * mid;
                if (sqaure == num)
                {
                    return true;
                }
                else if(sqaure < num)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
    }
}
