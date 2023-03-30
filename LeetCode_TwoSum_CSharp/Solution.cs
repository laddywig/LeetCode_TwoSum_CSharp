namespace LeetCode_TwoSum_CSharp
{
    public class Solution
    {

        /// <summary>
        /// Default Solution method
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns>An Array of ints</returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> memory = new Dictionary<int, int>();
            int? keyPairing = null;

            for (int i = 0; i < nums.Length; i++)
            {
                keyPairing = target - nums[i];

                if (memory.ContainsKey(nums[i]))
                {
                    int answer1 = i;
                    int answer2 = memory[nums[i]];
                    if (answer1 < answer2)
                    {
                        Console.WriteLine(string.Format("Because nums[{0}] and nums[{1}] == {2}, we return [{0}, {1}]", answer1, answer2, target));
                        return new int[] { answer1, answer2 };
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Because nums[{0}] and nums[{1}] == {2}, we return [{0}, {1}]", answer2, answer1, target));
                        return new int[] { answer2, answer1 };
                    }
                }
                else if (!memory.ContainsKey(keyPairing.Value))
                {
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
                        int answer1 = i;
                        int answer2 = j;
                        if (answer1 < answer2)
                        {
                            Console.WriteLine(string.Format("Because nums[{0}] and nums[{1}] == {2}, we return [{0}, {1}]", answer1, answer2, target));
                            return new int[] { answer1, answer2 };
                        }
                        else
                        {
                            Console.WriteLine(string.Format("Because nums[{0}] and nums[{1}] == {2}, we return [{0}, {1}]", answer2, answer1, target));
                            return new int[] { answer2, answer1 };
                        }
                    }
                }
            }

            throw new ApplicationException("There is no solution");
        }
    }
}