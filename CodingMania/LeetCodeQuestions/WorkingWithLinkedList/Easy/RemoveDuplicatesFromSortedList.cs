using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{ 
//{
//    Given the head of a sorted linked list, delete all duplicates such that each element appears only once.Return the linked list sorted as well.



//Example 1:


//Input: head = [1, 1, 2]
//Output: [1, 2]
//Example 2:


//Input: head = [1, 1, 2, 3, 3]
//Output: [1, 2, 3]


//Constraints:

//The number of nodes in the list is in the range[0, 300].
//-100 <= Node.val <= 100
//The list is guaranteed to be sorted in ascending order.
    public  class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicate(ListNode head)
        {
            ListNode current = head;

            //We continue as long as there is a next node to compare with.
            while (current != null  && current.next != null)
            {
               
                if (current.val == current.next.val)
                {
                    // Skip the duplicate node
                    /*
                     This removes the duplicate node by "skipping" it.


                     
                     */
                    current.next = current.next.next;

                }
                else
                {
                    //MOVE TO NEXT uNIQUE mODE
                    current = current.next;
                }
            }

            return head;
        }
    }
}
