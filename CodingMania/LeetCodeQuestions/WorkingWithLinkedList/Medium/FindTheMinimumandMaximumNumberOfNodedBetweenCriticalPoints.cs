using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium
{
    /*
     A critical point in a linked list is defined as either a local maxima or a local minima.

A node is a local maxima if the current node has a value strictly greater than the previous node and the next node.

A node is a local minima if the current node has a value strictly smaller than the previous node and the next node.

Note that a node can only be a local maxima/minima if there exists both a previous node and a next node.

Given a linked list head, return an array of length 2 containing [minDistance, maxDistance] where minDistance is the minimum distance between any two distinct critical points and maxDistance is the maximum distance between any two distinct critical points. If there are fewer than two critical points, return [-1, -1].

 

Example 1:


Input: head = [3,1]
Output: [-1,-1]
Explanation: There are no critical points in [3,1].
Example 2:


Input: head = [5,3,1,2,5,1,2]
Output: [1,3]
Explanation: There are three critical points:
- [5,3,1,2,5,1,2]: The third node is a local minima because 1 is less than 3 and 2.
- [5,3,1,2,5,1,2]: The fifth node is a local maxima because 5 is greater than 2 and 1.
- [5,3,1,2,5,1,2]: The sixth node is a local minima because 1 is less than 5 and 2.
The minimum distance is between the fifth and the sixth node. minDistance = 6 - 5 = 1.
The maximum distance is between the third and the sixth node. maxDistance = 6 - 3 = 3.
Example 3:


Input: head = [1,3,2,2,3,2,2,2,7]
Output: [3,3]
Explanation: There are two critical points:
- [1,3,2,2,3,2,2,2,7]: The second node is a local maxima because 3 is greater than 1 and 2.
- [1,3,2,2,3,2,2,2,7]: The fifth node is a local maxima because 3 is greater than 2 and 2.
Both the minimum and maximum distances are between the second and the fifth node.
Thus, minDistance and maxDistance is 5 - 2 = 3.
Note that the last node is not considered a local maxima because it does not have a next node.
 

Constraints:

The number of nodes in the list is in the range [2, 105].
1 <= Node.val <= 105
     
     */
    class FindTheMinimumandMaximumNumberOfNodedBetweenCriticalPoints
    {
        public int[] NodesBetweenCriticalPoints(ListNode head)
        {
            List<int> criticalPoints = new List<int>();

            int index = 1; // Start from index 1 for the second node
            ListNode prev = head;
            ListNode curr = head.next;

            while (curr != null && curr.next != null)
            {
                int prevVal = prev.val;
                int currVal = curr.val;
                int nextVal = curr.next.val;

                if ((currVal > prevVal && currVal > nextVal) || (currVal < prevVal && currVal < nextVal))
                {
                    criticalPoints.Add(index);
                }

                prev = curr;
                curr = curr.next;
                index++;
            }

            if (criticalPoints.Count < 2) return new int[] { -1, -1 };

            int minDist = int.MaxValue;
            for (int i = 1; i < criticalPoints.Count; i++)
            {
                minDist = Math.Min(minDist, criticalPoints[i] - criticalPoints[i - 1]);
            }

            int maxDist = criticalPoints[^1] - criticalPoints[0];
            return new int[] { minDist, maxDist };
        }
    }
}
