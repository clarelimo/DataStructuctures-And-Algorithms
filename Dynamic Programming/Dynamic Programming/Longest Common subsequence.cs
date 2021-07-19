using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Programming
{
    public static class Longest_Common_subsequence
    {
        public static int LongestCommonSubsequence(string text1, string text2)
        {
            int m = text1.Length;
            int n = text2.Length;
            // have a table to store the max count at the cell
            int[,] dp = new int[m + 1, n + 1];

            //loop through the two strings
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)  // have starting point in the table to be 0
                    {
                        dp[i, j] = 0;
                    }
                    else if (text1[i - 1] == text2[j - 1]) // if the characters are the same then add 1 to the top left val and store it in the current cell
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]); // if the letters arent the same store the max of the prev cell val
                    }
                }
            }

            // return the last val in the table
            return dp[m, n];
        }
    }
}
