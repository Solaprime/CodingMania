using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.BinarySearch
{
    /*
     278. First Bad Version
Easy
Topics
premium lock icon
Companies
You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.

 

Example 1:

Input: n = 5, bad = 4
Output: 4
Explanation:
call isBadVersion(3) -> false
call isBadVersion(5) -> true
call isBadVersion(4) -> true
Then 4 is the first bad version.
Example 2:

Input: n = 1, bad = 1
Output: 1
 

Constraints:

1 <= bad <= n <= 231 - 1
     
     */
    /*
     this problem assumes that You already Have a fictituos IsBadVersion Method that makes an Api Call
    So we just need to apply our Concept of Binary search to reduce the Number of apu call we are making
    
     */
    public class _278_FirstBadVersion
    {

        public int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;

            while (left < right)
            {
                int mid = left + (right - left)/2;

                //Note thr Goal is to find the First Bad Version- from the Mid ----- to ---n can be bad
                //that mean mid might not be the First Bad Versio

                if (IsBadVersion(mid))
                {
                    right = mid;
                }

                //Since mid is not a bad Version you can Push it to the Right 
                else
                {
                    left = mid+1;
                }
            }

            return left;
        }

        public bool IsBadVersion(int  version)
        {
            return true;
        }
    }
}
