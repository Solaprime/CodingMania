using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{
    /*
     
  You are given the heads of two sorted linked lists list1 and list2.
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
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoList(ListNode list1, ListNode list2)
        {
            // Dummy Head node
            //It’s called a dummy head node, and it acts as a temporary starting point for building the final merged list.
            /*
             When you're creating a new linked list (like the merged one), managing the first node (head) is tricky.
            If you don’t use a dummy, you have to write special logic if the first nodes is not Null:
             
             */
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {

                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }

                else
                {
                    current.next = list2;
                    list2 = list2.next;

                }

                current = current.next;
            }


            // At this point, at least one list is exhausted
            /*
             If list1 is not null, assign it to current.next.
              Otherwise, assign list2 to current.next.
             null-coalescing operator ?? in C#.


                   if (list1 != null)
                     current.next = list1;
                         else
                current.next = list2;
 


            i Thougt of Something if List1 has lenght of 3 and list2 has lenght 7.
                 current.next = list1 ?? list2;
                 The code above can not handle it , or was that scenario not asked in the question


            That line is not just assigning one node — it’s assigning the entire remaining chain (linked list) starting from either list1 or list2.
             */
            current.next = list1 ?? list2;
            /*
              You don’t want to return the dummy node itself because:
                  Its value (-1) is meaningless
                 It was just a starter point
             */

            return dummy.next; // Return merged list, skipping dummy node
        }
    }

    /*
     A Linked List is a data structure where elements (called nodes) are connected using pointers. 
 Each node has:
A value (val)

A reference (next) to the next node in the list.
     
     
     */

}
