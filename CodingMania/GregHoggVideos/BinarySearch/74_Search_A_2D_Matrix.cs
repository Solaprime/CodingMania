using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.BinarySearch
{
    /*
     74. Search a 2D Matrix
Medium
Topics
premium lock icon
Companies
You are given an m x n integer matrix matrix with the following two properties:

Each row is sorted in non-decreasing order.
The first integer of each row is greater than the last integer of the previous row.
Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.

 

Example 1:


Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
Output: true
Example 2:


Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
Output: false
 

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 100
-104 <= matrix[i][j], target <= 104
 

Accepted
3,174,187/5.8M
Acceptance Rate
54.3%
     
     */
    class _74_Search_A_2D_Matrix
    {
        /*So you need a way to flaten out the 2d Matrix to be like a Single Array hence the  Multiplcation then we use the Modulus to  and Division to find the I and j Cordinate
         
         this Works because the Matrix is Sorted, so we can treat
        it as one long sorted array and apply Biary Search
        ssee 7 < 10, 20< 23 It can be trated as a long one array

        -Each row is also Sorted in ascending order
        we can rewrite the entire matrix as  -- 1, 3, 5, 7, 10, 11, 16, 20, 23, 30, 34, 60
        the core Concept is Howto convert a ID index back into a 2d Row and Column

          int[][] matrix =
{
    new int[] { 1, 3, 5, 7 },
    new int[] { 10, 11, 16, 20 },
    new int[] { 23, 30, 34, 60 }
};
         */


        public bool SearchMatrix(int[][] matrix, int target)
        {

            int m = matrix.Length;
            int n = matrix[0].Length;

            int left = 0;

            int right = (m * n) - 1;

         

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                //Divide by the Columns N here 
                int row = mid / n;
                int col = mid % n;


                if (matrix[row][col] == target)
                {
                    return true;
                }
                else if (matrix[row][col] < target)
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
/*
 Yes. The solution works for a rectangular matrix, not just a square matrix, provided it
 
 */