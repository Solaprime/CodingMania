using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions
{
    internal class SquareRootOfaNumber
    {

        public int MySqrt(int x)
        {
            if (x < 2)
                return x; // If x is 0 or 1, the square root is x itself.

            int left = 1, right = x / 2, result = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Use long to prevent overflow when squaring mid
                long square = (long)mid * mid;

                if (square == x)
                    return mid; // Found exact square root
                else if (square < x)
                {
                    result = mid; // Store mid as a potential answer
                    left = mid + 1; // Move right to find a closer value
                }
                else
                {
                    right = mid - 1; // Move left to find a smaller value
                }
            }

            return result; // Return the floor of the square root
        }
    }
}
/*
 Solution solution = new Solution();
int x = 4;
int result = solution.MySqrt(x);
Console.WriteLine(result); // Output: 2

 */
/*
 Solution solution = new Solution();
int x = 8;
int result = solution.MySqrt(x);
Console.WriteLine(result); // Output: 2

 */