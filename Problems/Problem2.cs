namespace ProjectEuler.Problems
{
	/// <summary>
	/// By considering the terms in the Fibonacci sequence
	/// whose values do not exceed four million,
	/// find the sum of the even-valued terms.
	/// </summary>
	public class Problem2 : IProblem
	{
		public string Solve()
		{
			var sum = 0;

			var previousNum = 0;
			var currentNum = 1;

			while (currentNum < 4000001)
			{
				var tempNum = currentNum;
				currentNum = previousNum + currentNum;
				previousNum = tempNum;

				if (currentNum % 2 == 0)
					sum += currentNum;
			}

			return sum.ToString();
		}
	}
}