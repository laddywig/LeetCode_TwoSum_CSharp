namespace LeetCode_TwoSum_CSharp_Refactored
{
    public class Solution
    {
        /// <summary>
        /// Finds a matching pair of integers that sums up to the target
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>An Array of ints</returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> memory = new();
            int? keyPairing = null;

            for (int i = 0; i < nums.Length; i++)
            {
                // Need to compute the matching integer to equal Target
                // Using this value as the Key within 'memory'
                keyPairing = target - nums[i];

                if (memory.ContainsKey(nums[i])) // Answer Found!
                {
                    int[] answerArray = FormatAnswer(new int[] { i, memory[nums[i]] });
                    ReportAnswer(answerArray, target);
                    return answerArray;
                }
                else if (!memory.ContainsKey(keyPairing.Value)) // No answer yet...
                {
                    // Add to memory and keep looking
                    memory.Add(keyPairing.Value, i);
                }
            }

            throw new ApplicationException("There is no solution");
        }

        /// <summary>
        /// Default Solution method
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>An Array of ints</returns>
        public static int[] TwoSumBruteStrength(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] answerArray = FormatAnswer(new int[] { i, j });
                        ReportAnswer(answerArray, target);
                        return answerArray;
                    }
                }
            }

            throw new ApplicationException("There is no solution");
        }

        internal static int[] FormatAnswer(int[] answerArray)
        {
            if (answerArray == null)
            {
                throw new ArgumentNullException();
            }

            Array.Sort(answerArray);
            return answerArray;
        }

        internal static void ReportAnswer(int[] answerArray, int target)
        {
            if (answerArray == null || answerArray.Length != 2)
            {
                throw new ArgumentNullException();
            }

            Console.WriteLine(string.Format("Because nums[{0}] and nums[{1}] == {2}, we return [{0}, {1}]", answerArray[0], answerArray[1], target));
        }
    }

    /// <summary>
    /// This class is an alternative to test non-Public methods
    /// Left this in as an example.
    /// </summary>
    public class SolutionTests : Solution
    {
        public static int[] FormatAnswerTest(int[] answerArray)
        {
            return FormatAnswer(answerArray);
        }

        public static void ReportAnswerTest(int[] answerArray, int target)
        {
            ReportAnswer(answerArray, target);
        }
    }
}
