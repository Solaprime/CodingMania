using CodingMania.LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.LinkedList
{
    /*
     ou are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

 

Example 1:


Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]
 

Constraints:

The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both list1 and list2 are sorted in non-decreasing order.
     
     */
    class _21_MergTwoSortedList
    {

        public ListNode MergeTwoList(ListNode list1, ListNode list2)
        {

            // Dummy Head node
            //It’s called a dummy head node, and it acts as a temporary starting point for building the final merged list.
            /*
             When you're creating a new linked list (like the merged one), managing the first node (head) is tricky.
            If you don’t use a dummy, you have to write special logic if the first nodes is not Null:

            Imagine you did not have a dummy Node how do we dETERMINE Which node should become the First Node ofout merged List

             
             */


            //So Dummy will remian at the beginning of our Merged List
            //We need this Dummy to be returning the Start of the List
            ListNode dummy = new ListNode(-1);

            //Current will Move forward as we add Nodes
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {

                if(list1.val <= list2.val)
                {
                    current.next = list1;

                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;

                    list2 = list2.next;
                }
                //Current represnents the last node in out merged List, Whenever we attach a new node, we need to move currrent to that newy attached NODE
                //so we need to ensure that the Current Pointer Points to the newly attached Node
                current = current.next;
            }


            // The ?? operator is called the null-coalescing operator.
            //IF LIST1 is not null, use LIST1.
           // OTHERWISE, use LIST2.
            current.next = list1 ?? list2;

            //if (list1 != null)
            //{
            //    current.next = list1;
            //}

            //if (list2 != null)
            //{
            //    current.next  = list2;
            //}


             return dummy.next;
        }
    }
}
