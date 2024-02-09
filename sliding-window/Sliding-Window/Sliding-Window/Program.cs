// Solution for the problem Leetcode 1493: Longest Subarray of 1's After Deleting One Element
// https://leetcode.com/problems/longest-subarray-of-1s-after-deleting-one-element/
int LongestSubarray(int[] nums)
{
	int Start = 0;

	int Zeroes = 0;

	int LongestWindow = 0;

	for (int i = 0; i < nums.Length; i++)
	{
		Zeroes += nums[i] == 0 ? 1 : 0;

		while (Zeroes > 1)
		{
			Zeroes -= nums[Start] == 0 ? 1 : 0;
			Start++;

		}

		LongestWindow = Math.Max(LongestWindow, i - Start);

	}

	return LongestWindow;
}

Console.WriteLine("First Case: " + LongestSubarray([1, 1, 0, 1]));

Console.WriteLine("Second Case: " + LongestSubarray([0, 1, 1, 1, 0, 1, 1, 0, 1]));

Console.WriteLine("Third Case: " + LongestSubarray([1, 1, 1]));