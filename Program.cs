using System;

namespace ProjectEuler
{
	class Program
	{
		static void Main(string[] args)
		{
			int probNum = 0;

			var isValid = false;

			while (!isValid)
			{ isValid = int.TryParse(Console.ReadLine(), out probNum); }

			var type = Type.GetType("ProjectEuler.Problem" + probNum);

			if (type != null)
			{
				IProblem problem = (IProblem)Activator.CreateInstance(type);

				Console.WriteLine(problem.Solve());
			}
			else
			{
				Console.WriteLine("Unable to find specified problem");
			}

			Console.ReadLine();
		}
	}

	public interface IProblem
	{
		string Solve();
	}

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

	/// <summary>
	/// What is the largest prime factor of the number 600851475143 ?
	/// </summary>
	public class Problem3 : IProblem
	{
		public string Solve()
		{
			var k = 2;
			var n = 46;

			while (k * k <= n)
			{
				if (n % k == 0)
				{
					n /= k;
				}
				else
				{
					++k;
				}
			}

			return n.ToString();
		}
	}
}