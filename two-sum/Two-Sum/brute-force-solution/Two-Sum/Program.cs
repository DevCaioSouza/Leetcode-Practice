using System.Linq;

int[] TwoSum(int[] nums, int target)
{
	for (int i = 0; i < nums.Length; i++)
	{
		for (int j = i + 1; j < nums.Length; j++)
		{
			if (nums[i] + nums[j] == target)
			{
				return new int[] { i, j };
			}
		}
	}
	throw new Exception("Not found");
}
Console.WriteLine("Os índices do array que somados resultam no target é: " + string.Join(", ", TwoSum([1, 2, 7, 10, 23], 9)));

//Console.WriteLine("Resultado: " + TwoSum([1, 2, 7, 10, 23], 9));

//Testando Bug do git

public class Test
{
	bool test = true;
}