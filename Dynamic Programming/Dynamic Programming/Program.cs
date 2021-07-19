using System;

namespace Dynamic_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Common subsequence");
            int subsequenceLength = Longest_Common_subsequence.LongestCommonSubsequence("abcde", "ace");
            Console.WriteLine(subsequenceLength);
            Console.WriteLine("Longest Common Substring");
            int substringLen = LongestCommonSubstring.LCS("NewSite:GeeksQuiz.com", "OldSite:GeeksforGeeks.org");
            Console.WriteLine(substringLen);
            Console.WriteLine("Knapsack- Max Profit");
            int[] val = new int[] { 60, 100, 120 };
            int[] wt = new int[] { 10, 20, 30 };
            int W = 50;

            Console.WriteLine(KnapsackProblem.MaxProfit(wt,val,W));
        }
    }
}
