namespace LeetCode_TwoSum_CSharp_RefactoredTests
{
    using LeetCode_TwoSum_CSharp_Refactored;

    [TestClass]
    public class ProgamTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [DataRow(new int[] { 0, 4, 3, 0 }, 0, new int[] { 0, 3 })]
        [DataRow(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new int[] { 5, 11 })]
        public void TwoSum_FromDataRowTest(int[] nums, int target, int[] expected)
        {
            int[] actual = Solution.TwoSum(nums, target);
            Assert.AreEqual(expected.Length, 2);
            Assert.AreEqual(actual.Length, 2);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
        }

        [TestMethod]
        public void FormatAnswer_ArgumentNullException()
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            int[] nums = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
#pragma warning disable CS8604 // Possible null reference argument.
                Solution.FormatAnswer(nums);
#pragma warning restore CS8604 // Possible null reference argument.
            }
            catch (ArgumentNullException e)
            {
                return;
            }
#pragma warning restore CS0168 // Variable is declared but never used

            Assert.Fail("The expected ArgumentNullException was not thrown.");
        }

        [DataTestMethod]
        [DataRow(new int[] { 2, 7, 1 }, new int[] { 1, 2, 7 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 3, 2, 1 }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 })]
        [DataRow(new int[] { -1, 2, 1 }, new int[] { -1, 1, 2 })]
        public void FormatAnswer_FromDataRowTest(int[] nums, int[] expected)
        { 
            // Typically only write unit tests for custom code
            // Don't usually need to test .net framework calls (unless experimental)
            // Definitely test the argument checking logic (i.e. FormateAnswer_NullArgumentException)

            int[] actual = Solution.FormatAnswer(nums);
            Assert.AreEqual(nums.Length, actual.Length);
            for(int i=0; i<actual.Length; i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }

        [TestMethod]
        public void ReportAnswer_ArgumentNullException()
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            int[] nums = null;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
#pragma warning disable CS8604 // Possible null reference argument.
                Solution.FormatAnswer(nums);
#pragma warning restore CS8604 // Possible null reference argument.
            }
            catch (ArgumentNullException e)
            {
                return;
            }
#pragma warning restore CS0168 // Variable is declared but never used

            Assert.Fail("The expected ArgumentNullException was not thrown.");
        }
    }
}