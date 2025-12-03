using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part2
{
    /*
     Given the head of a linked list, rotate the list to the right by k places.

 

Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:


Input: head = [0,1,2], k = 4
Output: [2,0,1]
 

Constraints:

The number of nodes in the list is in the range [0, 500].
-100 <= Node.val <= 100
0 <= k <= 2 * 109
     */
    class RotateList
    {

        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null || k == 0)
                return head;

            // 1. Compute the length of the list and get the last node
            int length = 1;
            ListNode tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
                length++;
            }

            // 2. Make the list circular
            tail.next = head;

            // 3. Find new tail: (length - k % length - 1)th node
            //    and new head: (length - k % length)th node
            k = k % length;
            int stepsToNewTail = length - k;
            ListNode newTail = head;
            for (int i = 1; i < stepsToNewTail; i++)
            {
                newTail = newTail.next;
            }

            ListNode newHead = newTail.next;
            newTail.next = null; // Break the cycle

            return newHead;
        }
    }
}
