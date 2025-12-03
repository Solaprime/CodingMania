using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.WorkingWithLinkedList.Medium.Part3
{
    /*
     Design a queue that supports push and pop operations in the front, middle, and back.

Implement the FrontMiddleBack class:

FrontMiddleBack() Initializes the queue.
void pushFront(int val) Adds val to the front of the queue.
void pushMiddle(int val) Adds val to the middle of the queue.
void pushBack(int val) Adds val to the back of the queue.
int popFront() Removes the front element of the queue and returns it. If the queue is empty, return -1.
int popMiddle() Removes the middle element of the queue and returns it. If the queue is empty, return -1.
int popBack() Removes the back element of the queue and returns it. If the queue is empty, return -1.
Notice that when there are two middle position choices, the operation is performed on the frontmost middle position choice. For example:

Pushing 6 into the middle of [1, 2, 3, 4, 5] results in [1, 2, 6, 3, 4, 5].
Popping the middle from [1, 2, 3, 4, 5, 6] returns 3 and results in [1, 2, 4, 5, 6].
 

Example 1:

Input:
["FrontMiddleBackQueue", "pushFront", "pushBack", "pushMiddle", "pushMiddle", "popFront", "popMiddle", "popMiddle", "popBack", "popFront"]
[[], [1], [2], [3], [4], [], [], [], [], []]
Output:
[null, null, null, null, null, 1, 3, 4, 2, -1]

Explanation:
FrontMiddleBackQueue q = new FrontMiddleBackQueue();
q.pushFront(1);   // [1]
q.pushBack(2);    // [1, 2]
q.pushMiddle(3);  // [1, 3, 2]
q.pushMiddle(4);  // [1, 4, 3, 2]
q.popFront();     // return 1 -> [4, 3, 2]
q.popMiddle();    // return 3 -> [4, 2]
q.popMiddle();    // return 4 -> [2]
q.popBack();      // return 2 -> []
q.popFront();     // return -1 -> [] (The queue is empty)
 

Constraints:

1 <= val <= 109
At most 1000 calls will be made to pushFront, pushMiddle, pushBack, popFront, popMiddle, and popBack.
     
     */
    class DesignFrontMiddleBackQueue
    {
    }

   

public class FrontMiddleBackQueue
    {
        private LinkedList<int> left;
        private LinkedList<int> right;

        public FrontMiddleBackQueue()
        {
            left = new LinkedList<int>();
            right = new LinkedList<int>();
        }

        public void PushFront(int val)
        {
            left.AddFirst(val);
            Balance();
        }

        public void PushMiddle(int val)
        {
            if (left.Count > right.Count)
            {
                right.AddFirst(left.Last.Value);
                left.RemoveLast();
            }
            left.AddLast(val);
        }

        public void PushBack(int val)
        {
            right.AddLast(val);
            Balance();
        }

        public int PopFront()
        {
            if (IsEmpty()) return -1;

            int val;
            if (left.Count > 0)
            {
                val = left.First.Value;
                left.RemoveFirst();
            }
            else
            {
                val = right.First.Value;
                right.RemoveFirst();
            }

            Balance();
            return val;
        }

        public int PopMiddle()
        {
            if (IsEmpty()) return -1;

            int val;
            if (left.Count == right.Count)
            {
                val = left.Last.Value;
                left.RemoveLast();
            }
            else
            {
                val = left.Last.Value;
                left.RemoveLast();
            }

            Balance();
            return val;
        }

        public int PopBack()
        {
            if (IsEmpty()) return -1;

            int val;
            if (right.Count > 0)
            {
                val = right.Last.Value;
                right.RemoveLast();
            }
            else
            {
                val = left.Last.Value;
                left.RemoveLast();
            }

            Balance();
            return val;
        }

        private void Balance()
        {
            // Maintain the invariant: left.Count == right.Count or left.Count == right.Count + 1
            while (left.Count > right.Count + 1)
            {
                right.AddFirst(left.Last.Value);
                left.RemoveLast();
            }

            while (left.Count < right.Count)
            {
                left.AddLast(right.First.Value);
                right.RemoveFirst();
            }
        }

        private bool IsEmpty()
        {
            return left.Count == 0 && right.Count == 0;
        }
    }

}
