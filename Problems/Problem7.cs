namespace ProjectEuler.Problems
{
	/// <summary>
	/// What is the 10001st prime number?
	/// </summary>
	public class Problem7 : IProblem
	{
		public string Solve()
		{
			int counter = 2;
			int primeCounter = 1;

			while(primeCounter != 10001)
			{
				counter++;

				bool notPrime = false;
				for (int i = 2; i < counter; i++)
				{
					if(counter%i == 0)
					{
						notPrime = true;
						break;
					}
				}

				if(!notPrime)
					primeCounter++;
			}

			return counter.ToString();
		}
	}
}
