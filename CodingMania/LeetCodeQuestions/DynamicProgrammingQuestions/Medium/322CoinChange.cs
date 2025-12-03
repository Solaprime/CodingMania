using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingMania.LeetCodeQuestions.DynamicProgrammingQuestions.Medium
{
    /*
     You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.

Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.

You may assume that you have an infinite number of each kind of coin.

 

Example 1:

Input: coins = [1,2,5], amount = 11
Output: 3
Explanation: 11 = 5 + 5 + 1
Example 2:

Input: coins = [2], amount = 3
Output: -1
Example 3:

Input: coins = [1], amount = 0
Output: 0
 

Constraints:

1 <= coins.length <= 12
1 <= coins[i] <= 231 - 1
0 <= amount <= 104
     */
    public class _322CoinChange
    {
        private Dictionary<int, int> memo = new Dictionary<int, int>();

        public int CoinChange(int[] coins, int amount)
        {
            if (amount == 0) return 0;
            int result = Helper(coins, amount);
            return result == int.MaxValue ? -1 : result;
        }

        private int Helper(int[] coins, int remain)
        {
            if (remain == 0) return 0;
            if (remain < 0) return int.MaxValue;

            if (memo.ContainsKey(remain)) return memo[remain];

            int minCoins = int.MaxValue;
            foreach (int coin in coins)
            {
                int res = Helper(coins, remain - coin);
                if (res != int.MaxValue)
                {
                    minCoins = Math.Min(minCoins, res + 1);
                }
            }

            memo[remain] = minCoins;
            return minCoins;
        }


        //Implementation (Bottom-Up DP)
        /*
          An array coins[], where each element represents a coin denomination.
           An integer amount, which is the target value we want to make using the coins.
            We have an unlimited supply of each coin. 
         
         We build a DP array where dp[i] = minimum coins needed to make amount i.

          Initialize dp[0] = 0 (0 coins to make amount 0).

         For all other amounts, set dp[i] = ∞ initially.

          For each coin, update all amounts that can be made with it.
         
         */
        public int CoinChangeBottomUpDp(int[] coins, int amount)
        {
            int max = amount + 1; //Sentinel large Value
            int[] dp = new int[amount + 1];
            System.Array.Fill(dp, max);
            //Initialize dp[0] = 0 (0 coins to make amount 0).
            dp[0] = 0;//base Case

            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (i - coin >= 0)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }
            return dp[amount] == max ? -1 : dp[amount];
        }
    }
}
