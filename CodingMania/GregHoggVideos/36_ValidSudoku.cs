using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     36. Valid Sudoku
Medium
Topics
premium lock icon
Companies
Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
 

Example 1:


Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true
Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
 

Constraints:

board.length == 9
board[i].length == 9
board[i][j] is a digit 1-9 or '.'.
     
     */
    public class _36_ValidSudoku
    {
        /*
         =====Forget all the Nonsnesne jkust Focus on this Validation Flow
         Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

        A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
         
         */

        public bool IsValidSudoku(char[][] board)
        {
            //Normal approach Define 3 Hashet for Row, Column and Box Cheecking then Start doing the Check

            //But this approach Define one HashSet to Lookup Row, Column and box

            HashSet<string> seen = new HashSet<string>();

            //Ome Iteration tO vERIFY ALL
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9  ; j++)
                {
                    char val = board[i][j];

                    if(val =='.')
                    {
                        continue;
                    }
                    //at every instance Populate the Row, Column and Box


                    //   These lines build three “facts” about the cell.For the 5 at row 0, column 0:

                    //"row-0-5" means “a 5 exists in row 0”.
                    //"col-0-5" means “a 5 exists in column 0”.
                    //"box-0-0-5" means “a 5 exists in box(0, 0)”.

                    /*
                       The prefixes row, col and box matter. Without them, “a 5 in row 0” and “a 5 in column 0” 
                    would  produce the same key and look like a duplicate when they aren’
                     
                     */

                    string rowKey = $"row-{i}-{val}";
                    string colKey = $"col-{j}-{val}";

                    /*
                     The box formula i / 3, j / 3 is the clever part. 
                    Integer division squashes indices 0–8 down to 0–2:

             The box formula i / 3, j / 3 is the clever part. Integer division squashes indices 0–8 down to 0–2:

Index	0 1 2	3 4 5	6 7 8
/ 3     	0	 1     	2


  So (i/3, j/3) gives each of the nine boxes a coordinate:
  (0,0) | (0,1) | (0,2)
------+-------+------
(1,0) | (1,1) | (1,2)
------+-------+------
(2,0) | (2,1) | (2,2)
                     
                     */
                    string boxKey = $"box-{i / 3}-{j / 3}-{val}";
                    if (seen.Contains(rowKey) ||seen.Contains(colKey) || seen.Contains(boxKey))
                    {
                        return false;
                    }
                    seen.Add(rowKey);
                    seen.Add(colKey);
                    seen.Add(boxKey);

                }
            }

            return true;

        }
    }
}
