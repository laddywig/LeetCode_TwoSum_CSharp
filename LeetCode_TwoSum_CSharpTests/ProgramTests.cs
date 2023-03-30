namespace LeetCode_TwoSum_CSharpTests
{
    using LeetCode_TwoSum_CSharp;

    [TestClass]
    public class ProgramTests
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <param name="expected"></param>
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
    }
}