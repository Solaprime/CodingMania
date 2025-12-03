using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part2
{
    /*
     
     Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,2,3,3,4,4,5]
Output: [1,2,5]
Example 2:


Input: head = [1,1,1,2,3]
Output: [2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order.
     */
    class RemoveDuplicatesFromSortedList2
    {
       public ListNode DeleteDuplicates(ListNode head)
        {
            // Dummy node before the head to simplify edge cases
            ListNode dummy = new ListNode(0, head);
            ListNode prev = dummy;     // Last node known to be non-duplicate
            ListNode current = head;

            while (current != null)
            {
                // Detect duplicates
                if (current.next != null && current.val == current.next.val)
                {
                    int duplicateVal = current.val;
                    // Skip all nodes with this value
                    while (current != null && current.val == duplicateVal)
                    {
                        current = current.next;
                    }
                    prev.next = current;  // Remove all duplicates
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }

            return dummy.next;
        }
    }
}
