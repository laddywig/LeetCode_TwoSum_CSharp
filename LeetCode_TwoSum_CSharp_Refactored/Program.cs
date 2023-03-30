// See https://aka.ms/new-console-template for more information
// The Big O notation of O(n^2) is telling me it's a double loop, we need to find a faster solution than double looping
// To do that, we need the algorithm to remember
// The key assumption being there's only ONE solution
using LeetCode_TwoSum_CSharp_Refactored;

Console.WriteLine("Testing Smart Algorithm");
Solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
Solution.TwoSum(new int[] { 3, 2, 4 }, 6);
Solution.TwoSum(new int[] { 3, 3 }, 6);
Solution.TwoSum(new int[] { 0, 4, 3, 0 }, 0);
Solution.TwoSum(new int[] { -3, 4, 3, 90 }, 0);
Solution.TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);
Console.WriteLine("\nTesting Brute Force Algorithm");
Solution.TwoSumBruteStrength(new int[] { 2, 7, 11, 15 }, 9);
Solution.TwoSumBruteStrength(new int[] { 3, 2, 4 }, 6);
Solution.TwoSumBruteStrength(new int[] { 3, 3 }, 6);
Solution.TwoSumBruteStrength(new int[] { 0, 4, 3, 0 }, 0);
Solution.TwoSumBruteStrength(new int[] { -3, 4, 3, 90 }, 0);
Solution.TwoSumBruteStrength(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);