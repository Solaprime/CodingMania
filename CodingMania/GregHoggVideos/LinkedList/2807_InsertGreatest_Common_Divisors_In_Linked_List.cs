using CodingMania.LeetCodeQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.LinkedList
{
    /*
     
     &#x20;

[**2807. Insert Greatest Common Divisors in Linked List**](https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/)

Medium

Topics

[premium lock icon](https://leetcode.com/_next/static/media/lock.30spdgxy-h-4s.svg)Companies

Given the head of a linked list `head`, in which each node contains an integer value.

Between every pair of adjacent nodes, insert a new node with a value equal to the **greatest common divisor** of them.

Return *the linked list after insertion*.

The **greatest common divisor** of two numbers is the largest positive integer that evenly divides both numbers.



**Example 1:**

[image](https://assets.leetcode.com/uploads/2023/07/18/ex1_copy.png)

**Input:** head = [18,6,10,3] **Output:** [18,6,6,2,10,1,3] **Explanation:** The 1st diagram denotes the initial linked list and the 2nd diagram denotes the linked list after inserting the new nodes (nodes in blue are the inserted nodes). - We insert the greatest common divisor of 18 and 6 = 6 between the 1st and the 2nd nodes. - We insert the greatest common divisor of 6 and 10 = 2 between the 2nd and the 3rd nodes. - We insert the greatest common divisor of 10 and 3 = 1 between the 3rd and the 4th nodes. There are no more adjacent nodes, so we return the linked list.&#x20;

**Example 2:**

[image](https://assets.leetcode.com/uploads/2023/07/18/ex2_copy1.png)

**Input:** head = [7] **Output:** [7] **Explanation:** The 1st diagram denotes the initial linked list and the 2nd diagram denotes the linked list after inserting the new nodes. There are no pairs of adjacent nodes, so we return the initial linked list.&#x20;



**Constraints:**

- The number of nodes in the list is in the range `[1, 5000]`.
- `1 <= Node.val <= 1000`
     */
    class _2807_InsertGreatest_Common_Divisors_In_Linked_List
    {

        public ListNode  InsertGreatestCommonDivisors(ListNode head)
        {
            ListNode current = head;

            while (current != null && current.next != null)
            {
                /*
                  18,  6
                  a\   /b
                     6
                     c

                c- C is the Gcd Crreatiion

                b- is the operation that attache the gcD to the (neewNode.Next)  nect element of 18
                c- Is the operation that attach the Current element 18, to the NeWwly Inserteed node
                 */

                int gcd = GCD(current.val, current.next.val);
                // using System.Numerics;
                //int gcd = (int)BigInteger.GreatestCommonDivisor(current.val, current.next.val);

                //Create the Gcd Node
                ListNode newNode = new ListNode(gcd);
                //Attach the Element to the Right TO THE gcd 
                //
                newNode.next = current.next;
                current.next= newNode;

                //push the next iteration to b --which is 6
                current = newNode.next;

            }

            return head;
        }





        // this is an Euclidean Algorithm
        //What are Gcd
        //18 and 6 -- The GCD is 6
        // 6 and 10 - THE gcd IS 2
        //10 and 3 --the GCd is 1

        //The goal is to return the Largest number that can divide both
        //numbers without leaving a remainder
        // the  % operator calculates the remainder after divison
        // 18 % 6 = 0; 10 %6 =4;
        //The Principle behind the algorithm is 
        // GCd(a, b) = GCG(b, a%b)
        /*
            Instead of trying to find all the factors of two numbers, 
           we repeatedly divide and use the remainder to reduce the problem
         e.g
          GCD(10, 6);
        10/6 = 1 remainder 4
        GCD(10,6) = GCD(6,4)
        Beacuse the Common Divisors of 10 and 6 is also 
        the Common divisors of 6 and 4
        6/4 = 1 remainder 2
        GCD(6,4) = GCD(4, 2)
        4/2 = 2 remainder 0
         */
        public int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;

                a = b;
                b = remainder;

            }
            return a;

           
        }
        
    }


    
}
