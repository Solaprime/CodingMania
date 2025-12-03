using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{
    /*
     
     Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.

 

Example 1:


Input: head = [1,2,6,3,4,5,6], val = 6
Output: [1,2,3,4,5]
Example 2:

Input: head = [], val = 1
Output: []
Example 3:

Input: head = [7,7,7,7], val = 7
Output: []
 

Constraints:

The number of nodes in the list is in the range [0, 104].
1 <= Node.val <= 50
0 <= val <= 50
     */
    public class RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            //Create a dummy node pointing to head
            ListNode dummy = new ListNode(-1);
            dummy.next = head;

            //Use a current pointer to traverse the list
            /*
             
             current moves through the list
current is used to traverse and modify the list.

At the end of the loop, current could be anywhere in the list (middle or end).

So current.next might be null, or it might point to a node far from the actual start.


             */
            ListNode current = dummy;

            while (current.next != null)
            {
                if (current.next.val == val)
                {

                    //Skip the node with val
                    /*Why This Is a Bit Tricky
Removing elements from a linked list isn't like a normal array — you can't just "skip" an index.

You need to reconnect the next pointers to bypass the nodes you want to remove.

*/
                    current.next = current.next.next;

                }

                else
                {
                    //move to the next node
                    current = current.next;
                }
            }

            //return the updated list, Skipping dummy
            //why is Dummy next returned from the Question?
            /*
             dummy is always at the start of the list
dummy is a node before the actual head of the list.

It never moves, so we can always use dummy.next to point to the new head (even if the original head was deleted).
             */

            return dummy.next;

        }
    }
}

/*
 why is current.next modified in the while loop, will the changes show in the dummy varaibvle

Yes, modifying current.next also changes the list that dummy points to, because both current and dummy are pointing to nodes that are part of the same linked list in memory.

////
//////   Revisit value typenand refernce type
/////
 Objects like ListNode are reference types.

That means variables like dummy, current, head hold references (pointers) to the actual nodes in memory — not copies.

Think of the list as a chain of linked boxes. If you change the arrow on one box, everyone who can reach that box will see the change — because they’re pointing to the same physical box in memory.
 
 */