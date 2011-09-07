namespace ProjectEuler.Problems
{
	public class Problem5 : IProblem
	{
		/// <summary>
		/// 2520 is the smallest number that can be divided by each of the numbers
		/// from 1 to 10 without any remainder.
		/// What is the smallest positive number that is evenly divisible
		/// by all of the numbers from 1 to 20? 
		/// </summary>
		/// <returns></returns>
		public string Solve()
		{
			var smallestNumberFound = false;
			var counter = 1;
			do
			{
				var divisibleByAll = true;

				for (int i = 1; i < 20; i++)
				{
					var mod = counter%i;

					if(mod != 0)
					{
						divisibleByAll = false;
						break;
					}

					divisibleByAll &= (counter%i == 0);
				}

				if(divisibleByAll)
				{
					smallestNumberFound = true;
				}
				else
				{
					counter++;
				}
			}
			while (!smallestNumberFound);

			return counter.ToString();
		}
	}
}