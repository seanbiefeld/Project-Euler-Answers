using System;

namespace ProjectEuler
{
	class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				Console.WriteLine("Please enter problem number to continue or exit to leave.");
				var command = Console.ReadLine();
				if(command != null)
				{
					if(command.ToUpper() == "EXIT")
						break;
				}

				int probNum;
				if(!int.TryParse(command, out probNum))
					continue;

				var type = Type.GetType("ProjectEuler.Problems.Problem" + probNum);

				if (type != null)
				{
					IProblem problem = (IProblem) Activator.CreateInstance(type);

					var start = DateTime.Now;
					var answer = problem.Solve();
					var end = DateTime.Now;

					Console.WriteLine(answer);
					Console.WriteLine("Calculation took " + end.Subtract(start).TotalSeconds + " seconds");
				}
				else
				{
					Console.WriteLine("Unable to find specified problem");
				}
				Console.WriteLine();
			}
		}
	}

	public interface IProblem
	{
		string Solve();
	}
}