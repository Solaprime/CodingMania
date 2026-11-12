using CodingMania.LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.LinkedList
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



    //You can Use Iterative or Recursive apprach 
     
     */
    public class _206_Reverse_Linked_List
    {

        public ListNode ReverseIterative(ListNode head)
        {

            //Greg Hogg Cocenpt
            /*
             * Questions
                [1, -> 2, -> 3,->4, ->5]
            answer
                [5,4,3,2,1]

            --But      [1, -> 2, -> 3,->4, ->5] in Reverse Foramt is actualy   [1, <- 2, <-3,<-4, <-5] 
            So you just change the Direction of the arrow 
            or we will need to variable to track the (Current Varaible and The Previoud VARAIBLE)


                    /*
 head
 ↓
1 → 2 → 3 → 4 → 5 → NULL

 head
 ↓
5 → 4 → 3 → 2 → 1 → NULL

// i was originally the First Node but is now the last,
// 5 was originally the last Node but now the First 
//the direction of evrry connection has beeen REVERSED

n:bWe are not sorting the values, creating a new list, or swapping the values inside the nodes.
We are not sorting the values, creating a new list, or swapping the values inside the nodes.


         
         
            */
            //This will be Used to store the Portion of the List that has been Reversed 
            //Why is this null when we reverse the Linked List,the Original first node will eventaully becone
            //the last node, And the last node must point to null
            ListNode prev = null;

            //Stoes the node We are Currently Reversing
            ListNode current = head;

            while(current != null)
            {
                //Temporarrariy Saves the next Node so we dont lose the Remaining List
                //Before changing the Direction of a node, We must save the Node that Comes after it
                //Why do we do this because the next line of code will change current.next 
                //if we dont Save the next node first we could lose access to the remaing part of the Original list
                ListNode nextNode = current.next;

                //This is where the actual Reversal Happens
                /*
                 
                   prev = NULL

                  1 → 2 → 3 → 4 → 5 → NULL
                  ↑
                  current

                so
                 
                    1 → NULL
           
                    2 → 3 → 4 → 5 → NULL
                    ↑
                   nextNode

                So we have succesfully reversed the First Connectionh
                 */
                current.next = prev;

                //You are attaching to the  prev and Building it Up with Current 
                //aftrer revising the F
                // Now that we have reversed the current node, we move prev forward.
                prev = current;

                //We move current to the next node that we saved earlier.

                current = nextNode;   
            }

            return prev;
        }


        //Using  Recursice Solutuon
        public ListNode ReverseListRecursive(ListNode head)
        {
            //Base Case: If head is null or it is the last node return it
            //if the list is empty or has only one node 
            if (head == null || head.next == null)
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
