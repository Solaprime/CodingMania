using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos
{
    /*
     
     
     739. Daily Temperatures
Medium
Topics
premium lock icon
Companies
Hint
Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

 

Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]
Example 2:

Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]
Example 3:

Input: temperatures = [30,60,90]
Output: [1,1,0]
 

Constraints:

1 <= temperatures.length <= 105
30 <= temperatures[i] <= 100
     */
    public class _739_DailyTemperature
    {

        // So we are Using a montonic Stack 
        //the First Item stored in the stack will be the Biggest, Follow by the Bigger Bsiaclly 
        //In decreasing order. So by 
        //put 75, 69, in stack,  71 is the Current Ite, 
        //but 71 IS BIGGER THAN THAN 69 so do the Computation and remove 69
        //so it becomes 75, 71  current in stack , you 76 as current Item
        //76 is beigger ant 71 and 75, ig 76 is the 10th item in the array that means 
        //Index 10th minus the Index  of both 71 and index of 76
        //note we are only storing the Index of the Item not the Item itSeolf
        //Some Soulutions Might use like aDictionary or tupple of key value Pair
        //But here we are 
        public int[] DailyTemperature(int[] temepratures)
        {
            //Get the leneght of the array
            int n = temepratures.Length;

            //Create an array of Answer whose Defaulat is going to be Set to  Zero;
            // Because if we don't find a warmer temperature for a particular day, its answer should remain 0.
            int[] answer = new int[n];

            //we are not storing Temperatures Directly we are storing Indexes

            /*
             
               temperatures = [73, 74, 75, 71, 69, 72, 76, 73]

             answer       = [ 0,  0,  0,  0,  0,  0,  0,  0] -- Default Everything to Zero
             stack =      [0, 1, 2] // Store Indesxes
             
             //Why Use Indexses instead of Temeperature becasue we need to calculate the number of days betweeen two Positons

             
             */
            Stack<int>  stack = new Stack<int>();

            //iterate through the Array of Temperature
            for (int i = 0; i < n; i++)
            {
                //Check if the Current Temperature is Higher than the Prevously stored tempearature
                //in the Stack
                while (stack.Count > 0 && temepratures[i] > temepratures[stack.Peek()])
                {
                    //Remove the Current item in the Stack  that is less than the current Item in the iteration
                    //Not we are only storing the Index not everything 
                    int previousDay = stack.Pop();

                    //Save Here    
                    answer[previousDay] = i - previousDay;
                }

                //Store the Index of the  Temeperature in a stack
                stack.Push(i);

            }
            return answer;
        } 
    }
}
