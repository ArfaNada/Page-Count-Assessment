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
            // TODO: Implement the logic
            return 0;
        }

        /// <summary>
        /// Returns an array of minimum page turns for multiple target pages.
        /// </summary>
        /// <param name="n">Total number of pages in the book</param>
        /// <param name="targets">Array of target pages</param>
        /// <returns>Array of minimum page turns for each target</returns>
        public static int[] PageCountMultiple(int n, int[] targets)
        {
            // TODO: Implement the logic
            return new int[targets.Length];
        }
    }
}
