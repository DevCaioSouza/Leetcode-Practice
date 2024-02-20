
// 268.Missing Number (Easy)
// Given an array nums containing n distinct numbers in the range [0, n],
// return the only number in the range that is missing from the array.

//	Example: nums = [9, 6, 4, 2, 3, 5, 7, 0, 1]
// Output: 8
// Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0, 9].
// 8 is the missing number in the range since it does not appear in nums.

//Example: nums = [3, 0, 1]
//Output: 2

using System.Linq;

static int MissingNumber(int[] nums)
{
	Array.Sort(nums);

	var x = nums.Length;

	int[] newArr = Enumerable.Range(0, x+1).ToArray();

	int newArrSum = 0;
	int numsSum = 0;

	for (int i = 0; i<newArr.Length; i++)
	{
		newArrSum += newArr[i];
    }

	for (int j = 0; j<nums.Length; j++)
	{
		numsSum += nums[j];
	}

    var result = newArrSum - numsSum;

    return result;
}

Console.WriteLine(MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]));