namespace ProjectEuler.Problems
{
	/// <summary>
	/// A palindromic number reads the same both ways.
	/// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91  99.
	/// Find the largest palindrome made from the product of two 3-digit numbers.
	/// </summary>
	public class Problem4 : IProblem
	{
		public string Solve()
		{
			int largestPalindrome = 0;

			for (int i = 100; i < 999; i++)
			{
				for (int j = 100; j < 999; j++)
				{
					var product = i*j;

					var productAsString = product.ToString();
					var array = productAsString.ToCharArray();
					string reversedProduct = null;

					for (int k = array.Length; k > 0; k--)
					{
						reversedProduct += array[k-1];
					}

					if(reversedProduct == productAsString)
					{
						if(largestPalindrome < product)
							largestPalindrome = product;
					}
				}
			}

			return largestPalindrome.ToString();
		}
	}
}