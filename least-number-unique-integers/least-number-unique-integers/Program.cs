// LEETCODE 1481.Least Number of Unique Integers after K Removals - Medium

// Given an array of integers arr and an integer k. Find the least number of unique integers after removing exactly k elements.



// Example 1: Input: arr = [5, 5, 4], k = 1
// Output: 1
// Explanation: Remove the single 4, only 5 is left.

// Example 2: Input: arr = [4, 3, 1, 1, 3, 3, 2], k = 3
// Output: 2
// Explanation: Remove 4, 2 and either one of the two 1s or three 3s. 1 and 3 will be left.

static int FindLeastNumOfUniqueInts(int[] arr, int k)
{

	var dict = new Dictionary<int, int>();

	for (var i = 0; i < arr.Length; i++)
	{
		if (dict.ContainsKey(arr[i]))
			dict[arr[i]]++;
		else
			dict.Add(arr[i], 1);
	}

	var sortedDict = dict.OrderBy(pair => pair.Value).ToList();

	foreach (var kvp in sortedDict)
	{
		if (k > 0)
		{
			if (k >= kvp.Value)
			{
				k -= kvp.Value;
				dict.Remove(kvp.Key);
			}
			else
			{
				dict[kvp.Key] -= k;
				k = 0;
			}
		}
		else
		{
			break;
		}
	}

	return dict.Count;

}

Console.WriteLine(FindLeastNumOfUniqueInts([4, 3, 1, 1, 3, 3, 2], 3));























// Comment: "least number of unique integers" means we want to minimize the number of distinct integers in the array.
// e.g. [5, 5, 1] has two distinct integers, 5 and 1. If we delete 1 we are left with [5, 5],
// meaning there is only one distinct integer: 5
// Try counting how many times each integer occurs,
// and greedily deleting from the integers with the lowest number of occurrences first.
// Suggestion: There are multiple ways to do this, I elected for bucket sort to achieve O(n) time complexity.

// Comment: Count the number of occurrences of each unique integer in the input array.
// Sort the list of counts in ascending order.
// Iterate through the sorted list of counts.
// If k is greater than or equal to the current count, subtract the current count from k.
// If k is less than the current count, set count to the number of remaining unique integers and break the loop.











// Solution n° 1
// Used a Priority Queue, Set and HashMap to.

// HashMap to store frequencies.
// Set to store the unique elements of the array.
// Priority Queue to store the elements by the order of frequency in ascending.
// Remove the least frequent element from the set till k becomes zero.
// If K becomes less than zero, that means we have removed an extra element. Add that element back.
// Return the size of the set.
