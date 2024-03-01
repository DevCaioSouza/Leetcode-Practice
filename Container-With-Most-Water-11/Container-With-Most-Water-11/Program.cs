
static int MaxArea(int[] height)
{

	int LeftP = 0;
	int RightP = height.Length - 1;
	int MaxArea = 0;

	while (LeftP < RightP)
	{
		int CurrArea = Math.Min(height[LeftP], height[RightP]) * (RightP - LeftP);

		MaxArea = Math.Max(MaxArea, CurrArea);
		if (height[RightP] > height[LeftP])
		{
			LeftP++;
		}
		else
		{
			RightP--;
		}
	}
	return MaxArea;
}

Console.WriteLine(MaxArea([1, 3, 2, 5, 25, 24, 5]));