// Leetcode n° 2149.Rearrange Array Elements by Sign - Medium

//You are given a 0-indexed integer array nums of even length consisting of an equal number of positive and negative integers.

//You should rearrange the elements of nums such that the modified array follows the given conditions:

// 1 - Every consecutive pair of integers have opposite signs.
// 2 - For all integers with the same sign, the order in which they were present in nums is preserved.
// 3 - The rearranged array begins with a positive integer.
// Return the modified array after rearranging the elements to satisfy the aforementioned conditions.

// Case 1 [3,1,-2,-5,2,-4] , Case 2 [-1,1]

using System;
using System.Linq;



static int[] RearrangeArray(int[] nums)
{
	int posIndex = 0;
	int negIndex = 1;

	int[] allNums = new int[nums.Length];

	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] > 0)
		{
			allNums[posIndex] = nums[i];
			posIndex += 2;
		}

		if (nums[i] < 0)
		{
			allNums[negIndex] = nums[i];
			negIndex += 2;
		}
	}

	return allNums;
}

Console.WriteLine(String.Join(", ", RearrangeArray([3, 1, -2, -5, 2, -4])));
Console.WriteLine(String.Join(", ", RearrangeArray([-1, 1])));