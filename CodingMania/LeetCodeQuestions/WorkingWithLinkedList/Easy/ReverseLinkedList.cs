using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Easy
{
    /*
     Given the head of a singly linked list, reverse the list, and return the reversed list.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:


Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []
 

Constraints:

The number of nodes in the list is the range [0, 5000].
-5000 <= Node.val <= 5000
 

Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?
     
     */
    public  class ReverseLinkedList
    {

        //Using  Iterative Solution


        /*
         we are a given a singly linked list likw
         1 → 2 → 3 → 4 → 5 → null

         our goal is to revers ii to

        5 → 4 → 3 → 2 → 1 → null


         
         */
        public ListNode ReversIterative(ListNode head)
        {
            //These becomes the new head
            //prev will eventuually becomes the new head
            ListNode prev = null;

            //Current is used to traverse the originalList
            ListNode current = head;


            /*
             AnaylYsing the  Loop
             
             
              Starting State
               prev    current
                ↓        ↓
                null ←  [1] → [2] → [3] → [4] → [5] → null


               First Iteration
                ListNode nextNode = current.next; // nextNode = [2]
               current.next = prev;              // [1].next = null
               prev = current;                    // prev = [1]
                current = nextNode;               // current = [2]

                mow the List Looks Like
                 [1] → null     [2] → [3] → [4] → [5]
                  ↑
                  prev           ↑
                                current

                Second iteration
                
                nextNode = [3]
                [2].next = [1]
                prev = [2]
                current = [3]
              
            [2] → [1] → null     [3] → [4] → [5]
             ↑
            prev                  ↑
                                current


            Third Iteration
               nextNode = [4]
              [3].next = [2]
                 prev = [3]
               current = [4]


            [3] → [2] → [1] → null     [4] → [5]
             ↑
            prev                        ↑
                                       current


            Fourth Iteration
            nextNode = [5]
            [4].next = [3]
               prev = [4]
              current = [5]


            [4] → [3] → [2] → [1] → null     [5]
             ↑
            prev                              ↑
                                          current


            Fifth Iteration
            nextNode = null
            [5].next = [4]
             prev = [5]
           current = null
            [5] → [4] → [3] → [2] → [1] → null
              ↑
            prev
           current = null


             */

            while (current != null)
            {
                
                //Store the next Node in a Vraibles
                ListNode nextNode = current.next; //Store next node


                current.next = prev; //revesrse pointer(Reverse current node's pointer)

                prev = current; //MOVE PREV fORWARD(Move prev one step forward)


                //pass the nextNode to the Current Varibale
                current = nextNode; //(mOVE CURRENT ONE STEP fORWARD)
            }

            return prev; //PREV IS THE new head of the reversed List
        }

        //Using  Recursice Solutuon
        public ListNode ReverseListRecursive(ListNode head)
        {
            //Base Case: If head is null or it is the last node return it
            //if the list is empty or has only one node 
            if (head == null ||  head.next == null)
            {
                return head;
            }


            //Watch Video On Recursion
            //Recursively reverse the rest of the list
            ListNode reverseListHead = ReverseListRecursive(head.next);

            //point the next node back to current node
            head.next.next = head;
            head.next = null;

            return reverseListHead;
                
        }
    }
}
