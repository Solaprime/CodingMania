using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     
Code
Testcase
Test Result
Test Result
54. Spiral Matrix
Medium
Topics
premium lock icon
Companies
Hint
Given an m x n matrix, return all elements of the matrix in spiral order.

  
Example 1:
  1->2->3
        |
   4->5 6
  |      |
  7->8->9

Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,2,3,6,9,8,7,4,5]
Example 2:
  1->2->3->4
           |
  5->6->7  8
  |        |
  9->10->11->12

Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 

Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 10
-100 <= matrix[i][j] <= 100
     */
    public class _54SpiralMatrix
    {
        public List<int> SpiralOrder(int[][] matrix)
        {
            /*
             Left → Right
             Top → Bottom
             Right → Left
             Bottom → Top
             
             */

            /*Shrinking the Boundaries
            
              top++
              right--
              bottom--
              left++
            */


            /*
             why I am  checking if    if (top <= bottom) and     if (left <= right)

             sometimes: no rows remain OR no columns remain But the code would still
            try to traverse them.That causes: duplicate elements invalid traversal


            [
                    [1,2,3],
                    [4,5,6]

            // 123  - Left-Right
            //6 - top-to-bottom
            //  5 4 right-left
]
             */
            List<int> result = new List<int>();

            //ChatGpt Solution is Quite Differnet From GregHogg Cage Solution
            int top = 0;
            int bottom = matrix.Length - 1;

             int left = 0;
             int right = matrix[0].Length - 1;

            while (top <= bottom && left <=right)
            {
                //Use the Direction of the Arrow to Understand Direction
                //of the For LOOP,

                //Whem it Comes to Increasing/Decreasing
                //you Use the Next direction start to Form Cage
                //After Left-Right you are going top to Bottom top++;
                
                //Left -right 
                //you are starting left to right so starting 
                //index is left then you are Pusing to Right then Incrasrs
                //Do the Samee for top to bootom
                //Same right-left
                //Bottom-top


                //1  left->Right
                for (int col = left; col <= right; col++)
                {
                    result.Add(matrix[top][col]);
                }
                top++;

                //top -> bottom
                for (int row = top; row <= bottom; row++)
                {
                    result.Add(matrix[row][right]);
                }
                right--;

                //top<=bottom
                //"There is still at least one row remaining."

                //right -> left
                if (top <= bottom)
                {
                    for (int col = right; col >= left; col--)
                    {
                        result.Add(matrix[bottom][col]);
                    }
                    bottom--;
                }

                //IF left <=Right, ther is still at least one Column remianing


                //BOTTOM->tOP
                if (left <= right)
                {
                    for (int row = bottom; row >= top; row++)
                    {
                        result.Add(matrix[row][left]);
                    }
                    left++;
                }
               
            }
            return result;
        }
    }
}
