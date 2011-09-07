namespace ProjectEuler.Problems
{
	/// <summary>
	/// Find the sum of all the multiples of 3 or 5 below 1000.
	/// </summary>
	public class Problem1 : IProblem
	{
		public string Solve()
		{
			var sum = 0;

			for (int i = 0; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
					sum += i;
			}

			return sum.ToString();
		}
	}
}