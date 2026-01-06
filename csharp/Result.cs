using System;

namespace PageCountAssessment
{
    public static class Result
    {
        /// <summary>
        /// Returns the minimum number of pages to turn to reach page p
        /// in a book with n pages.
        /// </summary>
        /// <param name="n">Total number of pages in the book</param>
        /// <param name="p">Target page</param>
        /// <returns>Minimum number of page turns</returns>
        public static int PageCount(int n, int p)
        {
            // Calculate turns from the front (page 1)
            // Each turn reveals 2 pages, so divide by 2
            int turnsFromFront = p / 2;
            
            // Calculate turns from the back
            // Total possible turns from front is n / 2
            // Subtract the target page position from that
            int turnsFromBack = n / 2 - p / 2;
            
            // Special case: when n is divisible by 4 and p is n-1,
            // both pages n-1 and n are visible from the back opening
            if (n % 4 == 0 && p == n - 1)
            {
                turnsFromBack = 0;
            }
            
            // Return the minimum of the two approaches
            return Math.Min(turnsFromFront, turnsFromBack);
        }

        /// <summary>
        /// Returns an array of minimum page turns for multiple target pages.
        /// </summary>
        /// <param name="n">Total number of pages in the book</param>
        /// <param name="targets">Array of target pages</param>
        /// <returns>Array of minimum page turns for each target</returns>
        public static int[] PageCountMultiple(int n, int[] targets)
        {
            int[] result = new int[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                result[i] = PageCount(n, targets[i]);
            }
            return result;
        }
    }
}