using System;

namespace ProjectEuler.Problems
{
	public class Problem9 : IProblem
	{
		/// <summary>
		/// A Pythagorean triplet is a set of three natural numbers, a  b  c, for which,
		/// a2 + b2 = c2
		/// For example, 32 + 42 = 9 + 16 = 25 = 52.
		/// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
		/// Find the product abc.
		/// </summary>
		/// <returns></returns>
		public string Solve()
		{
			var perimeter = 12;

			for (int a = 1; a <= perimeter; a++)
			{
				//brute force
				//for (int b = 1; b <= perimeter; b++)
				//{
				//    var cSquared = Math.Pow(a, 2) + Math.Pow(b, 2);
				//    var c = Math.Sqrt(cSquared);
				//    if(a+b+c == perimeter)
				//        return (a*b*c).ToString();
				//}	

				//using equation solving for b
				var denominator = (2*perimeter - 2*a);
				var enumerator = (Math.Pow(perimeter, 2) - (2*perimeter*a));

				var bMod = enumerator%denominator;
				//check for natural numbers
				if(bMod == 0)
				{
					var b = enumerator/denominator;
					var cSquared = Math.Pow(a, 2) + Math.Pow(b, 2);
					var c = Math.Sqrt(cSquared);

					if (a + b + c == perimeter)
						return (a*b*c).ToString();
				}
			}

			return "no natural numbers found";
		}
	}
}
