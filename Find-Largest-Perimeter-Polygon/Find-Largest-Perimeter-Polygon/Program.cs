﻿// Leetcode 2971.Find Polygon With the Largest Perimeter

// You are given an array of positive integers nums of length n.
// A polygon is a closed plane figure that has at least 3 sides. The longest side of a polygon is smaller
// than the sum of its other sides.

// Conversely, if you have k (k >= 3) positive real numbers a1, a2, a3, ...,
// ak where a1 <= a2 <= a3 <= ... <= ak and a1 + a2 + a3 + ... + ak-1 > ak,
// then there always exists a polygon with k sides whose lengths are a1, a2, a3, ..., ak.

// The perimeter of a polygon is the sum of lengths of its sides.

// Return the largest possible perimeter of a polygon whose sides can be formed from nums,
// or -1 if it is not possible to create a polygon.

// Cases: 1: [5,5,5], 2: [1,12,1,2,5,50,3], 3: [5,5,50];

using System.Linq;
static long LargestPerimeter(int[] nums)
{
	// verificando se tem menos de 3 lados. Se tiver, não é polígono
	if (nums.Length < 3)
	{
		throw new Exception("The polygon must have at least 3 sides");
	}

	int MaxNum = nums.Max();
	int Sum = 0;

	int maxIndex = Array.IndexOf(nums, MaxNum);

	var numsList = nums.ToList();

    for (int i = 0; i < nums.Length; i++)
	{
		// Somando todos elementos
		Sum += nums[i];
	}

	int Result = Sum - MaxNum;

	while (MaxNum > Result)
	{
		//nums = nums.Except(new int[] { maxIndex }).ToArray();

		numsList.Remove(MaxNum); // Assim não precisamos achar o indice
		Console.WriteLine(String.Join(",", numsList));

		for (int i = 0; i < numsList.Count; i++)
		{
			// Somando todos elementos
			Sum += numsList[i];
		}
		return Sum;


	}

	int Perimeter = Result + MaxNum;

	return Perimeter;
}

Console.WriteLine(LargestPerimeter([1, 12, 1, 2, 5, 50, 3]));