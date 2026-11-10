using CodingMania.LeetCodeQuestions.WorkingWithLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.LinkedList
{
    /*
83. Remove Duplicates from Sorted List
Easy
Topics
premium lock icon
Companies
Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.

 

Example 1:


Input: head = [1,1,2]
Output: [1,2]
Example 2:


Input: head = [1,1,2,3,3]
Output: [1,2,3]
 

Constraints:

The number of nodes in the list is in the range [0, 300].
-100 <= Node.val <= 100
The list is guaranteed to be sorted in ascending order
     */
    public class _83_Remove_Duplicate_From_Sorted_List
    {

        public ListNode  RemoveDuplicated(ListNode head)
        {

            ListNode current = head;

            //Ensures we are not on the Last Item 
            while (current != null  && current.next != null)
            {
                if(current.val == current.next.val)
                {
                    //Remove the Duplicated for
                    current.next = current.next.next;
                }
                else
                {
                    //Move to the Next Node
                    current = current.next;
                }
            }



            /*
              We return head because it still points to the beginning of our modified linked list.
           Remember, we used current to traverse and modify the linked list, but we never changed the original head reference.
             */
            return head;
        }
    }
}
