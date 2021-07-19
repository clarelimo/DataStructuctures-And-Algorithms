using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Programming
{
    public static class KnapsackProblem
    {
        public static int MaxProfit(int[] weights, int[] value, int W)
        {
            int n = value.Length;
            // have a table to store the profit at the current cell
            int[,] dp = new int[n + 1, W + 1];

            // loop through the weights and index from 0 to length of the value array
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= W; j++)
                {
                    if (i == 0 || j == 0) // fill the first cell with 0
                    {
                        dp[i, j] = 0;
                    }
                    else if (weights[i - 1] <= j)  // if current weight in the row is less than the weight in the col(j)
                    {
                        dp[i, j] = Math.Max((value[i - 1] + dp[i - 1, j - weights[i - 1]]), dp[i - 1, j]); // get the max val to e put in the knapsack
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j]; // fill the cell with the top val
                    }
                }
            }

            //return the last value in the table
            return dp[n, W];
        }
    }
}

/* Given weights and values of n items, put these items in a knapsack of capacity W to get the maximum total value in the knapsack.
 * In other words, given two integer arrays val[0..n-1] and wt[0..n-1] which represent values and weights associated with n items respectively. 
 * Also given an integer W which represents knapsack capacity, find out the maximum value subset of val[] such that sum of the weights of this subset is smaller than or equal to W.
 * You cannot break an item, either pick the complete item or don’t pick it (0-1 property). */