using CodingMania.LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.LinkedList
{
    /*
     
     19. Remove Nth Node From End of List
Medium
Topics
premium lock icon
Companies
Hint
Given the head of a linked list, remove the nth node from the end of the list and return its head.

 

Example 1:


Input: head = [1,2,3,4,5], n = 2
Output: [1,2,3,5]
Example 2:

Input: head = [1], n = 1
Output: []
Example 3:

Input: head = [1,2], n = 1
Output: [1]
 

Constraints:

The number of nodes in the list is sz.
1 <= sz <= 30
0 <= Node.val <= 100
1 <= n <= sz
 

Follow up: Could you do this in one pass?
     */
    public class _19th_RemoNthNodeFromEndOfList
    {
        //You can do 2 Iteration approach,
        //Iterate the First Time to get the Number of Items in the List
        //Iterate the Seconf time to remove the item
        /*
         * Could you do this in one pass?
         So the Follow UP IS can we do it one Passs
        So we use fast and Slow Pointer Approach
        So we mantain a distance of n nodes between them
        Once fast reaches the end of the Linked list, slow will be positioned 
        just before we want to remove
         

The important thing is that we're counting from the end, not the beginning.

Let's count:

        the Goal is to maintain a distance of n nodes between them 
        fast -Slow = n distance

        that mean when Fast get to the end Of the nodes, the distacme 
        between the Fast and Slow will be N node
        which is the Posiotn we are Looking For
         */

        public ListNode RemoveNthNodeFromEnd(ListNode node, int n )
        {
            ListNode dummy = new ListNode(-1);
            dummy.next = node;

            ListNode slow = dummy;
            ListNode fast = dummy;

            //Move fast head by n Position
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            //Move both Pointers Unit Fast reaches the Last Node
            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            //This is assuming that when fast gets to the end of the Node
            //Slow is going to be nth Node to remove

            //Remove the targetNode
            slow.next = slow.next.next;
            return dummy.next;
        }
    }
}
