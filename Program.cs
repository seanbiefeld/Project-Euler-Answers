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

			var type = Type.GetType("ProjectEuler.Problems.Problem" + probNum);

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
}