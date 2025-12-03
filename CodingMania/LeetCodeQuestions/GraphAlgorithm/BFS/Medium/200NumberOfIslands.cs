using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.GraphAlgorithm.BFS.Medium
{
    /*
     Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.

An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

 

Example 1:

Input: grid = [
  ["1","1","1","1","0"],
  ["1","1","0","1","0"],
  ["1","1","0","0","0"],
  ["0","0","0","0","0"]
]
Output: 1
Example 2:

Input: grid = [
  ["1","1","0","0","0"],
  ["1","1","0","0","0"],
  ["0","0","1","0","0"],
  ["0","0","0","1","1"]
]
Output: 3
 

Constraints:

m == grid.length
n == grid[i].length
1 <= m, n <= 300
grid[i][j] is '0' or '1'.
     */
    public class _200NumberOfIslands
    {
        //BfS Solution Using Queue

        private int rows;
        private int cols;

        public int NumIslandsBFS(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;

            rows = grid.Length;
            cols = grid[0].Length;
            int count = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        BFS(grid, r, c);
                        count++;
                    }
                }
            }
            return count;
        }

        private void BFS(char[][] grid, int r, int c)
        {
            var queue = new Queue<(int, int)>();
            queue.Enqueue((r, c));
            grid[r][c] = '0'; // mark visited

            int[][] directions = new int[][] {
            new int[] {1, 0}, // down
            new int[] {-1, 0}, // up
            new int[] {0, 1}, // right
            new int[] {0, -1} // left
        };

            while (queue.Count > 0)
            {
                var (row, col) = queue.Dequeue();

                foreach (var dir in directions)
                {
                    int newRow = row + dir[0];
                    int newCol = col + dir[1];

                    if (newRow >= 0 && newRow < rows &&
                        newCol >= 0 && newCol < cols &&
                        grid[newRow][newCol] == '1')
                    {
                        grid[newRow][newCol] = '0'; // mark visited
                        queue.Enqueue((newRow, newCol));
                    }
                }
            }

        }


        //Dfs Solution

        public int NumIslandsDFS(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;

            rows = grid.Length;
            cols = grid[0].Length;
            int count = 0;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        DFS(grid, r, c);
                        count++;
                    }
                }
            }
            return count;
        }

        private void DFS(char[][] grid, int r, int c)
        {
            if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0')
            {
                return;
            }

            grid[r][c] = '0'; // mark visited

            DFS(grid, r + 1, c);
            DFS(grid, r - 1, c);
            DFS(grid, r, c + 1);
            DFS(grid, r, c - 1);
        }
    }
}
