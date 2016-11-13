using System.Linq;

namespace Puzzles
{
	public static class Puzzles
	{
		public static int Multiply(int a, int b)
		{
			if (a < 0 && b < 0)
				return Multiply(-a, -b);

			var x = a > b ? a : b;
			var y = b > a ? a : b;
			var result = 0;

			for (var i = 0; i < y; i++)
				result += x;

			return result;
		}

		public static int[] RotateLeft(int[] input, int n)
		{
			var output = input.ToList().ConvertAll(x => x);
			for (var i = 0; i < n; i++)
			{
				var temp = output.First();
				output.Remove(temp);
				output.Insert(output.Count, temp);

			}

			return output.ToArray();
		}
	}
}
