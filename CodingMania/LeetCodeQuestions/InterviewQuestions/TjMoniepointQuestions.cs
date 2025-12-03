using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.InterviewQuestions
{
    /*
     
     Implement a fixed-size “first in, first out” (FIFO) buffer, that can handle the following operations:
 
write: add element to the buffer if max size is not reached, raise an error otherwise.
 
force write: add element to the buffer. If the max size is reached, remove the oldest element first.
 
read: remove and return the oldest element from the buffer if there are any, raise an error otherwise.
 
clear: remove all elements from the buffer.
 
dump: return buffer content (for debugging).
 
 
Example: buffer size 3
 
[ ][ ][ ]
 
read()
=> error
 
write(A)
write(B)
write(C)
 
write(D)
=> error
 
force_write(D)
 
read()
=> B
 
read()
=> C
 
clear()
# => [ ][ ][ ]
 
     */
    class TjMoniepointQuestions
    {
        public class FixedSizeFiFoBuffer<T>
        {
            //Define Max Size
            private readonly int _maxSize;
            private readonly Queue<T> _buffer;

            //Set the MasSize
            public FixedSizeFiFoBuffer(int maxSize)
            {
                if (maxSize <= 0)
                {
                    throw new ArgumentException("Buffer size must be greater than 0.");
                }
                _maxSize = maxSize;
                //So you can always intiatel maxSize, when creatring
                //A queue
                _buffer = new Queue<T>(maxSize);
            }

            
            //Write
            //add ad item to the buffer if there is space
            public void Write(T item)
            {
                if (_buffer.Count >= _maxSize)
                {
                    throw new InvalidOperationException("Buffer is Full");

                }
                //Enqueu Add items to the Queue
                _buffer.Enqueue(item);
            }

            ///Read
            //Read and Remove the 0ldest item
            public T Read()
            {
                if (_buffer.Count == 0)
                    throw new InvalidOperationException("Buffer is Empty");
                return _buffer.Dequeue();
            }
            
            //clear
            //Remove all the items in the buffewr
            public void Clear()
            {
                //My solution
                //while( _buffer.Count >= 0)
                //{
                //    _buffer.Dequeue();
                //}

                //we have buffer.Clear
                _buffer.Clear();
               
            }

            //dump
            //Return buffer content for Debugging


            //forceWrite
            //Forece a write even if Buffer s Full,
            //removing the Oldest item
            public void ForceWrite(T item)
            {
                if( _buffer.Count >= _maxSize)
                {
                    _buffer.Dequeue(); //Remove oldest
                }
                _buffer.Enqueue(item);

            }
        }

    }

}

/*
  What is FIFO
THE Question asked to build a small data storage system 
called a Fixed-Size FIFO bUFFER 

NOTE FIF0 - First in,First our 
Means the First Element you add is the first one you get out
Imagine it to be a QueueLine
//The Question Requirement the Buffer should 
support 5 Operation
Write(value) - Add Value to the Buffer. If the buffer is Full, throw an
error
force_write(value) - Add a value to the Buffer, If full Remove the Oldest Value first,  then add the New one
read()- Remove and return the oldest Value, if empty throws an error
clear() - remove all elements from the Buffer
dump()- Return the Current Contents(For Debugging or Checking)
 
 */
