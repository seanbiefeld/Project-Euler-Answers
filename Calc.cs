using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProjectEuler
{
	public static class Calc
	{
		public static ICollection<int> GetAllPrimes(int max)
		{
			Collection<int> primes = new Collection<int>();
			BitArray primeArray = PrimesBySieveOfEratosthenes(max);

			for (int i = 0; i < primeArray.Length; i++)
			{
				if (primeArray[i])
					primes.Add(i);
			}

			return primes;
		}

		public static BitArray PrimesBySieveOfEratosthenes(int max)
		{
			BitArray primeArray = new BitArray(max, true);

			primeArray[0] = false;
			primeArray[1] = false;

			for (double i = 2; i < Math.Sqrt(max); i++)
			{
				if (primeArray.Get((int)i))
				{
					for (double j = i * i; j < max; j += i)
					{
						primeArray.Set((int)j, false);
					}
				}
			}

			return primeArray;
		}
	}
}
