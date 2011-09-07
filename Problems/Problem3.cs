namespace ProjectEuler.Problems
{
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