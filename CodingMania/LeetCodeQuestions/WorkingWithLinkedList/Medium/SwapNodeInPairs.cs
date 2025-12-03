using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium
{
    /*
     
     You are given the head of a linked list, and an integer k.

Return the head of the linked list after swapping the values of the kth node from the beginning and the kth node from the end (the list is 1-indexed).

 

Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [1,4,3,2,5]
Example 2:

Input: head = [7,9,6,6,7,8,3,0,9,5], k = 5
Output: [7,9,6,6,8,7,3,0,9,5]
 

Constraints:

The number of nodes in the list is n.
1 <= k <= n <= 105
0 <= Node.val <= 100
     */
    public class SwapNodeInPairs
    {
        public ListNode SwapNodes(ListNode head, int k)
        {
            int length = 0;
            ListNode current = head;

            // Step 1: Get the length of the list
            while (current != null)
            {
                length++;
                current = current.next;
            }

            // Step 2: Find kth node from start and end
            ListNode firstK = head;
            for (int i = 1; i < k; i++)
            {
                firstK = firstK.next;
            }

            ListNode secondK = head;
            for (int i = 1; i < length - k + 1; i++)
            {
                secondK = secondK.next;
            }

            // Step 3: Swap their values
            int temp = firstK.val;
            firstK.val = secondK.val;
            secondK.val = temp;

            return head;
        }
    }
}
