using System;
using System.Collections.Generic;
using System.Text;

namespace Dynamic_Programming
{
    public static class LongestCommonSubstring
    {
        public static int LCS(string a, string b)
        {
            int m = a.Length;
            int n = b.Length;
            // grid to store the current max length
            int[,] grid = new int[m, n];
            int result = 0;

            // loop through both strings
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    { // initialize the start of the grid with 0
                        grid[i, j] = 0;
                    }
                    else if (a[i - 1] == b[j - 1])
                    { // if the last characters are the same
                        grid[i, j] = grid[i - 1, j - 1] + 1; // add 1 to the prev diagonal element
                        result = Math.Max(result, grid[i, j]); // find max between the current result and the current cell
                    }
                    else
                    {
                        grid[i, j] = 0; // if the letters dont match
                    }
                }
            }

            return result;
        }
    }
}
