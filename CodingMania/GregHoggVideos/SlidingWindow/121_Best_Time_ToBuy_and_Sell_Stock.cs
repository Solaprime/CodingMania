using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.GregHoggVideos.SlidingWindow
{
    /*
     121. Best Time to Buy and Sell Stock
Easy
Topics
premium lock icon
Companies
You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.
 

Constraints:

1 <= prices.length <= 105
0 <= prices[i] <= 104
     */
    public class _121_Best_Time_ToBuy_and_Sell_Stock
    {
        //So you may Make one trade, Buy on one day and Sell it on a later Day
        //Profil is the Sell price minus the Buy price.
        //Return the biggest profit possible or 0 if every possible trade loses money
        /*
         [7,1,5,3,6,4]: buy at 1 (day 2) and sell at 6 (day 5), so the profit is 5
        [7,6,4,3,1]: prices only fall, so any trade loses money and you don’t trade. The answer is 0.

        So buy must come before sell 

        The key insight

For any day you might sell, the best day to have bought is the cheapest day before it. So you walk through the prices once and keep track of:

the lowest price seen so far (your best buy), and
the best profit seen so far.
        The solution (sliding-window form)

left is the buy day and right is the sell day.
         */

        public int MaxProfit(int[] prices)
        {
           //So we Use left as the First Price to start the Iteration 
            int left = 0;
            int maxProfit = 0;

            for (int right= 1; right < prices.Length; right++)
            {
                //If the Current Send price is Very Low
                // [10, 50, 9, 60]
                //You can buy at 10 and Sell at 50 , Profiit is 40
                //when you get to 9, that Means the 50 and 10 ,is not Longer needed
                //but 60-9 = 51, nut ypu need to comapre if the Larges betwwen 51 and 40
                if (prices[right] < prices[left])
                {
                    left = right; //Found a cheaper buy day, So move the window start here
                }
                else
                {
                    maxProfit= Math.Max(maxProfit, prices[right]- prices[left]);
                }
            }

            return maxProfit;
        }
    }
}
