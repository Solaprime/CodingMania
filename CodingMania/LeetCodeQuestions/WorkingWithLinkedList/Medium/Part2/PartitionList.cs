using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part2
{
    /*
     Given the head of a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.

You should preserve the original relative order of the nodes in each of the two partitions.

 

Example 1:


Input: head = [1,4,3,2,5,2], x = 3
Output: [1,2,2,4,3,5]
Example 2:

Input: head = [2,1], x = 2
Output: [1,2]
 

Constraints:

The number of nodes in the list is in the range [0, 200].
-100 <= Node.val <= 100
-200 <= x <= 200
     
     */
    class PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode beforeHead = new ListNode(0); // Dummy head for < x
            ListNode afterHead = new ListNode(0);  // Dummy head for >= x

            ListNode before = beforeHead;
            ListNode after = afterHead;

            while (head != null)
            {
                if (head.val < x)
                {
                    before.next = head;
                    before = before.next;
                }
                else
                {
                    after.next = head;
                    after = after.next;
                }
                head = head.next;
            }

            after.next = null; // Important: terminate the list
            before.next = afterHead.next; // Connect the two lists

            return beforeHead.next;
        }
    }
}
