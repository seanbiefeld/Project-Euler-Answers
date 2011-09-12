namespace ProjectEuler.Problems
{
	/// <summary>
	/// What is the largest prime factor of the number 600851475143 ?
	/// </summary>
	public class Problem3 : IProblem
	{
		public string Solve()
		{
			//assuming the largest prime is under 100000
			var primes = Calc.GetAllPrimes(100000);
			var largestPrime = 0;

			foreach (var prime in primes)
			{
				if (largestPrime < prime && 600851475143 % prime == 0)
					largestPrime = prime;
			}

			return largestPrime.ToString();
		}
	}
}