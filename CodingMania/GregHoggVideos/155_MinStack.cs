using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     *  155. Min Stack
Medium
Topics
premium lock icon
Companies
Hint
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

Implement the MinStack class:

MinStack() initializes the stack object.
void push(int value) pushes the element value onto the stack.
void pop() removes the element on the top of the stack.
int top() gets the top element of the stack.
int getMin() retrieves the minimum element in the stack.
You must implement a solution with O(1) time complexity for each function.

 

Example 1:

Input
["MinStack","push","push","push","getMin","pop","top","getMin"]
[[],[-2],[0],[-3],[],[],[],[]]

Output
[null,null,null,null,-3,null,0,-2]

Explanation
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin(); // return -3
minStack.pop();
minStack.top();    // return 0
minStack.getMin(); // return -2
 

Constraints:

-231 <= val <= 231 - 1
Methods pop, top and getMin operations will always be called on non-empty stacks.
At most 3 * 104 calls will be made to push, pop, top, and getMin.
     
     */
    public class _155_MinStack
    {
        //Noraml Stack
        private Stack<int> stack;

        //To keep track of Minstack
        private Stack<int> minStack;

        public _155_MinStack(int val)
        {
            //Initialize the STACK
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        { 
            stack.Push(val);

            if (minStack.Count == 0 || val <= minStack.Peek())
            {
                minStack.Push(val);
            }
        }

        public void Pop()
        { 
            //if you removw a value from the Stack and that
            //Value is the same as the same as the Minimum vale
            //Remove that Small value from the MinStack
            int removedValue = stack.Pop();

            if (removedValue == minStack.Peek())
            {
                minStack.Pop();
            }
        
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek(); 
        }
    }
}
