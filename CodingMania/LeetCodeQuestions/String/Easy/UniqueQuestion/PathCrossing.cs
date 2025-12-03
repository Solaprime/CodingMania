using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.String.Easy.UniqueQuestion
{
    class PathCrossing
    {
        /*
        Given a string path, where path[i] = 'N', 'S', 'E' or 'W', each representing moving one unit north, south, east, or west, respectively. You start at the origin (0, 0) on a 2D plane and walk on the path specified by path.

Return true if the path crosses itself at any point, that is, if at any time you are on a location you have previously visited. Return false otherwise.

 

Example 1:


Input: path = "NES"
Output: false 
Explanation: Notice that the path doesn't cross any point more than once.
Example 2:


Input: path = "NESWW"
Output: true
Explanation: Notice that the path visits the origin twice.
 

Constraints:

1 <= path.length <= 104
path[i] is either 'N', 'S', 'E', or 'W'.

 
   You are given a string path where each character represents a movement on a 2D grid:

'N' → Move North (↑): y += 1

'S' → Move South (↓): y -= 1

'E' → Move East (→): x += 1

'W' → Move West (←): x -= 1

You start from position (0, 0) and move in the directions specified.

        eXAMPLE1
 Input: path = "NES"
Output: false
Explanation:
         (x, y) - Use x and Y CORDINATE TO VISUALIZE 
Start at (0, 0)
         
N → (0, 1)

E → (1, 1)

S → (1, 0)

Visited coordinates



        Example 2:
Input: path = "NESWW"
Output: true

Step-by-step Trace:
Start at (0, 0)

N → (0, 1)

E → (1, 1)

S → (1, 0)

W → (0, 0) ← Visited again!

W → (-1, 0)
         
         */


        public bool IsPathCrossing(string path)
        {
            int x = 0, y = 0;
            HashSet<string> visited = new HashSet<string>();
            visited.Add("0,0"); //Starting poiny

            foreach (char direction in path)
            {
                switch (direction)
                {
                    case 'N':
                        y += 1;
                        break;

                    case 'S':
                        y -= 1;
                        break;


                    case 'E':
                        x += 1;
                        break;


                    case 'W':
                        x -= 1;
                        break;
                }

                string position = $"{x},{y}";

                if (visited.Contains(position))
                {
                    return true;
                }

                visited.Add(position);
            }

            return false;
        }
    }
}
