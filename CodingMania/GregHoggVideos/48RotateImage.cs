using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy;

namespace CodingMania.GregHoggVideos
{

    /*
     48. Rotate Image
Medium
Topics
premium lock icon
Companies
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.

 

Example 1:
    1, 2, 3        7, 4, 1
    4, 5, 6    =>  8, 5, 2
    7, 8, 9        9, 6, 3


Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [[7,4,1],[8,5,2],[9,6,3]]
Example 2:

    5, 1, 9, 11          15, 13,2,5
    2, 4, 8, 10      =>  14, 3, 4, 1
    13, 3, 6, 7           12, 6, 8, 9
    15 14  12, 16          16, 7, 10, 11

Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
 

Constraints:

n == matrix.length == matrix[i].length
1 <= n <= 20
-1000 <= matrix[i][j] <= 1000
     
     */
    public class _48RotateImage
    {
        //ChatGpt Solution
        public void Rotate(int[][] matrix)
        {
            //Rtotation is basically 
            //First Transpose it
            // Then Reverse each row
            
            int n = matrix.Length;

            //Step 1: Transpose
            for (int i = 0; i < n; i++)
            {
                // n == matrix.length == matrix[i].length
                //The Constraints it is alwasys going to be a square matrix taht is why 
                //n is being Used
                for (int j = i+1; j  < n; j ++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }


            //Step 2: Reverse Each Row
            for (int i = 0;i < n; i++)
            {
                int left = 0;
                int right = n - 1;

                // Reverse By Left and Right

                while(left< right)
                {
                    int temp = matrix[i][left];
                    matrix[i][left] = matrix[i][right];
                    matrix[i][right] = temp;

                    left++;
                    right--;
                }
            }
        }
    }
}
