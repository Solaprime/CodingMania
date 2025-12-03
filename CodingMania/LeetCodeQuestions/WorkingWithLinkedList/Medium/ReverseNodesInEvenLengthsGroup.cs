using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium
{
    /*
     You are given the head of a linked list.

The nodes in the linked list are sequentially assigned to non-empty groups whose lengths form the sequence of the natural numbers (1, 2, 3, 4, ...). The length of a group is the number of nodes assigned to it. In other words,

The 1st node is assigned to the first group.
The 2nd and the 3rd nodes are assigned to the second group.
The 4th, 5th, and 6th nodes are assigned to the third group, and so on.
Note that the length of the last group may be less than or equal to 1 + the length of the second to last group.

Reverse the nodes in each group with an even length, and return the head of the modified linked list.

 

Example 1:


Input: head = [5,2,6,3,9,1,7,3,8,4]
Output: [5,6,2,3,9,1,4,8,3,7]
Explanation:
- The length of the first group is 1, which is odd, hence no reversal occurs.
- The length of the second group is 2, which is even, hence the nodes are reversed.
- The length of the third group is 3, which is odd, hence no reversal occurs.
- The length of the last group is 4, which is even, hence the nodes are reversed.
Example 2:


Input: head = [1,1,0,6]
Output: [1,0,1,6]
Explanation:
- The length of the first group is 1. No reversal occurs.
- The length of the second group is 2. The nodes are reversed.
- The length of the last group is 1. No reversal occurs.
Example 3:


Input: head = [1,1,0,6,5]
Output: [1,0,1,5,6]
Explanation:
- The length of the first group is 1. No reversal occurs.
- The length of the second group is 2. The nodes are reversed.
- The length of the last group is 2. The nodes are reversed.
 

Constraints:

The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 105
     */
    class ReverseNodesInEvenLengthsGroup
    {
        public ListNode ReverseEvenLengthGroups(ListNode head)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode prev = dummy;
            ListNode curr = head;

            int groupSize = 1;

            while (curr != null)
            {
                // Determine group length
                ListNode groupStart = curr;
                int count = 0;
                while (count < groupSize && curr != null)
                {
                    curr = curr.next;
                    count++;
                }

                // Now we know actual group length is count
                if (count % 2 == 0)
                {
                    // Reverse this group
                    ListNode reversedGroup = ReverseList(groupStart, count);
                    prev.next = reversedGroup;

                    // Move prev to the end of reversed group
                    prev = groupStart;
                }
                else
                {
                    // No reversal, move prev to the end of the group
                    prev = groupStart;
                    for (int i = 1; i < count; i++)
                    {
                        prev = prev.next;
                    }
                }

                groupSize++;
            }

            return dummy.next;
        }

        // Helper to reverse exactly k nodes
        private ListNode ReverseList(ListNode head, int k)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (k-- > 0 && curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }

            head.next = curr; // connect end of reversed part to next segment
            return prev; // new head of reversed part
        }
    }
}
