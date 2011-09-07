using System;

namespace ProjectEuler.Problems
{
	public class Problem6 : IProblem
	{
		/// <summary>
		/// Find the difference between the sum of the squares
		/// of the first one hundred natural numbers and the square of the sum.
		/// </summary>
		/// <returns></returns>
		public string Solve()
		{
			var sumOfTheSquares = 0d;
			var sumOfNaturalNumbers = 0d;

			for (double i = 1; i <= 100; i++)
			{
				sumOfTheSquares += Math.Pow(i, 2d);
				sumOfNaturalNumbers +=i;
			}

			var squareOfTheSum = Math.Pow(sumOfNaturalNumbers, 2d);
			var difference = squareOfTheSum - sumOfTheSquares;

			return difference.ToString();
		}
	}
}
