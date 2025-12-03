using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{
    /*
     Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.

 

Example 1:


Input: head = [3,2,0,-4], pos = 1
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
Example 2:


Input: head = [1,2], pos = 0
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
Example 3:


Input: head = [1], pos = -1
Output: false
Explanation: There is no cycle in the linked list.
 

Constraints:

The number of the nodes in the list is in the range [0, 104].
-105 <= Node.val <= 105
pos is -1 or a valid index in the linked-list.



     
     */
    //
    //
    //
    //The questiob has some Diagram go to website to see question
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            //If the list is empty or has only one node → no cycle possible.
            if (head == null || head.next == null)
                return false;

            //: Initialize two pointers
            /*
             slow goes 1 node at a time.
             fast goes 2 nodes at a time.
             
             */
            ListNode slow = head; 
            ListNode fast = head.next;

            //While fast and fast.next are not null, keep moving:

            while (fast != null && fast.next != null)
            {
                if(slow == fast)
                {
                    return true; // They met! There is a cycle.
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            //If loop exits without match
            return false;

        }

        /*
         pos = -1 → means the linked list has no cycle (tail’s next = null)
            pos = 0 → tail points back to the first node
           pos = 1 → tail points to the second node, and so on...



        3 → 2 → 0 → -4
                ↑    ↓
                └────┘


        The last node -4 connects back to the node at index 1 (value = 2).

This creates a cycle.
         


        Why Does fast Move Twice as Fast as slow?
This is the heart of Floyd’s Cycle Detection Algorithm (also called Tortoise and Hare algorithm).


        slow moves 1 step

fast moves 2 steps

🧠 Why Twice (2x)?
Because if there’s a cycle:

The fast pointer will eventually "lap" the slow pointer.

Think of a race track: if two runners are going around in a loop, and one is running twice as fast, they will eventually meet.


         */
    }
}
