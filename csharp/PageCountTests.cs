using Xunit;
using PageCountAssessment;

namespace PageCountAssessment.Tests
{
    public class PageCountTests
    {
        // --- Part 1: Single page ---
        [Theory]
        [InlineData(6, 2, 1)]
        [InlineData(5, 4, 0)]
        [InlineData(10, 1, 0)]
        [InlineData(10, 10, 0)]
        [InlineData(9, 9, 0)]
        [InlineData(7, 3, 1)]
        [InlineData(7, 4, 1)]
        [InlineData(100, 2, 1)]
        [InlineData(100, 99, 0)]
        [InlineData(1000, 450, 225)]
        [InlineData(1000, 999, 0)]
        public void TestPageCount(int n, int p, int expected)
        {
            int result = Result.PageCount(n, p);
            Assert.Equal(expected, result);
        }

        // --- Part 2: Multiple queries ---
        [Fact]
        public void TestPageCountMultiple_SmallBook()
        {
            int n = 6;
            int[] targets = new int[] { 1, 2, 5, 6 };
            int[] expected = new int[] { 0, 1, 1, 0 };
            Assert.Equal(expected, Result.PageCountMultiple(n, targets));
        }

        [Fact]
        public void TestPageCountMultiple_LargeBook()
        {
            int n = 100;
            int[] targets = new int[] { 2, 50, 99 };
            int[] expected = new int[] { 1, 25, 0 };
            Assert.Equal(expected, Result.PageCountMultiple(n, targets));
        }

        [Fact]
        public void TestPageCountMultiple_SingleTarget()
        {
            int n = 10;
            int[] targets = new int[] { 4 };
            int[] expected = new int[] { 2 };
            Assert.Equal(expected, Result.PageCountMultiple(n, targets));
        }

        [Fact]
        public void TestPageCountMultiple_FirstAndLast()
        {
            int n = 15;
            int[] targets = new int[] { 1, 15 };
            int[] expected = new int[] { 0, 0 };
            Assert.Equal(expected, Result.PageCountMultiple(n, targets));
        }
    }
}
