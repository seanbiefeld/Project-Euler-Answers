using System;
using System.Collections;

namespace ProjectEuler.Problems
{
	/// <summary>
	/// Find the sum of all the primes below two million.
	/// </summary>
	public class Problem10 : IProblem
	{
		public string Solve()
		{
			double primeSum = 0;

			//brute force, takes too long
			//int counter = 2;
			//while(counter != 2000000)
			//{
			//    counter++;

			//    bool notPrime = false;
			//    for (int i = 2; i < counter; i++)
			//    {
			//        if(counter%i == 0)
			//        {
			//            notPrime = true;
			//            break;
			//        }
			//    }
			//    if(!notPrime)
			//        primeSum += counter;
			//}

			//sieve of eratosthenes
			//much faster
			var max = 2000001;
			BitArray primes = Calc.PrimesBySieveOfEratosthenes(max);

			for (int i = 0; i < primes.Length; i++)
			{
				if(primes.Get(i))
					primeSum+=i;
			}

			return primeSum.ToString();
		}
	}
}
